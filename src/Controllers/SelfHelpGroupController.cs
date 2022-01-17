using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WDPR_A.Models;
using WDPR_A.ViewModels;

namespace WDPR_A.Controllers;

[Authorize(Roles = "Client, Orthopedagogue")]
public class SelfHelpGroupController : Controller
{
    private readonly ILogger<SelfHelpGroupController> _logger;
    private readonly WDPRContext _context;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleSystem _roleSystem;
    private readonly ChatManager _chatManager;

    public SelfHelpGroupController(ILogger<SelfHelpGroupController> logger, WDPRContext context, UserManager<IdentityUser> userManager, RoleSystem roleSystem, ChatManager chatManager)
    {
        _logger = logger;
        _context = context;
        _userManager = userManager;
        _roleSystem = roleSystem;
        _chatManager = chatManager;
    }

    public async Task<IActionResult> Index(string roomName, AgeCategory? ageCategory)
    {
        IdentityUser user = await _userManager.GetUserAsync(User);

        var lijst = _context.Chats.Where(c => c.IsPrivate == false);

        if (User.IsInRole("Client"))
        {
            var currentUser = _context.Clients.Where(c => c.Id == user.Id).SingleOrDefault();
            lijst = lijst.Where(c => c.IsPrivate == false && c.Subject == currentUser.Condition);

            if (!String.IsNullOrEmpty(roomName))
            {
                lijst = lijst.Where(c => c.RoomName.Contains(roomName));
            }

            if (!String.IsNullOrEmpty(ageCategory.ToString()))
            {
                lijst = lijst.Where(c => c.AgeCategory == ageCategory);
            }

            if (!String.IsNullOrEmpty(roomName) && !String.IsNullOrEmpty(ageCategory.ToString()))
            {
                lijst = lijst.Where(c => c.IsPrivate == false && c.RoomName.Contains(roomName) && c.AgeCategory == ageCategory);
            }

            if (lijst.Count() == 0)
            {
                ViewData["Melding"] = "Er zijn helaas geen chats gevonden.";
            }
        }

        return View(await lijst.OrderBy(c => c.RoomName.ToLower()).Include(c => c.Clients).ToListAsync());
    }

    [Authorize(Roles = "Orthopedagogue")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Authorize(Roles = "Orthopedagogue")]
    public async Task<IActionResult> Create(string roomName, AgeCategory ageCategory)
    {
        IdentityUser user = await _userManager.GetUserAsync(User);
        var currentUser = _context.Orthopedagogues.Where(c => c.Id == user.Id).SingleOrDefault();

        await _chatManager.CreateSelfHelpChatAsync(currentUser, roomName, currentUser.Specialty, ageCategory);
        return RedirectToAction("Index");
    }

    [Authorize(Roles = "Client")]
    [HttpPost]
    public async Task<IActionResult> Join(string roomId)
    {
        IdentityUser user = await _userManager.GetUserAsync(User);
        var currentUser = _context.Clients.Where(c => c.Id == user.Id).SingleOrDefault();
        var chat = _context.Chats.FirstOrDefault(c => c.RoomId == roomId);
        chat.Clients.Add(currentUser);
        _context.SaveChanges();

        return RedirectToAction("Index", "Chat");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

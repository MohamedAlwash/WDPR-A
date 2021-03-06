using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using SendGrid;
using SendGrid.Helpers.Mail;

public class EmailSender
{
    private static string? _ApiKey { get; set; }

    public static async Task SendEmail(string receiver, string subject, string body)
    {
        var client = new SendGridClient(_ApiKey);
        var from = new EmailAddress("20119046@student.hhs.nl", "ZMDH Kliniek");  //Voer verzender email in
        var to = new EmailAddress(receiver, "Intakegesprek cliënt");
        var plainTextContent = "";
        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, body);
        var response = await client.SendEmailAsync(msg);
    }

    public static async Task SetApiKey(string kvUri, string secretName)
    {
        var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
        var secret = await client.GetSecretAsync(secretName);
        _ApiKey = secret.Value.Value;
    }

    public static Boolean ApiKeyIsNull()
    {

        return _ApiKey == null;
    }
}
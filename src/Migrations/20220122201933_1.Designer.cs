﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WDPR_A.Migrations
{
    [DbContext(typeof(WDPRContext))]
    [Migration("20220122201933_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("ChatClient", b =>
                {
                    b.Property<string>("ChatsRoomId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientsId")
                        .HasColumnType("TEXT");

                    b.HasKey("ChatsRoomId", "ClientsId");

                    b.HasIndex("ClientsId");

                    b.ToTable("ChatClient");
                });

            modelBuilder.Entity("ClientGuardian", b =>
                {
                    b.Property<string>("ClientsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GuardiansId")
                        .HasColumnType("TEXT");

                    b.HasKey("ClientsId", "GuardiansId");

                    b.HasIndex("GuardiansId");

                    b.ToTable("ClientGuardian");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "006c921b-611f-4cf9-a18c-3d722840ee42",
                            ConcurrencyStamp = "4eea6ee7-52c8-4fda-9aac-2bafc66e1b90",
                            Name = "Orthopedagogue",
                            NormalizedName = "ORTHOPEDAGOGUE"
                        },
                        new
                        {
                            Id = "26d89e3f-e47f-468b-bd78-6f58aef3285e",
                            ConcurrencyStamp = "47cfa19d-91e9-4750-8064-f0473b01978b",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "6e7321be-b891-44a3-abd8-71283880ddb9",
                            ConcurrencyStamp = "768ea407-2114-410d-b940-d319caeee57f",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        },
                        new
                        {
                            Id = "ede8d0e5-2581-476c-ba45-a99d7089844a",
                            ConcurrencyStamp = "f3f93e36-9b98-44c7-82d8-688d6957bc06",
                            Name = "Guardian",
                            NormalizedName = "GUARDIAN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "13198681-ef68-4acf-bd7e-544e12fed291",
                            RoleId = "26d89e3f-e47f-468b-bd78-6f58aef3285e"
                        },
                        new
                        {
                            UserId = "13198681-ef68-4acf-bd7e-544e12fed291",
                            RoleId = "006c921b-611f-4cf9-a18c-3d722840ee42"
                        },
                        new
                        {
                            UserId = "7d028f6c-929e-45b0-8493-573078b85f79",
                            RoleId = "26d89e3f-e47f-468b-bd78-6f58aef3285e"
                        },
                        new
                        {
                            UserId = "7d028f6c-929e-45b0-8493-573078b85f79",
                            RoleId = "006c921b-611f-4cf9-a18c-3d722840ee42"
                        },
                        new
                        {
                            UserId = "1988e216-9179-42a1-8243-2b6bf362b1b4",
                            RoleId = "26d89e3f-e47f-468b-bd78-6f58aef3285e"
                        },
                        new
                        {
                            UserId = "1988e216-9179-42a1-8243-2b6bf362b1b4",
                            RoleId = "006c921b-611f-4cf9-a18c-3d722840ee42"
                        },
                        new
                        {
                            UserId = "4e3371ca-b20a-4c91-b6c2-7c872c310a54",
                            RoleId = "26d89e3f-e47f-468b-bd78-6f58aef3285e"
                        },
                        new
                        {
                            UserId = "4e3371ca-b20a-4c91-b6c2-7c872c310a54",
                            RoleId = "006c921b-611f-4cf9-a18c-3d722840ee42"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WDPR_A.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("IncomingClientId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrthopedagogueId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IncomingClientId");

                    b.HasIndex("OrthopedagogueId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("WDPR_A.Models.Chat", b =>
                {
                    b.Property<string>("RoomId")
                        .HasColumnType("TEXT");

                    b.Property<int>("AgeCategory")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Condition")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrthopedagogueId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("RoomId");

                    b.HasIndex("OrthopedagogueId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("WDPR_A.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChatRoomId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ReportCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SenderId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("When")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChatRoomId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("WDPR_A.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("WDPR_A.Models.Client", b =>
                {
                    b.HasBaseType("WDPR_A.Models.User");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AgeCategory")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Residence")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("WDPR_A.Models.Guardian", b =>
                {
                    b.HasBaseType("WDPR_A.Models.User");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AppointmentId");

                    b.HasDiscriminator().HasValue("Guardian");
                });

            modelBuilder.Entity("WDPR_A.Models.Orthopedagogue", b =>
                {
                    b.HasBaseType("WDPR_A.Models.User");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Orthopedagogue");

                    b.HasData(
                        new
                        {
                            Id = "13198681-ef68-4acf-bd7e-544e12fed291",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "95a74eba-c530-4f43-a64a-f9518dabccfc",
                            Email = "kkemper@zmdh.nl",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "KKEMPER@ZMDH.NL",
                            NormalizedUserName = "KKEMPER@ZMDH.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAECliP0eZF/dtPcZTjNEfC7Sh+XjlLTW0LhuATCboH6s/1GZZsLvr9LiQEpMOLZ7pQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3c0a69cf-8b10-4e42-a97c-5729b0e309cc",
                            TwoFactorEnabled = false,
                            UserName = "kkemper@zmdh.nl",
                            FirstName = "Karin",
                            LastName = "Kemper",
                            Specialty = "ADHD"
                        },
                        new
                        {
                            Id = "7d028f6c-929e-45b0-8493-573078b85f79",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "47ef2b06-ec71-4118-82cd-e2847d9d8f73",
                            Email = "jlo@zmdh.nl",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JLO@ZMDH.NL",
                            NormalizedUserName = "JLO@ZMDH.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAECliP0eZF/dtPcZTjNEfC7Sh+XjlLTW0LhuATCboH6s/1GZZsLvr9LiQEpMOLZ7pQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4080b8c0-7f4e-4832-9ba8-b1c807c18e5f",
                            TwoFactorEnabled = false,
                            UserName = "jlo@zmdh.nl",
                            FirstName = "Johan",
                            LastName = "Lo",
                            Specialty = "Faalangst"
                        },
                        new
                        {
                            Id = "1988e216-9179-42a1-8243-2b6bf362b1b4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dbd74c86-8a80-4191-ba43-be9db3e42eec",
                            Email = "sito@zmdh.nl",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SITO@ZMDH.NL",
                            NormalizedUserName = "SITO@ZMDH.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAECliP0eZF/dtPcZTjNEfC7Sh+XjlLTW0LhuATCboH6s/1GZZsLvr9LiQEpMOLZ7pQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3f5c4959-ae96-44a9-ae68-c865af7cac56",
                            TwoFactorEnabled = false,
                            UserName = "sito@zmdh.nl",
                            FirstName = "Steven",
                            LastName = "Ito",
                            Specialty = "Eetstoornis"
                        },
                        new
                        {
                            Id = "4e3371ca-b20a-4c91-b6c2-7c872c310a54",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0f10d5fa-d056-4d1a-9877-69e9d1630f6d",
                            Email = "mvdijk@zmdh.nl",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MVDIJK@ZMDH.NL",
                            NormalizedUserName = "MVDIJK@ZMDH.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAECliP0eZF/dtPcZTjNEfC7Sh+XjlLTW0LhuATCboH6s/1GZZsLvr9LiQEpMOLZ7pQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "847dd826-1006-490c-9667-6ff7fb3c333c",
                            TwoFactorEnabled = false,
                            UserName = "mvdijk@zmdh.nl",
                            FirstName = "Marianne",
                            LastName = "van Dijk",
                            Specialty = "Dyslexie"
                        });
                });

            modelBuilder.Entity("ChatClient", b =>
                {
                    b.HasOne("WDPR_A.Models.Chat", null)
                        .WithMany()
                        .HasForeignKey("ChatsRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClientGuardian", b =>
                {
                    b.HasOne("WDPR_A.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.Guardian", null)
                        .WithMany()
                        .HasForeignKey("GuardiansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WDPR_A.Models.Appointment", b =>
                {
                    b.HasOne("WDPR_A.Models.Client", "IncomingClient")
                        .WithMany()
                        .HasForeignKey("IncomingClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.Orthopedagogue", "Orthopedagogue")
                        .WithMany("Appointments")
                        .HasForeignKey("OrthopedagogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IncomingClient");

                    b.Navigation("Orthopedagogue");
                });

            modelBuilder.Entity("WDPR_A.Models.Chat", b =>
                {
                    b.HasOne("WDPR_A.Models.Orthopedagogue", "Orthopedagogue")
                        .WithMany("Chats")
                        .HasForeignKey("OrthopedagogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orthopedagogue");
                });

            modelBuilder.Entity("WDPR_A.Models.Message", b =>
                {
                    b.HasOne("WDPR_A.Models.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("WDPR_A.Models.Guardian", b =>
                {
                    b.HasOne("WDPR_A.Models.Appointment", null)
                        .WithMany("Guardians")
                        .HasForeignKey("AppointmentId");
                });

            modelBuilder.Entity("WDPR_A.Models.Appointment", b =>
                {
                    b.Navigation("Guardians");
                });

            modelBuilder.Entity("WDPR_A.Models.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("WDPR_A.Models.Orthopedagogue", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Chats");
                });
#pragma warning restore 612, 618
        }
    }
}

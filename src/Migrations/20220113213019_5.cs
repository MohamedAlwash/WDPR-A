﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WDPR_A.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67c69e6f-6ef0-46ed-97be-0a0be1560669");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf0862d1-ec8a-4e1d-8db3-23f8d190b97c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1c33788-60c1-4ee3-8345-97b2d4f8c860");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de14abad-0c58-4c88-8904-2021913dcb42");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrthopedagogueWebText", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "SecurityStamp", "Specialty", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3efb8f49-df36-48ac-933f-6e0bad7eeb5c", 0, "8cea5b2f-4bef-435f-9c25-b905195c5627", "Orthopedagogue", null, false, "Steven", "Ito", false, null, null, null, "Even voorstellen   \r\n Mijn naam is Steven Ito, ik ben geboren in 1987 in het hartje van Amsterdam. Mijn ouders hadden allebei een medische achtergrond en komen oorspronkelijk uit Japan. Ik heb al sinds mijn jeugd een passie gehad voor de medische wereld en het helpen van mensen, specifiek de jongeren. Omdat het mij interesseert hoe jongeren hun leven leiden. \r\n\r\n \r\nMijn studie   \r\n Na het VWO heb ik orthopedagogiek gestudeerd aan de Universiteit van Amsterdam. Bij mijn afstuderen heb ik mij gespecialiseerd in de behandeling van eetstoornissen. Daarna heb ik nog een tweejarig masterprogramma gevolgd in het buitenland op de Medische Universiteit van Tokyo. \r\n\r\n \r\nNu over jou: jij hebt misschien een eetstoornis  \r\n Bij jou bestaat het vermoeden dat je een eetstoornis hebt. Soms wordt gedacht dat er maar één eetstoornis is. Maar dit klopt niet, want er zijn verschillende soorten zoals: boulimia, anorexia en Binge Eating Disorder (BED). Sommige eetstoornissen zijn niet altijd zichtbaar en worden daarom ook ‘onzichtbare eetstoornissen’ genoemd. Als het goed is merk je dat je een verstoord en onregelmatig eetgedrag hebt. Dit wordt gekenmerkt dat er soms te weinig wordt gegeten en in andere perioden juist te veel wordt gegeten. Het heeft voornamelijk te maken met een verstoord lichaamsbeeld. Misschien heb je gemerkt dat je een angst hebt om dik te worden of juist om dun te worden, toch? Verder zijn er lichamelijke klachten zoals misselijkheid of maagpijn. Daarnaast herken je misschien dat je liever niet wilt eten als andere mensen in de buurt zijn. \r\n\r\n  \r\n\r\n \r\nWat gaan we doen?   \r\n\r\nIk ga met jou samen onderzoeken of jij een eetstoornis hebt met een paar testen, waarbij eventueel jouw ouder(s)/verzorger(s) betrokken worden. Mocht blijken uit de resultaten dat je toch een eetstoornis hebt. Dan zullen we samen bekijken waar jij moeite mee hebt of tegen aanloopt. We zullen dan samen stap-voor-stap ervoor zorgen dat we jouw eetstoornis en verstoord lichaamsbeeld verhelpen. \r\n\r\nDaarna gaan we met elkaar aan de slag en probeer ik je verder te helpen met tips en oefeningen, die laagdrempelig zijn, wat vooral prettig is voor jou.   \r\n Er zal in het proces veel humor en gezelligheid zijn. We gaan niet te ingewikkeld doen, maar onze mouwen opstropen en aan het werk met jouw grootste uitdagingen is de missie waaraan wij gaan werken.   \r\n\r\nJe bent van harte welkom. Ik help je heel graag. Wil je eerst nog meer informatie; bel of mail me gerust. We plannen in ieder geval een intakegesprek in om te zien of wij graag met elkaar verder willen. Daarna kun je je eventueel in overleg met je ouder(s)/verzorger(s)-inschrijven voor een behandeling. \r\n\r\n \r\n\r\nHoe meld ik mij aan? \r\n\r\nJe kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na de intakegesprek ben je succesvol aangemeld. \r\n\r\n \r\n\r\n \r\n\r\nHoe kan ik chatten met mijn hulpverlener? \r\n\r\nNa de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar stevenito@ZMDH.nl \r\n\r\n \r\n\r\nHoe kan ik deelnemen aan de groepschat? \r\n\r\nNa de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. ", null, null, false, "https://i.postimg.cc/bNbyP9RF/Steven-Ito-Orthopedagoog.png", "7214845a-1957-43b0-8767-ea4bac92356c", "Eetstoornis", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrthopedagogueWebText", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "SecurityStamp", "Specialty", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4eed38c5-6dd6-498d-a92b-baaee4d0f0cf", 0, "adf9809d-9cb6-4f93-8694-31d75a3f2768", "Orthopedagogue", null, false, "Karin", "Kemper", false, null, null, null, "<article>\r\n    <h2>Even voorstellen</h2>\r\n    <section>Ik heet Karin Kemper, geboren in 1972 in Almere en ben het enige kind.  Mijn vader is Argentijns en mijn moeder is Nederlands. Ik ben heel nieuwsgierig naar mensen met ADHD; naar wat hun motiveert, wat hun concentratievermogen is en hoe ik ze persoonlijk kan helpen. Toen ik jong was begon ik al met hulp aanbieden bij kinderen met ADHD. </section>\r\n</article>\r\n\r\n\r\n <article>\r\n     <h2>Mijn studie   </h2>\r\n     <section>Na het behalen van mijn gymnasium ging ik werken in de Albert Heijn om geld te verdienen voor mijn opleiding. Hierna had ik orthopedagogiek gestudeerd aan de Universiteit van Leiden. Tijdens mijn studie heb ik mij gespecialiseerd in de behandeling van ADHD en had een bijbaantje als bezorger. </section>\r\n </article>\r\n\r\n <article>\r\n     <h2>Nu over jou: jij hebt misschien ADHD </h2>\r\n     <section>Bij jou bestaat het vermoeden dat je ADHD hebt. Als je ADHD hebt, heb je moeite om je aandacht bij iets te houden en dat je te druk bent. Bij ADHD word je afgeleid bij alle prikkels die bij jou binnenkomen en dat je je dan ook druk gedraagt. De gevolgen hiervan zijn dat je de informatie niet goed onthoudt en je misschien andere mensen lastigvalt zonder dat je, het door hebt. \r\n    </section>\r\n </article>\r\n\r\n <article>\r\n    <h2>Wat gaan we doen?  </h2>\r\n    <section>Ik ga met jou uitzoeken of jij ADHD hebt met een paar gesprekken waarbij evt. ook jouw ouder(s)/verzorger(s) betrokken worden. Mocht het blijken dat je ADHD hebt kijken we samen naar de problemen die je ervaart en hoe we dat stap voor stap kunnen oplossen.  Ik ga mijn uiterst best doen om je te helpen concentreren en je te kalmeren.  \r\n\r\n        Allereerst luister ik graag actief naar je. Dit betekent dat ik tijdens het luisteren ook vragen ga stellen. Dit is om meer inzicht te krijgen in hoe ik jou kan helpen.  \r\n        \r\n        Wil je eerst nog meer informatie; bel, app of mail me gerust. We plannen in ieder geval een intakegesprek om elkaar beter te leren kennen. Daarna kun je je evt.-in overleg met je ouder(s)/verzorger(s)-inschrijven voor een behandeling. </section>\r\n</article>\r\n\r\n<article>\r\n    <h2>Hoe meld ik mij aan? </h2>\r\n    <section>Je kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na het intakegesprek ben je succesvol aangemeld. \r\n    </section>\r\n</article>\r\n\r\n<article>\r\n    <h2>Hoe kan ik chatten met mijn hulpverlener? \r\n    </h2>\r\n    <section>Na de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar karinkemper@ZMDH.nl \r\n    </section>\r\n</article>\r\n\r\n<article>\r\n    <h2>Hoe kan ik deelnemen aan de groepschat? </h2>\r\n    <section>Na de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. </section>\r\n</article>\r\n", null, null, false, "https://i.postimg.cc/tRPnMpWP/Karin-Kemper-Orthopedagoog.png", "fda8146b-e873-4768-a6da-65b5282ccdec", "ADHD", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrthopedagogueWebText", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "SecurityStamp", "Specialty", "TwoFactorEnabled", "UserName" },
                values: new object[] { "63a9b842-7e2a-4e1f-a14d-b986bcc9bf6c", 0, "d3d23bec-f503-4c72-a798-ec4883f9b525", "Orthopedagogue", null, false, "Marianne", "van Dijk", false, null, null, null, "Even voorstellen \r\n<strong>test</strong>\r\nHallo, ik ben Marianne van Dijk geboren en getogen in Rotterdam. Vanaf kleins af aan vind ik het altijd leuk om kinderen te helpen, ik haal hier namelijk mijn voldoening uit. Verder ben ik een moeder van drie kinderen, waarvan er een dyslexie heeft. Zelf heb ik ook dyslexie. Misschien valt het je op dat dyslexie een onderwerp is wat regelmatig in mijn leven ter sprake komt, hierdoor wil ik graag mijn ervaring delen met kinderen die hulp willen. \r\n\r\n \r\n\r\nMijn studie \r\n\r\nOmdat ik moeite had met lezen liep ik veel achterstand. Ik ben vanaf VMBO Basis begonnen en door de jaren heen ben ik verder gaan studeren. Uiteindelijk heb ik de opleiding orthopedagogiek afgerond aan de Universiteit van Leiden. \r\n\r\n \r\n\r\nNu over jou: Jij hebt misschien dyslexie \r\n\r\nDyslexie hebben is niet prettig. Het maakt lezen, spellen en schrijven veel ingewikkelder, terwijl iemand wel intelligent genoeg is om dat allemaal te begrijpen. Er is pas sprake van dyslexie als er geen andere oorzaken zijn die de leesproblemen kunnen verklaren. \r\n\r\n \r\n\r\nNiet elke kind dat dyslexie heeft, heeft moeite met spelling en lezen. Sommige kinderen hebben vooral problemen met het lezen en anderen met spelling. Zo heb je bijvoorbeeld kinderen die radend lezen, waardoor ze veel fouten maken doordat ze gokken wat er staat. Anderen lezen letter voor letter, waardoor het leestempo heel laag ligt. \r\n\r\n \r\n\r\nWat gaan we doen? \r\n\r\nSamen gaan we uitzoeken of jij dyslexie hebt. Dat doen we door verschillende soorten testen uit te voeren. Bij het uitvoeren van de testen merk ik vanzelf of jij symptomen hebt. Het zijn testen, zoals het hardop lezen van teksten of het uitspreken van klanken en letters. \r\n\r\nWat we vooral merken is dat je moeite hebt met het verschil te horen tussen klanken als: ‘m’, ‘n’, en ‘ng’, of ‘eu’, ‘uu’ en ‘ui’. Of je hebt moeite om op woorden te komen. En zo zijn er nog andere symptomen. \r\n\r\nJe bent van harte welkom en ik wil je graag bij helpen om mee om te gaan. Je kan mij altijd gerust bereiken voor meer informatie of uitleg door mij te bellen of te mailen. We maken eerst een intakegesprek zodat wij zien of we met elkaar verder willen. En uiteraard kun je je eventueel in overleg met je ouder(s)/verzorg(s) inschrijven voor een behandeling. \r\n\r\nHoe meld ik mij aan? \r\n\r\nJe kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na de intakegesprek ben je succesvol aangemeld. \r\n\r\n \r\n\r\n \r\n\r\nHoe kan ik chatten met mijn hulpverlener? \r\n\r\nNa de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar mariannevandijk@ZMDH.nl \r\n\r\n \r\n\r\nHoe kan ik deelnemen aan de groepschat? \r\n\r\nNa de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. ", null, null, false, "https://i.postimg.cc/wTSpbR8c/Marianne-Van-Dijk-Orthopedagoog.png", "a0b36dce-fd92-45a2-b703-e0e5d798c346", "Dyslexie", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrthopedagogueWebText", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "SecurityStamp", "Specialty", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8dae537f-7253-4b4f-831b-1f3c5439bedd", 0, "eed546f6-d48c-4c86-8b46-b94e9bedbbd7", "Orthopedagogue", null, false, "Johan", "Lo", false, null, null, null, "Even voorstellen \r\n\r\nIk heet Johan Lo, geboren in 1990 in Rotterdam en de jongste van zes kinderen. Ik ben opgegroeid bij de haven door mijn ouders. Ik verdiep me in de laatste trends van jongeren en vind het interessant hoe de huidige generatie van jongeren zicht inzet voor belangrijke maatschappelijke problemen, zoals klimaatverandering. Jongs af aan probeerde ik jongeren te motiveren om dingen te doen waar ze bang voor zijn.  \r\n \r\n\r\nMijn studie   \r\nNa het VWO begon ik met stand up comedy en werkte ik twee jaar lang als een motiverende spreker bij verschillende bedrijven en evenementen. Hierna had ik orthopedagogiek gestudeerd aan de Universiteit van Cambridge. Tijdens mijn studie heb ik mij gespecialiseerd in de behandeling van faalangst.  \r\n \r\n\r\nNu over jou: jij hebt misschien faalangst   \r\nBij jou bestaat het vermoeden dat je faalangst hebt. Veelal gaat dit over het uitvoeren van iets concreets zoals een taak, een examen, een werkopdracht en dergelijke. De gevolgen hiervan is dat je vaker faalervaring ervaart.  \r\n \r\n\r\nWat gaan we doen?   \r\nIk ga met jou uitzoeken of jij faalangst hebt met een paar gesprekken waarbij evt. ook jouw ouder(s)/verzorger(s) betrokken worden. Mocht het blijken dat je faalangst hebt kijken we samen naar de problemen die je ervaart en hoe we dat stap voor stap kunnen oplossen. Met therapie kan ik je helpen om sterker te staan in je schoenen en een positiever beeld te creëren over jezelf. \r\nAllereerst luister ik graag aandachtig naar je. Ik ben namelijk een actieve luisteraar en beantwoord graag vragen die je hebt. Daarna ga ik een gesprek met je aan om te kijken waarom je faalangst ervaart. We gaan ook je faalangst confronteren met positieve denkpatronen. Wil je eerst nog meer informatie; bel, app of mail me gerust. We plannen in ieder geval een intakegesprek om elkaar beter te leren kennen. Daarna kun je je evt.-in overleg met je ouder(s)/verzorger(s)-inschrijven voor een behandeling. \r\n\r\n \r\n\r\nHoe meld ik mij aan? \r\n\r\nJe kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na de intakegesprek ben je succesvol aangemeld. \r\n\r\n \r\n\r\n \r\n\r\nHoe kan ik chatten met mijn hulpverlener? \r\n\r\nNa de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar johanlo@ZMDH.nl \r\n\r\n \r\n\r\nHoe kan ik deelnemen aan de groepschat? \r\n\r\nNa de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. ", null, null, false, "https://i.postimg.cc/9fwqH7rm/Johan-Lo-Orthopedagoog.png", "558d805d-8b07-4fcb-b81a-57bf4313b67d", "Faalangst", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3efb8f49-df36-48ac-933f-6e0bad7eeb5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4eed38c5-6dd6-498d-a92b-baaee4d0f0cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63a9b842-7e2a-4e1f-a14d-b986bcc9bf6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8dae537f-7253-4b4f-831b-1f3c5439bedd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrthopedagogueWebText", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "SecurityStamp", "Specialty", "TwoFactorEnabled", "UserName" },
                values: new object[] { "67c69e6f-6ef0-46ed-97be-0a0be1560669", 0, "b816d0b3-264e-4dbf-bd36-58d92201e731", "Orthopedagogue", null, false, "Karin", "Kemper", false, null, null, null, "<h2>Even voorstellen</h2>									 \r\nIk heet Karin Kemper, geboren in 1972 in Almere en ben het enige kind.  Mijn vader is Argentijns en mijn moeder is Nederlands. Ik ben heel nieuwsgierig naar mensen met ADHD; naar wat hun motiveert, wat hun concentratievermogen is en hoe ik ze persoonlijk kan helpen. Toen ik jong was begon ik al met hulp aanbieden bij kinderen met ADHD. \r\n \r\n\r\nMijn studie   \r\nNa het behalen van mijn gymnasium ging ik werken in de Albert Heijn om geld te verdienen voor mijn opleiding. Hierna had ik orthopedagogiek gestudeerd aan de Universiteit van Leiden. Tijdens mijn studie heb ik mij gespecialiseerd in de behandeling van ADHD en had een bijbaantje als bezorger. \r\n \r\n\r\nNu over jou: jij hebt misschien ADHD \r\nBij jou bestaat het vermoeden dat je ADHD hebt. Als je ADHD hebt, heb je moeite om je aandacht bij iets te houden en dat je te druk bent. Bij ADHD word je afgeleid bij alle prikkels die bij jou binnenkomen en dat je je dan ook druk gedraagt. De gevolgen hiervan zijn dat je de informatie niet goed onthoudt en je misschien andere mensen lastigvalt zonder dat je, het door hebt. \r\n\r\n \r\n\r\nWat gaan we doen?   \r\nIk ga met jou uitzoeken of jij ADHD hebt met een paar gesprekken waarbij evt. ook jouw ouder(s)/verzorger(s) betrokken worden. Mocht het blijken dat je ADHD hebt kijken we samen naar de problemen die je ervaart en hoe we dat stap voor stap kunnen oplossen.  Ik ga mijn uiterst best doen om je te helpen concentreren en je te kalmeren.  \r\n\r\nAllereerst luister ik graag actief naar je. Dit betekent dat ik tijdens het luisteren ook vragen ga stellen. Dit is om meer inzicht te krijgen in hoe ik jou kan helpen.  \r\n\r\nWil je eerst nog meer informatie; bel, app of mail me gerust. We plannen in ieder geval een intakegesprek om elkaar beter te leren kennen. Daarna kun je je evt.-in overleg met je ouder(s)/verzorger(s)-inschrijven voor een behandeling. \r\n\r\n \r\n\r\nHoe meld ik mij aan? \r\n\r\nJe kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na het intakegesprek ben je succesvol aangemeld. \r\n\r\n \r\n\r\n \r\n\r\nHoe kan ik chatten met mijn hulpverlener? \r\n\r\nNa de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar karinkemper@ZMDH.nl \r\n\r\n \r\n\r\nHoe kan ik deelnemen aan de groepschat? \r\n\r\nNa de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. ", null, null, false, "https://i.postimg.cc/tRPnMpWP/Karin-Kemper-Orthopedagoog.png", "c71be8a8-198a-4015-9595-e251ffb8213e", "ADHD", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrthopedagogueWebText", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "SecurityStamp", "Specialty", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bf0862d1-ec8a-4e1d-8db3-23f8d190b97c", 0, "2028a1c2-9ea0-481b-8f0f-7fcf616a3469", "Orthopedagogue", null, false, "Johan", "Lo", false, null, null, null, "Even voorstellen \r\n\r\nIk heet Johan Lo, geboren in 1990 in Rotterdam en de jongste van zes kinderen. Ik ben opgegroeid bij de haven door mijn ouders. Ik verdiep me in de laatste trends van jongeren en vind het interessant hoe de huidige generatie van jongeren zicht inzet voor belangrijke maatschappelijke problemen, zoals klimaatverandering. Jongs af aan probeerde ik jongeren te motiveren om dingen te doen waar ze bang voor zijn.  \r\n \r\n\r\nMijn studie   \r\nNa het VWO begon ik met stand up comedy en werkte ik twee jaar lang als een motiverende spreker bij verschillende bedrijven en evenementen. Hierna had ik orthopedagogiek gestudeerd aan de Universiteit van Cambridge. Tijdens mijn studie heb ik mij gespecialiseerd in de behandeling van faalangst.  \r\n \r\n\r\nNu over jou: jij hebt misschien faalangst   \r\nBij jou bestaat het vermoeden dat je faalangst hebt. Veelal gaat dit over het uitvoeren van iets concreets zoals een taak, een examen, een werkopdracht en dergelijke. De gevolgen hiervan is dat je vaker faalervaring ervaart.  \r\n \r\n\r\nWat gaan we doen?   \r\nIk ga met jou uitzoeken of jij faalangst hebt met een paar gesprekken waarbij evt. ook jouw ouder(s)/verzorger(s) betrokken worden. Mocht het blijken dat je faalangst hebt kijken we samen naar de problemen die je ervaart en hoe we dat stap voor stap kunnen oplossen. Met therapie kan ik je helpen om sterker te staan in je schoenen en een positiever beeld te creëren over jezelf. \r\nAllereerst luister ik graag aandachtig naar je. Ik ben namelijk een actieve luisteraar en beantwoord graag vragen die je hebt. Daarna ga ik een gesprek met je aan om te kijken waarom je faalangst ervaart. We gaan ook je faalangst confronteren met positieve denkpatronen. Wil je eerst nog meer informatie; bel, app of mail me gerust. We plannen in ieder geval een intakegesprek om elkaar beter te leren kennen. Daarna kun je je evt.-in overleg met je ouder(s)/verzorger(s)-inschrijven voor een behandeling. \r\n\r\n \r\n\r\nHoe meld ik mij aan? \r\n\r\nJe kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na de intakegesprek ben je succesvol aangemeld. \r\n\r\n \r\n\r\n \r\n\r\nHoe kan ik chatten met mijn hulpverlener? \r\n\r\nNa de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar johanlo@ZMDH.nl \r\n\r\n \r\n\r\nHoe kan ik deelnemen aan de groepschat? \r\n\r\nNa de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. ", null, null, false, "https://i.postimg.cc/9fwqH7rm/Johan-Lo-Orthopedagoog.png", "82fe67aa-fb3f-45ab-8ae2-7b6ba85d8b46", "Faalangst", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrthopedagogueWebText", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "SecurityStamp", "Specialty", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c1c33788-60c1-4ee3-8345-97b2d4f8c860", 0, "d095c25d-7c76-47cd-bb85-2c9fa39b4a4d", "Orthopedagogue", null, false, "Marianne", "van Dijk", false, null, null, null, "Even voorstellen \r\n<strong>test</strong>\r\nHallo, ik ben Marianne van Dijk geboren en getogen in Rotterdam. Vanaf kleins af aan vind ik het altijd leuk om kinderen te helpen, ik haal hier namelijk mijn voldoening uit. Verder ben ik een moeder van drie kinderen, waarvan er een dyslexie heeft. Zelf heb ik ook dyslexie. Misschien valt het je op dat dyslexie een onderwerp is wat regelmatig in mijn leven ter sprake komt, hierdoor wil ik graag mijn ervaring delen met kinderen die hulp willen. \r\n\r\n \r\n\r\nMijn studie \r\n\r\nOmdat ik moeite had met lezen liep ik veel achterstand. Ik ben vanaf VMBO Basis begonnen en door de jaren heen ben ik verder gaan studeren. Uiteindelijk heb ik de opleiding orthopedagogiek afgerond aan de Universiteit van Leiden. \r\n\r\n \r\n\r\nNu over jou: Jij hebt misschien dyslexie \r\n\r\nDyslexie hebben is niet prettig. Het maakt lezen, spellen en schrijven veel ingewikkelder, terwijl iemand wel intelligent genoeg is om dat allemaal te begrijpen. Er is pas sprake van dyslexie als er geen andere oorzaken zijn die de leesproblemen kunnen verklaren. \r\n\r\n \r\n\r\nNiet elke kind dat dyslexie heeft, heeft moeite met spelling en lezen. Sommige kinderen hebben vooral problemen met het lezen en anderen met spelling. Zo heb je bijvoorbeeld kinderen die radend lezen, waardoor ze veel fouten maken doordat ze gokken wat er staat. Anderen lezen letter voor letter, waardoor het leestempo heel laag ligt. \r\n\r\n \r\n\r\nWat gaan we doen? \r\n\r\nSamen gaan we uitzoeken of jij dyslexie hebt. Dat doen we door verschillende soorten testen uit te voeren. Bij het uitvoeren van de testen merk ik vanzelf of jij symptomen hebt. Het zijn testen, zoals het hardop lezen van teksten of het uitspreken van klanken en letters. \r\n\r\nWat we vooral merken is dat je moeite hebt met het verschil te horen tussen klanken als: ‘m’, ‘n’, en ‘ng’, of ‘eu’, ‘uu’ en ‘ui’. Of je hebt moeite om op woorden te komen. En zo zijn er nog andere symptomen. \r\n\r\nJe bent van harte welkom en ik wil je graag bij helpen om mee om te gaan. Je kan mij altijd gerust bereiken voor meer informatie of uitleg door mij te bellen of te mailen. We maken eerst een intakegesprek zodat wij zien of we met elkaar verder willen. En uiteraard kun je je eventueel in overleg met je ouder(s)/verzorg(s) inschrijven voor een behandeling. \r\n\r\nHoe meld ik mij aan? \r\n\r\nJe kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na de intakegesprek ben je succesvol aangemeld. \r\n\r\n \r\n\r\n \r\n\r\nHoe kan ik chatten met mijn hulpverlener? \r\n\r\nNa de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar mariannevandijk@ZMDH.nl \r\n\r\n \r\n\r\nHoe kan ik deelnemen aan de groepschat? \r\n\r\nNa de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. ", null, null, false, "https://i.postimg.cc/wTSpbR8c/Marianne-Van-Dijk-Orthopedagoog.png", "e4916159-331a-44bb-888e-40ebdfe36880", "Dyslexie", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrthopedagogueWebText", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "SecurityStamp", "Specialty", "TwoFactorEnabled", "UserName" },
                values: new object[] { "de14abad-0c58-4c88-8904-2021913dcb42", 0, "de51fbd1-4d34-4f72-8439-c2aa29bd54f1", "Orthopedagogue", null, false, "Steven", "Ito", false, null, null, null, "Even voorstellen   \r\n Mijn naam is Steven Ito, ik ben geboren in 1987 in het hartje van Amsterdam. Mijn ouders hadden allebei een medische achtergrond en komen oorspronkelijk uit Japan. Ik heb al sinds mijn jeugd een passie gehad voor de medische wereld en het helpen van mensen, specifiek de jongeren. Omdat het mij interesseert hoe jongeren hun leven leiden. \r\n\r\n \r\nMijn studie   \r\n Na het VWO heb ik orthopedagogiek gestudeerd aan de Universiteit van Amsterdam. Bij mijn afstuderen heb ik mij gespecialiseerd in de behandeling van eetstoornissen. Daarna heb ik nog een tweejarig masterprogramma gevolgd in het buitenland op de Medische Universiteit van Tokyo. \r\n\r\n \r\nNu over jou: jij hebt misschien een eetstoornis  \r\n Bij jou bestaat het vermoeden dat je een eetstoornis hebt. Soms wordt gedacht dat er maar één eetstoornis is. Maar dit klopt niet, want er zijn verschillende soorten zoals: boulimia, anorexia en Binge Eating Disorder (BED). Sommige eetstoornissen zijn niet altijd zichtbaar en worden daarom ook ‘onzichtbare eetstoornissen’ genoemd. Als het goed is merk je dat je een verstoord en onregelmatig eetgedrag hebt. Dit wordt gekenmerkt dat er soms te weinig wordt gegeten en in andere perioden juist te veel wordt gegeten. Het heeft voornamelijk te maken met een verstoord lichaamsbeeld. Misschien heb je gemerkt dat je een angst hebt om dik te worden of juist om dun te worden, toch? Verder zijn er lichamelijke klachten zoals misselijkheid of maagpijn. Daarnaast herken je misschien dat je liever niet wilt eten als andere mensen in de buurt zijn. \r\n\r\n  \r\n\r\n \r\nWat gaan we doen?   \r\n\r\nIk ga met jou samen onderzoeken of jij een eetstoornis hebt met een paar testen, waarbij eventueel jouw ouder(s)/verzorger(s) betrokken worden. Mocht blijken uit de resultaten dat je toch een eetstoornis hebt. Dan zullen we samen bekijken waar jij moeite mee hebt of tegen aanloopt. We zullen dan samen stap-voor-stap ervoor zorgen dat we jouw eetstoornis en verstoord lichaamsbeeld verhelpen. \r\n\r\nDaarna gaan we met elkaar aan de slag en probeer ik je verder te helpen met tips en oefeningen, die laagdrempelig zijn, wat vooral prettig is voor jou.   \r\n Er zal in het proces veel humor en gezelligheid zijn. We gaan niet te ingewikkeld doen, maar onze mouwen opstropen en aan het werk met jouw grootste uitdagingen is de missie waaraan wij gaan werken.   \r\n\r\nJe bent van harte welkom. Ik help je heel graag. Wil je eerst nog meer informatie; bel of mail me gerust. We plannen in ieder geval een intakegesprek in om te zien of wij graag met elkaar verder willen. Daarna kun je je eventueel in overleg met je ouder(s)/verzorger(s)-inschrijven voor een behandeling. \r\n\r\n \r\n\r\nHoe meld ik mij aan? \r\n\r\nJe kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na de intakegesprek ben je succesvol aangemeld. \r\n\r\n \r\n\r\n \r\n\r\nHoe kan ik chatten met mijn hulpverlener? \r\n\r\nNa de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar stevenito@ZMDH.nl \r\n\r\n \r\n\r\nHoe kan ik deelnemen aan de groepschat? \r\n\r\nNa de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. ", null, null, false, "https://i.postimg.cc/bNbyP9RF/Steven-Ito-Orthopedagoog.png", "744eb686-c444-4cf3-b556-9078c3949b2f", "Eetstoornis", false, null });
        }
    }
}

using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;


Console.Write("Webhook: ");
var Webhook = Console.ReadLine();

Console.Write("Name: ");
var Name = Console.ReadLine();

Console.Write("Message Text: ");
var Message = Console.ReadLine();

Console.Write("Profile Pic: ");
var Pfp = Console.ReadLine();

/// String str = $"{FileName}.{FileType}";

try
{
    Console.WriteLine(Name + ": " + Message);
}
catch
{
    Console.WriteLine("How did u fail this???");
}

static void sendDiscordWebhook(string URL, string profilepic, string username, string message)
{
    NameValueCollection discordValues = new NameValueCollection();
    discordValues.Add("username", username);
    discordValues.Add("avatar_url", profilepic);
    discordValues.Add("content", message);
    new WebClient().UploadValues(URL, discordValues);
}

try
{
        sendDiscordWebhook(Webhook, Pfp, Name, Message);
}
catch
{
     Console.WriteLine("Just how..???");
}

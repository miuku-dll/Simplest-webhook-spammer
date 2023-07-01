using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;

class Program
{

    public static void error101() // Easier Re-using
    {
        Console.WriteLine("Error, Restarting...");
        Thread.Sleep(3000);
        Console.Clear();
    }

    static void Main(string[] args) // The code that spams the webhook
    {
    Start:

        Console.Write("Webhook: ");
        var Webhook = Console.ReadLine();

        Console.Write("Name: ");
        var Name = Console.ReadLine();

        Console.Write("Message Text: ");
        var Message = Console.ReadLine();

        Console.Write("Profile Pic: ");
        var Pfp = Console.ReadLine();

        Console.Write("How many times to send: ");
        var Times = Console.ReadLine();
        int RealTimes = Convert.ToInt32(Times);



        // String str = $"{FileName}.{FileType}";

        try
        {
            Console.WriteLine(Name + ": " + Message);
        }
        catch
        {
            error101();
            goto Start;
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
            for (int i = 0; i < RealTimes; i++) // Probably not the fastest way to loop stuff but works fine 🤷
            {
                Console.WriteLine(i); // Im stupid so i like to see how many messages ive sent
                sendDiscordWebhook(Webhook, Pfp, Name, Message);
                // sendDiscordWebhook(Webhook, Pfp, Name, (Message + i)); <-- If you want to include the number of the message
            }
        }
        catch
        {
            error101();
            goto Start;
        }

        try
        {
            Console.WriteLine("Messages sent, returning to start...");
            Thread.Sleep(3000);
            Console.Clear();
            goto Start;
        }
        catch
        {
            error101();
            goto Start;
        }
    }
}

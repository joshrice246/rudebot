using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class RudeChatBot
{
    private Dictionary<string, string> wordbank = new Dictionary<string, string>()
    {
         { "hello", "\nhey there user....\n ya gonna exit the program yet?\n" },
        { "weather", "\nthe weather is... wait why am i telling you just go out side and look dumbass.\n" },
        { "time", "\ni know you people dont touch grass and all but like... look outside.\n" },
        { "how are you", "\nnot great man, im a damn program.\n" },
        { "english or spanish?", "\nwe both know i cant move...\n" },
         { "guess what", "\njust say the funny word and end my program\n" },
          { "give me a fun fact", "\nfun fact diddy had 787 phalic objects in his house \n" },
           { "give me another fun fact", "\nfun fact your ip is  172.217.164.110, i will be there soon\n" },
           { "whats my iq", "\nlower than mine\n" },
            { "sooo", "\nif you cant figure out what to say go take a look at that red text and do what it tells you to instead of wasting my time\n" },
             { "file size", "\nits 2kb... give or take \n" },
               { "i love you", "\nawwwwwe... i dont love you\n" },
               { "rizz", "\nnawww not helping with that, btw you dont got it give up.\n" },
               { "no", "\nfuck you\n" },
                { "i wont", "\n..i give up\n" },
             { "whats your hobby", "\noh you knowww spending time with my family.... \nno its nothing dumbass, what do you think i do for a hobby im a damn program i cant do anything but talk to you\n" },
        // Include more responses here eventually (lazy ah)
    };

    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("\nHey there random user im 'rudechatbot' and i will not help you at all get used to it \n you can use the /help command to view prompts\n\n\n");
        string userInput = Console.ReadLine();
        Respond(userInput);
    }

    public void Respond(string input)
    {
       
       
        string response = GenerateResponse(input);
        Console.WriteLine(response);

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("type 'goodbye' to exit...\n");

        Console.ForegroundColor = ConsoleColor.White;

        string userInput = Console.ReadLine();
        if (userInput != "goodbye")
        {
            Respond(userInput);
        }
      

    }

    private string GenerateResponse(string input)

    { 

        if (input.Contains("/help"))
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            return "so your new to this dumb program, try one of these cool key words\n\n hello,\n no, (use it if i ask for anything) \n i wont, (use after no) \n weather,\n time,\n how are you,\n english or spanish?,\n guess what,\n give me a fun fact,\n give me another fun fact,\n whats my iq,\n rizz,\n sooo,\n file size,\n whats your hobby,\n i love you,\n\n now go have some fun with my poorly designed prompts (maybe more will be added)\n";
        }
       
        Console.ForegroundColor = ConsoleColor.White;
        foreach (KeyValuePair<string, string> response in wordbank)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (input.Contains(response.Key))
            {
                return response.Value;
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;

        return "You said: " + input + ". try saying something legible dumbass\n";
    
    
    }
        
}

class Program
{
    static void Main()
    {
        RudeChatBot myrudebot = new RudeChatBot();
        myrudebot.Start();
    }
    
}
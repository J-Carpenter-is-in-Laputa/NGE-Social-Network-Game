using System;
using System.ComponentModel;
using System.Threading;

namespace NERVNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "NERV Social Network 2015 v3.7";

            // color scheme for the console, i like purple 
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            // intro method

            DisplayIntro();

            // main loop
            bool running = true;
            while (running)
            {
                Console.Clear();
                DisplayTitle();

                Console.WriteLine("\n\nShinji, who would you like to talk to?");
                Console.WriteLine("1. Asuka Langley");
                Console.WriteLine("2. Rei Ayanami");
                Console.WriteLine("3. Exit Terminal");

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.D1:
                        TalkToAsuka();
                        break;
                    case ConsoleKey.D2:
                        TalkToRei();
                        break;
                    case ConsoleKey.D3:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        Thread.Sleep(1000);
                        break;
                }
            }

            DisplayOutro();
        }

        static void DisplayIntro()
        {
            Console.Clear();
            Console.WriteLine("Initializing NERV terminal system...");
            Thread.Sleep(1000);
            Console.WriteLine("Security clearance: LEVEL-B1");
            Thread.Sleep(800);
            Console.WriteLine("User: Ikari, Shinji");
            Thread.Sleep(800);
            Console.WriteLine("Loading personality profiles...");
            Thread.Sleep(1500);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        static void DisplayTitle()
        {
            string title = @"
  
                         ..;+;++++++:            
                      ;xXXXXXXXXXXXXx.           
                     :XXXXXXXXXXXXXX;.           
          ++         +XXXXXXXXXXXXXXXXXXX+:      
           ++.       xXXXXXXXXXXXXXXXXXXXXXx:    
            .+:     :XXXXXXXXXXXXXXXXXXXXXXXX;.                                                           
              :;:.:+XXXXXXXXXXXXXXXXXXXXXXXXXXx.                                              \
                ;xXXXXXXXXXXXXXXXXXXXXXXXXXXx;.                                            \   \
  :::.    ::::..:;xXXXXXXXXXXXXXXXX+;;_   _ _____________________________________________\  \   \
   ;Xx:    .+   :x;.+XXXXXXXXXXXXXXXx| \ | |  _____  ________________                     \  \   \ 
   :;;x;   .+   :x;  .+XXXXXXXXXXXXXX|  \| | |__   | |__      __    |______________________\  \   \
   :: .xx. .+   :xx+++xxxXXXXXXXXXXXX| . ` |  __|  | |\ \    / |   / / _ \|  __ \ | |/ /       \   \
   ::   ;X+.+   :x;    . ;xXXXXXXXXXX| |\  | |____ | | \ \  / /\  / / | | | |__) \| ' /             \
   ::    .xX+   :x;      . ;XXXXXXXXX|_| \_|_______| |  \ \/ /\ \/ /| | | |  _  / |  <  
  .+;.     ;;   ;x+:..:;x:   +XXXXXXXXXXXXX;             \  /  \  / | |_| | | \ \ | . \ 
                  .:::::..   .;XXXXXXXXXXXXX;             \/    \/   \___/|_|  \_\|_|\_\
                    Xx  .;x;  .XxxXXXXXXXXXX;    
                    X+   .xx   :x+:xXXXXXXXX+    
                    Xx.:;x;.    :x; ;xXXXXXX+.   
                    Xx ;x;       ;x::;+XXXXX;    
                    X+  :xx.     .+xx.  xXXX;    
                   .Xx    +X;     .+:    .xX+.   
                                           :;. 
   
   ";
            Console.WriteLine(title);
        }

        static void Shinji() //tbh this is just a place holder for if i find a reason to put shinji in this. like pokemon style battles maybe. 
        {
            string shinji = @""; 

            Console.WriteLine(shinji);
        }

        static void DisplayAsuka()
        {
            string asuka = @"
             _______________________
            /                       \ 
           |==========ASKUA==========|
            \_______________________/ 

                  ,o.----.-----.oo.
                 d8P=.:::.;;;::.`88b.
                /'.'. \:/ . `---:_;-|-
               ,-'.....v:..........:_.'-.
              /,-;.....|:..........`-;:\ \
             |' /'....:;::.........|\:.|'|
              '|| ..::/ `:::......|\::.| '
             |::\|.:/--. \|\|\-\.;\:::.`.
            .':::\\|'.-=\ `  \=-.,;:..:.|
            ||::::/\'``9;    'P/,""|)__ .|
            |'.:::(`| `- ;    --' //  \_'
           .'.. :::`|    /       .(     )
           ||..:|.::`    `__    ,(  ,  +
           |'..:`.|..`.  `='     |-;    `.
          .'..:..|.|..:`.    .'. \| `. /O/.
         .|..:...`..\:::' --  |.:...:.`.~  `.
        /'..::_.--'--/' :.    `.\;;;;::|\    `.
      -' |.:;'..\    |._      /    ,'--:_`.    `.
        /|./ |...`.   \    -.'   ,'...../- :.    `.
       | |.' |/....`-. \ _.'_..'.....,'   ..`:     `.
         \|  |'.....|_`.\'-' /..... /. . '   `:      `.
          '  |......-''/+|\ \....../.      .','.      .
         /  .'......\-'/,| \/.....| .     /.'|.\:     |
            ";
            Console.WriteLine(asuka);
        }

        static void DisplayRei()
        {
            string rei = @" 

             _______________________
            /                       \ 
           |==========REI============|
            \_______________________/     
                                        __.-""..--,__
                               __..---""  | _|    ""-_\
                        __.---""          | V|::.-""-._D
                   _--"""".-.._   ,,::::::'""\/""""'-:-:/
              _.-""""::_:_:::::'-8b---""            ""'
           .-/  ::::<  |\::::::""\
           \/:::/::::'\\ |:::b::\
           /|::/:::/::::-::b:%b:\|
            \/::::d:|8:::b:""%%%%%\
            |\:b:dP:d.:::%%%%%""""""-,
             \:\.V-/ _\b%P_   /  .-._
             '|T\   ""%j d:::--\.(    ""-.
             ::d<   -"" d%|:::do%P""-:.   ""-,
             |:I _    /%%%o::o8P    ""\.    ""\
              \8b     d%%%%%%P""""-._ _ \::.    \
              \%%8  _./Y%%P/      .::'-oMMo    )
                H""'|V  |  A:::...:odMMMMMM(  ./
                H /_.--""JMMMMbo:d##########b/
            ";
            Console.WriteLine(rei);
        }

        static void TalkToAsuka()
        {
            Console.Clear();
            DisplayTitle();

            Console.WriteLine("\n\n");
            Shinji();
            Console.WriteLine("\n");
            DisplayAsuka();

            Console.WriteLine("\n\nAsuka: \"What do you want!?, Shinji ?\"");
            Console.WriteLine("\n1. \"I-I just wanted to see how you're doing.........\"");
            Console.WriteLine("2. \"Misato said we need to practice sync tests.\"");
            Console.WriteLine("3. \"Never mind, u-uh sorry.\"");

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\nAsuka: \"Hmmm, I'm doing fine, not that you'd care!\"");
                    Console.WriteLine("Asuka: \"...but thanks for asking, I guess.\"");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\nAsuka: \"haha, with you ? Don't make me laugh!\"");
                    Console.WriteLine("Asuka: \"...though if you insist, maybe we could try later.\"");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("\nAsuka: \"typical! Running away as usual!\"");
                    break;
                default:
                    Console.WriteLine("\nAsuka: \"what was that? speak clearly!\"");
                    break;
            }

            Console.WriteLine("\npress any key to continue...");
            Console.ReadKey(true);
        }

        static void TalkToRei()
        {
            Console.Clear();
            DisplayTitle();

            Console.WriteLine("\n\n");
            Shinji();
            Console.WriteLine("\n");
            DisplayRei();

            Console.WriteLine("\n\nRei: \"Shinji Ikari. What is it ?\"");
            Console.WriteLine("\n1. \"I-I wanted to check on you.\"");
            Console.WriteLine("2. \"Do you need any help with anything?\"");
            Console.WriteLine("3. \"oh, I'm Sorry to bother you.\"");

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\nRei: \"I am functioning within normal parameters.\"");
                    Console.WriteLine("Rei: \"thank you for your concern.\"");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\nRei: \"Your assistance is not required at this time.\"");
                    Console.WriteLine("Rei: \"but I will remember your offer.\"");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("\nRei: \"You are not a bother, Shinji.\"");
                    break;
                default:
                    Console.WriteLine("\nRei: \"I do not understand that response.\"");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }


        //outro - at somepoint i want to make it to where theres various endings based off character interactions
        static void DisplayOutro()
        {
            Console.Clear();
            Console.WriteLine("Logging out of NERV terminal system...");
            Thread.Sleep(1000);
            Console.WriteLine("Security clearance revoked");
            Thread.Sleep(800);
            Console.WriteLine("Goodbye, Shinji");
            Thread.Sleep(1500);
        }
    }
}

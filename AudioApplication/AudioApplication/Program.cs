namespace AudioApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        { 

            while (true)
            {
                Console.WriteLine("Menu 1:");
                Console.WriteLine("1. Window:");
                Console.WriteLine("2. Linux");
                Console.WriteLine("3.Exit App");
                Console.WriteLine("Select Option:");

                int choice1=int.Parse(Console.ReadLine());


                switch (choice1)
                {
                    case 1:
                        InnerMenu(new WindowsAudioPlayerFactory()); break;
                    case 2:
                        InnerMenu(new LinuxAudioPlayerFactory()); break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Invalid Choice"); break;
                }
            }
        }

        public static void InnerMenu(AudioPlayerFactory playerFactory)
        {
            IAudioPlayer player=playerFactory.CreateAudioPlayer();

            while (true)
            {
                Console.WriteLine("Menu 2:");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Return to Menu 1");
                Console.WriteLine("Select Option:");

                int choice2 = int.Parse(Console.ReadLine());

                switch(choice2)
                {
                    case 1:
                        player.Play(); break;
                    case 2:
                        player.Stop(); break;
                    case 3:
                        return;
                    case 4:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

    }
}
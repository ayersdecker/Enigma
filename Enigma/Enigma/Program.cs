using System;

namespace Enigma
{
    class Program
    {
        static string[] mainMenuSelections = new string[] { "Encrypt New Data (FencePost)","Encrypt New Data (Modulos)", "Decrypt Existing Data (FencePost)", "Exit" };

        static void Main(string[] args)
        {
            while (true)
            {
                switch (Utility.MenuBuild("Main Menu", mainMenuSelections))
                {
                    case 1:
                        CreateEncryption();
                        break;
                    case 2:
                        CreateEncryption2();
                        break;
                    case 3:
                        DecypherData();
                        break;
                    case 4:
                        Utility.ExitProgram();
                        break;
                    default:
                        Utility.TextColor(ConsoleColor.Red, "System Switch Error -- Exiting");
                        Utility.ExitProgram();
                        break;
                }
            }
        }
        private static void CreateEncryption()
        {
            Console.WriteLine("Dial 1 [Pick a number 0-9]");
            int dial1 = Utility.ValidateNum(0, 9);
            Console.WriteLine("Dial 2 [Pick a number 0-9]");
            int dial2 = Utility.ValidateNum(0, 9);
            Console.WriteLine("Dial 3 [Pick a number 0-9]");
            int dial3 = Utility.ValidateNum(0, 9);

            string dataIn = Utility.GatherString("Data to be encrypted: ");

            string output = Dial.DialPlus(dial1, dataIn);
            string output2 = Dial.DialPlus(dial2, output);
            string output3 = Dial.DialPlus(dial3, output2);
            Console.WriteLine("\nCoded Text:\n" + output3);






            Console.ReadLine();
        }
        private static void CreateEncryption2()
        {

            string dataIn = Utility.GatherString("Data to be encrypted: ");

            string output = Dial.CypherEncrypt(dataIn);
            Console.WriteLine("\nCoded Text:\n" + output);




            Console.ReadLine();
        }
        private static void DecypherData()
        {
            Console.Write("Dial 1 ");
            int dial1 = Utility.ValidateNum(0, 9);
            Console.Write("Dial 2 ");
            int dial2 = Utility.ValidateNum(0, 9);
            Console.Write("Dial 3 ");
            int dial3 = Utility.ValidateNum(0, 9);

            string dataIn = Utility.GatherString("Data to be decrypted: ");
            
            string decode = Dial.DialMinus(dial3, dataIn);
            string decode2 = Dial.DialMinus(dial2, decode);
            string decode3 = Dial.DialMinus(dial1, decode2);
            Console.WriteLine("\nDecoded Text:\n" + decode3);

            Console.ReadLine();
        }
    }
}

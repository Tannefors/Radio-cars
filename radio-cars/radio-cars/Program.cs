using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Size of court

            Console.WriteLine("First, enter the size of the room, separated by a space (i.e. 8 6):");
            string sizeInput = Console.ReadLine();
            string[] sizeValues = sizeInput.Split(" ");

            int sizeX = Int32.Parse(sizeValues[0]);
            int sizeY = Int32.Parse(sizeValues[1]);

            // Position of the car

            Console.WriteLine("");
            Console.WriteLine("Secondly, enter the position and direction of your Monster Truck, separated by a space (i.e. 2 3 N):");

            string posInput = Console.ReadLine();
            string[] posValues = posInput.Split(" ");

            int posX = Int32.Parse(posValues[0]);
            int posY = Int32.Parse(posValues[1]);
            string startDir = posValues[2];



            // The car's travels

            Console.WriteLine("");
            Console.WriteLine("Lastly, enter how your Monster Truck travels (i.e. FFFRFFLBB):");
            string travelInput = Console.ReadLine();
            char[] travelChars = travelInput.ToCharArray();

            for (int i = 0; i < travelChars.Length; i++)
            {
                if (startDir == "N" || startDir == "n")
                {
                    int dirPivot = 1;
                    // Tänkte låta dirPivot styra trucken, och att R (+1) och L (-1) från travelInputs adderar/subtraherar 1 (+/- 1) till dirPivots
                    // För att sedan antingen posX++, posY++ eller posX--, posY-- baserat på riktningen. T.ex. startDir = N -> dirPivot = 1.
                    // Sekvensen FFFRRFLBB åker då fram 3 -> dirPivot = 3 -> åker fram 1 -> dirPivot = 2 -> backar 2
                }
                else if (startDir == "E" || startDir == "e")
                {
                    int dirPivot = 2;

                }
                else if (startDir == "S" || startDir == "s")
                {
                    int dirPivot = 3;

                }
                else if (startDir == "W" || startDir == "w")
                {
                    int dirPivot = 4;

                }
            }

            /* En snabb kludd (utan parenteser m.m.)

            dirPivot
            foreach char r in travelinput

            {
                dirPivot++;
            }

            foreach char l in travelinput

            {
                dirPivot--;
            }


            Tänker på fallet då man svänger R 50 gånger... att man använder remainder/rest på något sätt för att limitera mellan 1 till 4

            while dirPivot%4 = 1
            {
                foreach char f in travelinput
                {
                    posY++;
                }

                foreach char s in travelinput
                {
                    posY--;
                }
            }

            while dirPivot = 2
            {
                foreach char f in travelinput
                {
                    posX++;
                }

                foreach char s in travelinput
                {
                    posX--;
                }
            }
             */

            if ((posX > sizeX || posX < 0) || (posY > sizeY || posY < 0))
            {
                Console.WriteLine("You crashed!");
                Console.WriteLine("Would you like to try again?");
                Console.ReadLine();
            }
            else if ((posX <= sizeX && posX > 0) && (posY <= sizeY && posY > 0))
            {
                Console.WriteLine("Your truck made it! It is located at (X,Y) facing Z");
                Console.WriteLine("Would you like to go again?");
                Console.ReadLine();

            }

        }
    }
}
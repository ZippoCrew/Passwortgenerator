using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswortgeneratorVersuch1
{
    class Program
    {
        List<string> buchstaben = new List<string>();
        List<string> sonderzeichen = new List<string>();
        List<string> BUCHSTABEN = new List<string>();
        Random random;
        int zählerKlein = 0;
        int zählerGroß = 0;
        int zählerSonder = 0;
        int zählerZahl = 0;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        void Run()
        {
            buchstaben.Add("a");
            buchstaben.Add("b");
            buchstaben.Add("c");
            buchstaben.Add("d");
            buchstaben.Add("e");
            buchstaben.Add("f");
            buchstaben.Add("g");
            buchstaben.Add("h");
            buchstaben.Add("i");
            buchstaben.Add("j");
            buchstaben.Add("k");
            buchstaben.Add("l");
            buchstaben.Add("m");
            buchstaben.Add("n");
            buchstaben.Add("o");
            buchstaben.Add("p");
            buchstaben.Add("q");
            buchstaben.Add("r");
            buchstaben.Add("s");
            buchstaben.Add("t");
            buchstaben.Add("u");
            buchstaben.Add("v");
            buchstaben.Add("w");
            buchstaben.Add("x");
            buchstaben.Add("y");
            buchstaben.Add("z");

            BUCHSTABEN.Add("A");
            BUCHSTABEN.Add("B");
            BUCHSTABEN.Add("C");
            BUCHSTABEN.Add("D");
            BUCHSTABEN.Add("E");
            BUCHSTABEN.Add("F");
            BUCHSTABEN.Add("G");
            BUCHSTABEN.Add("H");
            BUCHSTABEN.Add("I");
            BUCHSTABEN.Add("J");
            BUCHSTABEN.Add("K");
            BUCHSTABEN.Add("L");
            BUCHSTABEN.Add("M");
            BUCHSTABEN.Add("N");
            BUCHSTABEN.Add("O");
            BUCHSTABEN.Add("P");
            BUCHSTABEN.Add("Q");
            BUCHSTABEN.Add("R");
            BUCHSTABEN.Add("S");
            BUCHSTABEN.Add("T");
            BUCHSTABEN.Add("U");
            BUCHSTABEN.Add("V");
            BUCHSTABEN.Add("W");
            BUCHSTABEN.Add("X");
            BUCHSTABEN.Add("Y");
            BUCHSTABEN.Add("Z");

            sonderzeichen.Add(".");
            sonderzeichen.Add("_");
            sonderzeichen.Add("/");
            sonderzeichen.Add(",");
            sonderzeichen.Add("-");
            sonderzeichen.Add(":");
            sonderzeichen.Add(";");
            sonderzeichen.Add("*");
            sonderzeichen.Add("#");
            sonderzeichen.Add("%");

            random = new Random();
            while (true)
            {
                zählerZahl = 0;
                zählerSonder = 0;
                zählerKlein = 0;
                zählerGroß = 0;
                Console.WriteLine("Gib eine Zahl ein.");
                string input = Console.ReadLine();
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(CalculateRandom(input));
                }
                //Console.WriteLine("buchstaben: {0}", zählerKlein);
                //Console.WriteLine("BUCHSTABEN: {0}", zählerGroß);
                //Console.WriteLine("Sonderzeichen: {0}", zählerSonder);
                //Console.WriteLine("Zahlen: {0}", zählerZahl);
            }
        }
        string CalculateRandom(string input)
        {
            string output;
            output = string.Empty;
            try
            {
                int index;
                int INDEX;
                int sonderIndex;
                int intInput;
                intInput = int.Parse(input);
                for (int i = 0; i < intInput; i++)
                {
                    int randOutput = random.Next(0, 1001);
                    if (randOutput < 400)
                    {
                        randOutput = 0;
                    }
                    else if (randOutput >= 400 && randOutput < 550)
                    {
                        randOutput = 1;
                    }
                    else if (randOutput >= 550 && randOutput < 800)
                    {
                        randOutput = 2;
                    }
                    else if (randOutput >= 900 && randOutput < 1000)
                    {
                        randOutput = 3;
                    }

                    switch (randOutput)
                    {
                        case 0:
                            index = random.Next(0, buchstaben.Count);
                            output += buchstaben[index];
                            zählerKlein++;
                            break;
                        case 1:
                            int randInt = random.Next(0, 10);
                            randInt.ToString();
                            output += randInt;
                            zählerZahl++;
                            break;
                        case 2:
                            INDEX = random.Next(0, BUCHSTABEN.Count);
                            output += BUCHSTABEN[INDEX];
                            zählerGroß++;
                            break;
                        case 3:
                            sonderIndex = random.Next(0, sonderzeichen.Count);
                            output += sonderzeichen[sonderIndex];
                            zählerSonder++;
                            break;
                    }
                }
            }
            catch (Exception)
            {

            }
            return output;
        }
    }
}

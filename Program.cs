using System;
using Service;

namespace ConverterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fortsett = true;
            //string menu = Console.ReadLine();
            ConverterService converter = new ConverterService();
            //Start point for the program.

            while (fortsett)
            {
                Console.WriteLine("\nTryck 1 för att konvertera resistans och ampere till Volt. ");
                Console.WriteLine("Tryck 2 för att konvertera resistans och Volt till ampere. ");
                Console.WriteLine("Tryck 3 för att konvertera Volt och ampere till resistans. ");
                Console.WriteLine("Tryck valfri tangent för att avsluta.");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.WriteLine("Skriv in antalet resistans:");
                        float res = 0;
                        while (true)
                        {
                            try
                            {
                                res = float.Parse(Console.ReadLine());
                            }
                            catch 
                            {

                                Console.WriteLine("Fel input, try again.");
                                continue;
                            }

                        break;


                        }

                        Console.WriteLine("Skriv in antalet ampere:");
                        float amp = 0;
                        while (true)
                        {
                            try
                            {
                                amp = float.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Fel input, try again.");
                                continue;
                            }
                            break;
                        }

                        float inputVoltage = converter.CalculateVoltage(res, amp);


                        Console.WriteLine("Resultatet är följande, dina värden blir {0} mycket Volt.", inputVoltage);

                        break;

                    case "2":
                        Console.WriteLine("Skriv in antalet resistans:");
                        float ampRes = 0;
                        while (true)
                        {
                            try
                            {
                                ampRes = float.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Fel input, try again.");
                                continue;
                            }
                            break;
                        }

                        Console.WriteLine("Skriv in antalet Volt:");
                        float ampVolt = 0;
                        while(true)
                        {
                            try
                            {
                                ampVolt = float.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Fel input, try again.");
                                continue;
                            }
                            break;

                        }


                        float inputAmpere = converter.CalculateAmps(ampVolt, ampRes);


                        Console.WriteLine("Resultatet är följande, dina värden blir {0} mycket ampere.", inputAmpere);
                        break;

                    case "3":
                        Console.WriteLine("Skriv in antalet Volt:");
                        float resVolt = 0;
                        while (true)
                        {
                            try
                            {
                                resVolt = float.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Fel input, try again.");
                                continue;                                
                            }
                            break;
                        }

                        Console.WriteLine("Skriv in antalet ampere:");
                        float resAmp = 0;
                        while(true)
                        {
                            try
                            {
                                resAmp = float.Parse(Console.ReadLine());                                
                            }
                            catch
                            {
                                Console.WriteLine("Fel input, try again.");
                                continue;     
                            }
                            break;
                        }


                        float inputResistance = converter.CalculateResistance(resVolt, resAmp);


                        Console.WriteLine("Resultatet är följande, dina värden blir {0} mycket Volt.", inputResistance);
                        break;

                    case "4":
                    default:
                        fortsett = false;
                        break;
                }


            }

        }
    }
}

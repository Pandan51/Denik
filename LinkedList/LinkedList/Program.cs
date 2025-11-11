namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Denik denik = new Denik();
            //LinkNode node = new LinkNode();

            while (true)
            {
                denik.Menu();

                string prikaz = Console.ReadLine();
                //Console.WriteLine(prikaz);

                switch (prikaz)
                {
                    //Příkaz nový
                    case "novy":
                        int tries = 0;
                        while (tries < 3)
                        {
                            Console.WriteLine("Zadej datum (dd/mm/yy):");
                            string input = Console.ReadLine();
                            DateTime dateValue;
                            if (DateTime.TryParse(input, out dateValue))
                            {
                                Console.WriteLine($"Valid date: {dateValue.ToShortDateString()}");
                                LinkNode node = new LinkNode(dateValue);
                                if(denik.NodeCount == 0)
                                {
                                    denik.Soucasny = node;
                                    break;
                                }
                                else
                                {
                                    denik.Soucasny = node;
                                }
                                
                            }
                            else
                            {
                                Console.WriteLine("Invalid date format!");
                                tries++;
                                Console.ReadKey();
                            }



                        }
                        break;
                    case "logNode":
                        denik._soucasny.LogDate();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

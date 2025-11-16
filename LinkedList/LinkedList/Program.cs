namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Denik denik = new Denik();
            //LinkNode node = new LinkNode();
            string prikaz = "";
            string inputText = "";

            while (true)
            {
                denik.Menu(inputText);

                prikaz = Console.ReadLine();
                //Console.WriteLine(prikaz);
                

                switch (prikaz)
                {
                    
                    case "predchozi":
                        
                        if (denik.soucasny == denik.prvni)
                        {
                            denik.soucasny = denik.posledni;
                        }
                        else
                        {
                            denik.soucasny = denik.soucasny.predchozi;
                        }
                        inputText = "";
                        break;
                    case "dalsi":
                        if (denik.soucasny == denik.posledni)
                        {
                            denik.soucasny = denik.prvni;
                        }
                        else
                        {
                            denik.soucasny = denik.soucasny.dalsi;
                        }
                        inputText = "";
                        break;
                    case "zacatek":
                        denik.soucasny = denik.prvni;
                        break;
                    case "konec":
                        denik.soucasny = denik.posledni;
                        break;
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
                                if(denik.nodeCount == 0)
                                {
                                    denik.soucasny = node;
                                    denik.soucasny.dalsi = node;
                                    denik.soucasny.predchozi = node;
                                    denik.prvni = denik.soucasny;
                                    denik.posledni = denik.soucasny;
                                    
                                    
                                }
                                else
                                {
                                    node.dalsi = denik.soucasny.dalsi;

                                    node.predchozi = denik.soucasny;
                                    //node.predchozi = denik.soucasny;
                                    denik.soucasny.dalsi.predchozi = node;
                                    denik.soucasny.dalsi = node;
                                    

                                    if(denik.soucasny == denik.posledni)
                                    {
                                        denik.posledni = denik.soucasny.dalsi;
                                        denik.posledni.dalsi = denik.prvni;
                                        denik.prvni.predchozi = denik.posledni;
                                    }
                                    
                                }
                                denik.nodeCount++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid date format!");
                                tries++;
                                Console.ReadKey();
                            }



                        }
                        break;
                    case "uloz":
                        denik.soucasny.text += inputText;
                        inputText = "";
                        break;
                    case "smaz":
                        denik.soucasny.predchozi.dalsi = denik.soucasny.dalsi;
                        denik.soucasny.dalsi.predchozi = denik.soucasny.predchozi;
                        if(denik.nodeCount == 1)
                        {
                            denik.soucasny = null;
                        }
                        else if(denik.soucasny == denik.prvni)
                        {
                            denik.soucasny = denik.soucasny.dalsi;
                        }
                        else if(denik.soucasny == denik.posledni)
                        {
                            denik.soucasny = denik.soucasny.predchozi;
                        }
                        else
                        {
                            denik.soucasny = denik.prvni;
                        }
                        denik.nodeCount--;
                        
                        break;
                    case "zavri":
                        Environment.Exit(0);
                        break;
                        //Vypíše date
                    case "logDate":
                        denik.soucasny.LogDate();
                        Console.ReadKey();
                        break;
                    default:
                        if(denik.nodeCount != 0)
                        {
                            inputText += $"{prikaz}\n";
                        }
                        break;
                }
            }
        }
    }
}

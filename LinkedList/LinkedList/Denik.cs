using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Denik
    {
        public LinkNode soucasny;
        public LinkNode prvni;
        public LinkNode posledni;
        public int nodeCount = 0;

        //public LinkNode Soucasny
        //{
        //    set
        //    {
        //        _soucasny = value;
        //        _nodeCount++;
        //    }
        //}
        //public LinkNode First
        //{
        //    get => _prvni;
        //}
        //public LinkNode Last
        //{   
        //    get => _posledni;

        //    //private set
        //}
        //public int NodeCount
        //{
        //    get => _nodeCount;
        //}
        public bool NodeCountIsZero()
        {
            if(nodeCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void Zacatek()
        {
            soucasny = prvni;
        }
        public void Konec()
        {
            soucasny = posledni;
        }
        public void Menu(string inputText)
        {
            Console.Clear();
            string[] tutorialLines = ["------------------------------------------------",
            "Deník se ovládá následujícími příkazy:",
            "- predchozi: Přesunutí na předchozí záznam",
            "- dalsi: Přesunutí na další záznam",
            "- novy: Vytvoření nového záznamu",
            "- uloz: Uložení vytvořeného záznamu",
            "- smaz: Odstranění záznamu",
            "- zavri: Zavření deníku",
            "------------------------------------------------",
            "",
            $"Počet záznamů: {nodeCount}",
            ""
             ];

            foreach (string line in tutorialLines)
            {
                Console.WriteLine(line);
            }

            if(NodeCountIsZero())
            {
                Console.WriteLine("Zadej příkaz:");
            }
            else if(nodeCount > 0)
            {
                soucasny.LogDate();
                
                Console.WriteLine($"\nText:\n{soucasny.text}{inputText}");
            }
        }

        //public void Commands(string prikaz)
        //{
        //    switch (prikaz)
        //    {

        //        case "predchozi":

        //            if (soucasny == prvni)
        //            {
        //                soucasny = posledni;
        //            }
        //            else
        //            {
        //                soucasny = soucasny.predchozi;
        //            }
        //            inputText = "";
        //            break;
        //        case "dalsi":
        //            if (soucasny == posledni)
        //            {
        //                soucasny = prvni;
        //            }
        //            else
        //            {
        //                soucasny = soucasny.dalsi;
        //            }
        //            inputText = "";
        //            break;
        //        case "zacatek":
        //            soucasny = prvni;
        //            break;
        //        case "konec":
        //            soucasny = posledni;
        //            break;
        //        //Příkaz nový   
        //        case "novy":
        //            int tries = 0;
        //            while (tries < 3)
        //            {
        //                Console.WriteLine("Zadej datum (dd/mm/yy):");
        //                string input = Console.ReadLine();
        //                DateTime dateValue;
        //                if (DateTime.TryParse(input, out dateValue))
        //                {
        //                    Console.WriteLine($"Valid date: {dateValue.ToShortDateString()}");
        //                    LinkNode node = new LinkNode(dateValue);
        //                    if (nodeCount == 0)
        //                    {
        //                        soucasny = node;
        //                        soucasny.dalsi = node;
        //                        soucasny.predchozi = node;
        //                        prvni = soucasny;
        //                        posledni = soucasny;


        //                    }
        //                    else
        //                    {
        //                        node.dalsi = soucasny.dalsi;

        //                        node.predchozi = soucasny;
        //                        //node.predchozi = soucasny;
        //                        soucasny.dalsi.predchozi = node;
        //                        soucasny.dalsi = node;


        //                        if (soucasny == posledni)
        //                        {
        //                            posledni = soucasny.dalsi;
        //                            posledni.dalsi = prvni;
        //                            prvni.predchozi = posledni;
        //                        }

        //                    }
        //                    nodeCount++;
        //                    break;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Invalid date format!");
        //                    tries++;
        //                    Console.ReadKey();
        //                }



        //            }
        //            break;
        //        case "uloz":
        //            soucasny.text += inputText;
        //            inputText = "";
        //            break;
        //        case "smaz":
        //            soucasny.predchozi.dalsi = soucasny.dalsi;
        //            soucasny.dalsi.predchozi = soucasny.predchozi;
        //            if (nodeCount == 1)
        //            {
        //                soucasny = null;
        //            }
        //            else if (soucasny == prvni)
        //            {
        //                soucasny = soucasny.dalsi;
        //            }
        //            else if (soucasny == posledni)
        //            {
        //                soucasny = soucasny.predchozi;
        //            }
        //            else
        //            {
        //                soucasny = prvni;
        //            }
        //            nodeCount--;

        //            break;
        //        case "zavri":
        //            Environment.Exit(0);
        //            break;
        //        //Vypíše date
        //        case "logDate":
        //            soucasny.LogDate();
        //            Console.ReadKey();
        //            break;
        //        default:
        //            if (nodeCount != 0)
        //            {
        //                inputText += $"{prikaz}\n";
        //            }
        //            break;
        //    }
        //}

    }
}

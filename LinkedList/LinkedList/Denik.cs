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
                
                Console.WriteLine($"\nText:\n{inputText}{soucasny.text}");
            }
        }


    }
}

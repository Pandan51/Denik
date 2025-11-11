using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Denik
    {
        private LinkNode _soucasny;
        private LinkNode _prvni;
        private LinkNode _posledni;
        private int _nodeCount = 0;

        public LinkNode Soucasny
        {
            set
            {
                _soucasny = value;
                _nodeCount++;
            }
        }
        public LinkNode First
        {
            get => _prvni;
        }
        public LinkNode Last
        {   
            get => _posledni;

            //private set
        }
        public int NodeCount
        {
            get => _nodeCount;
        }

        
        public void Zacatek()
        {
            _soucasny = _prvni;
        }
        public void Konec()
        {
            _soucasny = _posledni;
        }
        public void Menu()
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
            $"Počet záznamů: {_nodeCount}",
            "Zadej příkaz:"
             ];

            foreach (string line in tutorialLines)
            {
                Console.WriteLine(line);
            }

            if(_nodeCount >0)
            {
                Console.WriteLine("Text");
            }
        }


    }
}

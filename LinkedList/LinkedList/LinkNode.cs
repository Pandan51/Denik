using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkNode
    {
        public string text = "";
        public DateTime date;

        public LinkNode dalsi;
        public LinkNode predchozi;



        //public LinkNode Dalsi
        //{
        //    get => _dalsi;
        //    set => _dalsi = value;
        //}
        //public LinkNode Predchozi
        //{
        //    get => _predchozi;
        //    set => _predchozi = value;
        //}

        public LinkNode(DateTime _date)
        {
            date = _date;
        }
        //public void Dalsi()
        //{
        //    _soucasny = 
        //}
        //public void Predchozi()
        //{
        //    _soucasny = _predchozi;
        //}

        public void LogDate()
        {
            Console.WriteLine(date);
        }



        public void AddAfter() { }
        public void AddBefore() { }
        public void AddFirst() { }
        public void AddLast() { }

        public void RemoveFirst() { }
        public void RemoveLast() { }

    }
}

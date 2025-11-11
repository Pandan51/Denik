using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkNode
    {
        private string _text;
        private DateTime _date;
        
        //private LinkNode _dalsi;
        //private LinkNode _predchozi;
        


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

        public LinkNode(DateTime date)
        {
            _date = date;
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
            Console.WriteLine(_date);
        }



        public void AddAfter() { }
        public void AddBefore() { }
        public void AddFirst() { }
        public void AddLast() { }

        public void RemoveFirst() { }
        public void RemoveLast() { }

    }
}

using System;
using System.Net;
using System.Windows;
using System.Collections.Generic;

namespace RodeDog
{
    public class Pack
    {
        public int ID { get; set; }
        public string PackImage { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        public bool isPrivate { get; set; }
        public string Private { get; set; }
        public LinkedList<member> Members { get; set; }

        public Pack()
        {
            Members = new LinkedList<member>();
        }
    }
}

using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

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
    }
}

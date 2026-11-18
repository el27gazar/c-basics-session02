using System;
using System.Collections.Generic;
using System.Text;

namespace CApp_1
{
    internal class Book
    {
        public string Title;
        public int Pages;

        override public string ToString()
        {
            return $"Title: {Title}, Pages: {Pages}";
        }
    }
}

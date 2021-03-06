﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDemoStromgName
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }


        public Book(string title, string author)
        {
            Author = author;
            Title = title;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Title, Author);
        }
    }
}

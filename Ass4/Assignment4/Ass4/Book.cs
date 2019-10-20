using System;
using System.Collections.Generic;
using System.Text;

namespace Ass4
{
    public class Book
    {
        private string title;
        private string author;
        private int pagenumber;
        private string isbn13;
        private string books;


        public Book()
        {

        }

        public Book(string isbn13book, string titlebook, string authorbook, int pagenumberbook)
        {
            title = titlebook;
            author = authorbook;
            pagenumber = pagenumberbook;
            isbn13 = isbn13book;
        }




        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (value.Length <= 2)
                {
                    throw new Exception("Title must be longer!");
                }
                else
                {
                    title = value;
                }
            }
        }

        public string Author

        {
            get
            {
                return author;
            }
            set
            {
                this.author = value;
            }
        }

        public int PageNumber
        {
            get
            {
                return pagenumber;
            }

            set
            {
                if (value < 10 || value > 1000)
                {
                    throw new Exception("Page numbers do not fit the requirements!");
                }
                else
                {
                    pagenumber = value;
                }


            }


        }

        public string Isbn13
        {
            get
            {
                return isbn13;
            }
            set
            {
                if (value.Length > 13 || value.Length < 13)
                {
                    throw new Exception("The text must be 13 characters long!");
                }
                else
                {
                    isbn13 = value;
                }
            }
        }



    }
}


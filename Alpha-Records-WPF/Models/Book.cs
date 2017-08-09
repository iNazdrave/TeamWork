using Alpha_Records_WPF.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Models
{
    public class Book : IBook
    {
        private string title;
        private string autor;
        private string language;

        public Book(string title, string autor, string language)
        {
            this.title = title;
            this.autor = autor;
            this.language = language;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                //valid
                this.title = value;
            }
        }
        public string Autor
        {
            get
            {
                return this.autor;
            }
            private set
            {
                //valid
                this.autor = value;
            }
        }
        public string Language
        {
            get
            {
                return this.language;
            }
            private set
            {
                //valid
                this.language = value;
            }
        }

    }
}

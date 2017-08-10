using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;

namespace Alpha_Records_WPF.Models
{
    public class Book : IBook
    {
        private string title;
        private string autor;
        private string language;

        public Book(string title, string autor, string language)
        {
            this.Title = title;
            this.Autor = autor;
            this.Language = language;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Title)));
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
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Autor)));
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
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Language)));
                this.language = value;
            }
        }

    }
}

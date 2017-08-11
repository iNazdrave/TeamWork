using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;

namespace Alpha_Records_WPF.Models
{
    public class Book : IBook
    {
        private string title;
        private string author;
        private string language;

        public Book(string title, string author, string language)
        {
            this.Title = title;
            this.Author = author;
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
        public string Author
        {
            get
            {
                return this.author;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Author)));
                this.author = value;
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

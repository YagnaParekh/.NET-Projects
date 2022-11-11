
// I, Yagna Parekh, 000846481 certify that this material is my original work.
// No other person's work has been used without due acknowledgement.

// Date : October 31, 2021

/// <summary>
/// The purpose of this class is to output single book
/// </summary>
namespace Lab3A
{
    class Book : Media , IEncryptable
    {
        public string Author { get; set; }
        public string Summary{ get; set; }

        /// <summary>
        /// Making a new single Book
        /// </summary>
        /// <param name="author">Autohr of the book</param>
        /// <param name="year"> Year of publication</param>
        /// <param name="title"> Title of the book</param>
        /// <param name="summary">Summary of the book</param>
        public Book(string author, int year, string title, string summary) : base(title, year)
        {
            Author = author;
            Summary = summary;
        }

        /// <summary>
        /// Encrypt the book data
        /// </summary>
        /// <returns> Encrypted Data</returns>
        public string Encrypt()
        {
            char[] summary = Summary.ToCharArray();

            for(int i = 0; i < summary.Length; i++)
            {
                int num = (int)summary[i];

                if(num >= 'a' && num <= 'z')
                {
                    if (num > 'm')
                        num -= 13;
                    else
                        num += 13; 
                }
                else if(num >= 'A' && num <= 'Z')
                {
                    if (num > 'M')
                        num -= 13;
                    else
                        num += 13;
                }
                summary[i] = (char)num;
            }
            return new string(summary);
        }

        /// <summary>
        /// Decrypt the book data
        /// </summary>
        /// <returns> Decrypted Data</returns>
        public string Decrypt()
        {
            char[] summary = Summary.ToCharArray();

            for(int i = 0; i < summary.Length; i++)
            {
                int num = (int)summary[i];  
                
                if(num >= 'a' && num <= 'z')
                {
                    if (num > 'm')
                        num -= 13;
                    else
                        num += 13;
                }
                else if(num >= 'A' && num <= 'Z')
                {
                    if (num > 'M')
                        num -= 13;
                    else
                        num += 13;
                }
                summary[i] = (char)num;
            }
            return new string(summary);
        }

        /// <summary>
        /// Shows single book
        /// </summary>
        /// <returns>single book string</returns>
        public override string ToString()
        {
            return $"Book Title : {Title} ({Year}) \n" +
                   $"Author : {Author}";
        }
    }
}

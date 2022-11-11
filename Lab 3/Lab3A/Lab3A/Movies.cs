
// I, Yagna Parekh, 000846481 certify that this material is my original work.
// No other person's work has been used without due acknowledgement.

// Date : October 31, 2021

/// <summary>
/// This class is for Movies and decrypts all the other data
/// </summary>
namespace Lab3A
{
	class Movies : Media, IEncryptable
	{
		public string Director { get; set; }
		public string Summary { get; set; }

		/// <summary>
		/// This will create one single movie
		/// </summary>
		/// <param name="director"> Director of the movie</param>
		/// <param name="summary"> Summary of movie</param>
		/// <param name="year"> Year of released</param>
		/// <param name="title"> Title of movie</param>
		public Movies(string director, string summary, int year, string title) : base(title, year)
        {
			Director = director;
			Summary = summary;
        }

		/// <summary>
		/// Encrypts the data by ROT13
		/// </summary>
		/// <returns>Encrypted Data</returns>
		public string Encrypt()
        {
			char[] summary = Summary.ToCharArray();

			for(int i = 0; i < summary.Length; i++)
            {
				int num = (int)summary[i];

				if (num >= 'a' && num <= 'z')
					if (num > 'm')
						num -= 13;
					else
						num += 13;
				else if (num >= 'A' && num <= 'Z')
					if (num > 'M')
						num -= 13;
					else
						num += 13;
				summary[i] = (char)num;
			}
			return new string(summary);
        }

		/// <summary>
		/// Decrypts the data using ROT13
		/// </summary>
		/// <returns> Decrypted Data</returns>
		public string Decrypt()
        {
			char[] summary = Summary.ToCharArray();

			for(int i = 0; i < summary.Length; i++)
            {
				int num = (int)summary[i];

				if (num >= 'a' && num <= 'z')
					if (num > 'm')
						num -= 13;
				    else
						num += 13;
				else if (num >= 'A' && num <= 'Z')
					if (num > 'M')
						num -= 13;
					else
						num += 13;
				summary[i] = (char)num;
			}
			return new string(summary);
        }

		/// <summary>
		/// Single Movie string
		/// </summary>
		/// <returns> movie string</returns>
		public override string ToString()
        {
			return $"Movie Title : {Title} ({Year}) \n" +
				   $"Director : {Director}";
        }

	}
}

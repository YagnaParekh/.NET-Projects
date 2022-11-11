
// I, Yagna Parekh, 000846481 certify that this material is my original work.
// No other person's work has been used without due acknowledgement.

// Date : October 31, 2021


/// <summary>
/// Displays Song description
/// </summary>
namespace Lab3A
{
	class Songs : Media
	{
		public string Album { get; set; }
	    public string Artist { get; set; } 

		/// <summary>
		/// Creates one song
		/// </summary>
		/// <param name="album"> Album of the Song</param>
		/// <param name="artist">Artist Of the Song</param>
		/// <param name="year">Year of released</param>
		/// <param name="title"> Title of the Song</param>
	    public Songs(string album, string artist, int year, string title) : base (title, year) 
		{ 
			Album = album; 
			Artist = artist;
		}

		/// <summary>
		/// Gives output of one song
		/// </summary>
		/// <returns> single song string </returns>
	    public override string ToString()
		{
			return $"Song Title : {Title} ({Year}) \n" +
                   $"Album : {Album}" +
                   $"Artist : {Artist}";
	    }
	}
}

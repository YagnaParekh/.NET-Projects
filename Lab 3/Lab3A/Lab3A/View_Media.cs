using System;
using System.Collections.Generic;



// I, Yagna Parekh, 000846481 certify that this material is my original work.
// No other person's work has been used without due acknowledgement.

// Date : October 31, 2021

/// <summary>
/// This is a view class of media
/// </summary>
namespace Lab3A
{
	class View_Media
	{
		private List<Media> Media { get; set; }

		/// <summary>
		/// Creates one new View Media
		/// </summary>
		/// <param name="media"> media </param>
		public View_Media(List<Media> media)
		{
			Media = media;
		}

		public void UserSelection()
		{
			do
			{ 

				DisplayMenu();


				string user_input = Console.ReadLine();
				if ((int.TryParse(user_input, out int input)) == false || input < 1 || input > 6)
				{
					Console.WriteLine("Invaild Entry......Please enter a number between 1 and 6.");
					Console.WriteLine("Press any key to try again.......");
					Console.ReadKey();
					continue;
				}

				switch(input)
                {
					case 1:
						DisplayMedia(typeof(Book));
						break;
					case 2:
						DisplayMedia(typeof(Movies));
						break;
					case 3:
						DisplayMedia(typeof(Songs));
						break;
					case 4:
						DisplayMedia(null);
						break;
					case 5:
						SearchMedia();
						break;
                }
				if(input == 6)
                {
					break;
                }


				Console.WriteLine("Press any key to stop......");
				Console.ReadLine();
			}
			while (true);
		}

		/// <summary>
		/// Displays the main menu to select the choice
		/// </summary>
		public void DisplayMenu()
		{
			Console.WriteLine("Yagna's Media Collection");
			Console.WriteLine("========================");

			Console.WriteLine("1. List all Books");
			Console.WriteLine("2. List all Movies");
			Console.WriteLine("3. List all Songs");
			Console.WriteLine("4. List all Media");
			Console.WriteLine("5. Search all media by Title\n");

			Console.WriteLine("6. Exit Program\n");

			Console.WriteLine("Enter your choice: ");
		}

		/// <summary>
		/// Display the media of one specfic type 
		/// </summary>
		/// <param name="type"> Type of media</param>
		private void DisplayMedia(Type type)
		{
			foreach (Media media in Media)
				if (media.GetType() == type || type == null)
				{
					Console.WriteLine(media);
					Console.WriteLine("-------------------");
				}

		}

		/// <summary>
		/// Search the media to from the given data
		/// </summary>
		private void SearchMedia()
		{
			Console.WriteLine("Enter a string :");

			string user_input = Console.ReadLine();
			Console.WriteLine();

			foreach (Media media in Media)
			{
				if (media.Search(user_input))
				{
					Console.WriteLine(media);

					if (media is Book book)
						Console.WriteLine(book.Decrypt());
					else if (media is Movies movie)
						Console.WriteLine(movie.Decrypt());
					Console.WriteLine("---------------------");
				}
			}
		}
	}
}
using System;
using System.Collections.Generic;
using System.IO;


// I, Yagna Parekh, 000846481 certify that this material is my original work.
// No other person's work has been used without due acknowledgement.

// Date : October 31, 2021


/// <summary>
/// Main Program
/// </summary>
namespace Lab3A
{
    class Program
    {
        static void Main()
        {
            List<Media> media = ReadData();

            if(media != null)
            {
                View_Media viewmedia = new View_Media(media);
                viewmedia.UserSelection();
            }
        }

        /// <summary>
        /// Read the Data from Data.txt file and convert it into readable string
        /// </summary>
        /// <returns>Media list</returns>
        static List<Media> ReadData()
        {
            List<Media> media = new List<Media>();

            FileStream file = null;
            StreamReader stream = null;

            try
            {
                if(File.Exists("../../Data.txt"))
                    file = new FileStream("../../Data.txt", FileMode.Open);
                else
                   file = new FileStream("./Data.txt", FileMode.Open);

                stream = new StreamReader(file);


                while(!stream.EndOfStream)
                {
                    string user_input = stream.ReadLine();

                    string[] values = user_input.Split('|');

                    if(values.Length > 1)
                    {
                        string type = values[0];
                        string title = values[1];

                        if(int.TryParse(values[2], out int year) == false)
                            year = 0;

                        if(type == "BOOK")
                        {
                            string author = values[3];
                            string summary = "";

                            while(!stream.EndOfStream)
                            {
                                user_input = stream.ReadLine();
                                if(user_input != "------")
                                {
                                    if(user_input == "")
                                        summary += "\n";
                                    else
                                        summary += user_input;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            media.Add(new Book(title, year, author, summary));
                        }
                        if(type == "MOVIE")
                        {
                            string director = values[3];
                            string summary = "";

                            while (!stream.EndOfStream)
                            {
                                user_input = stream.ReadLine();
                                if(user_input != "-----")
                                {
                                    if(user_input != "")
                                        summary += user_input;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            media.Add(new Movies(director, summary, year, title));
                        }

                        if(type == "SONG")
                        {
                            string album = values[3];
                            string artist = values[4];

                            media.Add(new Songs(album, artist, year, title));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception reading 'Data.txt' due to: {e.Message}");
                Console.WriteLine("Press a key to exit");
                Console.ReadKey();
            }
            finally
            {
                if(file != null)
                    file.Close();
                if(stream != null)
                    stream.Close();
            }

            return media;
        }
    }
}

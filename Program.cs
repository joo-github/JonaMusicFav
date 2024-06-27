using System;
using MusicListBusinessLogic;
using MusicListModel;

namespace MusicUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicService musicService = new MusicService();

            Console.WriteLine("Please log in:");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (musicService.AuthenticateUser(username, password))
            {
                Console.WriteLine("Authentication successful!\n");

                var musicList = musicService.GetAllMusic();
                Console.WriteLine("Music Playlist:");
                foreach (var music in musicList)
                {
                    Console.WriteLine($"Id: {music.Id}, Artist: {music.ArtistName}, Title: {music.SongTitle}, Year: {music.YearComposed}");
                }
            }
            else
            {
                Console.WriteLine("Invalid username or password.");

            }
        }
    }
}
    



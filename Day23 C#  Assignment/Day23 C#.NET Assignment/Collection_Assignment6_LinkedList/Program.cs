namespace Collection_Assignment6_LinkedList
{
    internal class Program
    {
        static void Main()
        {
            // Create LinkedList
            LinkedList<Song> playlist = new LinkedList<Song>();

            // Add songs at beginning
            var song1 = new Song(1, "Shape of You", "Ed Sheeran");
            playlist.AddFirst(song1);

            // Add songs at end
            var song2 = new Song(2, "Blinding Lights", "The Weeknd");
            var song3 = new Song(3, "Levitating", "Dua Lipa");
            playlist.AddLast(song2);
            playlist.AddLast(song3);

            // Add song in middle (after song1)
            var song4 = new Song(4, "Believer", "Imagine Dragons");
            var node = playlist.Find(song1);
            if (node != null)
            {
                playlist.AddAfter(node, song4);
            }

            // Display playlist (Forward)
            Console.WriteLine("Playlist (Forward):");
            foreach (var song in playlist)
            {
                Console.WriteLine($"{song.Id} - {song.Title} by {song.Artist}");
            }

            // Traverse backward
            Console.WriteLine("\nPlaylist (Backward):");
            var current = playlist.Last;
            while (current != null)
            {
                Console.WriteLine($"{current.Value.Id} - {current.Value.Title} by {current.Value.Artist}");
                current = current.Previous;
            }

            // Find a song by title
            Console.WriteLine("\nSearching for 'Believer':");
            var found = playlist.First;
            while (found != null)
            {
                if (found.Value.Title == "Believer")
                {
                    Console.WriteLine("Song Found!");
                    Console.WriteLine($"{found.Value.Title} by {found.Value.Artist}");
                    break;
                }
                found = found.Next;
            }

            // Remove a specific song
            Console.WriteLine("\nRemoving 'Blinding Lights'...");
            var removeNode = playlist.First;
            while (removeNode != null)
            {
                if (removeNode.Value.Title == "Blinding Lights")
                {
                    playlist.Remove(removeNode);
                    break;
                }
                removeNode = removeNode.Next;
            }

            Console.WriteLine("\nAfter Removal:");
            foreach (var song in playlist)
            {
                Console.WriteLine($"{song.Title}");
            }

            // BONUS: Play Next Feature
            Console.WriteLine("\nPlay Next after 'Shape of You':");
            var playNode = playlist.Find(song1);
            if (playNode != null && playNode.Next != null)
            {
                var nextSong = playNode.Next.Value;
                Console.WriteLine($"Now Playing Next: {nextSong.Title} by {nextSong.Artist}");
            }
        }
    }
}

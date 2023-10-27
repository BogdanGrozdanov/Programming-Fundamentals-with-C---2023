namespace Song
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSong = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numSong; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                songs.Add(song);
            }
            string comand = Console.ReadLine();
            if (comand == "all")
            {
                foreach (Song song in songs) { Console.WriteLine(song.Name); }
            }
            else
            {
                List<Song> filterSong = songs.Where(s => s.TypeList == comand).ToList();
                foreach (Song song in filterSong) { Console.WriteLine(song.Name); }
            }
        }
    }
    internal class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }


    }
}

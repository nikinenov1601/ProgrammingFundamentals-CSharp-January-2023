﻿int n = int.Parse(Console.ReadLine());

List<Song> songs = new List<Song>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split('_');

    string typelist = input[0];
    string songNmae = input[1];
    string duration = input[2];

    Song song = new Song();
    song.TypeList = typelist;
    song.Name = songNmae;
    song.Time = duration;

    songs.Add(song);
};

string searchForTypeList = Console.ReadLine();

if (searchForTypeList == "all")
{
    foreach (Song song in songs)
    {
        Console.WriteLine(song.Name);
    }
}

else
{
    foreach (Song song in songs)
    {
        if (song.TypeList == searchForTypeList)
        {
            Console.WriteLine(song.Name);
        }
    }
}

public class Song
{
    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}
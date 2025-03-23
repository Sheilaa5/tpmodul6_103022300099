using System;
using System.Diagnostics;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100, "Title must be non-empty and max 100 characters.");
        id = new Random().Next(10000, 99999);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count > 0 && count <= 10000000, "Play count must be between 1 and 10,000,000.");

        if (playCount + count < playCount)
        {
            Console.WriteLine("Error: Play count overflow!");
        }
        else
        {
            playCount += count;
        }
    }

    public void PrintVideoDetails() => Console.WriteLine($"ID: {id}\nTitle: {title}\nPlay Count: {playCount}");
}

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Sheila Nabilla Chantika Yudho");
        video.PrintVideoDetails();

        for (int i = 0; i < 10; i++) video.IncreasePlayCount(10000000);


        video.PrintVideoDetails();
    }
}



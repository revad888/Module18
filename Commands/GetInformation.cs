using System.Text;
using YoutubeExplode;
using YoutubeExplode.Videos;
using static YoutubeExplode.YoutubeClient;

namespace Module18.Commands;

public class GetInformation : ICommand
{

    private readonly string url;
    public GetInformation(string url)
    {
        this.url = url;

    }
    public void Execute()
    {
        YoutubeClient client = new YoutubeClient();
        Video video = client.Videos.GetAsync(url).Result;
        Console.WriteLine($"Название: {video.Title}\nАвтор: {video.Author}" +
                          $"\nПродолжительность:{video.Duration}" +
                          $"\nОписание видео: {video.Description}");
    }

    public void Undo()
    {
        
    }
    
}
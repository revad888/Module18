using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace Module18.Commands;

public class Download : ICommand
{
    
    private readonly string url;

    public Download(string url)
    {
        this.url = url;

    }
    
    public async void Execute()
    {
        Console.WriteLine("Вставьте путь куда сохранить видео: ");
        string path = Console.ReadLine().Replace("\\", "/");
        YoutubeClient client = new YoutubeClient();
        Video video = client.Videos.GetAsync(url).Result;
        IProgress<double> progress = null;
        await client.Videos.DownloadAsync(url, path + $"/{video.Title}.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast), progress);
        Console.WriteLine($"{video.Title} загруженно!");
    }

    public void Undo()
    {

    }

}
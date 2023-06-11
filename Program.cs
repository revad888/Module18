// See https://aka.ms/new-console-template for more information

using Module18;
using Module18.Commands;
using System.Security.Cryptography.X509Certificates;
using YoutubeExplode;


internal class Program
{
    private static void Main(string[] args)
    {
        Client client = new Client();
        Console.Write("Вставьте ссылку на видео: ");
        string url = Console.ReadLine();

        client.SetCommand("info", new GetInformation(url));
        client.SetCommand("d", new Download(url));

        Console.WriteLine("Для просмотра инормации об видео ввдеите 'info'.\nДля скачивания видео введите 'd'.\n" +
            "Для работы с другим видео введите 'new'.\nДля остановки программы введите 'stop'.");
        bool isWork = true;

        while (isWork)
        {
            Console.WriteLine("Введите команду");
            string command = Console.ReadLine();
            switch (command)
            {
                case ("info"):
                    client.Run(command);
                    break;
                case "d":
                    client.Run(command);
                    break;
                case "new":
                    New();
                    break;
                case "stop":
                    isWork = false;
                    break;

            }

        }

        void New ()
        {
            Console.Write("Вставьте ссылку на видео: ");
            string newUrl = Console.ReadLine();
            url = newUrl;
            client.SetCommand("info", new GetInformation(newUrl));
            client.SetCommand("d", new Download(newUrl));
        }

    }
}
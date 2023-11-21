using System.Diagnostics;

internal class Program
{
    private static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();

        Console.Write("Введите ссылку для скачивания изображения: ");
        string webSiteName = Console.ReadLine();

        HttpResponseMessage response = await client.GetAsync(webSiteName);
        byte[] data = await response.Content.ReadAsByteArrayAsync();

        Console.Write("Введите путь сохранения: ");
        string path = Console.ReadLine();
        await File.WriteAllBytesAsync(path, data);

        Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });



        HttpClient client1 = new HttpClient();

        Console.Write("Введите ссылку для скачивания музыки: ");
        string webSiteLink = Console.ReadLine();


        HttpResponseMessage response1 = await client1.GetAsync(webSiteLink);
        byte[] data1 = response1.Content.ReadAsByteArrayAsync().Result;

        Console.Write("Введите путь сохранения: ");
        string path_1 = Console.ReadLine();
        File.WriteAllBytes(path_1, data1);

        Process.Start(new ProcessStartInfo { FileName = path_1, UseShellExecute = true });
    }
}

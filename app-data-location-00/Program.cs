using System;
using System.IO;
using System.Reflection;

namespace app_data_location_00
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.Title = "Environment Test";
        var sourcePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Source Directory",
            "image.png");

    var appData = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        Assembly.GetEntryAssembly().GetName().Name,
        "Destination Directory");

    // Ensure create directory  (doesn't disturb existing)
    Directory.CreateDirectory(appData);

    var destPath = Path.Combine(appData, "image.png");

    // Overwrite any existing file by that name.
    File.Copy(sourcePath, destPath, overwrite: true);

    if(File.Exists(destPath))
    {
        Console.WriteLine($"Successsful write: {destPath}");
    }
        Console.ReadLine();
    }
    }
}

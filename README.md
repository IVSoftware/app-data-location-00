Try using `Environment.GetFolderPath()` to make your file names.

***
**Source Path**

    var sourcePath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "Source Directory",
        "image.png");

Where:

[![copy if newer][1]][1]

***
**Destination Directory**

    var appData = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        Assembly.GetEntryAssembly().GetName().Name,
        "Destination Directory");

    // Ensure create directory  (doesn't disturb existing)
    Directory.CreateDirectory(appData);

***
**Destination File Path**

    var destPath = Path.Combine(appData, "image.png");

    // Overwrite any existing file by that name.
    File.Copy(sourcePath, destPath, overwrite: true);

    if(File.Exists(destPath))
    {
        Console.WriteLine($"Successsful write: {destPath}");
    }

[![should-work][2]][2]


  [1]: https://i.stack.imgur.com/tfdS5.png
  [2]: https://i.stack.imgur.com/LKN4j.png
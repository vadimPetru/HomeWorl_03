using HomeWork_06;
while (true)
{
    Console.WriteLine("Enter Filename in format FileName.FileFormat");
    string[] line = Console.ReadLine().Trim().Split('.');
    FileParser file = FileParser.GetParser(line);
    if (file == null)
    {
        Console.Write("This file is not supported,try agian:");
    }
    else
    {
        file.Parse();
        break;
    }
}

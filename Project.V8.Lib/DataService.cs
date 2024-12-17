using System.Text;

namespace Project.V8.Lib;

public class DataService
{
    public static string[][] ReadCsv(string filePath) => File.ReadLines(filePath).Where(x => x.Length != 0).Select(x => x.Split(',')).ToArray();
    public static void AppendCsv(string filePath, string line)
    {
        if (!File.Exists(filePath))
            File.Create(filePath).Close();
        File.AppendAllText(filePath, "\n" + line);
    }
    public static void DeleteLineInCsv(string filePath, string line)
    {
        var csv = File.ReadAllText(filePath).Split('\n');

        StringBuilder outCsv = new();
        for (int i = 0; i < csv.Length; i++)
        {
            if (csv[i] != line)
                outCsv.Append(csv[i]+"\n");
        }

        File.WriteAllText(filePath, outCsv.ToString().TrimEnd());
    }
    public static bool IsCarNumberPresentInCsv(string filePath, string carNumber)
    {
        if (!File.Exists(filePath))
            File.Create(filePath).Close();
        var csv = File.ReadAllText(filePath).Split('\n');
        for (int i = 0; i < csv.Length; i++)
        {
            if (csv[i].Split(',').First() == carNumber)
                return true;
        }
        return false;
    }
}

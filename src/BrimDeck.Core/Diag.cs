namespace BrimDeck.Core;

// Temporary: writes what the panel decided and how it laid out, to answer a report from the field without guesses.
public static class Diag
{
    private static readonly object Gate = new();
    public static bool Enabled { get; } = Environment.GetEnvironmentVariable("BRIMDECK_DIAG") != "0";
    public static void Log(string line)
    {
        if (!Enabled) return;
        try
        {
            lock (Gate)
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BrimDeck");
                Directory.CreateDirectory(dir);
                var file = Path.Combine(dir, "context.log");
                if (File.Exists(file) && new FileInfo(file).Length > 1_000_000) File.Delete(file);
                File.AppendAllText(file, DateTime.Now.ToString("HH:mm:ss.fff") + " " + line + Environment.NewLine);
            }
        }
        catch { }
    }
}

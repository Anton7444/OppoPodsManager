using Avalonia;

namespace OppoPodsManager;

internal static class Program
{
    private static void Main(string[] args)
    {
        try
        {
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }
        catch (Exception ex)
        {
            // 启动期致命异常（日志服务尚未建立）：落盘供排查，避免进程无声退出。
            try
            {
                var dir = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "OppoPodsManager");
                Directory.CreateDirectory(dir);
                File.WriteAllText(Path.Combine(dir, "startup-crash.txt"), ex.ToString());
            }
            catch
            {
            }
            throw;
        }
    }

    public static AppBuilder BuildAvaloniaApp() => AppBuilder
        .Configure<App>()
        .UsePlatformDetect()
        .LogToTrace();
}

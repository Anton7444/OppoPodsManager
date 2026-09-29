using System.Threading.Tasks;

namespace OppoPodsManager.UI.MainWindow;
public partial class MainWindow
{
    // 本项目不再联网查询版本号：点击「获取更新」直接用默认浏览器打开 GitHub Releases 页面，
    // 由用户自行查看和下载，程序自身不发起任何更新相关的网络请求。
    private Task OpenUpdatePageAsync()
    {
        _logManager?.Info("UI", "用户操作: 打开 GitHub Releases 页面（不联网检测版本）。");
        _desktopLinks?.TryOpen(AppInfo.ReleasesUrl, "更新页面");
        return Task.CompletedTask;
    }
}

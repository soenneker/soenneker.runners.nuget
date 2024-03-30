using System.Threading.Tasks;

namespace Soenneker.Runners.NuGet.Utils.Abstract;

public interface IDownloadUtil
{
    ValueTask<string> Download();
}

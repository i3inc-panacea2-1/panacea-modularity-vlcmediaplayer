using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.VlcMediaPlayer
{
    public interface IVlcBinariesPlugin : IPlugin
    {
        string GetVersion();
        string GetBinariesPath();
    }
}

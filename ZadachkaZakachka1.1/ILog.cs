using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachkaZakachka1._1
{
    public interface ILog
    {
        void WriteTeamLog(Team team, string filePath);
        void WriteTeamHistory(Team team, string filePath);
    }
}

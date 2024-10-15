using DATAPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public class PhongBanBackEnd
    {
        readonly HRMEntities Adapter = new HRMEntities();
        public List<PhongBan> LoadDataTable() => Adapter.PhongBans.AsNoTracking().ToList();
    }
}

using DATAPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public class ChucVuBackEnd
    {
        readonly HRMEntities Adapter = new HRMEntities();
        public List<DM_ChucVu> LoadDataTable() => Adapter.DM_ChucVu.AsNoTracking().ToList();
    }
}

using DATAPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public class NhanVienBackEnd
    {
        readonly HRMEntities Adapter = new HRMEntities();
        public List<NhanVien> LoadDataTable() => Adapter.NhanVien.AsNoTracking().ToList();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public static class ThongBao
    {
        public static event Action Load_TableThoiViec;

        public static void CapNhatBang_ChoThoiViec()
        {
            Load_TableThoiViec?.Invoke();
        }

        public static event Action Load_TableLamViec;

        public static void CapNhatBang_LamViecLai()
        {
            Load_TableLamViec?.Invoke();
        }

    }
}

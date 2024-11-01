﻿using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace FRONTENDPlayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("vi-VN");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("vi-VN");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrangChu());
        }
    }
}

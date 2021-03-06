﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Test1.DB_Automation
{
    public partial class Recording1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_Ext735Db(RepoItemInfo textInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'textInfo' at 24;8.", textInfo);
            textInfo.FindAdapter<Text>().Click("24;8");
        }

        public void Connect_Server(RepoItemInfo textInfo)
        {
            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\Digital Barriers\\EdgeVis Client\\EdgeVis Client.exe' in normal mode.");
            Host.Local.RunApplication("C:\\Program Files (x86)\\Digital Barriers\\EdgeVis Client\\EdgeVis Client.exe", "", "C:\\Program Files (x86)\\Digital Barriers\\EdgeVis Client", false);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'textInfo' at 35;7.", textInfo);
            textInfo.FindAdapter<Text>().Click("35;7");
        }

    }
}

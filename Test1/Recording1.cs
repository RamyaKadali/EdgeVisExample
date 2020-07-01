﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Test1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("fad2d254-3667-49a1-b906-27813115161c", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Test1Repository repository.
        /// </summary>
        public static Test1Repository repo = Test1Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Connect_Server(repo.EdgeVisClient.CONNECTInfo);
            Delay.Milliseconds(0);
            
            Mouse_Click_Ext735Db(repo.RootWindow.MainMenuLeft.Ext735DbInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RootWindow.MainMenuLeft.Alerts' at 10;10.", repo.RootWindow.MainMenuLeft.AlertsInfo, new RecordItemIndex(2));
            repo.RootWindow.MainMenuLeft.Alerts.Click("10;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RootWindow.MainMenuLeft.MItemMap' at 21;9.", repo.RootWindow.MainMenuLeft.MItemMapInfo, new RecordItemIndex(3));
            repo.RootWindow.MainMenuLeft.MItemMap.Click("21;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RootWindow.Home' at 24;12.", repo.RootWindow.HomeInfo, new RecordItemIndex(4));
            repo.RootWindow.Home.Click("24;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RootWindow.MainMenuLeft.Alerts' at 7;7.", repo.RootWindow.MainMenuLeft.AlertsInfo, new RecordItemIndex(5));
            repo.RootWindow.MainMenuLeft.Alerts.Click("7;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RootWindow.MainMenuLeft.TextMap' at 1;5.", repo.RootWindow.MainMenuLeft.TextMapInfo, new RecordItemIndex(6));
            repo.RootWindow.MainMenuLeft.TextMap.Click("1;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RootWindow.Home2' at 7;4.", repo.RootWindow.Home2Info, new RecordItemIndex(7));
            repo.RootWindow.Home2.Click("7;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RootWindow.SomePicture' at 13;13.", repo.RootWindow.SomePictureInfo, new RecordItemIndex(8));
            repo.RootWindow.SomePicture.Click("13;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RootWindow.SomePicture' at 5;11.", repo.RootWindow.SomePictureInfo, new RecordItemIndex(9));
            repo.RootWindow.SomePicture.Click("5;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EdgeVisClient1.Close' at 30;10.", repo.EdgeVisClient1.CloseInfo, new RecordItemIndex(10));
            repo.EdgeVisClient1.Close.Click("30;10");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

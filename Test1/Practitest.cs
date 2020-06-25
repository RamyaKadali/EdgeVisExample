/*
 * Created by Ranorex
 * User: RamyaKadali
 * Date: 22/06/2020
 * Time: 10:32
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace Test1
{
    /// <summary>
    /// Description of Practitest.
    /// </summary>
    [TestModule("AE22CFFB-9481-4145-90B5-9B83E3F2E9DB", ModuleType.UserCode, 1)]
    public class Practitest : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Practitest()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
curl -H "Content-Type:application/json" \
-u ramya.kadali@digitalbarriers.com:b771952fbf98e0d2fad82a6c6282ca98c74ff945\
-X POST https://api.practitest.com/api/v2/projects/4566/tests.json \
-d '{
	"data": {
	"type": "tests",
    "attributes": {
	"name": "one", 
	"author-id": 22,
	"priority": "highest", 
	"custom-fields": { 
	"---f-22": "Windows", 
	"---f-24": ["ClientA", "ClientB"]}}  } }'
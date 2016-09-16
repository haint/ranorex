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

namespace DelTek_POC.TestModules.General
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenDHS recording.
    /// </summary>
    [TestModule("c539336e-e496-49c1-84cd-859e3e334ecb", ModuleType.Recording, 1)]
    public partial class OpenDHS : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DelTek_POC.DelTek_POCRepository repository.
        /// </summary>
        public static DelTek_POC.DelTek_POCRepository repo = DelTek_POC.DelTek_POCRepository.Instance;

        static OpenDHS instance = new OpenDHS();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenDHS()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenDHS Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Taskbar.Start' at Center.", repo.Taskbar.StartInfo, new RecordItemIndex(0));
            repo.Taskbar.Start.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Start.ContainerHash' at Center.", repo.Start.ContainerHashInfo, new RecordItemIndex(1));
            repo.Start.ContainerHash.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Start.TextD' at Center.", repo.Start.TextDInfo, new RecordItemIndex(2));
            repo.Start.TextD.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(3));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            OpenApp();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

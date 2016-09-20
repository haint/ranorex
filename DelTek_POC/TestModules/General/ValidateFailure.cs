/*
 * Created by Ranorex
 * User: 22
 * Date: 9/19/2016
 * Time: 9:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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

namespace DelTek_POC.TestModules.General
{
    /// <summary>
    /// Description of VaidateFail.
    /// </summary>
    [TestModule("D20CF749-2514-4F18-9B2A-01A60F352342", ModuleType.UserCode, 1)]
    public class ValidateFailure : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateFailure()
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
            Ranorex.Validate.IsTrue(false);
        }
    }
}

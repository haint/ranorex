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
using Ranorex.Core.Testing;

namespace DelTek_POC.TestModules.General
{
    public partial class CheckWindowsTroubleShooter
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void OpenWindowsUpdate()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item Keep Your System Healthy ");
            repo.DHSMainWindow.KeepYourSystemHealthy.Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item Protecting your PC from Malware");
            repo.DHSMainWindow.ProtectYourPC.Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item Launch Windows Update Services Troubleshooter");
            repo.DHSArticleContentArea.RunApp.Click(Location.CenterLeft);
        }

        public void Validate_WUTitle()
        {
			Report.Log(ReportLevel.Info, "Validation", "Windows Update window is launched!", repo.WindowsUpdate.WUTitleInfo);
			Validate.Attribute(repo.WindowsUpdate.WUTitleInfo, "Text", "Windows Update");
        }

        public void MergedUserCodeMethod()
        {
			while(true){
				if(repo.DHSArticleContentArea.RunAppInfo.Exists(1000)){
					Report.Log(ReportLevel.Info, "Validation", "The troubleshooting wizard window is launched ", repo.WindowsNetworkDiagnostics.WindowsNetworkInfo);
					Validate.Attribute(repo.WindowsNetworkDiagnostics.WindowsNetworkInfo, "Text", "Windows Network Diagnostics");
					break;
				}else{
					Delay.Seconds(3);
				}
			}
			Delay.Milliseconds(0);

			Report.Log(ReportLevel.Info, "Validation", "Title: 'Troubleshooting couldn't identify the problem' on item 'WindowsNetworkDiagnostics' Exits!", repo.WindowsNetworkDiagnostics.HeadertitleInfo);
			repo.WindowsNetworkDiagnostics.FeedBackInfo.Exists(60000);
			Validate.Attribute(repo.WindowsNetworkDiagnostics.HeadertitleInfo, "Text", "Troubleshooting couldn't identify the problem");
        }

        public void OpenWireless()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click Connecting Wireless and Accessories");
            repo.DHSMainWindow.ConnectWirelessAccess.Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item Wireless Troubleshooting");
            repo.DHSMainWindow.TextTb.Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item Launch Windows Wireless Troubleshooter");
            repo.DHSArticleContentArea.RunApp.Click(Location.CenterLeft);
        }

        public void Validate_HardwareAndDeviceTitle()
        {
			Report.Log(ReportLevel.Info, "Validation", "Hardware and Devices troubleshooter window is launched!", repo.HardwareAndDevices.HardwareAndDeviceTitleInfo);
			Validate.Attribute(repo.HardwareAndDevices.HardwareAndDeviceTitleInfo, "Text", "Hardware and Devices");
        }

        public void OpenHardwareAndDevices()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click Connecting Wireless and Accessories");
            repo.DHSMainWindow.ConnectWirelessAccess.Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click Setup a Wireless Keyboard or Mouse");
            repo.DHSMainWindow.SetupAWireless.Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item Launch Windows Device Troubleshooter", repo.DHSArticleContentArea.RunAppInfo);
            repo.DHSArticleContentArea.RunApp.Click(Location.CenterLeft);
        }

    }
}
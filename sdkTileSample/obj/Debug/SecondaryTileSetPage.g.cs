﻿#pragma checksum "c:\users\ghostia\documents\visual studio 2012\Projects\sdkTileSample\sdkTileSample\SecondaryTileSetPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "45929395B8CEC02F4B4FC118B74B9360"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace sdkTileSample {
    
    
    public partial class SecondaryTileSetPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.ToggleSwitch isSecondaryTileEnabled;
        
        internal System.Windows.Controls.TextBox inputSecTile;
        
        internal System.Windows.Controls.Button setSecTitleBtn;
        
        internal System.Windows.Controls.TextBox inputSecBk;
        
        internal System.Windows.Controls.Button setSecBkBtn;
        
        internal System.Windows.Controls.TextBox inputSecCount;
        
        internal System.Windows.Controls.Button setSecCountBtn;
        
        internal System.Windows.Controls.TextBox inputSecBackTitle;
        
        internal System.Windows.Controls.Button setSecBackTitleBtn;
        
        internal System.Windows.Controls.TextBox inputSecBackBk;
        
        internal System.Windows.Controls.Button setSecBackBkBtn;
        
        internal System.Windows.Controls.TextBox inputSecBackContent;
        
        internal System.Windows.Controls.Button setSecBackContentBtn;
        
        internal System.Windows.Controls.Button setSecTileBtn;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/sdkTileSample;component/SecondaryTileSetPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.isSecondaryTileEnabled = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("isSecondaryTileEnabled")));
            this.inputSecTile = ((System.Windows.Controls.TextBox)(this.FindName("inputSecTile")));
            this.setSecTitleBtn = ((System.Windows.Controls.Button)(this.FindName("setSecTitleBtn")));
            this.inputSecBk = ((System.Windows.Controls.TextBox)(this.FindName("inputSecBk")));
            this.setSecBkBtn = ((System.Windows.Controls.Button)(this.FindName("setSecBkBtn")));
            this.inputSecCount = ((System.Windows.Controls.TextBox)(this.FindName("inputSecCount")));
            this.setSecCountBtn = ((System.Windows.Controls.Button)(this.FindName("setSecCountBtn")));
            this.inputSecBackTitle = ((System.Windows.Controls.TextBox)(this.FindName("inputSecBackTitle")));
            this.setSecBackTitleBtn = ((System.Windows.Controls.Button)(this.FindName("setSecBackTitleBtn")));
            this.inputSecBackBk = ((System.Windows.Controls.TextBox)(this.FindName("inputSecBackBk")));
            this.setSecBackBkBtn = ((System.Windows.Controls.Button)(this.FindName("setSecBackBkBtn")));
            this.inputSecBackContent = ((System.Windows.Controls.TextBox)(this.FindName("inputSecBackContent")));
            this.setSecBackContentBtn = ((System.Windows.Controls.Button)(this.FindName("setSecBackContentBtn")));
            this.setSecTileBtn = ((System.Windows.Controls.Button)(this.FindName("setSecTileBtn")));
        }
    }
}


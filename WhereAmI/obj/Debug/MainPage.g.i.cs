﻿#pragma checksum "C:\Users\Andrew Servania\Documents\GitHub\wp7app\WhereAmI\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2F6B51C669A0EA91C373C452F9B1473E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Maps;
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


namespace WhereAmI {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock myPositionText;
        
        internal System.Windows.Controls.Button myPositionButton;
        
        internal Microsoft.Phone.Controls.Maps.Map map1;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.Button button2;
        
        internal System.Windows.Controls.Button button3;
        
        internal System.Windows.Controls.TextBlock timerBlock;
        
        internal System.Windows.Controls.Button button4;
        
        internal System.Windows.Controls.Button button5;
        
        internal System.Windows.Controls.Grid PushpinPanel;
        
        internal System.Windows.Controls.TextBox XCoordinateField;
        
        internal System.Windows.Controls.TextBox YCoordinateField;
        
        internal System.Windows.Controls.TextBlock BannerTextBlock;
        
        internal System.Windows.Controls.TextBlock BannerTextBlock2;
        
        internal System.Windows.Controls.TextBlock BannerTextBlock3;
        
        internal System.Windows.Controls.TextBox PushpinTextField;
        
        internal System.Windows.Controls.TextBlock StatusBanner;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WhereAmI;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.myPositionText = ((System.Windows.Controls.TextBlock)(this.FindName("myPositionText")));
            this.myPositionButton = ((System.Windows.Controls.Button)(this.FindName("myPositionButton")));
            this.map1 = ((Microsoft.Phone.Controls.Maps.Map)(this.FindName("map1")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.button2 = ((System.Windows.Controls.Button)(this.FindName("button2")));
            this.button3 = ((System.Windows.Controls.Button)(this.FindName("button3")));
            this.timerBlock = ((System.Windows.Controls.TextBlock)(this.FindName("timerBlock")));
            this.button4 = ((System.Windows.Controls.Button)(this.FindName("button4")));
            this.button5 = ((System.Windows.Controls.Button)(this.FindName("button5")));
            this.PushpinPanel = ((System.Windows.Controls.Grid)(this.FindName("PushpinPanel")));
            this.XCoordinateField = ((System.Windows.Controls.TextBox)(this.FindName("XCoordinateField")));
            this.YCoordinateField = ((System.Windows.Controls.TextBox)(this.FindName("YCoordinateField")));
            this.BannerTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("BannerTextBlock")));
            this.BannerTextBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("BannerTextBlock2")));
            this.BannerTextBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("BannerTextBlock3")));
            this.PushpinTextField = ((System.Windows.Controls.TextBox)(this.FindName("PushpinTextField")));
            this.StatusBanner = ((System.Windows.Controls.TextBlock)(this.FindName("StatusBanner")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
        }
    }
}


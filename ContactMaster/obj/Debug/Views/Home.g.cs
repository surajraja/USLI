﻿#pragma checksum "C:\ZLI\Work\SilverLight\ContactMaster\Views\Home.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "550475AA8AA0663C51911A265EA4DF5B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace ContactMaster {
    
    
    public partial class Home : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ScrollViewer PageScrollViewer;
        
        internal System.Windows.Controls.Grid gridHeader;
        
        internal System.Windows.Controls.ComboBox cboDepts;
        
        internal System.Windows.Controls.TextBlock proscount;
        
        internal System.Windows.Controls.StackPanel btRow;
        
        internal System.Windows.Controls.Button btAdd;
        
        internal System.Windows.Controls.Button btDelete;
        
        internal System.Windows.Controls.Button btExcel;
        
        internal System.Windows.Controls.Button btPrint;
        
        internal System.Windows.Controls.ComboBox cboContactType;
        
        internal System.Windows.Controls.StackPanel DefaultContactBlock;
        
        internal System.Windows.Controls.TextBlock txDefaultContact;
        
        internal System.Windows.Controls.Button ChangeDefault;
        
        internal System.Windows.Controls.Button DeleteDefault;
        
        internal System.Windows.Controls.TextBlock txError;
        
        internal System.Windows.Controls.TabControl mainTab;
        
        internal System.Windows.Controls.TabItem ItemTab;
        
        internal System.Windows.Controls.DataGrid CustomerGrid;
        
        internal System.Windows.Controls.DataGrid StateGrid;
        
        internal System.Windows.Controls.DataGrid ProductGrid;
        
        internal System.Windows.Controls.TabItem psTabItem;
        
        internal System.Windows.Controls.DataGrid PSGrid;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ContactMaster;component/Views/Home.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PageScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("PageScrollViewer")));
            this.gridHeader = ((System.Windows.Controls.Grid)(this.FindName("gridHeader")));
            this.cboDepts = ((System.Windows.Controls.ComboBox)(this.FindName("cboDepts")));
            this.proscount = ((System.Windows.Controls.TextBlock)(this.FindName("proscount")));
            this.btRow = ((System.Windows.Controls.StackPanel)(this.FindName("btRow")));
            this.btAdd = ((System.Windows.Controls.Button)(this.FindName("btAdd")));
            this.btDelete = ((System.Windows.Controls.Button)(this.FindName("btDelete")));
            this.btExcel = ((System.Windows.Controls.Button)(this.FindName("btExcel")));
            this.btPrint = ((System.Windows.Controls.Button)(this.FindName("btPrint")));
            this.cboContactType = ((System.Windows.Controls.ComboBox)(this.FindName("cboContactType")));
            this.DefaultContactBlock = ((System.Windows.Controls.StackPanel)(this.FindName("DefaultContactBlock")));
            this.txDefaultContact = ((System.Windows.Controls.TextBlock)(this.FindName("txDefaultContact")));
            this.ChangeDefault = ((System.Windows.Controls.Button)(this.FindName("ChangeDefault")));
            this.DeleteDefault = ((System.Windows.Controls.Button)(this.FindName("DeleteDefault")));
            this.txError = ((System.Windows.Controls.TextBlock)(this.FindName("txError")));
            this.mainTab = ((System.Windows.Controls.TabControl)(this.FindName("mainTab")));
            this.ItemTab = ((System.Windows.Controls.TabItem)(this.FindName("ItemTab")));
            this.CustomerGrid = ((System.Windows.Controls.DataGrid)(this.FindName("CustomerGrid")));
            this.StateGrid = ((System.Windows.Controls.DataGrid)(this.FindName("StateGrid")));
            this.ProductGrid = ((System.Windows.Controls.DataGrid)(this.FindName("ProductGrid")));
            this.psTabItem = ((System.Windows.Controls.TabItem)(this.FindName("psTabItem")));
            this.PSGrid = ((System.Windows.Controls.DataGrid)(this.FindName("PSGrid")));
        }
    }
}


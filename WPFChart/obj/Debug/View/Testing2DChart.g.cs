﻿#pragma checksum "..\..\..\View\Testing2DChart.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D54C8AD2AF2F378CE76607025215DB8EA3CCB1DAAAEA5209A3E75140CEA69159"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.Charts;
using DevExpress.Xpf.Charts.Themes;
using DevExpress.Xpf.DXBinding;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPFChart.Model;
using WPFChart.View;
using WPFChart.ViewModel;


namespace WPFChart.View {
    
    
    /// <summary>
    /// Testing2DChart
    /// </summary>
    public partial class Testing2DChart : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\View\Testing2DChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPFChart.ViewModel.Testing2DVM VM;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\View\Testing2DChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFreq;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\View\Testing2DChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPolar;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\View\Testing2DChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbAngle;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\View\Testing2DChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.ChartControl chart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFChart;component/view/testing2dchart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Testing2DChart.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.VM = ((WPFChart.ViewModel.Testing2DVM)(target));
            return;
            case 2:
            this.cmbFreq = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cmbPolar = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cmbAngle = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.chart = ((DevExpress.Xpf.Charts.ChartControl)(target));
            return;
            case 6:
            
            #line 234 "..\..\..\View\Testing2DChart.xaml"
            ((DevExpress.Xpf.Charts.XYDiagram2D)(target)).Zoom += new DevExpress.Xpf.Charts.XYDiagram2DZoomEventHandler(this.XYDiagram2D_Zoom);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


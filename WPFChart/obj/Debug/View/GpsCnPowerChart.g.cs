﻿#pragma checksum "..\..\..\View\GpsCnPowerChart.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6CFAA53FA2247C2509D482D2281B725352C65BE0537255B9A5395D96C55C82F8"
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
using WPFChart.UC;
using WPFChart.ViewModel;


namespace WPFChart.UC {
    
    
    /// <summary>
    /// GpsCnPowerChart
    /// </summary>
    public partial class GpsCnPowerChart : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\GpsCnPowerChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPFChart.ViewModel.GpsCnPowerVM VM;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\View\GpsCnPowerChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.Pane defaultPane;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\..\View\GpsCnPowerChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFChart;component/view/gpscnpowerchart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\GpsCnPowerChart.xaml"
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
            this.VM = ((WPFChart.ViewModel.GpsCnPowerVM)(target));
            return;
            case 2:
            
            #line 124 "..\..\..\View\GpsCnPowerChart.xaml"
            ((DevExpress.Xpf.Charts.XYDiagram2D)(target)).Zoom += new DevExpress.Xpf.Charts.XYDiagram2DZoomEventHandler(this.XYDiagram2D_Zoom);
            
            #line default
            #line hidden
            return;
            case 3:
            this.defaultPane = ((DevExpress.Xpf.Charts.Pane)(target));
            return;
            case 4:
            this.button = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


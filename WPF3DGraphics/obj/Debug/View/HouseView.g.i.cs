﻿#pragma checksum "..\..\..\View\HouseView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E22751FA796FBBEC7A8A4FBCE9E02F8E021E97B4E10997FFC925A505EC421D76"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
using WPF3DGraphics.View;


namespace WPF3DGraphics.View {
    
    
    /// <summary>
    /// HouseView
    /// </summary>
    public partial class HouseView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\View\HouseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.ModelVisual3D Light;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\HouseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.GeometryModel3D Sides;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\HouseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.GeometryModel3D Ends;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\View\HouseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliX;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\View\HouseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliY;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\View\HouseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliZ;
        
        #line default
        #line hidden
        
        
        #line 241 "..\..\..\View\HouseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.DrawingGroup House;
        
        #line default
        #line hidden
        
        
        #line 243 "..\..\..\View\HouseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GeometryDrawing Front;
        
        #line default
        #line hidden
        
        
        #line 247 "..\..\..\View\HouseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GeometryDrawing Side;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\View\HouseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GeometryDrawing Roof;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF3DGraphics;component/view/houseview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\HouseView.xaml"
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
            this.Light = ((System.Windows.Media.Media3D.ModelVisual3D)(target));
            return;
            case 2:
            this.Sides = ((System.Windows.Media.Media3D.GeometryModel3D)(target));
            return;
            case 3:
            this.Ends = ((System.Windows.Media.Media3D.GeometryModel3D)(target));
            return;
            case 4:
            this.sliX = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.sliY = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.sliZ = ((System.Windows.Controls.Slider)(target));
            return;
            case 7:
            this.House = ((System.Windows.Media.DrawingGroup)(target));
            return;
            case 8:
            this.Front = ((System.Windows.Media.GeometryDrawing)(target));
            return;
            case 9:
            this.Side = ((System.Windows.Media.GeometryDrawing)(target));
            return;
            case 10:
            this.Roof = ((System.Windows.Media.GeometryDrawing)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


#pragma checksum "..\..\..\..\..\Views\Frames\PageOranisationCredits.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "963A05D94F2D905FA7B6B921E5A4F386E3B8D631"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Bestour.Views.Frames;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Bestour.Views.Frames {
    
    
    /// <summary>
    /// PageOranisationCredits
    /// </summary>
    public partial class PageOranisationCredits : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\Views\Frames\PageOranisationCredits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUploadMedia;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\Views\Frames\PageOranisationCredits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnContinue;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\Views\Frames\PageOranisationCredits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBackspace;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Bestour;component/views/frames/pageoranisationcredits.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Frames\PageOranisationCredits.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnUploadMedia = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\Views\Frames\PageOranisationCredits.xaml"
            this.BtnUploadMedia.Click += new System.Windows.RoutedEventHandler(this.BtnUploadMedia_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnContinue = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\..\Views\Frames\PageOranisationCredits.xaml"
            this.BtnContinue.Click += new System.Windows.RoutedEventHandler(this.BtnContinue_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnBackspace = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\..\Views\Frames\PageOranisationCredits.xaml"
            this.BtnBackspace.Click += new System.Windows.RoutedEventHandler(this.BtnBackspace_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


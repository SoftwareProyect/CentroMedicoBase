#ExternalChecksum ("..\..\WinMedicina.xaml", "{ff1816ec-aa5e-4d10-87f7-6f4963833460}", "94DFF22A190A6F645FD843030EAC793842911BB6")
'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports CentroMedico3
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''WinMedicina
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class WinMedicina
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector


#ExternalSource ("..\..\WinMedicina.xaml", 16)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> _
    Friend WithEvents in_descripcion As System.Windows.Controls.TextBox

#End ExternalSource


#ExternalSource ("..\..\WinMedicina.xaml", 17)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> _
    Friend WithEvents bt_agregar As System.Windows.Controls.Button

#End ExternalSource


#ExternalSource ("..\..\WinMedicina.xaml", 18)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> _
    Friend WithEvents bt_volver As System.Windows.Controls.Button

#End ExternalSource


#ExternalSource ("..\..\WinMedicina.xaml", 29)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> _
    Friend WithEvents cb_medicina As System.Windows.Controls.ComboBox

#End ExternalSource


#ExternalSource ("..\..\WinMedicina.xaml", 43)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> _
    Friend WithEvents in_contenido As System.Windows.Controls.TextBox

#End ExternalSource


#ExternalSource ("..\..\WinMedicina.xaml", 45)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> _
    Friend WithEvents in_cantidad As System.Windows.Controls.TextBox

#End ExternalSource

    Private _contentLoaded As Boolean

    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")> _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/CentroMedico3;component/winmedicina.xaml", System.UriKind.Relative)

#ExternalSource ("..\..\WinMedicina.xaml", 1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)

#End ExternalSource
    End Sub

    <System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"), _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never), _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"), _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"), _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")> _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then

#ExternalSource ("..\..\WinMedicina.xaml", 8)
            AddHandler CType(target, WinMedicina).Loaded, New System.Windows.RoutedEventHandler(AddressOf Me.Window_Loaded)

#End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.in_descripcion = CType(target, System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 3) Then
            Me.bt_agregar = CType(target, System.Windows.Controls.Button)

#ExternalSource ("..\..\WinMedicina.xaml", 17)
            AddHandler Me.bt_agregar.Click, New System.Windows.RoutedEventHandler(AddressOf Me.bt_agregar_Click)

#End ExternalSource
            Return
        End If
        If (connectionId = 4) Then
            Me.bt_volver = CType(target, System.Windows.Controls.Button)

#ExternalSource ("..\..\WinMedicina.xaml", 18)
            AddHandler Me.bt_volver.Click, New System.Windows.RoutedEventHandler(AddressOf Me.bt_volver_Click)

#End ExternalSource
            Return
        End If
        If (connectionId = 5) Then
            Me.lv_medicina = CType(target, System.Windows.Controls.ListView)
            Return
        End If
        If (connectionId = 6) Then
            Me.cb_medicina = CType(target, System.Windows.Controls.ComboBox)

#ExternalSource ("..\..\WinMedicina.xaml", 30)
            AddHandler Me.cb_medicina.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cb_medicina_SelectionChanged)

#End ExternalSource
            Return
        End If
        If (connectionId = 7) Then
            Me.in_contenido = CType(target, System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 8) Then
            Me.in_cantidad = CType(target, System.Windows.Controls.TextBox)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class


﻿#ExternalChecksum("..\..\WinAtencionMedica.xaml","{ff1816ec-aa5e-4d10-87f7-6f4963833460}","0D4FC1BA40CE2F64612699F25B58E23C95F0CF96")
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
'''WinAtencionMedica
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class WinAtencionMedica
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\WinAtencionMedica.xaml",26)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents in_Peso As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinAtencionMedica.xaml",27)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents in_Estatura As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinAtencionMedica.xaml",28)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents in_Presion As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinAtencionMedica.xaml",29)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents in_Temperatura As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinAtencionMedica.xaml",37)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents in_Diagnostico As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinAtencionMedica.xaml",40)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lv_medicina As System.Windows.Controls.ListView
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinAtencionMedica.xaml",56)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents bt_historia_clinica As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinAtencionMedica.xaml",57)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents bt_agregar_medicina As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinAtencionMedica.xaml",58)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents bt_guardar_consulta As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinAtencionMedica.xaml",59)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents bt_volver As System.Windows.Controls.Button
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/CentroMedico3;component/winatencionmedica.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\WinAtencionMedica.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.in_Peso = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 2) Then
            Me.in_Estatura = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 3) Then
            Me.in_Presion = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 4) Then
            Me.in_Temperatura = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 5) Then
            Me.in_Diagnostico = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 6) Then
            Me.lv_medicina = CType(target,System.Windows.Controls.ListView)
            Return
        End If
        If (connectionId = 7) Then
            Me.bt_historia_clinica = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\WinAtencionMedica.xaml",56)
            AddHandler Me.bt_historia_clinica.Click, New System.Windows.RoutedEventHandler(AddressOf Me.bt_historia_clinica_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 8) Then
            Me.bt_agregar_medicina = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\WinAtencionMedica.xaml",57)
            AddHandler Me.bt_agregar_medicina.Click, New System.Windows.RoutedEventHandler(AddressOf Me.bt_agregar_medicina_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 9) Then
            Me.bt_guardar_consulta = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\WinAtencionMedica.xaml",58)
            AddHandler Me.bt_guardar_consulta.Click, New System.Windows.RoutedEventHandler(AddressOf Me.bt_guardar_consulta_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 10) Then
            Me.bt_volver = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\WinAtencionMedica.xaml",59)
            AddHandler Me.bt_volver.Click, New System.Windows.RoutedEventHandler(AddressOf Me.bt_volver_Click)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class


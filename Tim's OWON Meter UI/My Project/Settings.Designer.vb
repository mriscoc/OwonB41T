﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.10.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Users\timon\Documents\Visual Studio Projects\_Repositorys\OwonB41T\x64\Release"& _ 
            "\OwonB41T.exe")>  _
        Public Property TextBox_Shell_Path_Text() As String
            Get
                Return CType(Me("TextBox_Shell_Path_Text"),String)
            End Get
            Set
                Me("TextBox_Shell_Path_Text") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UI_Width_Max() As Boolean
            Get
                Return CType(Me("UI_Width_Max"),Boolean)
            End Get
            Set
                Me("UI_Width_Max") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property Form1_Location() As Global.System.Drawing.Point
            Get
                Return CType(Me("Form1_Location"),Global.System.Drawing.Point)
            End Get
            Set
                Me("Form1_Location") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property Form_Plot_Location() As Global.System.Drawing.Point
            Get
                Return CType(Me("Form_Plot_Location"),Global.System.Drawing.Point)
            End Get
            Set
                Me("Form_Plot_Location") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("60")>  _
        Public Property ComboBox_Range_Text() As String
            Get
                Return CType(Me("ComboBox_Range_Text"),String)
            End Get
            Set
                Me("ComboBox_Range_Text") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property NumericUpDown_PlotPoints_Value() As Decimal
            Get
                Return CType(Me("NumericUpDown_PlotPoints_Value"),Decimal)
            End Get
            Set
                Me("NumericUpDown_PlotPoints_Value") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CheckBox_Auto_Checked() As Boolean
            Get
                Return CType(Me("CheckBox_Auto_Checked"),Boolean)
            End Get
            Set
                Me("CheckBox_Auto_Checked") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property RadioButton_Range_Checked() As Integer
            Get
                Return CType(Me("RadioButton_Range_Checked"),Integer)
            End Get
            Set
                Me("RadioButton_Range_Checked") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0.6")>  _
        Public Property NumericUpDown_ReadInterval_Value() As Decimal
            Get
                Return CType(Me("NumericUpDown_ReadInterval_Value"),Decimal)
            End Get
            Set
                Me("NumericUpDown_ReadInterval_Value") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property NumericUpDown_ZoomLevel_Value() As Decimal
            Get
                Return CType(Me("NumericUpDown_ZoomLevel_Value"),Decimal)
            End Get
            Set
                Me("NumericUpDown_ZoomLevel_Value") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SaveFileDialog1_FileName() As String
            Get
                Return CType(Me("SaveFileDialog1_FileName"),String)
            End Get
            Set
                Me("SaveFileDialog1_FileName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CheckBox_AppendFile_Checked() As Boolean
            Get
                Return CType(Me("CheckBox_AppendFile_Checked"),Boolean)
            End Get
            Set
                Me("CheckBox_AppendFile_Checked") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property NumericUpDown_RecordInterval_Value() As Decimal
            Get
                Return CType(Me("NumericUpDown_RecordInterval_Value"),Decimal)
            End Get
            Set
                Me("NumericUpDown_RecordInterval_Value") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property NumericUpDown_RecordNumberOfReading() As Decimal
            Get
                Return CType(Me("NumericUpDown_RecordNumberOfReading"),Decimal)
            End Get
            Set
                Me("NumericUpDown_RecordNumberOfReading") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TextBox_FileName_Text() As String
            Get
                Return CType(Me("TextBox_FileName_Text"),String)
            End Get
            Set
                Me("TextBox_FileName_Text") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property LogFileName() As String
            Get
                Return CType(Me("LogFileName"),String)
            End Get
            Set
                Me("LogFileName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property Form_LogALL_Location() As Global.System.Drawing.Point
            Get
                Return CType(Me("Form_LogALL_Location"),Global.System.Drawing.Point)
            End Get
            Set
                Me("Form_LogALL_Location") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Tim_s_OWON_Meter_UI.My.MySettings
            Get
                Return Global.Tim_s_OWON_Meter_UI.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace

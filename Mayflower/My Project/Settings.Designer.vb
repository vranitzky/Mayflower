﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34003
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Public NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
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
         Global.System.Configuration.DefaultSettingValueAttribute("192.168.0.56")>  _
        Public Property DBAddress() As String
            Get
                Return CType(Me("DBAddress"),String)
            End Get
            Set
                Me("DBAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3050")>  _
        Public Property DBPort() As String
            Get
                Return CType(Me("DBPort"),String)
            End Get
            Set
                Me("DBPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("E:\Program Files (x86)\AIT\Projetex 9\Projetex Server\Database\Projetex.fdb")>  _
        Public Property DBFile() As String
            Get
                Return CType(Me("DBFile"),String)
            End Get
            Set
                Me("DBFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("password")>  _
        Public Property DBPassword() As String
            Get
                Return CType(Me("DBPassword"),String)
            End Get
            Set
                Me("DBPassword") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("User=ODBC;Password=pwww;Database=c:\projetex9\projetex server\database\projetex.f"& _ 
            "db;DataSource=192.168.56.101;Port=3050;Dialect=3;Charset=UTF8;Role=PROJETEX_ODBC"& _ 
            ";Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=81"& _ 
            "92")>  _
        Public Property ProjetexDB() As String
            Get
                Return CType(Me("ProjetexDB"),String)
            End Get
            Set
                Me("ProjetexDB") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("character set=UTF8;data source=192.168.0.56;initial catalog=""E:\Program Files (x8"& _ 
            "6)\AIT\Projetex 9\Projetex Server\Database\Projetex.fdb"";user id=ODBC;password=p"& _ 
            "assword;role=PROJETEX_ODBC")>  _
        Public ReadOnly Property ProjetexDB2() As String
            Get
                Return CType(Me("ProjetexDB2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property WindowLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("WindowLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("WindowLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Normal")>  _
        Public Property MainFormWindowState() As Global.System.Windows.Forms.FormWindowState
            Get
                Return CType(Me("MainFormWindowState"),Global.System.Windows.Forms.FormWindowState)
            End Get
            Set
                Me("MainFormWindowState") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MainFormSize() As String
            Get
                Return CType(Me("MainFormSize"),String)
            End Get
            Set
                Me("MainFormSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("837, 435")>  _
        Public Property test() As Global.System.Drawing.Size
            Get
                Return CType(Me("test"),Global.System.Drawing.Size)
            End Get
            Set
                Me("test") = value
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
        Friend ReadOnly Property Settings() As Global.Mayflower.My.MySettings
            Get
                Return Global.Mayflower.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace

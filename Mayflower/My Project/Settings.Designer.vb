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
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
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
         Global.System.Configuration.DefaultSettingValueAttribute("E:\Program Files (x86)\AIT\Projetex 9\Projetex Server\Database\projetex.fdb")>  _
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
         Global.System.Configuration.DefaultSettingValueAttribute("character set=UTF8;data source=192.168.0.56;initial catalog=""E:\Program Files (x8"& _ 
            "6)\AIT\Projetex 9\Projetex Server\Database\projetex.fdb"";user id=ODBC;password=p"& _ 
            "assword;role=PROJETEX_ODBC")>  _
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
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)>  _
        Public ReadOnly Property ProjetexDB2() As String
            Get
                Return CType(Me("ProjetexDB2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property test2() As String
            Get
                Return CType(Me("test2"),String)
            End Get
            Set
                Me("test2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100, 100")>  _
        Public Property MFLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("MFLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("MFLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("192.168.0.56")>  _
        Public Property DBAddrTEST() As String
            Get
                Return CType(Me("DBAddrTEST"),String)
            End Get
            Set
                Me("DBAddrTEST") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Write the subject of the email here.")>  _
        Public Property EmailSubject() As String
            Get
                Return CType(Me("EmailSubject"),String)
            End Get
            Set
                Me("EmailSubject") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" ?>  <html xmlns=""http://www.w3.org/1999/xhtml"">  <head>  <met"& _ 
            "a content=""TX20_HTM 20.0.405.501"" name=""GENERATOR"" />  <title></title>  </head> "& _ 
            " <body style=""font-family:'Arial';font-size:12pt;text-align:left;"">  <p lang=""en"& _ 
            "-GB"" style=""margin-top:0pt;margin-bottom:0pt;""><span style=""font-family:'Calibri"& _ 
            "';font-size:11pt;"">Test</span></p>  <p lang=""en-GB"" style=""margin-top:0pt;margin"& _ 
            "-bottom:0pt;""><span style=""font-family:'Calibri';font-size:11pt;""> </span></p>  "& _ 
            "<p lang=""en-GB"" style=""margin-top:0pt;margin-bottom:0pt;""><span style=""font-fami"& _ 
            "ly:'Times New Roman';font-size:10pt;color:#000080;"">Thanks &amp; Regards,</span>"& _ 
            "</p>  <p lang=""en-GB"" style=""margin-top:0pt;margin-bottom:0pt;""><span style=""fon"& _ 
            "t-family:'Times New Roman';font-size:10pt;color:#000080;"">Mohamed Kunhi M A</spa"& _ 
            "n></p>  <p lang=""en-GB"" style=""margin-top:0pt;margin-bottom:0pt;""><span style=""f"& _ 
            "ont-family:'Times New Roman';font-size:10pt;color:#000080;"">System Administrator"& _ 
            "</span></p>  <p lang=""en-GB"" style=""margin-top:0pt;margin-bottom:0pt;""><a href="""& _ 
            "http://mayflowerlanguages.com/"" style=""color:#E36C0A;font-weight:bold;text-decor"& _ 
            "ation:underline ;"">Mayflower Language Services (P) Ltd.</a></p>  <p lang=""en-GB"""& _ 
            " style=""margin-top:0pt;margin-bottom:0pt;""><span style=""font-family:'Century';fo"& _ 
            "nt-size:10pt;font-weight:bold;"">An ISO 9001:2008 &amp; 27001:2005 Certified Orga"& _ 
            "nization</span></p>  <p lang=""en-GB"" style=""margin-top:0pt;margin-bottom:0pt;""><"& _ 
            "span style=""font-family:'Times New Roman';font-size:10pt;"">Landline : 91-80-2210"& _ 
            "1888<br />  </span><a href=""mailto:Mohamed@mayflowerlanguages.com"" style=""font-f"& _ 
            "amily:'Times New Roman';font-size:10pt;color:#0000FF;text-decoration:underline ;"& _ 
            """>Mohamed@mayflowerlanguages.com</a><span style=""font-family:'Times New Roman';f"& _ 
            "ont-size:10pt;color:#0000FF;"">  |</span><a href=""http://www.mayflowerlanguages.c"& _ 
            "om/"" style=""font-family:'Times New Roman';font-size:10pt;color:#0000FF;text-deco"& _ 
            "ration:underline ;"">www.mayflowerlanguages.com</a></p>  <p lang=""en-GB"" style=""m"& _ 
            "argin-top:0pt;margin-bottom:0pt;""><span style=""font-size:9pt;color:#E36C0A;font-"& _ 
            "weight:bold;""> </span></p>  <p lang=""en-GB"" style=""margin-top:0pt;margin-bottom:"& _ 
            "0pt;""><span style=""font-size:9pt;color:#E36C0A;font-weight:bold;"">LOCALIZATION |"& _ 
            " TRANSLATION | TESTING | VOICEOVER | MEDIA MONITORING</span></p>  <p lang=""en-GB"& _ 
            """ style=""margin-top:0pt;margin-bottom:0pt;""><span style=""font-size:9pt;color:#E3"& _ 
            "6C0A;font-weight:bold;""> </span></p>  <p lang=""en-GB"" style=""margin-top:0pt;marg"& _ 
            "in-bottom:0pt;""><span style=""font-family:'Cambria';"">Celebrating 10 Years of  Ex"& _ 
            "cellence in Translation &amp; Localization !!!</span></p>  </body>  </html>")>  _
        Public Property EmailBody() As String
            Get
                Return CType(Me("EmailBody"),String)
            End Get
            Set
                Me("EmailBody") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Enter your full name here")>  _
        Public Property EmailSettingsName() As String
            Get
                Return CType(Me("EmailSettingsName"),String)
            End Get
            Set
                Me("EmailSettingsName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Enter your email here")>  _
        Public Property EmailSettingsEmail() As String
            Get
                Return CType(Me("EmailSettingsEmail"),String)
            End Get
            Set
                Me("EmailSettingsEmail") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("mail.mayflowerlanguages.com")>  _
        Public Property EmailSettingsServer() As String
            Get
                Return CType(Me("EmailSettingsServer"),String)
            End Get
            Set
                Me("EmailSettingsServer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("587")>  _
        Public Property EmailSettingsPort() As String
            Get
                Return CType(Me("EmailSettingsPort"),String)
            End Get
            Set
                Me("EmailSettingsPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property EmailSettingsPassword() As String
            Get
                Return CType(Me("EmailSettingsPassword"),String)
            End Get
            Set
                Me("EmailSettingsPassword") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property FirstRun() As Boolean
            Get
                Return CType(Me("FirstRun"),Boolean)
            End Get
            Set
                Me("FirstRun") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property EmailTestMode() As Boolean
            Get
                Return CType(Me("EmailTestMode"),Boolean)
            End Get
            Set
                Me("EmailTestMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property AttachmentOpenFileDir() As String
            Get
                Return CType(Me("AttachmentOpenFileDir"),String)
            End Get
            Set
                Me("AttachmentOpenFileDir") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property EmailTemplatesBodies() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("EmailTemplatesBodies"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("EmailTemplatesBodies") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property EmailTemplatesSubjects() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("EmailTemplatesSubjects"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("EmailTemplatesSubjects") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property EmailTemplatesNames() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("EmailTemplatesNames"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("EmailTemplatesNames") = value
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

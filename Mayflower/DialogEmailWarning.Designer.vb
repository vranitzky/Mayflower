<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogEmailWarning
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogEmailWarning))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelYouAreSending = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmailBody = New TXTextControl.TextControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBoxRemindMe = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(590, 456)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelYouAreSending, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.EmailBody, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBoxRemindMe, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 1, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(724, 407)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'LabelYouAreSending
        '
        Me.LabelYouAreSending.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.LabelYouAreSending, 2)
        Me.LabelYouAreSending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelYouAreSending.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelYouAreSending.Location = New System.Drawing.Point(3, 0)
        Me.LabelYouAreSending.Name = "LabelYouAreSending"
        Me.LabelYouAreSending.Size = New System.Drawing.Size(683, 20)
        Me.LabelYouAreSending.TabIndex = 0
        Me.LabelYouAreSending.Text = "You are sending the following email to {0}:"
        Me.LabelYouAreSending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 290)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Body:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EmailBody
        '
        Me.EmailBody.BorderStyle = TXTextControl.BorderStyle.FixedSingle
        Me.EmailBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailBody.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.EmailBody.Location = New System.Drawing.Point(55, 49)
        Me.EmailBody.Name = "EmailBody"
        Me.EmailBody.Size = New System.Drawing.Size(631, 284)
        Me.EmailBody.TabIndex = 4
        Me.EmailBody.ViewMode = TXTextControl.ViewMode.SimpleControl
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Mayflower.My.MySettings.Default, "EmailSubject", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(55, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(631, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = Global.Mayflower.My.MySettings.Default.EmailSubject
        '
        'CheckBoxRemindMe
        '
        Me.CheckBoxRemindMe.AutoSize = True
        Me.CheckBoxRemindMe.Checked = True
        Me.CheckBoxRemindMe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRemindMe.Location = New System.Drawing.Point(55, 387)
        Me.CheckBoxRemindMe.Name = "CheckBoxRemindMe"
        Me.CheckBoxRemindMe.Size = New System.Drawing.Size(151, 17)
        Me.CheckBoxRemindMe.TabIndex = 0
        Me.CheckBoxRemindMe.Text = "Remind me for this session"
        Me.CheckBoxRemindMe.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Attach:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "DocAdd")
        Me.Icons.Images.SetKeyName(1, "DocRemove")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = Global.Mayflower.My.MySettings.Default.AttachmentOpenFileDir
        Me.OpenFileDialog1.Title = "Select Attachment"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageKey = "DocAdd"
        Me.Button1.ImageList = Me.Icons
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.MinimumSize = New System.Drawing.Size(80, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(55, 339)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(631, 42)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageKey = "DocAdd"
        Me.Button2.ImageList = Me.Icons
        Me.Button2.Location = New System.Drawing.Point(89, 3)
        Me.Button2.MinimumSize = New System.Drawing.Size(80, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 36)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Add"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageKey = "DocAdd"
        Me.Button3.ImageList = Me.Icons
        Me.Button3.Location = New System.Drawing.Point(175, 3)
        Me.Button3.MinimumSize = New System.Drawing.Size(80, 36)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 36)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Add"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageKey = "DocAdd"
        Me.Button4.ImageList = Me.Icons
        Me.Button4.Location = New System.Drawing.Point(261, 3)
        Me.Button4.MinimumSize = New System.Drawing.Size(80, 36)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 36)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Add"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.ImageKey = "DocAdd"
        Me.Button5.ImageList = Me.Icons
        Me.Button5.Location = New System.Drawing.Point(347, 3)
        Me.Button5.MinimumSize = New System.Drawing.Size(80, 36)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 36)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Add"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DialogEmailWarning
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(748, 497)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogEmailWarning"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Warning"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelYouAreSending As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EmailBody As TXTextControl.TextControl
    Friend WithEvents CheckBoxRemindMe As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm
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
        Me.YMail = New System.Windows.Forms.TextBox
        Me.YPass = New System.Windows.Forms.TextBox
        Me.STo = New System.Windows.Forms.TextBox
        Me.Subj = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Bsend = New System.Windows.Forms.Button
        Me.RTBdy = New System.Windows.Forms.RichTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.HM = New System.Windows.Forms.RadioButton
        Me.GM = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.AtF = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'YMail
        '
        Me.YMail.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YMail.Location = New System.Drawing.Point(103, 12)
        Me.YMail.Multiline = True
        Me.YMail.Name = "YMail"
        Me.YMail.Size = New System.Drawing.Size(172, 27)
        Me.YMail.TabIndex = 1
        '
        'YPass
        '
        Me.YPass.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YPass.Location = New System.Drawing.Point(412, 12)
        Me.YPass.Multiline = True
        Me.YPass.Name = "YPass"
        Me.YPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.YPass.Size = New System.Drawing.Size(172, 27)
        Me.YPass.TabIndex = 2
        '
        'STo
        '
        Me.STo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STo.Location = New System.Drawing.Point(103, 75)
        Me.STo.Multiline = True
        Me.STo.Name = "STo"
        Me.STo.Size = New System.Drawing.Size(481, 27)
        Me.STo.TabIndex = 3
        '
        'Subj
        '
        Me.Subj.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subj.Location = New System.Drawing.Point(103, 45)
        Me.Subj.Multiline = True
        Me.Subj.Name = "Subj"
        Me.Subj.Size = New System.Drawing.Size(481, 27)
        Me.Subj.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Your Mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(281, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Your Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Send To"
        '
        'Bsend
        '
        Me.Bsend.Location = New System.Drawing.Point(18, 172)
        Me.Bsend.Name = "Bsend"
        Me.Bsend.Size = New System.Drawing.Size(79, 34)
        Me.Bsend.TabIndex = 9
        Me.Bsend.Text = "Send"
        Me.Bsend.UseVisualStyleBackColor = True
        '
        'RTBdy
        '
        Me.RTBdy.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBdy.Location = New System.Drawing.Point(12, 221)
        Me.RTBdy.Name = "RTBdy"
        Me.RTBdy.Size = New System.Drawing.Size(847, 208)
        Me.RTBdy.TabIndex = 10
        Me.RTBdy.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HM)
        Me.GroupBox1.Controls.Add(Me.GM)
        Me.GroupBox1.Location = New System.Drawing.Point(590, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 73)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose"
        '
        'HM
        '
        Me.HM.AutoSize = True
        Me.HM.Location = New System.Drawing.Point(6, 45)
        Me.HM.Name = "HM"
        Me.HM.Size = New System.Drawing.Size(41, 17)
        Me.HM.TabIndex = 1
        Me.HM.TabStop = True
        Me.HM.Text = "live"
        Me.HM.UseVisualStyleBackColor = True
        '
        'GM
        '
        Me.GM.AutoSize = True
        Me.GM.Location = New System.Drawing.Point(6, 19)
        Me.GM.Name = "GM"
        Me.GM.Size = New System.Drawing.Size(58, 17)
        Me.GM.TabIndex = 0
        Me.GM.TabStop = True
        Me.GM.Text = "Google"
        Me.GM.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(23, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Attach File"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AtF
        '
        Me.AtF.Enabled = False
        Me.AtF.Location = New System.Drawing.Point(120, 125)
        Me.AtF.Multiline = True
        Me.AtF.Name = "AtF"
        Me.AtF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AtF.Size = New System.Drawing.Size(464, 53)
        Me.AtF.TabIndex = 14
        '
        'frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(872, 460)
        Me.Controls.Add(Me.AtF)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RTBdy)
        Me.Controls.Add(Me.Bsend)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Subj)
        Me.Controls.Add(Me.STo)
        Me.Controls.Add(Me.YPass)
        Me.Controls.Add(Me.YMail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm"
        Me.Text = "Send Mail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YMail As System.Windows.Forms.TextBox
    Friend WithEvents YPass As System.Windows.Forms.TextBox
    Friend WithEvents STo As System.Windows.Forms.TextBox
    Friend WithEvents Subj As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Bsend As System.Windows.Forms.Button
    Friend WithEvents RTBdy As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HM As System.Windows.Forms.RadioButton
    Friend WithEvents GM As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AtF As System.Windows.Forms.TextBox

End Class

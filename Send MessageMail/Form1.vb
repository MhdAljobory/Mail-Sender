Imports System.Net.Mail
Imports System.Net.Mail.MailMessage
Imports System.Net.NetworkCredential
Public Class frm
    Public smtp As New SmtpClient
    Public MyMSG As New MailMessage
    Private Sub Bsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsend.Click
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("Sorry your Computer is not connected to Internet")
            Exit Sub
        End If
        If STo.Text = "" Then
            MsgBox("Enter e-mail you want to send to it")
            Exit Sub
        End If
        If YPass.Text = "" Then
            MsgBox("Enter Your Password")
            Exit Sub
        End If
        If YMail.Text = "" Then
            MsgBox("Enter Your e-mail")
            Exit Sub
        End If
        If Subj.Text = "" Then
            MsgBox("Enter Your Subject of e-mail")
            Exit Sub
        End If
        If YMail.Text = "" Then
            MsgBox("Enter Your e-mail")
            Exit Sub
        End If
        If Not GM.Checked And Not HM.Checked Then
            MsgBox("Choose Your e-mail Google or Yahoo")
            Exit Sub
        End If
        MyMSG.From = New MailAddress(YMail.Text)
        MyMSG.To.Add(STo.Text)
        MyMSG.Subject = Subj.Text
        MyMSG.Body = RTBdy.Text
        MyMSG.IsBodyHtml = True
        If GM.Checked Then
            smtp.Host = "smtp.gmail.com"
        ElseIf HM.Checked Then
            smtp.Host = "smtp.live.com"
        End If
        smtp.Port = 25
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential(YMail.Text, YPass.Text)
        If AtF.Text <> "" Then
            Dim attachFile As New Attachment(AtF.Text)
            MyMSG.Attachments.Add(attachFile)
        End If
        smtp.Send(MyMSG)
        MsgBox("Your Message has been sent ")
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = " Choose File to Attach"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AtF.Text = OpenFileDialog1.FileName
        End If
    End Sub

End Class

Option Strict On
Imports System.IO
Public Class Form1
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog

        ofd.DefaultExt = "txt"
        ofd.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*"
        ofd.RestoreDirectory = True



        Dim fl As String
        ofd.ShowDialog()
        fl = ofd.FileName

        Dim sr As New StreamReader(fl)
        RichTextBox1.Text = sr.ReadToEnd()
        sr.Close()


    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        sfd.CheckFileExists = False
        sfd.CheckPathExists = False
        sfd.DefaultExt = "txt"
        sfd.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*"
        sfd.RestoreDirectory = True
        sfd.ValidateNames = True


        Dim sv As String
        sfd.ShowDialog()
        sv = sfd.FileName

        Dim sw As New StreamWriter(sv)
        sw.Write(RichTextBox1.Text)
        sw.Close()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        Dim sfd As New SaveFileDialog
        sfd.CheckFileExists = False
        sfd.CheckPathExists = False
        sfd.DefaultExt = "txt"
        sfd.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*"
        sfd.RestoreDirectory = True

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        RichTextBox1.Copy()

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
        RichTextBox1.Paste()

    End Sub
End Class

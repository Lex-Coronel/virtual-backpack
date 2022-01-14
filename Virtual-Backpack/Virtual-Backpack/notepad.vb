Imports Word = Microsoft.Office.Interop.Word
Imports System.IO

Public Class notepad
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles calculatorBtn.Click
        calculator.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        If RichTextBox1.Modified Then

            Dim msg As MsgBoxResult
            msg = MsgBox("Do you want to save changes?", MsgBoxStyle.YesNoCancel, "New Document")
            If msg = MsgBoxResult.No Then
                Me.Hide()
                homepage.Show()
            ElseIf msg = MsgBoxResult.Cancel Then
            ElseIf msg = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                Try
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                    RichTextBox1.Clear()
                Catch ex As Exception

                End Try
            End If
        Else
            Me.Hide()
            homepage.Show()
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        If RichTextBox1.Modified Then

            Dim msg As MsgBoxResult
            msg = MsgBox("Do you want to save changes?", MsgBoxStyle.YesNoCancel, "New Document")
            If msg = MsgBoxResult.No Then
                Me.Hide()
                daily_planner.Show()
            ElseIf msg = MsgBoxResult.Cancel Then
            ElseIf msg = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                Try
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                    RichTextBox1.Clear()
                Catch ex As Exception

                End Try
            End If
        Else
            Me.Hide()
            daily_planner.Show()
        End If
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        If RichTextBox1.Modified Then

            Dim msg As MsgBoxResult
            msg = MsgBox("Do you want to save changes?", MsgBoxStyle.YesNoCancel, "New Document")
            If msg = MsgBoxResult.No Then
                Me.Hide()
                sketchpad.Show()
            ElseIf msg = MsgBoxResult.Cancel Then
            ElseIf msg = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                Try
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                    RichTextBox1.Clear()
                Catch ex As Exception

                End Try
            End If
        Else
            Me.Hide()
            sketchpad.Show()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If RichTextBox1.Modified Then

            Dim msg As MsgBoxResult
            msg = MsgBox("Do you want to save changes?", MsgBoxStyle.YesNoCancel, "New Document")
            If msg = MsgBoxResult.No Then
                RichTextBox1.Clear()
            ElseIf msg = MsgBoxResult.Cancel Then
            ElseIf msg = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                Try
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                    RichTextBox1.Clear()
                Catch ex As Exception

                End Try
            End If
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If RichTextBox1.Modified Then

            Dim msg As MsgBoxResult
            msg = MsgBox("Do you want to save changes?", MsgBoxStyle.YesNoCancel, "New Document")
            If msg = MsgBoxResult.No Then
                OpenFileDialog1.ShowDialog()
                Try
                    RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                Catch ex As Exception

                End Try
            ElseIf msg = MsgBoxResult.Cancel Then
            ElseIf msg = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                Try
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                    RichTextBox1.Clear()
                Catch ex As Exception

                End Try
            End If
        Else
            OpenFileDialog1.ShowDialog()
            Try
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Try
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Try
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub OpenWordDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenWordDocumentToolStripMenuItem.Click
        If RichTextBox1.Modified Then

            Dim msg As MsgBoxResult
            msg = MsgBox("Do you want to save changes?", MsgBoxStyle.YesNoCancel, "New Document")
            If msg = MsgBoxResult.No Then
                Dim word As DialogResult = OpenFileDialog1.ShowDialog()
                Try
                    If word = Windows.Forms.DialogResult.OK Then
                        Dim path As String = OpenFileDialog1.FileName
                        Dim wdApp As Word.Application = New Word.Application()
                        Dim wdDoc As Word.Document = wdApp.Documents.Open(path.ToString)
                        Dim lines As String() = wdDoc.Paragraphs.Cast(Of Word.Paragraph) _
                    .Select(Function(x) x.Range.Text.Trim()).ToArray()

                        RichTextBox1.Lines = lines
                        wdDoc.Close(SaveChanges:=False)
                        wdApp.Quit()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf msg = MsgBoxResult.Cancel Then
            ElseIf msg = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                Try
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                    RichTextBox1.Clear()
                Catch ex As Exception

                End Try
            End If
        Else
            Dim word As DialogResult = OpenFileDialog1.ShowDialog()
            Try
                If word = Windows.Forms.DialogResult.OK Then
                    Dim path As String = OpenFileDialog1.FileName
                    Dim wdApp As Word.Application = New Word.Application()
                    Dim wdDoc As Word.Document = wdApp.Documents.Open(path.ToString)
                    Dim lines As String() = wdDoc.Paragraphs.Cast(Of Word.Paragraph) _
                    .Select(Function(x) x.Range.Text.Trim()).ToArray()

                    RichTextBox1.Lines = lines
                    wdDoc.Close(SaveChanges:=False)
                    wdApp.Quit()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub minBtn_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If RichTextBox1.CanUndo() Then
            RichTextBox1.Undo()
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        If RichTextBox1.CanRedo() Then
            RichTextBox1.Redo()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        My.Computer.Clipboard.Clear()
        If RichTextBox1.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(RichTextBox1.SelectedText)
        End If
        RichTextBox1.SelectedText = ""
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        My.Computer.Clipboard.Clear()
        If RichTextBox1.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(RichTextBox1.SelectedText)
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If My.Computer.Clipboard.ContainsText() Then
            RichTextBox1.Paste()
        End If
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim a As String
        a = InputBox("Enter text to be found")
        Dim startTxt As Integer = 0
        Dim endTxt As Integer

        endTxt = RichTextBox1.Text.LastIndexOf(a)

        RichTextBox1.SelectAll()
        RichTextBox1.SelectionBackColor = Color.White

        While startTxt < endTxt
            RichTextBox1.Find(a, startTxt, RichTextBox1.TextLength, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectionBackColor = Color.Lime

            startTxt = RichTextBox1.Text.IndexOf(a, startTxt) + 1

        End While

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        RichTextBox1.SelectedText = ""
    End Sub

    Private Sub HighlightTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighlightTextToolStripMenuItem.Click
        If RichTextBox1.SelectionLength > 0 Then
            RichTextBox1.SelectionBackColor = Color.Lime
        End If
    End Sub

    Private Sub UnhighlightTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnhighlightTextToolStripMenuItem.Click
        If RichTextBox1.SelectionLength > 0 Then
            RichTextBox1.SelectionBackColor = Color.White
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        If RichTextBox1.Modified Then

            Dim msg As MsgBoxResult
            msg = MsgBox("Do you want to save changes?", MsgBoxStyle.YesNoCancel, "New Document")
            If msg = MsgBoxResult.No Then
                Me.Hide()
                homepage.Show()
            ElseIf msg = MsgBoxResult.Cancel Then
            ElseIf msg = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                Try
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                    RichTextBox1.Clear()
                Catch ex As Exception

                End Try
            End If
        Else
            Me.Hide()
            homepage.Show()
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color
    End Sub
End Class
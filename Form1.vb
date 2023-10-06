Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim word As String
        word = TextBox1.Text


        If String.IsNullOrEmpty(word) Then
            MessageBox.Show("Please enter a word")
            Return
        End If
        If ListBox1.Items.Contains(word) Then
            MessageBox.Show("That word already exists")
            Return
        End If

        ListBox1.Items.Add(word)


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Label1.Text = ListBox1.SelectedItem.ToString()

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = Microsoft.VisualBasic.UCase(Label1.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "words"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = Microsoft.VisualBasic.LCase(Label1.Text)

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label1.ForeColor = Color.Purple
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Label1.ForeColor = Color.Blue

    End Sub
End Class

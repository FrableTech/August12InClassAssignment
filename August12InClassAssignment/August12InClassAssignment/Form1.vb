Public Class StudentInfo
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblMajor.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click
        MessageBox.Show("Hello, " & txtName.Text &
                        " ! Thank you for the input. ",
"Program End ")
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub StudentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSem.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hello, " & txtName.Text &
                        " ! My Name is Brian J. Frable.I am a junior, this fall, studying  Computer Informations Systems. I am Studying CIS 3503 - Visual Programming this Fall! This is Build version 1.0.0. This project will run through-out the VP course. This program will evolve into a survial game.  It will be composed of differnt varibles, affecting the outcome of the user's character. ",
"About ")

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup
        MessageBox.Show("Type Your Name")
    End Sub
End Class

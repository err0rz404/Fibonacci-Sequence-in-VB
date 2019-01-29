Public Class Form1
    Private Sub GO_Click(sender As Object, e As EventArgs) Handles GO.Click
        Dim x As Integer = 0
        Dim z As Integer = 1
        Dim fibo As Integer = 0
        Dim int As Integer = 0
        If TextBox1.Text = "" Then
            MsgBox("please input numbers into the text box")
        Else
            int = TextBox1.Text
        End If
        Label2.Text = ""
        If int > 0 Then
            Label2.Text = Label2.Text + x.ToString + ", "
            If int > 1 Then
                Label2.Text = Label2.Text + z.ToString + ", "
            End If
        End If
        int = int - 2
        While int > 0
            fibo = x + z
            x = z
            z = fibo
            Label2.Text = Label2.Text + fibo.ToString + ", "
            int = int - 1
        End While
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If Not IsNumeric(Chr(e.KeyCode)) Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class

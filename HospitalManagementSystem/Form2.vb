Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username = TextBox1.Text
        Dim password = TextBox2.Text
        If username = "pratik_admin" And password = "pratik_admin@sad" Then
            Label5.Text = "Login Successfull"
            Me.Hide()
            Dim myform As New Form3
            myform.Show()
        Else
            Label5.Text = "Invalid Credentials"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
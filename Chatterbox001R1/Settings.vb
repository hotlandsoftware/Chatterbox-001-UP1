Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Default" Then
            MainProgram.DefaultBackColor = Control
        End If
    End Sub
End Class
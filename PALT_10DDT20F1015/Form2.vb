Public Class Form2

    Dim myForm As New Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myForm As New Form1
        Me.Hide()
        myForm.Show()
    End Sub

End Class
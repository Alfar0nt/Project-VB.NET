Public Class Form2
    Private Sub lvRekapGaji_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvRekapGaji.SelectedIndexChanged

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
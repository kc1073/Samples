Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count As Integer
        count = 0
        For i = 0 To Me.Controls.Count - 1
            Dim name As String
            name = Me.Controls(i).GetType().ToString()
            If name.Contains("NumericUpDown") Then
                count = count + 1
            End If
        Next
        Label1.Text = count.ToString()
    End Sub
End Class

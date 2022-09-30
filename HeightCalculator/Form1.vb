Public Class frmHeightCalculator
    Private Sub frmHeightCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeight.Click

    End Sub

    Private Sub btnCalculet_Click(sender As Object, e As EventArgs) Handles btnCalculet.Click
        Dim height As Double
        If Not IsNumeric(txtHeight.Text) Then
            MessageBox.Show("身高必須是數字，請重新輸入", "警告！")
            Return
        End If
        height = CDbl(txtHeight.Text)
        lblResult.Text = "恭喜！你的身高為：" & height & " cm"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblResult.Text = ""
        txtHeight.Text = ""
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub
End Class

Public Class MenuForm

    Private Sub btnTutorial1_Click(sender As Object, e As EventArgs) Handles btnTutorial1.Click
        Dim frmOne As New Tutorial_1
        frmOne.Show()
    End Sub

    Private Sub btnTutorial2_Click(sender As Object, e As EventArgs) Handles btnTutorial2.Click
        Dim frmTwo As New Tutorial_2
        frmTwo.Show()
    End Sub

    Private Sub btnTutorial6_Click(sender As Object, e As EventArgs) Handles btnTutorial6.Click
        Dim frmSix As New Tutorial_6
        frmSix.Show()
    End Sub

    Private Sub btnTutorial10_Click(sender As Object, e As EventArgs) Handles btnTutorial10.Click
        Dim frmTen As New Tutorial_10
        frmTen.Show()
    End Sub
End Class

Public Class PayBill


    Private Sub btnRtrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRtrn.Click
        Me.Close()
    End Sub

   
    Private Sub btnWBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWBill.Click
        Bill.bill = 1
        Bill.ShowInTaskbar = False
        Bill.ShowDialog()
    End Sub

    Private Sub btnEBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEBill.Click
        Bill.bill = 2
        Bill.ShowInTaskbar = False
        Bill.ShowDialog()
    End Sub

    Private Sub btnPBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPBill.Click
        Bill.bill = 3
        Bill.ShowInTaskbar = False
        Bill.ShowDialog()
    End Sub

    Private Sub btnLBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLBill.Click
        Bill.bill = 4
        Bill.ShowInTaskbar = False
        Bill.ShowDialog()
    End Sub
End Class
Public Class Bill
    Public bill As Integer
    Dim cBal As String
    Dim bAmount As String
    Dim xx As Integer
    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Dim total As Integer = (Convert.ToInt32(cBal) - Convert.ToInt32(bAmount))
        If checkAmount() > 20000 Then
            MessageBox.Show("Sorry, You've reached the maximum $20,000.00 per day. Please try again tomorrow. Thank you!")
        Else
            If bAmount > cBal Then
                MessageBox.Show("Insufficient Amount") 
            Else
                If total < 200 Then
                    MessageBox.Show("Sorry, You must maintain atleast $200.00 on your account.")
                Else

                    If bill = 1 Then
                        lblBill.Text = "Water Bill"
                        query = "UPDATE Bill INNER JOIN Balance ON Bill.userNum = Balance.userNum SET Bill.Status = 'Paid',Balance.BalAmount = '" + total.ToString() + "' WHERE Bill.userNum  = '" + username + "' AND Bill.BillCatID = 1 AND Bill.Status = ''"
                        payBill(query)
                    ElseIf bill = 2 Then
                        lblBill.Text = "Electric Bill"
                        query = "UPDATE Bill INNER JOIN Balance ON Bill.userNum = Balance.userNum SET Bill.Status = 'Paid',Balance.BalAmount = '" + total.ToString() + "' WHERE Bill.userNum = '" + username + "' AND Bill.BillCatID = 2 AND Bill.Status = ''"
                        payBill(query)
                    ElseIf bill = 3 Then
                        lblBill.Text = "Phone Bill"
                        query = "UPDATE Bill INNER JOIN Balance ON Bill.userNum = Balance.userNum SET Bill.Status = 'Paid',Balance.BalAmount = '" + total.ToString() + "' WHERE Bill.userNum = '" + username + "' AND Bill.BillCatID = 3 AND Bill.Status = ''"
                        payBill(query)
                    ElseIf bill = 4 Then

                        lblBill.Text = "Loan Bill"
                        query = "UPDATE Bill INNER JOIN Balance ON Bill.userNum = Balance.userNum SET Bill.Status = 'Paid',Balance.BalAmount = '" + total.ToString() + "' WHERE Bill.userNum = '" + username + "' AND Bill.BillCatID = 4 AND Bill.Status = ''"
                        payBill(query)
                    End If
                End If

            End If

        End If


    End Sub



    Sub payBill(ByVal query)
        Try
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandText = query
            xx = cmd.ExecuteNonQuery
            If xx > 0 Then
                query = "INSERT INTO Transaction(Amount,transDate,userNum) VALUES(Amount = '" + bAmount + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + username + "')"
                cmd = con.CreateCommand()
                cmd.CommandText = query
                xx = cmd.ExecuteNonQuery()
                If xx > 0 Then
                    Me.Close()
                    MessageBox.Show("Bill Paid")

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If bill = 1 Then
            lblBill.Text = "Water Bill"
            query = "SELECT * FROM Bill INNER JOIN user ON user.userNum = Bill.userNum INNER JOIN Balance ON user.userNum = Balance.userNum WHERE user.userNum  = '" + username + "' AND Bill.BillCatID = 1 AND Bill.Status = ''"
            getBillInfo(query)
        ElseIf bill = 2 Then
            lblBill.Text = "Electric Bill"
            query = "SELECT * FROM Bill INNER JOIN user ON user.userNum = Bill.userNum INNER JOIN Balance ON user.userNum = Balance.userNum WHERE user.userNum = '" + username + "' AND Bill.BillCatID = 2 AND Bill.Status = ''"
            getBillInfo(query)
        ElseIf bill = 3 Then
            lblBill.Text = "Phone Bill"
            query = "SELECT * FROM Bill INNER JOIN user ON user.userNum = Bill.userNum INNER JOIN Balance ON user.userNum = Balance.userNum WHERE user.userNum = '" + username + "' AND Bill.BillCatID = 3 AND Bill.Status = ''"
            getBillInfo(query)
        ElseIf bill = 4 Then

            lblBill.Text = "Loan Bill"
            query = "SELECT * FROM Bill INNER JOIN user ON user.userNum = Bill.userNum INNER JOIN Balance ON user.userNum = Balance.userNum WHERE user.userNum = '" + username + "' AND Bill.BillCatID = 4 AND Bill.Status = ''"
            getBillInfo(query)
        End If
    End Sub

    Sub getBillInfo(ByVal query)
        Try
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandText = query
            reader = cmd.ExecuteReader
            If reader.Read Then
                lblANumber.Text = reader.GetString(5)
                lblAOwner.Text = reader.GetString(7)
                lblBAmount.Text = FormatCurrency(reader.GetString(1))
                lblCBal.Text = FormatCurrency(reader.GetString(9))
                cBal = reader.GetString(9)
                bAmount = reader.GetString(1)
                lblPaid.Hide()
                btnPay.Enabled = True
                lblANumber.Show()
                lblAOwner.Show()
                lblCBal.Show()
                lblBAmount.Show()
                Label3.Show()
                Label4.Show()
                Label5.Show()
                Label6.Show()
            Else
                lblANumber.Hide()
                lblAOwner.Hide()
                lblCBal.Hide()
                lblBAmount.Hide()
                Label3.Hide()
                Label4.Hide()
                Label5.Hide()
                Label6.Hide()
                btnPay.Enabled = False
                lblPaid.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub
End Class
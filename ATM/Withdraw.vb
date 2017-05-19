Public Class Withdraw

    
    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
       
        txtAmount.Text += "1"

    End Sub

    Private Sub btnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClr.Click
        txtAmount.Text = ""
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        txtAmount.Text += "2"
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        txtAmount.Text += "3"
    End Sub

    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        txtAmount.Text += "4"
    End Sub

    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        txtAmount.Text += "5"
    End Sub

    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click
        txtAmount.Text += "6"
    End Sub

    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click
        txtAmount.Text += "7"
    End Sub

    Private Sub btnEight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEight.Click

        txtAmount.Text += "8"
    End Sub

    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click

        txtAmount.Text += "9"

    End Sub

    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        txtAmount.Text += "0"
    End Sub
    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Dim xx As Integer
    Dim cBal As Integer
    Sub Withdraw()
        Try
            con.Open()
            query = "SELECT * FROM user INNER JOIN balance ON user.userNum = balance.userNum WHERE user.userNum = '" + username + "'"
            cmd = con.CreateCommand()
            cmd.CommandText = query
            reader = cmd.ExecuteReader
            If reader.Read() Then
                cBal = (Convert.ToInt32(reader.GetString(4)) - Convert.ToInt32(txtAmount.Text))
                reader.Close()
                If cBal < 200 Then
                    MessageBox.Show("Sorry, You must maintain atleast $200.00 on your account.")
                Else
                    query = "UPDATE user INNER JOIN balance ON user.userNum = balance.userNum SET balance.balAmount = '" + cBal.ToString() + "'WHERE user.userNum = '" + username + "'"
                    cmd = con.CreateCommand()
                    cmd.CommandText = query
                    xx = cmd.ExecuteNonQuery()
                    If xx > 0 Then
                        txtAmount.Clear()
                        query = "INSERT INTO Transaction(Amount,transDate,userNum) VALUES(Amount = '" + txtAmount.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + username + "')"
                        cmd = con.CreateCommand()
                        cmd.CommandText = query
                        xx = cmd.ExecuteNonQuery()
                        If xx > 0 Then
                            lblBal.Text = CurrentAmount()
                            MessageBox.Show("Withdraw Successful")
                        End If
                    End If
                End If
                
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub
    
    
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If txtAmount.Text <> "" Then
            If checkAmount() > 20000 Then
               
                txtAmount.Clear()
                MessageBox.Show("Sorry, You've reached the maximum $20,000.00 per day. Please try again tomorrow. Thank you!")
            Else
                If IsNumeric(txtAmount.Text) Then
                    Withdraw()
                Else
                    MessageBox.Show("Enter valid input")
                End If

            End If
        End If
    End Sub


    Private Sub Withdraw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBal.Text = CurrentAmount()
    End Sub


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If txtAmount.Text.Length > 0 Then
            txtAmount.Text = txtAmount.Text.Remove(txtAmount.Text.Length - 1, 1)
        End If
    End Sub
End Class
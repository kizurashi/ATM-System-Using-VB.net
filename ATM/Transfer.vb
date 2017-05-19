Public Class Transfer
    Dim x As String
    Dim cBal As Integer
    Dim xx As Integer
    Private Sub TextBox_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransferTo.Enter, txtAmount.Enter
        Dim currTextBox As TextBox = sender

        If currTextBox.Equals(txtTransferTo) Then
            x = "textbox1"
        ElseIf currTextBox.Equals(txtAmount) Then
            x = "textbox2"
        End If
    End Sub

    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
        If x = "textbox1" Then
            txtTransferTo.Text += "1"
        Else
            txtAmount.Text += "1"
        End If
    End Sub

    Private Sub btnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClr.Click
        If x = "textbox1" Then
            txtTransferTo.Text = ""
        Else
            txtAmount.Text = ""
        End If
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        If x = "textbox1" Then
            txtTransferTo.Text += "2"
        Else
            txtAmount.Text += "2"
        End If
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        If x = "textbox1" Then
            txtTransferTo.Text += "3"
        Else
            txtAmount.Text += "3"
        End If
    End Sub

    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        If x = "textbox1" Then
            txtTransferTo.Text += "4"
        Else
            txtAmount.Text += "4"
        End If
    End Sub

    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        If x = "textbox1" Then
            txtTransferTo.Text += "5"
        Else
            txtAmount.Text += "5"
        End If
    End Sub

    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click
        If x = "textbox1" Then
            txtTransferTo.Text += "6"
        Else
            txtAmount.Text += "6"
        End If
    End Sub

    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click
        If x = "textbox1" Then
            txtTransferTo.Text += "7"
        Else
            txtAmount.Text += "7"
        End If

    End Sub

    Private Sub btnEight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEight.Click
        If x = "textbox1" Then
            txtTransferTo.Text += "8"
        Else
            txtAmount.Text += "8"
        End If
    End Sub

    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click
        If x = "textbox1" Then
            txtTransferTo.Text += "9"
        Else
            txtAmount.Text += "9"
        End If
    End Sub

    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        If x = "textbox1" Then
            txtTransferTo.Text += "0"
        Else
            txtAmount.Text += "0"
        End If
    End Sub
    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Sub transferTo()
        Try
            con.Open()
            query = "SELECT * FROM user INNER JOIN balance ON user.userNum = balance.userNum WHERE user.userNum = '" + username + "'"
            cmd = con.CreateCommand()
            cmd.CommandText = query
            reader = cmd.ExecuteReader
            If reader.Read Then
                cBal = reader.GetString(4) - txtAmount.Text

                If cBal < 200 Then
                    MessageBox.Show("Sorry, You must maintain atleast $200.00 on your account.")
                Else
                    reader.Close()
                    query = "SELECT BalAmount FROM Balance WHERE userNum = '" + txtTransferTo.Text + "'"
                    cmd = con.CreateCommand()
                    cmd.CommandText = query
                    reader = cmd.ExecuteReader
                    If reader.Read Then
                        Dim moneyTrans As Integer = Convert.ToInt32(txtAmount.Text) + Convert.ToInt32(reader.GetString(0))
                        reader.Close()
                        query = "UPDATE balance INNER JOIN user ON user.userNum = balance.userNum  SET balAmount = '" + moneyTrans.ToString() + "' WHERE user.userNum = '" + txtTransferTo.Text + "'"
                        cmd = con.CreateCommand()
                        cmd.CommandText = query
                        xx = cmd.ExecuteNonQuery()

                        If xx > 0 Then
                            query = "UPDATE balance INNER JOIN user ON user.userNum = balance.userNum SET balAmount = '" + cBal.ToString() + "' WHERE user.userNum = '" + username + "'"
                            cmd = con.CreateCommand()
                            cmd.CommandText = query
                            xx = cmd.ExecuteNonQuery()
                            If xx > 0 Then
                                query = "INSERT INTO Transaction(Amount,transDate,userNum) VALUES(Amount = '" + txtAmount.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + username + "')"
                                cmd = con.CreateCommand()
                                cmd.CommandText = query
                                xx = cmd.ExecuteNonQuery()
                                If xx > 0 Then
                                    lblBal.Text = CurrentAmount()
                                    MessageBox.Show("Transfer successful")
                                End If
                            End If
                        End If
                    Else
                        reader.Close()
                        MessageBox.Show("Account number not found")
                    End If
                End If
                    reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub Transfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBal.Text = CurrentAmount()
    End Sub


    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If txtTransferTo.Text <> "" Or txtAmount.Text <> "" Then
            If username = txtTransferTo.Text Then
                MessageBox.Show("Sorry, You cannot transfer to your own account.")
            Else
                If checkAmount() > 20000 Then
                    txtAmount.Clear()
                    MessageBox.Show("Sorry, You've reached the maximum $20,000.00 per day. Please try again tomorrow. Thank you!")
                Else
                    If IsNumeric(txtAmount.Text) Then
                        transferTo()
                    Else
                        MessageBox.Show("Enter valid input")
                    End If

                End If

            End If
        Else
            MessageBox.Show("Fill all fields")
        End If
        

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If x = "textbox1" Then

            If txtTransferTo.Text.Length > 0 Then
                txtTransferTo.Text = txtTransferTo.Text.Remove(txtTransferTo.Text.Length - 1, 1)
            End If
        Else
            If txtAmount.Text.Length > 0 Then
                txtAmount.Text = txtAmount.Text.Remove(txtAmount.Text.Length - 1, 1)
            End If
        End If

    End Sub
End Class
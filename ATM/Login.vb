Public Class Login
    Dim x As String
    Private Sub TextBox_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCNum.Enter, txtPin.Enter
        Dim currTextBox As TextBox = sender

        If currTextBox.Equals(txtCNum) Then
            x = "textbox1"
        ElseIf currTextBox.Equals(txtPin) Then
            x = "textbox2"
        End If
    End Sub

    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
        If x = "textbox1" Then
            txtCNum.Text += "1"
        Else
            txtPin.Text += "1"
        End If
    End Sub

    Private Sub btnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClr.Click
        If x = "textbox1" Then
            txtCNum.Text = ""
        Else
            txtPin.Text = ""
        End If
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        If x = "textbox1" Then
            txtCNum.Text += "2"
        Else
            txtPin.Text += "2"
        End If
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        If x = "textbox1" Then
            txtCNum.Text += "3"
        Else
            txtPin.Text += "3"
        End If
    End Sub

    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        If x = "textbox1" Then
            txtCNum.Text += "4"
        Else
            txtPin.Text += "4"
        End If
    End Sub

    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        If x = "textbox1" Then
            txtCNum.Text += "5"
        Else
            txtPin.Text += "5"
        End If
    End Sub

    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click
        If x = "textbox1" Then
            txtCNum.Text += "6"
        Else
            txtPin.Text += "6"
        End If
    End Sub

    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click
        If x = "textbox1" Then
            txtCNum.Text += "7"
        Else
            txtPin.Text += "7"
        End If
    End Sub

    Private Sub btnEight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEight.Click
        If x = "textbox1" Then
            txtCNum.Text += "8"
        Else
            txtPin.Text += "8"
        End If
    End Sub

    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click
        If x = "textbox1" Then
            txtCNum.Text += "9"
        Else
            txtPin.Text += "9"
        End If
    End Sub

    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        If x = "textbox1" Then
            txtCNum.Text += "0"
        Else
            txtPin.Text += "0"
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If x = "textbox1" Then

            If txtCNum.Text.Length > 0 Then
                txtCNum.Text = txtCNum.Text.Remove(txtCNum.Text.Length - 1, 1)
            End If
        Else
            If txtPin.Text.Length > 0 Then
                txtPin.Text = txtPin.Text.Remove(txtPin.Text.Length - 1, 1)
            End If
        End If

    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If txtCNum.Text = "" Or txtPin.Text = "" Then
            MessageBox.Show("Fill all fields")
        Else
            If checkUser(txtCNum.Text, txtPin.Text) Then

                Main.Show()
                Me.Close()
            Else
                MessageBox.Show("Mismatch")
            End If
        End If
    End Sub


    Function checkUser(ByVal Number, ByVal Pin)
        Try
            con.Open()
            query = "SELECT * FROM user WHERE userNum = '" + Number + "' AND userPin = '" + Pin + "'"
            cmd = con.CreateCommand()
            cmd.CommandText = query
            reader = cmd.ExecuteReader
            If reader.Read Then
                username = reader.GetString(0)
                reader.Close()

                Return True
            Else
                reader.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            con.Close()
        End Try
        Return 0
    End Function



End Class
Public Class Changepin

    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click

        txtPin.Text += "1"

    End Sub

    Private Sub btnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClr.Click
        txtPin.Text = ""
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        txtPin.Text += "2"
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        txtPin.Text += "3"
    End Sub

    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        txtPin.Text += "4"
    End Sub

    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        txtPin.Text += "5"
    End Sub

    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click
        txtPin.Text += "6"
    End Sub

    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click
        txtPin.Text += "7"
    End Sub

    Private Sub btnEight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEight.Click

        txtPin.Text += "8"
    End Sub

    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click

        txtPin.Text += "9"

    End Sub

    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        txtPin.Text += "0"
    End Sub
    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If txtPin.Text <> "" Then
            If IsNumeric(txtPin.Text) Then
                changePin()
            Else
                MessageBox.Show("Enter valid input")
            End If

        Else
            MessageBox.Show("Fill all fields")
        End If
    End Sub
    Dim xx As Integer
    Sub changePin()
        Try
            con.Open()

            query = "UPDATE user SET userPin = '" + txtPin.Text + "'WHERE userNum = '" + username + "'"
            cmd = con.CreateCommand()
            cmd.CommandText = query
            xx = cmd.ExecuteNonQuery()
            If xx > 0 Then
                txtPin.Clear()
                MessageBox.Show("Pin Changed")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Changepin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

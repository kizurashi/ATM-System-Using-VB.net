Public Class Balance

    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Me.Close()
    End Sub

    Sub getAccountInfo()
        Try
            con.Open()
            query = "SELECT * FROM user INNER JOIN balance ON user.userNum = balance.userNum WHERE user.userNum = '" + username + "'"
            cmd = con.CreateCommand()
            cmd.CommandText = query
            reader = cmd.ExecuteReader
            If reader.Read Then
                lblANumber.Text = reader.GetString(0)
                lblAOwner.Text = reader.GetString(2)
                lblBal.Text = FormatCurrency(reader.GetString(4))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Balance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getAccountInfo()
    End Sub


End Class
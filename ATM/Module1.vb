Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection("host=127.0.0.1;username=root;password= '';database=atmDB")
    Public reader As MySqlDataReader
    Public cmd As MySqlCommand
    Public Property username As String
    Public query As String
    Function CurrentAmount()
        Try
            con.Close()
            con.Open()
            query = "SELECT * FROM user INNER JOIN balance ON user.userNum = balance.userNum WHERE user.userNum = '" + username + "'"
            cmd = con.CreateCommand()
            cmd.CommandText = query
            reader = cmd.ExecuteReader
            If reader.Read Then
                Return FormatCurrency(reader.GetString(4))
                reader.Close()
            Else
                reader.Close()
                Return ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            con.Close()
        End Try
        Return ""
    End Function
    Function checkAmount()
        Dim amountPerDay As Integer
        Try
            con.Close()
            con.Open()
            query = "SELECT Amount FROM Transaction WHERE userNum = '" + username + "' AND transDate = '" + Date.Now.ToString("yyyy-MM-dd") + "'"
            cmd = con.CreateCommand()
            cmd.CommandText = query
            reader = cmd.ExecuteReader
            While reader.Read 
                amountPerDay += Convert.ToInt32(reader.GetString(0))

            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            con.Close()
        End Try
        Return amountPerDay
    End Function
End Module

Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try 'es como un if'
            conectarmysql = New MySqlConnection("server=localhost;" + "database=eje;user=root;password=;") 'conectarse con el servidor de xampp'
            conectarmysql.Open() 'para abrir lo declarado anteriormente'
            conectarmysqlcomand = New MySqlCommand 'uso de comandos'
            conectarmysqlcomand.CommandType = CommandType.Text 'tipo texto'
            conectarmysqlcomand.Connection = conectarmysql 'coneccion a xampp'

        Catch ex As Exception 'descripciones'
            MsgBox("Error, Error falta conectar algunos comandos" + ex.Message, MsgBoxStyle.Critical, "BD Error") 'coneccion'
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conectarmysqlcomand.CommandText = "select * from usuario where usuario = '" + TextBox1.Text + "'AND Contraseña='" + TextBox2.Text + "'"
        Dim Ash As MySqlDataReader
        Ash = conectarmysqlcomand.ExecuteReader
        If Ash.HasRows <> False Then
            MsgBox("acceso correcto")
            Form2.Show()
        Else
            MsgBox("Acceso Dennegado ")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class

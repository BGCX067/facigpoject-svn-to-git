'importando as dll do mysql
Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class DataBase

    'Declaração da variaveis
    Const host = "localhost"
    Const port = 3306
    Const user = "root"
    Const pass = ""
    Const base = "despesapessoal"

    Private conn As New MySqlConnection
    Private cmdo As New MySqlCommand
    Private adap As New MySqlDataAdapter
    Private read As MySqlDataReader


    'Metodo de conexão com banco de dados

    Private Sub connect()
        Try
            If Not conn.State = ConnectionState.Open Then
                Dim strConn As String = "Data Source=" & host & ";port=" & port & ";user id=" & user & ";password=" & pass & "; database=" & base
                conn = New MySqlConnection()
                conn.ConnectionString = strConn
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Não foi possivel conectar ao servidor de dados!")
        End Try
    End Sub

    'Metodo que fecha a conexçao com banco de dados

    Private Sub disconnect()
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Dispose()
            conn = Nothing
        End If
    End Sub

    ' metodo para a inserção de dados no banco

    Public Function runQuery(ByVal query As String) As Integer
        Try
            connect()
            cmdo.CommandType = CommandType.Text
            cmdo.CommandText = query
            cmdo.Connection = conn
            cmdo.ExecuteNonQuery()
            Return cmdo.LastInsertedId
        Catch ex As Exception
            MessageBox.Show("Não foi possivel execultar o comando no banco de dados!")
        End Try
        Return 0
    End Function




    'metodo para retorno de leitura de dados

    Public Function runDataRead(ByVal query As String) As MySqlDataReader
        read = Nothing
        Try
            connect()
            cmdo.CommandType = CommandType.Text
            cmdo.CommandText = query
            cmdo.Connection = conn
            read = cmdo.ExecuteReader()
            cmdo.Dispose()
            Return read
        Catch ex As Exception
            MessageBox.Show("Não foi possivel execultar o comando no banco de dados!")
        End Try
        Return read
    End Function


    'metodo para execução de consulta no banco de dados

    Public Function runDataTable(ByVal query As String) As DataTable
        Dim mDataTable As New DataTable
        Try
            connect()
            cmdo.CommandType = CommandType.Text
            cmdo.CommandText = query
            cmdo.Connection = conn
            adap.SelectCommand = cmdo
            adap.Fill(mDataTable)
            adap.Dispose()
            Return mDataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return mDataTable
    End Function


End Class


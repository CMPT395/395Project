Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Sqlcon
    'DESKTOP-UUM78C3 Williams Desktop
    'DESKTOP-1NVLP4D  Leon Desktop
    '0O0              Yuhang's Desktop
    'DESKTOP-4M90S2P\LEONXIAO  leon laptop
    Private DBCon As New SqlConnection("Data Source=DESKTOP-4M90S2P\LEONXIAO;Initial Catalog=CMPT395;Integrated Security=True")
    Private DBCmd As SqlCommand
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public Params As New List(Of SqlParameter)
    Public RecordCount As Integer
    Public Exception As String
    Public DBDS As DataSet
    Public Sub New()
    End Sub
    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    Public Function HasConnection() As Boolean
        Try
            DBCon.Open()
            DBCon.Close()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Sub ExecQuery(Query As String)
        'reset query stats
        ' RecordCount = 0
        Try
            DBCon.Open()
            'database cmd
            DBCmd = New SqlCommand(Query, DBCon)
            'load param into db command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
            Params.Clear()
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            DBDS = New DataSet
            DBDA.Fill(DBDS)
            'RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            MsgBox(ex.Message)
            'close connection
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        Finally
            DBCon.Close()
        End Try
        'DBCon.Close()
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
End Class

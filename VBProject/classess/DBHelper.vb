Imports System.Configuration
Imports System.Data.SqlClient

Public Class DBHelper
    Private Shared ReadOnly _connectionString As String = ConfigurationManager.ConnectionStrings("DB").ConnectionString

    Public Function GetData(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing, Optional isStoredProcedure As Boolean = False) As DataTable
        Dim dt As New DataTable()

        Using conn As New SqlConnection(_connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.CommandType = If(isStoredProcedure, CommandType.StoredProcedure, CommandType.Text)

                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If

                Using adapter As New SqlDataAdapter(cmd)
                    Dim builder As New SqlCommandBuilder(adapter)
                    conn.Open()
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function ExecuteNonQuery(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing, Optional isStoredProcedure As Boolean = False) As Integer
        Dim affectedRows As Integer = 0

        Using conn As New SqlConnection(_connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.CommandType = If(isStoredProcedure, CommandType.StoredProcedure, CommandType.Text)

                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                conn.Open()
                affectedRows = cmd.ExecuteNonQuery()
            End Using
        End Using

        Return affectedRows
    End Function

    Public Function ExecuteScalar(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing, Optional isStoredProcedure As Boolean = False) As Object
        Using conn As New SqlConnection(_connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.CommandType = If(isStoredProcedure, CommandType.StoredProcedure, CommandType.Text)

                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If

                conn.Open()
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Function SaveChanges(dt As DataTable, selectQuery As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Integer
        If dt Is Nothing Then Throw New ArgumentNullException(NameOf(dt))
        Dim affectedRows As Integer = 0

        Using conn As New SqlConnection(_connectionString)
            Using cmd As New SqlCommand(selectQuery, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If

                Using adapter As New SqlDataAdapter(cmd)
                    Dim builder As New SqlCommandBuilder(adapter)
                    conn.Open()
                    affectedRows = adapter.Update(dt)
                    dt.AcceptChanges()
                End Using
            End Using
        End Using
        Return affectedRows
    End Function
End Class



Public Class Karyawan
    Private _nik As String
    Private _nama As String
    Private _pendidikan As Integer
    Private _status() As Boolean

    Public Sub New(ByVal nik As String, ByVal nama As String,
                   ByVal pendidikan As Integer,
                   ByVal status() As Boolean)
        _nik = nik
        _nama = nama
        _pendidikan = pendidikan
        _status = status
    End Sub

    Public Function getNama() As String
        Return _nama
    End Function

    Public Function getStatus(ByVal idx As Integer) As String
        Return _status(idx)
    End Function

    Public Function getGajipokok() As Double
        'ini adalah switch case
        Select Case _pendidikan
            Case 0 : Return 1500000
            Case 1 : Return 2000000
            Case 2 : Return 3500000
            Case Else : Return 0
        End Select
    End Function

    Public Function getPegawai() As String
        Select Case _pendidikan
            Case 0 : Return "Diploma"
            Case 1 : Return "S1"
            Case 2 : Return "Magister"
            Case Else : Return 0
        End Select
    End Function

    Public Function getTunjangan() As Double
        Dim tunjangan As Double = 0

        If (_status(0)) Then
            tunjangan += 0.1 * getGajipokok()
        End If
        If (_status(1)) Then
            tunjangan += 0.25 * getGajipokok()
        End If
        Return tunjangan
    End Function
End Class

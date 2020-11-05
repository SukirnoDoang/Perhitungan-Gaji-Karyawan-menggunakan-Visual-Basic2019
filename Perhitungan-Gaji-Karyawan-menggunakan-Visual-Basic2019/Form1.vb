Public Class Form1
    Private karyawan(20) As Karyawan
    Private idx As Integer = 0
    Private rdb(3) As RadioButton

    Private Sub WriteToTextFile(ByRef file As String)
        Dim Writer As New IO.StreamWriter(file)
        For i As Integer = 0 To ListBox1.Items.Count - 1
            Writer.WriteLine(ListBox1.Items.Item(i))
        Next
        Writer.Close()
    End Sub


    Private Sub bsimpan_Click(ByVal sender As Object, e As EventArgs) Handles bsimpan.Click
        Dim status(2) As Boolean
        Dim pendidikan As Integer = -1

        rdb(0) = rdbD3
        rdb(1) = rdbS1
        rdb(2) = rdbS2

        For i As Integer = 0 To 2
            If (rdb(i).Checked) Then
                pendidikan = i
            End If
        Next

        status(0) = ckawin.Checked
        status(1) = ctetap.Checked

        karyawan(idx) = New Karyawan(tNik.Text, tNama.Text, pendidikan, status)
        ListBox1.Items.Add(tNik.Text & "_" & tNama.Text & "_" & karyawan(idx).getPegawai)

        idx += 1
        WriteToTextFile("latihanuts.txt")
    End Sub

    Private Sub bbersih_Click(ByVal sender As Object, e As EventArgs) Handles bbersih.Click
        tNama.Text = ""
        tNik.Text = ""
        tNama1.Text = ""
        tGaji.Text = ""
        rdbD3.Checked = False
        rdbS1.Checked = False
        rdbS2.Checked = False
        ckawin.Checked = False
        ctetap.Checked = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        tNama1.Text = karyawan(ListBox1.SelectedIndex).getNama
        tGaji.Text = "Rp " &
            karyawan(ListBox1.SelectedIndex).getGajipokok +
            karyawan(ListBox1.SelectedIndex).getTunjangan
    End Sub
End Class

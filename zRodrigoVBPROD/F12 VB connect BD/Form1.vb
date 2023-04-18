Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminaRegistos.Click
        Dim obj As New DataBaseAccess

        Dim sc As String = obj.ConnectionString
        Dim ssql As String = "DELETE FROM viagens
                              DBCC CHECKIDENT('viagens', RESEED, 0);"

        obj.BuscaDados(sc, ssql)

    End Sub

    Private Sub btnIniciaRegistos_Click(sender As Object, e As EventArgs) Handles btnIniciaRegistos.Click
        Dim obj As New DataBaseAccess

        Dim sc As String = obj.ConnectionString
        Dim ssql As String = "INSERT INTO viagens (viatura, dia, km) 
        VALUES ('Fiat A', 2, 1800), ('Ford', 1, 300), ('Opel', 2, 900), ('Fiat B', 2, 1400), ('Fiat C', 1, 2200);"

        obj.BuscaDados(sc, ssql)

    End Sub

    Private Sub btnBdParaGrid_Click(sender As Object, e As EventArgs) Handles btnBdParaGrid.Click
        cbxOpcoes.Text = ""
        DesmarcarRDB()
        Dim obj As New DataBaseAccess

        Dim sc As String = obj.ConnectionString
        Dim ssql As String = "SELECT * FROM viagens;"

        dgvViagens.DataSource = obj.BuscaDados(sc, ssql)

    End Sub

    Private Sub btnLimpaGrid_Click(sender As Object, e As EventArgs) Handles btnLimpaGrid.Click
        cbxOpcoes.Text = ""
        DesmarcarRDB()
        dgvViagens.DataSource = Nothing

    End Sub

    Private Sub btnSomaKm_Click(sender As Object, e As EventArgs) Handles btnSomaKM.Click
        Dim obj As New DataBaseAccess
        Dim viatura As String = txtViatura.Text

        Dim sc As String = obj.ConnectionString
        Dim ssql As String = "SELECT SUM(km) AS Soma FROM viagens WHERE viatura = '" & viatura & "';"

        Dim somaKM As Integer = obj.BuscaDados(sc, ssql).Rows(0)(0)

        txtKMViatura.Text = somaKM.ToString

    End Sub

    Private Sub btnViagensDoisDias_Click(sender As Object, e As EventArgs) Handles btnViagensDoisDias.Click
        Dim viaturaDoisDias As String = txtViaturaDoisDias.Text
        Dim contador As Integer = 0

        For index = 0 To dgvViagens.Rows.Count - 1
            If dgvViagens.Rows(index).Cells(1).Value = viaturaDoisDias And
               dgvViagens.Rows(index).Cells(2).Value = 2 Then
                contador += 1
            End If
        Next

        txtViagensDoisDias.Text = contador.ToString

    End Sub

    Private Sub btnViaturaMaisKM_Click(sender As Object, e As EventArgs) Handles btnViaturaMaisKM.Click
        Dim valorMaiorKM As Integer = 0
        Dim aux As Integer = 0

        For index = 0 To dgvViagens.Rows.Count - 1
            Dim novoValorMaiorKM As Integer = dgvViagens.Rows(index).Cells(3).Value

            If novoValorMaiorKM > valorMaiorKM Then
                valorMaiorKM = novoValorMaiorKM
                aux = index
            End If
        Next

        Dim viaturaMaisKM As String = dgvViagens.Rows(aux).Cells(1).Value
        lstViaturaMaisKM.Items.Add(viaturaMaisKM)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnRegistoAlterado.Click
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString

        Dim id As Integer = dgvViagens.CurrentRow.Cells(0).Value
        Dim viatura As String = dgvViagens.CurrentRow.Cells(1).Value
        Dim dia As Integer = dgvViagens.CurrentRow.Cells(2).Value
        Dim km As Integer = dgvViagens.CurrentRow.Cells(3).Value

        Dim ssql As String = "UPDATE viagens SET viatura = '" & viatura & "', dia = " & dia & ", km = " & km &
                             " WHERE id = " & id & ";"

        obj.BuscaDados(sc, ssql)

    End Sub

    Private Sub btnEliminaGridBD_Click(sender As Object, e As EventArgs) Handles btnEliminaGridBD.Click
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString

        Dim id As String = txtIdViagem.Text

        For index = 0 To dgvViagens.Rows.Count - 2
            If dgvViagens.Rows(index).Cells(0).Value = CInt(id) Then
                dgvViagens.Rows.RemoveAt(index)
            End If
        Next

        Dim ssql As String = "DELETE FROM viagens WHERE id = " & id & ";"

        obj.BuscaDados(sc, ssql)

    End Sub

    Private Sub DesmarcarRDB()
        rdbViagens1Dia.Checked = False
        rdbViagens2Dias.Checked = False
        rdbViagens3Dias.Checked = False

    End Sub


    Private Sub CarregarDias()
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString
        Dim ssql As String = "SELECT * FROM viagens WHERE dia "

        If rdbViagens1Dia.Checked Then
            ssql = ssql & "= 1;"

        ElseIf rdbViagens2Dias.Checked Then
            ssql = ssql & "= 2;"

        ElseIf rdbViagens3Dias.Checked Then
            ssql = ssql & ">= 3;"

        End If

        dgvViagens.DataSource = obj.BuscaDados(sc, ssql)

    End Sub

    Private Sub rdbViagens1Dia_CheckedChanged(sender As Object, e As EventArgs) Handles rdbViagens1Dia.CheckedChanged
        Try
            CarregarDias()
            cbxOpcoes.Text = ""
        Catch
            rdbViagens1Dia.Checked = False
        End Try

    End Sub

    Private Sub rdbViagens2Dias_CheckedChanged(sender As Object, e As EventArgs) Handles rdbViagens2Dias.CheckedChanged
        Try
            CarregarDias()
            cbxOpcoes.Text = ""
        Catch
            rdbViagens2Dias.Checked = False
        End Try
    End Sub

    Private Sub rdbViagens3Dias_CheckedChanged(sender As Object, e As EventArgs) Handles rdbViagens3Dias.CheckedChanged
        Try
            CarregarDias()
            cbxOpcoes.Text = ""
        Catch
            rdbViagens3Dias.Checked = False
        End Try
    End Sub

    Private Sub cbxOpcoes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOpcoes.SelectedIndexChanged
        DesmarcarRDB()
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString
        Dim ssql As String = "SELECT * FROM viagens"

        If cbxOpcoes.SelectedIndex = 0 Then
            ssql = ssql & ";"

        ElseIf cbxOpcoes.SelectedIndex = 1 Then
            ssql = ssql & " WHERE dia = 1;"

        ElseIf cbxOpcoes.SelectedIndex = 2 Then
            ssql = ssql & " WHERE dia >= 2;"

        End If

        dgvViagens.DataSource = obj.BuscaDados(sc, ssql)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxOpcoes.Items.Add("A) Mostra na Grid todos os registos")
        cbxOpcoes.Items.Add("B) Mostra as viagens de um dia")
        cbxOpcoes.Items.Add("C) Mostra as viagens de 2 ou mais dias")
    End Sub
End Class

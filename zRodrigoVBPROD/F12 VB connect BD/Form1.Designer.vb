<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnEliminaRegistos = New System.Windows.Forms.Button()
        Me.dgvViagens = New System.Windows.Forms.DataGridView()
        Me.btnIniciaRegistos = New System.Windows.Forms.Button()
        Me.btnBdParaGrid = New System.Windows.Forms.Button()
        Me.btnLimpaGrid = New System.Windows.Forms.Button()
        Me.btnSomaKM = New System.Windows.Forms.Button()
        Me.txtViatura = New System.Windows.Forms.TextBox()
        Me.txtKMViatura = New System.Windows.Forms.TextBox()
        Me.lblViatura = New System.Windows.Forms.Label()
        Me.lblKMViatura = New System.Windows.Forms.Label()
        Me.btnViagensDoisDias = New System.Windows.Forms.Button()
        Me.txtViaturaDoisDias = New System.Windows.Forms.TextBox()
        Me.txtViagensDoisDias = New System.Windows.Forms.TextBox()
        Me.lblViaturaViagens = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnViaturaMaisKM = New System.Windows.Forms.Button()
        Me.lstViaturaMaisKM = New System.Windows.Forms.ListBox()
        Me.btnRegistoAlterado = New System.Windows.Forms.Button()
        Me.btnEliminaGridBD = New System.Windows.Forms.Button()
        Me.txtIdViagem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbViagens1Dia = New System.Windows.Forms.RadioButton()
        Me.rdbViagens2Dias = New System.Windows.Forms.RadioButton()
        Me.rdbViagens3Dias = New System.Windows.Forms.RadioButton()
        Me.cbxOpcoes = New System.Windows.Forms.ComboBox()
        CType(Me.dgvViagens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminaRegistos
        '
        Me.btnEliminaRegistos.BackColor = System.Drawing.Color.IndianRed
        Me.btnEliminaRegistos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminaRegistos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminaRegistos.Location = New System.Drawing.Point(29, 12)
        Me.btnEliminaRegistos.Name = "btnEliminaRegistos"
        Me.btnEliminaRegistos.Size = New System.Drawing.Size(171, 35)
        Me.btnEliminaRegistos.TabIndex = 0
        Me.btnEliminaRegistos.Text = "Elimina Registos"
        Me.btnEliminaRegistos.UseVisualStyleBackColor = False
        '
        'dgvViagens
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViagens.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViagens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvViagens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvViagens.BackgroundColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViagens.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvViagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViagens.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvViagens.GridColor = System.Drawing.Color.Black
        Me.dgvViagens.Location = New System.Drawing.Point(459, 226)
        Me.dgvViagens.Name = "dgvViagens"
        Me.dgvViagens.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViagens.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvViagens.Size = New System.Drawing.Size(571, 211)
        Me.dgvViagens.TabIndex = 1
        '
        'btnIniciaRegistos
        '
        Me.btnIniciaRegistos.BackColor = System.Drawing.Color.LightCoral
        Me.btnIniciaRegistos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnIniciaRegistos.Location = New System.Drawing.Point(206, 12)
        Me.btnIniciaRegistos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnIniciaRegistos.Name = "btnIniciaRegistos"
        Me.btnIniciaRegistos.Size = New System.Drawing.Size(224, 35)
        Me.btnIniciaRegistos.TabIndex = 2
        Me.btnIniciaRegistos.Text = "Inicia Registos na BD"
        Me.btnIniciaRegistos.UseVisualStyleBackColor = False
        '
        'btnBdParaGrid
        '
        Me.btnBdParaGrid.BackColor = System.Drawing.Color.LightCoral
        Me.btnBdParaGrid.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBdParaGrid.Location = New System.Drawing.Point(29, 53)
        Me.btnBdParaGrid.Name = "btnBdParaGrid"
        Me.btnBdParaGrid.Size = New System.Drawing.Size(267, 35)
        Me.btnBdParaGrid.TabIndex = 3
        Me.btnBdParaGrid.Text = "Todos registos da BD para Grid"
        Me.btnBdParaGrid.UseVisualStyleBackColor = False
        '
        'btnLimpaGrid
        '
        Me.btnLimpaGrid.BackColor = System.Drawing.Color.IndianRed
        Me.btnLimpaGrid.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpaGrid.Location = New System.Drawing.Point(302, 53)
        Me.btnLimpaGrid.Name = "btnLimpaGrid"
        Me.btnLimpaGrid.Size = New System.Drawing.Size(128, 35)
        Me.btnLimpaGrid.TabIndex = 4
        Me.btnLimpaGrid.Text = "Limpa Grid"
        Me.btnLimpaGrid.UseVisualStyleBackColor = False
        '
        'btnSomaKM
        '
        Me.btnSomaKM.BackColor = System.Drawing.Color.LightCoral
        Me.btnSomaKM.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSomaKM.Location = New System.Drawing.Point(29, 122)
        Me.btnSomaKM.Name = "btnSomaKM"
        Me.btnSomaKM.Size = New System.Drawing.Size(401, 36)
        Me.btnSomaKM.TabIndex = 5
        Me.btnSomaKM.Text = "Soma KMs uma Viatura"
        Me.btnSomaKM.UseCompatibleTextRendering = True
        Me.btnSomaKM.UseVisualStyleBackColor = False
        '
        'txtViatura
        '
        Me.txtViatura.BackColor = System.Drawing.Color.RosyBrown
        Me.txtViatura.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtViatura.Location = New System.Drawing.Point(29, 179)
        Me.txtViatura.Name = "txtViatura"
        Me.txtViatura.Size = New System.Drawing.Size(171, 25)
        Me.txtViatura.TabIndex = 6
        Me.txtViatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKMViatura
        '
        Me.txtKMViatura.BackColor = System.Drawing.Color.RosyBrown
        Me.txtKMViatura.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtKMViatura.Location = New System.Drawing.Point(206, 179)
        Me.txtKMViatura.Name = "txtKMViatura"
        Me.txtKMViatura.Size = New System.Drawing.Size(221, 25)
        Me.txtKMViatura.TabIndex = 7
        Me.txtKMViatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblViatura
        '
        Me.lblViatura.AutoSize = True
        Me.lblViatura.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblViatura.Location = New System.Drawing.Point(84, 158)
        Me.lblViatura.Name = "lblViatura"
        Me.lblViatura.Size = New System.Drawing.Size(64, 18)
        Me.lblViatura.TabIndex = 8
        Me.lblViatura.Text = "Viatura"
        '
        'lblKMViatura
        '
        Me.lblKMViatura.AutoSize = True
        Me.lblKMViatura.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblKMViatura.Location = New System.Drawing.Point(269, 161)
        Me.lblKMViatura.Name = "lblKMViatura"
        Me.lblKMViatura.Size = New System.Drawing.Size(96, 18)
        Me.lblKMViatura.TabIndex = 9
        Me.lblKMViatura.Text = "KMs Viatura"
        '
        'btnViagensDoisDias
        '
        Me.btnViagensDoisDias.BackColor = System.Drawing.Color.LightCoral
        Me.btnViagensDoisDias.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnViagensDoisDias.Location = New System.Drawing.Point(26, 226)
        Me.btnViagensDoisDias.Name = "btnViagensDoisDias"
        Me.btnViagensDoisDias.Size = New System.Drawing.Size(401, 35)
        Me.btnViagensDoisDias.TabIndex = 10
        Me.btnViagensDoisDias.Text = "Viagens de 2 dias de uma Viatura"
        Me.btnViagensDoisDias.UseVisualStyleBackColor = False
        '
        'txtViaturaDoisDias
        '
        Me.txtViaturaDoisDias.BackColor = System.Drawing.Color.RosyBrown
        Me.txtViaturaDoisDias.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtViaturaDoisDias.Location = New System.Drawing.Point(29, 283)
        Me.txtViaturaDoisDias.Name = "txtViaturaDoisDias"
        Me.txtViaturaDoisDias.Size = New System.Drawing.Size(171, 25)
        Me.txtViaturaDoisDias.TabIndex = 11
        Me.txtViaturaDoisDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtViagensDoisDias
        '
        Me.txtViagensDoisDias.BackColor = System.Drawing.Color.RosyBrown
        Me.txtViagensDoisDias.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtViagensDoisDias.Location = New System.Drawing.Point(206, 283)
        Me.txtViagensDoisDias.Name = "txtViagensDoisDias"
        Me.txtViagensDoisDias.Size = New System.Drawing.Size(221, 25)
        Me.txtViagensDoisDias.TabIndex = 12
        Me.txtViagensDoisDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblViaturaViagens
        '
        Me.lblViaturaViagens.AutoSize = True
        Me.lblViaturaViagens.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblViaturaViagens.Location = New System.Drawing.Point(84, 264)
        Me.lblViaturaViagens.Name = "lblViaturaViagens"
        Me.lblViaturaViagens.Size = New System.Drawing.Size(64, 18)
        Me.lblViaturaViagens.TabIndex = 13
        Me.lblViaturaViagens.Text = "Viatura"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblResultado.Location = New System.Drawing.Point(269, 264)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(80, 18)
        Me.lblResultado.TabIndex = 14
        Me.lblResultado.Text = "Resultado"
        '
        'btnViaturaMaisKM
        '
        Me.btnViaturaMaisKM.BackColor = System.Drawing.Color.IndianRed
        Me.btnViaturaMaisKM.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnViaturaMaisKM.Location = New System.Drawing.Point(29, 325)
        Me.btnViaturaMaisKM.Name = "btnViaturaMaisKM"
        Me.btnViaturaMaisKM.Size = New System.Drawing.Size(171, 112)
        Me.btnViaturaMaisKM.TabIndex = 15
        Me.btnViaturaMaisKM.Text = "Viatura com mais KM"
        Me.btnViaturaMaisKM.UseVisualStyleBackColor = False
        '
        'lstViaturaMaisKM
        '
        Me.lstViaturaMaisKM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstViaturaMaisKM.BackColor = System.Drawing.Color.RosyBrown
        Me.lstViaturaMaisKM.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lstViaturaMaisKM.FormattingEnabled = True
        Me.lstViaturaMaisKM.ItemHeight = 18
        Me.lstViaturaMaisKM.Location = New System.Drawing.Point(206, 325)
        Me.lstViaturaMaisKM.Name = "lstViaturaMaisKM"
        Me.lstViaturaMaisKM.Size = New System.Drawing.Size(224, 112)
        Me.lstViaturaMaisKM.TabIndex = 16
        '
        'btnRegistoAlterado
        '
        Me.btnRegistoAlterado.BackColor = System.Drawing.Color.IndianRed
        Me.btnRegistoAlterado.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistoAlterado.Location = New System.Drawing.Point(459, 12)
        Me.btnRegistoAlterado.Name = "btnRegistoAlterado"
        Me.btnRegistoAlterado.Size = New System.Drawing.Size(571, 76)
        Me.btnRegistoAlterado.TabIndex = 17
        Me.btnRegistoAlterado.Text = "Enviar registo alterado para tabela"
        Me.btnRegistoAlterado.UseVisualStyleBackColor = False
        '
        'btnEliminaGridBD
        '
        Me.btnEliminaGridBD.BackColor = System.Drawing.Color.LightCoral
        Me.btnEliminaGridBD.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminaGridBD.Location = New System.Drawing.Point(459, 94)
        Me.btnEliminaGridBD.Name = "btnEliminaGridBD"
        Me.btnEliminaGridBD.Size = New System.Drawing.Size(322, 33)
        Me.btnEliminaGridBD.TabIndex = 18
        Me.btnEliminaGridBD.Text = "Eliminar da Grid e BD"
        Me.btnEliminaGridBD.UseVisualStyleBackColor = False
        '
        'txtIdViagem
        '
        Me.txtIdViagem.BackColor = System.Drawing.Color.RosyBrown
        Me.txtIdViagem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtIdViagem.Location = New System.Drawing.Point(873, 96)
        Me.txtIdViagem.Name = "txtIdViagem"
        Me.txtIdViagem.Size = New System.Drawing.Size(157, 25)
        Me.txtIdViagem.TabIndex = 19
        Me.txtIdViagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(787, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID Viagem"
        '
        'rdbViagens1Dia
        '
        Me.rdbViagens1Dia.AutoSize = True
        Me.rdbViagens1Dia.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.rdbViagens1Dia.Location = New System.Drawing.Point(462, 145)
        Me.rdbViagens1Dia.Name = "rdbViagens1Dia"
        Me.rdbViagens1Dia.Size = New System.Drawing.Size(157, 22)
        Me.rdbViagens1Dia.TabIndex = 21
        Me.rdbViagens1Dia.TabStop = True
        Me.rdbViagens1Dia.Text = "Viagens de 1 dia"
        Me.rdbViagens1Dia.UseVisualStyleBackColor = True
        '
        'rdbViagens2Dias
        '
        Me.rdbViagens2Dias.AutoSize = True
        Me.rdbViagens2Dias.BackColor = System.Drawing.Color.MistyRose
        Me.rdbViagens2Dias.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.rdbViagens2Dias.Location = New System.Drawing.Point(654, 145)
        Me.rdbViagens2Dias.Name = "rdbViagens2Dias"
        Me.rdbViagens2Dias.Size = New System.Drawing.Size(165, 22)
        Me.rdbViagens2Dias.TabIndex = 22
        Me.rdbViagens2Dias.TabStop = True
        Me.rdbViagens2Dias.Text = "Viagens de 2 dias"
        Me.rdbViagens2Dias.UseVisualStyleBackColor = False
        '
        'rdbViagens3Dias
        '
        Me.rdbViagens3Dias.AutoSize = True
        Me.rdbViagens3Dias.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.rdbViagens3Dias.Location = New System.Drawing.Point(857, 145)
        Me.rdbViagens3Dias.Name = "rdbViagens3Dias"
        Me.rdbViagens3Dias.Size = New System.Drawing.Size(173, 22)
        Me.rdbViagens3Dias.TabIndex = 23
        Me.rdbViagens3Dias.TabStop = True
        Me.rdbViagens3Dias.Text = "Viagens de 3+ dias"
        Me.rdbViagens3Dias.UseVisualStyleBackColor = True
        '
        'cbxOpcoes
        '
        Me.cbxOpcoes.BackColor = System.Drawing.Color.RosyBrown
        Me.cbxOpcoes.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cbxOpcoes.FormattingEnabled = True
        Me.cbxOpcoes.Location = New System.Drawing.Point(462, 179)
        Me.cbxOpcoes.Name = "cbxOpcoes"
        Me.cbxOpcoes.Size = New System.Drawing.Size(568, 26)
        Me.cbxOpcoes.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1064, 469)
        Me.Controls.Add(Me.cbxOpcoes)
        Me.Controls.Add(Me.rdbViagens3Dias)
        Me.Controls.Add(Me.rdbViagens2Dias)
        Me.Controls.Add(Me.rdbViagens1Dia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdViagem)
        Me.Controls.Add(Me.btnEliminaGridBD)
        Me.Controls.Add(Me.btnRegistoAlterado)
        Me.Controls.Add(Me.lstViaturaMaisKM)
        Me.Controls.Add(Me.btnViaturaMaisKM)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblViaturaViagens)
        Me.Controls.Add(Me.txtViagensDoisDias)
        Me.Controls.Add(Me.txtViaturaDoisDias)
        Me.Controls.Add(Me.btnViagensDoisDias)
        Me.Controls.Add(Me.lblKMViatura)
        Me.Controls.Add(Me.lblViatura)
        Me.Controls.Add(Me.txtKMViatura)
        Me.Controls.Add(Me.txtViatura)
        Me.Controls.Add(Me.btnSomaKM)
        Me.Controls.Add(Me.btnLimpaGrid)
        Me.Controls.Add(Me.btnBdParaGrid)
        Me.Controls.Add(Me.btnIniciaRegistos)
        Me.Controls.Add(Me.dgvViagens)
        Me.Controls.Add(Me.btnEliminaRegistos)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvViagens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminaRegistos As Button
    Friend WithEvents dgvViagens As DataGridView
    Friend WithEvents btnIniciaRegistos As Button
    Friend WithEvents btnBdParaGrid As Button
    Friend WithEvents btnLimpaGrid As Button
    Friend WithEvents btnSomaKM As Button
    Friend WithEvents txtViatura As TextBox
    Friend WithEvents txtKMViatura As TextBox
    Friend WithEvents lblViatura As Label
    Friend WithEvents lblKMViatura As Label
    Friend WithEvents btnViagensDoisDias As Button
    Friend WithEvents txtViaturaDoisDias As TextBox
    Friend WithEvents txtViagensDoisDias As TextBox
    Friend WithEvents lblViaturaViagens As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnViaturaMaisKM As Button
    Friend WithEvents lstViaturaMaisKM As ListBox
    Friend WithEvents btnRegistoAlterado As Button
    Friend WithEvents btnEliminaGridBD As Button
    Friend WithEvents txtIdViagem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbViagens1Dia As RadioButton
    Friend WithEvents rdbViagens2Dias As RadioButton
    Friend WithEvents rdbViagens3Dias As RadioButton
    Friend WithEvents cbxOpcoes As ComboBox
End Class

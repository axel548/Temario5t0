<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.pct_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_placa = New System.Windows.Forms.Label()
        Me.lbl_tipo_placa = New System.Windows.Forms.Label()
        Me.cb_tipoPlaca = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.lbl_informacion = New System.Windows.Forms.Label()
        Me.lnklbl_admin = New System.Windows.Forms.LinkLabel()
        CType(Me.pct_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(63, 15)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(365, 31)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "Consulta de Remisiones de Tránsito"
        '
        'txt_placa
        '
        Me.txt_placa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_placa.Location = New System.Drawing.Point(30, 271)
        Me.txt_placa.MaxLength = 6
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(455, 22)
        Me.txt_placa.TabIndex = 1
        '
        'pct_logo
        '
        Me.pct_logo.Image = CType(resources.GetObject("pct_logo.Image"), System.Drawing.Image)
        Me.pct_logo.Location = New System.Drawing.Point(180, 49)
        Me.pct_logo.Name = "pct_logo"
        Me.pct_logo.Size = New System.Drawing.Size(133, 132)
        Me.pct_logo.TabIndex = 2
        Me.pct_logo.TabStop = False
        '
        'lbl_placa
        '
        Me.lbl_placa.AutoSize = True
        Me.lbl_placa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_placa.Location = New System.Drawing.Point(27, 252)
        Me.lbl_placa.Name = "lbl_placa"
        Me.lbl_placa.Size = New System.Drawing.Size(46, 16)
        Me.lbl_placa.TabIndex = 3
        Me.lbl_placa.Text = "Placa:"
        '
        'lbl_tipo_placa
        '
        Me.lbl_tipo_placa.AutoSize = True
        Me.lbl_tipo_placa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_placa.Location = New System.Drawing.Point(27, 201)
        Me.lbl_tipo_placa.Name = "lbl_tipo_placa"
        Me.lbl_tipo_placa.Size = New System.Drawing.Size(96, 16)
        Me.lbl_tipo_placa.TabIndex = 4
        Me.lbl_tipo_placa.Text = "Tipo de Placa:"
        '
        'cb_tipoPlaca
        '
        Me.cb_tipoPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipoPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tipoPlaca.FormattingEnabled = True
        Me.cb_tipoPlaca.Items.AddRange(New Object() {"P", "C", "M", "A", "U", "O", "TC"})
        Me.cb_tipoPlaca.Location = New System.Drawing.Point(30, 220)
        Me.cb_tipoPlaca.Name = "cb_tipoPlaca"
        Me.cb_tipoPlaca.Size = New System.Drawing.Size(455, 24)
        Me.cb_tipoPlaca.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_consultar)
        Me.Panel1.Controls.Add(Me.cb_tipoPlaca)
        Me.Panel1.Controls.Add(Me.lbl_titulo)
        Me.Panel1.Controls.Add(Me.lbl_tipo_placa)
        Me.Panel1.Controls.Add(Me.lbl_placa)
        Me.Panel1.Controls.Add(Me.pct_logo)
        Me.Panel1.Controls.Add(Me.txt_placa)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 381)
        Me.Panel1.TabIndex = 6
        '
        'btn_consultar
        '
        Me.btn_consultar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar.Location = New System.Drawing.Point(237, 331)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(97, 45)
        Me.btn_consultar.TabIndex = 6
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'lbl_informacion
        '
        Me.lbl_informacion.AutoSize = True
        Me.lbl_informacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_informacion.Location = New System.Drawing.Point(533, 12)
        Me.lbl_informacion.Name = "lbl_informacion"
        Me.lbl_informacion.Size = New System.Drawing.Size(166, 117)
        Me.lbl_informacion.TabIndex = 7
        Me.lbl_informacion.Text = "Tipos de Placa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P (Particular)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C (Comercial urbano de personas)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M (Motociclet" &
    "a)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A (Alquiler)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "U (Transporte Urbano)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O (Vehículos oficiales)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TC (Remolques " &
    "y semirremolques)"
        '
        'lnklbl_admin
        '
        Me.lnklbl_admin.AutoSize = True
        Me.lnklbl_admin.Location = New System.Drawing.Point(533, 380)
        Me.lnklbl_admin.Name = "lnklbl_admin"
        Me.lnklbl_admin.Size = New System.Drawing.Size(81, 13)
        Me.lnklbl_admin.TabIndex = 8
        Me.lnklbl_admin.TabStop = True
        Me.lnklbl_admin.Text = "Administradores"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(710, 405)
        Me.Controls.Add(Me.lnklbl_admin)
        Me.Controls.Add(Me.lbl_informacion)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pct_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents pct_logo As PictureBox
    Friend WithEvents lbl_placa As Label
    Friend WithEvents lbl_tipo_placa As Label
    Friend WithEvents cb_tipoPlaca As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_consultar As Button
    Friend WithEvents lbl_informacion As Label
    Friend WithEvents lnklbl_admin As LinkLabel
End Class

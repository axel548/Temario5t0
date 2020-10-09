<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class control
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(control))
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.dgv_control = New System.Windows.Forms.DataGridView()
        Me.RemisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuniDataSet = New Temario.muniDataSet()
        Me.MultasTableAdapter = New Temario.muniDataSetTableAdapters.multasTableAdapter()
        Me.txt_remision = New System.Windows.Forms.TextBox()
        Me.txt_lugar = New System.Windows.Forms.TextBox()
        Me.txt_articulo = New System.Windows.Forms.TextBox()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.lbl_remision = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_lugar = New System.Windows.Forms.Label()
        Me.lbl_articulo = New System.Windows.Forms.Label()
        Me.lbl_motivo = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_placa = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.dgv_control, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MultasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_insertar
        '
        Me.btn_insertar.Location = New System.Drawing.Point(12, 127)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(75, 23)
        Me.btn_insertar.TabIndex = 0
        Me.btn_insertar.Text = "Insertar"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Location = New System.Drawing.Point(93, 127)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(75, 23)
        Me.btn_actualizar.TabIndex = 1
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(174, 127)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(255, 127)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 3
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'dgv_control
        '
        Me.dgv_control.AllowUserToAddRows = False
        Me.dgv_control.AllowUserToDeleteRows = False
        Me.dgv_control.AllowUserToOrderColumns = True
        Me.dgv_control.AutoGenerateColumns = False
        Me.dgv_control.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_control.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RemisionDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.LugarDataGridViewTextBoxColumn, Me.ArticuloDataGridViewTextBoxColumn, Me.MotivoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.PlacaDataGridViewTextBoxColumn})
        Me.dgv_control.DataSource = Me.MultasBindingSource
        Me.dgv_control.Location = New System.Drawing.Point(12, 156)
        Me.dgv_control.Name = "dgv_control"
        Me.dgv_control.ReadOnly = True
        Me.dgv_control.Size = New System.Drawing.Size(686, 237)
        Me.dgv_control.TabIndex = 4
        '
        'RemisionDataGridViewTextBoxColumn
        '
        Me.RemisionDataGridViewTextBoxColumn.DataPropertyName = "remision"
        Me.RemisionDataGridViewTextBoxColumn.HeaderText = "remision"
        Me.RemisionDataGridViewTextBoxColumn.Name = "RemisionDataGridViewTextBoxColumn"
        Me.RemisionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LugarDataGridViewTextBoxColumn
        '
        Me.LugarDataGridViewTextBoxColumn.DataPropertyName = "lugar"
        Me.LugarDataGridViewTextBoxColumn.HeaderText = "lugar"
        Me.LugarDataGridViewTextBoxColumn.Name = "LugarDataGridViewTextBoxColumn"
        Me.LugarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "articulo"
        Me.ArticuloDataGridViewTextBoxColumn.HeaderText = "articulo"
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MotivoDataGridViewTextBoxColumn
        '
        Me.MotivoDataGridViewTextBoxColumn.DataPropertyName = "motivo"
        Me.MotivoDataGridViewTextBoxColumn.HeaderText = "motivo"
        Me.MotivoDataGridViewTextBoxColumn.Name = "MotivoDataGridViewTextBoxColumn"
        Me.MotivoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlacaDataGridViewTextBoxColumn
        '
        Me.PlacaDataGridViewTextBoxColumn.DataPropertyName = "placa"
        Me.PlacaDataGridViewTextBoxColumn.HeaderText = "placa"
        Me.PlacaDataGridViewTextBoxColumn.Name = "PlacaDataGridViewTextBoxColumn"
        Me.PlacaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MultasBindingSource
        '
        Me.MultasBindingSource.DataMember = "multas"
        Me.MultasBindingSource.DataSource = Me.MuniDataSet
        '
        'MuniDataSet
        '
        Me.MuniDataSet.DataSetName = "muniDataSet"
        Me.MuniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MultasTableAdapter
        '
        Me.MultasTableAdapter.ClearBeforeFill = True
        '
        'txt_remision
        '
        Me.txt_remision.Location = New System.Drawing.Point(65, 34)
        Me.txt_remision.Name = "txt_remision"
        Me.txt_remision.Size = New System.Drawing.Size(100, 20)
        Me.txt_remision.TabIndex = 5
        '
        'txt_lugar
        '
        Me.txt_lugar.Location = New System.Drawing.Point(237, 34)
        Me.txt_lugar.Name = "txt_lugar"
        Me.txt_lugar.Size = New System.Drawing.Size(100, 20)
        Me.txt_lugar.TabIndex = 7
        '
        'txt_articulo
        '
        Me.txt_articulo.Location = New System.Drawing.Point(237, 65)
        Me.txt_articulo.Name = "txt_articulo"
        Me.txt_articulo.Size = New System.Drawing.Size(100, 20)
        Me.txt_articulo.TabIndex = 8
        '
        'txt_motivo
        '
        Me.txt_motivo.Location = New System.Drawing.Point(405, 34)
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(100, 20)
        Me.txt_motivo.TabIndex = 9
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(405, 65)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 10
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(65, 62)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(100, 20)
        Me.dtp_fecha.TabIndex = 11
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(595, 36)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(100, 20)
        Me.txt_placa.TabIndex = 12
        '
        'lbl_remision
        '
        Me.lbl_remision.AutoSize = True
        Me.lbl_remision.Location = New System.Drawing.Point(7, 36)
        Me.lbl_remision.Name = "lbl_remision"
        Me.lbl_remision.Size = New System.Drawing.Size(50, 13)
        Me.lbl_remision.TabIndex = 13
        Me.lbl_remision.Text = "Remisión"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(20, 65)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 14
        Me.lbl_fecha.Text = "Fecha"
        '
        'lbl_lugar
        '
        Me.lbl_lugar.AutoSize = True
        Me.lbl_lugar.Location = New System.Drawing.Point(192, 36)
        Me.lbl_lugar.Name = "lbl_lugar"
        Me.lbl_lugar.Size = New System.Drawing.Size(34, 13)
        Me.lbl_lugar.TabIndex = 15
        Me.lbl_lugar.Text = "Lugar"
        '
        'lbl_articulo
        '
        Me.lbl_articulo.AutoSize = True
        Me.lbl_articulo.Location = New System.Drawing.Point(192, 65)
        Me.lbl_articulo.Name = "lbl_articulo"
        Me.lbl_articulo.Size = New System.Drawing.Size(44, 13)
        Me.lbl_articulo.TabIndex = 16
        Me.lbl_articulo.Text = "Artículo"
        '
        'lbl_motivo
        '
        Me.lbl_motivo.AutoSize = True
        Me.lbl_motivo.Location = New System.Drawing.Point(360, 36)
        Me.lbl_motivo.Name = "lbl_motivo"
        Me.lbl_motivo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_motivo.TabIndex = 17
        Me.lbl_motivo.Text = "Motivo"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(360, 65)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(37, 13)
        Me.lbl_precio.TabIndex = 18
        Me.lbl_precio.Text = "Precio"
        '
        'lbl_placa
        '
        Me.lbl_placa.AutoSize = True
        Me.lbl_placa.Location = New System.Drawing.Point(550, 37)
        Me.lbl_placa.Name = "lbl_placa"
        Me.lbl_placa.Size = New System.Drawing.Size(34, 13)
        Me.lbl_placa.TabIndex = 19
        Me.lbl_placa.Text = "Placa"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(620, 127)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 20
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 405)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.lbl_placa)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.lbl_motivo)
        Me.Controls.Add(Me.lbl_articulo)
        Me.Controls.Add(Me.lbl_lugar)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_remision)
        Me.Controls.Add(Me.txt_placa)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_motivo)
        Me.Controls.Add(Me.txt_articulo)
        Me.Controls.Add(Me.txt_lugar)
        Me.Controls.Add(Me.txt_remision)
        Me.Controls.Add(Me.dgv_control)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.btn_insertar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "control"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv_control, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MultasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents dgv_control As DataGridView
    Friend WithEvents MuniDataSet As muniDataSet
    Friend WithEvents MultasBindingSource As BindingSource
    Friend WithEvents MultasTableAdapter As muniDataSetTableAdapters.multasTableAdapter
    Friend WithEvents txt_remision As TextBox
    Friend WithEvents txt_lugar As TextBox
    Friend WithEvents txt_articulo As TextBox
    Friend WithEvents txt_motivo As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents lbl_remision As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_lugar As Label
    Friend WithEvents lbl_articulo As Label
    Friend WithEvents lbl_motivo As Label
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_placa As Label
    Friend WithEvents RemisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LugarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlacaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_salir As Button
End Class

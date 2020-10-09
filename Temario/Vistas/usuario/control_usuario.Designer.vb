<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class control_usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(control_usuario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_consultas_remisiones = New System.Windows.Forms.Panel()
        Me.lbl_color_valor = New System.Windows.Forms.Label()
        Me.lbl_color = New System.Windows.Forms.Label()
        Me.lbl_marca_valor = New System.Windows.Forms.Label()
        Me.lbl_marca = New System.Windows.Forms.Label()
        Me.lbl_placa_valor = New System.Windows.Forms.Label()
        Me.lbl_placa = New System.Windows.Forms.Label()
        Me.lbl_informacion = New System.Windows.Forms.Label()
        Me.dgv_remisiones = New System.Windows.Forms.DataGridView()
        Me.RemisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ViewmultasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuniDataSet = New Temario.muniDataSet()
        Me.lbl_linea = New System.Windows.Forms.Label()
        Me.btn_pagar = New System.Windows.Forms.Button()
        Me.lbl_pagara = New System.Windows.Forms.Label()
        Me.pnl_totalApagar = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_total_pagar = New System.Windows.Forms.Label()
        Me.dgv_pagar = New System.Windows.Forms.DataGridView()
        Me.Remisiones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_pagare = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_subtotal_pagar = New System.Windows.Forms.Label()
        Me.lbl_desc_pagar = New System.Windows.Forms.Label()
        Me.lbl_descuento = New System.Windows.Forms.Label()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.lbl_mostrarDatos = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.View_multasTableAdapter = New Temario.muniDataSetTableAdapters.View_multasTableAdapter()
        Me.lbl_código = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnl_consultas_remisiones.SuspendLayout()
        CType(Me.dgv_remisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewmultasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_totalApagar.SuspendLayout()
        CType(Me.dgv_pagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_pagare.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(140, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 107)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(421, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No hemos encontrado registros de remisiones referente a su vehículo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Felicidades!!"
        '
        'pnl_consultas_remisiones
        '
        Me.pnl_consultas_remisiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_consultas_remisiones.Controls.Add(Me.lbl_color_valor)
        Me.pnl_consultas_remisiones.Controls.Add(Me.lbl_color)
        Me.pnl_consultas_remisiones.Controls.Add(Me.lbl_marca_valor)
        Me.pnl_consultas_remisiones.Controls.Add(Me.lbl_marca)
        Me.pnl_consultas_remisiones.Controls.Add(Me.lbl_placa_valor)
        Me.pnl_consultas_remisiones.Controls.Add(Me.lbl_placa)
        Me.pnl_consultas_remisiones.Controls.Add(Me.lbl_informacion)
        Me.pnl_consultas_remisiones.Controls.Add(Me.dgv_remisiones)
        Me.pnl_consultas_remisiones.Location = New System.Drawing.Point(12, 12)
        Me.pnl_consultas_remisiones.Name = "pnl_consultas_remisiones"
        Me.pnl_consultas_remisiones.Size = New System.Drawing.Size(429, 381)
        Me.pnl_consultas_remisiones.TabIndex = 1
        '
        'lbl_color_valor
        '
        Me.lbl_color_valor.AutoSize = True
        Me.lbl_color_valor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_color_valor.Location = New System.Drawing.Point(350, 58)
        Me.lbl_color_valor.Name = "lbl_color_valor"
        Me.lbl_color_valor.Size = New System.Drawing.Size(55, 16)
        Me.lbl_color_valor.TabIndex = 7
        Me.lbl_color_valor.Text = "NEGRO"
        '
        'lbl_color
        '
        Me.lbl_color.AutoSize = True
        Me.lbl_color.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_color.Location = New System.Drawing.Point(298, 58)
        Me.lbl_color.Name = "lbl_color"
        Me.lbl_color.Size = New System.Drawing.Size(46, 16)
        Me.lbl_color.TabIndex = 6
        Me.lbl_color.Text = "Color:"
        '
        'lbl_marca_valor
        '
        Me.lbl_marca_valor.AutoSize = True
        Me.lbl_marca_valor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_marca_valor.Location = New System.Drawing.Point(218, 58)
        Me.lbl_marca_valor.Name = "lbl_marca_valor"
        Me.lbl_marca_valor.Size = New System.Drawing.Size(52, 16)
        Me.lbl_marca_valor.TabIndex = 5
        Me.lbl_marca_valor.Text = "VOLVO"
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoSize = True
        Me.lbl_marca.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_marca.Location = New System.Drawing.Point(161, 58)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(51, 16)
        Me.lbl_marca.TabIndex = 4
        Me.lbl_marca.Text = "Marca:"
        '
        'lbl_placa_valor
        '
        Me.lbl_placa_valor.AutoSize = True
        Me.lbl_placa_valor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_placa_valor.Location = New System.Drawing.Point(68, 58)
        Me.lbl_placa_valor.Name = "lbl_placa_valor"
        Me.lbl_placa_valor.Size = New System.Drawing.Size(69, 16)
        Me.lbl_placa_valor.TabIndex = 3
        Me.lbl_placa_valor.Text = "P-182DRH"
        '
        'lbl_placa
        '
        Me.lbl_placa.AutoSize = True
        Me.lbl_placa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_placa.Location = New System.Drawing.Point(23, 58)
        Me.lbl_placa.Name = "lbl_placa"
        Me.lbl_placa.Size = New System.Drawing.Size(48, 16)
        Me.lbl_placa.TabIndex = 2
        Me.lbl_placa.Text = "Placa:"
        '
        'lbl_informacion
        '
        Me.lbl_informacion.AutoSize = True
        Me.lbl_informacion.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_informacion.Location = New System.Drawing.Point(99, 9)
        Me.lbl_informacion.Name = "lbl_informacion"
        Me.lbl_informacion.Size = New System.Drawing.Size(225, 23)
        Me.lbl_informacion.TabIndex = 1
        Me.lbl_informacion.Text = "Información de Vehículo"
        '
        'dgv_remisiones
        '
        Me.dgv_remisiones.AllowUserToAddRows = False
        Me.dgv_remisiones.AllowUserToDeleteRows = False
        Me.dgv_remisiones.AllowUserToOrderColumns = True
        Me.dgv_remisiones.AutoGenerateColumns = False
        Me.dgv_remisiones.BackgroundColor = System.Drawing.Color.White
        Me.dgv_remisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_remisiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RemisionDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.Pagar})
        Me.dgv_remisiones.DataSource = Me.ViewmultasBindingSource
        Me.dgv_remisiones.Location = New System.Drawing.Point(3, 88)
        Me.dgv_remisiones.Name = "dgv_remisiones"
        Me.dgv_remisiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgv_remisiones.Size = New System.Drawing.Size(421, 288)
        Me.dgv_remisiones.TabIndex = 0
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
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pagar
        '
        Me.Pagar.HeaderText = "pagar"
        Me.Pagar.Name = "Pagar"
        Me.Pagar.Width = 77
        '
        'ViewmultasBindingSource
        '
        Me.ViewmultasBindingSource.DataMember = "View_multas"
        Me.ViewmultasBindingSource.DataSource = Me.MuniDataSet
        '
        'MuniDataSet
        '
        Me.MuniDataSet.DataSetName = "muniDataSet"
        Me.MuniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_linea
        '
        Me.lbl_linea.AutoSize = True
        Me.lbl_linea.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_linea.Location = New System.Drawing.Point(3, 248)
        Me.lbl_linea.Name = "lbl_linea"
        Me.lbl_linea.Size = New System.Drawing.Size(241, 14)
        Me.lbl_linea.TabIndex = 0
        Me.lbl_linea.Text = "_______________________________________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_pagar
        '
        Me.btn_pagar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pagar.Location = New System.Drawing.Point(3, 266)
        Me.btn_pagar.Name = "btn_pagar"
        Me.btn_pagar.Size = New System.Drawing.Size(79, 33)
        Me.btn_pagar.TabIndex = 1
        Me.btn_pagar.Text = "Pagar"
        Me.btn_pagar.UseVisualStyleBackColor = True
        '
        'lbl_pagara
        '
        Me.lbl_pagara.AutoSize = True
        Me.lbl_pagara.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pagara.Location = New System.Drawing.Point(78, 9)
        Me.lbl_pagara.Name = "lbl_pagara"
        Me.lbl_pagara.Size = New System.Drawing.Size(91, 16)
        Me.lbl_pagara.TabIndex = 4
        Me.lbl_pagara.Text = "Usted Pagará."
        '
        'pnl_totalApagar
        '
        Me.pnl_totalApagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnl_totalApagar.Controls.Add(Me.Label5)
        Me.pnl_totalApagar.Controls.Add(Me.lbl_total)
        Me.pnl_totalApagar.Controls.Add(Me.lbl_total_pagar)
        Me.pnl_totalApagar.Location = New System.Drawing.Point(5, 228)
        Me.pnl_totalApagar.Name = "pnl_totalApagar"
        Me.pnl_totalApagar.Size = New System.Drawing.Size(238, 26)
        Me.pnl_totalApagar.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(133, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Q"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(3, 3)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(117, 19)
        Me.lbl_total.TabIndex = 2
        Me.lbl_total.Text = " Total a pagar:"
        '
        'lbl_total_pagar
        '
        Me.lbl_total_pagar.AutoSize = True
        Me.lbl_total_pagar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_pagar.Location = New System.Drawing.Point(155, 3)
        Me.lbl_total_pagar.Name = "lbl_total_pagar"
        Me.lbl_total_pagar.Size = New System.Drawing.Size(40, 19)
        Me.lbl_total_pagar.TabIndex = 3
        Me.lbl_total_pagar.Text = "0.00"
        '
        'dgv_pagar
        '
        Me.dgv_pagar.AllowUserToAddRows = False
        Me.dgv_pagar.AllowUserToDeleteRows = False
        Me.dgv_pagar.AllowUserToOrderColumns = True
        Me.dgv_pagar.BackgroundColor = System.Drawing.Color.White
        Me.dgv_pagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pagar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Remisiones, Me.Precio})
        Me.dgv_pagar.GridColor = System.Drawing.Color.Black
        Me.dgv_pagar.Location = New System.Drawing.Point(3, 28)
        Me.dgv_pagar.Name = "dgv_pagar"
        Me.dgv_pagar.ReadOnly = True
        Me.dgv_pagar.Size = New System.Drawing.Size(239, 136)
        Me.dgv_pagar.TabIndex = 1
        '
        'Remisiones
        '
        Me.Remisiones.HeaderText = "remision"
        Me.Remisiones.Name = "Remisiones"
        Me.Remisiones.ReadOnly = True
        Me.Remisiones.Width = 97
        '
        'Precio
        '
        Me.Precio.HeaderText = "precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 97
        '
        'pnl_pagare
        '
        Me.pnl_pagare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_pagare.Controls.Add(Me.lbl_código)
        Me.pnl_pagare.Controls.Add(Me.Label4)
        Me.pnl_pagare.Controls.Add(Me.Label3)
        Me.pnl_pagare.Controls.Add(Me.lbl_subtotal)
        Me.pnl_pagare.Controls.Add(Me.lbl_subtotal_pagar)
        Me.pnl_pagare.Controls.Add(Me.lbl_desc_pagar)
        Me.pnl_pagare.Controls.Add(Me.lbl_descuento)
        Me.pnl_pagare.Controls.Add(Me.btn_imprimir)
        Me.pnl_pagare.Controls.Add(Me.dgv_pagar)
        Me.pnl_pagare.Controls.Add(Me.lbl_mostrarDatos)
        Me.pnl_pagare.Controls.Add(Me.pnl_totalApagar)
        Me.pnl_pagare.Controls.Add(Me.lbl_pagara)
        Me.pnl_pagare.Controls.Add(Me.btn_pagar)
        Me.pnl_pagare.Controls.Add(Me.lbl_linea)
        Me.pnl_pagare.Location = New System.Drawing.Point(447, 12)
        Me.pnl_pagare.Name = "pnl_pagare"
        Me.pnl_pagare.Size = New System.Drawing.Size(251, 304)
        Me.pnl_pagare.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(138, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Q"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Q"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(8, 186)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(83, 19)
        Me.lbl_subtotal.TabIndex = 9
        Me.lbl_subtotal.Text = "SubTotal:"
        '
        'lbl_subtotal_pagar
        '
        Me.lbl_subtotal_pagar.AutoSize = True
        Me.lbl_subtotal_pagar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal_pagar.Location = New System.Drawing.Point(160, 186)
        Me.lbl_subtotal_pagar.Name = "lbl_subtotal_pagar"
        Me.lbl_subtotal_pagar.Size = New System.Drawing.Size(40, 19)
        Me.lbl_subtotal_pagar.TabIndex = 8
        Me.lbl_subtotal_pagar.Text = "0.00"
        '
        'lbl_desc_pagar
        '
        Me.lbl_desc_pagar.AutoSize = True
        Me.lbl_desc_pagar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc_pagar.Location = New System.Drawing.Point(160, 206)
        Me.lbl_desc_pagar.Name = "lbl_desc_pagar"
        Me.lbl_desc_pagar.Size = New System.Drawing.Size(36, 19)
        Me.lbl_desc_pagar.TabIndex = 4
        Me.lbl_desc_pagar.Text = "150"
        '
        'lbl_descuento
        '
        Me.lbl_descuento.AutoSize = True
        Me.lbl_descuento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descuento.Location = New System.Drawing.Point(8, 206)
        Me.lbl_descuento.Name = "lbl_descuento"
        Me.lbl_descuento.Size = New System.Drawing.Size(98, 19)
        Me.lbl_descuento.TabIndex = 4
        Me.lbl_descuento.Text = "Descuento:"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.Location = New System.Drawing.Point(88, 266)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 33)
        Me.btn_imprimir.TabIndex = 7
        Me.btn_imprimir.Text = "Imprimir Factura"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        Me.btn_imprimir.Visible = False
        '
        'lbl_mostrarDatos
        '
        Me.lbl_mostrarDatos.AutoSize = True
        Me.lbl_mostrarDatos.Location = New System.Drawing.Point(43, 49)
        Me.lbl_mostrarDatos.Name = "lbl_mostrarDatos"
        Me.lbl_mostrarDatos.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mostrarDatos.TabIndex = 6
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(623, 370)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 3
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'View_multasTableAdapter
        '
        Me.View_multasTableAdapter.ClearBeforeFill = True
        '
        'lbl_código
        '
        Me.lbl_código.AutoSize = True
        Me.lbl_código.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_código.Location = New System.Drawing.Point(214, 9)
        Me.lbl_código.Name = "lbl_código"
        Me.lbl_código.Size = New System.Drawing.Size(46, 16)
        Me.lbl_código.TabIndex = 8
        Me.lbl_código.Text = "código"
        Me.lbl_código.Visible = False
        '
        'control_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(710, 405)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.pnl_pagare)
        Me.Controls.Add(Me.pnl_consultas_remisiones)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "control_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_consultas_remisiones.ResumeLayout(False)
        Me.pnl_consultas_remisiones.PerformLayout()
        CType(Me.dgv_remisiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewmultasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_totalApagar.ResumeLayout(False)
        Me.pnl_totalApagar.PerformLayout()
        CType(Me.dgv_pagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_pagare.ResumeLayout(False)
        Me.pnl_pagare.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_consultas_remisiones As Panel
    Friend WithEvents dgv_remisiones As DataGridView
    Friend WithEvents lbl_color_valor As Label
    Friend WithEvents lbl_color As Label
    Friend WithEvents lbl_marca_valor As Label
    Friend WithEvents lbl_marca As Label
    Friend WithEvents lbl_placa_valor As Label
    Friend WithEvents lbl_placa As Label
    Friend WithEvents lbl_informacion As Label
    Friend WithEvents lbl_linea As Label
    Friend WithEvents btn_pagar As Button
    Friend WithEvents lbl_pagara As Label
    Friend WithEvents pnl_totalApagar As Panel
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_total_pagar As Label
    Friend WithEvents dgv_pagar As DataGridView
    Friend WithEvents pnl_pagare As Panel
    Friend WithEvents btn_salir As Button
    Friend WithEvents Remisiones As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents lbl_mostrarDatos As Label
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents lbl_subtotal_pagar As Label
    Friend WithEvents lbl_desc_pagar As Label
    Friend WithEvents lbl_descuento As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RemisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Pagar As DataGridViewCheckBoxColumn
    Friend WithEvents MuniDataSet As muniDataSet
    Friend WithEvents ViewmultasBindingSource As BindingSource
    Friend WithEvents View_multasTableAdapter As muniDataSetTableAdapters.View_multasTableAdapter
    Friend WithEvents lbl_código As Label
End Class

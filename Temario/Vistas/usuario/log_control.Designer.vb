<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class log_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(log_control))
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_contra = New System.Windows.Forms.Label()
        Me.txt_contra = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.lbl_admi = New System.Windows.Forms.Label()
        Me.ckb_mostrar = New System.Windows.Forms.CheckBox()
        Me.lnklbl_regresar = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(12, 64)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(189, 22)
        Me.txt_usuario.TabIndex = 1
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(9, 45)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(58, 16)
        Me.lbl_usuario.TabIndex = 4
        Me.lbl_usuario.Text = "Usuario:"
        '
        'lbl_contra
        '
        Me.lbl_contra.AutoSize = True
        Me.lbl_contra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contra.Location = New System.Drawing.Point(9, 101)
        Me.lbl_contra.Name = "lbl_contra"
        Me.lbl_contra.Size = New System.Drawing.Size(80, 16)
        Me.lbl_contra.TabIndex = 6
        Me.lbl_contra.Text = "Contraseña:"
        '
        'txt_contra
        '
        Me.txt_contra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contra.Location = New System.Drawing.Point(12, 120)
        Me.txt_contra.Name = "txt_contra"
        Me.txt_contra.Size = New System.Drawing.Size(189, 22)
        Me.txt_contra.TabIndex = 2
        Me.txt_contra.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(57, 154)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(97, 45)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "Consultar"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'lbl_admi
        '
        Me.lbl_admi.AutoSize = True
        Me.lbl_admi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admi.Location = New System.Drawing.Point(41, 9)
        Me.lbl_admi.Name = "lbl_admi"
        Me.lbl_admi.Size = New System.Drawing.Size(124, 20)
        Me.lbl_admi.TabIndex = 8
        Me.lbl_admi.Text = "Administradores"
        '
        'ckb_mostrar
        '
        Me.ckb_mostrar.AutoSize = True
        Me.ckb_mostrar.Location = New System.Drawing.Point(207, 125)
        Me.ckb_mostrar.Name = "ckb_mostrar"
        Me.ckb_mostrar.Size = New System.Drawing.Size(15, 14)
        Me.ckb_mostrar.TabIndex = 9
        Me.ckb_mostrar.UseVisualStyleBackColor = True
        '
        'lnklbl_regresar
        '
        Me.lnklbl_regresar.AutoSize = True
        Me.lnklbl_regresar.Location = New System.Drawing.Point(77, 210)
        Me.lnklbl_regresar.Name = "lnklbl_regresar"
        Me.lnklbl_regresar.Size = New System.Drawing.Size(50, 13)
        Me.lnklbl_regresar.TabIndex = 10
        Me.lnklbl_regresar.TabStop = True
        Me.lnklbl_regresar.Text = "Regresar"
        '
        'log_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 232)
        Me.Controls.Add(Me.lnklbl_regresar)
        Me.Controls.Add(Me.ckb_mostrar)
        Me.Controls.Add(Me.lbl_admi)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.lbl_contra)
        Me.Controls.Add(Me.txt_contra)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_usuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "log_control"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_contra As Label
    Friend WithEvents txt_contra As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_admi As Label
    Friend WithEvents ckb_mostrar As CheckBox
    Friend WithEvents lnklbl_regresar As LinkLabel
End Class

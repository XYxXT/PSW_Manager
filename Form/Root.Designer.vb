<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Root
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Root))
        Me.Root_Btn = New System.Windows.Forms.Button()
        Me.Psw_Tbx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Root_Btn
        '
        Me.Root_Btn.BackgroundImage = Global.PSW_Manager.My.Resources.Resources.root
        Me.Root_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Root_Btn.Location = New System.Drawing.Point(12, 12)
        Me.Root_Btn.Name = "Root_Btn"
        Me.Root_Btn.Size = New System.Drawing.Size(350, 350)
        Me.Root_Btn.TabIndex = 0
        Me.Root_Btn.UseVisualStyleBackColor = True
        '
        'Psw_Tbx
        '
        Me.Psw_Tbx.Location = New System.Drawing.Point(131, 169)
        Me.Psw_Tbx.Name = "Psw_Tbx"
        Me.Psw_Tbx.Size = New System.Drawing.Size(100, 20)
        Me.Psw_Tbx.TabIndex = 1
        '
        'Root
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 374)
        Me.Controls.Add(Me.Root_Btn)
        Me.Controls.Add(Me.Psw_Tbx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Root"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Root"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Root_Btn As Button
    Friend WithEvents Psw_Tbx As TextBox
End Class

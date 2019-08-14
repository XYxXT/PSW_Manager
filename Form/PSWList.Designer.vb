<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PSWList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSWList))
        Me.Search_Tbx = New System.Windows.Forms.TextBox()
        Me.Psw_Dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add_Btn = New System.Windows.Forms.Button()
        Me.Root_Btn = New System.Windows.Forms.Button()
        CType(Me.Psw_Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search_Tbx
        '
        Me.Search_Tbx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search_Tbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Tbx.Location = New System.Drawing.Point(12, 77)
        Me.Search_Tbx.Multiline = True
        Me.Search_Tbx.Name = "Search_Tbx"
        Me.Search_Tbx.Size = New System.Drawing.Size(709, 61)
        Me.Search_Tbx.TabIndex = 3
        '
        'Psw_Dgv
        '
        Me.Psw_Dgv.AllowUserToAddRows = False
        Me.Psw_Dgv.AllowUserToDeleteRows = False
        Me.Psw_Dgv.AllowUserToResizeColumns = False
        Me.Psw_Dgv.AllowUserToResizeRows = False
        Me.Psw_Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Psw_Dgv.ColumnHeadersHeight = 29
        Me.Psw_Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4})
        Me.Psw_Dgv.Location = New System.Drawing.Point(12, 144)
        Me.Psw_Dgv.MultiSelect = False
        Me.Psw_Dgv.Name = "Psw_Dgv"
        Me.Psw_Dgv.RowHeadersVisible = False
        Me.Psw_Dgv.RowHeadersWidth = 51
        Me.Psw_Dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Psw_Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Psw_Dgv.Size = New System.Drawing.Size(708, 527)
        Me.Psw_Dgv.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Visible = False
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "site"
        Me.Column2.HeaderText = "SITE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 130
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "user"
        Me.Column5.HeaderText = "USER"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.Width = 130
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "user_name"
        Me.Column3.HeaderText = "USER NAME"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.Width = 210
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "user_psw"
        Me.Column4.HeaderText = "PSW"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 210
        '
        'Add_Btn
        '
        Me.Add_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Add_Btn.BackgroundImage = Global.PSW_Manager.My.Resources.Resources.add
        Me.Add_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add_Btn.Location = New System.Drawing.Point(660, 11)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(60, 60)
        Me.Add_Btn.TabIndex = 1
        Me.Add_Btn.UseVisualStyleBackColor = True
        '
        'Root_Btn
        '
        Me.Root_Btn.BackgroundImage = Global.PSW_Manager.My.Resources.Resources.root
        Me.Root_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Root_Btn.Location = New System.Drawing.Point(12, 11)
        Me.Root_Btn.Name = "Root_Btn"
        Me.Root_Btn.Size = New System.Drawing.Size(60, 60)
        Me.Root_Btn.TabIndex = 0
        Me.Root_Btn.UseVisualStyleBackColor = True
        Me.Root_Btn.Visible = False
        '
        'PSWList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 683)
        Me.Controls.Add(Me.Psw_Dgv)
        Me.Controls.Add(Me.Search_Tbx)
        Me.Controls.Add(Me.Add_Btn)
        Me.Controls.Add(Me.Root_Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PSWList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PSW LIST"
        CType(Me.Psw_Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Root_Btn As Button
    Friend WithEvents Add_Btn As Button
    Friend WithEvents Search_Tbx As TextBox
    Friend WithEvents Psw_Dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class

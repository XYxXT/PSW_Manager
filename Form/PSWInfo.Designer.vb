<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PSWInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSWInfo))
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Add_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.ExtInfo_Dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Site_Tbx = New System.Windows.Forms.TextBox()
        Me.WebSite_Tbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.User_Tbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserName_Tbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserPSW_Tbx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Root_Cbx = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Description_Tbx = New System.Windows.Forms.TextBox()
        CType(Me.ExtInfo_Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Save_Btn
        '
        Me.Save_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Save_Btn.BackgroundImage = Global.PSW_Manager.My.Resources.Resources.padlock
        Me.Save_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Save_Btn.Location = New System.Drawing.Point(971, 15)
        Me.Save_Btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(80, 74)
        Me.Save_Btn.TabIndex = 3
        Me.Save_Btn.UseVisualStyleBackColor = True
        '
        'Add_Btn
        '
        Me.Add_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Add_Btn.BackgroundImage = Global.PSW_Manager.My.Resources.Resources.add
        Me.Add_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add_Btn.Location = New System.Drawing.Point(971, 273)
        Me.Add_Btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(80, 74)
        Me.Add_Btn.TabIndex = 5
        Me.Add_Btn.UseVisualStyleBackColor = True
        '
        'Delete_Btn
        '
        Me.Delete_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Delete_Btn.BackgroundImage = Global.PSW_Manager.My.Resources.Resources.delete
        Me.Delete_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Delete_Btn.Location = New System.Drawing.Point(971, 354)
        Me.Delete_Btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(80, 74)
        Me.Delete_Btn.TabIndex = 6
        Me.Delete_Btn.UseVisualStyleBackColor = True
        '
        'ExtInfo_Dgv
        '
        Me.ExtInfo_Dgv.AllowUserToAddRows = False
        Me.ExtInfo_Dgv.AllowUserToDeleteRows = False
        Me.ExtInfo_Dgv.AllowUserToResizeColumns = False
        Me.ExtInfo_Dgv.AllowUserToResizeRows = False
        Me.ExtInfo_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ExtInfo_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExtInfo_Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.ExtInfo_Dgv.Location = New System.Drawing.Point(16, 273)
        Me.ExtInfo_Dgv.Margin = New System.Windows.Forms.Padding(4)
        Me.ExtInfo_Dgv.Name = "ExtInfo_Dgv"
        Me.ExtInfo_Dgv.RowHeadersVisible = False
        Me.ExtInfo_Dgv.RowHeadersWidth = 51
        Me.ExtInfo_Dgv.Size = New System.Drawing.Size(947, 266)
        Me.ExtInfo_Dgv.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "id"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "id_password"
        Me.Column2.HeaderText = "id password"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "description"
        Me.Column3.HeaderText = "DESCRIPTION"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "value"
        Me.Column4.HeaderText = "VALUE"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "x"
        Me.Column5.HeaderText = "X"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SITE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Site_Tbx
        '
        Me.Site_Tbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Site_Tbx.Location = New System.Drawing.Point(241, 15)
        Me.Site_Tbx.Margin = New System.Windows.Forms.Padding(4)
        Me.Site_Tbx.Name = "Site_Tbx"
        Me.Site_Tbx.Size = New System.Drawing.Size(212, 34)
        Me.Site_Tbx.TabIndex = 9
        '
        'WebSite_Tbx
        '
        Me.WebSite_Tbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebSite_Tbx.Location = New System.Drawing.Point(241, 58)
        Me.WebSite_Tbx.Margin = New System.Windows.Forms.Padding(4)
        Me.WebSite_Tbx.Name = "WebSite_Tbx"
        Me.WebSite_Tbx.Size = New System.Drawing.Size(212, 34)
        Me.WebSite_Tbx.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 37)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "WEB SITE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'User_Tbx
        '
        Me.User_Tbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_Tbx.Location = New System.Drawing.Point(241, 101)
        Me.User_Tbx.Margin = New System.Windows.Forms.Padding(4)
        Me.User_Tbx.Name = "User_Tbx"
        Me.User_Tbx.Size = New System.Drawing.Size(212, 34)
        Me.User_Tbx.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 37)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "USER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserName_Tbx
        '
        Me.UserName_Tbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_Tbx.Location = New System.Drawing.Point(241, 144)
        Me.UserName_Tbx.Margin = New System.Windows.Forms.Padding(4)
        Me.UserName_Tbx.Name = "UserName_Tbx"
        Me.UserName_Tbx.Size = New System.Drawing.Size(212, 34)
        Me.UserName_Tbx.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 37)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "USER NAME"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserPSW_Tbx
        '
        Me.UserPSW_Tbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPSW_Tbx.Location = New System.Drawing.Point(241, 187)
        Me.UserPSW_Tbx.Margin = New System.Windows.Forms.Padding(4)
        Me.UserPSW_Tbx.Name = "UserPSW_Tbx"
        Me.UserPSW_Tbx.Size = New System.Drawing.Size(212, 34)
        Me.UserPSW_Tbx.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 187)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 37)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "USER PSW"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 230)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 37)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ROOT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Root_Cbx
        '
        Me.Root_Cbx.AutoSize = True
        Me.Root_Cbx.Location = New System.Drawing.Point(332, 242)
        Me.Root_Cbx.Margin = New System.Windows.Forms.Padding(4)
        Me.Root_Cbx.Name = "Root_Cbx"
        Me.Root_Cbx.Size = New System.Drawing.Size(18, 17)
        Me.Root_Cbx.TabIndex = 19
        Me.Root_Cbx.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(508, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 37)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "DESCRIPTION"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Description_Tbx
        '
        Me.Description_Tbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description_Tbx.Location = New System.Drawing.Point(508, 58)
        Me.Description_Tbx.Margin = New System.Windows.Forms.Padding(4)
        Me.Description_Tbx.Multiline = True
        Me.Description_Tbx.Name = "Description_Tbx"
        Me.Description_Tbx.Size = New System.Drawing.Size(453, 201)
        Me.Description_Tbx.TabIndex = 21
        '
        'PSWInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Description_Tbx)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Root_Cbx)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.UserPSW_Tbx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.UserName_Tbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.User_Tbx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WebSite_Tbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Site_Tbx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExtInfo_Dgv)
        Me.Controls.Add(Me.Delete_Btn)
        Me.Controls.Add(Me.Add_Btn)
        Me.Controls.Add(Me.Save_Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PSWInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PSW DETAIL"
        CType(Me.ExtInfo_Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Save_Btn As Button
    Friend WithEvents Add_Btn As Button
    Friend WithEvents Delete_Btn As Button
    Friend WithEvents ExtInfo_Dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Site_Tbx As TextBox
    Friend WithEvents WebSite_Tbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents User_Tbx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UserName_Tbx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents UserPSW_Tbx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Root_Cbx As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Description_Tbx As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Upload_Btn = New System.Windows.Forms.Button()
        Me.Download_Btn = New System.Windows.Forms.Button()
        Me.FtpPath_Tbx = New System.Windows.Forms.TextBox()
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
        'Upload_Btn
        '
        Me.Upload_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Upload_Btn.BackgroundImage = Global.PSW_Manager.My.Resources.Resources.upload
        Me.Upload_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Upload_Btn.Location = New System.Drawing.Point(302, 368)
        Me.Upload_Btn.Name = "Upload_Btn"
        Me.Upload_Btn.Size = New System.Drawing.Size(60, 60)
        Me.Upload_Btn.TabIndex = 8
        Me.Upload_Btn.UseVisualStyleBackColor = True
        '
        'Download_Btn
        '
        Me.Download_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Download_Btn.BackgroundImage = Global.PSW_Manager.My.Resources.Resources.download
        Me.Download_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Download_Btn.Location = New System.Drawing.Point(236, 368)
        Me.Download_Btn.Name = "Download_Btn"
        Me.Download_Btn.Size = New System.Drawing.Size(60, 60)
        Me.Download_Btn.TabIndex = 7
        Me.Download_Btn.UseVisualStyleBackColor = True
        '
        'FtpPath_Tbx
        '
        Me.FtpPath_Tbx.Location = New System.Drawing.Point(12, 368)
        Me.FtpPath_Tbx.Multiline = True
        Me.FtpPath_Tbx.Name = "FtpPath_Tbx"
        Me.FtpPath_Tbx.Size = New System.Drawing.Size(219, 60)
        Me.FtpPath_Tbx.TabIndex = 9
        '
        'Root
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 437)
        Me.Controls.Add(Me.FtpPath_Tbx)
        Me.Controls.Add(Me.Upload_Btn)
        Me.Controls.Add(Me.Download_Btn)
        Me.Controls.Add(Me.Root_Btn)
        Me.Controls.Add(Me.Psw_Tbx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Root"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Root"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Root_Btn As Button
    Friend WithEvents Psw_Tbx As TextBox
    Friend WithEvents Upload_Btn As Button
    Friend WithEvents Download_Btn As Button
    Friend WithEvents FtpPath_Tbx As TextBox
End Class

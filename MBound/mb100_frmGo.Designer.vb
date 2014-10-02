<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.cmdLoad = New System.Windows.Forms.Button()
Me.cmdExit = New System.Windows.Forms.Button()
Me.SuspendLayout()
'
'cmdLoad
'
Me.cmdLoad.BackColor = System.Drawing.Color.Lime
Me.cmdLoad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.cmdLoad.Location = New System.Drawing.Point(93, 40)
Me.cmdLoad.Name = "cmdLoad"
Me.cmdLoad.Size = New System.Drawing.Size(100, 42)
Me.cmdLoad.TabIndex = 0
Me.cmdLoad.Text = "Load"
Me.cmdLoad.UseVisualStyleBackColor = False
'
'cmdExit
'
Me.cmdExit.BackColor = System.Drawing.Color.Blue
Me.cmdExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.cmdExit.ForeColor = System.Drawing.Color.White
Me.cmdExit.Location = New System.Drawing.Point(93, 156)
Me.cmdExit.Name = "cmdExit"
Me.cmdExit.Size = New System.Drawing.Size(100, 39)
Me.cmdExit.TabIndex = 1
Me.cmdExit.Text = "Exit"
Me.cmdExit.UseVisualStyleBackColor = False
'
'frmGo
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
Me.ClientSize = New System.Drawing.Size(292, 273)
Me.Controls.Add(Me.cmdExit)
Me.Controls.Add(Me.cmdLoad)
Me.Name = "frmGo"
Me.Text = "MBound"
Me.ResumeLayout(False)

End Sub
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button

End Class

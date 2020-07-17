<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pgbLoading = New System.Windows.Forms.ProgressBar()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.BackColor = System.Drawing.Color.Transparent
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.ForeColor = System.Drawing.Color.Black
        Me.lblIntro.Location = New System.Drawing.Point(39, 297)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(522, 20)
        Me.lblIntro.TabIndex = 0
        Me.lblIntro.Text = "Tap the arrow keys as fast as possible to avoid oncoming traffic!"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tempus Sans ITC", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(110, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(336, 191)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Rush Hour Turtle"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pgbLoading
        '
        Me.pgbLoading.ForeColor = System.Drawing.Color.Lime
        Me.pgbLoading.Location = New System.Drawing.Point(356, 340)
        Me.pgbLoading.Name = "pgbLoading"
        Me.pgbLoading.Size = New System.Drawing.Size(184, 29)
        Me.pgbLoading.Step = 1
        Me.pgbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbLoading.TabIndex = 2
        '
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        Me.tmrLoad.Interval = 50
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.pgbLoading)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblIntro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIntro As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pgbLoading As ProgressBar
    Friend WithEvents tmrLoad As Timer
End Class

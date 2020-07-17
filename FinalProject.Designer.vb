<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinalProject
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinalProject))
        Me.pnlDisplay = New System.Windows.Forms.Panel()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.lblPreviousScore = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrevious = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.wmpPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lblLife1 = New System.Windows.Forms.Label()
        Me.lblLife2 = New System.Windows.Forms.Label()
        Me.lblLife3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.wmpPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDisplay
        '
        Me.pnlDisplay.BackColor = System.Drawing.Color.White
        Me.pnlDisplay.Location = New System.Drawing.Point(12, 89)
        Me.pnlDisplay.Name = "pnlDisplay"
        Me.pnlDisplay.Size = New System.Drawing.Size(760, 425)
        Me.pnlDisplay.TabIndex = 0
        '
        'lblLogo
        '
        Me.lblLogo.Image = CType(resources.GetObject("lblLogo.Image"), System.Drawing.Image)
        Me.lblLogo.Location = New System.Drawing.Point(12, 9)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(134, 77)
        Me.lblLogo.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(616, 526)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(697, 526)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblHighScore
        '
        Me.lblHighScore.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(595, 14)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(81, 18)
        Me.lblHighScore.TabIndex = 4
        Me.lblHighScore.Text = "High Score:"
        '
        'lblHigh
        '
        Me.lblHigh.BackColor = System.Drawing.Color.Transparent
        Me.lblHigh.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHigh.ForeColor = System.Drawing.Color.White
        Me.lblHigh.Location = New System.Drawing.Point(682, 11)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(121, 19)
        Me.lblHigh.TabIndex = 5
        '
        'lblPreviousScore
        '
        Me.lblPreviousScore.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreviousScore.Location = New System.Drawing.Point(570, 36)
        Me.lblPreviousScore.Name = "lblPreviousScore"
        Me.lblPreviousScore.Size = New System.Drawing.Size(106, 18)
        Me.lblPreviousScore.TabIndex = 6
        Me.lblPreviousScore.Text = "Previous Score:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(576, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Current Score:"
        '
        'lblPrevious
        '
        Me.lblPrevious.BackColor = System.Drawing.Color.Transparent
        Me.lblPrevious.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevious.ForeColor = System.Drawing.Color.White
        Me.lblPrevious.Location = New System.Drawing.Point(682, 32)
        Me.lblPrevious.Name = "lblPrevious"
        Me.lblPrevious.Size = New System.Drawing.Size(121, 19)
        Me.lblPrevious.TabIndex = 8
        '
        'lblCurrent
        '
        Me.lblCurrent.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrent.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.ForeColor = System.Drawing.Color.White
        Me.lblCurrent.Location = New System.Drawing.Point(682, 53)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(121, 19)
        Me.lblCurrent.TabIndex = 9
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Image = CType(resources.GetObject("lblInfo.Image"), System.Drawing.Image)
        Me.lblInfo.Location = New System.Drawing.Point(152, 12)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(235, 63)
        Me.lblInfo.TabIndex = 10
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'wmpPlayer
        '
        Me.wmpPlayer.Enabled = True
        Me.wmpPlayer.Location = New System.Drawing.Point(449, 3)
        Me.wmpPlayer.Name = "wmpPlayer"
        Me.wmpPlayer.OcxState = CType(resources.GetObject("wmpPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpPlayer.Size = New System.Drawing.Size(75, 29)
        Me.wmpPlayer.TabIndex = 11
        '
        'lblLife1
        '
        Me.lblLife1.Image = CType(resources.GetObject("lblLife1.Image"), System.Drawing.Image)
        Me.lblLife1.Location = New System.Drawing.Point(421, 36)
        Me.lblLife1.Name = "lblLife1"
        Me.lblLife1.Size = New System.Drawing.Size(39, 39)
        Me.lblLife1.TabIndex = 12
        '
        'lblLife2
        '
        Me.lblLife2.Image = CType(resources.GetObject("lblLife2.Image"), System.Drawing.Image)
        Me.lblLife2.Location = New System.Drawing.Point(466, 36)
        Me.lblLife2.Name = "lblLife2"
        Me.lblLife2.Size = New System.Drawing.Size(39, 39)
        Me.lblLife2.TabIndex = 13
        '
        'lblLife3
        '
        Me.lblLife3.Image = CType(resources.GetObject("lblLife3.Image"), System.Drawing.Image)
        Me.lblLife3.Location = New System.Drawing.Point(511, 36)
        Me.lblLife3.Name = "lblLife3"
        Me.lblLife3.Size = New System.Drawing.Size(39, 39)
        Me.lblLife3.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Bisque
        Me.Label1.Location = New System.Drawing.Point(791, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 425)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FinalProject
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(949, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLife3)
        Me.Controls.Add(Me.lblLife2)
        Me.Controls.Add(Me.lblLife1)
        Me.Controls.Add(Me.wmpPlayer)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.lblPrevious)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPreviousScore)
        Me.Controls.Add(Me.lblHigh)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.pnlDisplay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FinalProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rush Hour Turtle"
        CType(Me.wmpPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDisplay As Panel
    Friend WithEvents lblLogo As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblHighScore As Label
    Friend WithEvents lblHigh As Label
    Friend WithEvents lblPreviousScore As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrevious As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents wmpPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblLife1 As Label
    Friend WithEvents lblLife2 As Label
    Friend WithEvents lblLife3 As Label
    Friend WithEvents Label1 As Label
End Class

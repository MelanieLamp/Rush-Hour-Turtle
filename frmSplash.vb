Option Explicit On
Option Strict On

Public Class frmSplash

    Public Sub tmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick

        FinalProject.Visible = False
        Me.Show()
        tmrLoad.Enabled = True
        pgbLoading.Enabled = True
        tmrLoad.Start()

        pgbLoading.Increment(1)
        If pgbLoading.Value = 100 Then
            Me.Hide()
            tmrLoad.Enabled = False
            FinalProject.Enabled = True
            FinalProject.Visible = True
        End If

    End Sub

    Public Sub ShowSplash()
        FinalProject.Enabled = False
        tmrLoad.Interval = 100
        Me.Show()
        Me.TopMost = True
    End Sub

End Class
'Jason Permann
'Spring 2025
'RCET2265
'Stan's Grocery
'https://github.com/JaceFoxman/StansGrocery.git
Public Class SplahScreenForm
    Private Sub SplahScreenForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        StansGroceryForm.SendToBack()
        SplashScreenTimer.Enabled = True
    End Sub

    Private Sub SplashScreenTimer_Tick(sender As Object, e As EventArgs) Handles SplashScreenTimer.Tick
        SplashScreenTimer.Enabled = False
        Me.Close()
        StansGroceryForm.Show()
    End Sub
End Class
'Jason Permann
'Spring 2025
'RCET2265
'Stan's Grocery
'https://github.com/JaceFoxman/StansGrocery.git
Public Class StansGroceryForm
    'Event Handler_________________________________________________________________________________________________
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub
    'Boot Up_______________________________________________________________________________________________________
    Private Sub StansGroceryForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Static activated As Boolean = True
        If activated = True Then
            SplahScreenForm.Show()
            activated = False
        End If
        Me.Hide() 'dose not work inside the If statement and will not work on the Splash Screen side of code.
    End Sub

End Class

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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class

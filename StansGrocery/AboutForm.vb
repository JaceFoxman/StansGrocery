'Jason Permann
'Spring 2025
'RCET2265
'Stan's Grocery
'https://github.com/JaceFoxman/StansGrocery.git
Public Class AboutForm
    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Me.Hide()
        StansGroceryForm.Show()
    End Sub
End Class
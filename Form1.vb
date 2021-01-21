'Jenna Lambert
'9/8/18
'"Convert Feet Into Meters"
Public Class Form1 'Starting the form
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click 'Starting Sub. Button click event: When the user clicks the "Convert Feet into Meters" button on the form.
        Dim feet As Double 'declare "feet" as a double variable.
        Dim meters As Double 'declare "meters" as a double varible.
        feet = txtFeet.Text 'set double "feet" to the text proporty of txtFeet.
        meters = feet * 0.305 'set double "meters" to double "feet" multiplied by 0.305 or the equivalency of one foot to a meter.
        lblMeter.Text = meters 'set the text property of lblMeter to double "meters".
    End Sub 'Ending Sub
    Private Sub txtFeet_TextChanged(sender As Object, e As EventArgs) Handles txtFeet.TextChanged 'Starting sub. Text changed event: when the user enters a new value into txtFeet.
        lblMeter.Text = "" 'set the text property of lblMeter as ""
    End Sub 'Ending Sub
End Class 'Ending Class

Public Class Form1

    Dim month As Decimal
    Dim salary As Decimal
    Dim total As Decimal
    Dim i, cd, gen As String
    Private Uppercase As Object
    Public Property StringPass As String

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

        Dim p = Uppercase

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click

        total = 0
        cd = "NO"

        lbltotal.Text = "$ " + Format(total, "0.00")
        gbox1.Items.btncalc("       " & i & "           " & cd & "            " & Format(total, "0.00") & "     ")

    End Sub

    Try
            If IsValidData() Then
                Dim name As String = Convert.ToString(txtname.Text)
                Dim Duration As String = Convert.ToString(txtmonth.Text)
                Dim IC As String = Convert.ToString(txtic.Text)
                Dim Gender As String = Convert.ToString(txtic.Text)
                Dim LastSalary As String = Convert.ToString(txtsalary.Text)
                Dim Level As String = Convert.ToString(cbtype.Text)
                Dim Calculation As String = Convert.ToString(btncalc.Text)
                Dim TotalPayment As String = Convert.ToString(btncalc.Text)
                gbox.Items.btncalc(String.Format("    " & name & "  " & Duration & "  " & IC & " " & Gender & " " & LastSalary & "   " & Level & " & Calculation & "  " & Total Payment & " " @vb.net"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & vbCrLf & ex.GetType.ToString & vbCrLf & vbCrLf & ex.StackTrace, "Exception")
        End Try
    End Sub



    Private Function IsValidData() As Boolean
        Return _
        IsPresent(txtname, "Name ") AndAlso
        IsPresent(txtmonth, "Duration ") AndAlso
        IsPresent(txtic, "IC Number ") AndAlso
        IsPresent(txtic, "Gender ") AndAlso
        IsPresent(txtsalary, "Last Salary ") AndAlso
        IsPresent(cbtype, "Level ") AndAlso
        IsPresent(btncalc, "Calculation ") AndAlso
        IsPresent(txtsalary, "Total Payment (MYR) ")
    End Function

    Private Sub lbloutput_Click(sender As Object, e As EventArgs) Handles lbloutput.Click
        txtname.Text = Form1.txtname.Text
        txtmonth.Checked = False
        txtic.Checked = False
        txtsalary.Checked = False
        Level.Checked = False
        btncalc.Checked = False
        lbloutput.Items.Add("            Name            Duration             IC Number          Gender        Last Salary         Level        Calculation          Total Payment (MYR)     ")

        Try
            If IsValidData() Then
                Dim name As String = Convert.ToString(txtname.Text)
                Dim Duration As String = Convert.ToString(txtmonth.Text)
                Dim IC As String = Convert.ToString(txtic.Text)
                Dim Gender As String = Convert.ToString(txtic.Text)
                Dim LastSalary As String = Convert.ToString(txtsalary.Text)
                Dim Level As String = Convert.ToString(cbtype.Text)
                Dim Calculation As String = Convert.ToString(btncalc.Text)
                Dim TotalPayment As String = Convert.ToString(btncalc.Text)
                gbox.Items.btncalc(String.Format("    " & name & "  " & Duration & "  " & IC & " " & Gender & " " & LastSalary & "   " & Level & " & Calculation & "  " & Total Payment & " " @vb.net"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & vbCrLf & ex.GetType.ToString & vbCrLf & vbCrLf & ex.StackTrace, "Exception")
        End Try
    End Sub



    Private Function IsValidData() As Boolean
        Return _
        IsPresent(txtname, "Name ") AndAlso
        IsPresent(txtmonth, "Duration ") AndAlso
        IsPresent(txtic, "IC Number ") AndAlso
        IsPresent(txtic, "Gender ") AndAlso
        IsPresent(txtsalary, "Last Salary ") AndAlso
        IsPresent(cbtype, "Level ") AndAlso
        IsPresent(btncalc, "Calculation ") AndAlso
        IsPresent(txtsalary, "Total Payment (MYR) ")
    End Function

    End Sub

    Private Function IsPresent(ByVal textbox As TextBox, ByVal name As String) As Boolean
        If textbox.Text = "" Then
            MessageBox.Show(name & " is required", "Error")
            textbox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub txtic_TextChanged(sender As Object, e As EventArgs) Handles txtic.TextChanged
        If txtic.TextLength > 12 Then
            MessageBox.Show("Must 12 digits only")
        End If
    End Sub
    Private Sub txtic_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtic.KeyPress

        If e.KeyChar <> ChrW(8) AndAlso Not (e.KeyChar >= "0"c AndAlso e.KeyChar <= "9"c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txticnumber_KeyPress_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtic.KeyPress
        If e.KeyChar <> ChrW(8) AndAlso Not (e.KeyChar >= "0"c AndAlso e.KeyChar <= "9"c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtname.Text = ""
        txtic.Text = ""
        cbtype.Text = ""
        txtmonth.Text = ""
        txtsalary.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim myForm As New Form2
        Me.Hide()
        myForm.Show()
    End Sub


End Class



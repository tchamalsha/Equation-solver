Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, p, q, r, x, y As String
        a = Val(txta.Text)
        b = Val(txtb.Text)
        c = Val(txtc.Text)
        p = Val(txtp.Text)
        q = Val(txtq.Text)
        r = Val(txtr.Text)

        x = ((r * b) + (q * c)) / ((b * p) - (q * a))
        y = ((p * c) - (a * r)) / ((q * a) - (p * b))

        lblx.Text = "X = " + x
        lbly.Text = "Y = " + y
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txta.Text = ""
        txtb.Text = ""
        txtc.Text = ""
        txtp.Text = ""
        txtq.Text = ""
        txtr.Text = ""
    End Sub
End Class

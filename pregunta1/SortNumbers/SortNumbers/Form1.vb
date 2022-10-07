Public Class Form1

    Private Sub Ordenar_Click(sender As Object, e As EventArgs) Handles Ordenar.Click
        Dim x, y, z As Integer
        x = Convert.ToInt32(num1.Text)
        y = Convert.ToInt32(num2.Text)
        z = Convert.ToInt32(num3.Text)

        If x > y And x > z Then
            If y > z Then
                GoTo sort_zyx
            Else
                GoTo sort_yzx
            End If
        End If

        If y > x And y > z Then
            If x > z Then
                GoTo sort_zxy
            Else
                GoTo sort_xzy
            End If
        End If

        If z > x And z > y Then
            If x > y Then
                GoTo sort_yxz
            Else
                GoTo sort_xyz
            End If
        End If

sort_xyz:
        ord1.Text = x
        ord2.Text = y
        ord3.Text = z
        GoTo my_end
sort_xzy:
        ord1.Text = x
        ord2.Text = z
        ord3.Text = y
        GoTo my_end
sort_yxz:
        ord1.Text = y
        ord2.Text = x
        ord3.Text = z
        GoTo my_end
sort_yzx:
        ord1.Text = y
        ord2.Text = z
        ord3.Text = x
        GoTo my_end
sort_zxy:
        ord1.Text = z
        ord2.Text = x
        ord3.Text = y
        GoTo my_end
sort_zyx:
        ord1.Text = z
        ord2.Text = y
        ord3.Text = x
        GoTo my_end
my_end:

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(ord1.Text)
        b = Convert.ToInt32(ord2.Text)
        c = Convert.ToInt32(ord3.Text)
        ord1.Text = c
        ord2.Text = b
        ord3.Text = a

    End Sub
End Class

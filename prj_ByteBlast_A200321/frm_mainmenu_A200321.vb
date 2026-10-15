Public Class frm_mainmenu_A200321
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End

    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        frm_products_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cust_Click(sender As Object, e As EventArgs) Handles btn_cust.Click
        frm_customer_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        frm_order_A200321.Show()
        Me.Hide()

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_A200321.Show()
        Me.Hide()

    End Sub
End Class

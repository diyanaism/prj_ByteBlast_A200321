Public Class frm_splashscreen_A200321
    Private Sub frm_splashscreen_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome!")
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        'username = txt_name.Text
        frm_mainmenu_A200321.Show()
        Me.Hide()
    End Sub
End Class
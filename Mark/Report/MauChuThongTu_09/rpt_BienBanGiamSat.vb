Public Class rpt_BienBanGiamSat
    Public Sub New(Optional ByVal Ten_mon As String = "", Optional ByVal Ten_lop As String = "", Optional ByVal Ngay_thi As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Ten_mon.Text = Ten_mon
        Me.Ten_lop.Text = Ten_lop
        Me.Ngay_thi.Text = Ngay_thi
    End Sub

End Class
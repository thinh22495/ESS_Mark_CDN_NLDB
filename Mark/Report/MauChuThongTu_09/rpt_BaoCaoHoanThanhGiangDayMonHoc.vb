Public Class rpt_BaoCaoHoanThanhGiangDayMonHoc
    Public Sub New(Optional ByVal Ten_lop As String = "", Optional ByVal Ten_mon As String = "", Optional ByVal So_tin_chi As String = "", Optional ByVal Ten_khoa As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_ngay.Text = "Ngày " & Date.Now.Day.ToString & " tháng " & Date.Now.Month.ToString & " năm " & Date.Now.Year.ToString
        Me.Ten_lop.Text = Ten_lop
        Me.Ten_mon.Text = Ten_mon
        Me.So_tin_chi.Text = So_tin_chi
        Me.Khoa.Text = Ten_khoa
    End Sub
End Class
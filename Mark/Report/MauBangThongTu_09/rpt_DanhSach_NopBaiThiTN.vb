Public Class rpt_DanhSach_NopBaiThiTN
    Public Sub New(ByVal dt As DataTable, Optional ByVal Ten_mon As String = "", Optional ByVal Ten_lop As String = "")
        InitializeComponent()
        Me.DataSource = dt
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_ngay.Text = "Ngày " & Date.Now.Day.ToString & " tháng " & Date.Now.Month.ToString & " năm " & Date.Now.Year.ToString
        Me.Mon_thi.Text = Ten_mon
        Me.Lop.Text = Ten_lop
        Binding()
    End Sub
    Public Sub Binding()
        sbd.DataBindings.Add("Text", DataSource, "So_bao_danh")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
    End Sub
End Class
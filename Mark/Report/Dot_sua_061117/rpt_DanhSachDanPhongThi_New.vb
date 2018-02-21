Public Class rpt_DanhSachDanPhongThi_New
    Public Sub New(ByVal dt As DataTable, Optional ByVal Ten_phong As String = "", Optional ByVal Tieu_de_bao_cao As String = "")
        InitializeComponent()
        Me.DataSource = dt
        Me.Dia_diem.Text = Ten_phong
        Me.Tieu_de_bao_cao.Text = Tieu_de_bao_cao
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_ngay.Text = gTieu_de_noi_ki & ", ngày " & Date.Now.Day.ToString & " tháng " & Date.Now.Month.ToString & " năm " & Date.Now.Year.ToString
        Binding()
    End Sub
    Public Sub Binding()
        SBD.DataBindings.Add("Text", DataSource, "So_bao_danh")
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
    End Sub
End Class
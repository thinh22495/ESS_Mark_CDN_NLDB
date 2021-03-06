Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rptDanhSachHocTiep
    Public Sub New(Optional ByVal dv As DataView = Nothing, Optional ByVal Tieu_de1 As String = "", Optional ByVal Khoa_hoc As String = "", Optional ByVal Chuyen_nganh As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        Me.Tieu_de_bao_cao1.Text = Tieu_de1.ToString.ToUpper
        Me.Khoa_hoc.Text = Khoa_hoc.ToString
        Me.Chuyen_nganh.Text = Chuyen_nganh.ToString
        Me.Tenlop.Text = "Lớp: " & dv.Item(0)("Ten_lop").ToString
        Me.DataSource = dv
        Binding()
    End Sub
    Public Sub Binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
    End Sub
End Class
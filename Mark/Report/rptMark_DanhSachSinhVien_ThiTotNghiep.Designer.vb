<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptMark_DanhSachSinhVien_ThiTotNghiep
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.STT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Ma_sv = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Ten_sinh_vien = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TBCHT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Xep_hang = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Ghi_chu = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ten_he = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ten_lop = New DevExpress.XtraReports.UI.XRLabel()
        Me.Khoa_hoc = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ten_nganh = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.Tong_sv = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de_nguoi_ky1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de_chuc_danh1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de_chuc_danh2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de_noi_ky = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de_nguoi_ky2 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 20.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(7.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(721.3335!, 20.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.STT, Me.Ma_sv, Me.Ten_sinh_vien, Me.TBCHT, Me.Xep_hang, Me.Ghi_chu})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'STT
        '
        Me.STT.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.STT.Name = "STT"
        Me.STT.StylePriority.UseFont = False
        Me.STT.Weight = 0.32097166555163553R
        '
        'Ma_sv
        '
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.Weight = 1.2595719439278414R
        '
        'Ten_sinh_vien
        '
        Me.Ten_sinh_vien.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ten_sinh_vien.Name = "Ten_sinh_vien"
        Me.Ten_sinh_vien.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.Ten_sinh_vien.StylePriority.UseFont = False
        Me.Ten_sinh_vien.StylePriority.UsePadding = False
        Me.Ten_sinh_vien.StylePriority.UseTextAlignment = False
        Me.Ten_sinh_vien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ten_sinh_vien.Weight = 2.0924871631972546R
        '
        'TBCHT
        '
        Me.TBCHT.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCHT.Name = "TBCHT"
        Me.TBCHT.StylePriority.UseFont = False
        Me.TBCHT.Weight = 0.98808155494567584R
        '
        'Xep_hang
        '
        Me.Xep_hang.Name = "Xep_hang"
        Me.Xep_hang.Weight = 1.4680800669668816R
        '
        'Ghi_chu
        '
        Me.Ghi_chu.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ghi_chu.Name = "Ghi_chu"
        Me.Ghi_chu.StylePriority.UseFont = False
        Me.Ghi_chu.Weight = 1.0841431359046105R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 39.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 33.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.Ten_he, Me.XrLabel6, Me.XrLabel9, Me.Ten_lop, Me.Khoa_hoc, Me.XrLabel4, Me.XrLabel5, Me.Ten_nganh, Me.Tieu_de1, Me.XrLabel2, Me.XrLabel1, Me.XrLine1, Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Me.XrLine2})
        Me.ReportHeader.HeightF = 222.5!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(5.666646!, 110.0833!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(721.3334!, 28.20834!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "( Kèm theo Quyết định số:       /QĐ-CĐĐB-ĐT, ngày      /      / 20      )"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Ten_he
        '
        Me.Ten_he.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Ten_he.LocationFloat = New DevExpress.Utils.PointFloat(513.2708!, 160.4167!)
        Me.Ten_he.Name = "Ten_he"
        Me.Ten_he.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_he.SizeF = New System.Drawing.SizeF(215.0626!, 22.99998!)
        Me.Ten_he.StylePriority.UseFont = False
        Me.Ten_he.StylePriority.UseTextAlignment = False
        Me.Ten_he.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(420.4791!, 160.4167!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(92.79166!, 22.99998!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Trình độ:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(420.4791!, 185.4167!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(92.79166!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Lớp học:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ten_lop
        '
        Me.Ten_lop.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Ten_lop.LocationFloat = New DevExpress.Utils.PointFloat(513.2708!, 185.4167!)
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_lop.SizeF = New System.Drawing.SizeF(215.0626!, 23.0!)
        Me.Ten_lop.StylePriority.UseFont = False
        Me.Ten_lop.StylePriority.UseTextAlignment = False
        Me.Ten_lop.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Khoa_hoc
        '
        Me.Khoa_hoc.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Khoa_hoc.LocationFloat = New DevExpress.Utils.PointFloat(166.0207!, 160.4167!)
        Me.Khoa_hoc.Name = "Khoa_hoc"
        Me.Khoa_hoc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Khoa_hoc.SizeF = New System.Drawing.SizeF(211.6251!, 22.99998!)
        Me.Khoa_hoc.StylePriority.UseFont = False
        Me.Khoa_hoc.StylePriority.UseTextAlignment = False
        Me.Khoa_hoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(82.97911!, 160.4167!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(83.04163!, 22.99998!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Khóa:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(82.97911!, 185.4167!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(83.04163!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Nghề:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ten_nganh
        '
        Me.Ten_nganh.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Ten_nganh.LocationFloat = New DevExpress.Utils.PointFloat(166.0207!, 185.4167!)
        Me.Ten_nganh.Name = "Ten_nganh"
        Me.Ten_nganh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_nganh.SizeF = New System.Drawing.SizeF(211.6251!, 23.0!)
        Me.Ten_nganh.StylePriority.UseFont = False
        Me.Ten_nganh.StylePriority.UseTextAlignment = False
        Me.Ten_nganh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Tieu_de1
        '
        Me.Tieu_de1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de1.LocationFloat = New DevExpress.Utils.PointFloat(7.000104!, 85.87497!)
        Me.Tieu_de1.Name = "Tieu_de1"
        Me.Tieu_de1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de1.SizeF = New System.Drawing.SizeF(721.3334!, 28.20834!)
        Me.Tieu_de1.StylePriority.UseFont = False
        Me.Tieu_de1.StylePriority.UseTextAlignment = False
        Me.Tieu_de1.Text = "DANH SÁCH HSSV ĐỦ ĐIỀU KIỆN DỰ THI TỐT NGHIỆP"
        Me.Tieu_de1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(371.5!, 33.70832!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(356.8335!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Độc lập - Tự do - Hạnh phúc"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel2.Visible = False
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(371.5!, 6.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(356.8334!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel1.Visible = False
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(462.0!, 61.70832!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(171.25!, 2.0!)
        Me.XrLine1.Visible = False
        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(7.000001!, 0.0!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF(274.5416!, 23.0!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_truong
        '
        Me.Tieu_de_ten_truong.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(7.000001!, 22.99999!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF(274.5416!, 40.70834!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.Text = "TRƯỜNG CAO ĐẲNG CÔNG NGHỆ VÀ NÔNG LÂM ĐÔNG BẮC"
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(58.16661!, 63.70834!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(170.375!, 2.0!)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.HeightF = 45.00001!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(7.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(721.3335!, 45.00001!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell4, Me.XrTableCell3, Me.XrTableCell5, Me.XrTableCell2, Me.XrTableCell12})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "TT"
        Me.XrTableCell1.Weight = 0.33333330745787187R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "MÃ SINH VIÊN"
        Me.XrTableCell4.Weight = 1.3080819650757689R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "HỌ VÀ TÊN"
        Me.XrTableCell3.Weight = 2.1730750336019642R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "TBCTK"
        Me.XrTableCell5.Weight = 1.0261346699382463R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "XẾP LOẠI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HỌC TẬP"
        Me.XrTableCell2.Weight = 1.5246211030373416R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Text = "Ghi chú"
        Me.XrTableCell12.Weight = 1.12589657165766R
        '
        'FormattingRule1
        '
        '
        '
        '
        Me.FormattingRule1.Formatting.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tong_sv, Me.XrLabel11, Me.XrLabel10, Me.XrLabel8, Me.XrLabel7, Me.Tieu_de_nguoi_ky1, Me.Tieu_de_chuc_danh1, Me.Tieu_de_chuc_danh2, Me.Tieu_de_noi_ky, Me.Tieu_de_nguoi_ky2})
        Me.ReportFooter.HeightF = 160.875!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'Tong_sv
        '
        Me.Tong_sv.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Tong_sv.LocationFloat = New DevExpress.Utils.PointFloat(162.5626!, 4.000007!)
        Me.Tong_sv.Name = "Tong_sv"
        Me.Tong_sv.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tong_sv.SizeF = New System.Drawing.SizeF(43.35419!, 23.0!)
        Me.Tong_sv.StylePriority.UseFont = False
        Me.Tong_sv.StylePriority.UseTextAlignment = False
        Me.Tong_sv.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(205.9168!, 4.000007!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(69.39584!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "học sinh"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(7.000104!, 4.000007!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(155.5625!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "* Ấn định danh sách :"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(462.0!, 38.9167!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(198.5625!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "NGƯỜI LẬP"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(82.97913!, 38.9167!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(198.5625!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "T.PHÒNG ĐÀO TẠO"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_nguoi_ky1
        '
        Me.Tieu_de_nguoi_ky1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Tieu_de_nguoi_ky1.LocationFloat = New DevExpress.Utils.PointFloat(396.257!, 127.875!)
        Me.Tieu_de_nguoi_ky1.Name = "Tieu_de_nguoi_ky1"
        Me.Tieu_de_nguoi_ky1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky1.SizeF = New System.Drawing.SizeF(264.3055!, 23.00002!)
        Me.Tieu_de_nguoi_ky1.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_nguoi_ky1.Visible = False
        '
        'Tieu_de_chuc_danh1
        '
        Me.Tieu_de_chuc_danh1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Tieu_de_chuc_danh1.LocationFloat = New DevExpress.Utils.PointFloat(323.7015!, 127.875!)
        Me.Tieu_de_chuc_danh1.Name = "Tieu_de_chuc_danh1"
        Me.Tieu_de_chuc_danh1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh1.SizeF = New System.Drawing.SizeF(264.3055!, 23.00002!)
        Me.Tieu_de_chuc_danh1.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_chuc_danh1.Visible = False
        '
        'Tieu_de_chuc_danh2
        '
        Me.Tieu_de_chuc_danh2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Tieu_de_chuc_danh2.LocationFloat = New DevExpress.Utils.PointFloat(351.742!, 127.875!)
        Me.Tieu_de_chuc_danh2.Name = "Tieu_de_chuc_danh2"
        Me.Tieu_de_chuc_danh2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh2.SizeF = New System.Drawing.SizeF(264.3055!, 23.00002!)
        Me.Tieu_de_chuc_danh2.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_chuc_danh2.Visible = False
        '
        'Tieu_de_noi_ky
        '
        Me.Tieu_de_noi_ky.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Tieu_de_noi_ky.LocationFloat = New DevExpress.Utils.PointFloat(352.7083!, 127.875!)
        Me.Tieu_de_noi_ky.Name = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_noi_ky.SizeF = New System.Drawing.SizeF(307.8542!, 23.00002!)
        Me.Tieu_de_noi_ky.StylePriority.UseFont = False
        Me.Tieu_de_noi_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_noi_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_noi_ky.Visible = False
        '
        'Tieu_de_nguoi_ky2
        '
        Me.Tieu_de_nguoi_ky2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Tieu_de_nguoi_ky2.LocationFloat = New DevExpress.Utils.PointFloat(457.7987!, 127.875!)
        Me.Tieu_de_nguoi_ky2.Name = "Tieu_de_nguoi_ky2"
        Me.Tieu_de_nguoi_ky2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky2.SizeF = New System.Drawing.SizeF(264.3055!, 23.00002!)
        Me.Tieu_de_nguoi_ky2.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_nguoi_ky2.Visible = False
        '
        'rptMark_DanhSachSinhVien_ThiTotNghiep
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(49, 41, 39, 33)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "15.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Tieu_de1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Tieu_de_ten_bo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents STT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_sinh_vien As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBCHT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents Ghi_chu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ma_sv As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_he As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ten_lop As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Khoa_hoc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ten_nganh As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Xep_hang As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Tieu_de_chuc_danh2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_noi_ky As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tong_sv As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
End Class

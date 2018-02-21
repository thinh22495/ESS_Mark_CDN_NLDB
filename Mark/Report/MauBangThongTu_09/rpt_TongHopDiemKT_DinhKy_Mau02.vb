Imports DevExpress.XtraReports.UI
Imports System.Drawing.Drawing2D
Public Class rpt_TongHopDiemKT_DinhKy_Mau02
    Public Sub New(ByVal dt As DataTable, ByVal dvSource As DataView, ByVal Ten_mon_hoc As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.DataSource = dvSource
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_noi_ky.Text = "Ngày " & Date.Now.Day.ToString & " tháng " & Date.Now.Month.ToString & " năm " & Date.Now.Year.ToString
        Me.lbl_Ten_mon_hoc.Text = Ten_mon_hoc
        Me.lbl_Lop.Text = dvSource.Item(0)("Ten_lop").ToString
        'Me.Ten_hoc_phan.Text = Ten_hoc_phan
        'Me.He.Text = He
        'Me.Chuyen_nganh.Text = Chuyen_nganh
        'Me.Ten_lop.Text = Ten_lop
        'Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        'Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        'Tieu_de_noi_ky.Text = gTieu_de_noi_ki & " Ngày " & DateTime.Now.Day.ToString() & "/" & DateTime.Now.Month.ToString() & "/" & DateTime.Now.Year
        ' Add any initialization after the InitializeComponent() call.
        Dim numCol As Integer = dt.DefaultView.Count - 1
        Dim childWidth As Double = Diem_kt.WidthF / (numCol + 1)
        For j As Integer = 0 To numCol
            Dim lb1 As New XRLabel()
            lb1.WidthF = childWidth
            lb1.HeightF = XrTableRow2.HeightF
            Dim p1 As New Point(j * childWidth, 0)
            lb1.LocationF = p1
            'no border left and right
            lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            If j = numCol Then
                lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
            Diem_kt.Controls.Add(lb1)
            lb1.DataBindings.Add("Text", DataSource, "TP" & dt.DefaultView(j).Row("ID_thanh_phan"), "{0:n1}")
            lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Next
        Binding()
    End Sub
    Private Sub Binding()
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Diem_tb.DataBindings.Add("Text", DataSource, "TBCBP")
        So_gio_nghi.DataBindings.Add("Text", DataSource, "So_tiet_nghi")
        Ghi_chu.DataBindings.Add("Text", DataSource, "Ghi_chu")
    End Sub

End Class
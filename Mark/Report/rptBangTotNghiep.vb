Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangTotNghiep
    'Public Sub New(Optional ByVal ID_sv As Integer = 0, Optional ByVal Tieu_de_bao_cao As String = "")
    '    InitializeComponent()
    '    Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
    '    Dim dt_bang As DataTable = obj.rpt_DTB_ToanKhoa(ID_sv)
    '    If dt_bang.Rows.Count > 0 Then
    '        Tieu_de_noi_ky.Text = "Hà nội, ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
    '        Me.Ten.Text = dt_bang.Rows(0).Item("Ho_ten").ToString
    '        Me.Ngay_sinh.Text = CType(dt_bang.Rows(0).Item("Ngay_sinh"), Date).ToString("dd/MM/yyyy")
    '        Me.Nam.Text = dt_bang.Rows(0).Item("Nam_TN").ToString
    '        Me.Xep_loai.Text = dt_bang.Rows(0).Item("xh").ToString
    '        Me.Hinh_thuc.Text = dt_bang.Rows(0).Item("Loai_dao_tao").ToString

    '        Me.Ten_en.Text = ChuyenSangKhongDau(dt_bang.Rows(0).Item("Ho_ten").ToString)
    '        Me.Ngay_sinh_en.Text = CType(dt_bang.Rows(0).Item("Ngay_sinh"), Date).ToString("MMMM dd, yyyy")
    '        Me.Nam_en.Text = dt_bang.Rows(0).Item("Nam_TN").ToString
    '        Me.Xep_loai_en.Text = dt_bang.Rows(0).Item("xh_en").ToString.ToString
    '        Me.Hinh_thuc_en.Text = dt_bang.Rows(0).Item("Loai_dao_tao_en").ToString
    '    End If
    'End Sub
    'Public Function ChuyenSangKhongDau(ByVal mystr As String) As String
    '    Dim myChar() As String = {"aàáảãạăằắẳẵặâầấẩẫậ", "AÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬ", "ÒÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢ", "EÈÉẺẼẸÊỀẾỂỄỆ", "UÙÚỦŨỤƯỪỨỬỮỰ", "IÌÍỈĨỊ", "YỲÝỶỸỴ", "Đ", "oòóỏõọôồốổỗộơờớởỡợ", "eèéẻẽẹêềếểễệ", "uùúủũụưừứửữự", "iìíỉĩị", "yỳýỷỹỵ", "đ"}
    '    Dim myChar1() As String = {"a", "A", "O", "E", "U", "I", "Y", "Đ", "o", "e", "u", "i", "y", "d"}
    '    Dim str As String = mystr
    '    Dim strReturn As String = ""
    '    For i As Int32 = 0 To str.Length - 1
    '        Dim iStr As String = str.Substring(i, 1)
    '        Dim rStr As String = iStr

    '        For j As Int32 = 0 To myChar.Length - 1
    '            If myChar(j).IndexOf(iStr) >= 0 Then
    '                rStr = myChar1(j)
    '                Exit For
    '            End If
    '        Next
    '        strReturn += rStr
    '    Next
    '    Return strReturn
    'End Function
End Class
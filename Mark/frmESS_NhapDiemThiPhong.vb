﻿Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports ESS.Catalogue
Imports ESS.Machine
Public Class frmESS_NhapDiemThiPhong
    Private Loader As Boolean = False
    Private mID_he As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_thi As Integer = 0
    Private mLan_hoc As Integer = 0
    Private mLan_thi As Integer = 0
    Private mID_mon As Integer = 0
    Private mID_phong_thi As Integer = 0
    Private mTen_mon As String = ""
    Private mNgay_thi As String = ""
    Private mTen_phong As String = ""
    Private clsDiem As New Diem_BLL
    Private clsTCThi As TochucThi_BLL
    Dim xlsFileName As String = ""
    Private dt As New DataTable
#Region "Function"
    Private Sub FormatDataView(ByVal dtKyHieuDiem As DataTable)
        Try
            grdViewDiem.Columns.Clear()
            'Trạng thái
            Dim col1 As New DataGridViewImageColumn
            With col1
                .Name = "imgLock"
                .HeaderText = "TT"
                .Width = 30
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col1)
            'Mã sinh viên
            Dim col2 As New DataGridViewTextBoxColumn
            With col2
                .Name = "Ma_sv"
                .DataPropertyName = "Ma_sv"
                .HeaderText = "Mã sinh viên"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col2)
            'Họ và tên
            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ho_ten"
                .DataPropertyName = "Ho_ten"
                .HeaderText = "Họ và tên"
                .Width = 200
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col3)
            'Các thành phần điểm
            Dim Tong_ty_le As Integer = 0
            For i As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                If clsDiem.ThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                    Dim col As New DataGridViewTextBoxColumn
                    With clsDiem.ThanhPhanDiem.ThanhPhanDiem(i)
                        col.Name = "TP" + .ID_thanh_phan.ToString
                        col.DataPropertyName = "TP" + .ID_thanh_phan.ToString
                        col.HeaderText = .Ky_hieu + " (" + .Ty_le.ToString + ")"
                        col.ToolTipText = .Ten_thanh_phan
                        col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        col.Width = 40
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        col.DefaultCellStyle.NullValue = ""
                        col.ReadOnly = True
                        Tong_ty_le += .Ty_le
                    End With
                    Me.grdViewDiem.Columns.Add(col)
                End If
            Next
            'TBCBP
            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "TBCBP"
                .DataPropertyName = "TBCBP"
                .HeaderText = "TBCBP"
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col5)
            'Điểm thi
            Dim col6 As New DataGridViewTextBoxColumn
            With col6
                .Name = "Diem_thi"
                .DataPropertyName = "Diem_thi"
                .HeaderText = "Thi"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
            End With
            Me.grdViewDiem.Columns.Add(col6)
            'TBCHP
            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "TBCHP"
                .DataPropertyName = "TBCHP"
                .HeaderText = "TBCHP"
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col7)
            'Ghi chú
            Dim col8 As New DataGridViewComboBoxColumn
            With col8
                .Name = "Ghi_chu"
                .DataPropertyName = "Ghi_chu"
                .HeaderText = "Ghi chú"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .MaxDropDownItems = 20
                .FlatStyle = FlatStyle.Standard
                .DropDownWidth = 80
                .DataSource = dtKyHieuDiem
                .ValueMember = "Ky_hieu"
                .DisplayMember = "Ky_hieu"
            End With
            Me.grdViewDiem.Columns.Add(col8)
            'Locked
            Dim col9 As New DataGridViewTextBoxColumn
            With col9
                .Name = "Locked"
                .DataPropertyName = "Locked"
                .HeaderText = ""
                .Visible = False
            End With
            Me.grdViewDiem.Columns.Add(col9)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Quyen_Khoa_Diem()
        Try
            Dim idx_quyen As Integer
            idx_quyen = gobjUser.Quyen.Tim_idx(gFunctionID)
            If idx_quyen >= 0 Then
                If gobjUser.Quyen.Quyen(idx_quyen).Xoa = 0 Then
                    'Disable nút khoá và mở khóa
                    cmdLock.Enabled = False
                    cmdUnLock.Enabled = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ReadOnly_Diem()
        Try
            Dim idx_quyen As Integer
            idx_quyen = gobjUser.Quyen.Tim_idx(gFunctionID)
            If idx_quyen >= 0 Then
                If gobjUser.Quyen.Quyen(idx_quyen).Sua = 0 Then
                    'ReadOnly toan bo diem thi
                    For i As Integer = 0 To grdViewDiem.RowCount - 1
                        If grdViewDiem.Rows(i).Cells("Diem_thi").Value.ToString <> "" Or grdViewDiem.Rows(i).Cells("Ghi_chu").Value.ToString <> "" Then
                            grdViewDiem.Rows(i).Cells("Diem_thi").ReadOnly = True
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub KhoaDuLieu(ByRef Lock_diem As Boolean)
        Try
            Lock_diem = False
            For i As Integer = 0 To grdViewDiem.RowCount - 1
                If grdViewDiem.Rows(i).Cells("Locked").Value = True Then    'Locked
                    If Lock_diem = False Then Lock_diem = True
                    grdViewDiem.Rows(i).Cells("Diem_thi").ReadOnly = True
                    Dim CellImage As New DataGridViewImageCell
                    CellImage.Value = My.Resources.Locked
                    CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                    grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                Else
                    If grdViewDiem.Rows(i).Cells("Diem_thi").Value.ToString <> "" Or grdViewDiem.Rows(i).Cells("Ghi_chu").Value.ToString <> "" Then    'Edit
                        Dim CellImage As New DataGridViewImageCell
                        CellImage.Value = My.Resources.Edit
                        CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                        grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                    Else    'Add new
                        Dim CellImage As New DataGridViewImageCell
                        CellImage.Value = My.Resources.Add
                        CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                        grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                    End If
                End If
            Next
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Function Diem_chu(ByVal str As String) As String
        Dim Arr(11) As String
        Arr(0) = "không"
        Arr(1) = "một"
        Arr(2) = "hai"
        Arr(3) = "ba"
        Arr(4) = "bốn"
        Arr(5) = "năm"
        Arr(6) = "sáu"
        Arr(7) = "bảy"
        Arr(8) = "tám"
        Arr(9) = "chín"
        Arr(10) = "mười"
        If str <> "" Then
            For i As Integer = 0 To 10
                str = Replace(str, i.ToString, Arr(i))
            Next
            str = Replace(str, ".", ", ")
            If str.Length >= 2 Then
                str = Mid(str, 1, 1).ToUpper + Mid(str, 2)
            End If
        End If
        Return str
    End Function
#End Region

#Region "Form Events"
    Private Sub frmESS_NhapDiemThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetUpDataGridView(grdViewDiem)
            Loader = True
            SetQuyenTruyCap(, btnSave, , btnDel)
            Quyen_Khoa_Diem()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_NhapDiemThiLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub trvPhongThi_Select() Handles trvPhongThi.TreeNodeSelected_
        Me.Cursor = Cursors.WaitCursor
        Try
            If Loader Then
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_hoc = 1
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi

                mTen_mon = trvPhongThi.Ten_mon
                mTen_phong = trvPhongThi.Phong_thi
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDiemKyHieu As DataTable
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_BLL(mID_thi)
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, True)
                        If mLan_thi = 1 Then
                            grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan1(mID_mon, 1).DefaultView
                        Else
                            grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan(1, mLan_thi, mID_mon, False).DefaultView
                        End If
                        dtDiemKyHieu = clsDiem.Load_DiemKyHieu_List
                        FormatDataView(dtDiemKyHieu)
                        Dim Lock_diem As Boolean = False
                        ReadOnly_Diem()
                        KhoaDuLieu(Lock_diem)
                        If Lock_diem = True Then
                            btnDel.Enabled = False
                            btnSave.Enabled = False
                            cmdLock.Enabled = False
                            cmdUnLock.Enabled = True
                        Else
                            btnDel.Enabled = True
                            btnSave.Enabled = True
                            cmdLock.Enabled = True
                            cmdUnLock.Enabled = False
                        End If
                    Else
                        grdViewDiem.DataSource = Nothing
                    End If
                End If
            End If
            SetQuyenTruyCap(, btnSave, , btnDel)
            Quyen_Khoa_Diem()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub grdViewDiem_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdViewDiem.CellEndEdit
        If e.ColumnIndex = grdViewDiem.Columns("Diem_thi").Index Then
            If grdViewDiem.CurrentCell.Value.ToString <> "" AndAlso Not IsNumeric(grdViewDiem.CurrentCell.Value) Then
                Thongbao("Bạn phải nhập điểm là số !")
                grdViewDiem.CurrentCell.Value = DBNull.Value
            End If
            If grdViewDiem.CurrentCell.Value.ToString <> "" AndAlso (grdViewDiem.CurrentCell.Value < 0 Or grdViewDiem.CurrentCell.Value > 10) Then
                Thongbao("Bạn phải nhập điểm là số từ 0 đến 10 !")
                grdViewDiem.CurrentCell.Value = DBNull.Value
            End If
        End If
    End Sub
#End Region

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            grdViewDiem.EndEdit()
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            Dim idx_diem, idx_diem_thi As Integer
            Dim Noi_dung_Add As String = ""
            Dim Noi_dung_Edit As String = ""
            'Gán các điểm thi vào object điểm, điểm thi
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                idx_diem = dtDiem.Rows(i)("idx_diem")
                idx_diem_thi = dtDiem.Rows(i)("idx_diem_thi")
                If dtDiem.Rows(i)("Diem_thi").ToString <> "" Or dtDiem.Rows(i)("Ghi_chu").ToString = "X" Then
                    Dim objDiem As New Diem
                    Dim objDiemThi As New DiemThi
                    'Nếu chưa có môn học này thì insert thêm vào object điểm
                    If idx_diem = -1 Then
                        objDiem.Hoc_ky = mHoc_ky
                        objDiem.Nam_hoc = mNam_hoc
                        objDiem.ID_mon = mID_mon
                        objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                        objDiem.ID_dv = gobjUser.ID_dv
                        objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")
                        clsDiem.Add(objDiem)
                    Else
                        objDiem = clsDiem.Diem(idx_diem)
                    End If
                    'Nếu là nhập mới điểm thi thì insert thêm object điểm thi mới
                    If idx_diem_thi = -1 Then
                        objDiemThi.Lan_hoc = mLan_hoc
                        objDiemThi.Lan_thi = mLan_thi
                        If dtDiem.Rows(i)("Diem_thi").ToString = "" Then
                            objDiemThi.Diem_thi = -1
                        Else
                            objDiemThi.Diem_thi = dtDiem.Rows(i)("Diem_thi")
                        End If
                        objDiemThi.Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        objDiem.dsDiemThi.Add(objDiemThi)
                        Noi_dung_Add += vbCrLf & " -ID_sv:" & dtDiem.Rows(i)("ID_sv") & " -Ma_SV:" & dtDiem.Rows(i)("Ma_sv").ToString & " Điểm thi:" & dtDiem.Rows(i)("Diem_thi").ToString
                    Else
                        If dtDiem.Rows(i)("Diem_thi").ToString = "" Then
                            objDiemThi.Diem_thi = -1
                        Else
                            objDiemThi.Diem_thi = dtDiem.Rows(i)("Diem_thi")
                            objDiem.dsDiemThi.DiemThi(idx_diem_thi).Diem_thi = dtDiem.Rows(i)("Diem_thi")
                        End If
                        objDiem.dsDiemThi.DiemThi(idx_diem_thi).Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        Noi_dung_Edit += vbCrLf & " -ID_sv:" & dtDiem.Rows(i)("ID_sv") & " -Ma_SV:" & dtDiem.Rows(i)("Ma_sv").ToString & " Điểm thi:" & dtDiem.Rows(i)("Diem_thi").ToString
                    End If
                Else
                    If idx_diem >= 0 And idx_diem_thi >= 0 Then
                        clsDiem.Diem(idx_diem).dsDiemThi.DiemThi(idx_diem_thi).Diem_thi = -1
                    End If
                End If
            Next
            'Save Log 
            If Noi_dung_Add.Trim <> "" Then
                Noi_dung_Add = "Bổ sung điểm thi học phần " & mTen_mon & " -Lần thi " & mLan_thi & " -Học kỳ " & mHoc_ky & " -Năm học " & mNam_hoc & Noi_dung_Add
                SaveLog(LoaiSuKien.Them, Noi_dung_Add)
            End If
            If Noi_dung_Edit.Trim <> "" Then
                Noi_dung_Edit = "Sửa điểm thi học phần " & mTen_mon & " -Lần thi " & mLan_thi & " -Học kỳ " & mHoc_ky & " -Năm học " & mNam_hoc & Noi_dung_Edit
                SaveLog(LoaiSuKien.Sua, Noi_dung_Edit)
            End If

            'Lưu điểm thi
            clsDiem.LuuDiemThi(1, mLan_thi)
            'Load lại dữ liệu điểm
            Call trvPhongThi_Select()
            Thongbao("Đã lưu điểm thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim dt_ngay As DataTable = clsTCThi.DanhSachMonToChucThi()
                If dt_ngay.Rows.Count > 0 Then
                    mNgay_thi = dt_ngay.Rows(0).Item("Ngay_thi")
                End If

                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim dtTP As DataTable
                Tieu_de1 = "KẾT QUẢ HỌC TẬP " & mTen_mon.ToUpper
                Tieu_de2 = "Lần thi: " & mLan_thi & " Học kỳ:" & mHoc_ky & " Năm học: " & mNam_hoc
                Tieu_de3 = mTen_phong & vbTab & "Ngày thi: " & Format(CType(mNgay_thi, Date), "dd/MM/yyyy")

                Dim dtDiemTH As DataTable = grdViewDiem.DataSource.Table
                Dim XS, Gioi, Kha, TB, Duoi5 As Integer
                dtDiemTH.DefaultView.RowFilter = "TBCHP >= 9"
                XS = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCHP >= 8 AND TBCHP < 9"
                Gioi = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCHP >= 7 AND TBCHP < 8"
                Kha = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCHP >= 5 AND TBCHP < 7"
                TB = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCHP < 5 "
                Duoi5 = dtDiemTH.DefaultView.Count

                dtDiemTH.DefaultView.RowFilter = ""
                dtTP = clsDiem.DanhSachThanhPhanChon
                TaoBaoCaoBangDiemThiHocPhan(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, Tieu_de3, dtTP, XS, Gioi, Kha, TB, Duoi5)
                C1Report1.DataSource.Recordset = dtDiemTH
                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog(C1Report1)
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportToExcel
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDataGridViewToExcel(grdViewDiem, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnKyHieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmESS_ As New frmESS_DMDiemKyHieu
        frmESS_.ShowDialog()
    End Sub

    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        With dlgOpenFile
            .InitialDirectory = Application.StartupPath
            .Filter = "Tệp Excel|*.xls"
            .FilterIndex = 1
        End With
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            xlsFileName = dlgOpenFile.FileName
            Dim xlsFile As String = xlsFileName.Trim.ToLower.Substring(xlsFileName.Trim.Length - 3, 3)
            If xlsFile = "xls" Then
                Try
                    cmbChonFile.Items.Clear()
                    Dim conADO As New ADODB.Connection
                    Dim myrs As New ADODB.Recordset
                    conADO.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    myrs = conADO.OpenSchema(ADODB.SchemaEnum.adSchemaTables)
                    While Not myrs.EOF
                        If myrs.Fields("TABLE_NAME").Value.ToString.Length > 0 Then
                            If myrs.Fields("TABLE_NAME").Value.ToString.Substring(myrs.Fields("TABLE_NAME").Value.ToString.Length - 1, 1) = "$" Then
                                cmbChonFile.Items.Add(myrs.Fields("TABLE_NAME").Value)
                            End If
                        End If
                        myrs.MoveNext()
                    End While
                    myrs.Close()
                    If cmbChonFile.Items.Count > 0 Then
                        cmbChonFile.SelectedIndex = 0
                    End If
                Catch
                End Try
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdDongBo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDongBo.Click
        Try
            Dim dv As DataView = grdViewDiem.DataSource
            For i As Integer = 0 To dv.Count - 1
                Dim dk As String = cmbMa_sv.Text & "=" & "'" & dv.Item(i)("Ma_sv").ToString & "'"
                dt.DefaultView.RowFilter = dk
                If dt.DefaultView.Count > 0 Then
                    dv.Item(i)("Diem_thi") = dt.DefaultView.Item(0)(cmbCot_diem.Text)
                End If
                If dv.Item(i)("TP31").ToString <> "" And dv.Item(i)("Diem_thi").ToString = "" Then
                    dv.Item(i)("Diem_thi") = 0
                End If
            Next
        Catch ex As Exception
            Thongbao("Có lỗi đồng bộ từ Excel", MsgBoxStyle.Information, "Thông báo")
        End Try
    End Sub

    Private Sub cmbChonFile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChonFile.SelectedIndexChanged
        If cmbChonFile.SelectedIndex >= 0 Then
            Me.Cursor = Cursors.WaitCursor
            If xlsFileName.Trim <> "" Then
                Try
                    dt = New DataTable
                    Dim oleCnn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [" & cmbChonFile.Text & "]", oleCnn)
                    da.Fill(dt)
                    Dim dt_tp, dt_tp_excel, dt_maSV As New DataTable
                    dt_tp_excel.Columns.Add("ID_TP_E", GetType(Integer))
                    dt_tp_excel.Columns.Add("Ten_TP_E", GetType(String))
                    If dt.Columns.Count > 0 Then
                        For j As Integer = 0 To dt.Columns.Count - 1
                            Dim dr As DataRow = dt_tp_excel.NewRow
                            dr("ID_TP_E") = j
                            dr("Ten_TP_E") = dt.Columns(j).ColumnName
                            dt_tp_excel.Rows.Add(dr)
                        Next
                    End If
                    FillCombo(cmbCot_diem, dt_tp_excel)
                    dt_maSV = dt_tp_excel.Copy
                    FillCombo(cmbMa_sv, dt_maSV)

                    dt_tp.Columns.Add("ID_TP", GetType(Integer))
                    dt_tp.Columns.Add("Ten_TP", GetType(String))

                    Dim dr1 As DataRow = dt_tp.NewRow
                    dr1("ID_tp") = 1
                    dr1("Ten_TP") = "Điểm thi"
                    dt_tp.Rows.Add(dr1)
                    FillCombo(cmbThanh_phan, dt_tp)
                Catch
                End Try
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = "Các bước nhập điểm thi qua Excel: "
        str = str + vbCrLf
        str = str + "1. Chọn biểu tượng folder để mở file excel" + vbCrLf
        str = str + "2. Chọn Sheet của file excel" + vbCrLf
        str = str + "3. Chọn cột Mã sinh viên" + vbCrLf
        str = str + "4. Người dùng lần lượt chọn Cột điểm thi của file excel tương ứng với Cột điểm thi" + vbCrLf
        str = str + "5. Chọn Đồng bộ dữ liệu từ Excel" + vbCrLf
        Thongbao(str, MsgBoxStyle.Information)
    End Sub

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            grdViewDiem.EndEdit()
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            Dim idx_diem, idx_diem_thi As Integer
            Dim Noi_dung_Add As String = ""
            Dim Noi_dung_Edit As String = ""
            'Gán các điểm thi vào object điểm, điểm thi
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                idx_diem = dtDiem.Rows(i)("idx_diem")
                idx_diem_thi = dtDiem.Rows(i)("idx_diem_thi")
                If dtDiem.Rows(i)("Diem_thi").ToString <> "" Or dtDiem.Rows(i)("Ghi_chu").ToString = "X" Then
                    Dim objDiem As New Diem
                    Dim objDiemThi As New DiemThi
                    'Nếu chưa có môn học này thì insert thêm vào object điểm
                    If idx_diem = -1 Then
                        objDiem.Hoc_ky = mHoc_ky
                        objDiem.Nam_hoc = mNam_hoc
                        objDiem.ID_mon = mID_mon
                        objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                        objDiem.ID_dv = gobjUser.ID_dv
                        objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")
                        clsDiem.Add(objDiem)
                    Else
                        objDiem = clsDiem.Diem(idx_diem)
                    End If
                    'Nếu là nhập mới điểm thi thì insert thêm object điểm thi mới
                    If idx_diem_thi = -1 Then
                        objDiemThi.Lan_hoc = mLan_hoc
                        objDiemThi.Lan_thi = mLan_thi
                        If dtDiem.Rows(i)("Diem_thi").ToString = "" Then
                            objDiemThi.Diem_thi = -1
                        Else
                            objDiemThi.Diem_thi = dtDiem.Rows(i)("Diem_thi")
                        End If
                        objDiemThi.Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        objDiem.dsDiemThi.Add(objDiemThi)
                        Noi_dung_Add += vbCrLf & " -ID_sv:" & dtDiem.Rows(i)("ID_sv") & " -Ma_SV:" & dtDiem.Rows(i)("Ma_sv").ToString & " Điểm thi:" & dtDiem.Rows(i)("Diem_thi").ToString
                    Else
                        If dtDiem.Rows(i)("Diem_thi").ToString = "" Then
                            objDiemThi.Diem_thi = -1
                        Else
                            objDiemThi.Diem_thi = dtDiem.Rows(i)("Diem_thi")
                            objDiem.dsDiemThi.DiemThi(idx_diem_thi).Diem_thi = dtDiem.Rows(i)("Diem_thi")
                        End If
                        objDiem.dsDiemThi.DiemThi(idx_diem_thi).Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        Noi_dung_Edit += vbCrLf & " -ID_sv:" & dtDiem.Rows(i)("ID_sv") & " -Ma_SV:" & dtDiem.Rows(i)("Ma_sv").ToString & " Điểm thi:" & dtDiem.Rows(i)("Diem_thi").ToString
                    End If
                Else
                    If idx_diem >= 0 And idx_diem_thi >= 0 Then
                        clsDiem.Diem(idx_diem).dsDiemThi.DiemThi(idx_diem_thi).Diem_thi = -1
                    End If
                End If
            Next
            'Save Log 
            If Noi_dung_Add.Trim <> "" Then
                Noi_dung_Add = "Bổ sung điểm thi học phần " & mTen_mon & " -Lần thi " & mLan_thi & " -Học kỳ " & mHoc_ky & " -Năm học " & mNam_hoc & Noi_dung_Add
                SaveLog(LoaiSuKien.Them, Noi_dung_Add)
            End If
            If Noi_dung_Edit.Trim <> "" Then
                Noi_dung_Edit = "Sửa điểm thi học phần " & mTen_mon & " -Lần thi " & mLan_thi & " -Học kỳ " & mHoc_ky & " -Năm học " & mNam_hoc & Noi_dung_Edit
                SaveLog(LoaiSuKien.Sua, Noi_dung_Edit)
            End If

            'Lưu điểm thi
            clsDiem.LuuDiemThi(1, mLan_thi)
            'Load lại dữ liệu điểm
            Call trvPhongThi_Select()
            Thongbao("Đã lưu điểm thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            If Thongbao("Chắc chắn bạn muốn xoá điểm của tất cả các sinh viên không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                Dim ID_diem As Integer
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    If dtDiem.Rows(i)("Diem_thi").ToString <> "" Then
                        ID_diem = CInt("0" + dtDiem.Rows(i)("ID_diem").ToString)
                        clsDiem.Delete_DiemThi(ID_diem, mLan_hoc, mLan_thi)
                        dtDiem.Rows(i)("Diem_thi") = DBNull.Value
                        dtDiem.Rows(i)("TBCHP") = DBNull.Value
                    End If
                Next
                'Load lại dữ liệu điểm
                Call trvPhongThi_Select()
                Thongbao("Đã xoá điểm thành công")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnPrint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim dt_ngay As DataTable = clsTCThi.DanhSachMonToChucThi()
                If dt_ngay.Rows.Count > 0 Then
                    mNgay_thi = dt_ngay.Rows(0).Item("Ngay_thi")
                End If

                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim dtTP As DataTable
                Tieu_de1 = "KẾT QUẢ HỌC TẬP " & mTen_mon.ToUpper
                Tieu_de2 = "Lần thi: " & mLan_thi & " Học kỳ:" & mHoc_ky & " Năm học: " & mNam_hoc
                Tieu_de3 = mTen_phong & vbTab & "Ngày thi: " & Format(CType(mNgay_thi, Date), "dd/MM/yyyy")

                Dim dtDiemTH As DataTable = grdViewDiem.DataSource.Table
                Dim XS, Gioi, Kha, TB, Duoi5 As Integer
                dtDiemTH.DefaultView.RowFilter = "TBCHP >= 9"
                XS = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCHP >= 8 AND TBCHP < 9"
                Gioi = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCHP >= 7 AND TBCHP < 8"
                Kha = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCHP >= 5 AND TBCHP < 7"
                TB = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCHP < 5 "
                Duoi5 = dtDiemTH.DefaultView.Count

                dtDiemTH.DefaultView.RowFilter = ""
                dtTP = clsDiem.DanhSachThanhPhanChon
                TaoBaoCaoBangDiemThiHocPhan(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, Tieu_de3, dtTP, XS, Gioi, Kha, TB, Duoi5)
                C1Report1.DataSource.Recordset = dtDiemTH
                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog(C1Report1)
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExcel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportToExcel
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDataGridViewToExcel(grdViewDiem, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Dim frmESS_ As New frmESS_DMDiemKyHieu
        frmESS_.ShowDialog()
    End Sub

    Private Sub btnThoat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If mLan_thi <= 0 Then Exit Sub
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                clsDiem.Lock_UnLock_Diem(dtDiem.Rows(i)("ID_sv"), mID_mon, mLan_hoc, mLan_thi, 1)
            Next
            'Load lại dữ liệu điểm
            Call trvPhongThi_Select()
            Thongbao("Đã khoá điểm thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdUnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnLock.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If mLan_thi <= 0 Then Exit Sub
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                clsDiem.Lock_UnLock_Diem(dtDiem.Rows(i)("ID_sv"), mID_mon, mLan_hoc, mLan_thi, 0)
            Next
            'Load lại dữ liệu điểm
            Call trvPhongThi_Select()
            Thongbao("Đã mở khoá điểm thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class
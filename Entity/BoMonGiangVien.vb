﻿'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Wednesday, June 04, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class BoMonGiangVien
        Inherits GiaoVien

#Region "Constructor"
        
#End Region

#Region "Var"
        Private mID_bm As Integer = 0
#End Region

#Region "Property"
        Public Property ID_bm() As Integer
            Get
                Return mID_bm
            End Get
            Set(ByVal Value As Integer)
                mID_bm = Value
            End Set
        End Property
#End Region

    End Class
End Namespace

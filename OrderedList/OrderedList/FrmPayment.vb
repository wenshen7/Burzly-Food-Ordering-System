Imports System.Text
Public Class FrmPayment
    Public Property AutoSizeColumnsMode As DataGridViewAutoSizeColumnsMode
    Friend totalPrice As Decimal
    Private db As BurzlyDataContext
    Friend tableNo As String
    'Private db As BurzlyDataContext
    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        totalPrice = 0
        'frmProductMenu.tableNumber = tableNo
        Dim db As New BurzlyDataContext

        txtTable.Text = tableNo
 
        txtDate.Text = CStr(Date.Now.Date())
        txtTime.Text = DateTime.Now.ToShortTimeString()
        txtTime.Enabled = False
        txtDate.Enabled = False
        txtPaymentID.Enabled = False
        txtTable.Enabled = False

    End Sub


End Class
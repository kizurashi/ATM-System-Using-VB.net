<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill))
        Me.lblBill = New System.Windows.Forms.Label()
        Me.lblANumber = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAOwner = New System.Windows.Forms.Label()
        Me.lblBAmount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCBal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBill
        '
        Me.lblBill.BackColor = System.Drawing.Color.Transparent
        Me.lblBill.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBill.ForeColor = System.Drawing.Color.White
        Me.lblBill.Location = New System.Drawing.Point(12, 9)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(445, 43)
        Me.lblBill.TabIndex = 10
        Me.lblBill.Text = "Water Bill"
        Me.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblANumber
        '
        Me.lblANumber.BackColor = System.Drawing.Color.Transparent
        Me.lblANumber.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblANumber.ForeColor = System.Drawing.Color.White
        Me.lblANumber.Location = New System.Drawing.Point(213, 69)
        Me.lblANumber.Name = "lblANumber"
        Me.lblANumber.Size = New System.Drawing.Size(231, 23)
        Me.lblANumber.TabIndex = 55
        Me.lblANumber.Text = "2013100441"
        Me.lblANumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(54, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 23)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Account Number:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(54, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Account Owner:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAOwner
        '
        Me.lblAOwner.BackColor = System.Drawing.Color.Transparent
        Me.lblAOwner.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAOwner.ForeColor = System.Drawing.Color.White
        Me.lblAOwner.Location = New System.Drawing.Point(213, 107)
        Me.lblAOwner.Name = "lblAOwner"
        Me.lblAOwner.Size = New System.Drawing.Size(231, 23)
        Me.lblAOwner.TabIndex = 53
        Me.lblAOwner.Text = "John Christian S. Viray"
        Me.lblAOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBAmount
        '
        Me.lblBAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblBAmount.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBAmount.ForeColor = System.Drawing.Color.White
        Me.lblBAmount.Location = New System.Drawing.Point(213, 172)
        Me.lblBAmount.Name = "lblBAmount"
        Me.lblBAmount.Size = New System.Drawing.Size(231, 23)
        Me.lblBAmount.TabIndex = 57
        Me.lblBAmount.Text = "$20,000"
        Me.lblBAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(54, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 23)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Bill Amount:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCBal
        '
        Me.lblCBal.BackColor = System.Drawing.Color.Transparent
        Me.lblCBal.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCBal.ForeColor = System.Drawing.Color.White
        Me.lblCBal.Location = New System.Drawing.Point(213, 138)
        Me.lblCBal.Name = "lblCBal"
        Me.lblCBal.Size = New System.Drawing.Size(234, 23)
        Me.lblCBal.TabIndex = 59
        Me.lblCBal.Text = "$20,000"
        Me.lblCBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(54, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 23)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Current Balance:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReturn
        '
        Me.btnReturn.BackgroundImage = CType(resources.GetObject("btnReturn.BackgroundImage"), System.Drawing.Image)
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturn.Location = New System.Drawing.Point(244, 213)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(122, 48)
        Me.btnReturn.TabIndex = 60
        Me.btnReturn.Text = "Return Main"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.BackgroundImage = CType(resources.GetObject("btnPay.BackgroundImage"), System.Drawing.Image)
        Me.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPay.Location = New System.Drawing.Point(104, 213)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(122, 48)
        Me.btnPay.TabIndex = 61
        Me.btnPay.Text = "Pay Now"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblPaid
        '
        Me.lblPaid.BackColor = System.Drawing.Color.Transparent
        Me.lblPaid.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.ForeColor = System.Drawing.Color.White
        Me.lblPaid.Location = New System.Drawing.Point(25, 107)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(432, 43)
        Me.lblPaid.TabIndex = 62
        Me.lblPaid.Text = "No Bill Unpaid"
        Me.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATM.My.Resources.Resources.image_background_color_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(469, 288)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblCBal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblBAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblANumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAOwner)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblBill)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBill As System.Windows.Forms.Label
    Friend WithEvents lblANumber As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAOwner As System.Windows.Forms.Label
    Friend WithEvents lblBAmount As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCBal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents lblPaid As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Balance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Balance))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAOwner = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblANumber = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBal = New System.Windows.Forms.Label()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(434, 43)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Balance"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAOwner
        '
        Me.lblAOwner.BackColor = System.Drawing.Color.Transparent
        Me.lblAOwner.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAOwner.ForeColor = System.Drawing.Color.White
        Me.lblAOwner.Location = New System.Drawing.Point(177, 118)
        Me.lblAOwner.Name = "lblAOwner"
        Me.lblAOwner.Size = New System.Drawing.Size(250, 23)
        Me.lblAOwner.TabIndex = 49
        Me.lblAOwner.Text = "John Christian S. Viray"
        Me.lblAOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Account Owner:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblANumber
        '
        Me.lblANumber.BackColor = System.Drawing.Color.Transparent
        Me.lblANumber.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblANumber.ForeColor = System.Drawing.Color.White
        Me.lblANumber.Location = New System.Drawing.Point(193, 80)
        Me.lblANumber.Name = "lblANumber"
        Me.lblANumber.Size = New System.Drawing.Size(234, 23)
        Me.lblANumber.TabIndex = 51
        Me.lblANumber.Text = "2013100441"
        Me.lblANumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(34, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 23)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Account Number:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(34, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 23)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Current Balance:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBal
        '
        Me.lblBal.BackColor = System.Drawing.Color.Transparent
        Me.lblBal.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBal.ForeColor = System.Drawing.Color.White
        Me.lblBal.Location = New System.Drawing.Point(193, 155)
        Me.lblBal.Name = "lblBal"
        Me.lblBal.Size = New System.Drawing.Size(234, 23)
        Me.lblBal.TabIndex = 49
        Me.lblBal.Text = "$20000"
        Me.lblBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button17
        '
        Me.Button17.BackgroundImage = CType(resources.GetObject("Button17.BackgroundImage"), System.Drawing.Image)
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button17.Location = New System.Drawing.Point(347, 7)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(99, 45)
        Me.Button17.TabIndex = 52
        Me.Button17.Text = "Return Main"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATM.My.Resources.Resources.image_background_color_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(458, 214)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.lblANumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblBal)
        Me.Controls.Add(Me.lblAOwner)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Balance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAOwner As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblANumber As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblBal As System.Windows.Forms.Label
    Friend WithEvents Button17 As System.Windows.Forms.Button
End Class

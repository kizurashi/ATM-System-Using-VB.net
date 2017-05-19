<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayBill))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRtrn = New System.Windows.Forms.Button()
        Me.btnLBill = New System.Windows.Forms.Button()
        Me.btnPBill = New System.Windows.Forms.Button()
        Me.btnEBill = New System.Windows.Forms.Button()
        Me.btnWBill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(479, 43)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Pay Bills"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRtrn
        '
        Me.btnRtrn.BackgroundImage = CType(resources.GetObject("btnRtrn.BackgroundImage"), System.Drawing.Image)
        Me.btnRtrn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRtrn.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRtrn.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnRtrn.Location = New System.Drawing.Point(369, 305)
        Me.btnRtrn.Name = "btnRtrn"
        Me.btnRtrn.Size = New System.Drawing.Size(122, 77)
        Me.btnRtrn.TabIndex = 27
        Me.btnRtrn.Text = "Return Main"
        Me.btnRtrn.UseVisualStyleBackColor = True
        '
        'btnLBill
        '
        Me.btnLBill.BackgroundImage = CType(resources.GetObject("btnLBill.BackgroundImage"), System.Drawing.Image)
        Me.btnLBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLBill.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLBill.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnLBill.Location = New System.Drawing.Point(255, 183)
        Me.btnLBill.Name = "btnLBill"
        Me.btnLBill.Size = New System.Drawing.Size(236, 116)
        Me.btnLBill.TabIndex = 31
        Me.btnLBill.Text = "Loan"
        Me.btnLBill.UseVisualStyleBackColor = True
        '
        'btnPBill
        '
        Me.btnPBill.BackgroundImage = CType(resources.GetObject("btnPBill.BackgroundImage"), System.Drawing.Image)
        Me.btnPBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPBill.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPBill.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnPBill.Location = New System.Drawing.Point(17, 183)
        Me.btnPBill.Name = "btnPBill"
        Me.btnPBill.Size = New System.Drawing.Size(232, 116)
        Me.btnPBill.TabIndex = 30
        Me.btnPBill.Text = "Phone"
        Me.btnPBill.UseVisualStyleBackColor = True
        '
        'btnEBill
        '
        Me.btnEBill.BackgroundImage = CType(resources.GetObject("btnEBill.BackgroundImage"), System.Drawing.Image)
        Me.btnEBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEBill.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEBill.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnEBill.Location = New System.Drawing.Point(255, 62)
        Me.btnEBill.Name = "btnEBill"
        Me.btnEBill.Size = New System.Drawing.Size(236, 116)
        Me.btnEBill.TabIndex = 29
        Me.btnEBill.Text = "Electric Bill"
        Me.btnEBill.UseVisualStyleBackColor = True
        '
        'btnWBill
        '
        Me.btnWBill.BackgroundImage = CType(resources.GetObject("btnWBill.BackgroundImage"), System.Drawing.Image)
        Me.btnWBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWBill.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWBill.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnWBill.Location = New System.Drawing.Point(17, 62)
        Me.btnWBill.Name = "btnWBill"
        Me.btnWBill.Size = New System.Drawing.Size(232, 116)
        Me.btnWBill.TabIndex = 28
        Me.btnWBill.Text = "Water Bill"
        Me.btnWBill.UseVisualStyleBackColor = True
        '
        'PayBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATM.My.Resources.Resources.image_background_color_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(505, 395)
        Me.Controls.Add(Me.btnLBill)
        Me.Controls.Add(Me.btnPBill)
        Me.Controls.Add(Me.btnEBill)
        Me.Controls.Add(Me.btnWBill)
        Me.Controls.Add(Me.btnRtrn)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PayBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayBill"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRtrn As System.Windows.Forms.Button
    Friend WithEvents btnLBill As System.Windows.Forms.Button
    Friend WithEvents btnPBill As System.Windows.Forms.Button
    Friend WithEvents btnEBill As System.Windows.Forms.Button
    Friend WithEvents btnWBill As System.Windows.Forms.Button
End Class

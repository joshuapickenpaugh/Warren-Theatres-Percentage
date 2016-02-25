<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtSalesOne = New System.Windows.Forms.TextBox()
        Me.txtSalesTwo = New System.Windows.Forms.TextBox()
        Me.txtSalesThree = New System.Windows.Forms.TextBox()
        Me.lblPercentOne = New System.Windows.Forms.Label()
        Me.lblPercentTwo = New System.Windows.Forms.Label()
        Me.lblPercentThree = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtSalesFour = New System.Windows.Forms.TextBox()
        Me.lblPercentFour = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSalesOne
        '
        Me.txtSalesOne.Location = New System.Drawing.Point(66, 22)
        Me.txtSalesOne.Name = "txtSalesOne"
        Me.txtSalesOne.Size = New System.Drawing.Size(116, 23)
        Me.txtSalesOne.TabIndex = 0
        Me.txtSalesOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSalesTwo
        '
        Me.txtSalesTwo.Location = New System.Drawing.Point(66, 52)
        Me.txtSalesTwo.Name = "txtSalesTwo"
        Me.txtSalesTwo.Size = New System.Drawing.Size(116, 23)
        Me.txtSalesTwo.TabIndex = 1
        Me.txtSalesTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSalesThree
        '
        Me.txtSalesThree.Location = New System.Drawing.Point(66, 82)
        Me.txtSalesThree.Name = "txtSalesThree"
        Me.txtSalesThree.Size = New System.Drawing.Size(116, 23)
        Me.txtSalesThree.TabIndex = 2
        Me.txtSalesThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPercentOne
        '
        Me.lblPercentOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercentOne.Location = New System.Drawing.Point(22, 22)
        Me.lblPercentOne.Name = "lblPercentOne"
        Me.lblPercentOne.Size = New System.Drawing.Size(65, 23)
        Me.lblPercentOne.TabIndex = 3
        Me.lblPercentOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPercentTwo
        '
        Me.lblPercentTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercentTwo.Location = New System.Drawing.Point(22, 52)
        Me.lblPercentTwo.Name = "lblPercentTwo"
        Me.lblPercentTwo.Size = New System.Drawing.Size(65, 23)
        Me.lblPercentTwo.TabIndex = 4
        Me.lblPercentTwo.Text = " "
        Me.lblPercentTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPercentThree
        '
        Me.lblPercentThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercentThree.Location = New System.Drawing.Point(22, 82)
        Me.lblPercentThree.Name = "lblPercentThree"
        Me.lblPercentThree.Size = New System.Drawing.Size(65, 23)
        Me.lblPercentThree.TabIndex = 5
        Me.lblPercentThree.Text = " "
        Me.lblPercentThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(109, 286)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(87, 27)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(16, 61)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(116, 23)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = " "
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalesFour
        '
        Me.txtSalesFour.Location = New System.Drawing.Point(66, 112)
        Me.txtSalesFour.Name = "txtSalesFour"
        Me.txtSalesFour.Size = New System.Drawing.Size(116, 23)
        Me.txtSalesFour.TabIndex = 3
        Me.txtSalesFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPercentFour
        '
        Me.lblPercentFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercentFour.Location = New System.Drawing.Point(22, 112)
        Me.lblPercentFour.Name = "lblPercentFour"
        Me.lblPercentFour.Size = New System.Drawing.Size(65, 23)
        Me.lblPercentFour.TabIndex = 9
        Me.lblPercentFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(214, 286)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 27)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(316, 286)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(473, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "North:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "South:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "East:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "West:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSalesOne)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSalesTwo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSalesThree)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSalesFour)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 156)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter individual profits:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPercentOne)
        Me.GroupBox2.Controls.Add(Me.lblPercentTwo)
        Me.GroupBox2.Controls.Add(Me.lblPercentThree)
        Me.GroupBox2.Controls.Add(Me.lblPercentFour)
        Me.GroupBox2.Location = New System.Drawing.Point(220, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(117, 156)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profit Percentage:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(343, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 151)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TOTAL PROFIT"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 325)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location's Profit Percentage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSalesOne As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesThree As System.Windows.Forms.TextBox
    Friend WithEvents lblPercentOne As System.Windows.Forms.Label
    Friend WithEvents lblPercentTwo As System.Windows.Forms.Label
    Friend WithEvents lblPercentThree As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtSalesFour As System.Windows.Forms.TextBox
    Friend WithEvents lblPercentFour As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class

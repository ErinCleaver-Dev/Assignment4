<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.bntAddNumber = New System.Windows.Forms.Button()
        Me.NumberList = New System.Windows.Forms.ListBox()
        Me.bntMean = New System.Windows.Forms.Button()
        Me.bntMedian = New System.Windows.Forms.Button()
        Me.bntMode = New System.Windows.Forms.Button()
        Me.bntClearList = New System.Windows.Forms.Button()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.lblMedian = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(66, 162)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 23)
        Me.txtNumber.TabIndex = 0
        '
        'bntAddNumber
        '
        Me.bntAddNumber.Location = New System.Drawing.Point(66, 206)
        Me.bntAddNumber.Name = "bntAddNumber"
        Me.bntAddNumber.Size = New System.Drawing.Size(100, 40)
        Me.bntAddNumber.TabIndex = 1
        Me.bntAddNumber.Text = "Add Number to List"
        Me.bntAddNumber.UseVisualStyleBackColor = True
        '
        'NumberList
        '
        Me.NumberList.FormattingEnabled = True
        Me.NumberList.ItemHeight = 15
        Me.NumberList.Location = New System.Drawing.Point(205, 28)
        Me.NumberList.Name = "NumberList"
        Me.NumberList.Size = New System.Drawing.Size(120, 394)
        Me.NumberList.TabIndex = 2
        '
        'bntMean
        '
        Me.bntMean.Location = New System.Drawing.Point(353, 79)
        Me.bntMean.Name = "bntMean"
        Me.bntMean.Size = New System.Drawing.Size(81, 43)
        Me.bntMean.TabIndex = 3
        Me.bntMean.Text = "Mean"
        Me.bntMean.UseVisualStyleBackColor = True
        '
        'bntMedian
        '
        Me.bntMedian.Location = New System.Drawing.Point(353, 142)
        Me.bntMedian.Name = "bntMedian"
        Me.bntMedian.Size = New System.Drawing.Size(81, 43)
        Me.bntMedian.TabIndex = 4
        Me.bntMedian.Text = "Median"
        Me.bntMedian.UseVisualStyleBackColor = True
        '
        'bntMode
        '
        Me.bntMode.Location = New System.Drawing.Point(353, 205)
        Me.bntMode.Name = "bntMode"
        Me.bntMode.Size = New System.Drawing.Size(81, 43)
        Me.bntMode.TabIndex = 5
        Me.bntMode.Text = "Mode"
        Me.bntMode.UseVisualStyleBackColor = True
        '
        'bntClearList
        '
        Me.bntClearList.Location = New System.Drawing.Point(353, 328)
        Me.bntClearList.Name = "bntClearList"
        Me.bntClearList.Size = New System.Drawing.Size(81, 43)
        Me.bntClearList.TabIndex = 6
        Me.bntClearList.Text = "Clear List"
        Me.bntClearList.UseVisualStyleBackColor = True
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(452, 93)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(37, 15)
        Me.lblMean.TabIndex = 7
        Me.lblMean.Text = "Mean"
        '
        'lblMedian
        '
        Me.lblMedian.AutoSize = True
        Me.lblMedian.Location = New System.Drawing.Point(452, 156)
        Me.lblMedian.Name = "lblMedian"
        Me.lblMedian.Size = New System.Drawing.Size(47, 15)
        Me.lblMedian.TabIndex = 8
        Me.lblMedian.Text = "Median"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(452, 219)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(38, 15)
        Me.lblMode.TabIndex = 9
        Me.lblMode.Text = "Mode"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 450)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.lblMedian)
        Me.Controls.Add(Me.lblMean)
        Me.Controls.Add(Me.bntClearList)
        Me.Controls.Add(Me.bntMode)
        Me.Controls.Add(Me.bntMedian)
        Me.Controls.Add(Me.bntMean)
        Me.Controls.Add(Me.NumberList)
        Me.Controls.Add(Me.bntAddNumber)
        Me.Controls.Add(Me.txtNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents bntAddNumber As Button
    Friend WithEvents NumberList As ListBox
    Friend WithEvents bntMean As Button
    Friend WithEvents bntMedian As Button
    Friend WithEvents bntMode As Button
    Friend WithEvents bntClearList As Button
    Friend WithEvents lblMean As Label
    Friend WithEvents lblMedian As Label
    Friend WithEvents lblMode As Label
End Class

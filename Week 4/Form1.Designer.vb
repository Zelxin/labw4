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
        Me.btn_addItem = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_unit = New System.Windows.Forms.Label()
        Me.txt_units = New System.Windows.Forms.TextBox()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.lbl_Price = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lb_Items = New System.Windows.Forms.ListBox()
        Me.btn_writeList = New System.Windows.Forms.Button()
        Me.lbl_subTotal = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_addItem
        '
        Me.btn_addItem.Location = New System.Drawing.Point(89, 272)
        Me.btn_addItem.Name = "btn_addItem"
        Me.btn_addItem.Size = New System.Drawing.Size(75, 23)
        Me.btn_addItem.TabIndex = 0
        Me.btn_addItem.Text = "Add Item"
        Me.btn_addItem.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(136, 148)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 1
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(91, 151)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(38, 13)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Text = "Name:"
        '
        'lbl_unit
        '
        Me.lbl_unit.AutoSize = True
        Me.lbl_unit.Location = New System.Drawing.Point(100, 177)
        Me.lbl_unit.Name = "lbl_unit"
        Me.lbl_unit.Size = New System.Drawing.Size(29, 13)
        Me.lbl_unit.TabIndex = 4
        Me.lbl_unit.Text = "Unit:"
        '
        'txt_units
        '
        Me.txt_units.Location = New System.Drawing.Point(136, 174)
        Me.txt_units.Name = "txt_units"
        Me.txt_units.Size = New System.Drawing.Size(100, 20)
        Me.txt_units.TabIndex = 3
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Location = New System.Drawing.Point(83, 203)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(46, 13)
        Me.lbl_amount.TabIndex = 6
        Me.lbl_amount.Text = "Amount:"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(136, 200)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(100, 20)
        Me.txt_amount.TabIndex = 5
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(193, 272)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 7
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Items On List"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(146, 127)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(90, 13)
        Me.label5.TabIndex = 10
        Me.label5.Text = "Enter Item Details"
        '
        'lbl_Price
        '
        Me.lbl_Price.AutoSize = True
        Me.lbl_Price.Location = New System.Drawing.Point(91, 229)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Price.TabIndex = 12
        Me.lbl_Price.Text = "Price:"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(136, 226)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 11
        '
        'lb_Items
        '
        Me.lb_Items.FormattingEnabled = True
        Me.lb_Items.Location = New System.Drawing.Point(325, 151)
        Me.lb_Items.Name = "lb_Items"
        Me.lb_Items.Size = New System.Drawing.Size(210, 147)
        Me.lb_Items.TabIndex = 14
        '
        'btn_writeList
        '
        Me.btn_writeList.Location = New System.Drawing.Point(89, 314)
        Me.btn_writeList.Name = "btn_writeList"
        Me.btn_writeList.Size = New System.Drawing.Size(70, 23)
        Me.btn_writeList.TabIndex = 15
        Me.btn_writeList.Text = "Write List"
        Me.btn_writeList.UseVisualStyleBackColor = True
        '
        'lbl_subTotal
        '
        Me.lbl_subTotal.AutoSize = True
        Me.lbl_subTotal.Location = New System.Drawing.Point(573, 361)
        Me.lbl_subTotal.Name = "lbl_subTotal"
        Me.lbl_subTotal.Size = New System.Drawing.Size(59, 13)
        Me.lbl_subTotal.TabIndex = 16
        Me.lbl_subTotal.Text = "Sub Total: "
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(573, 391)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(34, 13)
        Me.lbl_total.TabIndex = 17
        Me.lbl_total.Text = "Total:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_subTotal)
        Me.Controls.Add(Me.btn_writeList)
        Me.Controls.Add(Me.lb_Items)
        Me.Controls.Add(Me.lbl_Price)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.lbl_amount)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.lbl_unit)
        Me.Controls.Add(Me.txt_units)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_addItem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_addItem As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_unit As Label
    Friend WithEvents txt_units As TextBox
    Friend WithEvents lbl_amount As Label
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents lbl_Price As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lb_Items As ListBox
    Friend WithEvents btn_writeList As Button
    Friend WithEvents lbl_subTotal As Label
    Friend WithEvents lbl_total As Label
End Class

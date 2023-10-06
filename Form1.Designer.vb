<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        ListBox1 = New ListBox()
        btnAdd = New Button()
        Label2 = New Label()
        RadioButton1 = New RadioButton()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        RadioButton2 = New RadioButton()
        GroupBox2 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(271, 301)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(224, 125)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(176, 154)
        ListBox1.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(260, 92)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(236, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 3
        Label2.Text = "Enter a word:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(72, 19)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "To Upper"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(224, 51)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 23)
        TextBox1.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(153, 349)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(92, 65)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Case"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 40)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(72, 19)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "To Lower"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Location = New Point(321, 349)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(99, 65)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Colour"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(0, 40)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(48, 19)
        RadioButton4.TabIndex = 4
        RadioButton4.TabStop = True
        RadioButton4.Text = "Blue"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(1, 22)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(59, 19)
        RadioButton3.TabIndex = 4
        RadioButton3.TabStop = True
        RadioButton3.Text = "Purple"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(btnAdd)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
End Class

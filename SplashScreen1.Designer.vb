<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Me.lblGuide = New System.Windows.Forms.Label()
        Me.ptGuide = New System.Windows.Forms.PictureBox()
        Me.ptAeronist = New System.Windows.Forms.PictureBox()
        CType(Me.ptGuide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptAeronist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGuide
        '
        Me.lblGuide.AutoSize = True
        Me.lblGuide.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblGuide.Location = New System.Drawing.Point(793, 356)
        Me.lblGuide.Name = "lblGuide"
        Me.lblGuide.Size = New System.Drawing.Size(238, 84)
        Me.lblGuide.TabIndex = 1
        Me.lblGuide.Text = "Yer İstasyonu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Arayüzü"
        '
        'ptGuide
        '
        Me.ptGuide.Image = CType(resources.GetObject("ptGuide.Image"), System.Drawing.Image)
        Me.ptGuide.Location = New System.Drawing.Point(489, 247)
        Me.ptGuide.Name = "ptGuide"
        Me.ptGuide.Size = New System.Drawing.Size(298, 289)
        Me.ptGuide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptGuide.TabIndex = 5
        Me.ptGuide.TabStop = False
        '
        'ptAeronist
        '
        Me.ptAeronist.BackgroundImage = CType(resources.GetObject("ptAeronist.BackgroundImage"), System.Drawing.Image)
        Me.ptAeronist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ptAeronist.Location = New System.Drawing.Point(800, 309)
        Me.ptAeronist.Name = "ptAeronist"
        Me.ptAeronist.Size = New System.Drawing.Size(220, 54)
        Me.ptAeronist.TabIndex = 12
        Me.ptAeronist.TabStop = False
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1540, 845)
        Me.Controls.Add(Me.lblGuide)
        Me.Controls.Add(Me.ptAeronist)
        Me.Controls.Add(Me.ptGuide)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "SplashScreen1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aeronist Yer İstasyonu Arayüzü"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ptGuide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptAeronist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGuide As Label
    Friend WithEvents ptGuide As PictureBox
    Friend WithEvents ptAeronist As PictureBox
End Class

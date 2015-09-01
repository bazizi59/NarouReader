﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PlayImages = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StopImages = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox_url = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.LarrowImages = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_Forward = New System.Windows.Forms.Button()
        Me.RarrowList = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_reload = New System.Windows.Forms.Button()
        Me.Button_home = New System.Windows.Forms.Button()
        Me.Button_Setting = New System.Windows.Forms.Button()
        Me.SettingImages = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip_Read = New System.Windows.Forms.ToolTip(Me.components)
        Me.ReloadImages = New System.Windows.Forms.ImageList(Me.components)
        Me.HomeImages = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(857, 427)
        Me.WebBrowser1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.PlayImages
        Me.Button1.Location = New System.Drawing.Point(761, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 3
        Me.ToolTip_Read.SetToolTip(Me.Button1, "このページの小説を読み上げます")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlayImages
        '
        Me.PlayImages.ImageStream = CType(resources.GetObject("PlayImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.PlayImages.TransparentColor = System.Drawing.Color.Transparent
        Me.PlayImages.Images.SetKeyName(0, "play_s.png")
        Me.PlayImages.Images.SetKeyName(1, "play_s_gray.png")
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.ImageIndex = 0
        Me.Button2.ImageList = Me.StopImages
        Me.Button2.Location = New System.Drawing.Point(791, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 4
        Me.ToolTip_Read.SetToolTip(Me.Button2, "読み上げを停止します")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StopImages
        '
        Me.StopImages.ImageStream = CType(resources.GetObject("StopImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.StopImages.TransparentColor = System.Drawing.Color.Transparent
        Me.StopImages.Images.SetKeyName(0, "stop_s.png")
        Me.StopImages.Images.SetKeyName(1, "stop_s_gray.png")
        '
        'Timer1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(857, 109)
        Me.TextBox1.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 38)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.WebBrowser1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(857, 540)
        Me.SplitContainer1.SplitterDistance = 427
        Me.SplitContainer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(562, -37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 25)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TextBox_url
        '
        Me.TextBox_url.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_url.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_url.Location = New System.Drawing.Point(132, 7)
        Me.TextBox_url.Name = "TextBox_url"
        Me.TextBox_url.Size = New System.Drawing.Size(623, 23)
        Me.TextBox_url.TabIndex = 9
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(607, 584)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1
        Me.ProgressBar1.Maximum = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(238, 10)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 10
        '
        'Button_Back
        '
        Me.Button_Back.ImageIndex = 0
        Me.Button_Back.ImageList = Me.LarrowImages
        Me.Button_Back.Location = New System.Drawing.Point(12, 8)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(24, 24)
        Me.Button_Back.TabIndex = 11
        Me.ToolTip_Read.SetToolTip(Me.Button_Back, "クリックすると前に戻ります")
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'LarrowImages
        '
        Me.LarrowImages.ImageStream = CType(resources.GetObject("LarrowImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.LarrowImages.TransparentColor = System.Drawing.Color.Transparent
        Me.LarrowImages.Images.SetKeyName(0, "leftarrow_s.png")
        Me.LarrowImages.Images.SetKeyName(1, "leftarrow_s_gray.png")
        '
        'Button_Forward
        '
        Me.Button_Forward.ImageIndex = 0
        Me.Button_Forward.ImageList = Me.RarrowList
        Me.Button_Forward.Location = New System.Drawing.Point(42, 8)
        Me.Button_Forward.Name = "Button_Forward"
        Me.Button_Forward.Size = New System.Drawing.Size(24, 24)
        Me.Button_Forward.TabIndex = 12
        Me.ToolTip_Read.SetToolTip(Me.Button_Forward, "クリックすると次に進みます")
        Me.Button_Forward.UseVisualStyleBackColor = True
        '
        'RarrowList
        '
        Me.RarrowList.ImageStream = CType(resources.GetObject("RarrowList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.RarrowList.TransparentColor = System.Drawing.Color.Transparent
        Me.RarrowList.Images.SetKeyName(0, "righrarrow_s.png")
        Me.RarrowList.Images.SetKeyName(1, "righrarrow_s_gray.png")
        '
        'Button_reload
        '
        Me.Button_reload.ImageIndex = 0
        Me.Button_reload.ImageList = Me.ReloadImages
        Me.Button_reload.Location = New System.Drawing.Point(72, 8)
        Me.Button_reload.Name = "Button_reload"
        Me.Button_reload.Size = New System.Drawing.Size(24, 24)
        Me.Button_reload.TabIndex = 13
        Me.ToolTip_Read.SetToolTip(Me.Button_reload, "このページを再読み込みします")
        Me.Button_reload.UseVisualStyleBackColor = True
        '
        'Button_home
        '
        Me.Button_home.ImageIndex = 0
        Me.Button_home.ImageList = Me.HomeImages
        Me.Button_home.Location = New System.Drawing.Point(102, 8)
        Me.Button_home.Name = "Button_home"
        Me.Button_home.Size = New System.Drawing.Size(24, 24)
        Me.Button_home.TabIndex = 14
        Me.ToolTip_Read.SetToolTip(Me.Button_home, "小説家になろうホームページに移動します")
        Me.Button_home.UseVisualStyleBackColor = True
        '
        'Button_Setting
        '
        Me.Button_Setting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Setting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Setting.ImageIndex = 0
        Me.Button_Setting.ImageList = Me.SettingImages
        Me.Button_Setting.Location = New System.Drawing.Point(821, 6)
        Me.Button_Setting.Name = "Button_Setting"
        Me.Button_Setting.Size = New System.Drawing.Size(24, 24)
        Me.Button_Setting.TabIndex = 15
        Me.ToolTip_Read.SetToolTip(Me.Button_Setting, "設定ダイアログを表示します")
        Me.Button_Setting.UseVisualStyleBackColor = True
        '
        'SettingImages
        '
        Me.SettingImages.ImageStream = CType(resources.GetObject("SettingImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SettingImages.TransparentColor = System.Drawing.Color.Transparent
        Me.SettingImages.Images.SetKeyName(0, "setting.png")
        Me.SettingImages.Images.SetKeyName(1, "setting_gray.png")
        '
        'ReloadImages
        '
        Me.ReloadImages.ImageStream = CType(resources.GetObject("ReloadImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ReloadImages.TransparentColor = System.Drawing.Color.Transparent
        Me.ReloadImages.Images.SetKeyName(0, "reload_s.png")
        Me.ReloadImages.Images.SetKeyName(1, "stopLoad_s.png")
        '
        'HomeImages
        '
        Me.HomeImages.ImageStream = CType(resources.GetObject("HomeImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.HomeImages.TransparentColor = System.Drawing.Color.Transparent
        Me.HomeImages.Images.SetKeyName(0, "home_s.png")
        Me.HomeImages.Images.SetKeyName(1, "home_s_gray.png")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 599)
        Me.Controls.Add(Me.Button_Setting)
        Me.Controls.Add(Me.Button_home)
        Me.Controls.Add(Me.Button_reload)
        Me.Controls.Add(Me.Button_Forward)
        Me.Controls.Add(Me.Button_Back)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox_url)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Button2)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.なろうReader.My.MySettings.Default, "MyLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = Global.なろうReader.My.MySettings.Default.MyLocation
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "Form1"
        Me.Text = "なろうReader"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TextBox_url As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_Back As Button
    Friend WithEvents LarrowImages As ImageList
    Friend WithEvents Button_Forward As Button
    Friend WithEvents RarrowList As ImageList
    Friend WithEvents Button_reload As Button
    Friend WithEvents Button_home As Button
    Friend WithEvents Button_Setting As Button
    Friend WithEvents ToolTip_Read As ToolTip
    Friend WithEvents PlayImages As ImageList
    Friend WithEvents StopImages As ImageList
    Friend WithEvents SettingImages As ImageList
    Friend WithEvents ReloadImages As ImageList
    Friend WithEvents HomeImages As ImageList
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CheckBox_autoRead = New System.Windows.Forms.CheckBox()
        Me.CheckBox_autoNext = New System.Windows.Forms.CheckBox()
        Me.Button_Font = New System.Windows.Forms.Button()
        Me.FontLabel = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_bPath = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox_Maegaki = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Atogaki = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CheckBox_readTitle = New System.Windows.Forms.CheckBox()
        Me.CheckBox_readSubTitle = New System.Windows.Forms.CheckBox()
        Me.RadioButton_bouyomi = New System.Windows.Forms.RadioButton()
        Me.RadioButton_jtalk = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TrackBar_SAPI_Volume = New System.Windows.Forms.TrackBar()
        Me.TrackBar_SAPI_Speed = New System.Windows.Forms.TrackBar()
        Me.TextBox_SAPI_Volume = New System.Windows.Forms.TextBox()
        Me.TextBox_SAPI_Speed = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox_SAPI_Voice = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadioButton_SAPI = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_g = New System.Windows.Forms.TextBox()
        Me.TrackBar_g = New System.Windows.Forms.TrackBar()
        Me.Button_Talk = New System.Windows.Forms.Button()
        Me.TextBox_r = New System.Windows.Forms.TextBox()
        Me.TextBox_jf = New System.Windows.Forms.TextBox()
        Me.TextBox_jm = New System.Windows.Forms.TextBox()
        Me.TextBox_fm = New System.Windows.Forms.TextBox()
        Me.TextBox_a = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TrackBar_r = New System.Windows.Forms.TrackBar()
        Me.TrackBar_jf = New System.Windows.Forms.TrackBar()
        Me.TrackBar_jm = New System.Windows.Forms.TrackBar()
        Me.TrackBar_fm = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TrackBar_a = New System.Windows.Forms.TrackBar()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Separator = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_rubyNothing = New System.Windows.Forms.RadioButton()
        Me.RadioButton_rubyDelete = New System.Windows.Forms.RadioButton()
        Me.RadioButton_rubyConvert = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox_sample = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_Port = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar_SAPI_Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_SAPI_Speed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_g, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_jf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_jm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_fm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_a, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox_autoRead
        '
        Me.CheckBox_autoRead.AutoSize = True
        Me.CheckBox_autoRead.Location = New System.Drawing.Point(6, 34)
        Me.CheckBox_autoRead.Name = "CheckBox_autoRead"
        Me.CheckBox_autoRead.Size = New System.Drawing.Size(207, 16)
        Me.CheckBox_autoRead.TabIndex = 0
        Me.CheckBox_autoRead.Text = "起動すると自動的に小説を読み上げる"
        Me.CheckBox_autoRead.UseVisualStyleBackColor = True
        '
        'CheckBox_autoNext
        '
        Me.CheckBox_autoNext.AutoSize = True
        Me.CheckBox_autoNext.Location = New System.Drawing.Point(6, 56)
        Me.CheckBox_autoNext.Name = "CheckBox_autoNext"
        Me.CheckBox_autoNext.Size = New System.Drawing.Size(252, 16)
        Me.CheckBox_autoNext.TabIndex = 1
        Me.CheckBox_autoNext.Text = "連載作品の続きがある場合、自動的に移動する"
        Me.CheckBox_autoNext.UseVisualStyleBackColor = True
        '
        'Button_Font
        '
        Me.Button_Font.Location = New System.Drawing.Point(8, 21)
        Me.Button_Font.Name = "Button_Font"
        Me.Button_Font.Size = New System.Drawing.Size(92, 23)
        Me.Button_Font.TabIndex = 2
        Me.Button_Font.Text = "フォント設定…"
        Me.ToolTip1.SetToolTip(Me.Button_Font, "画面下部の「読み上げ用テキストエリア」に表示する文字の書体を設定します。")
        Me.Button_Font.UseVisualStyleBackColor = True
        '
        'FontLabel
        '
        Me.FontLabel.AutoSize = True
        Me.FontLabel.Location = New System.Drawing.Point(6, 54)
        Me.FontLabel.Name = "FontLabel"
        Me.FontLabel.Size = New System.Drawing.Size(38, 12)
        Me.FontLabel.TabIndex = 3
        Me.FontLabel.Text = "Label1"
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(582, 432)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Location = New System.Drawing.Point(691, 432)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancel.TabIndex = 5
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(299, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "探す..."
        Me.ToolTip1.SetToolTip(Me.Button1, "棒読みちゃんの実行ファイルがある場所を設定します。ファイル名はBouyuomiChan.exeです。")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "棒読みちゃんの実行ファイル(BouyomiChan.exe)"
        '
        'TextBox_bPath
        '
        Me.TextBox_bPath.Location = New System.Drawing.Point(40, 64)
        Me.TextBox_bPath.Name = "TextBox_bPath"
        Me.TextBox_bPath.Size = New System.Drawing.Size(252, 19)
        Me.TextBox_bPath.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.TextBox_bPath, "棒読みちゃんの実行ファイルがある場所を設定します。ファイル名はBouyuomiChan.exeです。")
        '
        'CheckBox_Maegaki
        '
        Me.CheckBox_Maegaki.AutoSize = True
        Me.CheckBox_Maegaki.Location = New System.Drawing.Point(6, 122)
        Me.CheckBox_Maegaki.Name = "CheckBox_Maegaki"
        Me.CheckBox_Maegaki.Size = New System.Drawing.Size(88, 16)
        Me.CheckBox_Maegaki.TabIndex = 10
        Me.CheckBox_Maegaki.Text = "前書きを読む"
        Me.ToolTip1.SetToolTip(Me.CheckBox_Maegaki, "前書きがある場合、読み上げます。")
        Me.CheckBox_Maegaki.UseVisualStyleBackColor = True
        '
        'CheckBox_Atogaki
        '
        Me.CheckBox_Atogaki.AutoSize = True
        Me.CheckBox_Atogaki.Location = New System.Drawing.Point(6, 144)
        Me.CheckBox_Atogaki.Name = "CheckBox_Atogaki"
        Me.CheckBox_Atogaki.Size = New System.Drawing.Size(88, 16)
        Me.CheckBox_Atogaki.TabIndex = 11
        Me.CheckBox_Atogaki.Text = "後書きを読む"
        Me.ToolTip1.SetToolTip(Me.CheckBox_Atogaki, "後書きがある場合、読み上げます。")
        Me.CheckBox_Atogaki.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(141, 24)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(152, 12)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "棒読みちゃん配布サイトへ移動"
        '
        'FontDialog1
        '
        Me.FontDialog1.AllowVerticalFonts = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CheckBox_readTitle
        '
        Me.CheckBox_readTitle.AutoSize = True
        Me.CheckBox_readTitle.Location = New System.Drawing.Point(6, 78)
        Me.CheckBox_readTitle.Name = "CheckBox_readTitle"
        Me.CheckBox_readTitle.Size = New System.Drawing.Size(90, 16)
        Me.CheckBox_readTitle.TabIndex = 12
        Me.CheckBox_readTitle.Text = "タイトルを読む"
        Me.CheckBox_readTitle.UseVisualStyleBackColor = True
        '
        'CheckBox_readSubTitle
        '
        Me.CheckBox_readSubTitle.AutoSize = True
        Me.CheckBox_readSubTitle.Location = New System.Drawing.Point(6, 100)
        Me.CheckBox_readSubTitle.Name = "CheckBox_readSubTitle"
        Me.CheckBox_readSubTitle.Size = New System.Drawing.Size(109, 16)
        Me.CheckBox_readSubTitle.TabIndex = 13
        Me.CheckBox_readSubTitle.Text = "サブタイトルを読む"
        Me.CheckBox_readSubTitle.UseVisualStyleBackColor = True
        '
        'RadioButton_bouyomi
        '
        Me.RadioButton_bouyomi.AutoSize = True
        Me.RadioButton_bouyomi.Location = New System.Drawing.Point(15, 22)
        Me.RadioButton_bouyomi.Name = "RadioButton_bouyomi"
        Me.RadioButton_bouyomi.Size = New System.Drawing.Size(85, 16)
        Me.RadioButton_bouyomi.TabIndex = 14
        Me.RadioButton_bouyomi.TabStop = True
        Me.RadioButton_bouyomi.Text = "棒読みちゃん"
        Me.RadioButton_bouyomi.UseVisualStyleBackColor = True
        '
        'RadioButton_jtalk
        '
        Me.RadioButton_jtalk.AutoSize = True
        Me.RadioButton_jtalk.Location = New System.Drawing.Point(15, 120)
        Me.RadioButton_jtalk.Name = "RadioButton_jtalk"
        Me.RadioButton_jtalk.Size = New System.Drawing.Size(82, 16)
        Me.RadioButton_jtalk.TabIndex = 15
        Me.RadioButton_jtalk.TabStop = True
        Me.RadioButton_jtalk.Text = "Open JTalk"
        Me.RadioButton_jtalk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_Port)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TrackBar_SAPI_Volume)
        Me.GroupBox1.Controls.Add(Me.TrackBar_SAPI_Speed)
        Me.GroupBox1.Controls.Add(Me.TextBox_SAPI_Volume)
        Me.GroupBox1.Controls.Add(Me.TextBox_SAPI_Speed)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ComboBox_SAPI_Voice)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.RadioButton_SAPI)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox_g)
        Me.GroupBox1.Controls.Add(Me.TrackBar_g)
        Me.GroupBox1.Controls.Add(Me.Button_Talk)
        Me.GroupBox1.Controls.Add(Me.TextBox_r)
        Me.GroupBox1.Controls.Add(Me.TextBox_jf)
        Me.GroupBox1.Controls.Add(Me.TextBox_jm)
        Me.GroupBox1.Controls.Add(Me.TextBox_fm)
        Me.GroupBox1.Controls.Add(Me.TextBox_a)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TrackBar_r)
        Me.GroupBox1.Controls.Add(Me.TrackBar_jf)
        Me.GroupBox1.Controls.Add(Me.TrackBar_jm)
        Me.GroupBox1.Controls.Add(Me.TrackBar_fm)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TrackBar_a)
        Me.GroupBox1.Controls.Add(Me.RadioButton_jtalk)
        Me.GroupBox1.Controls.Add(Me.RadioButton_bouyomi)
        Me.GroupBox1.Controls.Add(Me.TextBox_bPath)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 451)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "音声合成エンジン"
        '
        'TrackBar_SAPI_Volume
        '
        Me.TrackBar_SAPI_Volume.Location = New System.Drawing.Point(130, 429)
        Me.TrackBar_SAPI_Volume.Maximum = 100
        Me.TrackBar_SAPI_Volume.Name = "TrackBar_SAPI_Volume"
        Me.TrackBar_SAPI_Volume.Size = New System.Drawing.Size(206, 45)
        Me.TrackBar_SAPI_Volume.TabIndex = 45
        Me.TrackBar_SAPI_Volume.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar_SAPI_Volume.Value = 50
        '
        'TrackBar_SAPI_Speed
        '
        Me.TrackBar_SAPI_Speed.Location = New System.Drawing.Point(130, 389)
        Me.TrackBar_SAPI_Speed.Minimum = -10
        Me.TrackBar_SAPI_Speed.Name = "TrackBar_SAPI_Speed"
        Me.TrackBar_SAPI_Speed.Size = New System.Drawing.Size(206, 45)
        Me.TrackBar_SAPI_Speed.TabIndex = 44
        Me.TrackBar_SAPI_Speed.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'TextBox_SAPI_Volume
        '
        Me.TextBox_SAPI_Volume.Location = New System.Drawing.Point(73, 429)
        Me.TextBox_SAPI_Volume.Name = "TextBox_SAPI_Volume"
        Me.TextBox_SAPI_Volume.ReadOnly = True
        Me.TextBox_SAPI_Volume.Size = New System.Drawing.Size(51, 19)
        Me.TextBox_SAPI_Volume.TabIndex = 43
        '
        'TextBox_SAPI_Speed
        '
        Me.TextBox_SAPI_Speed.Location = New System.Drawing.Point(73, 396)
        Me.TextBox_SAPI_Speed.Name = "TextBox_SAPI_Speed"
        Me.TextBox_SAPI_Speed.ReadOnly = True
        Me.TextBox_SAPI_Speed.Size = New System.Drawing.Size(51, 19)
        Me.TextBox_SAPI_Speed.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 431)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "音量"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "速度"
        '
        'ComboBox_SAPI_Voice
        '
        Me.ComboBox_SAPI_Voice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_SAPI_Voice.FormattingEnabled = True
        Me.ComboBox_SAPI_Voice.Location = New System.Drawing.Point(73, 363)
        Me.ComboBox_SAPI_Voice.Name = "ComboBox_SAPI_Voice"
        Me.ComboBox_SAPI_Voice.Size = New System.Drawing.Size(223, 20)
        Me.ComboBox_SAPI_Voice.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "音声"
        '
        'RadioButton_SAPI
        '
        Me.RadioButton_SAPI.AutoSize = True
        Me.RadioButton_SAPI.Location = New System.Drawing.Point(15, 341)
        Me.RadioButton_SAPI.Name = "RadioButton_SAPI"
        Me.RadioButton_SAPI.Size = New System.Drawing.Size(149, 16)
        Me.RadioButton_SAPI.TabIndex = 37
        Me.RadioButton_SAPI.TabStop = True
        Me.RadioButton_SAPI.Text = "Windows Text to Speech"
        Me.RadioButton_SAPI.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "音量"
        '
        'TextBox_g
        '
        Me.TextBox_g.Location = New System.Drawing.Point(73, 312)
        Me.TextBox_g.Name = "TextBox_g"
        Me.TextBox_g.ReadOnly = True
        Me.TextBox_g.Size = New System.Drawing.Size(51, 19)
        Me.TextBox_g.TabIndex = 35
        '
        'TrackBar_g
        '
        Me.TrackBar_g.Location = New System.Drawing.Point(130, 312)
        Me.TrackBar_g.Maximum = 20
        Me.TrackBar_g.Minimum = -20
        Me.TrackBar_g.Name = "TrackBar_g"
        Me.TrackBar_g.Size = New System.Drawing.Size(212, 45)
        Me.TrackBar_g.TabIndex = 34
        Me.TrackBar_g.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar_g.Value = 1
        '
        'Button_Talk
        '
        Me.Button_Talk.Location = New System.Drawing.Point(342, 420)
        Me.Button_Talk.Name = "Button_Talk"
        Me.Button_Talk.Size = New System.Drawing.Size(75, 23)
        Me.Button_Talk.TabIndex = 33
        Me.Button_Talk.Text = "発音テスト"
        Me.Button_Talk.UseVisualStyleBackColor = True
        '
        'TextBox_r
        '
        Me.TextBox_r.Location = New System.Drawing.Point(73, 283)
        Me.TextBox_r.Name = "TextBox_r"
        Me.TextBox_r.ReadOnly = True
        Me.TextBox_r.Size = New System.Drawing.Size(51, 19)
        Me.TextBox_r.TabIndex = 32
        '
        'TextBox_jf
        '
        Me.TextBox_jf.Location = New System.Drawing.Point(73, 250)
        Me.TextBox_jf.Name = "TextBox_jf"
        Me.TextBox_jf.ReadOnly = True
        Me.TextBox_jf.Size = New System.Drawing.Size(51, 19)
        Me.TextBox_jf.TabIndex = 31
        '
        'TextBox_jm
        '
        Me.TextBox_jm.Location = New System.Drawing.Point(73, 221)
        Me.TextBox_jm.Name = "TextBox_jm"
        Me.TextBox_jm.ReadOnly = True
        Me.TextBox_jm.Size = New System.Drawing.Size(51, 19)
        Me.TextBox_jm.TabIndex = 30
        '
        'TextBox_fm
        '
        Me.TextBox_fm.Location = New System.Drawing.Point(73, 194)
        Me.TextBox_fm.Name = "TextBox_fm"
        Me.TextBox_fm.ReadOnly = True
        Me.TextBox_fm.Size = New System.Drawing.Size(51, 19)
        Me.TextBox_fm.TabIndex = 29
        '
        'TextBox_a
        '
        Me.TextBox_a.Location = New System.Drawing.Point(73, 167)
        Me.TextBox_a.Name = "TextBox_a"
        Me.TextBox_a.ReadOnly = True
        Me.TextBox_a.Size = New System.Drawing.Size(51, 19)
        Me.TextBox_a.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "声量"
        '
        'TrackBar_r
        '
        Me.TrackBar_r.Location = New System.Drawing.Point(130, 283)
        Me.TrackBar_r.Maximum = 40
        Me.TrackBar_r.Minimum = 1
        Me.TrackBar_r.Name = "TrackBar_r"
        Me.TrackBar_r.Size = New System.Drawing.Size(212, 45)
        Me.TrackBar_r.TabIndex = 26
        Me.TrackBar_r.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar_r.Value = 1
        '
        'TrackBar_jf
        '
        Me.TrackBar_jf.Location = New System.Drawing.Point(130, 250)
        Me.TrackBar_jf.Maximum = 100
        Me.TrackBar_jf.Name = "TrackBar_jf"
        Me.TrackBar_jf.Size = New System.Drawing.Size(211, 45)
        Me.TrackBar_jf.TabIndex = 25
        Me.TrackBar_jf.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'TrackBar_jm
        '
        Me.TrackBar_jm.Location = New System.Drawing.Point(129, 221)
        Me.TrackBar_jm.Maximum = 100
        Me.TrackBar_jm.Name = "TrackBar_jm"
        Me.TrackBar_jm.Size = New System.Drawing.Size(211, 45)
        Me.TrackBar_jm.TabIndex = 24
        Me.TrackBar_jm.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar_jm.Value = 1
        '
        'TrackBar_fm
        '
        Me.TrackBar_fm.Location = New System.Drawing.Point(129, 194)
        Me.TrackBar_fm.Maximum = 240
        Me.TrackBar_fm.Minimum = -240
        Me.TrackBar_fm.Name = "TrackBar_fm"
        Me.TrackBar_fm.Size = New System.Drawing.Size(212, 45)
        Me.TrackBar_fm.TabIndex = 23
        Me.TrackBar_fm.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "速度"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "抑揚"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 12)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "高さ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "声質"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "音声"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"mei_angry", "mei_bashful", "mei_happy", "mei_normal", "mei_sad", "nitech_jp_atr503_m001"})
        Me.ComboBox1.Location = New System.Drawing.Point(82, 141)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(210, 20)
        Me.ComboBox1.TabIndex = 17
        '
        'TrackBar_a
        '
        Me.TrackBar_a.Location = New System.Drawing.Point(130, 167)
        Me.TrackBar_a.Maximum = 100
        Me.TrackBar_a.Name = "TrackBar_a"
        Me.TrackBar_a.Size = New System.Drawing.Size(211, 45)
        Me.TrackBar_a.TabIndex = 16
        Me.TrackBar_a.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox_Separator)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox_autoRead)
        Me.GroupBox2.Controls.Add(Me.CheckBox_autoNext)
        Me.GroupBox2.Controls.Add(Me.CheckBox_readSubTitle)
        Me.GroupBox2.Controls.Add(Me.CheckBox_Maegaki)
        Me.GroupBox2.Controls.Add(Me.CheckBox_readTitle)
        Me.GroupBox2.Controls.Add(Me.CheckBox_Atogaki)
        Me.GroupBox2.Location = New System.Drawing.Point(441, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 231)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "読み上げ項目関連"
        '
        'ComboBox_Separator
        '
        Me.ComboBox_Separator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Separator.FormattingEnabled = True
        Me.ComboBox_Separator.Items.AddRange(New Object() {"改行のみ", "改行と句点（。）", "改行と句読点（。、）"})
        Me.ComboBox_Separator.Location = New System.Drawing.Point(100, 193)
        Me.ComboBox_Separator.Name = "ComboBox_Separator"
        Me.ComboBox_Separator.Size = New System.Drawing.Size(143, 20)
        Me.ComboBox_Separator.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 12)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "テキスト分割位置"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton_rubyNothing)
        Me.GroupBox4.Controls.Add(Me.RadioButton_rubyDelete)
        Me.GroupBox4.Controls.Add(Me.RadioButton_rubyConvert)
        Me.GroupBox4.Location = New System.Drawing.Point(141, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(169, 92)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ルビの扱い"
        '
        'RadioButton_rubyNothing
        '
        Me.RadioButton_rubyNothing.AutoSize = True
        Me.RadioButton_rubyNothing.Location = New System.Drawing.Point(16, 62)
        Me.RadioButton_rubyNothing.Name = "RadioButton_rubyNothing"
        Me.RadioButton_rubyNothing.Size = New System.Drawing.Size(69, 16)
        Me.RadioButton_rubyNothing.TabIndex = 2
        Me.RadioButton_rubyNothing.TabStop = True
        Me.RadioButton_rubyNothing.Text = "両方残す"
        Me.RadioButton_rubyNothing.UseVisualStyleBackColor = True
        '
        'RadioButton_rubyDelete
        '
        Me.RadioButton_rubyDelete.AutoSize = True
        Me.RadioButton_rubyDelete.Location = New System.Drawing.Point(16, 40)
        Me.RadioButton_rubyDelete.Name = "RadioButton_rubyDelete"
        Me.RadioButton_rubyDelete.Size = New System.Drawing.Size(74, 16)
        Me.RadioButton_rubyDelete.TabIndex = 1
        Me.RadioButton_rubyDelete.TabStop = True
        Me.RadioButton_rubyDelete.Text = "ルビを削除"
        Me.RadioButton_rubyDelete.UseVisualStyleBackColor = True
        '
        'RadioButton_rubyConvert
        '
        Me.RadioButton_rubyConvert.AutoSize = True
        Me.RadioButton_rubyConvert.Location = New System.Drawing.Point(16, 18)
        Me.RadioButton_rubyConvert.Name = "RadioButton_rubyConvert"
        Me.RadioButton_rubyConvert.Size = New System.Drawing.Size(126, 16)
        Me.RadioButton_rubyConvert.TabIndex = 0
        Me.RadioButton_rubyConvert.TabStop = True
        Me.RadioButton_rubyConvert.Text = "本文をルビで置き換え"
        Me.RadioButton_rubyConvert.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox_sample)
        Me.GroupBox3.Controls.Add(Me.Button_Font)
        Me.GroupBox3.Controls.Add(Me.FontLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(441, 259)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(331, 151)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "テキスト表示"
        '
        'TextBox_sample
        '
        Me.TextBox_sample.Location = New System.Drawing.Point(6, 73)
        Me.TextBox_sample.Multiline = True
        Me.TextBox_sample.Name = "TextBox_sample"
        Me.TextBox_sample.ReadOnly = True
        Me.TextBox_sample.Size = New System.Drawing.Size(319, 73)
        Me.TextBox_sample.TabIndex = 4
        Me.TextBox_sample.Text = "テキスト表示サンプルです。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "あいうえおABCDabc123456"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(38, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 12)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "ポート:"
        '
        'TextBox_Port
        '
        Me.TextBox_Port.Location = New System.Drawing.Point(82, 86)
        Me.TextBox_Port.Name = "TextBox_Port"
        Me.TextBox_Port.Size = New System.Drawing.Size(135, 19)
        Me.TextBox_Port.TabIndex = 47
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 482)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.OKButton)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.なろうReader.My.MySettings.Default, "SettingLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = Global.なろうReader.My.MySettings.Default.SettingLocation
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(427, 280)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "なろうReader 設定"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar_SAPI_Volume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_SAPI_Speed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_g, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_jf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_jm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_fm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_a, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckBox_autoRead As CheckBox
    Friend WithEvents CheckBox_autoNext As CheckBox
    Friend WithEvents Button_Font As Button
    Friend WithEvents FontLabel As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_bPath As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CheckBox_Maegaki As CheckBox
    Friend WithEvents CheckBox_Atogaki As CheckBox
    Friend WithEvents CheckBox_readTitle As CheckBox
    Friend WithEvents CheckBox_readSubTitle As CheckBox
    Friend WithEvents RadioButton_bouyomi As RadioButton
    Friend WithEvents RadioButton_jtalk As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TrackBar_r As TrackBar
    Friend WithEvents TrackBar_jf As TrackBar
    Friend WithEvents TrackBar_jm As TrackBar
    Friend WithEvents TrackBar_fm As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TrackBar_a As TrackBar
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TextBox_r As TextBox
    Friend WithEvents TextBox_jf As TextBox
    Friend WithEvents TextBox_jm As TextBox
    Friend WithEvents TextBox_fm As TextBox
    Friend WithEvents TextBox_a As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox_sample As TextBox
    Friend WithEvents Button_Talk As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_g As TextBox
    Friend WithEvents TrackBar_g As TrackBar
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton_rubyNothing As RadioButton
    Friend WithEvents RadioButton_rubyDelete As RadioButton
    Friend WithEvents RadioButton_rubyConvert As RadioButton
    Friend WithEvents TrackBar_SAPI_Volume As TrackBar
    Friend WithEvents TrackBar_SAPI_Speed As TrackBar
    Friend WithEvents TextBox_SAPI_Volume As TextBox
    Friend WithEvents TextBox_SAPI_Speed As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox_SAPI_Voice As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RadioButton_SAPI As RadioButton
    Friend WithEvents ComboBox_Separator As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox_Port As TextBox
    Friend WithEvents Label13 As Label
End Class

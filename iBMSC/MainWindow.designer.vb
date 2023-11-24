<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        cmnLanguage = New ContextMenuStrip(components)
        TBLangDef = New ToolStripMenuItem()
        TBLangRefresh = New ToolStripMenuItem()
        ToolStripSeparator9 = New ToolStripSeparator()
        TBLanguage = New ToolStripDropDownButton()
        mnLanguage = New ToolStripMenuItem()
        cmnTheme = New ContextMenuStrip(components)
        TBThemeDef = New ToolStripMenuItem()
        TBThemeSave = New ToolStripMenuItem()
        TBThemeRefresh = New ToolStripMenuItem()
        TBThemeLoadComptability = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        TBTheme = New ToolStripDropDownButton()
        mnTheme = New ToolStripMenuItem()
        POptionsScroll = New Panel()
        POptions = New Panel()
        POExpansion = New Panel()
        POExpansionInner = New Panel()
        TExpansion = New TextBox()
        POExpansionResizer = New Button()
        POExpansionSwitch = New CheckBox()
        POBeat = New Panel()
        POBeatInner = New TableLayoutPanel()
        POBeatExpander = New CheckBox()
        POBeatResizer = New Button()
        TableLayoutPanel7 = New TableLayoutPanel()
        nBeatD = New NumericUpDown()
        BBeatApplyV = New Button()
        nBeatN = New NumericUpDown()
        BBeatApply = New Button()
        Label7 = New Label()
        tBeatValue = New TextBox()
        LBeat = New ListBox()
        POBeatPart2 = New TableLayoutPanel()
        CBeatScale = New RadioButton()
        CBeatCut = New RadioButton()
        CBeatMeasure = New RadioButton()
        CBeatPreserve = New RadioButton()
        POBeatSwitch = New CheckBox()
        POBMP = New Panel()
        POBMPInner = New TableLayoutPanel()
        LBMP = New ListBox()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        BBMPUp = New Button()
        BBMPDown = New Button()
        BBMPBrowse = New Button()
        BBMPRemove = New Button()
        POBMPResizer = New Button()
        POBMPSwitch = New CheckBox()
        POWAV = New Panel()
        POWAVInner = New TableLayoutPanel()
        POWAVExpander = New CheckBox()
        LWAV = New ListBox()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        BWAVUp = New Button()
        BWAVDown = New Button()
        BWAVBrowse = New Button()
        BWAVRemove = New Button()
        POWAVResizer = New Button()
        POWAVPart2 = New TableLayoutPanel()
        CWAVMultiSelect = New CheckBox()
        CWAVChangeLabel = New CheckBox()
        CWAVEmptyfill = New CheckBox()
        POWAVSwitch = New CheckBox()
        POWaveForm = New Panel()
        POWaveFormInner = New Panel()
        POWaveFormPart2 = New TableLayoutPanel()
        TWSaturation = New NumericUpDown()
        PictureBox2 = New PictureBox()
        TWTransparency = New NumericUpDown()
        PictureBox3 = New PictureBox()
        TWPrecision = New NumericUpDown()
        PictureBox4 = New PictureBox()
        TWWidth = New NumericUpDown()
        PictureBox5 = New PictureBox()
        TWLeft = New NumericUpDown()
        PictureBox6 = New PictureBox()
        TWSaturation2 = New TrackBar()
        TWLeft2 = New TrackBar()
        TWTransparency2 = New TrackBar()
        TWWidth2 = New TrackBar()
        TWPrecision2 = New TrackBar()
        POWaveFormExpander = New CheckBox()
        POWaveFormPart1 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        BWLoad = New Button()
        BWClear = New Button()
        BWLock = New CheckBox()
        TWFileName = New TextBox()
        TableLayoutPanel6 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        TWPosition2 = New TrackBar()
        TWPosition = New NumericUpDown()
        POWaveFormSwitch = New CheckBox()
        POGrid = New Panel()
        POGridInner = New Panel()
        POGridPart2 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        cVSLockL = New CheckBox()
        cVSLock = New CheckBox()
        cVSLockR = New CheckBox()
        Label5 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label1 = New Label()
        CGB = New NumericUpDown()
        POGridExpander = New CheckBox()
        POGridPart1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        PictureBox9 = New PictureBox()
        CGHeight2 = New TrackBar()
        CGHeight = New NumericUpDown()
        PictureBox10 = New PictureBox()
        CGWidth2 = New TrackBar()
        CGWidth = New NumericUpDown()
        CGDisableVertical = New CheckBox()
        CGSnap = New CheckBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        PictureBox7 = New PictureBox()
        CGDivide = New NumericUpDown()
        CGSub = New NumericUpDown()
        BGSlash = New Button()
        POGridSwitch = New CheckBox()
        POHeader = New Panel()
        POHeaderInner = New Panel()
        POHeaderPart2 = New TableLayoutPanel()
        CHDifficulty = New ComboBox()
        Label13 = New Label()
        THExRank = New TextBox()
        CHLnObj = New ComboBox()
        Label23 = New Label()
        Label21 = New Label()
        THComment = New TextBox()
        Label24 = New Label()
        Label15 = New Label()
        BHStageFile = New Button()
        BHBanner = New Button()
        Label19 = New Label()
        BHBackBMP = New Button()
        Label17 = New Label()
        Label16 = New Label()
        Label12 = New Label()
        THBackBMP = New TextBox()
        Label11 = New Label()
        THBanner = New TextBox()
        THStageFile = New TextBox()
        THSubTitle = New TextBox()
        THSubArtist = New TextBox()
        Label26 = New Label()
        Label27 = New Label()
        THLandMine = New TextBox()
        BHLandMine = New Button()
        THMissBMP = New TextBox()
        BHMissBMP = New Button()
        Label28 = New Label()
        Label29 = New Label()
        THPreview = New TextBox()
        BHPreview = New Button()
        CHLnmode = New ComboBox()
        POHeaderExpander = New CheckBox()
        POHeaderPart1 = New TableLayoutPanel()
        Label3 = New Label()
        THPlayLevel = New TextBox()
        CHRank = New ComboBox()
        Label10 = New Label()
        CHPlayer = New ComboBox()
        Label4 = New Label()
        THGenre = New TextBox()
        THBPM = New NumericUpDown()
        Label2 = New Label()
        THArtist = New TextBox()
        THTitle = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        THTotal = New TextBox()
        Label20 = New Label()
        Label25 = New Label()
        POHeaderSwitch = New CheckBox()
        Timer1 = New Timer(components)
        Menu1 = New ContextMenuStrip(components)
        MInsert = New ToolStripMenuItem()
        MRemove = New ToolStripMenuItem()
        AutoSaveTimer = New Timer(components)
        mnMain = New MenuStrip()
        mnFile = New ToolStripMenuItem()
        mnNew = New ToolStripMenuItem()
        mnOpen = New ToolStripMenuItem()
        mnImportSM = New ToolStripMenuItem()
        mnImportIBMSC = New ToolStripMenuItem()
        ToolStripSeparator14 = New ToolStripSeparator()
        mnSave = New ToolStripMenuItem()
        mnSaveAs = New ToolStripMenuItem()
        mnExportIBMSC = New ToolStripMenuItem()
        mnExportBMSON = New ToolStripMenuItem()
        ToolStripSeparator15 = New ToolStripSeparator()
        mnOpenR0 = New ToolStripMenuItem()
        mnOpenR1 = New ToolStripMenuItem()
        mnOpenR2 = New ToolStripMenuItem()
        mnOpenR3 = New ToolStripMenuItem()
        mnOpenR4 = New ToolStripMenuItem()
        ToolStripSeparator16 = New ToolStripSeparator()
        mnQuit = New ToolStripMenuItem()
        mnEdit = New ToolStripMenuItem()
        mnUndo = New ToolStripMenuItem()
        mnRedo = New ToolStripMenuItem()
        ToolStripSeparator17 = New ToolStripSeparator()
        mnCut = New ToolStripMenuItem()
        mnCopy = New ToolStripMenuItem()
        mnPaste = New ToolStripMenuItem()
        mnDelete = New ToolStripMenuItem()
        mnSelectAll = New ToolStripMenuItem()
        mnGotoMeasure = New ToolStripMenuItem()
        ToolStripSeparator18 = New ToolStripSeparator()
        mnFind = New ToolStripMenuItem()
        mnStatistics = New ToolStripMenuItem()
        ToolStripSeparator19 = New ToolStripSeparator()
        mnTimeSelect = New ToolStripMenuItem()
        mnSelect = New ToolStripMenuItem()
        mnWrite = New ToolStripMenuItem()
        ToolStripSeparator23 = New ToolStripSeparator()
        mnMyO2 = New ToolStripMenuItem()
        mnSys = New ToolStripMenuItem()
        mnSMenu = New ToolStripMenuItem()
        mnSTB = New ToolStripMenuItem()
        mnSOP = New ToolStripMenuItem()
        mnSStatus = New ToolStripMenuItem()
        mnSLSplitter = New ToolStripMenuItem()
        mnSRSplitter = New ToolStripMenuItem()
        ToolStripSeparator21 = New ToolStripSeparator()
        CGShow = New ToolStripMenuItem()
        CGShowS = New ToolStripMenuItem()
        CGShowBG = New ToolStripMenuItem()
        CGShowM = New ToolStripMenuItem()
        CGShowMB = New ToolStripMenuItem()
        CGShowV = New ToolStripMenuItem()
        CGShowC = New ToolStripMenuItem()
        ToolStripSeparator22 = New ToolStripSeparator()
        CGBPM = New ToolStripMenuItem()
        CGSTOP = New ToolStripMenuItem()
        CGSCROLL = New ToolStripMenuItem()
        CGBLP = New ToolStripMenuItem()
        mnOptions = New ToolStripMenuItem()
        mnNTInput = New ToolStripMenuItem()
        mnErrorCheck = New ToolStripMenuItem()
        mnPreviewOnClick = New ToolStripMenuItem()
        mnShowFileName = New ToolStripMenuItem()
        mnChangePlaySide = New ToolStripMenuItem()
        ToolStripSeparator20 = New ToolStripSeparator()
        mnGOptions = New ToolStripMenuItem()
        mnVOptions = New ToolStripMenuItem()
        mnPOptions = New ToolStripMenuItem()
        mnConversion = New ToolStripMenuItem()
        cmnConversion = New ContextMenuStrip(components)
        POBLong = New ToolStripMenuItem()
        POBShort = New ToolStripMenuItem()
        POBLongShort = New ToolStripMenuItem()
        ToolStripSeparator10 = New ToolStripSeparator()
        POBHidden = New ToolStripMenuItem()
        POBVisible = New ToolStripMenuItem()
        POBHiddenVisible = New ToolStripMenuItem()
        ToolStripSeparator11 = New ToolStripSeparator()
        POBModify = New ToolStripMenuItem()
        POBMirror = New ToolStripMenuItem()
        POConvert = New ToolStripDropDownButton()
        TBMain = New ToolStrip()
        TBNew = New ToolStripButton()
        TBOpen = New ToolStripSplitButton()
        TBOpenR0 = New ToolStripMenuItem()
        TBOpenR1 = New ToolStripMenuItem()
        TBOpenR2 = New ToolStripMenuItem()
        TBOpenR3 = New ToolStripMenuItem()
        TBOpenR4 = New ToolStripMenuItem()
        ToolStripSeparator12 = New ToolStripSeparator()
        TBImportSM = New ToolStripMenuItem()
        TBImportIBMSC = New ToolStripMenuItem()
        TBSave = New ToolStripSplitButton()
        TBSaveAs = New ToolStripMenuItem()
        TBExportIBMSC = New ToolStripMenuItem()
        TBExportBMSON = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        TBCut = New ToolStripButton()
        TBCopy = New ToolStripButton()
        TBPaste = New ToolStripButton()
        TBFind = New ToolStripButton()
        ToolStripSeparator24 = New ToolStripSeparator()
        TBStatistics = New ToolStripButton()
        TBMyO2 = New ToolStripButton()
        ToolStripSeparator4 = New ToolStripSeparator()
        TBErrorCheck = New ToolStripButton()
        TBPreviewOnClick = New ToolStripButton()
        TBShowFileName = New ToolStripButton()
        TBChangePlaySide = New ToolStripButton()
        ToolStripSeparator8 = New ToolStripSeparator()
        TBNTInput = New ToolStripButton()
        TBWavIncrease = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        TBUndo = New ToolStripButton()
        TBRedo = New ToolStripButton()
        ToolStripSeparator5 = New ToolStripSeparator()
        TBTimeSelect = New ToolStripButton()
        TBSelect = New ToolStripButton()
        TBWrite = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        TBPlayB = New ToolStripButton()
        TBPlay = New ToolStripButton()
        TBStop = New ToolStripButton()
        TBPOptions = New ToolStripButton()
        ToolStripSeparator7 = New ToolStripSeparator()
        TBVOptions = New ToolStripButton()
        TBGOptions = New ToolStripButton()
        POBStorm = New ToolStripButton()
        pStatus = New Panel()
        FStatus2 = New StatusStrip()
        FSSS = New ToolStripButton()
        FSSL = New ToolStripButton()
        FSSH = New ToolStripButton()
        BVCReverse = New ToolStripButton()
        LblMultiply = New ToolStripStatusLabel()
        TVCM = New ToolStripTextBox()
        LblDivide = New ToolStripStatusLabel()
        TVCD = New ToolStripTextBox()
        BVCApply = New ToolStripButton()
        TVCBPM = New ToolStripTextBox()
        BVCCalculate = New ToolStripButton()
        BConvertStop = New ToolStripButton()
        FStatus = New StatusStrip()
        FSC = New ToolStripStatusLabel()
        FSW = New ToolStripStatusLabel()
        FSM = New ToolStripStatusLabel()
        FSP1 = New ToolStripStatusLabel()
        FSP3 = New ToolStripStatusLabel()
        FSP2 = New ToolStripStatusLabel()
        FSP4 = New ToolStripStatusLabel()
        TimeStatusLabel = New ToolStripStatusLabel()
        FST = New ToolStripStatusLabel()
        FSH = New ToolStripStatusLabel()
        FSL = New ToolStripStatusLabel()
        FSE = New ToolStripStatusLabel()
        TimerMiddle = New Timer(components)
        ToolStripContainer1 = New ToolStripContainer()
        PMain = New Panel()
        PMainIn = New Panel()
        MainPanelScroll = New VScrollBar()
        HS = New HScrollBar()
        SpR = New Button()
        SpL = New Button()
        PMainR = New Panel()
        PMainInR = New Panel()
        RightPanelScroll = New VScrollBar()
        HSR = New HScrollBar()
        PMainL = New Panel()
        PMainInL = New Panel()
        LeftPanelScroll = New VScrollBar()
        HSL = New HScrollBar()
        POptionsResizer = New Button()
        ToolTipUniversal = New ToolTip(components)
        mnPlayB = New ToolStripMenuItem()
        mnPlay = New ToolStripMenuItem()
        mnStop = New ToolStripMenuItem()
        mnPreview = New ToolStripMenuItem()
        cmnLanguage.SuspendLayout()
        cmnTheme.SuspendLayout()
        POptionsScroll.SuspendLayout()
        POptions.SuspendLayout()
        POExpansion.SuspendLayout()
        POExpansionInner.SuspendLayout()
        POBeat.SuspendLayout()
        POBeatInner.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        CType(nBeatD, ComponentModel.ISupportInitialize).BeginInit()
        CType(nBeatN, ComponentModel.ISupportInitialize).BeginInit()
        POBeatPart2.SuspendLayout()
        POBMP.SuspendLayout()
        POBMPInner.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        POWAV.SuspendLayout()
        POWAVInner.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        POWAVPart2.SuspendLayout()
        POWaveForm.SuspendLayout()
        POWaveFormInner.SuspendLayout()
        POWaveFormPart2.SuspendLayout()
        CType(TWSaturation, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWTransparency, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWPrecision, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWWidth, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWLeft, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWSaturation2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWLeft2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWTransparency2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWWidth2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWPrecision2, ComponentModel.ISupportInitialize).BeginInit()
        POWaveFormPart1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWPosition2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TWPosition, ComponentModel.ISupportInitialize).BeginInit()
        POGrid.SuspendLayout()
        POGridInner.SuspendLayout()
        POGridPart2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(CGB, ComponentModel.ISupportInitialize).BeginInit()
        POGridPart1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(CGHeight2, ComponentModel.ISupportInitialize).BeginInit()
        CType(CGHeight, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(CGWidth2, ComponentModel.ISupportInitialize).BeginInit()
        CType(CGWidth, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(CGDivide, ComponentModel.ISupportInitialize).BeginInit()
        CType(CGSub, ComponentModel.ISupportInitialize).BeginInit()
        POHeader.SuspendLayout()
        POHeaderInner.SuspendLayout()
        POHeaderPart2.SuspendLayout()
        POHeaderPart1.SuspendLayout()
        CType(THBPM, ComponentModel.ISupportInitialize).BeginInit()
        Menu1.SuspendLayout()
        mnMain.SuspendLayout()
        cmnConversion.SuspendLayout()
        TBMain.SuspendLayout()
        pStatus.SuspendLayout()
        FStatus2.SuspendLayout()
        FStatus.SuspendLayout()
        ToolStripContainer1.ContentPanel.SuspendLayout()
        ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        ToolStripContainer1.SuspendLayout()
        PMain.SuspendLayout()
        PMainR.SuspendLayout()
        PMainL.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmnLanguage
        ' 
        cmnLanguage.Items.AddRange(New ToolStripItem() {TBLangDef, TBLangRefresh, ToolStripSeparator9})
        cmnLanguage.Name = "cmnLanguage"
        cmnLanguage.OwnerItem = mnLanguage
        cmnLanguage.Size = New Size(126, 54)
        ' 
        ' TBLangDef
        ' 
        TBLangDef.Name = "TBLangDef"
        TBLangDef.Size = New Size(125, 22)
        TBLangDef.Text = "(Default)"
        ' 
        ' TBLangRefresh
        ' 
        TBLangRefresh.Image = CType(resources.GetObject("TBLangRefresh.Image"), Image)
        TBLangRefresh.Name = "TBLangRefresh"
        TBLangRefresh.Size = New Size(125, 22)
        TBLangRefresh.Text = "Refresh"
        ' 
        ' ToolStripSeparator9
        ' 
        ToolStripSeparator9.Name = "ToolStripSeparator9"
        ToolStripSeparator9.Size = New Size(122, 6)
        ' 
        ' TBLanguage
        ' 
        TBLanguage.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBLanguage.DropDown = cmnLanguage
        TBLanguage.Image = CType(resources.GetObject("TBLanguage.Image"), Image)
        TBLanguage.ImageTransparentColor = Color.Magenta
        TBLanguage.Name = "TBLanguage"
        TBLanguage.Size = New Size(29, 22)
        TBLanguage.Text = "Language"
        ' 
        ' mnLanguage
        ' 
        mnLanguage.DropDown = cmnLanguage
        mnLanguage.Image = CType(resources.GetObject("mnLanguage.Image"), Image)
        mnLanguage.Name = "mnLanguage"
        mnLanguage.Size = New Size(247, 22)
        mnLanguage.Text = "&Language"
        ' 
        ' cmnTheme
        ' 
        cmnTheme.Items.AddRange(New ToolStripItem() {TBThemeDef, TBThemeSave, TBThemeRefresh, TBThemeLoadComptability, ToolStripSeparator6})
        cmnTheme.Name = "cmnLanguage"
        cmnTheme.OwnerItem = mnTheme
        cmnTheme.Size = New Size(266, 98)
        ' 
        ' TBThemeDef
        ' 
        TBThemeDef.Name = "TBThemeDef"
        TBThemeDef.Size = New Size(265, 22)
        TBThemeDef.Text = "(Default)"
        ' 
        ' TBThemeSave
        ' 
        TBThemeSave.Image = CType(resources.GetObject("TBThemeSave.Image"), Image)
        TBThemeSave.Name = "TBThemeSave"
        TBThemeSave.Size = New Size(265, 22)
        TBThemeSave.Text = "Save Theme"
        ' 
        ' TBThemeRefresh
        ' 
        TBThemeRefresh.Image = CType(resources.GetObject("TBThemeRefresh.Image"), Image)
        TBThemeRefresh.Name = "TBThemeRefresh"
        TBThemeRefresh.Size = New Size(265, 22)
        TBThemeRefresh.Text = "Refresh"
        ' 
        ' TBThemeLoadComptability
        ' 
        TBThemeLoadComptability.Name = "TBThemeLoadComptability"
        TBThemeLoadComptability.Size = New Size(265, 22)
        TBThemeLoadComptability.Text = "Load Theme File from iBMSC 2.x"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(262, 6)
        ' 
        ' TBTheme
        ' 
        TBTheme.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBTheme.DropDown = cmnTheme
        TBTheme.Image = CType(resources.GetObject("TBTheme.Image"), Image)
        TBTheme.ImageTransparentColor = Color.Magenta
        TBTheme.Name = "TBTheme"
        TBTheme.Size = New Size(29, 22)
        TBTheme.Text = "Theme"
        ' 
        ' mnTheme
        ' 
        mnTheme.DropDown = cmnTheme
        mnTheme.Image = CType(resources.GetObject("mnTheme.Image"), Image)
        mnTheme.Name = "mnTheme"
        mnTheme.Size = New Size(247, 22)
        mnTheme.Text = "&Theme"
        ' 
        ' POptionsScroll
        ' 
        POptionsScroll.AutoScroll = True
        POptionsScroll.Controls.Add(POptions)
        POptionsScroll.Dock = DockStyle.Right
        POptionsScroll.Location = New Point(882, 0)
        POptionsScroll.Name = "POptionsScroll"
        POptionsScroll.Size = New Size(200, 730)
        POptionsScroll.TabIndex = 28
        ' 
        ' POptions
        ' 
        POptions.AutoSize = True
        POptions.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POptions.Controls.Add(POExpansion)
        POptions.Controls.Add(POBeat)
        POptions.Controls.Add(POBMP)
        POptions.Controls.Add(POWAV)
        POptions.Controls.Add(POWaveForm)
        POptions.Controls.Add(POGrid)
        POptions.Controls.Add(POHeader)
        POptions.Dock = DockStyle.Top
        POptions.Location = New Point(0, 0)
        POptions.Name = "POptions"
        POptions.Size = New Size(183, 2081)
        POptions.TabIndex = 29
        ' 
        ' POExpansion
        ' 
        POExpansion.AutoSize = True
        POExpansion.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POExpansion.Controls.Add(POExpansionInner)
        POExpansion.Controls.Add(POExpansionSwitch)
        POExpansion.Dock = DockStyle.Top
        POExpansion.Location = New Point(0, 1811)
        POExpansion.Name = "POExpansion"
        POExpansion.Size = New Size(183, 270)
        POExpansion.TabIndex = 6
        ' 
        ' POExpansionInner
        ' 
        POExpansionInner.Controls.Add(TExpansion)
        POExpansionInner.Controls.Add(POExpansionResizer)
        POExpansionInner.Dock = DockStyle.Top
        POExpansionInner.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        POExpansionInner.Location = New Point(0, 20)
        POExpansionInner.Name = "POExpansionInner"
        POExpansionInner.Size = New Size(183, 250)
        POExpansionInner.TabIndex = 7
        POExpansionInner.Visible = False
        ' 
        ' TExpansion
        ' 
        TExpansion.BorderStyle = BorderStyle.FixedSingle
        TExpansion.Dock = DockStyle.Fill
        TExpansion.HideSelection = False
        TExpansion.Location = New Point(0, 0)
        TExpansion.Multiline = True
        TExpansion.Name = "TExpansion"
        TExpansion.ScrollBars = ScrollBars.Vertical
        TExpansion.Size = New Size(183, 245)
        TExpansion.TabIndex = 0
        TExpansion.WordWrap = False
        ' 
        ' POExpansionResizer
        ' 
        POExpansionResizer.Dock = DockStyle.Bottom
        POExpansionResizer.FlatAppearance.BorderSize = 0
        POExpansionResizer.FlatStyle = FlatStyle.Flat
        POExpansionResizer.Location = New Point(0, 245)
        POExpansionResizer.Margin = New Padding(0)
        POExpansionResizer.Name = "POExpansionResizer"
        POExpansionResizer.Size = New Size(183, 5)
        POExpansionResizer.TabIndex = 65
        POExpansionResizer.TabStop = False
        POExpansionResizer.UseVisualStyleBackColor = True
        ' 
        ' POExpansionSwitch
        ' 
        POExpansionSwitch.Appearance = Appearance.Button
        POExpansionSwitch.BackColor = SystemColors.Control
        POExpansionSwitch.Cursor = Cursors.Hand
        POExpansionSwitch.Dock = DockStyle.Top
        POExpansionSwitch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        POExpansionSwitch.Location = New Point(0, 0)
        POExpansionSwitch.Name = "POExpansionSwitch"
        POExpansionSwitch.Size = New Size(183, 20)
        POExpansionSwitch.TabIndex = 6
        POExpansionSwitch.TabStop = False
        POExpansionSwitch.Text = "Expansion Code"
        POExpansionSwitch.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POExpansionSwitch.UseCompatibleTextRendering = True
        POExpansionSwitch.UseVisualStyleBackColor = False
        ' 
        ' POBeat
        ' 
        POBeat.AutoSize = True
        POBeat.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POBeat.Controls.Add(POBeatInner)
        POBeat.Controls.Add(POBeatSwitch)
        POBeat.Dock = DockStyle.Top
        POBeat.Location = New Point(0, 1541)
        POBeat.Name = "POBeat"
        POBeat.Size = New Size(183, 270)
        POBeat.TabIndex = 5
        ' 
        ' POBeatInner
        ' 
        POBeatInner.ColumnCount = 1
        POBeatInner.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        POBeatInner.Controls.Add(POBeatExpander, 0, 1)
        POBeatInner.Controls.Add(POBeatResizer, 0, 4)
        POBeatInner.Controls.Add(TableLayoutPanel7, 0, 0)
        POBeatInner.Controls.Add(LBeat, 0, 3)
        POBeatInner.Controls.Add(POBeatPart2, 0, 2)
        POBeatInner.Dock = DockStyle.Top
        POBeatInner.Location = New Point(0, 20)
        POBeatInner.Name = "POBeatInner"
        POBeatInner.RowCount = 5
        POBeatInner.RowStyles.Add(New RowStyle())
        POBeatInner.RowStyles.Add(New RowStyle())
        POBeatInner.RowStyles.Add(New RowStyle())
        POBeatInner.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        POBeatInner.RowStyles.Add(New RowStyle())
        POBeatInner.Size = New Size(183, 250)
        POBeatInner.TabIndex = 6
        POBeatInner.Visible = False
        ' 
        ' POBeatExpander
        ' 
        POBeatExpander.Appearance = Appearance.Button
        POBeatExpander.AutoSize = True
        POBeatExpander.Cursor = Cursors.Hand
        POBeatExpander.Dock = DockStyle.Top
        POBeatExpander.FlatAppearance.BorderSize = 0
        POBeatExpander.FlatStyle = FlatStyle.Popup
        POBeatExpander.Location = New Point(0, 54)
        POBeatExpander.Margin = New Padding(0)
        POBeatExpander.Name = "POBeatExpander"
        POBeatExpander.Size = New Size(183, 25)
        POBeatExpander.TabIndex = 65
        POBeatExpander.TabStop = False
        POBeatExpander.Text = "Expand..."
        POBeatExpander.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POBeatExpander.UseVisualStyleBackColor = False
        ' 
        ' POBeatResizer
        ' 
        POBeatInner.SetColumnSpan(POBeatResizer, 2)
        POBeatResizer.Dock = DockStyle.Top
        POBeatResizer.FlatAppearance.BorderSize = 0
        POBeatResizer.FlatStyle = FlatStyle.Flat
        POBeatResizer.Location = New Point(0, 245)
        POBeatResizer.Margin = New Padding(0)
        POBeatResizer.Name = "POBeatResizer"
        POBeatResizer.Size = New Size(183, 5)
        POBeatResizer.TabIndex = 64
        POBeatResizer.TabStop = False
        POBeatResizer.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.AutoSize = True
        TableLayoutPanel7.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel7.ColumnCount = 4
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel7.Controls.Add(nBeatD, 2, 0)
        TableLayoutPanel7.Controls.Add(BBeatApplyV, 3, 1)
        TableLayoutPanel7.Controls.Add(nBeatN, 0, 0)
        TableLayoutPanel7.Controls.Add(BBeatApply, 3, 0)
        TableLayoutPanel7.Controls.Add(Label7, 1, 0)
        TableLayoutPanel7.Controls.Add(tBeatValue, 0, 1)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(0, 0)
        TableLayoutPanel7.Margin = New Padding(0)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle())
        TableLayoutPanel7.RowStyles.Add(New RowStyle())
        TableLayoutPanel7.Size = New Size(183, 54)
        TableLayoutPanel7.TabIndex = 63
        ' 
        ' nBeatD
        ' 
        nBeatD.Dock = DockStyle.Fill
        nBeatD.Location = New Point(66, 3)
        nBeatD.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nBeatD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nBeatD.Name = "nBeatD"
        nBeatD.Size = New Size(45, 23)
        nBeatD.TabIndex = 37
        nBeatD.Value = New Decimal(New Integer() {4, 0, 0, 0})
        ' 
        ' BBeatApplyV
        ' 
        BBeatApplyV.AutoSize = True
        BBeatApplyV.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BBeatApplyV.Dock = DockStyle.Fill
        BBeatApplyV.Location = New Point(114, 29)
        BBeatApplyV.Margin = New Padding(0, 0, 3, 0)
        BBeatApplyV.Name = "BBeatApplyV"
        BBeatApplyV.Size = New Size(66, 25)
        BBeatApplyV.TabIndex = 35
        BBeatApplyV.Text = "Apply"
        BBeatApplyV.UseVisualStyleBackColor = True
        ' 
        ' nBeatN
        ' 
        nBeatN.Dock = DockStyle.Fill
        nBeatN.Location = New Point(3, 3)
        nBeatN.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nBeatN.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nBeatN.Name = "nBeatN"
        nBeatN.Size = New Size(45, 23)
        nBeatN.TabIndex = 27
        nBeatN.Value = New Decimal(New Integer() {4, 0, 0, 0})
        ' 
        ' BBeatApply
        ' 
        BBeatApply.AutoSize = True
        BBeatApply.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BBeatApply.Dock = DockStyle.Fill
        BBeatApply.Location = New Point(114, 2)
        BBeatApply.Margin = New Padding(0, 2, 3, 2)
        BBeatApply.Name = "BBeatApply"
        BBeatApply.Size = New Size(66, 25)
        BBeatApply.TabIndex = 30
        BBeatApply.Text = "Apply"
        BBeatApply.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Location = New Point(51, 7)
        Label7.Margin = New Padding(0)
        Label7.Name = "Label7"
        Label7.Size = New Size(12, 15)
        Label7.TabIndex = 31
        Label7.Text = "/"
        Label7.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' tBeatValue
        ' 
        TableLayoutPanel7.SetColumnSpan(tBeatValue, 3)
        tBeatValue.Dock = DockStyle.Fill
        tBeatValue.Location = New Point(3, 30)
        tBeatValue.Margin = New Padding(3, 1, 3, 0)
        tBeatValue.Name = "tBeatValue"
        tBeatValue.Size = New Size(108, 23)
        tBeatValue.TabIndex = 36
        tBeatValue.Text = "1"
        ' 
        ' LBeat
        ' 
        LBeat.Dock = DockStyle.Fill
        LBeat.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBeat.IntegralHeight = False
        LBeat.ItemHeight = 14
        LBeat.Items.AddRange(New Object() {"000: 15.984375 (1023/64)"})
        LBeat.Location = New Point(3, 155)
        LBeat.Margin = New Padding(3, 0, 3, 0)
        LBeat.Name = "LBeat"
        LBeat.SelectionMode = SelectionMode.MultiExtended
        LBeat.Size = New Size(177, 90)
        LBeat.TabIndex = 26
        ' 
        ' POBeatPart2
        ' 
        POBeatPart2.AutoSize = True
        POBeatPart2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POBeatPart2.ColumnCount = 1
        POBeatPart2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        POBeatPart2.Controls.Add(CBeatScale, 0, 3)
        POBeatPart2.Controls.Add(CBeatCut, 0, 2)
        POBeatPart2.Controls.Add(CBeatMeasure, 0, 1)
        POBeatPart2.Controls.Add(CBeatPreserve, 0, 0)
        POBeatPart2.Dock = DockStyle.Fill
        POBeatPart2.Location = New Point(0, 79)
        POBeatPart2.Margin = New Padding(0)
        POBeatPart2.Name = "POBeatPart2"
        POBeatPart2.RowCount = 4
        POBeatPart2.RowStyles.Add(New RowStyle())
        POBeatPart2.RowStyles.Add(New RowStyle())
        POBeatPart2.RowStyles.Add(New RowStyle())
        POBeatPart2.RowStyles.Add(New RowStyle())
        POBeatPart2.Size = New Size(183, 76)
        POBeatPart2.TabIndex = 66
        POBeatPart2.Visible = False
        ' 
        ' CBeatScale
        ' 
        CBeatScale.AutoSize = True
        CBeatScale.Location = New Point(3, 57)
        CBeatScale.Margin = New Padding(3, 0, 3, 0)
        CBeatScale.Name = "CBeatScale"
        CBeatScale.Size = New Size(151, 19)
        CBeatScale.TabIndex = 3
        CBeatScale.Text = "Scale to measure length"
        CBeatScale.UseVisualStyleBackColor = True
        ' 
        ' CBeatCut
        ' 
        CBeatCut.AutoEllipsis = True
        CBeatCut.Dock = DockStyle.Fill
        CBeatCut.Location = New Point(3, 38)
        CBeatCut.Margin = New Padding(3, 0, 3, 0)
        CBeatCut.Name = "CBeatCut"
        CBeatCut.Size = New Size(177, 19)
        CBeatCut.TabIndex = 2
        CBeatCut.Text = "Keep measure position and cut overflow"
        CBeatCut.UseVisualStyleBackColor = True
        ' 
        ' CBeatMeasure
        ' 
        CBeatMeasure.AutoSize = True
        CBeatMeasure.Location = New Point(3, 19)
        CBeatMeasure.Margin = New Padding(3, 0, 3, 0)
        CBeatMeasure.Name = "CBeatMeasure"
        CBeatMeasure.Size = New Size(145, 19)
        CBeatMeasure.TabIndex = 1
        CBeatMeasure.Text = "Keep measure position"
        CBeatMeasure.UseVisualStyleBackColor = True
        ' 
        ' CBeatPreserve
        ' 
        CBeatPreserve.AutoSize = True
        CBeatPreserve.Checked = True
        CBeatPreserve.Location = New Point(3, 0)
        CBeatPreserve.Margin = New Padding(3, 0, 3, 0)
        CBeatPreserve.Name = "CBeatPreserve"
        CBeatPreserve.Size = New Size(145, 19)
        CBeatPreserve.TabIndex = 0
        CBeatPreserve.TabStop = True
        CBeatPreserve.Text = "Keep absolute position"
        CBeatPreserve.UseVisualStyleBackColor = True
        ' 
        ' POBeatSwitch
        ' 
        POBeatSwitch.Appearance = Appearance.Button
        POBeatSwitch.BackColor = SystemColors.Control
        POBeatSwitch.Cursor = Cursors.Hand
        POBeatSwitch.Dock = DockStyle.Top
        POBeatSwitch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        POBeatSwitch.Location = New Point(0, 0)
        POBeatSwitch.Name = "POBeatSwitch"
        POBeatSwitch.Size = New Size(183, 20)
        POBeatSwitch.TabIndex = 5
        POBeatSwitch.TabStop = False
        POBeatSwitch.Text = "Beat"
        POBeatSwitch.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POBeatSwitch.UseCompatibleTextRendering = True
        POBeatSwitch.UseVisualStyleBackColor = False
        ' 
        ' POBMP
        ' 
        POBMP.AllowDrop = True
        POBMP.AutoSize = True
        POBMP.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POBMP.Controls.Add(POBMPInner)
        POBMP.Controls.Add(POBMPSwitch)
        POBMP.Dock = DockStyle.Top
        POBMP.Location = New Point(0, 1271)
        POBMP.Name = "POBMP"
        POBMP.Size = New Size(183, 270)
        POBMP.TabIndex = 4
        ' 
        ' POBMPInner
        ' 
        POBMPInner.ColumnCount = 1
        POBMPInner.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        POBMPInner.Controls.Add(LBMP, 0, 1)
        POBMPInner.Controls.Add(FlowLayoutPanel4, 0, 0)
        POBMPInner.Controls.Add(POBMPResizer, 0, 2)
        POBMPInner.Dock = DockStyle.Top
        POBMPInner.Location = New Point(0, 20)
        POBMPInner.Name = "POBMPInner"
        POBMPInner.RowCount = 3
        POBMPInner.RowStyles.Add(New RowStyle())
        POBMPInner.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        POBMPInner.RowStyles.Add(New RowStyle())
        POBMPInner.Size = New Size(183, 250)
        POBMPInner.TabIndex = 5
        POBMPInner.Visible = False
        ' 
        ' LBMP
        ' 
        LBMP.Dock = DockStyle.Fill
        LBMP.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBMP.IntegralHeight = False
        LBMP.ItemHeight = 14
        LBMP.Location = New Point(3, 30)
        LBMP.Margin = New Padding(3, 0, 3, 0)
        LBMP.Name = "LBMP"
        LBMP.SelectionMode = SelectionMode.MultiExtended
        LBMP.Size = New Size(177, 215)
        LBMP.TabIndex = 25
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.AutoSize = True
        FlowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel4.Controls.Add(BBMPUp)
        FlowLayoutPanel4.Controls.Add(BBMPDown)
        FlowLayoutPanel4.Controls.Add(BBMPBrowse)
        FlowLayoutPanel4.Controls.Add(BBMPRemove)
        FlowLayoutPanel4.Location = New Point(3, 3)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(96, 24)
        FlowLayoutPanel4.TabIndex = 26
        FlowLayoutPanel4.WrapContents = False
        ' 
        ' BBMPUp
        ' 
        BBMPUp.Image = CType(resources.GetObject("BBMPUp.Image"), Image)
        BBMPUp.Location = New Point(0, 0)
        BBMPUp.Margin = New Padding(0)
        BBMPUp.Name = "BBMPUp"
        BBMPUp.Size = New Size(24, 24)
        BBMPUp.TabIndex = 26
        ToolTipUniversal.SetToolTip(BBMPUp, "Move Up")
        BBMPUp.UseVisualStyleBackColor = True
        ' 
        ' BBMPDown
        ' 
        BBMPDown.Image = CType(resources.GetObject("BBMPDown.Image"), Image)
        BBMPDown.Location = New Point(24, 0)
        BBMPDown.Margin = New Padding(0)
        BBMPDown.Name = "BBMPDown"
        BBMPDown.Size = New Size(24, 24)
        BBMPDown.TabIndex = 27
        ToolTipUniversal.SetToolTip(BBMPDown, "Move Down")
        BBMPDown.UseVisualStyleBackColor = True
        ' 
        ' BBMPBrowse
        ' 
        BBMPBrowse.Image = CType(resources.GetObject("BBMPBrowse.Image"), Image)
        BBMPBrowse.Location = New Point(48, 0)
        BBMPBrowse.Margin = New Padding(0)
        BBMPBrowse.Name = "BBMPBrowse"
        BBMPBrowse.Size = New Size(24, 24)
        BBMPBrowse.TabIndex = 30
        ToolTipUniversal.SetToolTip(BBMPBrowse, "Browse")
        BBMPBrowse.UseVisualStyleBackColor = True
        ' 
        ' BBMPRemove
        ' 
        BBMPRemove.Image = CType(resources.GetObject("BBMPRemove.Image"), Image)
        BBMPRemove.Location = New Point(72, 0)
        BBMPRemove.Margin = New Padding(0)
        BBMPRemove.Name = "BBMPRemove"
        BBMPRemove.Size = New Size(24, 24)
        BBMPRemove.TabIndex = 31
        ToolTipUniversal.SetToolTip(BBMPRemove, "Remove")
        BBMPRemove.UseVisualStyleBackColor = True
        ' 
        ' POBMPResizer
        ' 
        POBMPResizer.Dock = DockStyle.Top
        POBMPResizer.FlatAppearance.BorderSize = 0
        POBMPResizer.FlatStyle = FlatStyle.Flat
        POBMPResizer.Location = New Point(0, 245)
        POBMPResizer.Margin = New Padding(0)
        POBMPResizer.Name = "POBMPResizer"
        POBMPResizer.Size = New Size(183, 5)
        POBMPResizer.TabIndex = 33
        POBMPResizer.TabStop = False
        POBMPResizer.UseVisualStyleBackColor = True
        ' 
        ' POBMPSwitch
        ' 
        POBMPSwitch.Appearance = Appearance.Button
        POBMPSwitch.BackColor = SystemColors.Control
        POBMPSwitch.Checked = True
        POBMPSwitch.CheckState = CheckState.Checked
        POBMPSwitch.Cursor = Cursors.Hand
        POBMPSwitch.Dock = DockStyle.Top
        POBMPSwitch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        POBMPSwitch.Location = New Point(0, 0)
        POBMPSwitch.Name = "POBMPSwitch"
        POBMPSwitch.Size = New Size(183, 20)
        POBMPSwitch.TabIndex = 4
        POBMPSwitch.TabStop = False
        POBMPSwitch.Text = "#BMP (Images List)"
        POBMPSwitch.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POBMPSwitch.UseCompatibleTextRendering = True
        POBMPSwitch.UseVisualStyleBackColor = False
        ' 
        ' POWAV
        ' 
        POWAV.AllowDrop = True
        POWAV.AutoSize = True
        POWAV.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POWAV.Controls.Add(POWAVInner)
        POWAV.Controls.Add(POWAVSwitch)
        POWAV.Dock = DockStyle.Top
        POWAV.Location = New Point(0, 1001)
        POWAV.Name = "POWAV"
        POWAV.Size = New Size(183, 270)
        POWAV.TabIndex = 4
        ' 
        ' POWAVInner
        ' 
        POWAVInner.ColumnCount = 1
        POWAVInner.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        POWAVInner.Controls.Add(POWAVExpander, 0, 1)
        POWAVInner.Controls.Add(LWAV, 0, 3)
        POWAVInner.Controls.Add(FlowLayoutPanel3, 0, 0)
        POWAVInner.Controls.Add(POWAVResizer, 0, 4)
        POWAVInner.Controls.Add(POWAVPart2, 0, 2)
        POWAVInner.Dock = DockStyle.Top
        POWAVInner.Location = New Point(0, 20)
        POWAVInner.Name = "POWAVInner"
        POWAVInner.RowCount = 5
        POWAVInner.RowStyles.Add(New RowStyle())
        POWAVInner.RowStyles.Add(New RowStyle())
        POWAVInner.RowStyles.Add(New RowStyle())
        POWAVInner.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        POWAVInner.RowStyles.Add(New RowStyle())
        POWAVInner.Size = New Size(183, 250)
        POWAVInner.TabIndex = 5
        ' 
        ' POWAVExpander
        ' 
        POWAVExpander.Appearance = Appearance.Button
        POWAVExpander.AutoSize = True
        POWAVExpander.Cursor = Cursors.Hand
        POWAVExpander.Dock = DockStyle.Top
        POWAVExpander.FlatAppearance.BorderSize = 0
        POWAVExpander.FlatStyle = FlatStyle.Popup
        POWAVExpander.Location = New Point(0, 30)
        POWAVExpander.Margin = New Padding(0)
        POWAVExpander.Name = "POWAVExpander"
        POWAVExpander.Size = New Size(183, 25)
        POWAVExpander.TabIndex = 34
        POWAVExpander.TabStop = False
        POWAVExpander.Text = "Expand..."
        POWAVExpander.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POWAVExpander.UseVisualStyleBackColor = False
        ' 
        ' LWAV
        ' 
        LWAV.Dock = DockStyle.Fill
        LWAV.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LWAV.IntegralHeight = False
        LWAV.ItemHeight = 14
        LWAV.Location = New Point(3, 113)
        LWAV.Margin = New Padding(3, 0, 3, 0)
        LWAV.Name = "LWAV"
        LWAV.SelectionMode = SelectionMode.MultiExtended
        LWAV.Size = New Size(177, 132)
        LWAV.TabIndex = 25
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.AutoSize = True
        FlowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel3.Controls.Add(BWAVUp)
        FlowLayoutPanel3.Controls.Add(BWAVDown)
        FlowLayoutPanel3.Controls.Add(BWAVBrowse)
        FlowLayoutPanel3.Controls.Add(BWAVRemove)
        FlowLayoutPanel3.Location = New Point(3, 3)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(96, 24)
        FlowLayoutPanel3.TabIndex = 26
        FlowLayoutPanel3.WrapContents = False
        ' 
        ' BWAVUp
        ' 
        BWAVUp.Image = CType(resources.GetObject("BWAVUp.Image"), Image)
        BWAVUp.Location = New Point(0, 0)
        BWAVUp.Margin = New Padding(0)
        BWAVUp.Name = "BWAVUp"
        BWAVUp.Size = New Size(24, 24)
        BWAVUp.TabIndex = 26
        ToolTipUniversal.SetToolTip(BWAVUp, "Move Up")
        BWAVUp.UseVisualStyleBackColor = True
        ' 
        ' BWAVDown
        ' 
        BWAVDown.Image = CType(resources.GetObject("BWAVDown.Image"), Image)
        BWAVDown.Location = New Point(24, 0)
        BWAVDown.Margin = New Padding(0)
        BWAVDown.Name = "BWAVDown"
        BWAVDown.Size = New Size(24, 24)
        BWAVDown.TabIndex = 27
        ToolTipUniversal.SetToolTip(BWAVDown, "Move Down")
        BWAVDown.UseVisualStyleBackColor = True
        ' 
        ' BWAVBrowse
        ' 
        BWAVBrowse.Image = CType(resources.GetObject("BWAVBrowse.Image"), Image)
        BWAVBrowse.Location = New Point(48, 0)
        BWAVBrowse.Margin = New Padding(0)
        BWAVBrowse.Name = "BWAVBrowse"
        BWAVBrowse.Size = New Size(24, 24)
        BWAVBrowse.TabIndex = 30
        ToolTipUniversal.SetToolTip(BWAVBrowse, "Browse")
        BWAVBrowse.UseVisualStyleBackColor = True
        ' 
        ' BWAVRemove
        ' 
        BWAVRemove.Image = CType(resources.GetObject("BWAVRemove.Image"), Image)
        BWAVRemove.Location = New Point(72, 0)
        BWAVRemove.Margin = New Padding(0)
        BWAVRemove.Name = "BWAVRemove"
        BWAVRemove.Size = New Size(24, 24)
        BWAVRemove.TabIndex = 31
        ToolTipUniversal.SetToolTip(BWAVRemove, "Remove")
        BWAVRemove.UseVisualStyleBackColor = True
        ' 
        ' POWAVResizer
        ' 
        POWAVResizer.Dock = DockStyle.Top
        POWAVResizer.FlatAppearance.BorderSize = 0
        POWAVResizer.FlatStyle = FlatStyle.Flat
        POWAVResizer.Location = New Point(0, 245)
        POWAVResizer.Margin = New Padding(0)
        POWAVResizer.Name = "POWAVResizer"
        POWAVResizer.Size = New Size(183, 5)
        POWAVResizer.TabIndex = 33
        POWAVResizer.TabStop = False
        POWAVResizer.UseVisualStyleBackColor = True
        ' 
        ' POWAVPart2
        ' 
        POWAVPart2.AutoSize = True
        POWAVPart2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POWAVPart2.ColumnCount = 1
        POWAVPart2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        POWAVPart2.Controls.Add(CWAVMultiSelect, 0, 0)
        POWAVPart2.Controls.Add(CWAVChangeLabel, 0, 1)
        POWAVPart2.Controls.Add(CWAVEmptyfill, 0, 2)
        POWAVPart2.Dock = DockStyle.Fill
        POWAVPart2.Location = New Point(0, 55)
        POWAVPart2.Margin = New Padding(0)
        POWAVPart2.Name = "POWAVPart2"
        POWAVPart2.RowCount = 2
        POWAVPart2.RowStyles.Add(New RowStyle())
        POWAVPart2.RowStyles.Add(New RowStyle())
        POWAVPart2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        POWAVPart2.Size = New Size(183, 58)
        POWAVPart2.TabIndex = 35
        POWAVPart2.Visible = False
        ' 
        ' CWAVMultiSelect
        ' 
        CWAVMultiSelect.AutoSize = True
        CWAVMultiSelect.Checked = True
        CWAVMultiSelect.CheckState = CheckState.Checked
        CWAVMultiSelect.Location = New Point(3, 0)
        CWAVMultiSelect.Margin = New Padding(3, 0, 3, 0)
        CWAVMultiSelect.Name = "CWAVMultiSelect"
        CWAVMultiSelect.Size = New Size(154, 19)
        CWAVMultiSelect.TabIndex = 0
        CWAVMultiSelect.Text = "Allow Multiple Selection"
        CWAVMultiSelect.UseVisualStyleBackColor = True
        ' 
        ' CWAVChangeLabel
        ' 
        CWAVChangeLabel.AutoSize = True
        CWAVChangeLabel.Checked = True
        CWAVChangeLabel.CheckState = CheckState.Checked
        CWAVChangeLabel.Location = New Point(3, 19)
        CWAVChangeLabel.Margin = New Padding(3, 0, 3, 0)
        CWAVChangeLabel.Name = "CWAVChangeLabel"
        CWAVChangeLabel.Size = New Size(155, 19)
        CWAVChangeLabel.TabIndex = 1
        CWAVChangeLabel.Text = "Synchronize Note Labels"
        CWAVChangeLabel.UseVisualStyleBackColor = True
        ' 
        ' CWAVEmptyfill
        ' 
        CWAVEmptyfill.AutoSize = True
        CWAVEmptyfill.Checked = True
        CWAVEmptyfill.CheckState = CheckState.Checked
        CWAVEmptyfill.Location = New Point(3, 38)
        CWAVEmptyfill.Margin = New Padding(3, 0, 3, 0)
        CWAVEmptyfill.Name = "CWAVEmptyfill"
        CWAVEmptyfill.Size = New Size(158, 19)
        CWAVEmptyfill.TabIndex = 0
        CWAVEmptyfill.Text = "Fill Empty Definition First"
        CWAVEmptyfill.UseVisualStyleBackColor = True
        ' 
        ' POWAVSwitch
        ' 
        POWAVSwitch.Appearance = Appearance.Button
        POWAVSwitch.BackColor = SystemColors.Control
        POWAVSwitch.Checked = True
        POWAVSwitch.CheckState = CheckState.Checked
        POWAVSwitch.Cursor = Cursors.Hand
        POWAVSwitch.Dock = DockStyle.Top
        POWAVSwitch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        POWAVSwitch.Location = New Point(0, 0)
        POWAVSwitch.Name = "POWAVSwitch"
        POWAVSwitch.Size = New Size(183, 20)
        POWAVSwitch.TabIndex = 4
        POWAVSwitch.TabStop = False
        POWAVSwitch.Text = "#WAV (Sounds List)"
        POWAVSwitch.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POWAVSwitch.UseCompatibleTextRendering = True
        POWAVSwitch.UseVisualStyleBackColor = False
        ' 
        ' POWaveForm
        ' 
        POWaveForm.AutoSize = True
        POWaveForm.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POWaveForm.Controls.Add(POWaveFormInner)
        POWaveForm.Controls.Add(POWaveFormSwitch)
        POWaveForm.Dock = DockStyle.Top
        POWaveForm.Location = New Point(0, 758)
        POWaveForm.Name = "POWaveForm"
        POWaveForm.Size = New Size(183, 243)
        POWaveForm.TabIndex = 3
        ' 
        ' POWaveFormInner
        ' 
        POWaveFormInner.AutoSize = True
        POWaveFormInner.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POWaveFormInner.Controls.Add(POWaveFormPart2)
        POWaveFormInner.Controls.Add(POWaveFormExpander)
        POWaveFormInner.Controls.Add(POWaveFormPart1)
        POWaveFormInner.Dock = DockStyle.Top
        POWaveFormInner.Location = New Point(0, 20)
        POWaveFormInner.Name = "POWaveFormInner"
        POWaveFormInner.Size = New Size(183, 223)
        POWaveFormInner.TabIndex = 29
        POWaveFormInner.Visible = False
        ' 
        ' POWaveFormPart2
        ' 
        POWaveFormPart2.AutoSize = True
        POWaveFormPart2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POWaveFormPart2.ColumnCount = 3
        POWaveFormPart2.ColumnStyles.Add(New ColumnStyle())
        POWaveFormPart2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        POWaveFormPart2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        POWaveFormPart2.Controls.Add(TWSaturation, 2, 4)
        POWaveFormPart2.Controls.Add(PictureBox2, 0, 0)
        POWaveFormPart2.Controls.Add(TWTransparency, 2, 3)
        POWaveFormPart2.Controls.Add(PictureBox3, 0, 1)
        POWaveFormPart2.Controls.Add(TWPrecision, 2, 2)
        POWaveFormPart2.Controls.Add(PictureBox4, 0, 2)
        POWaveFormPart2.Controls.Add(TWWidth, 2, 1)
        POWaveFormPart2.Controls.Add(PictureBox5, 0, 3)
        POWaveFormPart2.Controls.Add(TWLeft, 2, 0)
        POWaveFormPart2.Controls.Add(PictureBox6, 0, 4)
        POWaveFormPart2.Controls.Add(TWSaturation2, 1, 4)
        POWaveFormPart2.Controls.Add(TWLeft2, 1, 0)
        POWaveFormPart2.Controls.Add(TWTransparency2, 1, 3)
        POWaveFormPart2.Controls.Add(TWWidth2, 1, 1)
        POWaveFormPart2.Controls.Add(TWPrecision2, 1, 2)
        POWaveFormPart2.Dock = DockStyle.Top
        POWaveFormPart2.Location = New Point(0, 83)
        POWaveFormPart2.Name = "POWaveFormPart2"
        POWaveFormPart2.RowCount = 5
        POWaveFormPart2.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
        POWaveFormPart2.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
        POWaveFormPart2.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
        POWaveFormPart2.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
        POWaveFormPart2.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
        POWaveFormPart2.Size = New Size(183, 140)
        POWaveFormPart2.TabIndex = 5
        ' 
        ' TWSaturation
        ' 
        TWSaturation.Dock = DockStyle.Fill
        TWSaturation.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        TWSaturation.Location = New Point(137, 112)
        TWSaturation.Margin = New Padding(0, 0, 3, 0)
        TWSaturation.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        TWSaturation.Name = "TWSaturation"
        TWSaturation.Size = New Size(43, 23)
        TWSaturation.TabIndex = 68
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 0)
        PictureBox2.Margin = New Padding(3, 0, 3, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(24, 24)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 60
        PictureBox2.TabStop = False
        ' 
        ' TWTransparency
        ' 
        TWTransparency.Dock = DockStyle.Fill
        TWTransparency.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        TWTransparency.Location = New Point(137, 84)
        TWTransparency.Margin = New Padding(0, 0, 3, 0)
        TWTransparency.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        TWTransparency.Name = "TWTransparency"
        TWTransparency.Size = New Size(43, 23)
        TWTransparency.TabIndex = 69
        TWTransparency.Value = New Decimal(New Integer() {80, 0, 0, 0})
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 28)
        PictureBox3.Margin = New Padding(3, 0, 3, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(24, 24)
        PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox3.TabIndex = 61
        PictureBox3.TabStop = False
        ' 
        ' TWPrecision
        ' 
        TWPrecision.Dock = DockStyle.Fill
        TWPrecision.Location = New Point(137, 56)
        TWPrecision.Margin = New Padding(0, 0, 3, 0)
        TWPrecision.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        TWPrecision.Name = "TWPrecision"
        TWPrecision.Size = New Size(43, 23)
        TWPrecision.TabIndex = 46
        TWPrecision.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(3, 56)
        PictureBox4.Margin = New Padding(3, 0, 3, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(24, 24)
        PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox4.TabIndex = 62
        PictureBox4.TabStop = False
        ' 
        ' TWWidth
        ' 
        TWWidth.Dock = DockStyle.Fill
        TWWidth.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        TWWidth.Location = New Point(137, 28)
        TWWidth.Margin = New Padding(0, 0, 3, 0)
        TWWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        TWWidth.Name = "TWWidth"
        TWWidth.Size = New Size(43, 23)
        TWWidth.TabIndex = 45
        TWWidth.Value = New Decimal(New Integer() {200, 0, 0, 0})
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(3, 84)
        PictureBox5.Margin = New Padding(3, 0, 3, 0)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(24, 24)
        PictureBox5.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox5.TabIndex = 67
        PictureBox5.TabStop = False
        ' 
        ' TWLeft
        ' 
        TWLeft.Dock = DockStyle.Fill
        TWLeft.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        TWLeft.Location = New Point(137, 0)
        TWLeft.Margin = New Padding(0, 0, 3, 0)
        TWLeft.Maximum = New Decimal(New Integer() {800, 0, 0, 0})
        TWLeft.Name = "TWLeft"
        TWLeft.Size = New Size(43, 23)
        TWLeft.TabIndex = 44
        TWLeft.Value = New Decimal(New Integer() {50, 0, 0, 0})
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(3, 112)
        PictureBox6.Margin = New Padding(3, 0, 3, 0)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(24, 24)
        PictureBox6.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox6.TabIndex = 66
        PictureBox6.TabStop = False
        ' 
        ' TWSaturation2
        ' 
        TWSaturation2.Dock = DockStyle.Fill
        TWSaturation2.LargeChange = 200
        TWSaturation2.Location = New Point(30, 112)
        TWSaturation2.Margin = New Padding(0)
        TWSaturation2.Maximum = 1000
        TWSaturation2.Name = "TWSaturation2"
        TWSaturation2.Size = New Size(107, 28)
        TWSaturation2.SmallChange = 50
        TWSaturation2.TabIndex = 70
        TWSaturation2.TickFrequency = 200
        ' 
        ' TWLeft2
        ' 
        TWLeft2.Dock = DockStyle.Fill
        TWLeft2.LargeChange = 50
        TWLeft2.Location = New Point(30, 0)
        TWLeft2.Margin = New Padding(0)
        TWLeft2.Maximum = 800
        TWLeft2.Name = "TWLeft2"
        TWLeft2.Size = New Size(107, 28)
        TWLeft2.SmallChange = 10
        TWLeft2.TabIndex = 63
        TWLeft2.TickFrequency = 100
        TWLeft2.Value = 50
        ' 
        ' TWTransparency2
        ' 
        TWTransparency2.Dock = DockStyle.Fill
        TWTransparency2.LargeChange = 64
        TWTransparency2.Location = New Point(30, 84)
        TWTransparency2.Margin = New Padding(0)
        TWTransparency2.Maximum = 255
        TWTransparency2.Name = "TWTransparency2"
        TWTransparency2.Size = New Size(107, 28)
        TWTransparency2.SmallChange = 8
        TWTransparency2.TabIndex = 71
        TWTransparency2.TickFrequency = 64
        TWTransparency2.Value = 80
        ' 
        ' TWWidth2
        ' 
        TWWidth2.Dock = DockStyle.Fill
        TWWidth2.LargeChange = 50
        TWWidth2.Location = New Point(30, 28)
        TWWidth2.Margin = New Padding(0)
        TWWidth2.Maximum = 1000
        TWWidth2.Name = "TWWidth2"
        TWWidth2.Size = New Size(107, 28)
        TWWidth2.SmallChange = 10
        TWWidth2.TabIndex = 64
        TWWidth2.TickFrequency = 100
        TWWidth2.Value = 200
        ' 
        ' TWPrecision2
        ' 
        TWPrecision2.Dock = DockStyle.Fill
        TWPrecision2.LargeChange = 4
        TWPrecision2.Location = New Point(30, 56)
        TWPrecision2.Margin = New Padding(0)
        TWPrecision2.Maximum = 50
        TWPrecision2.Name = "TWPrecision2"
        TWPrecision2.Size = New Size(107, 28)
        TWPrecision2.TabIndex = 65
        TWPrecision2.TickFrequency = 5
        TWPrecision2.Value = 5
        ' 
        ' POWaveFormExpander
        ' 
        POWaveFormExpander.Appearance = Appearance.Button
        POWaveFormExpander.AutoSize = True
        POWaveFormExpander.Cursor = Cursors.Hand
        POWaveFormExpander.Dock = DockStyle.Top
        POWaveFormExpander.FlatAppearance.BorderSize = 0
        POWaveFormExpander.FlatStyle = FlatStyle.Popup
        POWaveFormExpander.Location = New Point(0, 58)
        POWaveFormExpander.Margin = New Padding(0)
        POWaveFormExpander.Name = "POWaveFormExpander"
        POWaveFormExpander.Size = New Size(183, 25)
        POWaveFormExpander.TabIndex = 29
        POWaveFormExpander.TabStop = False
        POWaveFormExpander.Text = "Expand..."
        POWaveFormExpander.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POWaveFormExpander.UseVisualStyleBackColor = False
        ' 
        ' POWaveFormPart1
        ' 
        POWaveFormPart1.AutoSize = True
        POWaveFormPart1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POWaveFormPart1.ColumnCount = 1
        POWaveFormPart1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        POWaveFormPart1.Controls.Add(TableLayoutPanel1, 0, 0)
        POWaveFormPart1.Controls.Add(TableLayoutPanel6, 0, 1)
        POWaveFormPart1.Dock = DockStyle.Top
        POWaveFormPart1.Location = New Point(0, 0)
        POWaveFormPart1.Name = "POWaveFormPart1"
        POWaveFormPart1.RowCount = 2
        POWaveFormPart1.RowStyles.Add(New RowStyle())
        POWaveFormPart1.RowStyles.Add(New RowStyle())
        POWaveFormPart1.Size = New Size(183, 58)
        POWaveFormPart1.TabIndex = 4
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 0)
        TableLayoutPanel1.Controls.Add(TWFileName, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(183, 30)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Controls.Add(BWLoad)
        FlowLayoutPanel1.Controls.Add(BWClear)
        FlowLayoutPanel1.Controls.Add(BWLock)
        FlowLayoutPanel1.Location = New Point(3, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(72, 24)
        FlowLayoutPanel1.TabIndex = 72
        FlowLayoutPanel1.WrapContents = False
        ' 
        ' BWLoad
        ' 
        BWLoad.Image = CType(resources.GetObject("BWLoad.Image"), Image)
        BWLoad.Location = New Point(0, 0)
        BWLoad.Margin = New Padding(0)
        BWLoad.Name = "BWLoad"
        BWLoad.Size = New Size(24, 24)
        BWLoad.TabIndex = 40
        ToolTipUniversal.SetToolTip(BWLoad, "Load WaveForm")
        BWLoad.UseVisualStyleBackColor = True
        ' 
        ' BWClear
        ' 
        BWClear.Image = CType(resources.GetObject("BWClear.Image"), Image)
        BWClear.Location = New Point(24, 0)
        BWClear.Margin = New Padding(0)
        BWClear.Name = "BWClear"
        BWClear.Size = New Size(24, 24)
        BWClear.TabIndex = 41
        ToolTipUniversal.SetToolTip(BWClear, "Clear WaveForm")
        BWClear.UseVisualStyleBackColor = True
        ' 
        ' BWLock
        ' 
        BWLock.Appearance = Appearance.Button
        BWLock.Checked = True
        BWLock.CheckState = CheckState.Checked
        BWLock.Image = CType(resources.GetObject("BWLock.Image"), Image)
        BWLock.Location = New Point(48, 0)
        BWLock.Margin = New Padding(0)
        BWLock.Name = "BWLock"
        BWLock.Size = New Size(24, 24)
        BWLock.TabIndex = 0
        ToolTipUniversal.SetToolTip(BWLock, "Lock to BGM")
        BWLock.UseVisualStyleBackColor = True
        ' 
        ' TWFileName
        ' 
        TWFileName.Dock = DockStyle.Fill
        TWFileName.Location = New Point(81, 3)
        TWFileName.Name = "TWFileName"
        TWFileName.ReadOnly = True
        TWFileName.Size = New Size(99, 23)
        TWFileName.TabIndex = 42
        TWFileName.Text = "(None)"
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.AutoSize = True
        TableLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel6.ColumnCount = 3
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel6.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel6.Controls.Add(TWPosition2, 1, 0)
        TableLayoutPanel6.Controls.Add(TWPosition, 2, 0)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(0, 30)
        TableLayoutPanel6.Margin = New Padding(0)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
        TableLayoutPanel6.Size = New Size(183, 28)
        TableLayoutPanel6.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 0)
        PictureBox1.Margin = New Padding(3, 0, 3, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 59
        PictureBox1.TabStop = False
        ' 
        ' TWPosition2
        ' 
        TWPosition2.Dock = DockStyle.Fill
        TWPosition2.Enabled = False
        TWPosition2.LargeChange = 24
        TWPosition2.Location = New Point(30, 0)
        TWPosition2.Margin = New Padding(0)
        TWPosition2.Maximum = 960
        TWPosition2.Name = "TWPosition2"
        TWPosition2.Size = New Size(91, 28)
        TWPosition2.TabIndex = 58
        TWPosition2.TickFrequency = 192
        ' 
        ' TWPosition
        ' 
        TWPosition.DecimalPlaces = 2
        TWPosition.Dock = DockStyle.Fill
        TWPosition.Enabled = False
        TWPosition.Location = New Point(121, 0)
        TWPosition.Margin = New Padding(0, 0, 3, 0)
        TWPosition.Maximum = New Decimal(New Integer() {192000, 0, 0, 0})
        TWPosition.Name = "TWPosition"
        TWPosition.Size = New Size(59, 23)
        TWPosition.TabIndex = 43
        ' 
        ' POWaveFormSwitch
        ' 
        POWaveFormSwitch.Appearance = Appearance.Button
        POWaveFormSwitch.BackColor = SystemColors.Control
        POWaveFormSwitch.Cursor = Cursors.Hand
        POWaveFormSwitch.Dock = DockStyle.Top
        POWaveFormSwitch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        POWaveFormSwitch.Location = New Point(0, 0)
        POWaveFormSwitch.Name = "POWaveFormSwitch"
        POWaveFormSwitch.Size = New Size(183, 20)
        POWaveFormSwitch.TabIndex = 3
        POWaveFormSwitch.TabStop = False
        POWaveFormSwitch.Text = "WaveForm"
        POWaveFormSwitch.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POWaveFormSwitch.UseCompatibleTextRendering = True
        POWaveFormSwitch.UseVisualStyleBackColor = False
        ' 
        ' POGrid
        ' 
        POGrid.AutoSize = True
        POGrid.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POGrid.Controls.Add(POGridInner)
        POGrid.Controls.Add(POGridSwitch)
        POGrid.Dock = DockStyle.Top
        POGrid.Location = New Point(0, 528)
        POGrid.Name = "POGrid"
        POGrid.Size = New Size(183, 230)
        POGrid.TabIndex = 2
        ' 
        ' POGridInner
        ' 
        POGridInner.AutoSize = True
        POGridInner.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POGridInner.Controls.Add(POGridPart2)
        POGridInner.Controls.Add(POGridExpander)
        POGridInner.Controls.Add(POGridPart1)
        POGridInner.Dock = DockStyle.Top
        POGridInner.Location = New Point(0, 20)
        POGridInner.Name = "POGridInner"
        POGridInner.Size = New Size(183, 210)
        POGridInner.TabIndex = 3
        ' 
        ' POGridPart2
        ' 
        POGridPart2.AutoSize = True
        POGridPart2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POGridPart2.ColumnCount = 1
        POGridPart2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        POGridPart2.Controls.Add(TableLayoutPanel5, 0, 1)
        POGridPart2.Controls.Add(TableLayoutPanel4, 0, 0)
        POGridPart2.Dock = DockStyle.Top
        POGridPart2.Location = New Point(0, 152)
        POGridPart2.Name = "POGridPart2"
        POGridPart2.RowCount = 2
        POGridPart2.RowStyles.Add(New RowStyle())
        POGridPart2.RowStyles.Add(New RowStyle())
        POGridPart2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        POGridPart2.Size = New Size(183, 58)
        POGridPart2.TabIndex = 0
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.AutoSize = True
        TableLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Controls.Add(FlowLayoutPanel2, 1, 0)
        TableLayoutPanel5.Controls.Add(Label5, 0, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(0, 29)
        TableLayoutPanel5.Margin = New Padding(0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle())
        TableLayoutPanel5.Size = New Size(183, 29)
        TableLayoutPanel5.TabIndex = 46
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.AutoSize = True
        FlowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel2.Controls.Add(cVSLockL)
        FlowLayoutPanel2.Controls.Add(cVSLock)
        FlowLayoutPanel2.Controls.Add(cVSLockR)
        FlowLayoutPanel2.Location = New Point(114, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(66, 23)
        FlowLayoutPanel2.TabIndex = 72
        FlowLayoutPanel2.WrapContents = False
        ' 
        ' cVSLockL
        ' 
        cVSLockL.Appearance = Appearance.Button
        cVSLockL.FlatStyle = FlatStyle.Popup
        cVSLockL.Image = CType(resources.GetObject("cVSLockL.Image"), Image)
        cVSLockL.Location = New Point(0, 0)
        cVSLockL.Margin = New Padding(0)
        cVSLockL.Name = "cVSLockL"
        cVSLockL.Size = New Size(23, 23)
        cVSLockL.TabIndex = 38
        cVSLockL.Tag = "0"
        ToolTipUniversal.SetToolTip(cVSLockL, "Lock Left Editing Panel")
        ' 
        ' cVSLock
        ' 
        cVSLock.Appearance = Appearance.Button
        cVSLock.FlatStyle = FlatStyle.Popup
        cVSLock.Image = CType(resources.GetObject("cVSLock.Image"), Image)
        cVSLock.Location = New Point(23, 0)
        cVSLock.Margin = New Padding(0)
        cVSLock.Name = "cVSLock"
        cVSLock.Size = New Size(23, 23)
        cVSLock.TabIndex = 40
        cVSLock.Tag = "1"
        ToolTipUniversal.SetToolTip(cVSLock, "Lock Middle Editing Panel")
        ' 
        ' cVSLockR
        ' 
        cVSLockR.Appearance = Appearance.Button
        cVSLockR.FlatStyle = FlatStyle.Popup
        cVSLockR.Image = CType(resources.GetObject("cVSLockR.Image"), Image)
        cVSLockR.Location = New Point(46, 0)
        cVSLockR.Margin = New Padding(0)
        cVSLockR.Name = "cVSLockR"
        cVSLockR.Size = New Size(23, 23)
        cVSLockR.TabIndex = 41
        cVSLockR.Tag = "2"
        ToolTipUniversal.SetToolTip(cVSLockR, "Lock Right Editing Panel")
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 29)
        Label5.TabIndex = 39
        Label5.Text = "Vertical Scroll Lock"
        Label5.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.AutoSize = True
        TableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Controls.Add(Label1, 0, 0)
        TableLayoutPanel4.Controls.Add(CGB, 1, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Margin = New Padding(0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle())
        TableLayoutPanel4.Size = New Size(183, 29)
        TableLayoutPanel4.TabIndex = 44
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 29)
        Label1.TabIndex = 43
        Label1.Text = "Number of B Columns"
        Label1.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' CGB
        ' 
        CGB.Dock = DockStyle.Fill
        CGB.Location = New Point(135, 3)
        CGB.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        CGB.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        CGB.Name = "CGB"
        CGB.Size = New Size(45, 23)
        CGB.TabIndex = 35
        CGB.Value = New Decimal(New Integer() {15, 0, 0, 0})
        ' 
        ' POGridExpander
        ' 
        POGridExpander.Appearance = Appearance.Button
        POGridExpander.AutoSize = True
        POGridExpander.Cursor = Cursors.Hand
        POGridExpander.Dock = DockStyle.Top
        POGridExpander.FlatAppearance.BorderSize = 0
        POGridExpander.FlatStyle = FlatStyle.Popup
        POGridExpander.Location = New Point(0, 127)
        POGridExpander.Margin = New Padding(0)
        POGridExpander.Name = "POGridExpander"
        POGridExpander.Size = New Size(183, 25)
        POGridExpander.TabIndex = 27
        POGridExpander.TabStop = False
        POGridExpander.Text = "Expand..."
        POGridExpander.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POGridExpander.UseVisualStyleBackColor = False
        ' 
        ' POGridPart1
        ' 
        POGridPart1.AutoSize = True
        POGridPart1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POGridPart1.ColumnCount = 1
        POGridPart1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        POGridPart1.Controls.Add(TableLayoutPanel3, 0, 1)
        POGridPart1.Controls.Add(CGDisableVertical, 0, 3)
        POGridPart1.Controls.Add(CGSnap, 0, 2)
        POGridPart1.Controls.Add(TableLayoutPanel2, 0, 0)
        POGridPart1.Dock = DockStyle.Top
        POGridPart1.Location = New Point(0, 0)
        POGridPart1.Name = "POGridPart1"
        POGridPart1.RowCount = 4
        POGridPart1.RowStyles.Add(New RowStyle())
        POGridPart1.RowStyles.Add(New RowStyle())
        POGridPart1.RowStyles.Add(New RowStyle())
        POGridPart1.RowStyles.Add(New RowStyle())
        POGridPart1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        POGridPart1.Size = New Size(183, 127)
        POGridPart1.TabIndex = 11
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel3.Controls.Add(PictureBox9, 0, 0)
        TableLayoutPanel3.Controls.Add(CGHeight2, 1, 0)
        TableLayoutPanel3.Controls.Add(CGHeight, 2, 0)
        TableLayoutPanel3.Controls.Add(PictureBox10, 0, 1)
        TableLayoutPanel3.Controls.Add(CGWidth2, 1, 1)
        TableLayoutPanel3.Controls.Add(CGWidth, 2, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 30)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
        TableLayoutPanel3.Size = New Size(183, 56)
        TableLayoutPanel3.TabIndex = 12
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(3, 0)
        PictureBox9.Margin = New Padding(3, 0, 3, 0)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(24, 24)
        PictureBox9.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox9.TabIndex = 27
        PictureBox9.TabStop = False
        ' 
        ' CGHeight2
        ' 
        CGHeight2.Dock = DockStyle.Fill
        CGHeight2.LargeChange = 4
        CGHeight2.Location = New Point(30, 0)
        CGHeight2.Margin = New Padding(0)
        CGHeight2.Maximum = 20
        CGHeight2.Minimum = 1
        CGHeight2.Name = "CGHeight2"
        CGHeight2.Size = New Size(107, 28)
        CGHeight2.TabIndex = 29
        CGHeight2.TickFrequency = 2
        CGHeight2.Value = 4
        ' 
        ' CGHeight
        ' 
        CGHeight.DecimalPlaces = 2
        CGHeight.Dock = DockStyle.Fill
        CGHeight.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        CGHeight.Location = New Point(137, 0)
        CGHeight.Margin = New Padding(0, 0, 3, 0)
        CGHeight.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        CGHeight.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        CGHeight.Name = "CGHeight"
        CGHeight.Size = New Size(43, 23)
        CGHeight.TabIndex = 23
        CGHeight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(3, 28)
        PictureBox10.Margin = New Padding(3, 0, 3, 0)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(24, 24)
        PictureBox10.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox10.TabIndex = 28
        PictureBox10.TabStop = False
        ' 
        ' CGWidth2
        ' 
        CGWidth2.Dock = DockStyle.Fill
        CGWidth2.LargeChange = 4
        CGWidth2.Location = New Point(30, 28)
        CGWidth2.Margin = New Padding(0)
        CGWidth2.Maximum = 20
        CGWidth2.Minimum = 1
        CGWidth2.Name = "CGWidth2"
        CGWidth2.Size = New Size(107, 28)
        CGWidth2.TabIndex = 30
        CGWidth2.TickFrequency = 2
        CGWidth2.Value = 4
        ' 
        ' CGWidth
        ' 
        CGWidth.DecimalPlaces = 2
        CGWidth.Dock = DockStyle.Fill
        CGWidth.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        CGWidth.Location = New Point(137, 28)
        CGWidth.Margin = New Padding(0, 0, 3, 0)
        CGWidth.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        CGWidth.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        CGWidth.Name = "CGWidth"
        CGWidth.Size = New Size(43, 23)
        CGWidth.TabIndex = 24
        CGWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' CGDisableVertical
        ' 
        CGDisableVertical.AutoSize = True
        CGDisableVertical.Location = New Point(3, 108)
        CGDisableVertical.Margin = New Padding(3, 0, 3, 0)
        CGDisableVertical.Name = "CGDisableVertical"
        CGDisableVertical.Size = New Size(162, 19)
        CGDisableVertical.TabIndex = 45
        CGDisableVertical.Text = "Disable vertical moves (D)"
        CGDisableVertical.UseVisualStyleBackColor = True
        ' 
        ' CGSnap
        ' 
        CGSnap.AutoSize = True
        CGSnap.Checked = True
        CGSnap.CheckState = CheckState.Checked
        CGSnap.Location = New Point(3, 89)
        CGSnap.Margin = New Padding(3, 3, 3, 0)
        CGSnap.Name = "CGSnap"
        CGSnap.Size = New Size(109, 19)
        CGSnap.TabIndex = 10
        CGSnap.Text = "Snap to grid (G)"
        CGSnap.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.Controls.Add(PictureBox7, 0, 0)
        TableLayoutPanel2.Controls.Add(CGDivide, 1, 0)
        TableLayoutPanel2.Controls.Add(CGSub, 2, 0)
        TableLayoutPanel2.Controls.Add(BGSlash, 3, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(183, 30)
        TableLayoutPanel2.TabIndex = 11
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.None
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(3, 3)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(24, 24)
        PictureBox7.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox7.TabIndex = 25
        PictureBox7.TabStop = False
        ' 
        ' CGDivide
        ' 
        CGDivide.Dock = DockStyle.Fill
        CGDivide.Location = New Point(33, 3)
        CGDivide.Maximum = New Decimal(New Integer() {1920, 0, 0, 0})
        CGDivide.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        CGDivide.Name = "CGDivide"
        CGDivide.Size = New Size(58, 23)
        CGDivide.TabIndex = 36
        CGDivide.Value = New Decimal(New Integer() {16, 0, 0, 0})
        ' 
        ' CGSub
        ' 
        CGSub.Dock = DockStyle.Fill
        CGSub.Location = New Point(97, 3)
        CGSub.Maximum = New Decimal(New Integer() {1920, 0, 0, 0})
        CGSub.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        CGSub.Name = "CGSub"
        CGSub.Size = New Size(58, 23)
        CGSub.TabIndex = 37
        CGSub.Value = New Decimal(New Integer() {4, 0, 0, 0})
        ' 
        ' BGSlash
        ' 
        BGSlash.Anchor = AnchorStyles.None
        BGSlash.Image = CType(resources.GetObject("BGSlash.Image"), Image)
        BGSlash.Location = New Point(158, 4)
        BGSlash.Margin = New Padding(0, 0, 3, 0)
        BGSlash.Name = "BGSlash"
        BGSlash.Size = New Size(22, 22)
        BGSlash.TabIndex = 38
        BGSlash.UseVisualStyleBackColor = True
        ' 
        ' POGridSwitch
        ' 
        POGridSwitch.Appearance = Appearance.Button
        POGridSwitch.BackColor = SystemColors.Control
        POGridSwitch.Checked = True
        POGridSwitch.CheckState = CheckState.Checked
        POGridSwitch.Cursor = Cursors.Hand
        POGridSwitch.Dock = DockStyle.Top
        POGridSwitch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        POGridSwitch.Location = New Point(0, 0)
        POGridSwitch.Name = "POGridSwitch"
        POGridSwitch.Size = New Size(183, 20)
        POGridSwitch.TabIndex = 2
        POGridSwitch.TabStop = False
        POGridSwitch.Text = "Grid"
        POGridSwitch.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POGridSwitch.UseCompatibleTextRendering = True
        POGridSwitch.UseVisualStyleBackColor = False
        ' 
        ' POHeader
        ' 
        POHeader.AutoSize = True
        POHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POHeader.Controls.Add(POHeaderInner)
        POHeader.Controls.Add(POHeaderSwitch)
        POHeader.Dock = DockStyle.Top
        POHeader.Location = New Point(0, 0)
        POHeader.Name = "POHeader"
        POHeader.Size = New Size(183, 528)
        POHeader.TabIndex = 1
        ' 
        ' POHeaderInner
        ' 
        POHeaderInner.AutoSize = True
        POHeaderInner.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POHeaderInner.Controls.Add(POHeaderPart2)
        POHeaderInner.Controls.Add(POHeaderExpander)
        POHeaderInner.Controls.Add(POHeaderPart1)
        POHeaderInner.Dock = DockStyle.Top
        POHeaderInner.Location = New Point(0, 20)
        POHeaderInner.Name = "POHeaderInner"
        POHeaderInner.Size = New Size(183, 508)
        POHeaderInner.TabIndex = 2
        ' 
        ' POHeaderPart2
        ' 
        POHeaderPart2.AutoSize = True
        POHeaderPart2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POHeaderPart2.ColumnCount = 3
        POHeaderPart2.ColumnStyles.Add(New ColumnStyle())
        POHeaderPart2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        POHeaderPart2.ColumnStyles.Add(New ColumnStyle())
        POHeaderPart2.Controls.Add(CHDifficulty, 1, 5)
        POHeaderPart2.Controls.Add(Label13, 2, 6)
        POHeaderPart2.Controls.Add(THExRank, 1, 6)
        POHeaderPart2.Controls.Add(CHLnObj, 1, 8)
        POHeaderPart2.Controls.Add(Label23, 0, 6)
        POHeaderPart2.Controls.Add(Label21, 0, 5)
        POHeaderPart2.Controls.Add(THComment, 1, 7)
        POHeaderPart2.Controls.Add(Label24, 0, 8)
        POHeaderPart2.Controls.Add(Label15, 0, 0)
        POHeaderPart2.Controls.Add(BHStageFile, 2, 2)
        POHeaderPart2.Controls.Add(BHBanner, 2, 3)
        POHeaderPart2.Controls.Add(Label19, 0, 7)
        POHeaderPart2.Controls.Add(BHBackBMP, 2, 4)
        POHeaderPart2.Controls.Add(Label17, 0, 1)
        POHeaderPart2.Controls.Add(Label16, 0, 2)
        POHeaderPart2.Controls.Add(Label12, 0, 3)
        POHeaderPart2.Controls.Add(THBackBMP, 1, 4)
        POHeaderPart2.Controls.Add(Label11, 0, 4)
        POHeaderPart2.Controls.Add(THBanner, 1, 3)
        POHeaderPart2.Controls.Add(THStageFile, 1, 2)
        POHeaderPart2.Controls.Add(THSubTitle, 1, 0)
        POHeaderPart2.Controls.Add(THSubArtist, 1, 1)
        POHeaderPart2.Controls.Add(Label26, 0, 9)
        POHeaderPart2.Controls.Add(Label27, 0, 10)
        POHeaderPart2.Controls.Add(THLandMine, 1, 9)
        POHeaderPart2.Controls.Add(BHLandMine, 2, 9)
        POHeaderPart2.Controls.Add(THMissBMP, 1, 10)
        POHeaderPart2.Controls.Add(BHMissBMP, 2, 10)
        POHeaderPart2.Controls.Add(Label28, 0, 11)
        POHeaderPart2.Controls.Add(Label29, 0, 12)
        POHeaderPart2.Controls.Add(THPreview, 1, 11)
        POHeaderPart2.Controls.Add(BHPreview, 2, 11)
        POHeaderPart2.Controls.Add(CHLnmode, 1, 12)
        POHeaderPart2.Dock = DockStyle.Top
        POHeaderPart2.Location = New Point(0, 206)
        POHeaderPart2.Name = "POHeaderPart2"
        POHeaderPart2.RowCount = 13
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle())
        POHeaderPart2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        POHeaderPart2.Size = New Size(183, 302)
        POHeaderPart2.TabIndex = 27
        ' 
        ' CHDifficulty
        ' 
        POHeaderPart2.SetColumnSpan(CHDifficulty, 2)
        CHDifficulty.Dock = DockStyle.Top
        CHDifficulty.DropDownStyle = ComboBoxStyle.DropDownList
        CHDifficulty.FlatStyle = FlatStyle.System
        CHDifficulty.Items.AddRange(New Object() {"None", "1 - EZ / Beginner", "2 - NM / Normal", "3 - HD / Hyper", "4 - MX / Another", "5 - SC / Insane"})
        CHDifficulty.Location = New Point(67, 118)
        CHDifficulty.Margin = New Padding(0)
        CHDifficulty.Name = "CHDifficulty"
        CHDifficulty.Size = New Size(116, 23)
        CHDifficulty.TabIndex = 63
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Dock = DockStyle.Fill
        Label13.Location = New Point(158, 141)
        Label13.Margin = New Padding(3, 0, 0, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(25, 23)
        Label13.TabIndex = 63
        Label13.Text = "(%)"
        Label13.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' THExRank
        ' 
        THExRank.Dock = DockStyle.Fill
        THExRank.Location = New Point(67, 141)
        THExRank.Margin = New Padding(0)
        THExRank.Name = "THExRank"
        THExRank.Size = New Size(88, 23)
        THExRank.TabIndex = 27
        ' 
        ' CHLnObj
        ' 
        POHeaderPart2.SetColumnSpan(CHLnObj, 2)
        CHLnObj.Dock = DockStyle.Top
        CHLnObj.DropDownStyle = ComboBoxStyle.DropDownList
        CHLnObj.FlatStyle = FlatStyle.System
        CHLnObj.Items.AddRange(New Object() {"None (#LnType 1)", "01", "02", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "0G", "0H", "0I", "0J", "0K", "0L", "0M", "0N", "0O", "0P", "0Q", "0R", "0S", "0T", "0U", "0V", "0W", "0X", "0Y", "0Z", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "1I", "1J", "1K", "1L", "1M", "1N", "1O", "1P", "1Q", "1R", "1S", "1T", "1U", "1V", "1W", "1X", "1Y", "1Z", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "2G", "2H", "2I", "2J", "2K", "2L", "2M", "2N", "2O", "2P", "2Q", "2R", "2S", "2T", "2U", "2V", "2W", "2X", "2Y", "2Z", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L", "3M", "3N", "3O", "3P", "3Q", "3R", "3S", "3T", "3U", "3V", "3W", "3X", "3Y", "3Z", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4K", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4T", "4U", "4V", "4W", "4X", "4Y", "4Z", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5L", "5M", "5N", "5O", "5P", "5Q", "5R", "5S", "5T", "5U", "5V", "5W", "5X", "5Y", "5Z", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "6G", "6H", "6I", "6J", "6K", "6L", "6M", "6N", "6O", "6P", "6Q", "6R", "6S", "6T", "6U", "6V", "6W", "6X", "6Y", "6Z", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "7G", "7H", "7I", "7J", "7K", "7L", "7M", "7N", "7O", "7P", "7Q", "7R", "7S", "7T", "7U", "7V", "7W", "7X", "7Y", "7Z", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "8G", "8H", "8I", "8J", "8K", "8L", "8M", "8N", "8O", "8P", "8Q", "8R", "8S", "8T", "8U", "8V", "8W", "8X", "8Y", "8Z", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "9G", "9H", "9I", "9J", "9K", "9L", "9M", "9N", "9O", "9P", "9Q", "9R", "9S", "9T", "9U", "9V", "9W", "9X", "9Y", "9Z", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV", "DW", "DX", "DY", "DZ", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP", "EQ", "ER", "ES", "ET", "EU", "EV", "EW", "EX", "EY", "EZ", "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FN", "FO", "FP", "FQ", "FR", "FS", "FT", "FU", "FV", "FW", "FX", "FY", "FZ", "G0", "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GY", "GZ", "H0", "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HX", "HY", "HZ", "I0", "I1", "I2", "I3", "I4", "I5", "I6", "I7", "I8", "I9", "IA", "IB", "IC", "ID", "IE", "IF", "IG", "IH", "II", "IJ", "IK", "IL", "IM", "IN", "IO", "IP", "IQ", "IR", "IS", "IT", "IU", "IV", "IW", "IX", "IY", "IZ", "J0", "J1", "J2", "J3", "J4", "J5", "J6", "J7", "J8", "J9", "JA", "JB", "JC", "JD", "JE", "JF", "JG", "JH", "JI", "JJ", "JK", "JL", "JM", "JN", "JO", "JP", "JQ", "JR", "JS", "JT", "JU", "JV", "JW", "JX", "JY", "JZ", "K0", "K1", "K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9", "KA", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KN", "KO", "KP", "KQ", "KR", "KS", "KT", "KU", "KV", "KW", "KX", "KY", "KZ", "L0", "L1", "L2", "L3", "L4", "L5", "L6", "L7", "L8", "L9", "LA", "LB", "LC", "LD", "LE", "LF", "LG", "LH", "LI", "LJ", "LK", "LL", "LM", "LN", "LO", "LP", "LQ", "LR", "LS", "LT", "LU", "LV", "LW", "LX", "LY", "LZ", "M0", "M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "M9", "MA", "MB", "MC", "MD", "ME", "MF", "MG", "MH", "MI", "MJ", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "N0", "N1", "N2", "N3", "N4", "N5", "N6", "N7", "N8", "N9", "NA", "NB", "NC", "ND", "NE", "NF", "NG", "NH", "NI", "NJ", "NK", "NL", "NM", "NN", "NO", "NP", "NQ", "NR", "NS", "NT", "NU", "NV", "NW", "NX", "NY", "NZ", "O0", "O1", "O2", "O3", "O4", "O5", "O6", "O7", "O8", "O9", "OA", "OB", "OC", "OD", "OE", "OF", "OG", "OH", "OI", "OJ", "OK", "OL", "OM", "ON", "OO", "OP", "OQ", "OR", "OS", "OT", "OU", "OV", "OW", "OX", "OY", "OZ", "P0", "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PI", "PJ", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "Q0", "Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "Q8", "Q9", "QA", "QB", "QC", "QD", "QE", "QF", "QG", "QH", "QI", "QJ", "QK", "QL", "QM", "QN", "QO", "QP", "QQ", "QR", "QS", "QT", "QU", "QV", "QW", "QX", "QY", "QZ", "R0", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RI", "RJ", "RK", "RL", "RM", "RN", "RO", "RP", "RQ", "RR", "RS", "RT", "RU", "RV", "RW", "RX", "RY", "RZ", "S0", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "SW", "SX", "SY", "SZ", "T0", "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "TA", "TB", "TC", "TD", "TE", "TF", "TG", "TH", "TI", "TJ", "TK", "TL", "TM", "TN", "TO", "TP", "TQ", "TR", "TS", "TT", "TU", "TV", "TW", "TX", "TY", "TZ", "U0", "U1", "U2", "U3", "U4", "U5", "U6", "U7", "U8", "U9", "UA", "UB", "UC", "UD", "UE", "UF", "UG", "UH", "UI", "UJ", "UK", "UL", "UM", "UN", "UO", "UP", "UQ", "UR", "US", "UT", "UU", "UV", "UW", "UX", "UY", "UZ", "V0", "V1", "V2", "V3", "V4", "V5", "V6", "V7", "V8", "V9", "VA", "VB", "VC", "VD", "VE", "VF", "VG", "VH", "VI", "VJ", "VK", "VL", "VM", "VN", "VO", "VP", "VQ", "VR", "VS", "VT", "VU", "VV", "VW", "VX", "VY", "VZ", "W0", "W1", "W2", "W3", "W4", "W5", "W6", "W7", "W8", "W9", "WA", "WB", "WC", "WD", "WE", "WF", "WG", "WH", "WI", "WJ", "WK", "WL", "WM", "WN", "WO", "WP", "WQ", "WR", "WS", "WT", "WU", "WV", "WW", "WX", "WY", "WZ", "X0", "X1", "X2", "X3", "X4", "X5", "X6", "X7", "X8", "X9", "XA", "XB", "XC", "XD", "XE", "XF", "XG", "XH", "XI", "XJ", "XK", "XL", "XM", "XN", "XO", "XP", "XQ", "XR", "XS", "XT", "XU", "XV", "XW", "XX", "XY", "XZ", "Y0", "Y1", "Y2", "Y3", "Y4", "Y5", "Y6", "Y7", "Y8", "Y9", "YA", "YB", "YC", "YD", "YE", "YF", "YG", "YH", "YI", "YJ", "YK", "YL", "YM", "YN", "YO", "YP", "YQ", "YR", "YS", "YT", "YU", "YV", "YW", "YX", "YY", "YZ", "Z0", "Z1", "Z2", "Z3", "Z4", "Z5", "Z6", "Z7", "Z8", "Z9", "ZA", "ZB", "ZC", "ZD", "ZE", "ZF", "ZG", "ZH", "ZI", "ZJ", "ZK", "ZL", "ZM", "ZN", "ZO", "ZP", "ZQ", "ZR", "ZS", "ZT", "ZU", "ZV", "ZW", "ZX", "ZY", "ZZ"})
        CHLnObj.Location = New Point(67, 187)
        CHLnObj.Margin = New Padding(0)
        CHLnObj.Name = "CHLnObj"
        CHLnObj.Size = New Size(116, 23)
        CHLnObj.TabIndex = 28
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Right
        Label23.AutoSize = True
        Label23.Location = New Point(19, 145)
        Label23.Name = "Label23"
        Label23.Size = New Size(45, 15)
        Label23.TabIndex = 26
        Label23.Text = "ExRank"
        Label23.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Right
        Label21.AutoSize = True
        Label21.Location = New Point(9, 122)
        Label21.Name = "Label21"
        Label21.Size = New Size(55, 15)
        Label21.TabIndex = 25
        Label21.Text = "Difficulty"
        Label21.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' THComment
        ' 
        POHeaderPart2.SetColumnSpan(THComment, 2)
        THComment.Dock = DockStyle.Fill
        THComment.Location = New Point(67, 164)
        THComment.Margin = New Padding(0)
        THComment.Name = "THComment"
        THComment.Size = New Size(116, 23)
        THComment.TabIndex = 19
        ' 
        ' Label24
        ' 
        Label24.Anchor = AnchorStyles.Right
        Label24.AutoSize = True
        Label24.Location = New Point(25, 191)
        Label24.Name = "Label24"
        Label24.Size = New Size(39, 15)
        Label24.TabIndex = 27
        Label24.Text = "LnObj"
        Label24.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Location = New Point(15, 4)
        Label15.Name = "Label15"
        Label15.Size = New Size(49, 15)
        Label15.TabIndex = 6
        Label15.Text = "SubTitle"
        Label15.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' BHStageFile
        ' 
        BHStageFile.Dock = DockStyle.Fill
        BHStageFile.FlatStyle = FlatStyle.System
        BHStageFile.Location = New Point(158, 46)
        BHStageFile.Margin = New Padding(3, 0, 0, 0)
        BHStageFile.Name = "BHStageFile"
        BHStageFile.Size = New Size(25, 24)
        BHStageFile.TabIndex = 20
        BHStageFile.Text = "..."
        BHStageFile.UseVisualStyleBackColor = True
        ' 
        ' BHBanner
        ' 
        BHBanner.Dock = DockStyle.Fill
        BHBanner.FlatStyle = FlatStyle.System
        BHBanner.Location = New Point(158, 70)
        BHBanner.Margin = New Padding(3, 0, 0, 0)
        BHBanner.Name = "BHBanner"
        BHBanner.Size = New Size(25, 24)
        BHBanner.TabIndex = 21
        BHBanner.Text = "..."
        BHBanner.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Right
        Label19.AutoSize = True
        Label19.Location = New Point(3, 168)
        Label19.Name = "Label19"
        Label19.Size = New Size(61, 15)
        Label19.TabIndex = 13
        Label19.Text = "Comment"
        Label19.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' BHBackBMP
        ' 
        BHBackBMP.Dock = DockStyle.Fill
        BHBackBMP.FlatStyle = FlatStyle.System
        BHBackBMP.Location = New Point(158, 94)
        BHBackBMP.Margin = New Padding(3, 0, 0, 0)
        BHBackBMP.Name = "BHBackBMP"
        BHBackBMP.Size = New Size(25, 24)
        BHBackBMP.TabIndex = 22
        BHBackBMP.Text = "..."
        BHBackBMP.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Right
        Label17.AutoSize = True
        Label17.Location = New Point(9, 27)
        Label17.Name = "Label17"
        Label17.Size = New Size(55, 15)
        Label17.TabIndex = 7
        Label17.Text = "SubArtist"
        Label17.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Location = New Point(7, 50)
        Label16.Name = "Label16"
        Label16.Size = New Size(57, 15)
        Label16.TabIndex = 9
        Label16.Text = "Stage File"
        Label16.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Location = New Point(20, 74)
        Label12.Name = "Label12"
        Label12.Size = New Size(44, 15)
        Label12.TabIndex = 13
        Label12.Text = "Banner"
        Label12.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' THBackBMP
        ' 
        THBackBMP.Dock = DockStyle.Fill
        THBackBMP.Location = New Point(67, 94)
        THBackBMP.Margin = New Padding(0)
        THBackBMP.Name = "THBackBMP"
        THBackBMP.Size = New Size(88, 23)
        THBackBMP.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New Point(4, 98)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 15)
        Label11.TabIndex = 16
        Label11.Text = "Back BMP"
        Label11.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' THBanner
        ' 
        THBanner.Dock = DockStyle.Fill
        THBanner.Location = New Point(67, 70)
        THBanner.Margin = New Padding(0)
        THBanner.Name = "THBanner"
        THBanner.Size = New Size(88, 23)
        THBanner.TabIndex = 19
        ' 
        ' THStageFile
        ' 
        THStageFile.Dock = DockStyle.Fill
        THStageFile.Location = New Point(67, 46)
        THStageFile.Margin = New Padding(0)
        THStageFile.Name = "THStageFile"
        THStageFile.Size = New Size(88, 23)
        THStageFile.TabIndex = 18
        ' 
        ' THSubTitle
        ' 
        POHeaderPart2.SetColumnSpan(THSubTitle, 2)
        THSubTitle.Dock = DockStyle.Fill
        THSubTitle.Location = New Point(67, 0)
        THSubTitle.Margin = New Padding(0)
        THSubTitle.Name = "THSubTitle"
        THSubTitle.Size = New Size(116, 23)
        THSubTitle.TabIndex = 6
        ' 
        ' THSubArtist
        ' 
        POHeaderPart2.SetColumnSpan(THSubArtist, 2)
        THSubArtist.Dock = DockStyle.Fill
        THSubArtist.Location = New Point(67, 23)
        THSubArtist.Margin = New Padding(0)
        THSubArtist.Name = "THSubArtist"
        THSubArtist.Size = New Size(116, 23)
        THSubArtist.TabIndex = 7
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Right
        Label26.AutoSize = True
        Label26.Location = New Point(13, 214)
        Label26.Name = "Label26"
        Label26.Size = New Size(51, 15)
        Label26.TabIndex = 29
        Label26.Text = "#WAV00"
        Label26.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label27
        ' 
        Label27.Anchor = AnchorStyles.Right
        Label27.AutoSize = True
        Label27.Location = New Point(13, 238)
        Label27.Name = "Label27"
        Label27.Size = New Size(51, 15)
        Label27.TabIndex = 32
        Label27.Text = "#BMP00"
        Label27.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' THLandMine
        ' 
        THLandMine.Dock = DockStyle.Fill
        THLandMine.Location = New Point(67, 210)
        THLandMine.Margin = New Padding(0)
        THLandMine.Name = "THLandMine"
        THLandMine.Size = New Size(88, 23)
        THLandMine.TabIndex = 30
        ' 
        ' BHLandMine
        ' 
        BHLandMine.Dock = DockStyle.Fill
        BHLandMine.FlatStyle = FlatStyle.System
        BHLandMine.Location = New Point(158, 210)
        BHLandMine.Margin = New Padding(3, 0, 0, 0)
        BHLandMine.Name = "BHLandMine"
        BHLandMine.Size = New Size(25, 24)
        BHLandMine.TabIndex = 31
        BHLandMine.Text = "..."
        BHLandMine.UseVisualStyleBackColor = True
        ' 
        ' THMissBMP
        ' 
        THMissBMP.Dock = DockStyle.Fill
        THMissBMP.Location = New Point(67, 234)
        THMissBMP.Margin = New Padding(0)
        THMissBMP.Name = "THMissBMP"
        THMissBMP.Size = New Size(88, 23)
        THMissBMP.TabIndex = 33
        ' 
        ' BHMissBMP
        ' 
        BHMissBMP.Dock = DockStyle.Fill
        BHMissBMP.FlatStyle = FlatStyle.System
        BHMissBMP.Location = New Point(158, 234)
        BHMissBMP.Margin = New Padding(3, 0, 0, 0)
        BHMissBMP.Name = "BHMissBMP"
        BHMissBMP.Size = New Size(25, 24)
        BHMissBMP.TabIndex = 34
        BHMissBMP.Text = "..."
        BHMissBMP.UseVisualStyleBackColor = True
        ' 
        ' Label28
        ' 
        Label28.Anchor = AnchorStyles.Right
        Label28.AutoSize = True
        Label28.Location = New Point(16, 262)
        Label28.Name = "Label28"
        Label28.Size = New Size(48, 15)
        Label28.TabIndex = 35
        Label28.Text = "Preview"
        Label28.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label29
        ' 
        Label29.Anchor = AnchorStyles.Right
        Label29.AutoSize = True
        Label29.Location = New Point(11, 284)
        Label29.Name = "Label29"
        Label29.Size = New Size(53, 15)
        Label29.TabIndex = 38
        Label29.Text = "LNmode"
        Label29.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' THPreview
        ' 
        THPreview.Dock = DockStyle.Fill
        THPreview.Location = New Point(67, 258)
        THPreview.Margin = New Padding(0)
        THPreview.Name = "THPreview"
        THPreview.Size = New Size(88, 23)
        THPreview.TabIndex = 36
        ' 
        ' BHPreview
        ' 
        BHPreview.Dock = DockStyle.Fill
        BHPreview.FlatStyle = FlatStyle.System
        BHPreview.Location = New Point(158, 258)
        BHPreview.Margin = New Padding(3, 0, 0, 0)
        BHPreview.Name = "BHPreview"
        BHPreview.Size = New Size(25, 24)
        BHPreview.TabIndex = 37
        BHPreview.Text = "..."
        BHPreview.UseVisualStyleBackColor = True
        ' 
        ' CHLnmode
        ' 
        POHeaderPart2.SetColumnSpan(CHLnmode, 2)
        CHLnmode.Dock = DockStyle.Top
        CHLnmode.DropDownStyle = ComboBoxStyle.DropDownList
        CHLnmode.FlatStyle = FlatStyle.System
        CHLnmode.Items.AddRange(New Object() {"Selectable", "LN only", "CN only", "HN only"})
        CHLnmode.Location = New Point(67, 282)
        CHLnmode.Margin = New Padding(0)
        CHLnmode.Name = "CHLnmode"
        CHLnmode.Size = New Size(116, 23)
        CHLnmode.TabIndex = 39
        ' 
        ' POHeaderExpander
        ' 
        POHeaderExpander.Appearance = Appearance.Button
        POHeaderExpander.AutoSize = True
        POHeaderExpander.Cursor = Cursors.Hand
        POHeaderExpander.Dock = DockStyle.Top
        POHeaderExpander.FlatAppearance.BorderSize = 0
        POHeaderExpander.FlatStyle = FlatStyle.Popup
        POHeaderExpander.Location = New Point(0, 181)
        POHeaderExpander.Margin = New Padding(0)
        POHeaderExpander.Name = "POHeaderExpander"
        POHeaderExpander.Size = New Size(183, 25)
        POHeaderExpander.TabIndex = 26
        POHeaderExpander.TabStop = False
        POHeaderExpander.Text = "Expand..."
        POHeaderExpander.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POHeaderExpander.UseVisualStyleBackColor = False
        ' 
        ' POHeaderPart1
        ' 
        POHeaderPart1.AutoSize = True
        POHeaderPart1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POHeaderPart1.ColumnCount = 3
        POHeaderPart1.ColumnStyles.Add(New ColumnStyle())
        POHeaderPart1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        POHeaderPart1.ColumnStyles.Add(New ColumnStyle())
        POHeaderPart1.Controls.Add(Label3, 0, 0)
        POHeaderPart1.Controls.Add(THPlayLevel, 1, 6)
        POHeaderPart1.Controls.Add(CHRank, 1, 5)
        POHeaderPart1.Controls.Add(Label10, 0, 5)
        POHeaderPart1.Controls.Add(CHPlayer, 1, 4)
        POHeaderPart1.Controls.Add(Label4, 0, 1)
        POHeaderPart1.Controls.Add(THGenre, 1, 2)
        POHeaderPart1.Controls.Add(THBPM, 1, 3)
        POHeaderPart1.Controls.Add(Label2, 0, 2)
        POHeaderPart1.Controls.Add(THArtist, 1, 1)
        POHeaderPart1.Controls.Add(THTitle, 1, 0)
        POHeaderPart1.Controls.Add(Label9, 0, 3)
        POHeaderPart1.Controls.Add(Label8, 0, 4)
        POHeaderPart1.Controls.Add(Label6, 0, 6)
        POHeaderPart1.Controls.Add(THTotal, 1, 7)
        POHeaderPart1.Controls.Add(Label20, 0, 7)
        POHeaderPart1.Controls.Add(Label25, 2, 7)
        POHeaderPart1.Dock = DockStyle.Top
        POHeaderPart1.Location = New Point(0, 0)
        POHeaderPart1.Name = "POHeaderPart1"
        POHeaderPart1.RowCount = 8
        POHeaderPart1.RowStyles.Add(New RowStyle())
        POHeaderPart1.RowStyles.Add(New RowStyle())
        POHeaderPart1.RowStyles.Add(New RowStyle())
        POHeaderPart1.RowStyles.Add(New RowStyle())
        POHeaderPart1.RowStyles.Add(New RowStyle())
        POHeaderPart1.RowStyles.Add(New RowStyle())
        POHeaderPart1.RowStyles.Add(New RowStyle())
        POHeaderPart1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        POHeaderPart1.Size = New Size(183, 181)
        POHeaderPart1.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(33, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 15)
        Label3.TabIndex = 6
        Label3.Text = "Title"
        Label3.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' THPlayLevel
        ' 
        POHeaderPart1.SetColumnSpan(THPlayLevel, 2)
        THPlayLevel.Dock = DockStyle.Fill
        THPlayLevel.Location = New Point(65, 138)
        THPlayLevel.Margin = New Padding(0)
        THPlayLevel.Name = "THPlayLevel"
        THPlayLevel.Size = New Size(118, 23)
        THPlayLevel.TabIndex = 8
        ' 
        ' CHRank
        ' 
        POHeaderPart1.SetColumnSpan(CHRank, 2)
        CHRank.Dock = DockStyle.Top
        CHRank.DropDownStyle = ComboBoxStyle.DropDownList
        CHRank.FlatStyle = FlatStyle.System
        CHRank.Items.AddRange(New Object() {"0 - Very Hard", "1 - Hard", "2 - Normal", "3 - Easy", "4 - Very Easy"})
        CHRank.Location = New Point(65, 115)
        CHRank.Margin = New Padding(0)
        CHRank.Name = "CHRank"
        CHRank.Size = New Size(118, 23)
        CHRank.TabIndex = 15
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(29, 119)
        Label10.Name = "Label10"
        Label10.Size = New Size(33, 15)
        Label10.TabIndex = 16
        Label10.Text = "Rank"
        Label10.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' CHPlayer
        ' 
        POHeaderPart1.SetColumnSpan(CHPlayer, 2)
        CHPlayer.Dock = DockStyle.Top
        CHPlayer.DropDownStyle = ComboBoxStyle.DropDownList
        CHPlayer.FlatStyle = FlatStyle.System
        CHPlayer.Items.AddRange(New Object() {"1 - Single Play", "2 - Couple Play", "3 - Double Play"})
        CHPlayer.Location = New Point(65, 92)
        CHPlayer.Margin = New Padding(0)
        CHPlayer.Name = "CHPlayer"
        CHPlayer.Size = New Size(118, 23)
        CHPlayer.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(27, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 7
        Label4.Text = "Artist"
        Label4.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' THGenre
        ' 
        POHeaderPart1.SetColumnSpan(THGenre, 2)
        THGenre.Dock = DockStyle.Fill
        THGenre.Location = New Point(65, 46)
        THGenre.Margin = New Padding(0)
        THGenre.Name = "THGenre"
        THGenre.Size = New Size(118, 23)
        THGenre.TabIndex = 5
        ' 
        ' THBPM
        ' 
        POHeaderPart1.SetColumnSpan(THBPM, 2)
        THBPM.DecimalPlaces = 4
        THBPM.Dock = DockStyle.Fill
        THBPM.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        THBPM.Location = New Point(65, 69)
        THBPM.Margin = New Padding(0)
        THBPM.Maximum = New Decimal(New Integer() {655359999, 0, 0, 262144})
        THBPM.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
        THBPM.Name = "THBPM"
        THBPM.Size = New Size(118, 23)
        THBPM.TabIndex = 10
        THBPM.Value = New Decimal(New Integer() {120, 0, 0, 0})
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(24, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 5
        Label2.Text = "Genre"
        Label2.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' THArtist
        ' 
        POHeaderPart1.SetColumnSpan(THArtist, 2)
        THArtist.Dock = DockStyle.Fill
        THArtist.Location = New Point(65, 23)
        THArtist.Margin = New Padding(0)
        THArtist.Name = "THArtist"
        THArtist.Size = New Size(118, 23)
        THArtist.TabIndex = 7
        ' 
        ' THTitle
        ' 
        POHeaderPart1.SetColumnSpan(THTitle, 2)
        THTitle.Dock = DockStyle.Fill
        THTitle.Location = New Point(65, 0)
        THTitle.Margin = New Padding(0)
        THTitle.Name = "THTitle"
        THTitle.Size = New Size(118, 23)
        THTitle.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(30, 73)
        Label9.Name = "Label9"
        Label9.Size = New Size(32, 15)
        Label9.TabIndex = 9
        Label9.Text = "BPM"
        Label9.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(23, 96)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 15)
        Label8.TabIndex = 13
        Label8.Text = "Player"
        Label8.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(3, 142)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 15)
        Label6.TabIndex = 8
        Label6.Text = "Play Level"
        Label6.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' THTotal
        ' 
        THTotal.Dock = DockStyle.Fill
        THTotal.Location = New Point(65, 161)
        THTotal.Margin = New Padding(0)
        THTotal.Name = "THTotal"
        THTotal.Size = New Size(90, 23)
        THTotal.TabIndex = 5
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Right
        Label20.AutoSize = True
        Label20.Location = New Point(30, 163)
        Label20.Name = "Label20"
        Label20.Size = New Size(32, 15)
        Label20.TabIndex = 5
        Label20.Text = "Total"
        Label20.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Dock = DockStyle.Fill
        Label25.Location = New Point(158, 161)
        Label25.Margin = New Padding(3, 0, 0, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(25, 20)
        Label25.TabIndex = 23
        Label25.Text = "(%)"
        Label25.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' POHeaderSwitch
        ' 
        POHeaderSwitch.Appearance = Appearance.Button
        POHeaderSwitch.BackColor = SystemColors.Control
        POHeaderSwitch.Checked = True
        POHeaderSwitch.CheckState = CheckState.Checked
        POHeaderSwitch.Cursor = Cursors.Hand
        POHeaderSwitch.Dock = DockStyle.Top
        POHeaderSwitch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        POHeaderSwitch.Location = New Point(0, 0)
        POHeaderSwitch.Name = "POHeaderSwitch"
        POHeaderSwitch.Size = New Size(183, 20)
        POHeaderSwitch.TabIndex = 1
        POHeaderSwitch.TabStop = False
        POHeaderSwitch.Text = "Header"
        POHeaderSwitch.TextAlign = Drawing.ContentAlignment.MiddleCenter
        POHeaderSwitch.UseCompatibleTextRendering = True
        POHeaderSwitch.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 15
        ' 
        ' Menu1
        ' 
        Menu1.Items.AddRange(New ToolStripItem() {MInsert, MRemove})
        Menu1.Name = "Menu1"
        Menu1.Size = New Size(179, 48)
        ' 
        ' MInsert
        ' 
        MInsert.Image = CType(resources.GetObject("MInsert.Image"), Image)
        MInsert.Name = "MInsert"
        MInsert.Size = New Size(178, 22)
        MInsert.Text = "Insert Measure"
        ' 
        ' MRemove
        ' 
        MRemove.Image = CType(resources.GetObject("MRemove.Image"), Image)
        MRemove.Name = "MRemove"
        MRemove.Size = New Size(178, 22)
        MRemove.Text = "Remove Measure"
        ' 
        ' AutoSaveTimer
        ' 
        AutoSaveTimer.Enabled = True
        AutoSaveTimer.Interval = 300000
        ' 
        ' mnMain
        ' 
        mnMain.AccessibleRole = AccessibleRole.MenuBar
        mnMain.BackgroundImageLayout = ImageLayout.Stretch
        mnMain.Dock = DockStyle.None
        mnMain.GripMargin = New Padding(2)
        mnMain.Items.AddRange(New ToolStripItem() {mnFile, mnEdit, mnSys, mnOptions, mnConversion, mnPreview})
        mnMain.LayoutStyle = ToolStripLayoutStyle.Flow
        mnMain.Location = New Point(0, 25)
        mnMain.Name = "mnMain"
        mnMain.Size = New Size(876, 25)
        mnMain.TabIndex = 57
        ' 
        ' mnFile
        ' 
        mnFile.DropDownItems.AddRange(New ToolStripItem() {mnNew, mnOpen, mnImportSM, mnImportIBMSC, ToolStripSeparator14, mnSave, mnSaveAs, mnExportIBMSC, mnExportBMSON, ToolStripSeparator15, mnOpenR0, mnOpenR1, mnOpenR2, mnOpenR3, mnOpenR4, ToolStripSeparator16, mnQuit})
        mnFile.Name = "mnFile"
        mnFile.Size = New Size(39, 21)
        mnFile.Text = "&File"
        ' 
        ' mnNew
        ' 
        mnNew.Image = CType(resources.GetObject("mnNew.Image"), Image)
        mnNew.Name = "mnNew"
        mnNew.ShortcutKeys = Keys.Control Or Keys.N
        mnNew.Size = New Size(215, 22)
        mnNew.Text = "&New"
        ' 
        ' mnOpen
        ' 
        mnOpen.Image = CType(resources.GetObject("mnOpen.Image"), Image)
        mnOpen.Name = "mnOpen"
        mnOpen.ShortcutKeys = Keys.Control Or Keys.O
        mnOpen.Size = New Size(215, 22)
        mnOpen.Text = "&Open"
        ' 
        ' mnImportSM
        ' 
        mnImportSM.Image = CType(resources.GetObject("mnImportSM.Image"), Image)
        mnImportSM.Name = "mnImportSM"
        mnImportSM.Size = New Size(215, 22)
        mnImportSM.Text = "Import from .S&M file"
        ' 
        ' mnImportIBMSC
        ' 
        mnImportIBMSC.Image = CType(resources.GetObject("mnImportIBMSC.Image"), Image)
        mnImportIBMSC.Name = "mnImportIBMSC"
        mnImportIBMSC.Size = New Size(215, 22)
        mnImportIBMSC.Text = "Import from .&IBMSC file"
        ' 
        ' ToolStripSeparator14
        ' 
        ToolStripSeparator14.Name = "ToolStripSeparator14"
        ToolStripSeparator14.Size = New Size(212, 6)
        ' 
        ' mnSave
        ' 
        mnSave.Image = CType(resources.GetObject("mnSave.Image"), Image)
        mnSave.Name = "mnSave"
        mnSave.ShortcutKeys = Keys.Control Or Keys.S
        mnSave.Size = New Size(215, 22)
        mnSave.Text = "&Save"
        ' 
        ' mnSaveAs
        ' 
        mnSaveAs.Image = CType(resources.GetObject("mnSaveAs.Image"), Image)
        mnSaveAs.Name = "mnSaveAs"
        mnSaveAs.Size = New Size(215, 22)
        mnSaveAs.Text = "Save &As..."
        ' 
        ' mnExportIBMSC
        ' 
        mnExportIBMSC.Image = CType(resources.GetObject("mnExportIBMSC.Image"), Image)
        mnExportIBMSC.Name = "mnExportIBMSC"
        mnExportIBMSC.Size = New Size(215, 22)
        mnExportIBMSC.Text = "&Export .IBMSC file"
        ' 
        ' mnExportBMSON
        ' 
        mnExportBMSON.Image = CType(resources.GetObject("mnExportBMSON.Image"), Image)
        mnExportBMSON.Name = "mnExportBMSON"
        mnExportBMSON.Size = New Size(215, 22)
        mnExportBMSON.Text = "Export .&BMSON file"
        ' 
        ' ToolStripSeparator15
        ' 
        ToolStripSeparator15.Name = "ToolStripSeparator15"
        ToolStripSeparator15.Size = New Size(212, 6)
        ' 
        ' mnOpenR0
        ' 
        mnOpenR0.Enabled = False
        mnOpenR0.Name = "mnOpenR0"
        mnOpenR0.Size = New Size(215, 22)
        mnOpenR0.Tag = "0"
        mnOpenR0.Text = "Recent #0"
        ' 
        ' mnOpenR1
        ' 
        mnOpenR1.Enabled = False
        mnOpenR1.Name = "mnOpenR1"
        mnOpenR1.Size = New Size(215, 22)
        mnOpenR1.Tag = "1"
        mnOpenR1.Text = "Recent #1"
        ' 
        ' mnOpenR2
        ' 
        mnOpenR2.Enabled = False
        mnOpenR2.Name = "mnOpenR2"
        mnOpenR2.Size = New Size(215, 22)
        mnOpenR2.Tag = "2"
        mnOpenR2.Text = "Recent #2"
        ' 
        ' mnOpenR3
        ' 
        mnOpenR3.Enabled = False
        mnOpenR3.Name = "mnOpenR3"
        mnOpenR3.Size = New Size(215, 22)
        mnOpenR3.Tag = "3"
        mnOpenR3.Text = "Recent #3"
        ' 
        ' mnOpenR4
        ' 
        mnOpenR4.Enabled = False
        mnOpenR4.Name = "mnOpenR4"
        mnOpenR4.Size = New Size(215, 22)
        mnOpenR4.Tag = "4"
        mnOpenR4.Text = "Recent #4"
        ' 
        ' ToolStripSeparator16
        ' 
        ToolStripSeparator16.Name = "ToolStripSeparator16"
        ToolStripSeparator16.Size = New Size(212, 6)
        ' 
        ' mnQuit
        ' 
        mnQuit.Name = "mnQuit"
        mnQuit.Size = New Size(215, 22)
        mnQuit.Text = "&Quit"
        ' 
        ' mnEdit
        ' 
        mnEdit.DropDownItems.AddRange(New ToolStripItem() {mnUndo, mnRedo, ToolStripSeparator17, mnCut, mnCopy, mnPaste, mnDelete, mnSelectAll, mnGotoMeasure, ToolStripSeparator18, mnFind, mnStatistics, ToolStripSeparator19, mnTimeSelect, mnSelect, mnWrite, ToolStripSeparator23, mnMyO2})
        mnEdit.Name = "mnEdit"
        mnEdit.Size = New Size(42, 21)
        mnEdit.Text = "&Edit"
        ' 
        ' mnUndo
        ' 
        mnUndo.Enabled = False
        mnUndo.Image = CType(resources.GetObject("mnUndo.Image"), Image)
        mnUndo.Name = "mnUndo"
        mnUndo.ShortcutKeyDisplayString = "Ctrl+Z"
        mnUndo.Size = New Size(252, 22)
        mnUndo.Text = "&Undo"
        ' 
        ' mnRedo
        ' 
        mnRedo.Enabled = False
        mnRedo.Image = CType(resources.GetObject("mnRedo.Image"), Image)
        mnRedo.Name = "mnRedo"
        mnRedo.ShortcutKeyDisplayString = "Ctrl+Y"
        mnRedo.Size = New Size(252, 22)
        mnRedo.Text = "&Redo"
        ' 
        ' ToolStripSeparator17
        ' 
        ToolStripSeparator17.Name = "ToolStripSeparator17"
        ToolStripSeparator17.Size = New Size(249, 6)
        ' 
        ' mnCut
        ' 
        mnCut.Image = CType(resources.GetObject("mnCut.Image"), Image)
        mnCut.Name = "mnCut"
        mnCut.ShortcutKeyDisplayString = "Ctrl+X"
        mnCut.Size = New Size(252, 22)
        mnCut.Text = "Cu&t"
        ' 
        ' mnCopy
        ' 
        mnCopy.Image = CType(resources.GetObject("mnCopy.Image"), Image)
        mnCopy.Name = "mnCopy"
        mnCopy.ShortcutKeyDisplayString = "Ctrl+C"
        mnCopy.Size = New Size(252, 22)
        mnCopy.Text = "&Copy"
        ' 
        ' mnPaste
        ' 
        mnPaste.Image = CType(resources.GetObject("mnPaste.Image"), Image)
        mnPaste.Name = "mnPaste"
        mnPaste.ShortcutKeyDisplayString = "Ctrl+V"
        mnPaste.Size = New Size(252, 22)
        mnPaste.Text = "&Paste"
        ' 
        ' mnDelete
        ' 
        mnDelete.Image = CType(resources.GetObject("mnDelete.Image"), Image)
        mnDelete.Name = "mnDelete"
        mnDelete.ShortcutKeyDisplayString = "Del"
        mnDelete.Size = New Size(252, 22)
        mnDelete.Text = "De&lete"
        ' 
        ' mnSelectAll
        ' 
        mnSelectAll.Name = "mnSelectAll"
        mnSelectAll.ShortcutKeyDisplayString = "Ctrl+A"
        mnSelectAll.Size = New Size(252, 22)
        mnSelectAll.Text = "Select &All"
        ' 
        ' mnGotoMeasure
        ' 
        mnGotoMeasure.Name = "mnGotoMeasure"
        mnGotoMeasure.ShortcutKeys = Keys.Control Or Keys.G
        mnGotoMeasure.Size = New Size(252, 22)
        mnGotoMeasure.Text = "Go To Measure..."
        ' 
        ' ToolStripSeparator18
        ' 
        ToolStripSeparator18.Name = "ToolStripSeparator18"
        ToolStripSeparator18.Size = New Size(249, 6)
        ' 
        ' mnFind
        ' 
        mnFind.Image = CType(resources.GetObject("mnFind.Image"), Image)
        mnFind.Name = "mnFind"
        mnFind.ShortcutKeyDisplayString = "Ctrl+F"
        mnFind.Size = New Size(252, 22)
        mnFind.Text = "&Find / Delete / Replace"
        ' 
        ' mnStatistics
        ' 
        mnStatistics.Image = CType(resources.GetObject("mnStatistics.Image"), Image)
        mnStatistics.Name = "mnStatistics"
        mnStatistics.ShortcutKeyDisplayString = "Ctrl+T"
        mnStatistics.Size = New Size(252, 22)
        mnStatistics.Text = "St&atistics"
        ' 
        ' ToolStripSeparator19
        ' 
        ToolStripSeparator19.Name = "ToolStripSeparator19"
        ToolStripSeparator19.Size = New Size(249, 6)
        ' 
        ' mnTimeSelect
        ' 
        mnTimeSelect.CheckOnClick = True
        mnTimeSelect.Image = CType(resources.GetObject("mnTimeSelect.Image"), Image)
        mnTimeSelect.Name = "mnTimeSelect"
        mnTimeSelect.ShortcutKeys = Keys.F1
        mnTimeSelect.Size = New Size(252, 22)
        mnTimeSelect.Text = "T&ime Selection Tool"
        ' 
        ' mnSelect
        ' 
        mnSelect.Checked = True
        mnSelect.CheckOnClick = True
        mnSelect.CheckState = CheckState.Checked
        mnSelect.Image = CType(resources.GetObject("mnSelect.Image"), Image)
        mnSelect.Name = "mnSelect"
        mnSelect.ShortcutKeys = Keys.F2
        mnSelect.Size = New Size(252, 22)
        mnSelect.Text = "&Select Tool"
        ' 
        ' mnWrite
        ' 
        mnWrite.CheckOnClick = True
        mnWrite.Image = CType(resources.GetObject("mnWrite.Image"), Image)
        mnWrite.Name = "mnWrite"
        mnWrite.ShortcutKeys = Keys.F3
        mnWrite.Size = New Size(252, 22)
        mnWrite.Text = "&Write Tool"
        ' 
        ' ToolStripSeparator23
        ' 
        ToolStripSeparator23.Name = "ToolStripSeparator23"
        ToolStripSeparator23.Size = New Size(249, 6)
        ' 
        ' mnMyO2
        ' 
        mnMyO2.Image = CType(resources.GetObject("mnMyO2.Image"), Image)
        mnMyO2.Name = "mnMyO2"
        mnMyO2.Size = New Size(252, 22)
        mnMyO2.Text = "MyO2 ToolBox (Chinese Only)"
        ' 
        ' mnSys
        ' 
        mnSys.DropDownItems.AddRange(New ToolStripItem() {mnSMenu, mnSTB, mnSOP, mnSStatus, mnSLSplitter, mnSRSplitter, ToolStripSeparator21, CGShow, CGShowS, CGShowBG, CGShowM, CGShowMB, CGShowV, CGShowC, ToolStripSeparator22, CGBPM, CGSTOP, CGSCROLL, CGBLP})
        mnSys.Name = "mnSys"
        mnSys.Size = New Size(47, 21)
        mnSys.Text = "&View"
        ' 
        ' mnSMenu
        ' 
        mnSMenu.Checked = True
        mnSMenu.CheckOnClick = True
        mnSMenu.CheckState = CheckState.Checked
        mnSMenu.Name = "mnSMenu"
        mnSMenu.Size = New Size(186, 22)
        mnSMenu.Text = "&Main Menu"
        mnSMenu.Visible = False
        ' 
        ' mnSTB
        ' 
        mnSTB.Checked = True
        mnSTB.CheckOnClick = True
        mnSTB.CheckState = CheckState.Checked
        mnSTB.Name = "mnSTB"
        mnSTB.Size = New Size(186, 22)
        mnSTB.Text = "&ToolBar"
        ' 
        ' mnSOP
        ' 
        mnSOP.Checked = True
        mnSOP.CheckOnClick = True
        mnSOP.CheckState = CheckState.Checked
        mnSOP.Name = "mnSOP"
        mnSOP.Size = New Size(186, 22)
        mnSOP.Text = "&Options Panel"
        ' 
        ' mnSStatus
        ' 
        mnSStatus.Checked = True
        mnSStatus.CheckOnClick = True
        mnSStatus.CheckState = CheckState.Checked
        mnSStatus.Name = "mnSStatus"
        mnSStatus.Size = New Size(186, 22)
        mnSStatus.Text = "&Status Bar"
        ' 
        ' mnSLSplitter
        ' 
        mnSLSplitter.CheckOnClick = True
        mnSLSplitter.Name = "mnSLSplitter"
        mnSLSplitter.Size = New Size(186, 22)
        mnSLSplitter.Text = "&Left Splitter"
        ' 
        ' mnSRSplitter
        ' 
        mnSRSplitter.CheckOnClick = True
        mnSRSplitter.Name = "mnSRSplitter"
        mnSRSplitter.Size = New Size(186, 22)
        mnSRSplitter.Text = "&Right Splitter"
        ' 
        ' ToolStripSeparator21
        ' 
        ToolStripSeparator21.Name = "ToolStripSeparator21"
        ToolStripSeparator21.Size = New Size(183, 6)
        ' 
        ' CGShow
        ' 
        CGShow.Checked = True
        CGShow.CheckOnClick = True
        CGShow.CheckState = CheckState.Checked
        CGShow.Name = "CGShow"
        CGShow.Size = New Size(186, 22)
        CGShow.Text = "Grid"
        ' 
        ' CGShowS
        ' 
        CGShowS.Checked = True
        CGShowS.CheckOnClick = True
        CGShowS.CheckState = CheckState.Checked
        CGShowS.Name = "CGShowS"
        CGShowS.Size = New Size(186, 22)
        CGShowS.Text = "Sub"
        ' 
        ' CGShowBG
        ' 
        CGShowBG.Checked = True
        CGShowBG.CheckOnClick = True
        CGShowBG.CheckState = CheckState.Checked
        CGShowBG.Name = "CGShowBG"
        CGShowBG.Size = New Size(186, 22)
        CGShowBG.Text = "BackGround"
        ' 
        ' CGShowM
        ' 
        CGShowM.Checked = True
        CGShowM.CheckOnClick = True
        CGShowM.CheckState = CheckState.Checked
        CGShowM.Name = "CGShowM"
        CGShowM.Size = New Size(186, 22)
        CGShowM.Text = "Measure Index"
        ' 
        ' CGShowMB
        ' 
        CGShowMB.Checked = True
        CGShowMB.CheckOnClick = True
        CGShowMB.CheckState = CheckState.Checked
        CGShowMB.Name = "CGShowMB"
        CGShowMB.Size = New Size(186, 22)
        CGShowMB.Text = "Measure Line"
        ' 
        ' CGShowV
        ' 
        CGShowV.Checked = True
        CGShowV.CheckOnClick = True
        CGShowV.CheckState = CheckState.Checked
        CGShowV.Name = "CGShowV"
        CGShowV.Size = New Size(186, 22)
        CGShowV.Text = "Vertical Line"
        ' 
        ' CGShowC
        ' 
        CGShowC.Checked = True
        CGShowC.CheckOnClick = True
        CGShowC.CheckState = CheckState.Checked
        CGShowC.Name = "CGShowC"
        CGShowC.Size = New Size(186, 22)
        CGShowC.Text = "Column Caption"
        ' 
        ' ToolStripSeparator22
        ' 
        ToolStripSeparator22.Name = "ToolStripSeparator22"
        ToolStripSeparator22.Size = New Size(183, 6)
        ' 
        ' CGBPM
        ' 
        CGBPM.Checked = True
        CGBPM.CheckOnClick = True
        CGBPM.CheckState = CheckState.Checked
        CGBPM.Name = "CGBPM"
        CGBPM.Size = New Size(186, 22)
        CGBPM.Text = "BPM"
        ' 
        ' CGSTOP
        ' 
        CGSTOP.Checked = True
        CGSTOP.CheckOnClick = True
        CGSTOP.CheckState = CheckState.Checked
        CGSTOP.Name = "CGSTOP"
        CGSTOP.Size = New Size(186, 22)
        CGSTOP.Text = "STOP"
        ' 
        ' CGSCROLL
        ' 
        CGSCROLL.Checked = True
        CGSCROLL.CheckOnClick = True
        CGSCROLL.CheckState = CheckState.Checked
        CGSCROLL.Name = "CGSCROLL"
        CGSCROLL.Size = New Size(186, 22)
        CGSCROLL.Text = "SCROLL"
        ' 
        ' CGBLP
        ' 
        CGBLP.Checked = True
        CGBLP.CheckOnClick = True
        CGBLP.CheckState = CheckState.Checked
        CGBLP.Name = "CGBLP"
        CGBLP.Size = New Size(186, 22)
        CGBLP.Text = "BGA / Layer / Poor"
        ' 
        ' mnOptions
        ' 
        mnOptions.DropDownItems.AddRange(New ToolStripItem() {mnNTInput, mnErrorCheck, mnPreviewOnClick, mnShowFileName, mnChangePlaySide, ToolStripSeparator20, mnGOptions, mnVOptions, mnPOptions, mnLanguage, mnTheme})
        mnOptions.Name = "mnOptions"
        mnOptions.Size = New Size(66, 21)
        mnOptions.Text = "&Options"
        ' 
        ' mnNTInput
        ' 
        mnNTInput.Checked = True
        mnNTInput.CheckOnClick = True
        mnNTInput.CheckState = CheckState.Checked
        mnNTInput.Image = CType(resources.GetObject("mnNTInput.Image"), Image)
        mnNTInput.Name = "mnNTInput"
        mnNTInput.ShortcutKeys = Keys.F8
        mnNTInput.Size = New Size(247, 22)
        mnNTInput.Text = "L&N Input Style - NT/BMSE"
        ' 
        ' mnErrorCheck
        ' 
        mnErrorCheck.Checked = True
        mnErrorCheck.CheckOnClick = True
        mnErrorCheck.CheckState = CheckState.Checked
        mnErrorCheck.Image = CType(resources.GetObject("mnErrorCheck.Image"), Image)
        mnErrorCheck.Name = "mnErrorCheck"
        mnErrorCheck.Size = New Size(247, 22)
        mnErrorCheck.Text = "&Error Check"
        ' 
        ' mnPreviewOnClick
        ' 
        mnPreviewOnClick.Checked = True
        mnPreviewOnClick.CheckOnClick = True
        mnPreviewOnClick.CheckState = CheckState.Checked
        mnPreviewOnClick.Image = CType(resources.GetObject("mnPreviewOnClick.Image"), Image)
        mnPreviewOnClick.Name = "mnPreviewOnClick"
        mnPreviewOnClick.Size = New Size(247, 22)
        mnPreviewOnClick.Text = "Preview on &Click"
        ' 
        ' mnShowFileName
        ' 
        mnShowFileName.CheckOnClick = True
        mnShowFileName.Image = CType(resources.GetObject("mnShowFileName.Image"), Image)
        mnShowFileName.Name = "mnShowFileName"
        mnShowFileName.Size = New Size(247, 22)
        mnShowFileName.Text = "Show &File Name on Notes"
        ' 
        ' mnChangePlaySide
        ' 
        mnChangePlaySide.CheckOnClick = True
        mnChangePlaySide.Image = CType(resources.GetObject("mnChangePlaySide.Image"), Image)
        mnChangePlaySide.Name = "mnChangePlaySide"
        mnChangePlaySide.Size = New Size(247, 22)
        mnChangePlaySide.Text = "&RightScratch Mode"
        ' 
        ' ToolStripSeparator20
        ' 
        ToolStripSeparator20.Name = "ToolStripSeparator20"
        ToolStripSeparator20.Size = New Size(244, 6)
        ' 
        ' mnGOptions
        ' 
        mnGOptions.Image = CType(resources.GetObject("mnGOptions.Image"), Image)
        mnGOptions.Name = "mnGOptions"
        mnGOptions.Size = New Size(247, 22)
        mnGOptions.Text = "&General Options"
        ' 
        ' mnVOptions
        ' 
        mnVOptions.Image = CType(resources.GetObject("mnVOptions.Image"), Image)
        mnVOptions.Name = "mnVOptions"
        mnVOptions.Size = New Size(247, 22)
        mnVOptions.Text = "&Visual Options"
        ' 
        ' mnPOptions
        ' 
        mnPOptions.Image = CType(resources.GetObject("mnPOptions.Image"), Image)
        mnPOptions.Name = "mnPOptions"
        mnPOptions.Size = New Size(247, 22)
        mnPOptions.Text = "&Player Options"
        ' 
        ' mnConversion
        ' 
        mnConversion.DropDown = cmnConversion
        mnConversion.Name = "mnConversion"
        mnConversion.Size = New Size(91, 21)
        mnConversion.Text = "&Conversions"
        ' 
        ' cmnConversion
        ' 
        cmnConversion.Items.AddRange(New ToolStripItem() {POBLong, POBShort, POBLongShort, ToolStripSeparator10, POBHidden, POBVisible, POBHiddenVisible, ToolStripSeparator11, POBModify, POBMirror})
        cmnConversion.Name = "cmnLanguage"
        cmnConversion.Size = New Size(241, 192)
        ' 
        ' POBLong
        ' 
        POBLong.Enabled = False
        POBLong.Image = CType(resources.GetObject("POBLong.Image"), Image)
        POBLong.Name = "POBLong"
        POBLong.Size = New Size(240, 22)
        POBLong.Text = "→ &Long Note"
        ' 
        ' POBShort
        ' 
        POBShort.Image = CType(resources.GetObject("POBShort.Image"), Image)
        POBShort.Name = "POBShort"
        POBShort.Size = New Size(240, 22)
        POBShort.Text = "→ &Short Note"
        ' 
        ' POBLongShort
        ' 
        POBLongShort.Enabled = False
        POBLongShort.Image = CType(resources.GetObject("POBLongShort.Image"), Image)
        POBLongShort.Name = "POBLongShort"
        POBLongShort.Size = New Size(240, 22)
        POBLongShort.Text = "Long Note ↔ Short Note"
        ' 
        ' ToolStripSeparator10
        ' 
        ToolStripSeparator10.Name = "ToolStripSeparator10"
        ToolStripSeparator10.Size = New Size(237, 6)
        ' 
        ' POBHidden
        ' 
        POBHidden.Image = CType(resources.GetObject("POBHidden.Image"), Image)
        POBHidden.Name = "POBHidden"
        POBHidden.Size = New Size(240, 22)
        POBHidden.Text = "→ &Hidden Note"
        ' 
        ' POBVisible
        ' 
        POBVisible.Image = CType(resources.GetObject("POBVisible.Image"), Image)
        POBVisible.Name = "POBVisible"
        POBVisible.Size = New Size(240, 22)
        POBVisible.Text = "→ &Visible Note"
        ' 
        ' POBHiddenVisible
        ' 
        POBHiddenVisible.Image = CType(resources.GetObject("POBHiddenVisible.Image"), Image)
        POBHiddenVisible.Name = "POBHiddenVisible"
        POBHiddenVisible.Size = New Size(240, 22)
        POBHiddenVisible.Text = "Hidden Note ↔ Visible Note"
        ' 
        ' ToolStripSeparator11
        ' 
        ToolStripSeparator11.Name = "ToolStripSeparator11"
        ToolStripSeparator11.Size = New Size(237, 6)
        ' 
        ' POBModify
        ' 
        POBModify.Image = CType(resources.GetObject("POBModify.Image"), Image)
        POBModify.Name = "POBModify"
        POBModify.Size = New Size(240, 22)
        POBModify.Text = "&Modify Labels"
        ' 
        ' POBMirror
        ' 
        POBMirror.Image = CType(resources.GetObject("POBMirror.Image"), Image)
        POBMirror.Name = "POBMirror"
        POBMirror.Size = New Size(240, 22)
        POBMirror.Text = "Mi&rror"
        ' 
        ' POConvert
        ' 
        POConvert.DisplayStyle = ToolStripItemDisplayStyle.Image
        POConvert.DropDown = cmnConversion
        POConvert.Image = CType(resources.GetObject("POConvert.Image"), Image)
        POConvert.ImageTransparentColor = Color.Magenta
        POConvert.Name = "POConvert"
        POConvert.Size = New Size(29, 22)
        POConvert.Text = "Convert Notes"
        ' 
        ' TBMain
        ' 
        TBMain.AccessibleRole = AccessibleRole.ToolBar
        TBMain.BackgroundImageLayout = ImageLayout.Stretch
        TBMain.Dock = DockStyle.None
        TBMain.Items.AddRange(New ToolStripItem() {TBNew, TBOpen, TBSave, ToolStripSeparator1, TBCut, TBCopy, TBPaste, TBFind, ToolStripSeparator24, TBStatistics, POConvert, TBMyO2, ToolStripSeparator4, TBErrorCheck, TBPreviewOnClick, TBShowFileName, TBChangePlaySide, ToolStripSeparator8, TBNTInput, TBWavIncrease, ToolStripSeparator2, TBUndo, TBRedo, ToolStripSeparator5, TBTimeSelect, TBSelect, TBWrite, ToolStripSeparator3, TBPlayB, TBPlay, TBStop, TBPOptions, ToolStripSeparator7, TBVOptions, TBGOptions, TBLanguage, TBTheme, POBStorm})
        TBMain.Location = New Point(3, 0)
        TBMain.Name = "TBMain"
        TBMain.Size = New Size(774, 25)
        TBMain.TabIndex = 64
        TBMain.Text = "Main Toolbar"
        ' 
        ' TBNew
        ' 
        TBNew.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBNew.Image = CType(resources.GetObject("TBNew.Image"), Image)
        TBNew.ImageTransparentColor = Color.Transparent
        TBNew.Name = "TBNew"
        TBNew.Size = New Size(23, 22)
        TBNew.Text = "New (Ctrl+N)"
        ' 
        ' TBOpen
        ' 
        TBOpen.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBOpen.DropDownItems.AddRange(New ToolStripItem() {TBOpenR0, TBOpenR1, TBOpenR2, TBOpenR3, TBOpenR4, ToolStripSeparator12, TBImportSM, TBImportIBMSC})
        TBOpen.Image = CType(resources.GetObject("TBOpen.Image"), Image)
        TBOpen.ImageTransparentColor = Color.Magenta
        TBOpen.Name = "TBOpen"
        TBOpen.Size = New Size(32, 22)
        TBOpen.Text = "Open (Ctrl+O)"
        ' 
        ' TBOpenR0
        ' 
        TBOpenR0.Enabled = False
        TBOpenR0.Name = "TBOpenR0"
        TBOpenR0.Size = New Size(215, 22)
        TBOpenR0.Tag = "0"
        TBOpenR0.Text = "Recent #0"
        ' 
        ' TBOpenR1
        ' 
        TBOpenR1.Enabled = False
        TBOpenR1.Name = "TBOpenR1"
        TBOpenR1.Size = New Size(215, 22)
        TBOpenR1.Tag = "1"
        TBOpenR1.Text = "Recent #1"
        ' 
        ' TBOpenR2
        ' 
        TBOpenR2.Enabled = False
        TBOpenR2.Name = "TBOpenR2"
        TBOpenR2.Size = New Size(215, 22)
        TBOpenR2.Tag = "2"
        TBOpenR2.Text = "Recent #2"
        ' 
        ' TBOpenR3
        ' 
        TBOpenR3.Enabled = False
        TBOpenR3.Name = "TBOpenR3"
        TBOpenR3.Size = New Size(215, 22)
        TBOpenR3.Tag = "3"
        TBOpenR3.Text = "Recent #3"
        ' 
        ' TBOpenR4
        ' 
        TBOpenR4.Enabled = False
        TBOpenR4.Name = "TBOpenR4"
        TBOpenR4.Size = New Size(215, 22)
        TBOpenR4.Tag = "4"
        TBOpenR4.Text = "Recent #4"
        ' 
        ' ToolStripSeparator12
        ' 
        ToolStripSeparator12.Name = "ToolStripSeparator12"
        ToolStripSeparator12.Size = New Size(212, 6)
        ' 
        ' TBImportSM
        ' 
        TBImportSM.Image = CType(resources.GetObject("TBImportSM.Image"), Image)
        TBImportSM.Name = "TBImportSM"
        TBImportSM.Size = New Size(215, 22)
        TBImportSM.Text = "Import from .SM file"
        ' 
        ' TBImportIBMSC
        ' 
        TBImportIBMSC.Image = CType(resources.GetObject("TBImportIBMSC.Image"), Image)
        TBImportIBMSC.Name = "TBImportIBMSC"
        TBImportIBMSC.Size = New Size(215, 22)
        TBImportIBMSC.Text = "Import from .IBMSC file"
        ' 
        ' TBSave
        ' 
        TBSave.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBSave.DropDownItems.AddRange(New ToolStripItem() {TBSaveAs, TBExportIBMSC, TBExportBMSON})
        TBSave.Image = CType(resources.GetObject("TBSave.Image"), Image)
        TBSave.ImageTransparentColor = Color.Magenta
        TBSave.Name = "TBSave"
        TBSave.Size = New Size(32, 22)
        TBSave.Text = "Save (Ctrl+S)"
        ' 
        ' TBSaveAs
        ' 
        TBSaveAs.Image = CType(resources.GetObject("TBSaveAs.Image"), Image)
        TBSaveAs.Name = "TBSaveAs"
        TBSaveAs.Size = New Size(189, 22)
        TBSaveAs.Text = "Save As..."
        ' 
        ' TBExportIBMSC
        ' 
        TBExportIBMSC.Image = CType(resources.GetObject("TBExportIBMSC.Image"), Image)
        TBExportIBMSC.Name = "TBExportIBMSC"
        TBExportIBMSC.Size = New Size(189, 22)
        TBExportIBMSC.Text = "Export .IBMSC file"
        ' 
        ' TBExportBMSON
        ' 
        TBExportBMSON.Image = CType(resources.GetObject("TBExportBMSON.Image"), Image)
        TBExportBMSON.Name = "TBExportBMSON"
        TBExportBMSON.Size = New Size(189, 22)
        TBExportBMSON.Text = "Export .BMSON file"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' TBCut
        ' 
        TBCut.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBCut.Image = CType(resources.GetObject("TBCut.Image"), Image)
        TBCut.ImageTransparentColor = Color.Magenta
        TBCut.Name = "TBCut"
        TBCut.Size = New Size(23, 22)
        TBCut.Text = "Cut (Ctrl+X)"
        ' 
        ' TBCopy
        ' 
        TBCopy.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBCopy.Image = CType(resources.GetObject("TBCopy.Image"), Image)
        TBCopy.ImageTransparentColor = Color.Magenta
        TBCopy.Name = "TBCopy"
        TBCopy.Size = New Size(23, 22)
        TBCopy.Text = "Copy (Ctrl+C)"
        ' 
        ' TBPaste
        ' 
        TBPaste.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBPaste.Image = CType(resources.GetObject("TBPaste.Image"), Image)
        TBPaste.ImageTransparentColor = Color.Magenta
        TBPaste.Name = "TBPaste"
        TBPaste.Size = New Size(23, 22)
        TBPaste.Text = "Paste (Ctrl+V)"
        ' 
        ' TBFind
        ' 
        TBFind.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBFind.Image = CType(resources.GetObject("TBFind.Image"), Image)
        TBFind.ImageTransparentColor = Color.Magenta
        TBFind.Name = "TBFind"
        TBFind.Size = New Size(23, 22)
        TBFind.Text = "Find / Delete / Replace (Ctrl+F)"
        ' 
        ' ToolStripSeparator24
        ' 
        ToolStripSeparator24.Name = "ToolStripSeparator24"
        ToolStripSeparator24.Size = New Size(6, 25)
        ' 
        ' TBStatistics
        ' 
        TBStatistics.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        TBStatistics.Image = CType(resources.GetObject("TBStatistics.Image"), Image)
        TBStatistics.ImageTransparentColor = Color.Magenta
        TBStatistics.Name = "TBStatistics"
        TBStatistics.Size = New Size(34, 22)
        TBStatistics.Text = "0"
        TBStatistics.ToolTipText = "Statistics (Ctrl+T)"
        ' 
        ' TBMyO2
        ' 
        TBMyO2.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBMyO2.Image = CType(resources.GetObject("TBMyO2.Image"), Image)
        TBMyO2.ImageTransparentColor = Color.Magenta
        TBMyO2.Name = "TBMyO2"
        TBMyO2.Size = New Size(23, 22)
        TBMyO2.Text = "MyO2 ToolBox (Chinese Only)"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 25)
        ' 
        ' TBErrorCheck
        ' 
        TBErrorCheck.Checked = True
        TBErrorCheck.CheckOnClick = True
        TBErrorCheck.CheckState = CheckState.Checked
        TBErrorCheck.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBErrorCheck.Image = CType(resources.GetObject("TBErrorCheck.Image"), Image)
        TBErrorCheck.ImageTransparentColor = Color.Magenta
        TBErrorCheck.Name = "TBErrorCheck"
        TBErrorCheck.Size = New Size(23, 22)
        TBErrorCheck.Text = "Error Check"
        ' 
        ' TBPreviewOnClick
        ' 
        TBPreviewOnClick.Checked = True
        TBPreviewOnClick.CheckOnClick = True
        TBPreviewOnClick.CheckState = CheckState.Checked
        TBPreviewOnClick.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBPreviewOnClick.Image = CType(resources.GetObject("TBPreviewOnClick.Image"), Image)
        TBPreviewOnClick.ImageTransparentColor = Color.Magenta
        TBPreviewOnClick.Name = "TBPreviewOnClick"
        TBPreviewOnClick.Size = New Size(23, 22)
        TBPreviewOnClick.Text = "Preview On Click"
        ' 
        ' TBShowFileName
        ' 
        TBShowFileName.CheckOnClick = True
        TBShowFileName.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBShowFileName.Image = CType(resources.GetObject("TBShowFileName.Image"), Image)
        TBShowFileName.ImageTransparentColor = Color.Magenta
        TBShowFileName.Name = "TBShowFileName"
        TBShowFileName.Size = New Size(23, 22)
        TBShowFileName.Text = "Show File Name on Notes"
        ' 
        ' TBChangePlaySide
        ' 
        TBChangePlaySide.CheckOnClick = True
        TBChangePlaySide.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBChangePlaySide.Image = CType(resources.GetObject("TBChangePlaySide.Image"), Image)
        TBChangePlaySide.ImageTransparentColor = Color.Magenta
        TBChangePlaySide.Name = "TBChangePlaySide"
        TBChangePlaySide.Size = New Size(23, 22)
        TBChangePlaySide.Text = "RightScratch Mode"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(6, 25)
        ' 
        ' TBNTInput
        ' 
        TBNTInput.Checked = True
        TBNTInput.CheckOnClick = True
        TBNTInput.CheckState = CheckState.Checked
        TBNTInput.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBNTInput.Image = CType(resources.GetObject("TBNTInput.Image"), Image)
        TBNTInput.ImageTransparentColor = Color.Magenta
        TBNTInput.Name = "TBNTInput"
        TBNTInput.Size = New Size(23, 22)
        TBNTInput.Text = "LongNote Input Style - NoteTool/BMSE"
        ' 
        ' TBWavIncrease
        ' 
        TBWavIncrease.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBWavIncrease.Image = CType(resources.GetObject("TBWavIncrease.Image"), Image)
        TBWavIncrease.ImageTransparentColor = Color.Magenta
        TBWavIncrease.Name = "TBWavIncrease"
        TBWavIncrease.Size = New Size(23, 22)
        TBWavIncrease.Text = "Autoincrease WAV when writing"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' TBUndo
        ' 
        TBUndo.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBUndo.Enabled = False
        TBUndo.Image = CType(resources.GetObject("TBUndo.Image"), Image)
        TBUndo.ImageTransparentColor = Color.Magenta
        TBUndo.Name = "TBUndo"
        TBUndo.Size = New Size(23, 22)
        TBUndo.Text = "Undo (Ctrl+Z)"
        ' 
        ' TBRedo
        ' 
        TBRedo.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBRedo.Enabled = False
        TBRedo.Image = CType(resources.GetObject("TBRedo.Image"), Image)
        TBRedo.ImageTransparentColor = Color.Magenta
        TBRedo.Name = "TBRedo"
        TBRedo.Size = New Size(23, 22)
        TBRedo.Text = "Redo (Ctrl+Y)"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(6, 25)
        ' 
        ' TBTimeSelect
        ' 
        TBTimeSelect.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBTimeSelect.Image = CType(resources.GetObject("TBTimeSelect.Image"), Image)
        TBTimeSelect.ImageTransparentColor = Color.Magenta
        TBTimeSelect.Name = "TBTimeSelect"
        TBTimeSelect.Size = New Size(23, 22)
        TBTimeSelect.Text = "Time Selection Tool (F1)"
        ' 
        ' TBSelect
        ' 
        TBSelect.Checked = True
        TBSelect.CheckState = CheckState.Checked
        TBSelect.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBSelect.Image = CType(resources.GetObject("TBSelect.Image"), Image)
        TBSelect.ImageTransparentColor = Color.Magenta
        TBSelect.Name = "TBSelect"
        TBSelect.Size = New Size(23, 22)
        TBSelect.Text = "Select Tool (F2)"
        ' 
        ' TBWrite
        ' 
        TBWrite.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBWrite.Image = CType(resources.GetObject("TBWrite.Image"), Image)
        TBWrite.ImageTransparentColor = Color.Magenta
        TBWrite.Name = "TBWrite"
        TBWrite.Size = New Size(23, 22)
        TBWrite.Text = "Write Tool (F3)"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 25)
        ' 
        ' TBPlayB
        ' 
        TBPlayB.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBPlayB.Image = CType(resources.GetObject("TBPlayB.Image"), Image)
        TBPlayB.ImageTransparentColor = Color.Magenta
        TBPlayB.Name = "TBPlayB"
        TBPlayB.Size = New Size(23, 22)
        TBPlayB.Text = "Play from beginning (F5)"
        ' 
        ' TBPlay
        ' 
        TBPlay.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBPlay.Image = CType(resources.GetObject("TBPlay.Image"), Image)
        TBPlay.ImageTransparentColor = Color.Magenta
        TBPlay.Name = "TBPlay"
        TBPlay.Size = New Size(23, 22)
        TBPlay.Text = "Play from here (F6)"
        ' 
        ' TBStop
        ' 
        TBStop.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBStop.Image = CType(resources.GetObject("TBStop.Image"), Image)
        TBStop.ImageTransparentColor = Color.Magenta
        TBStop.Name = "TBStop"
        TBStop.Size = New Size(23, 22)
        TBStop.Text = "Stop (F7)"
        ' 
        ' TBPOptions
        ' 
        TBPOptions.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBPOptions.Image = CType(resources.GetObject("TBPOptions.Image"), Image)
        TBPOptions.ImageTransparentColor = Color.Magenta
        TBPOptions.Name = "TBPOptions"
        TBPOptions.Size = New Size(23, 22)
        TBPOptions.Text = "Player Options"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(6, 25)
        ' 
        ' TBVOptions
        ' 
        TBVOptions.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBVOptions.Image = CType(resources.GetObject("TBVOptions.Image"), Image)
        TBVOptions.ImageTransparentColor = Color.Magenta
        TBVOptions.Name = "TBVOptions"
        TBVOptions.Size = New Size(23, 22)
        TBVOptions.Text = "Visual Options"
        ' 
        ' TBGOptions
        ' 
        TBGOptions.DisplayStyle = ToolStripItemDisplayStyle.Image
        TBGOptions.Image = CType(resources.GetObject("TBGOptions.Image"), Image)
        TBGOptions.ImageTransparentColor = Color.Magenta
        TBGOptions.Name = "TBGOptions"
        TBGOptions.Size = New Size(23, 22)
        TBGOptions.Text = "General Options"
        ' 
        ' POBStorm
        ' 
        POBStorm.DisplayStyle = ToolStripItemDisplayStyle.Image
        POBStorm.Image = CType(resources.GetObject("POBStorm.Image"), Image)
        POBStorm.ImageTransparentColor = Color.Magenta
        POBStorm.Name = "POBStorm"
        POBStorm.Size = New Size(23, 22)
        POBStorm.Text = "Storm"
        POBStorm.Visible = False
        ' 
        ' pStatus
        ' 
        pStatus.AutoSize = True
        pStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pStatus.Controls.Add(FStatus2)
        pStatus.Controls.Add(FStatus)
        pStatus.Dock = DockStyle.Bottom
        pStatus.Location = New Point(0, 708)
        pStatus.Name = "pStatus"
        pStatus.Size = New Size(876, 22)
        pStatus.TabIndex = 62
        ' 
        ' FStatus2
        ' 
        FStatus2.AccessibleRole = AccessibleRole.StatusBar
        FStatus2.Items.AddRange(New ToolStripItem() {FSSS, FSSL, FSSH, BVCReverse, LblMultiply, TVCM, LblDivide, TVCD, BVCApply, TVCBPM, BVCCalculate, BConvertStop})
        FStatus2.Location = New Point(0, 0)
        FStatus2.Name = "FStatus2"
        FStatus2.ShowItemToolTips = True
        FStatus2.Size = New Size(876, 22)
        FStatus2.TabIndex = 0
        FStatus2.Text = "Status"
        FStatus2.Visible = False
        ' 
        ' FSSS
        ' 
        FSSS.DisplayStyle = ToolStripItemDisplayStyle.Text
        FSSS.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        FSSS.ImageTransparentColor = Color.Magenta
        FSSS.Name = "FSSS"
        FSSS.Size = New Size(23, 20)
        FSSS.Text = "0"
        FSSS.ToolTipText = "Selection Start Position"
        ' 
        ' FSSL
        ' 
        FSSL.DisplayStyle = ToolStripItemDisplayStyle.Text
        FSSL.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        FSSL.ImageTransparentColor = Color.Magenta
        FSSL.Name = "FSSL"
        FSSL.Size = New Size(23, 20)
        FSSL.Text = "0"
        FSSL.ToolTipText = "Selection Length"
        ' 
        ' FSSH
        ' 
        FSSH.DisplayStyle = ToolStripItemDisplayStyle.Text
        FSSH.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        FSSH.ImageTransparentColor = Color.Magenta
        FSSH.Name = "FSSH"
        FSSH.Size = New Size(23, 20)
        FSSH.Text = "0"
        FSSH.ToolTipText = "Selection Split Position"
        ' 
        ' BVCReverse
        ' 
        BVCReverse.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BVCReverse.DisplayStyle = ToolStripItemDisplayStyle.Text
        BVCReverse.ImageTransparentColor = Color.Magenta
        BVCReverse.Name = "BVCReverse"
        BVCReverse.Size = New Size(114, 20)
        BVCReverse.Text = "Reverse Selection"
        ' 
        ' LblMultiply
        ' 
        LblMultiply.Name = "LblMultiply"
        LblMultiply.Size = New Size(17, 17)
        LblMultiply.Text = "×"
        ' 
        ' TVCM
        ' 
        TVCM.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        TVCM.BorderStyle = BorderStyle.None
        TVCM.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        TVCM.Name = "TVCM"
        TVCM.Size = New Size(60, 22)
        TVCM.Text = "2"
        TVCM.TextBoxTextAlign = HorizontalAlignment.Center
        ' 
        ' LblDivide
        ' 
        LblDivide.Name = "LblDivide"
        LblDivide.Size = New Size(17, 17)
        LblDivide.Text = "÷"
        ' 
        ' TVCD
        ' 
        TVCD.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        TVCD.BorderStyle = BorderStyle.None
        TVCD.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        TVCD.Name = "TVCD"
        TVCD.Size = New Size(60, 22)
        TVCD.Text = "1"
        TVCD.TextBoxTextAlign = HorizontalAlignment.Center
        ' 
        ' BVCApply
        ' 
        BVCApply.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BVCApply.DisplayStyle = ToolStripItemDisplayStyle.Text
        BVCApply.ImageTransparentColor = Color.Magenta
        BVCApply.Name = "BVCApply"
        BVCApply.Size = New Size(107, 20)
        BVCApply.Text = "Expand By Ratio"
        BVCApply.ToolTipText = "This will expand notes and selection by the ratio next to this button. Ignores center bar."
        ' 
        ' TVCBPM
        ' 
        TVCBPM.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        TVCBPM.BorderStyle = BorderStyle.None
        TVCBPM.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        TVCBPM.Name = "TVCBPM"
        TVCBPM.Size = New Size(80, 22)
        TVCBPM.Text = "120"
        TVCBPM.TextBoxTextAlign = HorizontalAlignment.Center
        ' 
        ' BVCCalculate
        ' 
        BVCCalculate.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BVCCalculate.DisplayStyle = ToolStripItemDisplayStyle.Text
        BVCCalculate.ImageTransparentColor = Color.Magenta
        BVCCalculate.Name = "BVCCalculate"
        BVCCalculate.Size = New Size(116, 20)
        BVCCalculate.Text = "Relocate By Value"
        BVCCalculate.ToolTipText = "This will move notes within the selection and preserve the selection, given the BPM value next to this button. Considers center bar."
        ' 
        ' BConvertStop
        ' 
        BConvertStop.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BConvertStop.DisplayStyle = ToolStripItemDisplayStyle.Text
        BConvertStop.ImageTransparentColor = Color.Magenta
        BConvertStop.Name = "BConvertStop"
        BConvertStop.Size = New Size(130, 20)
        BConvertStop.Text = "Transform Into Stop"
        BConvertStop.ToolTipText = "This will move notes within the selection and preserve the selection, given the BPM value next to this button. Considers center bar."
        ' 
        ' FStatus
        ' 
        FStatus.AccessibleRole = AccessibleRole.StatusBar
        FStatus.Items.AddRange(New ToolStripItem() {FSC, FSW, FSM, FSP1, FSP3, FSP2, FSP4, TimeStatusLabel, FST, FSH, FSL, FSE})
        FStatus.Location = New Point(0, 0)
        FStatus.Name = "FStatus"
        FStatus.ShowItemToolTips = True
        FStatus.Size = New Size(876, 22)
        FStatus.SizingGrip = False
        FStatus.TabIndex = 62
        FStatus.Text = "Status"
        ' 
        ' FSC
        ' 
        FSC.AutoSize = False
        FSC.Name = "FSC"
        FSC.Size = New Size(70, 17)
        FSC.Text = "BPM"
        FSC.ToolTipText = "Column Caption"
        ' 
        ' FSW
        ' 
        FSW.AutoSize = False
        FSW.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        FSW.Name = "FSW"
        FSW.Size = New Size(40, 17)
        FSW.Text = "01"
        FSW.ToolTipText = "Note Index"
        ' 
        ' FSM
        ' 
        FSM.AutoSize = False
        FSM.ForeColor = Color.Teal
        FSM.Name = "FSM"
        FSM.Size = New Size(40, 17)
        FSM.Text = "000"
        FSM.ToolTipText = "Measure Index"
        ' 
        ' FSP1
        ' 
        FSP1.AutoSize = False
        FSP1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        FSP1.Name = "FSP1"
        FSP1.Size = New Size(170, 17)
        FSP1.Text = "9.41176470588235 / 9999"
        FSP1.ToolTipText = "Grid Resolution"
        ' 
        ' FSP3
        ' 
        FSP3.AutoSize = False
        FSP3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        FSP3.ForeColor = Color.Maroon
        FSP3.Name = "FSP3"
        FSP3.Size = New Size(85, 17)
        FSP3.Text = "9999 / 9999"
        FSP3.ToolTipText = "Reduced Resolution"
        ' 
        ' FSP2
        ' 
        FSP2.AutoSize = False
        FSP2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        FSP2.ForeColor = Color.Green
        FSP2.Name = "FSP2"
        FSP2.Size = New Size(170, 17)
        FSP2.Text = "112.941176470588 / 9999"
        FSP2.ToolTipText = "Measure Resolution"
        ' 
        ' FSP4
        ' 
        FSP4.AutoSize = False
        FSP4.Name = "FSP4"
        FSP4.Size = New Size(115, 17)
        FSP4.Text = "112.941176470588"
        FSP4.ToolTipText = "Absolute Position"
        ' 
        ' TimeStatusLabel
        ' 
        TimeStatusLabel.Name = "TimeStatusLabel"
        TimeStatusLabel.Size = New Size(63, 17)
        TimeStatusLabel.Text = "00:00:000"
        ' 
        ' FST
        ' 
        FST.ForeColor = Color.Olive
        FST.LinkColor = Color.FromArgb(CByte(0), CByte(0), CByte(255))
        FST.Name = "FST"
        FST.Size = New Size(71, 17)
        FST.Text = "Length = 0"
        ' 
        ' FSH
        ' 
        FSH.ForeColor = Color.Blue
        FSH.Name = "FSH"
        FSH.Size = New Size(50, 17)
        FSH.Text = "Hidden"
        ' 
        ' FSL
        ' 
        FSL.ForeColor = Color.Orange
        FSL.Name = "FSL"
        FSL.Size = New Size(65, 17)
        FSL.Text = "LandMine"
        ' 
        ' FSE
        ' 
        FSE.ForeColor = Color.Red
        FSE.Name = "FSE"
        FSE.Size = New Size(38, 17)
        FSE.Text = "Error"
        ' 
        ' TimerMiddle
        ' 
        TimerMiddle.Interval = 15
        ' 
        ' ToolStripContainer1
        ' 
        ' 
        ' ToolStripContainer1.ContentPanel
        ' 
        ToolStripContainer1.ContentPanel.Controls.Add(PMain)
        ToolStripContainer1.ContentPanel.Controls.Add(SpR)
        ToolStripContainer1.ContentPanel.Controls.Add(SpL)
        ToolStripContainer1.ContentPanel.Controls.Add(PMainR)
        ToolStripContainer1.ContentPanel.Controls.Add(PMainL)
        ToolStripContainer1.ContentPanel.Size = New Size(876, 658)
        ToolStripContainer1.Dock = DockStyle.Fill
        ToolStripContainer1.Location = New Point(0, 0)
        ToolStripContainer1.Name = "ToolStripContainer1"
        ToolStripContainer1.Size = New Size(876, 708)
        ToolStripContainer1.TabIndex = 65
        ToolStripContainer1.Text = "ToolStripContainer1"
        ' 
        ' ToolStripContainer1.TopToolStripPanel
        ' 
        ToolStripContainer1.TopToolStripPanel.Controls.Add(TBMain)
        ToolStripContainer1.TopToolStripPanel.Controls.Add(mnMain)
        ' 
        ' PMain
        ' 
        PMain.BackColor = Color.Black
        PMain.Controls.Add(PMainIn)
        PMain.Controls.Add(MainPanelScroll)
        PMain.Controls.Add(HS)
        PMain.Dock = DockStyle.Fill
        PMain.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PMain.ForeColor = Color.White
        PMain.Location = New Point(5, 0)
        PMain.Name = "PMain"
        PMain.Size = New Size(866, 658)
        PMain.TabIndex = 58
        PMain.Tag = "1"
        ' 
        ' PMainIn
        ' 
        PMainIn.BackColor = Color.Black
        PMainIn.Dock = DockStyle.Fill
        PMainIn.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PMainIn.ForeColor = Color.White
        PMainIn.Location = New Point(0, 0)
        PMainIn.Name = "PMainIn"
        PMainIn.Size = New Size(849, 641)
        PMainIn.TabIndex = 0
        PMainIn.TabStop = True
        PMainIn.Tag = "1"
        ' 
        ' MainPanelScroll
        ' 
        MainPanelScroll.AccessibleRole = AccessibleRole.ScrollBar
        MainPanelScroll.Dock = DockStyle.Right
        MainPanelScroll.LargeChange = 592
        MainPanelScroll.Location = New Point(849, 0)
        MainPanelScroll.Maximum = 591
        MainPanelScroll.Minimum = -10000
        MainPanelScroll.Name = "MainPanelScroll"
        MainPanelScroll.Size = New Size(17, 641)
        MainPanelScroll.SmallChange = 12
        MainPanelScroll.TabIndex = 2
        MainPanelScroll.Tag = "1"
        ' 
        ' HS
        ' 
        HS.AccessibleRole = AccessibleRole.ScrollBar
        HS.Dock = DockStyle.Bottom
        HS.LargeChange = 777
        HS.Location = New Point(0, 641)
        HS.Maximum = 1233
        HS.Name = "HS"
        HS.Size = New Size(866, 17)
        HS.TabIndex = 3
        HS.Tag = "1"
        ' 
        ' SpR
        ' 
        SpR.Dock = DockStyle.Right
        SpR.FlatAppearance.BorderSize = 0
        SpR.FlatStyle = FlatStyle.Flat
        SpR.Location = New Point(871, 0)
        SpR.Name = "SpR"
        SpR.Size = New Size(5, 658)
        SpR.TabIndex = 59
        SpR.TabStop = False
        SpR.UseVisualStyleBackColor = True
        SpR.Visible = False
        ' 
        ' SpL
        ' 
        SpL.Dock = DockStyle.Left
        SpL.FlatAppearance.BorderSize = 0
        SpL.FlatStyle = FlatStyle.Flat
        SpL.Location = New Point(0, 0)
        SpL.Name = "SpL"
        SpL.Size = New Size(5, 658)
        SpL.TabIndex = 60
        SpL.TabStop = False
        SpL.UseVisualStyleBackColor = True
        SpL.Visible = False
        ' 
        ' PMainR
        ' 
        PMainR.BackColor = Color.Black
        PMainR.Controls.Add(PMainInR)
        PMainR.Controls.Add(RightPanelScroll)
        PMainR.Controls.Add(HSR)
        PMainR.Dock = DockStyle.Right
        PMainR.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PMainR.ForeColor = Color.White
        PMainR.Location = New Point(876, 0)
        PMainR.Name = "PMainR"
        PMainR.Size = New Size(0, 658)
        PMainR.TabIndex = 56
        PMainR.Tag = "2"
        ' 
        ' PMainInR
        ' 
        PMainInR.BackColor = Color.Black
        PMainInR.Dock = DockStyle.Fill
        PMainInR.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PMainInR.ForeColor = Color.White
        PMainInR.Location = New Point(0, 0)
        PMainInR.Name = "PMainInR"
        PMainInR.Size = New Size(0, 641)
        PMainInR.TabIndex = 0
        PMainInR.TabStop = True
        PMainInR.Tag = "2"
        ' 
        ' RightPanelScroll
        ' 
        RightPanelScroll.Dock = DockStyle.Right
        RightPanelScroll.LargeChange = 592
        RightPanelScroll.Location = New Point(-17, 0)
        RightPanelScroll.Maximum = 591
        RightPanelScroll.Minimum = -10000
        RightPanelScroll.Name = "RightPanelScroll"
        RightPanelScroll.Size = New Size(17, 641)
        RightPanelScroll.SmallChange = 12
        RightPanelScroll.TabIndex = 2
        RightPanelScroll.Tag = "2"
        ' 
        ' HSR
        ' 
        HSR.Dock = DockStyle.Bottom
        HSR.LargeChange = 777
        HSR.Location = New Point(0, 641)
        HSR.Maximum = 1233
        HSR.Name = "HSR"
        HSR.Size = New Size(0, 17)
        HSR.TabIndex = 3
        HSR.Tag = "2"
        ' 
        ' PMainL
        ' 
        PMainL.BackColor = Color.Black
        PMainL.Controls.Add(PMainInL)
        PMainL.Controls.Add(LeftPanelScroll)
        PMainL.Controls.Add(HSL)
        PMainL.Dock = DockStyle.Left
        PMainL.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PMainL.ForeColor = Color.White
        PMainL.Location = New Point(0, 0)
        PMainL.Name = "PMainL"
        PMainL.Size = New Size(0, 658)
        PMainL.TabIndex = 54
        PMainL.Tag = "0"
        ' 
        ' PMainInL
        ' 
        PMainInL.BackColor = Color.Black
        PMainInL.Dock = DockStyle.Fill
        PMainInL.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PMainInL.ForeColor = Color.White
        PMainInL.Location = New Point(0, 0)
        PMainInL.Name = "PMainInL"
        PMainInL.Size = New Size(0, 641)
        PMainInL.TabIndex = 0
        PMainInL.TabStop = True
        PMainInL.Tag = "0"
        ' 
        ' LeftPanelScroll
        ' 
        LeftPanelScroll.Dock = DockStyle.Right
        LeftPanelScroll.LargeChange = 592
        LeftPanelScroll.Location = New Point(-17, 0)
        LeftPanelScroll.Maximum = 591
        LeftPanelScroll.Minimum = -10000
        LeftPanelScroll.Name = "LeftPanelScroll"
        LeftPanelScroll.Size = New Size(17, 641)
        LeftPanelScroll.SmallChange = 12
        LeftPanelScroll.TabIndex = 2
        LeftPanelScroll.Tag = "0"
        ' 
        ' HSL
        ' 
        HSL.Dock = DockStyle.Bottom
        HSL.LargeChange = 777
        HSL.Location = New Point(0, 641)
        HSL.Maximum = 1233
        HSL.Name = "HSL"
        HSL.Size = New Size(0, 17)
        HSL.TabIndex = 3
        HSL.Tag = "0"
        ' 
        ' POptionsResizer
        ' 
        POptionsResizer.AutoSize = True
        POptionsResizer.AutoSizeMode = AutoSizeMode.GrowAndShrink
        POptionsResizer.Dock = DockStyle.Right
        POptionsResizer.FlatAppearance.BorderSize = 0
        POptionsResizer.FlatStyle = FlatStyle.Flat
        POptionsResizer.Location = New Point(876, 0)
        POptionsResizer.Name = "POptionsResizer"
        POptionsResizer.Size = New Size(6, 730)
        POptionsResizer.TabIndex = 67
        POptionsResizer.TabStop = False
        POptionsResizer.UseVisualStyleBackColor = True
        ' 
        ' mnPlayB
        ' 
        mnPlayB.Image = CType(resources.GetObject("mnPlayB.Image"), Image)
        mnPlayB.Name = "mnPlayB"
        mnPlayB.ShortcutKeys = Keys.F5
        mnPlayB.Size = New Size(214, 22)
        mnPlayB.Text = "Play from &beginning"
        ' 
        ' mnPlay
        ' 
        mnPlay.Image = CType(resources.GetObject("mnPlay.Image"), Image)
        mnPlay.Name = "mnPlay"
        mnPlay.ShortcutKeys = Keys.F6
        mnPlay.Size = New Size(214, 22)
        mnPlay.Text = "&Play from here"
        ' 
        ' mnStop
        ' 
        mnStop.Image = CType(resources.GetObject("mnStop.Image"), Image)
        mnStop.Name = "mnStop"
        mnStop.ShortcutKeys = Keys.F7
        mnStop.Size = New Size(214, 22)
        mnStop.Text = "&Stop"
        ' 
        ' mnPreview
        ' 
        mnPreview.DropDownItems.AddRange(New ToolStripItem() {mnPlayB, mnPlay, mnStop})
        mnPreview.Name = "mnPreview"
        mnPreview.Size = New Size(64, 21)
        mnPreview.Text = "&Preview"
        ' 
        ' MainWindow
        ' 
        AllowDrop = True
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1082, 730)
        Controls.Add(ToolStripContainer1)
        Controls.Add(pStatus)
        Controls.Add(POptionsResizer)
        Controls.Add(POptionsScroll)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MainMenuStrip = mnMain
        Name = "MainWindow"
        cmnLanguage.ResumeLayout(False)
        cmnTheme.ResumeLayout(False)
        POptionsScroll.ResumeLayout(False)
        POptionsScroll.PerformLayout()
        POptions.ResumeLayout(False)
        POptions.PerformLayout()
        POExpansion.ResumeLayout(False)
        POExpansionInner.ResumeLayout(False)
        POExpansionInner.PerformLayout()
        POBeat.ResumeLayout(False)
        POBeatInner.ResumeLayout(False)
        POBeatInner.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        CType(nBeatD, ComponentModel.ISupportInitialize).EndInit()
        CType(nBeatN, ComponentModel.ISupportInitialize).EndInit()
        POBeatPart2.ResumeLayout(False)
        POBeatPart2.PerformLayout()
        POBMP.ResumeLayout(False)
        POBMPInner.ResumeLayout(False)
        POBMPInner.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        POWAV.ResumeLayout(False)
        POWAVInner.ResumeLayout(False)
        POWAVInner.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        POWAVPart2.ResumeLayout(False)
        POWAVPart2.PerformLayout()
        POWaveForm.ResumeLayout(False)
        POWaveForm.PerformLayout()
        POWaveFormInner.ResumeLayout(False)
        POWaveFormInner.PerformLayout()
        POWaveFormPart2.ResumeLayout(False)
        POWaveFormPart2.PerformLayout()
        CType(TWSaturation, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(TWTransparency, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(TWPrecision, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(TWWidth, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(TWLeft, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(TWSaturation2, ComponentModel.ISupportInitialize).EndInit()
        CType(TWLeft2, ComponentModel.ISupportInitialize).EndInit()
        CType(TWTransparency2, ComponentModel.ISupportInitialize).EndInit()
        CType(TWWidth2, ComponentModel.ISupportInitialize).EndInit()
        CType(TWPrecision2, ComponentModel.ISupportInitialize).EndInit()
        POWaveFormPart1.ResumeLayout(False)
        POWaveFormPart1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(TWPosition2, ComponentModel.ISupportInitialize).EndInit()
        CType(TWPosition, ComponentModel.ISupportInitialize).EndInit()
        POGrid.ResumeLayout(False)
        POGrid.PerformLayout()
        POGridInner.ResumeLayout(False)
        POGridInner.PerformLayout()
        POGridPart2.ResumeLayout(False)
        POGridPart2.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        CType(CGB, ComponentModel.ISupportInitialize).EndInit()
        POGridPart1.ResumeLayout(False)
        POGridPart1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(CGHeight2, ComponentModel.ISupportInitialize).EndInit()
        CType(CGHeight, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(CGWidth2, ComponentModel.ISupportInitialize).EndInit()
        CType(CGWidth, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(CGDivide, ComponentModel.ISupportInitialize).EndInit()
        CType(CGSub, ComponentModel.ISupportInitialize).EndInit()
        POHeader.ResumeLayout(False)
        POHeader.PerformLayout()
        POHeaderInner.ResumeLayout(False)
        POHeaderInner.PerformLayout()
        POHeaderPart2.ResumeLayout(False)
        POHeaderPart2.PerformLayout()
        POHeaderPart1.ResumeLayout(False)
        POHeaderPart1.PerformLayout()
        CType(THBPM, ComponentModel.ISupportInitialize).EndInit()
        Menu1.ResumeLayout(False)
        mnMain.ResumeLayout(False)
        mnMain.PerformLayout()
        cmnConversion.ResumeLayout(False)
        TBMain.ResumeLayout(False)
        TBMain.PerformLayout()
        pStatus.ResumeLayout(False)
        pStatus.PerformLayout()
        FStatus2.ResumeLayout(False)
        FStatus2.PerformLayout()
        FStatus.ResumeLayout(False)
        FStatus.PerformLayout()
        ToolStripContainer1.ContentPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.PerformLayout()
        ToolStripContainer1.ResumeLayout(False)
        ToolStripContainer1.PerformLayout()
        PMain.ResumeLayout(False)
        PMainR.ResumeLayout(False)
        PMainL.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents POptionsScroll As System.Windows.Forms.Panel
    Friend WithEvents LWAV As System.Windows.Forms.ListBox
    Friend WithEvents LBMP As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MInsert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AutoSaveTimer As System.Windows.Forms.Timer
    Friend WithEvents mnMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnImportSM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnImportIBMSC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnExportIBMSC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnExportBMSON As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnOpenR0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnOpenR1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnOpenR2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnOpenR3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnOpenR4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnStatistics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnMyO2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnTimeSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnWrite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnConversion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnErrorCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPreviewOnClick As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnShowFileName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnChangePlaySide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnGOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnVOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLanguage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnTheme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnLanguage As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TBLangDef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnTheme As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TBThemeDef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBThemeSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBThemeRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnConversion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents POBLong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POBShort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POBLongShort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents POBHidden As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POBVisible As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POBHiddenVisible As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents POBMirror As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POBModify As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSys As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSTB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSOP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSLSplitter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSRSplitter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnNTInput As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBLangRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CGSub As System.Windows.Forms.NumericUpDown
    Friend WithEvents CGDivide As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents CGSnap As System.Windows.Forms.CheckBox
    Friend WithEvents BWLock As System.Windows.Forms.CheckBox
    Friend WithEvents TWSaturation As System.Windows.Forms.NumericUpDown
    Friend WithEvents TWTransparency As System.Windows.Forms.NumericUpDown
    Friend WithEvents TWPrecision As System.Windows.Forms.NumericUpDown
    Friend WithEvents TWWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents TWLeft As System.Windows.Forms.NumericUpDown
    Friend WithEvents TWPosition As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TWSaturation2 As System.Windows.Forms.TrackBar
    Friend WithEvents TWTransparency2 As System.Windows.Forms.TrackBar
    Friend WithEvents TWPrecision2 As System.Windows.Forms.TrackBar
    Friend WithEvents TWWidth2 As System.Windows.Forms.TrackBar
    Friend WithEvents TWLeft2 As System.Windows.Forms.TrackBar
    Friend WithEvents TWPosition2 As System.Windows.Forms.TrackBar
    Friend WithEvents TWFileName As System.Windows.Forms.TextBox
    Friend WithEvents BWClear As System.Windows.Forms.Button
    Friend WithEvents BWLoad As System.Windows.Forms.Button
    Friend WithEvents TBMain As System.Windows.Forms.ToolStrip
    Friend WithEvents TBNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBOpen As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents TBOpenR0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBOpenR1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBOpenR2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBOpenR3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBOpenR4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBImportSM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBImportIBMSC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBSave As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents TBSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBExportIBMSC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBExportBMSON As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBStatistics As System.Windows.Forms.ToolStripButton
    Friend WithEvents pStatus As System.Windows.Forms.Panel
    Friend WithEvents FStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents FSC As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FSP1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FSP2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FSP3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FSP4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FST As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FSH As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FSL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FSE As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FStatus2 As System.Windows.Forms.StatusStrip
    Friend WithEvents BVCReverse As System.Windows.Forms.ToolStripButton
    Friend WithEvents LblMultiply As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TVCBPM As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TVCM As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LblDivide As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TVCD As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BVCApply As System.Windows.Forms.ToolStripButton
    Friend WithEvents BVCCalculate As System.Windows.Forms.ToolStripButton
    Friend WithEvents FSW As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FSSS As System.Windows.Forms.ToolStripButton
    Friend WithEvents FSSL As System.Windows.Forms.ToolStripButton
    Friend WithEvents FSSH As System.Windows.Forms.ToolStripButton
    Friend WithEvents TExpansion As System.Windows.Forms.TextBox
    Friend WithEvents TimerMiddle As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CGShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CGShowS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CGShowBG As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CGShowM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CGShowMB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CGShowV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CGShowC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CGBLP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CGSTOP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CGSCROLL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nBeatN As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBeat As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BBeatApply As System.Windows.Forms.Button
    Friend WithEvents mnPOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents PMain As System.Windows.Forms.Panel
    Friend WithEvents PMainIn As System.Windows.Forms.Panel
    Friend WithEvents MainPanelScroll As System.Windows.Forms.VScrollBar
    Friend WithEvents HS As System.Windows.Forms.HScrollBar
    Friend WithEvents PMainR As System.Windows.Forms.Panel
    Friend WithEvents PMainInR As System.Windows.Forms.Panel
    Friend WithEvents RightPanelScroll As System.Windows.Forms.VScrollBar
    Friend WithEvents HSR As System.Windows.Forms.HScrollBar
    Friend WithEvents PMainL As System.Windows.Forms.Panel
    Friend WithEvents PMainInL As System.Windows.Forms.Panel
    Friend WithEvents LeftPanelScroll As System.Windows.Forms.VScrollBar
    Friend WithEvents HSL As System.Windows.Forms.HScrollBar
    Friend WithEvents POConvert As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TBLanguage As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TBTheme As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TBMyO2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBErrorCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBPreviewOnClick As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBShowFileName As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBChangePlaySide As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBRedo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBNTInput As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBTimeSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBWrite As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBPlayB As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBPlay As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBPOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBVOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBGOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents POBStorm As System.Windows.Forms.ToolStripButton
    Friend WithEvents POptions As System.Windows.Forms.Panel
    Friend WithEvents POHeader As System.Windows.Forms.Panel
    Friend WithEvents POHeaderSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents POGrid As System.Windows.Forms.Panel
    Friend WithEvents POGridSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents POHeaderInner As System.Windows.Forms.Panel
    Friend WithEvents POHeaderPart2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents THExRank As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents CHLnObj As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents THComment As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents THTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents BHStageFile As System.Windows.Forms.Button
    Friend WithEvents BHBanner As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents BHBackBMP As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents THBackBMP As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents THBanner As System.Windows.Forms.TextBox
    Friend WithEvents THStageFile As System.Windows.Forms.TextBox
    Friend WithEvents THSubTitle As System.Windows.Forms.TextBox
    Friend WithEvents THSubArtist As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents THLandMine As System.Windows.Forms.TextBox
    Friend WithEvents BHLandMine As System.Windows.Forms.Button
    Friend WithEvents THMissBMP As System.Windows.Forms.TextBox
    Friend WithEvents BHMissBMP As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents THPreview As System.Windows.Forms.TextBox
    Friend WithEvents BHPreview As System.Windows.Forms.Button
    Friend WithEvents CHLnmode As System.Windows.Forms.ComboBox
    Friend WithEvents POHeaderExpander As System.Windows.Forms.CheckBox
    Friend WithEvents POHeaderPart1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents THPlayLevel As System.Windows.Forms.TextBox
    Friend WithEvents CHRank As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CHPlayer As System.Windows.Forms.ComboBox
    Friend WithEvents CHDifficulty As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents THGenre As System.Windows.Forms.TextBox
    Friend WithEvents THBPM As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents THArtist As System.Windows.Forms.TextBox
    Friend WithEvents THTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents POGridPart1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents POGridInner As System.Windows.Forms.Panel
    Friend WithEvents POGridPart2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cVSLockR As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cVSLock As System.Windows.Forms.CheckBox
    Friend WithEvents cVSLockL As System.Windows.Forms.CheckBox
    Friend WithEvents CGDisableVertical As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CGB As System.Windows.Forms.NumericUpDown
    Friend WithEvents POGridExpander As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents CGHeight2 As System.Windows.Forms.TrackBar
    Friend WithEvents CGHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents CGWidth2 As System.Windows.Forms.TrackBar
    Friend WithEvents CGWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents POWaveForm As System.Windows.Forms.Panel
    Friend WithEvents POWaveFormSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents POWaveFormInner As System.Windows.Forms.Panel
    Friend WithEvents POWaveFormPart2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents POWaveFormExpander As System.Windows.Forms.CheckBox
    Friend WithEvents POWaveFormPart1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents POWAV As System.Windows.Forms.Panel
    Friend WithEvents POWAVInner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents POWAVSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents POBMP As System.Windows.Forms.Panel
    Friend WithEvents POBMPInner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents POBMPSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents POBeat As System.Windows.Forms.Panel
    Friend WithEvents POBeatInner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents POBeatSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BWAVUp As System.Windows.Forms.Button
    Friend WithEvents BWAVDown As System.Windows.Forms.Button
    Friend WithEvents BWAVBrowse As System.Windows.Forms.Button
    Friend WithEvents BWAVRemove As System.Windows.Forms.Button
    Friend WithEvents BBMPUp As System.Windows.Forms.Button
    Friend WithEvents BBMPDown As System.Windows.Forms.Button
    Friend WithEvents BBMPBrowse As System.Windows.Forms.Button
    Friend WithEvents BBMPRemove As System.Windows.Forms.Button
    Friend WithEvents POExpansion As System.Windows.Forms.Panel
    Friend WithEvents POExpansionInner As System.Windows.Forms.Panel
    Friend WithEvents POExpansionSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents POWAVResizer As System.Windows.Forms.Button
    Friend WithEvents POBMPResizer As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents POExpansionResizer As System.Windows.Forms.Button
    Friend WithEvents POBeatResizer As System.Windows.Forms.Button
    Friend WithEvents POptionsResizer As System.Windows.Forms.Button
    Friend WithEvents SpR As System.Windows.Forms.Button
    Friend WithEvents SpL As System.Windows.Forms.Button
    Friend WithEvents TBThemeLoadComptability As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POWAVExpander As System.Windows.Forms.CheckBox
    Friend WithEvents POWAVPart2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CWAVMultiSelect As System.Windows.Forms.CheckBox
    Friend WithEvents CWAVChangeLabel As System.Windows.Forms.CheckBox
    Friend WithEvents CWAVEmptyfill As System.Windows.Forms.CheckBox
    Friend WithEvents nBeatD As System.Windows.Forms.NumericUpDown
    Friend WithEvents BBeatApplyV As System.Windows.Forms.Button
    Friend WithEvents tBeatValue As System.Windows.Forms.TextBox
    Friend WithEvents POBeatExpander As System.Windows.Forms.CheckBox
    Friend WithEvents POBeatPart2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CBeatScale As System.Windows.Forms.RadioButton
    Friend WithEvents CBeatCut As System.Windows.Forms.RadioButton
    Friend WithEvents CBeatMeasure As System.Windows.Forms.RadioButton
    Friend WithEvents CBeatPreserve As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ToolTipUniversal As System.Windows.Forms.ToolTip
    Friend WithEvents CGBPM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BGSlash As System.Windows.Forms.Button
    Friend WithEvents FSM As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnGotoMeasure As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator24 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents TBWavIncrease As ToolStripButton
    Friend WithEvents TimeStatusLabel As ToolStripStatusLabel
    Friend WithEvents BConvertStop As ToolStripButton
    Friend WithEvents mnPreview As ToolStripMenuItem
    Friend WithEvents mnPlayB As ToolStripMenuItem
    Friend WithEvents mnPlay As ToolStripMenuItem
    Friend WithEvents mnStop As ToolStripMenuItem
End Class

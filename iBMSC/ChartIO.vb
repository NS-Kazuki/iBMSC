Imports System.Text.Json
Imports iBMSC.Editor

Partial Public Class MainWindow
    Private Sub OpenBMS(ByVal xStrAll As String)
        KMouseOver = -1

        'Line feed validation: will remove some empty lines
        xStrAll = Replace(Replace(Replace(xStrAll, vbLf, vbCr), vbCr & vbCr, vbCr), vbCr, vbCrLf)

        Dim xStrLine() As String = Split(xStrAll, vbCrLf, , CompareMethod.Text)
        Dim xI1 As Integer
        Dim sLine As String
        Dim xExpansion As String = ""
        ReDim Notes(0)
        ReDim mColumn(999)
        ReDim hWAV(1295)
        ReDim hBPM(1295)    'x10000
        ReDim hSTOP(1295)
        ReDim hBMSCROLL(1295)
        Me.InitializeNewBMS()
        Me.InitializeOpenBMS()

        With Notes(0)
            .ColumnIndex = niBPM
            .VPosition = -1
            '.LongNote = False
            '.Selected = False
            .Value = 1200000
        End With

        'random, setRandom      0
        'endRandom              0
        'if             +1
        'else           0
        'endif          -1
        'switch, setSwitch      +1
        'case, skip, def        0
        'endSw                  -1
        Dim xStack As Integer = 0

        For Each sLine In xStrLine
            Dim sLineTrim As String = sLine.Trim
            If xStack > 0 Then GoTo Expansion

            If sLineTrim.StartsWith("#") And Mid(sLineTrim, 5, 3) = "02:" Then
                Dim xIndex As Integer = Val(Mid(sLineTrim, 2, 3))
                Dim xRatio As Double = Val(Mid(sLineTrim, 8))
                Dim xxD As Long = GetDenominator(xRatio)
                MeasureLength(xIndex) = xRatio * 192.0R
                LBeat.Items(xIndex) = Add3Zeros(xIndex) & ": " & xRatio & IIf(xxD > 10000, "", " ( " & CLng(xRatio * xxD) & " / " & xxD & " ) ")

            ElseIf sLineTrim.StartsWith("#WAV", StringComparison.CurrentCultureIgnoreCase) Then
                hWAV(C36to10(Mid(sLineTrim, Len("#WAV") + 1, 2))) = Mid(sLineTrim, Len("#WAV") + 4)

            ElseIf sLineTrim.StartsWith("#BMP", StringComparison.CurrentCultureIgnoreCase) Then
                hBMP(C36to10(Mid(sLineTrim, Len("#BMP") + 1, 2))) = Mid(sLineTrim, Len("#BMP") + 4)

            ElseIf sLineTrim.StartsWith("#BPM", StringComparison.CurrentCultureIgnoreCase) And Not Mid(sLineTrim, Len("#BPM") + 1, 1).Trim = "" Then  'If BPM##
                ' zdr: No limits on BPM editing.. they don't make much sense.
                hBPM(C36to10(Mid(sLineTrim, Len("#BPM") + 1, 2))) = Val(Mid(sLineTrim, Len("#BPM") + 4)) * 10000

                'No limits on STOPs either.
            ElseIf sLineTrim.StartsWith("#STOP", StringComparison.CurrentCultureIgnoreCase) Then
                hSTOP(C36to10(Mid(sLineTrim, Len("#STOP") + 1, 2))) = Val(Mid(sLineTrim, Len("#STOP") + 4)) * 10000

            ElseIf sLineTrim.StartsWith("#SCROLL", StringComparison.CurrentCultureIgnoreCase) Then
                hBMSCROLL(C36to10(Mid(sLineTrim, Len("#SCROLL") + 1, 2))) = Val(Mid(sLineTrim, Len("#SCROLL") + 4)) * 10000


            ElseIf sLineTrim.StartsWith("#TITLE", StringComparison.CurrentCultureIgnoreCase) Then
                THTitle.Text = Mid(sLineTrim, Len("#TITLE") + 1).Trim

            ElseIf sLineTrim.StartsWith("#ARTIST", StringComparison.CurrentCultureIgnoreCase) Then
                THArtist.Text = Mid(sLineTrim, Len("#ARTIST") + 1).Trim

            ElseIf sLineTrim.StartsWith("#GENRE", StringComparison.CurrentCultureIgnoreCase) Then
                THGenre.Text = Mid(sLineTrim, Len("#GENRE") + 1).Trim

            ElseIf sLineTrim.StartsWith("#BPM", StringComparison.CurrentCultureIgnoreCase) Then  'If BPM ####
                Notes(0).Value = Val(Mid(sLineTrim, Len("#BPM") + 1).Trim) * 10000
                THBPM.Value = Notes(0).Value / 10000

            ElseIf sLineTrim.StartsWith("#PLAYER", StringComparison.CurrentCultureIgnoreCase) Then
                Dim xInt As Integer = Val(Mid(sLineTrim, Len("#PLAYER") + 1).Trim)
                If xInt >= 1 And xInt <= 4 Then _
                    CHPlayer.SelectedIndex = xInt - 1

            ElseIf sLineTrim.StartsWith("#RANK", StringComparison.CurrentCultureIgnoreCase) Then
                Dim xInt As Integer = Val(Mid(sLineTrim, Len("#RANK") + 1).Trim)
                If xInt >= 0 And xInt <= 4 Then _
                    CHRank.SelectedIndex = xInt

            ElseIf sLineTrim.StartsWith("#PLAYLEVEL", StringComparison.CurrentCultureIgnoreCase) Then
                THPlayLevel.Text = Mid(sLineTrim, Len("#PLAYLEVEL") + 1).Trim


            ElseIf sLineTrim.StartsWith("#SUBTITLE", StringComparison.CurrentCultureIgnoreCase) Then
                THSubTitle.Text = Mid(sLineTrim, Len("#SUBTITLE") + 1).Trim

            ElseIf sLineTrim.StartsWith("#SUBARTIST", StringComparison.CurrentCultureIgnoreCase) Then
                THSubArtist.Text = Mid(sLineTrim, Len("#SUBARTIST") + 1).Trim

            ElseIf sLineTrim.StartsWith("#STAGEFILE", StringComparison.CurrentCultureIgnoreCase) Then
                THStageFile.Text = Mid(sLineTrim, Len("#STAGEFILE") + 1).Trim

            ElseIf sLineTrim.StartsWith("#BANNER", StringComparison.CurrentCultureIgnoreCase) Then
                THBanner.Text = Mid(sLineTrim, Len("#BANNER") + 1).Trim

            ElseIf sLineTrim.StartsWith("#BACKBMP", StringComparison.CurrentCultureIgnoreCase) Then
                THBackBMP.Text = Mid(sLineTrim, Len("#BACKBMP") + 1).Trim

            ElseIf sLineTrim.StartsWith("#DIFFICULTY", StringComparison.CurrentCultureIgnoreCase) Then
                Try
                    CHDifficulty.SelectedIndex = Integer.Parse(Mid(sLineTrim, Len("#DIFFICULTY") + 1).Trim)
                Catch ex As Exception
                End Try

            ElseIf sLineTrim.StartsWith("#DEFEXRANK", StringComparison.CurrentCultureIgnoreCase) Then
                THExRank.Text = Mid(sLineTrim, Len("#DEFEXRANK") + 1).Trim

            ElseIf sLineTrim.StartsWith("#TOTAL", StringComparison.CurrentCultureIgnoreCase) Then
                Dim xStr As String = Mid(sLineTrim, Len("#TOTAL") + 1).Trim
                'If xStr.EndsWith("%") Then xStr = Mid(xStr, 1, Len(xStr) - 1)
                THTotal.Text = xStr

            ElseIf sLineTrim.StartsWith("#COMMENT", StringComparison.CurrentCultureIgnoreCase) Then
                Dim xStr As String = Mid(sLineTrim, Len("#COMMENT") + 1).Trim
                If xStr.StartsWith("""") Then xStr = Mid(xStr, 2)
                If xStr.EndsWith("""") Then xStr = Mid(xStr, 1, Len(xStr) - 1)
                THComment.Text = xStr

            ElseIf sLineTrim.StartsWith("#LNTYPE", StringComparison.CurrentCultureIgnoreCase) Then
                'THLnType.Text = Mid(sLineTrim, Len("#LNTYPE") + 1).Trim
                If Val(Mid(sLineTrim, Len("#LNTYPE") + 1).Trim) = 1 Then CHLnObj.SelectedIndex = 0

            ElseIf sLineTrim.StartsWith("#LNOBJ", StringComparison.CurrentCultureIgnoreCase) Then
                Dim xValue As Integer = C36to10(Mid(sLineTrim, Len("#LNOBJ") + 1).Trim)
                CHLnObj.SelectedIndex = xValue

                'TODO: LNOBJ value validation

                'ElseIf sLineTrim.StartsWith("#LNTYPE", StringComparison.CurrentCultureIgnoreCase) Then
                '    CAdLNTYPE.Checked = True
                '    If Mid(sLineTrim, 9) = "" Or Mid(sLineTrim, 9) = "1" Or Mid(sLineTrim, 9) = "01" Then CAdLNTYPEb.Text = "1"
                '    CAdLNTYPEb.Text = Mid(sLineTrim, 9)

            ElseIf sLineTrim.StartsWith("#PREVIEW", StringComparison.CurrentCultureIgnoreCase) Then
                THPreview.Text = Mid(sLineTrim, Len("#PREVIEW") + 1).Trim

            ElseIf sLineTrim.StartsWith("#LNMODE", StringComparison.CurrentCultureIgnoreCase) Then
                Dim xInt As Integer = Val(Mid(sLineTrim, Len("#LNMODE") + 1).Trim)
                If xInt >= 1 And xInt <= 3 Then _
                    CHLnmode.SelectedIndex = xInt

            ElseIf sLineTrim.StartsWith("#") And Mid(sLineTrim, 7, 1) = ":" Then   'If the line contains Ks
                Dim xIdentifier As String = Mid(sLineTrim, 5, 2)
                If BMSChannelToColumn(xIdentifier) = 0 Then GoTo AddExpansion

            Else
Expansion:      If sLineTrim.StartsWith("#IF", StringComparison.CurrentCultureIgnoreCase) Then
                    xStack += 1 : GoTo AddExpansion
                ElseIf sLineTrim.StartsWith("#ENDIF", StringComparison.CurrentCultureIgnoreCase) Then
                    xStack -= 1 : GoTo AddExpansion
                ElseIf sLineTrim.StartsWith("#SWITCH", StringComparison.CurrentCultureIgnoreCase) Then
                    xStack += 1 : GoTo AddExpansion
                ElseIf sLineTrim.StartsWith("#SETSWITCH", StringComparison.CurrentCultureIgnoreCase) Then
                    xStack += 1 : GoTo AddExpansion
                ElseIf sLineTrim.StartsWith("#ENDSW", StringComparison.CurrentCultureIgnoreCase) Then
                    xStack -= 1 : GoTo AddExpansion

                ElseIf sLineTrim.StartsWith("#") Then
AddExpansion:       xExpansion &= sLine & vbCrLf
                End If

            End If
        Next

        UpdateMeasureBottom()

        xStack = 0
        For Each sLine In xStrLine
            Dim sLineTrim As String = sLine.Trim
            If xStack > 0 Then Continue For

            If Not (sLineTrim.StartsWith("#") And Mid(sLineTrim, 7, 1) = ":") Then Continue For 'If the line contains Ks

            ' >> Measure =           Mid(sLine, 2, 3)
            ' >> Column Identifier = Mid(sLine, 5, 2)
            ' >> K =                 Mid(sLine, xI1, 2)
            Dim xMeasure As Integer = Val(Mid(sLineTrim, 2, 3))
            Dim Channel As String = Mid(sLineTrim, 5, 2)
            If BMSChannelToColumn(Channel) = 0 Then Continue For

            If Channel = "01" Then mColumn(xMeasure) += 1 'If the identifier is 01 then add a B column in that measure
            For xI1 = 8 To Len(sLineTrim) - 1 Step 2   'For all Ks within that line ( - 1 can be ommitted )
                If Mid(sLineTrim, xI1, 2) = "00" Then Continue For 'If the K is not 00

                ReDim Preserve Notes(Notes.Length)

                With Notes(UBound(Notes))
                    .ColumnIndex = BMSChannelToColumn(Channel) +
                                        IIf(Channel = "01", 1, 0) * (mColumn(xMeasure) - 1)
                    .LongNote = IsChannelLongNote(Channel)
                    .Hidden = IsChannelHidden(Channel)
                    .Landmine = IsChannelLandmine(Channel)
                    .Selected = False
                    .VPosition = MeasureBottom(xMeasure) + MeasureLength(xMeasure) * (xI1 / 2 - 4) / ((Len(sLineTrim) - 7) / 2)
                    .Value = C36to10(Mid(sLineTrim, xI1, 2)) * 10000

                    If Channel = "03" Then .Value = Convert.ToInt32(Mid(sLineTrim, xI1, 2), 16) * 10000
                    If Channel = "08" Then .Value = hBPM(C36to10(Mid(sLineTrim, xI1, 2)))
                    If Channel = "09" Then .Value = hSTOP(C36to10(Mid(sLineTrim, xI1, 2)))
                    If Channel = "SC" Then .Value = hBMSCROLL(C36to10(Mid(sLineTrim, xI1, 2)))
                End With

            Next
        Next

        If NTInput Then ConvertBMSE2NT()

        LWAV.Visible = False
        LWAV.Items.Clear()
        LBMP.Visible = False
        LBMP.Items.Clear()
        For xI1 = 1 To 1295
            LWAV.Items.Add(C10to36(xI1) & ": " & hWAV(xI1))
            LBMP.Items.Add(C10to36(xI1) & ": " & hBMP(xI1))
        Next
        LWAV.SelectedIndex = 0
        LWAV.Visible = True
        LBMP.SelectedIndex = 0
        LBMP.Visible = True
        THLandMine.Text = hWAV(0)
        THMissBMP.Text = hBMP(0)

        TExpansion.Text = xExpansion

        SortByVPositionQuick(0, UBound(Notes))
        UpdatePairing()
        CalculateTotalPlayableNotes()
        CalculateGreatestVPosition()
        RefreshPanelAll()
        POStatusRefresh()
    End Sub

    ReadOnly BMSChannelList() As String = {"01", "03", "04", "06", "07", "08", "09",
                                       "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "1I", "1J", "1K", "1L", "1M", "1N", "1O", "1P", "1Q",
                                       "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "2G", "2H", "2I", "2J", "2K", "2L", "2M", "2N", "2O", "2P", "2Q",
                                       "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L", "3M", "3N", "3O", "3P", "3Q",
                                       "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4K", "4L", "4M", "4N", "4O", "4P", "4Q",
                                       "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5L", "5M", "5N", "5O", "5P", "5Q",
                                       "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "6G", "6H", "6I", "6J", "6K", "6L", "6M", "6N", "6O", "6P", "6Q",
                                       "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ",
                                       "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP", "EQ",
                                       "SC"}
    ' 71 through 89 are reserved
    '"71", "72", "73", "74", "75", "76", "78", "79",
    '"81", "82", "83", "84", "85", "86", "88", "89",


    Private Function SaveBMS() As String
        CalculateGreatestVPosition()
        SortByVPositionInsertion()
        UpdatePairing()
        Dim MeasureIndex As Integer
        Dim hasOverlapping As Boolean = False
        'Dim xStrAll As String = ""   'for all 
        Dim xStrMeasure(MeasureAtDisplacement(GreatestVPosition) + 1) As String

        ' We regenerate these when traversing the bms event list.
        ReDim hBPM(0)
        ReDim hSTOP(0)
        ReDim hBMSCROLL(0)

        Dim xNTInput As Boolean = NTInput
        Dim xKBackUp() As Note = Notes
        If xNTInput Then
            NTInput = False
            ConvertNT2BMSE()
        End If

        Dim tempNote As Note     'Temp K

        Dim xprevNotes(-1) As Note  'Notes too close to the next measure

        For MeasureIndex = 0 To MeasureAtDisplacement(GreatestVPosition) + 1  'For xI1 in each measure
            xStrMeasure(MeasureIndex) = vbCrLf

            Dim consistentDecimalStr = WriteDecimalWithDot(MeasureLength(MeasureIndex) / 192.0R)

            ' Handle fractional measure
            If MeasureLength(MeasureIndex) <> 192.0R Then xStrMeasure(MeasureIndex) &= "#" & Add3Zeros(MeasureIndex) & "02:" & consistentDecimalStr & vbCrLf

            ' Get note count in current measure
            Dim LowerLimit As Integer = Nothing
            Dim UpperLimit As Integer = Nothing
            GetMeasureLimits(MeasureIndex, LowerLimit, UpperLimit)

            If UpperLimit - LowerLimit = 0 Then Continue For 'If there is no K in the current measure then end this loop

            ' Get notes from this measure
            Dim xUPrevText As Integer = UBound(xprevNotes)
            Dim NotesInMeasure(UpperLimit - LowerLimit + xUPrevText) As Note

            ' Copy notes from previous array
            For i = 0 To xUPrevText
                NotesInMeasure(i) = xprevNotes(i)
            Next

            ' Copy notes in current measure
            For i = LowerLimit To UpperLimit - 1
                NotesInMeasure(i - LowerLimit + xprevNotes.Length) = Notes(i)
            Next

            ' Find greatest column.
            ' Since background tracks have the highest column values
            ' this - niB will yield the number of B columns.
            Dim GreatestColumn = 0
            For Each tempNote In NotesInMeasure
                GreatestColumn = Math.Max(tempNote.ColumnIndex, GreatestColumn)
            Next

            ReDim xprevNotes(-1)
            xStrMeasure(MeasureIndex) &= GenerateBackgroundTracks(MeasureIndex, hasOverlapping, NotesInMeasure, GreatestColumn, xprevNotes)
            xStrMeasure(MeasureIndex) &= GenerateKeyTracks(MeasureIndex, hasOverlapping, NotesInMeasure, xprevNotes)
        Next

        ' Warn about 255 limit if neccesary.
        If hasOverlapping Then MsgBox(Strings.Messages.SaveWarning & vbCrLf &
                                                          Strings.Messages.NoteOverlapError & vbCrLf &
                                                Strings.Messages.SavedFileWillContainErrors, MsgBoxStyle.Exclamation)
        If UBound(hBPM) > IIf(BPMx1296, 1295, 255) Then MsgBox(Strings.Messages.SaveWarning & vbCrLf &
                                                          Strings.Messages.BPMOverflowError & UBound(hBPM) & " > " & IIf(BPMx1296, 1295, 255) & vbCrLf &
                                                Strings.Messages.SavedFileWillContainErrors, MsgBoxStyle.Exclamation)
        If UBound(hSTOP) > IIf(STOPx1296, 1295, 255) Then MsgBox(Strings.Messages.SaveWarning & vbCrLf &
                                                           Strings.Messages.STOPOverflowError & UBound(hSTOP) & " > " & IIf(STOPx1296, 1295, 255) & vbCrLf &
                                                  Strings.Messages.SavedFileWillContainErrors, MsgBoxStyle.Exclamation)
        If UBound(hBMSCROLL) > 1295 Then MsgBox(Strings.Messages.SaveWarning & vbCrLf &
                                           Strings.Messages.SCROLLOverflowError & UBound(hBMSCROLL) & " > " & 1295 & vbCrLf &
                                         Strings.Messages.SavedFileWillContainErrors, MsgBoxStyle.Exclamation)

        ' Add expansion text
        Dim xStrExp As String = vbCrLf & "*---------------------- EXPANSION FIELD" & vbCrLf & TExpansion.Text & vbCrLf & vbCrLf
        If TExpansion.Text = "" Then xStrExp = ""

        ' Output main data field.
        Dim xStrMain As String = "*---------------------- MAIN DATA FIELD" & vbCrLf & vbCrLf & Join(xStrMeasure, "") & vbCrLf

        If xNTInput Then
            Notes = xKBackUp
            NTInput = True
        End If

        ' Generate headers now, since we have the unique BPM/STOP/etc declarations.
        Dim xStrHeader As String = GenerateHeaderMeta()
        xStrHeader &= GenerateHeaderIndexedData()

        Dim xStrAll As String = xStrHeader & vbCrLf & xStrExp & vbCrLf & xStrMain
        Return xStrAll
    End Function

    Private Function GenerateHeaderMeta() As String
        Dim xStrHeader As String = vbCrLf & "*---------------------- HEADER FIELD" & vbCrLf & vbCrLf
        xStrHeader &= "#PLAYER " & (CHPlayer.SelectedIndex + 1) & vbCrLf
        xStrHeader &= "#GENRE " & THGenre.Text & vbCrLf
        xStrHeader &= "#TITLE " & THTitle.Text & vbCrLf
        xStrHeader &= "#ARTIST " & THArtist.Text & vbCrLf
        xStrHeader &= "#BPM " & WriteDecimalWithDot(Notes(0).Value / 10000) & vbCrLf
        xStrHeader &= "#PLAYLEVEL " & THPlayLevel.Text & vbCrLf
        xStrHeader &= "#RANK " & CHRank.SelectedIndex & vbCrLf
        xStrHeader &= vbCrLf
        If THSubTitle.Text <> "" Then xStrHeader &= "#SUBTITLE " & THSubTitle.Text & vbCrLf
        If THSubArtist.Text <> "" Then xStrHeader &= "#SUBARTIST " & THSubArtist.Text & vbCrLf
        If THStageFile.Text <> "" Then xStrHeader &= "#STAGEFILE " & THStageFile.Text & vbCrLf
        If THBanner.Text <> "" Then xStrHeader &= "#BANNER " & THBanner.Text & vbCrLf
        If THBackBMP.Text <> "" Then xStrHeader &= "#BACKBMP " & THBackBMP.Text & vbCrLf
        xStrHeader &= vbCrLf
        If CHDifficulty.SelectedIndex Then xStrHeader &= "#DIFFICULTY " & CHDifficulty.SelectedIndex & vbCrLf
        If THExRank.Text <> "" Then xStrHeader &= "#DEFEXRANK " & THExRank.Text & vbCrLf
        If THTotal.Text <> "" Then xStrHeader &= "#TOTAL " & THTotal.Text & vbCrLf
        If THComment.Text <> "" Then xStrHeader &= "#COMMENT """ & THComment.Text & """" & vbCrLf
        'If THLnType.Text <> "" Then xStrHeader &= "#LNTYPE " & THLnType.Text & vbCrLf
        If CHLnObj.SelectedIndex > 0 Then xStrHeader &= "#LNOBJ " & C10to36(CHLnObj.SelectedIndex) & vbCrLf _
                                     Else xStrHeader &= "#LNTYPE 1" & vbCrLf
        If THPreview.Text <> "" Then xStrHeader &= "#PREVIEW " & THPreview.Text & vbCrLf
        If CHLnmode.SelectedIndex > 0 Then xStrHeader &= "#LNMODE " & CHLnmode.SelectedIndex & vbCrLf
        xStrHeader &= vbCrLf
        Return xStrHeader
    End Function

    Private Function GenerateHeaderIndexedData() As String
        Dim xStrHeader As String = ""

        For i = 0 To UBound(hWAV)
            If Not hWAV(i) = "" Then xStrHeader &= "#WAV" & C10to36(i) &
                                                    " " & hWAV(i) & vbCrLf
        Next
        For i = 0 To UBound(hBMP)
            If Not hBMP(i) = "" Then xStrHeader &= "#BMP" & C10to36(i) &
                                                    " " & hBMP(i) & vbCrLf
        Next
        For i = 1 To UBound(hBPM)
            xStrHeader &= "#BPM" &
            IIf(BPMx1296, C10to36(i), Mid("0" & Hex(i), Len(Hex(i)))) &
            " " & WriteDecimalWithDot(hBPM(i) / 10000) & vbCrLf
        Next
        For i = 1 To UBound(hSTOP)
            xStrHeader &= "#STOP" &
                IIf(STOPx1296, C10to36(i), Mid("0" & Hex(i), Len(Hex(i)))) &
                " " & WriteDecimalWithDot(hSTOP(i) / 10000) & vbCrLf
        Next
        For i = 1 To UBound(hBMSCROLL)
            xStrHeader &= "#SCROLL" &
                C10to36(i) & " " & WriteDecimalWithDot(hBMSCROLL(i) / 10000) & vbCrLf
        Next

        Return xStrHeader
    End Function

    Private Sub GetMeasureLimits(MeasureIndex As Integer, ByRef LowerLimit As Integer, ByRef UpperLimit As Integer)
        Dim NoteCount = UBound(Notes)
        LowerLimit = 0

        For i = 1 To NoteCount  'Collect Ks in the same measure
            If MeasureAtDisplacement(Notes(i).VPosition) >= MeasureIndex Then
                LowerLimit = i
                Exit For
            End If 'Lower limit found
        Next

        UpperLimit = 0

        For i = LowerLimit To NoteCount
            If MeasureAtDisplacement(Notes(i).VPosition) > MeasureIndex Then
                UpperLimit = i
                Exit For 'Upper limit found
            End If
        Next

        If UpperLimit < LowerLimit Then UpperLimit = NoteCount + 1
    End Sub

    Private Function GenerateKeyTracks(MeasureIndex As Integer, ByRef hasOverlapping As Boolean, NotesInMeasure() As Note, ByRef xprevNotes() As Note) As String
        Dim CurrentBMSChannel As String
        Dim Ret As String = ""

        For Each CurrentBMSChannel In BMSChannelList 'Start rendering other notes
            Dim relativeMeasurePos(-1) 'Ks in the same column
            Dim NoteStrings(-1)      'Ks in the same column

            ' Background tracks take care of this.
            If CurrentBMSChannel = "01" Then Continue For


            For NoteIndex = 0 To UBound(NotesInMeasure) 'Find Ks in the same column (xI4 is TK index)

                Dim currentNote As Note = NotesInMeasure(NoteIndex)
                If GetBMSChannelBy(currentNote) = CurrentBMSChannel Then

                    ReDim Preserve relativeMeasurePos(UBound(relativeMeasurePos) + 1)
                    ReDim Preserve NoteStrings(UBound(NoteStrings) + 1)
                    relativeMeasurePos(UBound(relativeMeasurePos)) = currentNote.VPosition - MeasureBottom(MeasureAtDisplacement(currentNote.VPosition))
                    If relativeMeasurePos(UBound(relativeMeasurePos)) < 0 Then relativeMeasurePos(UBound(relativeMeasurePos)) = 0

                    If CurrentBMSChannel = "03" Then 'If integer bpm
                        NoteStrings(UBound(NoteStrings)) = Mid("0" & Hex(currentNote.Value \ 10000), Len(Hex(currentNote.Value \ 10000)))
                    ElseIf CurrentBMSChannel = "08" Then 'If bpm requires declaration
                        Dim BpmIndex
                        For BpmIndex = 1 To UBound(hBPM) ' find BPM value in existing array
                            If currentNote.Value = hBPM(BpmIndex) Then Exit For
                        Next
                        If BpmIndex > UBound(hBPM) Then ' Didn't find it, add it
                            ReDim Preserve hBPM(UBound(hBPM) + 1)
                            hBPM(UBound(hBPM)) = currentNote.Value
                        End If
                        NoteStrings(UBound(NoteStrings)) = IIf(BPMx1296, C10to36(BpmIndex), Mid("0" & Hex(BpmIndex), Len(Hex(BpmIndex))))
                    ElseIf CurrentBMSChannel = "09" Then 'If STOP
                        Dim StopIndex
                        For StopIndex = 1 To UBound(hSTOP) ' find STOP value in existing array
                            If currentNote.Value = hSTOP(StopIndex) Then Exit For
                        Next

                        If StopIndex > UBound(hSTOP) Then ' Didn't find it, add it
                            ReDim Preserve hSTOP(UBound(hSTOP) + 1)
                            hSTOP(UBound(hSTOP)) = currentNote.Value
                        End If
                        NoteStrings(UBound(NoteStrings)) = IIf(STOPx1296, C10to36(StopIndex), Mid("0" & Hex(StopIndex), Len(Hex(StopIndex))))
                    ElseIf CurrentBMSChannel = "SC" Then 'If SCROLL
                        Dim ScrollIndex
                        For ScrollIndex = 1 To UBound(hBMSCROLL) ' find SCROLL value in existing array
                            If currentNote.Value = hBMSCROLL(ScrollIndex) Then Exit For
                        Next

                        If ScrollIndex > UBound(hBMSCROLL) Then ' Didn't find it, add it
                            ReDim Preserve hBMSCROLL(UBound(hBMSCROLL) + 1)
                            hBMSCROLL(UBound(hBMSCROLL)) = currentNote.Value
                        End If
                        NoteStrings(UBound(NoteStrings)) = C10to36(ScrollIndex)
                    Else
                        NoteStrings(UBound(NoteStrings)) = C10to36(currentNote.Value \ 10000)
                    End If
                End If
            Next

            If relativeMeasurePos.Length = 0 Then Continue For

            Dim xGCD As Double = MeasureLength(MeasureIndex)
            For i = 0 To UBound(relativeMeasurePos)        'find greatest common divisor
                If relativeMeasurePos(i) > 0 Then xGCD = GCD(xGCD, relativeMeasurePos(i))
            Next

            Dim xStrKey() As String
            ReDim xStrKey(CInt(MeasureLength(MeasureIndex) / xGCD) - 1)
            For i = 0 To UBound(xStrKey)           'assign 00 to all keys
                xStrKey(i) = "00"
            Next

            For i = 0 To UBound(relativeMeasurePos)        'assign K texts
                If CInt(relativeMeasurePos(i) / xGCD) > UBound(xStrKey) Then
                    ReDim Preserve xprevNotes(UBound(xprevNotes) + 1)
                    With xprevNotes(UBound(xprevNotes))
                        .ColumnIndex = BMSChannelToColumn(BMSChannelList(CurrentBMSChannel))
                        .LongNote = IsChannelLongNote(BMSChannelList(CurrentBMSChannel))
                        .Hidden = IsChannelHidden(BMSChannelList(CurrentBMSChannel))
                        .VPosition = MeasureBottom(MeasureIndex)
                        .Value = C36to10(NoteStrings(i))
                    End With
                    If BMSChannelList(CurrentBMSChannel) = "08" Then _
                        xprevNotes(UBound(xprevNotes)).Value = IIf(BPMx1296, hBPM(C36to10(NoteStrings(i))), hBPM(Convert.ToInt32(NoteStrings(i), 16)))
                    If BMSChannelList(CurrentBMSChannel) = "09" Then _
                        xprevNotes(UBound(xprevNotes)).Value = IIf(STOPx1296, hSTOP(C36to10(NoteStrings(i))), hSTOP(Convert.ToInt32(NoteStrings(i), 16)))
                    If BMSChannelList(CurrentBMSChannel) = "SC" Then _
                        xprevNotes(UBound(xprevNotes)).Value = hBMSCROLL(C36to10(NoteStrings(i)))
                    Continue For
                End If
                If xStrKey(CInt(relativeMeasurePos(i) / xGCD)) <> "00" Then
                    hasOverlapping = True
                End If

                xStrKey(CInt(relativeMeasurePos(i) / xGCD)) = NoteStrings(i)
            Next

            Ret &= "#" & Add3Zeros(MeasureIndex) & CurrentBMSChannel & ":" & Join(xStrKey, "") & vbCrLf
        Next

        Return Ret
    End Function

    Private Function GenerateBackgroundTracks(MeasureIndex As Integer, ByRef hasOverlapping As Boolean, NotesInMeasure() As Note, GreatestColumn As Integer, ByRef xprevNotes() As Note) As String
        Dim relativeNotePositions() As Double 'Ks in the same column
        Dim noteStrings() As String    'Ks in the same column
        Dim Ret As String = ""

        For ColIndex = niB To GreatestColumn 'Start rendering B notes (xI3 is columnindex)
            ReDim relativeNotePositions(-1) 'Ks in the same column
            ReDim noteStrings(-1)      'Ks in the same column

            For I = 0 To UBound(NotesInMeasure) 'Find Ks in the same column (xI4 is TK index)
                If NotesInMeasure(I).ColumnIndex = ColIndex Then

                    ReDim Preserve relativeNotePositions(UBound(relativeNotePositions) + 1)
                    ReDim Preserve noteStrings(UBound(noteStrings) + 1)

                    relativeNotePositions(UBound(relativeNotePositions)) = NotesInMeasure(I).VPosition - MeasureBottom(MeasureAtDisplacement(NotesInMeasure(I).VPosition))
                    If relativeNotePositions(UBound(relativeNotePositions)) < 0 Then relativeNotePositions(UBound(relativeNotePositions)) = 0

                    noteStrings(UBound(noteStrings)) = C10to36(NotesInMeasure(I).Value \ 10000)
                End If
            Next

            Dim xGCD As Double = MeasureLength(MeasureIndex)
            For i = 0 To UBound(relativeNotePositions)        'find greatest common divisor
                If relativeNotePositions(i) > 0 Then xGCD = GCD(xGCD, relativeNotePositions(i))
            Next

            Dim xStrKey(CInt(MeasureLength(MeasureIndex) / xGCD) - 1) As String
            For i = 0 To UBound(xStrKey)           'assign 00 to all keys
                xStrKey(i) = "00"
            Next

            For i = 0 To UBound(relativeNotePositions)        'assign K texts
                If CInt(relativeNotePositions(i) / xGCD) > UBound(xStrKey) Then

                    ReDim Preserve xprevNotes(UBound(xprevNotes) + 1)

                    With xprevNotes(UBound(xprevNotes))
                        .ColumnIndex = ColIndex
                        .VPosition = MeasureBottom(MeasureIndex)
                        .Value = C36to10(noteStrings(i))
                    End With

                    Continue For
                End If
                If xStrKey(CInt(relativeNotePositions(i) / xGCD)) <> "00" Then hasOverlapping = True
                xStrKey(CInt(relativeNotePositions(i) / xGCD)) = noteStrings(i)
            Next

            Ret &= "#" & Add3Zeros(MeasureIndex) & "01:" & Join(xStrKey, "") & vbCrLf
        Next

        Return Ret
    End Function

    Private Function OpenSM(ByVal xStrAll As String) As Boolean
        KMouseOver = -1

        Dim xStrLine() As String = Split(xStrAll, vbCrLf)
        'Remove comments starting with "//"
        For xI1 As Integer = 0 To UBound(xStrLine)
            If xStrLine(xI1).Contains("//") Then xStrLine(xI1) = Mid(xStrLine(xI1), 1, InStr(xStrLine(xI1), "//") - 1)
        Next

        xStrAll = Join(xStrLine, "")
        xStrLine = Split(xStrAll, ";")

        Dim iDiff As Integer = 0
        Dim iCurrentDiff As Integer = 0
        Dim xTempSplit() As String = Split(xStrAll, "#NOTES:")
        Dim xTempStr() As String = {}
        If xTempSplit.Length > 2 Then
            ReDim Preserve xTempStr(UBound(xTempSplit) - 1)
            For xI1 As Integer = 1 To UBound(xTempSplit)
                xTempSplit(xI1) = Mid(xTempSplit(xI1), InStr(xTempSplit(xI1), ":") + 1)
                xTempSplit(xI1) = Mid(xTempSplit(xI1), InStr(xTempSplit(xI1), ":") + 1).Trim
                xTempStr(xI1 - 1) = Mid(xTempSplit(xI1), 1, InStr(xTempSplit(xI1), ":") - 1)
                xTempSplit(xI1) = Mid(xTempSplit(xI1), InStr(xTempSplit(xI1), ":") + 1).Trim
                xTempStr(xI1 - 1) &= " : " & Mid(xTempSplit(xI1), 1, InStr(xTempSplit(xI1), ":") - 1)
            Next

            Dim xDiag As New dgImportSM(xTempStr)
            If xDiag.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then Return True
            iDiff = xDiag.iResult
        End If

        Dim sL As String
        ReDim Notes(0)
        ReDim mColumn(999)
        ReDim hWAV(1295)
        ReDim hBMP(1295)
        ReDim hBPM(1295)    'x10000
        ReDim hSTOP(1295)
        ReDim hBMSCROLL(1295)
        Me.InitializeNewBMS()

        With Notes(0)
            .ColumnIndex = niBPM
            .VPosition = -1
            '.LongNote = False
            '.Selected = False
            .Value = 1200000
        End With

        For Each sL In xStrLine
            If UCase(sL).StartsWith("#TITLE:") Then
                THTitle.Text = Mid(sL, Len("#TITLE:") + 1)

            ElseIf UCase(sL).StartsWith("#SUBTITLE:") Then
                If Not UCase(sL).EndsWith("#SUBTITLE:") Then THTitle.Text &= " " & Mid(sL, Len("#SUBTITLE:") + 1)

            ElseIf UCase(sL).StartsWith("#ARTIST:") Then
                THArtist.Text = Mid(sL, Len("#ARTIST:") + 1)

            ElseIf UCase(sL).StartsWith("#GENRE:") Then
                THGenre.Text = Mid(sL, Len("#GENRE:") + 1)

            ElseIf UCase(sL).StartsWith("#BPMS:") Then
                Dim xLine As String = Mid(sL, Len("#BPMS:") + 1)
                Dim xItem() As String = Split(xLine, ",")

                Dim xVal1 As Double
                Dim xVal2 As Double

                For xI1 As Integer = 0 To UBound(xItem)
                    xVal1 = Mid(xItem(xI1), 1, InStr(xItem(xI1), "=") - 1)
                    xVal2 = Mid(xItem(xI1), InStr(xItem(xI1), "=") + 1)

                    If xVal1 <> 0 Then
                        ReDim Preserve Notes(Notes.Length)
                        With Notes(UBound(Notes))
                            .ColumnIndex = niBPM
                            '.LongNote = False
                            '.Hidden = False
                            '.Selected = False
                            .VPosition = xVal1 * 48
                            .Value = xVal2 * 10000
                        End With
                    Else
                        Notes(0).Value = xVal2 * 10000
                    End If
                Next

            ElseIf UCase(sL).StartsWith("#NOTES:") Then
                If iCurrentDiff <> iDiff Then iCurrentDiff += 1 : GoTo Jump1

                iCurrentDiff += 1
                Dim xLine As String = Mid(sL, Len("#NOTES:") + 1)
                Dim xItem() As String = Split(xLine, ":")
                For xI1 As Integer = 0 To UBound(xItem)
                    xItem(xI1) = xItem(xI1).Trim
                Next

                If xItem.Length <> 6 Then GoTo Jump1

                THPlayLevel.Text = xItem(3)

                Dim xM() As String = Split(xItem(5), ",")
                For xI1 As Integer = 0 To UBound(xM)
                    xM(xI1) = xM(xI1).Trim
                Next

                For xI1 As Integer = 0 To UBound(xM)
                    For xI2 As Integer = 0 To Len(xM(xI1)) - 1 Step 4
                        If xM(xI1)(xI2) <> "0" Then
                            ReDim Preserve Notes(Notes.Length)
                            With Notes(UBound(Notes))
                                .ColumnIndex = niA1
                                .LongNote = xM(xI1)(xI2) = "2" Or xM(xI1)(xI2) = "3"
                                '.Hidden = False
                                '.Selected = False
                                .VPosition = (192 \ (Len(xM(xI1)) \ 4)) * xI2 \ 4 + xI1 * 192
                                .Value = 10000
                            End With
                        End If
                        If xM(xI1)(xI2 + 1) <> "0" Then
                            ReDim Preserve Notes(Notes.Length)
                            With Notes(UBound(Notes))
                                .ColumnIndex = niA2
                                .LongNote = xM(xI1)(xI2 + 1) = "2" Or xM(xI1)(xI2 + 1) = "3"
                                '.Hidden = False
                                '.Selected = False
                                .VPosition = (192 \ (Len(xM(xI1)) \ 4)) * xI2 \ 4 + xI1 * 192
                                .Value = 10000
                            End With
                        End If
                        If xM(xI1)(xI2 + 2) <> "0" Then
                            ReDim Preserve Notes(Notes.Length)
                            With Notes(UBound(Notes))
                                .ColumnIndex = niA3
                                .LongNote = xM(xI1)(xI2 + 2) = "2" Or xM(xI1)(xI2 + 2) = "3"
                                '.Hidden = False
                                '.Selected = False
                                .VPosition = (192 \ (Len(xM(xI1)) \ 4)) * xI2 \ 4 + xI1 * 192
                                .Value = 10000
                            End With
                        End If
                        If xM(xI1)(xI2 + 3) <> "0" Then
                            ReDim Preserve Notes(Notes.Length)
                            With Notes(UBound(Notes))
                                .ColumnIndex = niA4
                                .LongNote = xM(xI1)(xI2 + 3) = "2" Or xM(xI1)(xI2 + 3) = "3"
                                '.Hidden = False
                                '.Selected = False
                                .VPosition = (192 \ (Len(xM(xI1)) \ 4)) * xI2 \ 4 + xI1 * 192
                                .Value = 10000
                            End With
                        End If
                    Next
                Next
Jump1:
            End If
        Next

        If NTInput Then ConvertBMSE2NT()

        LWAV.Visible = False
        LWAV.Items.Clear()
        LBMP.Visible = False
        LBMP.Items.Clear()
        For xI1 As Integer = 1 To 1295
            LWAV.Items.Add(C10to36(xI1) & ": " & hWAV(xI1))
            LBMP.Items.Add(C10to36(xI1) & ": " & hBMP(xI1))
        Next
        LWAV.SelectedIndex = 0
        LWAV.Visible = True
        LBMP.SelectedIndex = 0
        LBMP.Visible = True

        THBPM.Value = Notes(0).Value / 10000
        SortByVPositionQuick(0, UBound(Notes))
        UpdatePairing()
        CalculateTotalPlayableNotes()
        CalculateGreatestVPosition()
        RefreshPanelAll()
        POStatusRefresh()
        Return False
    End Function

    ''' <summary>Do not clear Undo.</summary>
    Private Sub OpeniBMSC(ByVal Path As String)
        KMouseOver = -1

        Dim br As New BinaryReader(New FileStream(Path, FileMode.Open, FileAccess.Read), System.Text.Encoding.Unicode)

        If br.ReadInt32 <> &H534D4269 Then GoTo EndOfSub
        If br.ReadByte <> CByte(&H43) Then GoTo EndOfSub
        Dim xMajor As Integer = br.ReadByte
        Dim xMinor As Integer = br.ReadByte
        Dim xBuild As Integer = br.ReadByte

        ClearUndo()
        ReDim Notes(0)
        ReDim mColumn(999)
        ReDim hWAV(1295)
        ReDim hBMP(1295)
        Me.InitializeNewBMS()
        Me.InitializeOpenBMS()

        Notes(0) = New Note
        With Notes(0)
            .ColumnIndex = niBPM
            .VPosition = -1
            '.LongNote = False
            '.Selected = False
            .Value = 1200000
        End With

        Do Until br.BaseStream.Position >= br.BaseStream.Length
            Dim BlockID As Integer = br.ReadInt32()

            Select Case BlockID

                Case &H66657250     'Preferences
                    Dim xPref As Integer = br.ReadInt32

                    NTInput = xPref And &H1
                    TBNTInput.Checked = NTInput
                    mnNTInput.Checked = NTInput
                    POBLong.Enabled = Not NTInput
                    POBLongShort.Enabled = Not NTInput

                    ErrorCheck = xPref And &H2
                    TBErrorCheck.Checked = ErrorCheck
                    TBErrorCheck_Click(TBErrorCheck, New System.EventArgs)

                    PreviewOnClick = xPref And &H4
                    TBPreviewOnClick.Checked = PreviewOnClick
                    TBPreviewOnClick_Click(TBPreviewOnClick, New System.EventArgs)

                    ShowFileName = xPref And &H8
                    TBShowFileName.Checked = ShowFileName
                    TBShowFileName_Click(TBShowFileName, New System.EventArgs)

                    Rscratch = xPref And &H10
                    If TBChangePlaySide.Checked <> Rscratch Then
                        TBChangePlaySide.Checked = Rscratch
                        TBChangePlaySide_Click(TBChangePlaySide, New System.EventArgs)
                    Else
                        TBChangePlaySide.Checked = Rscratch
                    End If

                    mnSMenu.Checked = xPref And &H100
                    mnSTB.Checked = xPref And &H200
                    mnSOP.Checked = xPref And &H400
                    mnSStatus.Checked = xPref And &H800
                    mnSLSplitter.Checked = xPref And &H1000
                    mnSRSplitter.Checked = xPref And &H2000

                    CGShow.Checked = xPref And &H4000
                    CGShowS.Checked = xPref And &H8000
                    CGShowBG.Checked = xPref And &H10000
                    CGShowM.Checked = xPref And &H20000
                    CGShowMB.Checked = xPref And &H40000
                    CGShowV.Checked = xPref And &H80000
                    CGShowC.Checked = xPref And &H100000
                    CGBLP.Checked = xPref And &H200000
                    CGSTOP.Checked = xPref And &H400000
                    CGSCROLL.Checked = xPref And &H20000000
                    CGBPM.Checked = xPref And &H800000

                    CGSnap.Checked = xPref And &H1000000
                    CGDisableVertical.Checked = xPref And &H2000000
                    cVSLockL.Checked = xPref And &H4000000
                    cVSLock.Checked = xPref And &H8000000
                    cVSLockR.Checked = xPref And &H10000000

                    CGDivide.Value = br.ReadInt32
                    CGSub.Value = br.ReadInt32
                    gSlash = br.ReadInt32
                    CGHeight.Value = br.ReadSingle
                    CGWidth.Value = br.ReadSingle
                    CGB.Value = br.ReadInt32

                Case &H64616548     'Header
                    THTitle.Text = br.ReadString
                    THArtist.Text = br.ReadString
                    THGenre.Text = br.ReadString
                    Notes(0).Value = br.ReadInt64
                    Dim xPlayerRank As Integer = br.ReadByte
                    THPlayLevel.Text = br.ReadString

                    CHPlayer.SelectedIndex = xPlayerRank And &HF
                    CHRank.SelectedIndex = xPlayerRank >> 4

                    THSubTitle.Text = br.ReadString
                    THSubArtist.Text = br.ReadString
                    'THMaker.Text = br.ReadString
                    THStageFile.Text = br.ReadString
                    THBanner.Text = br.ReadString
                    THBackBMP.Text = br.ReadString
                    'THMidiFile.Text = br.ReadString
                    CHDifficulty.SelectedIndex = br.ReadByte
                    THExRank.Text = br.ReadString
                    THTotal.Text = br.ReadString
                    'THVolWAV.Text = br.ReadString
                    THComment.Text = br.ReadString
                    'THLnType.Text = br.ReadString
                    CHLnObj.SelectedIndex = br.ReadInt16
                    THPreview.Text = br.ReadString
                    CHLnmode.SelectedIndex = br.ReadByte

                Case &H564157       'WAV List
                    Dim xWAVOptions As Integer = br.ReadByte
                    WAVMultiSelect = xWAVOptions And &H1
                    CWAVMultiSelect.Checked = WAVMultiSelect
                    CWAVMultiSelect_CheckedChanged(CWAVMultiSelect, New EventArgs)
                    WAVChangeLabel = xWAVOptions And &H2
                    CWAVChangeLabel.Checked = WAVChangeLabel
                    CWAVChangeLabel_CheckedChanged(CWAVChangeLabel, New EventArgs)
                    WAVEmptyfill = xWAVOptions And &H4
                    CWAVEmptyfill.Checked = WAVEmptyfill
                    CWAVEmptyfill_CheckedChanged(CWAVEmptyfill, New EventArgs)

                    Dim xWAVCount As Integer = br.ReadInt32
                    For xxi As Integer = 1 To xWAVCount
                        Dim xI As Integer = br.ReadInt16
                        hWAV(xI) = br.ReadString
                    Next

                Case &H504D42       'BMP List

                    Dim xBMPCount As Integer = br.ReadInt32
                    For xxi As Integer = 1 To xBMPCount
                        Dim xI As Integer = br.ReadInt16
                        hBMP(xI) = br.ReadString
                    Next

                Case &H74616542     'Beat
                    nBeatN.Value = br.ReadInt16
                    nBeatD.Value = br.ReadInt16
                    'nBeatD.SelectedIndex = br.ReadByte

                    Dim xBeatChangeMode As Integer = br.ReadByte
                    Dim xBeatChangeList As RadioButton() = {CBeatPreserve, CBeatMeasure, CBeatCut, CBeatScale}
                    xBeatChangeList(xBeatChangeMode).Checked = True
                    CBeatPreserve_Click(xBeatChangeList(xBeatChangeMode), New System.EventArgs)

                    Dim xBeatCount As Integer = br.ReadInt32
                    For xxi As Integer = 1 To xBeatCount
                        Dim xIndex As Integer = br.ReadInt16
                        MeasureLength(xIndex) = br.ReadDouble
                        Dim xRatio As Double = MeasureLength(xIndex) / 192.0R
                        Dim xxD As Long = GetDenominator(xRatio)
                        LBeat.Items(xIndex) = Add3Zeros(xIndex) & ": " & xRatio & IIf(xxD > 10000, "", " ( " & CLng(xRatio * xxD) & " / " & xxD & " ) ")
                    Next

                Case &H6E707845     'Expansion Code
                    TExpansion.Text = br.ReadString

                Case &H65746F4E     'Note
                    Dim xNoteUbound As Integer = br.ReadInt32
                    ReDim Preserve Notes(xNoteUbound)
                    For i As Integer = 1 To UBound(Notes)
                        Notes(i) = New Note
                        Notes(i).FromBinReader(br)
                    Next

                Case &H6F646E55     'Undo / Redo Commands
                    Dim URCount As Integer = br.ReadInt32   'Should be 100
                    sI = br.ReadInt32

                    For xI As Integer = 0 To 99
                        Dim xUndoCount As Integer = br.ReadInt32
                        Dim xBaseUndo As New UndoRedo.Void
                        Dim xIteratorUndo As UndoRedo.LinkedURCmd = xBaseUndo

                        For xxj As Integer = 1 To xUndoCount
                            Dim xByteLen As Integer = br.ReadInt32
                            Dim xByte() As Byte = br.ReadBytes(xByteLen)
                            xIteratorUndo.Next = UndoRedo.fromBytes(xByte)
                            xIteratorUndo = xIteratorUndo.Next
                        Next

                        sUndo(xI) = xBaseUndo.Next

                        Dim xRedoCount As Integer = br.ReadInt32
                        Dim xBaseRedo As New UndoRedo.Void
                        Dim xIteratorRedo As UndoRedo.LinkedURCmd = xBaseRedo
                        For xxj As Integer = 1 To xRedoCount
                            Dim xByteLen As Integer = br.ReadInt32
                            Dim xByte() As Byte = br.ReadBytes(xByteLen)
                            xIteratorRedo.Next = UndoRedo.fromBytes(xByte)
                            xIteratorRedo = xIteratorRedo.Next
                        Next
                        sRedo(xI) = xBaseRedo.Next
                    Next

            End Select
        Loop

EndOfSub:
        br.Close()

        TBUndo.Enabled = sUndo(sI).ofType <> UndoRedo.opNoOperation
        TBRedo.Enabled = sRedo(sIA).ofType <> UndoRedo.opNoOperation
        mnUndo.Enabled = sUndo(sI).ofType <> UndoRedo.opNoOperation
        mnRedo.Enabled = sRedo(sIA).ofType <> UndoRedo.opNoOperation

        LBMP.Visible = False
        LBMP.Items.Clear()
        LWAV.Visible = False
        LWAV.Items.Clear()
        For xI1 As Integer = 1 To 1295
            LWAV.Items.Add(C10to36(xI1) & ": " & hWAV(xI1))
            LBMP.Items.Add(C10to36(xI1) & ": " & hBMP(xI1))
        Next
        LWAV.SelectedIndex = 0
        LWAV.Visible = True
        LBMP.SelectedIndex = 0
        LBMP.Visible = True

        THLandMine.Text = hWAV(0)
        THMissBMP.Text = hBMP(0)

        THBPM.Value = Notes(0).Value / 10000
        SortByVPositionQuick(0, UBound(Notes))
        UpdatePairing()
        UpdateMeasureBottom()
        CalculateTotalPlayableNotes()
        CalculateGreatestVPosition()
        RefreshPanelAll()
        POStatusRefresh()
    End Sub

    Private Sub SaveiBMSC(ByVal Path As String)
        CalculateGreatestVPosition()
        SortByVPositionInsertion()
        UpdatePairing()

        Try

            Dim bw As New BinaryWriter(New IO.FileStream(Path, FileMode.Create), System.Text.Encoding.Unicode)

            'bw.Write("iBMSC".ToCharArray)
            bw.Write(&H534D4269)
            bw.Write(CByte(&H43))
            bw.Write(CByte(My.Application.Info.Version.Major))
            bw.Write(CByte(My.Application.Info.Version.Minor))
            bw.Write(CByte(My.Application.Info.Version.Build))

            'Preferences
            'bw.Write("Pref".ToCharArray)
            bw.Write(&H66657250)
            Dim xPref As Integer = 0
            If NTInput Then xPref = xPref Or &H1
            If ErrorCheck Then xPref = xPref Or &H2
            If PreviewOnClick Then xPref = xPref Or &H4
            If ShowFileName Then xPref = xPref Or &H8
            If Rscratch Then xPref = xPref Or &H10
            If mnSMenu.Checked Then xPref = xPref Or &H100
            If mnSTB.Checked Then xPref = xPref Or &H200
            If mnSOP.Checked Then xPref = xPref Or &H400
            If mnSStatus.Checked Then xPref = xPref Or &H800
            If mnSLSplitter.Checked Then xPref = xPref Or &H1000
            If mnSRSplitter.Checked Then xPref = xPref Or &H2000
            If gShowGrid Then xPref = xPref Or &H4000
            If gShowSubGrid Then xPref = xPref Or &H8000
            If gShowBG Then xPref = xPref Or &H10000
            If gShowMeasureNumber Then xPref = xPref Or &H20000
            If gShowMeasureBar Then xPref = xPref Or &H40000
            If gShowVerticalLine Then xPref = xPref Or &H80000
            If gShowC Then xPref = xPref Or &H100000
            If gDisplayBGAColumn Then xPref = xPref Or &H200000
            If gSTOP Then xPref = xPref Or &H400000
            If gBPM Then xPref = xPref Or &H800000
            If gSCROLL Then xPref = xPref Or &H20000000
            If gSnap Then xPref = xPref Or &H1000000
            If DisableVerticalMove Then xPref = xPref Or &H2000000
            If spLock(0) Then xPref = xPref Or &H4000000
            If spLock(1) Then xPref = xPref Or &H8000000
            If spLock(2) Then xPref = xPref Or &H10000000
            bw.Write(xPref)
            bw.Write(BitConverter.GetBytes(gDivide))
            bw.Write(BitConverter.GetBytes(gSub))
            bw.Write(BitConverter.GetBytes(gSlash))
            bw.Write(BitConverter.GetBytes(gxHeight))
            bw.Write(BitConverter.GetBytes(gxWidth))
            bw.Write(BitConverter.GetBytes(gColumns))

            'Header
            'bw.Write("Head".ToCharArray)
            bw.Write(&H64616548)
            bw.Write(THTitle.Text)
            bw.Write(THArtist.Text)
            bw.Write(THGenre.Text)
            bw.Write(Notes(0).Value)
            Dim xPlayer As Integer = CHPlayer.SelectedIndex
            Dim xRank As Integer = CHRank.SelectedIndex << 4
            bw.Write(CByte(xPlayer Or xRank))
            bw.Write(THPlayLevel.Text)

            bw.Write(THSubTitle.Text)
            bw.Write(THSubArtist.Text)
            'bw.Write(THMaker.Text)
            bw.Write(THStageFile.Text)
            bw.Write(THBanner.Text)
            bw.Write(THBackBMP.Text)
            'bw.Write(THMidiFile.Text)
            bw.Write(CByte(CHDifficulty.SelectedIndex))
            bw.Write(THExRank.Text)
            bw.Write(THTotal.Text)
            'bw.Write(THVolWAV.Text)
            bw.Write(THComment.Text)
            'bw.Write(THLnType.Text)
            bw.Write(CShort(CHLnObj.SelectedIndex))
            bw.Write(THPreview.Text)
            bw.Write(CByte(CHLnmode.SelectedIndex))

            'Wav List
            'bw.Write(("WAV" & vbNullChar).ToCharArray)
            bw.Write(&H564157)

            Dim xWAVOptions As Integer = 0
            If WAVMultiSelect Then xWAVOptions = xWAVOptions Or &H1
            If WAVChangeLabel Then xWAVOptions = xWAVOptions Or &H2
            If WAVEmptyfill Then xWAVOptions = xWAVOptions Or &H4
            bw.Write(CByte(xWAVOptions))

            Dim xWAVCount As Integer = 0
            For i As Integer = 0 To UBound(hWAV)
                If hWAV(i) <> "" Then xWAVCount += 1
            Next
            bw.Write(xWAVCount)

            For i As Integer = 0 To UBound(hWAV)
                If hWAV(i) = "" Then Continue For
                bw.Write(CShort(i))
                bw.Write(hWAV(i))
            Next

            'Bmp List
            'bw.Write(("BMP" & vbNullChar).ToCharArray)
            bw.Write(&H504D42)

            Dim xBMPCount As Integer = 0
            For i As Integer = 0 To UBound(hBMP)
                If hBMP(i) <> "" Then xBMPCount += 1
            Next
            bw.Write(xBMPCount)

            For i As Integer = 0 To UBound(hBMP)
                If hBMP(i) = "" Then Continue For
                bw.Write(CShort(i))
                bw.Write(hBMP(i))
            Next

            'Beat
            'bw.Write("Beat".ToCharArray)
            bw.Write(&H74616542)
            'Dim xNumerator As Short = nBeatN.Value
            'Dim xDenominator As Short = nBeatD.Value
            'Dim xBeatChangeMode As Byte = BeatChangeMode
            bw.Write(CShort(nBeatN.Value))
            bw.Write(CShort(nBeatD.Value))
            bw.Write(CByte(BeatChangeMode))

            Dim xBeatCount As Integer = 0
            For i As Integer = 0 To UBound(MeasureLength)
                If MeasureLength(i) <> 192.0R Then xBeatCount += 1
            Next
            bw.Write(xBeatCount)

            For i As Integer = 0 To UBound(MeasureLength)
                If MeasureLength(i) = 192.0R Then Continue For
                bw.Write(CShort(i))
                bw.Write(MeasureLength(i))
            Next

            'Expansion Code
            'bw.Write("Expn".ToCharArray)
            bw.Write(&H6E707845)
            bw.Write(TExpansion.Text)

            'Note
            'bw.Write("Note".ToCharArray)
            bw.Write(&H65746F4E)
            bw.Write(UBound(Notes))
            For i As Integer = 1 To UBound(Notes)
                Notes(i).WriteBinWriter(bw)
            Next

            'Undo / Redo Commands
            'bw.Write("Undo".ToCharArray)
            bw.Write(&H6F646E55)
            bw.Write(100)
            bw.Write(sI)

            For i As Integer = 0 To 99
                'UndoCommandsCount
                Dim countUndo As Integer = 0
                Dim pUndo As UndoRedo.LinkedURCmd = sUndo(i)
                While pUndo IsNot Nothing
                    countUndo += 1
                    pUndo = pUndo.Next
                End While
                bw.Write(countUndo)

                'UndoCommands
                pUndo = sUndo(i)
                For xxi As Integer = 1 To countUndo
                    Dim bUndo() As Byte = pUndo.toBytes
                    bw.Write(bUndo.Length)  'Length
                    bw.Write(bUndo)         'Command
                    pUndo = pUndo.Next
                Next

                'RedoCommandsCount
                Dim countRedo As Integer = 0
                Dim pRedo As UndoRedo.LinkedURCmd = sRedo(i)
                While pRedo IsNot Nothing
                    countRedo += 1
                    pRedo = pRedo.Next
                End While
                bw.Write(countRedo)

                'RedoCommands
                pRedo = sRedo(i)
                For xxi As Integer = 1 To countRedo
                    Dim bRedo() As Byte = pRedo.toBytes
                    bw.Write(bRedo.Length)
                    bw.Write(bRedo)
                    pRedo = pRedo.Next
                Next
            Next

            bw.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub SaveBMSON(ByVal Path As String)
        CalculateGreatestVPosition()
        SortByVPositionInsertion()
        UpdatePairing()
        Dim i = 0
        Try
            Dim format = New Bmson
            Dim options = New JsonSerializerOptions

            Dim bar_list = New List(Of BarLine)()
            Dim wav_list = New Dictionary(Of Integer, SoundChannel)()
            Dim note_list = New Dictionary(Of Integer, List(Of BmsonNote))()
            Dim mine_list = New List(Of MineNote)()
            Dim hidden_list = New Dictionary(Of Integer, MineChannel)()
            Dim hidden_note_list = New Dictionary(Of Integer, List(Of MineNote))()
            Dim bmp_list = New List(Of BGAHeader)()
            Dim bga_list = New List(Of BGAEvent)()
            Dim layer_list = New List(Of BGAEvent)()
            Dim miss_list = New List(Of BGAEvent)()
            Dim bpm_list = New List(Of BpmEvent)()
            Dim stop_list = New List(Of StopEvent)()
            Dim scroll_list = New List(Of ScrollEvent)()

            ' ヘッダ情報
            format.info.title = THTitle.Text
            format.info.subtitle = THSubTitle.Text
            format.info.artist = THArtist.Text
            format.info.subartists(0) = THSubArtist.Text
            format.info.genre = THGenre.Text
            If CHPlayer.SelectedIndex = 0 Then
                format.info.mode_hint = "beat-5k"
            Else
                format.info.mode_hint = "popn-9k"
            End If
            format.info.chart_name = ""
            If THExRank.Text <> "" Then
                format.info.judge_rank = CDbl(THExRank.Text)
            Else
                format.info.judge_rank = (CHRank.SelectedIndex + 1) * 25
            End If
            If THTotal.Text <> "" Then
                format.info.total = CalcBMSONTotal(CDbl(THTotal.Text))
            Else
                format.info.total = CalcBMSONTotal(CalcBMSTotal())
            End If
            format.info.init_bpm = CDbl(THBPM.Text)
            If THPlayLevel.Text <> "" Then
                format.info.level = CInt(THPlayLevel.Text)
            Else
                format.info.level = 0
            End If
            format.info.back_image = THBackBMP.Text
            format.info.eyecatch_image = THStageFile.Text
            format.info.banner_image = THBanner.Text
            format.info.preview_music = THPreview.Text
            format.info.ln_type = CHLnmode.SelectedIndex

            ' 必要な分解能を計算
            Dim xGCD As Double = 192.0R
            For i = 0 To UBound(Notes)
                xGCD = GCD(xGCD, Notes(i).VPosition, 1920000)
                ' ついでにプレイモードを検出
                If format.info.mode_hint = "beat-5k" AndAlso
                   GetColumn(Notes(i).ColumnIndex).Identifier >= (36 + 8) AndAlso GetColumn(Notes(i).ColumnIndex).Identifier <= (36 + 9) Then
                    format.info.mode_hint = "beat-7k"
                End If
                If format.info.mode_hint = "beat-5k" AndAlso
                   GetColumn(Notes(i).ColumnIndex).Identifier >= 72 AndAlso GetColumn(Notes(i).ColumnIndex).Identifier <= (72 + 5) Then
                    format.info.mode_hint = "beat-10k"
                End If
                If format.info.mode_hint = "popn-9k" AndAlso
                    (GetColumn(Notes(i).ColumnIndex).Identifier Mod 36 = 6 OrElse GetColumn(Notes(i).ColumnIndex).Identifier = (72 + 1)) Then
                    format.info.mode_hint = "beat-10k"
                End If
                If (format.info.mode_hint = "beat-10k" OrElse format.info.mode_hint = "popn-9k") AndAlso
                   GetColumn(Notes(i).ColumnIndex).Identifier >= (36 + 8) AndAlso GetColumn(Notes(i).ColumnIndex).Identifier <= (36 + 8) Then
                    format.info.mode_hint = "beat-14k"
                End If
                If (format.info.mode_hint <> "beat-14k" AndAlso format.info.mode_hint <> "keyboard-24k" AndAlso format.info.mode_hint <> "keyboard-24k-double") AndAlso
                   GetColumn(Notes(i).ColumnIndex).Identifier >= (72 + 8) AndAlso GetColumn(Notes(i).ColumnIndex).Identifier <= (72 + 9) Then
                    format.info.mode_hint = "beat-14k"
                End If
                If (format.info.mode_hint = "beat-5k" OrElse format.info.mode_hint = "beat-7k") AndAlso
                   (GetColumn(Notes(i).ColumnIndex).Identifier = (36 + 7) OrElse GetColumn(Notes(i).ColumnIndex).Identifier > (36 + 9)) AndAlso GetColumn(Notes(i).ColumnIndex).Identifier < 72 Then
                    format.info.mode_hint = "keyboard-24k"
                End If
                If (format.info.mode_hint = "popn-9k" OrElse format.info.mode_hint = "beat-10k" OrElse format.info.mode_hint = "beat-14k") AndAlso
                   (GetColumn(Notes(i).ColumnIndex).Identifier = (36 + 7) OrElse GetColumn(Notes(i).ColumnIndex).Identifier > (36 + 9)) AndAlso GetColumn(Notes(i).ColumnIndex).Identifier < 72 Then
                    format.info.mode_hint = "keyboard-24k-double"
                End If
                If format.info.mode_hint <> "keyboard-24k-double" AndAlso
                   (GetColumn(Notes(i).ColumnIndex).Identifier = (72 + 7) OrElse GetColumn(Notes(i).ColumnIndex).Identifier > (72 + 9)) AndAlso GetColumn(Notes(i).ColumnIndex).Identifier < 108 Then
                    format.info.mode_hint = "keyboard-24k-double"
                End If
            Next
            Dim resolution = CInt(48.0R / xGCD)
            format.info.resolution = resolution
            ' 小節線定義
            Dim len As Double = 0
            For i = 0 To MeasureAtDisplacement(GreatestVPosition) + 1
                len += MeasureLength(i) * resolution / 48.0R
                bar_list.Add(New BarLine(len))
            Next
            ' Notes
            For i = 1 To UBound(Notes)
                Dim position = Notes(i).VPosition * resolution / 48.0R
                If Notes(i).ColumnIndex = niSCROLL Then
                    scroll_list.Add(New ScrollEvent(position, Notes(i).Value / 10000.0R))
                ElseIf Notes(i).ColumnIndex = niBPM Then
                    bpm_list.Add(New BpmEvent(position, Notes(i).Value / 10000.0R))
                ElseIf Notes(i).ColumnIndex = niSTOP Then
                    stop_list.Add(New StopEvent(position, Notes(i).Value * resolution / 480000.0R))
                ElseIf Notes(i).ColumnIndex = niBGA Then
                    bga_list.Add(New BGAEvent(position, Notes(i).Value / 10000))
                ElseIf Notes(i).ColumnIndex = niLAYER Then
                    layer_list.Add(New BGAEvent(position, Notes(i).Value / 10000))
                ElseIf Notes(i).ColumnIndex = niPOOR Then
                    miss_list.Add(New BGAEvent(position, Notes(i).Value / 10000))
                ElseIf Notes(i).ColumnIndex >= niB Then
                    Dim value = Notes(i).Value / 10000
                    If Not note_list.ContainsKey(value) Then
                        note_list(value) = New List(Of BmsonNote)
                    End If
                    note_list(value).Add(New BmsonNote(position, 0))
                Else
                    Dim lane = GetColumn(Notes(i).ColumnIndex).Identifier - 36
                    Dim value = Notes(i).Value / 10000
                    'ノート定義を変換
                    If format.info.mode_hint = "popn-9k" Then
                        If lane >= 36 Then
                            lane -= 32
                        End If
                    ElseIf format.info.mode_hint = "keyboard-24k" OrElse format.info.mode_hint = "keyboard-24k-double" Then
                        If (lane Mod 36) = 6 OrElse (lane Mod 36) = 7 Then
                            lane += 19
                        ElseIf (lane Mod 36) >= 8 Then
                            lane -= 2
                        End If
                        If (lane >= 36) Then
                            lane -= 10
                        End If
                    Else
                        If (lane Mod 36) = 6 Then
                            lane += 2
                        ElseIf (lane Mod 36) >= 8 Then
                            lane -= 2
                        End If
                        If (lane >= 36) Then
                            lane -= 28
                        End If
                    End If

                    If Notes(i).Landmine Then
                        mine_list.Add(New MineNote(position, lane, value))
                    ElseIf Notes(i).Hidden Then
                        If Not hidden_note_list.ContainsKey(value) Then
                            hidden_note_list(value) = New List(Of MineNote)
                        End If
                        hidden_note_list(value).Add(New MineNote(position, lane, 0))
                    ElseIf Notes(i).length > 0 AndAlso NTInput Then
                        If Not note_list.ContainsKey(value) Then
                            note_list(value) = New List(Of BmsonNote)
                        End If
                        Dim length = Notes(i).Length * resolution / 48.0R
                        note_list(value).Add(New BmsonNote(position, lane, length))
                    ElseIf Notes(i).LNPair > 0 Then
                        If i < Notes(i).LNPair Then
                            If Not note_list.ContainsKey(value) Then
                                note_list(value) = New List(Of BmsonNote)
                            End If
                            Dim length = (Notes(Notes(i).LNPair).VPosition - Notes(i).VPosition) * resolution / 48.0R
                            Dim note = New BmsonNote(position, lane, length)
                            note_list(value).Add(note)
                        Else
                            If Notes(i).Value \ 10000 <> LnObj AndAlso Notes(i).Value <> Notes(Notes(i).LNPair).Value Then
                                Dim note = New BmsonNote(position, lane)
                                note.up = True
                                note_list(value).Add(note)
                            End If
                        End If
                    Else
                        If Not note_list.ContainsKey(value) Then
                            note_list(value) = New List(Of BmsonNote)
                        End If
                        note_list(value).Add(New BmsonNote(position, lane))
                    End If
                End If
            Next
            ' 音定義
            For i = 1 To UBound(hWAV)
                If hWAV(i) <> "" Then
                    If note_list.ContainsKey(i) Then
                        wav_list.Add(i, New SoundChannel(hWAV(i)))
                    End If
                End If
                If hidden_note_list.ContainsKey(i) Then
                    If hWAV(i) <> "" Then
                        hidden_list.Add(i, New MineChannel(hWAV(i)))
                    Else
                        hidden_list.Add(i, New MineChannel(""))
                    End If
                End If
            Next
            ReDim format.mine_channels(0)
            If hWAV(0) <> "" Then
                format.mine_channels(0) = New MineChannel(hWAV(0))
            Else
                format.mine_channels(0) = New MineChannel("")
            End If
            For i = 1 To UBound(hBMP)
                If hBMP(i) <> "" Then
                    bmp_list.Add(New BGAHeader(i, hBMP(i)))
                End If
            Next
            ' 適用
            format.lines = bar_list.ToArray()
            format.bpm_events = bpm_list.ToArray()
            format.stop_events = stop_list.ToArray()
            format.scroll_events = scroll_list.ToArray()
            format.bga.bga_header = bmp_list.ToArray()
            format.bga.bga_events = bga_list.ToArray()
            format.bga.layer_events = layer_list.ToArray()
            format.bga.poor_events = miss_list.ToArray()
            format.mine_channels(0).notes = mine_list.ToArray()

            ReDim format.sound_channels(wav_list.Count() - 1)
            ReDim format.key_channels(hidden_list.Count() - 1)

            i = 0
            For Each n In wav_list
                format.sound_channels(i) = New SoundChannel(n.Value().name)
                ReDim format.sound_channels(i).notes(note_list(n.Key()).Count() - 1)
                format.sound_channels(i).notes = note_list(n.Key()).ToArray()
                i += 1
            Next

            i = 0
            For Each n In hidden_list
                format.key_channels(i) = New MineChannel(n.Value().name)
                ReDim format.key_channels(i).notes(hidden_note_list(n.Key()).Count() - 1)
                format.key_channels(i).notes = hidden_note_list(n.Key()).ToArray()
                i += 1
            Next

            options.IncludeFields = True
            options.WriteIndented = True
            Dim bw As New BinaryWriter(New IO.FileStream(Path, FileMode.Create), System.Text.Encoding.UTF8)
            Dim str = JsonSerializer.SerializeToUtf8Bytes(format, options)
            bw.Write(str)
            bw.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function CalcBMSTotal() As Double
        Dim notes = CalculateTotalNotes()
        Return System.Math.Max((720.0 / (800 + notes) * notes), 200.0)
    End Function

    Function CalcBMSONTotal(total As Double) As Double
        Dim notes = CalculateTotalNotes()
        Return total / System.Math.Max((800.0 / (700 + notes) * notes), 250.0) * 100
    End Function

End Class

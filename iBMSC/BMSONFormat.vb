Namespace Editor

    Public Class Bmson

        Public version As String = "1.0.0"
        Public info As BMSInfo = New BMSInfo()
        Public lines As BarLine() = {}
        Public bpm_events As BpmEvent() = {}
        Public stop_events As StopEvent() = {}
        Public scroll_events As ScrollEvent() = {}
        Public sound_channels As SoundChannel() = {}
        Public bga As BGA = New BGA()
        Public mine_channels As MineChannel() = {}
        Public key_channels As MineChannel() = {}
    End Class
    Public Class BMSInfo
        Public title As String = ""
        Public subtitle As String = ""
        Public genre As String = ""
        Public artist As String = ""
        Public subartists As String() = {""}
        Public mode_hint As String = "beat-7k"
        Public chart_name As String = ""
        Public judge_rank As Integer = 80
        Public total As Double = 90.0R
        Public init_bpm As Double = 120.0R
        Public level As Integer

        Public back_image As String = ""
        Public eyecatch_image As String = ""
        Public banner_image As String = ""
        Public preview_music As String = ""
        Public resolution As Integer = 48

        Public ln_type As Integer
    End Class
    Public Class BarLine
        Public y As Integer
        Public k As Integer = 0
        Public Sub New(position As Integer)
            y = position
        End Sub
    End Class

    Public Class SoundChannel
        Public name As String
        Public notes As BmsonNote() = {}
        Public Sub New(_name As String)
            name = _name
        End Sub
    End Class

    Public Class MineChannel
        Public name As String
        Public notes As MineNote() = {}
        Public Sub New(_name As String)
            name = _name
        End Sub
    End Class

    Public Class BGA
        Public bga_header As BGAHeader() = {}
        Public bga_sequence As BGASequence() = {}
        Public bga_events As BGAEvent() = {}
        Public layer_events As BGAEvent() = {}
        Public poor_events As BGAEvent() = {}
    End Class
    Public Class BGAHeader
        Public id As Integer
        Public name As String
        Public Sub New(_id As Integer, _name As String)
            id = _id
            name = _name
        End Sub
    End Class
    Public Class BGASequence
        Public id As Integer
        Public sequence As Sequence()
    End Class


    Public MustInherit Class BMSONEvent
        Public y As Integer
    End Class

    Public Class BmsonNote
        Inherits BMSONEvent
        Public x As Integer
        Public l As Integer
        Public c As Boolean = False
        Public t As Integer = 0
        Public up As Boolean = False
        Public Sub New(position As Integer, value As Integer, Optional length As Integer = 0)
            y = position
            x = value
            l = length
        End Sub
    End Class

    Public Class BpmEvent
        Inherits BMSONEvent
        Public bpm As Double
        Public Sub New(position As Integer, value As Double)
            y = position
            bpm = value
        End Sub
    End Class

    Public Class StopEvent
        Inherits BMSONEvent
        Public duration As Long
        Public Sub New(position As Integer, value As Long)
            y = position
            duration = value
        End Sub
    End Class

    Public Class ScrollEvent
        Inherits BMSONEvent
        Public rate As Double
        Public Sub New(position As Integer, value As Double)
            y = position
            rate = value
        End Sub
    End Class

    Public Class MineNote
        Inherits BMSONEvent
        Public x As Integer
        Public damage As Double
        Public Sub New(position As Integer, id As Integer, value As Double)
            y = position
            x = id
            damage = value
        End Sub
    End Class

    Public Class BGAEvent
        Inherits BMSONEvent
        Public id As Integer
        Public id_set As Integer() = {}
        Public condition As String = ""
        Public interval As Integer = 0
        Public Sub New(position As Integer, value As Double)
            y = position
            id = value
        End Sub
    End Class
    Public Class Sequence
        Public time As Long
        Public id As Integer = Integer.MinValue
    End Class
End Namespace
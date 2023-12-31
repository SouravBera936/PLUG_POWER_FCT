﻿Module Module1
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" _
                                                       (ByVal lpClassName As String,
                                                       ByVal lpWindowName As String) As Integer

    Public Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer,
                ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    ' Taskbar Visibility Constants
    Private Const TASKBAR_WINDOW_NAME As String = "Shell_traywnd"
    Private Const SWP_SHOWWINDOW As Integer = &H40
    Private Const SWP_HIDEWINDOW As Integer = &H80

    ' Callable function
    Public Sub HideTaskbar(ByVal ActionHide As Boolean)
        ' Either hides or shows the taskbar

        ' Obtain the window handle of the taskbar
        Dim TaskbarHWnd As Integer = FindWindow(TASKBAR_WINDOW_NAME, "")

        ' Then hide / shown the taskbar according to the appropriate action
        If ActionHide Then
            Call SetWindowPos(TaskbarHWnd, 0, 0, 0, 0, 0, SWP_HIDEWINDOW)
        Else
            Call SetWindowPos(TaskbarHWnd, 0, 0, 0, 0, 0, SWP_SHOWWINDOW)
        End If

    End Sub
End Module

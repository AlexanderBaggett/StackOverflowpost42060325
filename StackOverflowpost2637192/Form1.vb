Public Class Form1
    'http://stackoverflow.com/questions/42055300/vb-net-copy-all-text-from-webbrowser/42060325#42060325
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        WebBrowser1.Navigate("www.google.com")
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim text As String
        WebBrowser1.Document.ExecCommand("SelectAll", False, Nothing)
        WebBrowser1.Document.ExecCommand("Copy", False, Nothing)
        text = Clipboard.GetText()
        MessageBox.Show(text, "Text")
    End Sub
End Class

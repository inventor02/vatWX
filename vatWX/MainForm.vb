Imports RestSharp
Imports Squirrel

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionLabel.Text = My.Application.Info.Version.ToString(3)

        UpdateApp()
    End Sub

    Async Sub UpdateApp()
        Using mgr As UpdateManager = New UpdateManager("http://update.vatwx.georgepeppard.me")
            Await mgr.UpdateApp()
        End Using
    End Sub

    Sub CheckRouteInfoAndSetupButtons()
        If RouteDepartureTextBox.Text.Length = 4 And RouteDestinationTextBox.Text.Length = 4 Then
            RouteDownloadButton.Enabled = True
        Else
            RouteDownloadButton.Enabled = False
        End If
    End Sub

    Sub CheckCustomInfoAndSetupButtons()
        If CustomStationTextBox.Text.Length = 4 Then
            CustomDownloadButton.Enabled = True
        Else
            CustomDownloadButton.Enabled = False
        End If
    End Sub

    Private Sub RouteDepartureTextBox_TextChanged(sender As Object, e As EventArgs) Handles RouteDepartureTextBox.TextChanged
        CheckRouteInfoAndSetupButtons()
    End Sub

    Private Sub RouteDestinationTextBox_TextChanged(sender As Object, e As EventArgs) Handles RouteDestinationTextBox.TextChanged
        CheckRouteInfoAndSetupButtons()
    End Sub

    Private Sub RouteAlternateTextBox_TextChanged(sender As Object, e As EventArgs) Handles RouteAlternateTextBox.TextChanged
        CheckRouteInfoAndSetupButtons()
    End Sub

    Sub PerformRouteMetarSequence()
        Dim departureMetar, destinationMetar, alternateMetar As String

        departureMetar = GetMetar(RouteDepartureTextBox.Text)
        destinationMetar = GetMetar(RouteDestinationTextBox.Text)

        If RouteAlternateTextBox.Text.Length = 4 Then
            alternateMetar = GetMetar(RouteAlternateTextBox.Text)
        Else
            alternateMetar = "No alternate specified."
        End If

        RouteResultDepartureTextBox.Text = departureMetar
        RouteResultDestinationTextBox.Text = destinationMetar
        RouteResultAlternateTextBox.Text = alternateMetar

        RouteDepartureCopyButton.Enabled = True
        RouteDestinationCopyButton.Enabled = True
        RouteAlternateCopyButton.Enabled = True
    End Sub

    Sub PerformCustomMetarSequence()
        Dim customMetar As String

        customMetar = GetMetar(CustomStationTextBox.Text)

        CustomResultTextBox.Text = customMetar

        CustomResultCopyButton.Enabled = True
    End Sub

    Function GetMetar(station As String)
        Dim client As RestClient = New RestClient(My.Settings.APIEndpoint)

        Dim request As RestRequest = New RestRequest("metar.php", Method.GET)
        request.AddParameter("id", station)

        Dim response As IRestResponse = client.Execute(request)
        Dim responseContent As String = response.Content

        GetMetar = responseContent.Trim()
    End Function

    Private Sub RouteDownloadButton_Click(sender As Object, e As EventArgs) Handles RouteDownloadButton.Click
        PerformRouteMetarSequence()
    End Sub

    Sub CopyMetar(metar As String)
        Clipboard.SetText(metar)
    End Sub

    Private Sub RouteDepartureCopyButton_Click(sender As Object, e As EventArgs) Handles RouteDepartureCopyButton.Click
        CopyMetar(RouteResultDepartureTextBox.Text)
    End Sub

    Private Sub RouteDestinationCopyButton_Click(sender As Object, e As EventArgs) Handles RouteDestinationCopyButton.Click
        CopyMetar(RouteResultDestinationTextBox.Text)
    End Sub

    Private Sub RouteAlternateCopyButton_Click(sender As Object, e As EventArgs) Handles RouteAlternateCopyButton.Click
        CopyMetar(RouteResultAlternateTextBox.Text)
    End Sub

    Private Sub CustomStationTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomStationTextBox.TextChanged
        CheckCustomInfoAndSetupButtons()
    End Sub

    Private Sub CustomDownloadButton_Click(sender As Object, e As EventArgs) Handles CustomDownloadButton.Click
        PerformCustomMetarSequence()
    End Sub

    Private Sub CustomResultCopyButton_Click(sender As Object, e As EventArgs) Handles CustomResultCopyButton.Click
        CopyMetar(CustomResultTextBox.Text)
    End Sub

    Private Sub AttributionLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AttributionLinkLabel.LinkClicked
        Process.Start("https://georgepeppard.me/")
    End Sub
End Class

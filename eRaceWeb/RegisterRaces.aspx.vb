
Partial Class RegisterRaces
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'no filling of data here except for the cookie
        dl = 1
    End Sub

    Protected Sub fetchPost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fetchPostBTN.Click

        'here get the date from teh textbox and search for races based on the date
        'RDate.Text
        'fill dropdown of posttimesPostDD
    End Sub

    Protected Sub fetchRace_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fetchRaceBTN.Click
        'takes dropdown textvalue and gets race information for gridview
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub


    Protected Sub CarStat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CarStat.Click

    End Sub

    Protected Sub recordBTN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles recordBTN.Click

    End Sub

    Protected Sub RegisterID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RegisterID.Click

    End Sub


    Protected Sub CarStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CarStatus.Click

    End Sub

    Protected Sub RecordResults_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecordResults.Click
        'this is turned off while in update row of grid mode
    End Sub
End Class

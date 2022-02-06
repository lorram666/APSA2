Imports APSA_2.APSA_2

Public Class Validacoes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ent As New Entities
        gdValidacoes.DataSource = ent.AD_SP_VALIDACOES_ESTRUTURAIS.ToList()
        gdValidacoes.DataBind()

    End Sub

End Class
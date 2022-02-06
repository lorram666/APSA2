Imports Apsa2.Apsa2

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function Validacoes() As ActionResult
        ViewData("Message") = "Your contact page."

        Dim entities As ARQUIVO_DIGITALEntities = New ARQUIVO_DIGITALEntities
        'Dim gView As System.Web.UI.WebControls.GridView = New System.Web.UI.WebControls.GridView
        'gView.DataBind()

        ViewBag.ListError = entities.AD_RETORNA_VALIDACOES_ESTRUTURAIS.ToList
        Return View()

    End Function
End Class

Imports TesterPile

Public Class Controleur

    Private Property _HistoriqueArriere As IPile
    Private Property _HistoriqueAvant As IPile

    Public Sub New()
        Me._HistoriqueArriere = New Pile()
        Me._HistoriqueAvant = New Pile()
    End Sub

    Public Sub New(ByVal HistoriqueArriere As IPile, ByVal HistoriqueAvant As IPile)
        Me._HistoriqueAvant = HistoriqueAvant
        Me._HistoriqueArriere = HistoriqueArriere
    End Sub

    Public Function Back() As String
        Return Me._HistoriqueArriere.Depiler()
    End Function

    Public Function Forward() As String
        Return Me._HistoriqueAvant.Depiler()
    End Function

End Class

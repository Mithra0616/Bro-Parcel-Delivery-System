Public Class Usersession
    ' Property to hold the current student's ID
    Private Shared _currentStudentId As Integer

    ' Public property to access the current student's ID
    Public Shared Property CurrentStudentId As Integer
        Get
            Return _currentStudentId
        End Get
        Set(value As Integer)
            _currentStudentId = value
        End Set
    End Property
End Class

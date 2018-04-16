Imports System.Linq
Imports System.Text
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.DC

Namespace MultipleORMsExample.Module.BusinessObjects
    <DefaultClassOptions>
    Public Class XpoSampleObject
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", _name, value)
            End Set
        End Property
        Private _description As String
        <Size(SizeAttribute.Unlimited)>
        Public Property Description() As String
            Get
                Return _description
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Description", _description, value)
            End Set
        End Property
    End Class
End Namespace

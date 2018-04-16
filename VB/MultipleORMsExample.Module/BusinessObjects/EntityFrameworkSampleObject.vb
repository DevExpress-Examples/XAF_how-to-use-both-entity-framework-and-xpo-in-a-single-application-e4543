Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.Persistent.Base
Imports System.Data.Entity
Imports DevExpress.ExpressApp.DC

Namespace MultipleORMsExample.Module.BusinessObjects
    <DefaultClassOptions> _
    Public Class EntityFrameworkSampleObject
        Private privateId As Integer
        <Browsable(False)> _
        Public Property Id() As Integer
            Get
                Return privateId
            End Get
            Protected Set(ByVal value As Integer)
                privateId = value
            End Set
        End Property
        Private privateName As String
        Public Property Name() As String
            Get
                Return privateName
            End Get
            Set(ByVal value As String)
                privateName = value
            End Set
        End Property
        Private privateDescription As String
        <FieldSize(FieldSizeAttribute.Unlimited)> _
        Public Property Description() As String
            Get
                Return privateDescription
            End Get
            Set(ByVal value As String)
                privateDescription = value
            End Set
        End Property
    End Class

    Public Class MyDbContext
        Inherits DbContext

        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString)
        End Sub
        Private privateSampleObjects As DbSet(Of EntityFrameworkSampleObject)
        Public Property SampleObjects() As DbSet(Of EntityFrameworkSampleObject)
            Get
                Return privateSampleObjects
            End Get
            Set(ByVal value As DbSet(Of EntityFrameworkSampleObject))
                privateSampleObjects = value
            End Set
        End Property
    End Class
End Namespace

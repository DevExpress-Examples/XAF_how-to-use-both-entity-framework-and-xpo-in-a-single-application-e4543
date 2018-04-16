Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.Persistent.Base
Imports System.Data.Entity
Imports DevExpress.ExpressApp.DC
Imports DevExpress.ExpressApp.Updating

Namespace MultipleORMsExample.Module.BusinessObjects
    <DefaultClassOptions>
    Public Class EntityFrameworkSampleObject
        Private privateId As Integer
        <Browsable(False)>
        Public Property Id() As Integer
            Get
                Return privateId
            End Get
            Protected Set(ByVal value As Integer)
                privateId = value
            End Set
        End Property
        Public Property Name() As String
        <FieldSize(FieldSizeAttribute.Unlimited)>
        Public Property Description() As String
    End Class

    Public Class MyDbContext
        Inherits DbContext

        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString)
        End Sub
        Public Property SampleObjects() As DbSet(Of EntityFrameworkSampleObject)
        Public Property ModulesInfo() As DbSet(Of DevExpress.ExpressApp.EF.Updating.ModuleInfo)
    End Class
End Namespace

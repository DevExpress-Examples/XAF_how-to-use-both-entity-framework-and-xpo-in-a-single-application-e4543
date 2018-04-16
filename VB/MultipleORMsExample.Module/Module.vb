Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.EF
Imports MultipleORMsExample.Module.BusinessObjects
Imports System.Data.Entity

Namespace MultipleORMsExample.Module
    Public NotInheritable Partial Class MultipleORMsExampleModule
        Inherits ModuleBase
        Public Sub New()
            InitializeComponent()
            ExportedTypeHelpers.AddExportedTypeHelper(New EFExportedTypeHelperCF())
            Database.SetInitializer(Of MyDbContext)(New DropCreateDatabaseIfModelChanges(Of MyDbContext)())
        End Sub
        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
            Return New ModuleUpdater() { updater }
        End Function
    End Class
End Namespace

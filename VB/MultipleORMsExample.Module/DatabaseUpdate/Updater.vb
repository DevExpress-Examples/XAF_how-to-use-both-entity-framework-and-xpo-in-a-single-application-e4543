Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.EF
Imports MultipleORMsExample.Module.BusinessObjects

Namespace MultipleORMsExample.Module.DatabaseUpdate
	Public Class Updater
		Inherits ModuleUpdater

		Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			If TypeOf ObjectSpace Is XPObjectSpace Then
				If ObjectSpace.GetObjects(Of XpoSampleObject)().Count = 0 Then
					Dim efObject = ObjectSpace.CreateObject(Of XpoSampleObject)()
					efObject.Name = "XPO Object"
				End If
			End If
			If TypeOf ObjectSpace Is EFObjectSpace Then
				If ObjectSpace.GetObjects(Of EntityFrameworkSampleObject)().Count = 0 Then
					Dim efObject = ObjectSpace.CreateObject(Of EntityFrameworkSampleObject)()
					efObject.Name = "EF Object"
				End If
			End If
		End Sub
	End Class
End Namespace

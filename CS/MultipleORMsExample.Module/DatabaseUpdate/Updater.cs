using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.EF;
using MultipleORMsExample.Module.BusinessObjects;

namespace MultipleORMsExample.Module.DatabaseUpdate {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (ObjectSpace is XPObjectSpace) {
                if (ObjectSpace.GetObjects<XpoSampleObject>().Count == 0) {
                    var efObject = ObjectSpace.CreateObject<XpoSampleObject>();
                    efObject.Name = "XPO Object";
                }
            }
            if (ObjectSpace is EFObjectSpace) {
                if (ObjectSpace.GetObjects<EntityFrameworkSampleObject>().Count == 0) {
                    var efObject = ObjectSpace.CreateObject<EntityFrameworkSampleObject>();
                    efObject.Name = "EF Object";
                }
            }
        }
    }
}

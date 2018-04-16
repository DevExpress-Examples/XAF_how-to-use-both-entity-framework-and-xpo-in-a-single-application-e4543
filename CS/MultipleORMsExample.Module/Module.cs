using System;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.EF;
using MultipleORMsExample.Module.BusinessObjects;
using System.Data.Entity;


namespace MultipleORMsExample.Module {
    public sealed partial class MultipleORMsExampleModule : ModuleBase {
        public MultipleORMsExampleModule() {
            InitializeComponent();
            ExportedTypeHelpers.AddExportedTypeHelper(new EFExportedTypeHelperCF());
            Database.SetInitializer<MyDbContext>(new DropCreateDatabaseIfModelChanges<MyDbContext>());
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }
    }
}

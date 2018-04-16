using System;
using System.Collections.Generic;
using System.Data.Entity;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.EF;
using MultipleORMsExample.Module.BusinessObjects;

namespace MultipleORMsExample.Module {
    public sealed partial class MultipleORMsExampleModule : ModuleBase {
        public MultipleORMsExampleModule() {
            InitializeComponent();
            Database.SetInitializer<MyDbContext>(new DropCreateDatabaseIfModelChanges<MyDbContext>());
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using System.Data.Entity;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Updating;

namespace MultipleORMsExample.Module.BusinessObjects {
    [DefaultClassOptions]
    public class EntityFrameworkSampleObject {
        [Browsable(false)]
        public int Id { get; protected set; }
        public string Name { get; set; }
        [FieldSize(FieldSizeAttribute.Unlimited)]
        public String Description { get; set; }
    }

    public class MyDbContext : DbContext {
        public MyDbContext(string connectionString) : base(connectionString) { }
        public DbSet<EntityFrameworkSampleObject> SampleObjects { get; set; }
        public DbSet<DevExpress.ExpressApp.EF.Updating.ModuleInfo> ModulesInfo { get; set; }
    }
}

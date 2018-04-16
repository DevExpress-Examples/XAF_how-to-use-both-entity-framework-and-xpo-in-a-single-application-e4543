using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;

namespace MultipleORMsExample.Module.BusinessObjects {
    [DefaultClassOptions]
    public class XpoSampleObject : BaseObject {
        public XpoSampleObject(Session session) : base(session) { }
        private string name;
        public string Name {
            get { return name; }
            set { SetPropertyValue("Name", ref name, value); }
        }
        private string description;
        [Size(SizeAttribute.Unlimited)]
        public String Description { 
            get {return description; }
            set { SetPropertyValue("Description", ref description, value); }
        }
    }
}

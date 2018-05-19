using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;
using DevExpress.Xpo;

namespace DXExample.Module.Win {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
        }
    }
}
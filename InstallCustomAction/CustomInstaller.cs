using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration.Install;
using System.ComponentModel;
using System.Diagnostics;
namespace InstallCustomAction
{
    [RunInstaller(true)]
    public class CustomInstaller : Installer
    {
        public CustomInstaller()
        {
        }

        public override void Commit(System.Collections.IDictionary savedState)
        {
            base.Commit(savedState);
            string directory = Context.Parameters["TARGETDIR"].ToString();
            System.Diagnostics.Process.Start(directory + "finishSetup.bat");
            base.Dispose();
        }
    }
}

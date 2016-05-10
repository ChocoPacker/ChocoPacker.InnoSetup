namespace ChocoPacker.InnoSetup
{
    using System;
    using Common;
    using static ChocoPacker.InnoSetup.Constants;
    
    [SupportsInstaller(InstallerTypeName)]
    public sealed class InnoSetupInstallerInfoProvider : IInstallerInfoProvider
    {
        public InstallerInfo GetInstallerInfo(string installerPath)
        {
            throw new NotImplementedException();
        }
    }
}
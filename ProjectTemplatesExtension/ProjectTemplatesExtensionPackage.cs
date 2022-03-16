namespace ProjectTemplatesExtension
{
    using Microsoft.VisualStudio.Shell;

    using System;
    using System.Runtime.InteropServices;
    using System.Threading;

    using Task = System.Threading.Tasks.Task;

    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(ProjectTemplatesExtensionPackage.PackageGuidString)]
    public sealed class ProjectTemplatesExtensionPackage : AsyncPackage
    {
        public const string PackageGuidString = "7450ef5a-c85e-4582-9dd7-5b9fb8879fbf";

        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
        }
    }
}

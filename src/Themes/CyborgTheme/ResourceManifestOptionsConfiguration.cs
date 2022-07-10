using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace CyborgTheme
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;

        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest
                .DefineStyle("CyborgTheme-bootstrap-oc")
                .SetUrl("~/CyborgTheme/css/bootstrap-oc.min.css", "~/CyborgTheme/css/bootstrap-oc.css")
                .SetVersion("1.0.0");
        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}

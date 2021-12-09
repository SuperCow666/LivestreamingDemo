using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Business
{
    [Dependency(ReplaceServices = true)]
    public class BusinessBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Business";
    }
}

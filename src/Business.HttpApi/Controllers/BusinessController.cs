using Business.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Business.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BusinessController : AbpController
    {
        protected BusinessController()
        {
            LocalizationResource = typeof(BusinessResource);
        }
    }
}
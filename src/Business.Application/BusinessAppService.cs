using System;
using System.Collections.Generic;
using System.Text;
using Business.Localization;
using Volo.Abp.Application.Services;

namespace Business
{
    /* Inherit your application services from this class.
     */
    public abstract class BusinessAppService : ApplicationService
    {
        protected BusinessAppService()
        {
            LocalizationResource = typeof(BusinessResource);
        }
    }
}

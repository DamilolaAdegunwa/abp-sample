using Abp.AspNetCore.Mvc.ViewComponents;

namespace sample.Web.Views
{
    public abstract class sampleViewComponent : AbpViewComponent
    {
        protected sampleViewComponent()
        {
            LocalizationSourceName = sampleConsts.LocalizationSourceName;
        }
    }
}

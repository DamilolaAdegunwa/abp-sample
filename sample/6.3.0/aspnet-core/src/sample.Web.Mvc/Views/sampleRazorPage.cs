using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace sample.Web.Views
{
    public abstract class sampleRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected sampleRazorPage()
        {
            LocalizationSourceName = sampleConsts.LocalizationSourceName;
        }
    }
}

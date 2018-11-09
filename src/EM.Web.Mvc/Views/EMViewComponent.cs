using Abp.AspNetCore.Mvc.ViewComponents;

namespace EM.Web.Views
{
    public abstract class EMViewComponent : AbpViewComponent
    {
        protected EMViewComponent()
        {
            LocalizationSourceName = EMConsts.LocalizationSourceName;
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace EM.Web.Views
{
   public abstract class EMRazorPage<TModel> : AbpRazorPage<TModel>
   {
      [RazorInject] public IAbpSession AbpSession { get; set; }

      protected EMRazorPage()
      {
         LocalizationSourceName = EMConsts.LocalizationSourceName;
      }
   }
}
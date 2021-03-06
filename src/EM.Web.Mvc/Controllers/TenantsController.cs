﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using EM.Authorization;
using EM.Controllers;
using EM.MultiTenancy;

namespace EM.Web.Controllers
{
   [AbpMvcAuthorize(PermissionNames.PagesTenants)]
   public class TenantsController : EMControllerBase
   {
      private readonly ITenantAppService _tenantAppService;

      public TenantsController(ITenantAppService tenantAppService)
      {
         _tenantAppService = tenantAppService;
      }

      public async Task<ActionResult> Index()
      {
         var output =
            await _tenantAppService.GetAll(new PagedResultRequestDto
               {MaxResultCount = int.MaxValue}); // Paging not implemented yet
         return View(output);
      }

      public async Task<ActionResult> EditTenantModal(int tenantId)
      {
         var tenantDto = await _tenantAppService.Get(new EntityDto(tenantId));
         return View("_EditTenantModal", tenantDto);
      }
   }
}
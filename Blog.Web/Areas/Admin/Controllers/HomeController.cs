﻿using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IDashboardService dashboardService;

        public HomeController(IArticleService articleService, IDashboardService dashboardService )
        {
            this.articleService = articleService;
            this.dashboardService = dashboardService;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticleWithNonDeletedAsync();
            //var result = await dashboardService.GetYearlyArticleCounts();
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> YearlyArticleCounts()
        {
            var count = await dashboardService.GetYearlyArticleCounts();
            return Json(JsonConvert.SerializeObject(count));
        }
        [HttpGet]
        public async Task<IActionResult> TotalArticleCount()
        {
            var count = await dashboardService.GetTotalArticleCountAsync();
            return Json(count);
        }
        [HttpGet]
        public async Task<IActionResult> GetTotalCategoryCount()
        {
            var count = await dashboardService.GetTotalCategoryCountAsync();
            return Json(count);
        }

    }
}

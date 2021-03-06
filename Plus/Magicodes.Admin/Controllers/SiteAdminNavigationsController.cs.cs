﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Magicodes.Admin.Models;
using Magicodes.Core.Web.Controllers;
//======================================================================
//
//        Copyright (C) 2014-2016 Magicodes团队    
//        All rights reserved
//
//        filename :ConfigController
//        description :本控制器代码为自动生成，如需更改，请先删除父级T4模板
//
//        created by 雪雁 at  2015/01/26 21:32:01
//        http://www.magicodes.net
//
//======================================================================
namespace Magicodes.Admin.Controllers
{
    [Route("{action}/{id}")]
    public class SiteAdminNavigations : AdminControllerBase
    {
        private MagicodesAdminContext db = new MagicodesAdminContext();

        // GET: 
        [Route]
        public async Task<ActionResult> Index()
        {
            return View(await db.SiteAdminNavigations.ToListAsync());
        }

        // GET: /Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var model = await db.SiteAdminNavigations.FindAsync(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: /Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Create
        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(SiteAdminNavigation model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                db.SiteAdminNavigations.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: /Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            var model = await db.SiteAdminNavigations.FindAsync(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: /Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(SiteAdminNavigation model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: /Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            var model = await db.SiteAdminNavigations.FindAsync(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: /Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            var model = await db.SiteAdminNavigations.FindAsync(id);
            db.SiteAdminNavigations.Remove(model);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

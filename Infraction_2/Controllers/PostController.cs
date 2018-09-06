using Infraction_2.Models;
using Infraction_2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infraction_2.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult AddPost()
        {
            return View();
        }

        // POST: Employee/AddEmployee
        [HttpPost]
        public ActionResult AddPost(PostModel Post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PostRepository PostRepo = new PostRepository();

                    if (PostRepo.AddPost(Post))
                    {
                        ViewBag.Message = "Added successfully";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }


// GET: Employee/GetAllEmpDetails    
    public ActionResult GetAllPost()
    {    
          
        PostRepository PostRepo = new PostRepository();    
        ModelState.Clear();    
        return View(PostRepo.GetAllPost());    
    }






    public ActionResult Index()
        {
            return View();
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

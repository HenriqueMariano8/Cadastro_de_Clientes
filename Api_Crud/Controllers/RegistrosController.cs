using Api_Crud.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api_Crud.Controllers
{
    public class RegistrosController : Controller
    {
        public IActionResult Index()
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Registros> listaRegistros = dbContext.Registro.Find(mbox => true).ToList();
            return View(listaRegistros);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            MongoDbContext dbContext = new MongoDbContext();
            var entity = dbContext.Registro.Find(m => m.Id == id).FirstOrDefault();
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Registros entity)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Registro.ReplaceOne(m => m.Id == entity.Id, entity);
            return View(entity);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Registros entity)
        {
            MongoDbContext dbContext = new MongoDbContext();
            entity.Id = Guid.NewGuid();
            dbContext.Registro.InsertOne(entity);

            return RedirectToAction("Index", "");
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Registro.DeleteOne(m => m.Id == id);
            return RedirectToAction("Index", "");
        }
        public IActionResult Show(Guid id)
        {
            MongoDbContext dbContext = new MongoDbContext();
            var listaRegistros = dbContext.Registro.Find(m => m.Id == id).ToList();
            return View(listaRegistros);
        }
    }
}

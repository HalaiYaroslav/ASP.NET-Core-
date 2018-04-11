﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            //services.AddTransient<IProductRepository, FakeProductRepository>();
            repository = repo; //instance of FakeProductRepository
        }

        public ViewResult List() => View(repository.Products);
    }
}
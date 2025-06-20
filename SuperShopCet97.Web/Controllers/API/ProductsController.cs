﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuperShopCet97.Web.Data;

namespace SuperShopCet97.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productRepository.GetAllWithUsers());
        }
    }
}

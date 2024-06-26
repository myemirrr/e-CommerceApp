﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Api.Controllers;


[Route("api/[controller]")]
[Authorize(Roles = "admin,customer")]
[ApiController]
public class ProductsController(ApiDbContext dbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts(string productType, int? categoryId = null)
    {
        var products = dbContext.Products.AsQueryable();

        if (productType == "category" && categoryId != null)
        {
            products = products.Where(v => v.CategoryId == categoryId);
        }
        else if (productType == "trending")
        {
            products = products.Where(v => v.IsTrending == true);
        }
        else if (productType == "bestselling")
        {
            products = products.Where(v => v.IsBestSelling == true);
        }
        else
        {
            return BadRequest("Geçersiz Ürün Türü ! ");
        }

        var productData = products.Select(v => new
        {
            Id = v.Id,
            Name = v.Name,
            Price = v.Price,
            ImageUrl = v.ImageUrl
        });

        return Ok(productData);
    }

    [HttpGet("{id}")]
    public IActionResult GetProductDetail(int id)
    {
        var product = dbContext.Products.Where(p => p.Id == id);
        var productData = product.Select(v => new
        {
            Id = v.Id,
            Name = v.Name,
            Price = v.Price,
            Detail = v.Detail,
            ImageUrl = v.ImageUrl
        }).FirstOrDefault();
        return Ok(productData);
    }

}
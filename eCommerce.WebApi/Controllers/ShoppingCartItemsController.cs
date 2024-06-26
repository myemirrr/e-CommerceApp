﻿using eCommerce.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eCommerce.Api.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ShoppingCartItemsController(ApiDbContext dbContext) : ControllerBase
{
    // GET: api/ShoppingCartItems/1
    [HttpGet("{userId}")]
    public IActionResult Get(int userId)
    {
        var user = dbContext.ShoppingCartItems.Where(s => s.CustomerId == userId);
        if (user == null)
        {
            return NotFound();
        }

        var shoppingCartItems = from s in dbContext.ShoppingCartItems.Where(s => s.CustomerId == userId)
            join p in dbContext.Products on s.ProductId equals p.Id

            select new
            {
                Id = s.Id,
                Price = s.Price,
                TotalAmount = s.TotalAmount,
                Qty = s.Qty,
                ProductId = p.Id,
                ProductName = p.Name,
                ImageUrl = p.ImageUrl

            };

        return Ok(shoppingCartItems);
    }

    // POST: api/ShoppingCartItems
    [HttpPost]
    public IActionResult Post([FromBody]ShoppingCartItem shoppingCartItem)
    {
        var shoppingCart = dbContext.ShoppingCartItems.FirstOrDefault(s => s.ProductId == shoppingCartItem.ProductId && s.CustomerId == shoppingCartItem.CustomerId);
        if (shoppingCart != null)
        {
            shoppingCart.Qty += shoppingCartItem.Qty;
            shoppingCart.TotalAmount = shoppingCart.Price * shoppingCart.Qty;
        }
        else
        {
            
            var productRecord = dbContext.Products.Find(shoppingCartItem.ProductId);


            var sCart = new ShoppingCartItem()
            {
                CustomerId = shoppingCartItem.CustomerId,
                ProductId = shoppingCartItem.ProductId,
                Price = shoppingCartItem.Price,
                Qty = shoppingCartItem.Qty,
                TotalAmount = (int)(productRecord.Price) * (shoppingCartItem.Qty)
            };
            dbContext.ShoppingCartItems.Add(sCart);
        }
        dbContext.SaveChanges();
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut]
    public IActionResult Put(int productId, string action)
    {
        var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
        var user = dbContext.Users.FirstOrDefault(u => u.Email == userEmail);

        var shoppingCart = dbContext.ShoppingCartItems.FirstOrDefault(s => s.CustomerId == user.Id && s.ProductId == productId);

        if (shoppingCart != null)
        {
            if (action.ToLower() == "increase")
            {
                shoppingCart.Qty += 1;
            }
            else if (action.ToLower() == "decrease")
            {
                if (shoppingCart.Qty > 1)
                {
                    shoppingCart.Qty -= 1;
                }
                else
                {
                    dbContext.ShoppingCartItems.Remove(shoppingCart);
                    dbContext.SaveChanges();
                    return Ok();
                }
            }
            else if (action.ToLower() == "delete")
            {
                
                dbContext.ShoppingCartItems.Remove(shoppingCart);
                dbContext.SaveChanges();
                return Ok();
            }
            else
            {
               
                return BadRequest("Geçersiz Eylemde Bulundunuz ! ");
            }

            shoppingCart.TotalAmount = shoppingCart.Price * shoppingCart.Qty;
            dbContext.SaveChanges();
            return Ok();
        }
        else
        {
            
            return NotFound();
        }
    }

}
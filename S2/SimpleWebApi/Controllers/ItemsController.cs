using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SimpleWebApi.Models;

[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{ 
    private static List<Item> items = new List<Item>
    {
        new Item { Id = 1, Name = "Item 1", Price = 19.99m },
        new Item { Id = 2, Name = "Item 2", Price = 29.99m },
        new Item { Id = 3, Name = "Item 3", Price = 39.99m }
    };

    [HttpGet]


    public ActionResult<IEnumerable<Item>> Get()
    {
        return Ok(items);
    }

    [HttpGet("{id}")]


    public ActionResult<Item> Get(int id)
    {
        var item = items.Find(i => i.Id == id);

        if (item == null)
        {
            return NotFound();
        }

        return Ok(item);
    }
}
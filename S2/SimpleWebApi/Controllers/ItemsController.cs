using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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

    [HttpPost]
    public ActionResult<Item> Create(Item newItem)
    {
        newItem.Id = items.Count + 1;
        items.Add(newItem);
        return CreatedAtAction(nameof(Get), new { id = newItem.Id }, newItem);
    }

    [HttpPut("{id}")]
    public ActionResult<Item> Update(int id, Item updatedItem)
    {
        var existingItem = items.Find(i => i.Id == id);
        if (existingItem == null)
        {
            return NotFound();
        }
        
        existingItem.Name = updatedItem.Name;
        existingItem.Price = updatedItem.Price;
        return Ok(existingItem);   
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var itemToRemove = items.Find(i => i.Id == id);
        if (itemToRemove == null)
        {
            return NotFound();
        }
        
        items.Remove(itemToRemove);
        return NoContent();
    }

}
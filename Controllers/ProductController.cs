
using BookVault.Data;
using BookVault.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookVault.Controllers;

public class ProductController : Controller
{
    private readonly ApplicationDbContext _db;

    public ProductController(ApplicationDbContext db)
    {
        _db = db;
    }

    /// <summary>Lists all products, with optional search by title or author.</summary>
    public IActionResult Index(string? searchString)
    {
        var query = _db.Products.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchString))
        {
            query = query.Where(p =>
                p.Title.Contains(searchString) ||
                p.Author.Contains(searchString) ||
                p.Genre.Contains(searchString));
        }

        ViewData["SearchString"] = searchString;
        return View(query.AsNoTracking().ToList());
    }

    /// <summary>Shows the create product form.</summary>
    public IActionResult Create()
    {
        return View();
    }

    /// <summary>Handles submission of the create product form.</summary>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            TempData["success"] = $"\"{product.Title}\" was added to BookVault successfully!";
            return RedirectToAction(nameof(Index));
        }
        return View(product);
    }

    /// <summary>Shows the edit form for an existing product.</summary>
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var product = _db.Products.Find(id);
        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    /// <summary>Handles submission of the edit product form.</summary>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Product product)
    {
        if (ModelState.IsValid)
        {
            _db.Products.Update(product);
            _db.SaveChanges();
            TempData["success"] = $"\"{product.Title}\" was updated successfully!";
            return RedirectToAction(nameof(Index));
        }
        return View(product);
    }

    /// <summary>Shows the delete confirmation page for a product.</summary>
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var product = _db.Products.Find(id);
        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    /// <summary>Handles the confirmed deletion of a product.</summary>
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int? id)
    {
        var product = _db.Products.Find(id);
        if (product == null)
        {
            return NotFound();
        }

        _db.Products.Remove(product);
        _db.SaveChanges();
        TempData["success"] = $"\"{product.Title}\" was removed from BookVault.";
        return RedirectToAction(nameof(Index));
    }
}

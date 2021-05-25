using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMS.Models.Entity;
using InventoryMS.DB;
using Microsoft.EntityFrameworkCore;

namespace InventoryMS.DAL
{
    public static class _DAL
    {
        public static class Products
        {
            public static async Task<List<Product>> All()
            {
                using(var db=new InventoryMsDbContext())
                {
                    // поєднуємо сутність product  з сутністю ProductUnit
                    return await db.Product.Include(p=>p.ProductUnit).ToListAsync();
                }
            }

            public static async Task<Product> ByID(int productID)
            {
                using(var db=new InventoryMsDbContext())
                {
                    return await db.Product.Include(p => p.ProductUnit).Where(p => p.ProductID == productID).FirstOrDefaultAsync();
                }
            }

            public static async Task<Product> Add(Product productToAdd)
            {
                using(var db=new InventoryMsDbContext())
                {
                    productToAdd.ProductUnit = await db.Unit.Where(u => u.UnitID == productToAdd.ProductUnit.UnitID).FirstOrDefaultAsync();
                    await db.Product.AddAsync(productToAdd);
                    await db.SaveChangesAsync();
                    return productToAdd;
                
                
                }
            }
            public static async Task<bool> DeleteByID(int productID)
            {
                using(var db=new InventoryMsDbContext())
                {
                    Product productToDelete = await db.Product.Where(p => p.ProductID == productID).FirstOrDefaultAsync();
                    if (productToDelete != null)
                    {
                        db.Product.Remove(productToDelete);
                        await db.SaveChangesAsync();
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                
                
                
                }
            }
            public static async Task<Product> Update(Product product)
            {
                using (var db = new InventoryMsDbContext())
                {
                    Product productToUpdate =await db.Product.Where(p => p.ProductID == product.ProductID).FirstOrDefaultAsync();
                    if (productToUpdate != null)
                    {
                        productToUpdate.ProductName = product.ProductName;
                        productToUpdate.ProductPrice = product.ProductPrice;
                        productToUpdate.ProductUnit= await db.Unit.Where(u => u.UnitID == product.ProductUnit.UnitID).FirstOrDefaultAsync();

                        await db.SaveChangesAsync();
                        return productToUpdate;
                    }
                    return new Product();                                                     
                }
            }
        }
        public static class Units
        {
            public static async Task<List<Unit>> All()
            {
                using(var db=new InventoryMsDbContext())
                {
                    return await db.Unit.ToListAsync();
                }
            }
        }
    }
}

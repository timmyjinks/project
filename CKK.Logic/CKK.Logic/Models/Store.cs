using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class Store : Entity, IStore
    {
        public List<StoreItem> Items = new List<StoreItem>();

        public StoreItem AddStoreItem(Product product, int quantity)
        {
            var q =
                from i in Items
                where i.Product == product
                select i;
            if (quantity <= 0)
            {
               throw new InventoryItemStockTooLowException();
            }else
            {
                if (Items.Count == 0)
                {
                    Items.Add(new StoreItem(product, quantity));
                    return Items[0];
                }else if (Items.Count != 0)
                {
                    int count = 0;
                    foreach (var prod in Items)
                    {
                        count++;
                        if (prod.Product != product && count == Items.Count())
                        {
                            Items.Add(new StoreItem(product, quantity));
                            foreach (var obj in q)
                            {
                                return obj;
                            }return null;
                        }else if (prod.Product == product)
                        {
                            foreach (var obj in q)
                            {
                                quantity = obj.Quantity + quantity;
                                obj.Quantity = quantity;
                                return obj;
                            }return null;
                        }
                    }return null;
                }else { return null; }
            }
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            var q =
                from i in Items
                where i.Product.Id == id
                select i;
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();

            }else 
            {
                foreach (var prod in q)
                {
                    if (quantity - prod.Quantity > 0 || prod.Product == null)
                    {
                        prod.Quantity = 0;
                        return prod;
                    }else
                    {
                        quantity = prod.Quantity - quantity;
                        prod.Quantity = quantity;
                        return prod;
                    }
                }throw new ProductDoesNotExistException();
            }
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }

        public StoreItem FindStoreItemById(int id)
        {
            var q =
                from i in Items
                where i.Product.Id == id
                select i;
            if (id < 0)
            {
                throw new InvalidIdException();
                
            }else 
            {
                foreach (var i in q)
                {
                    return i;
                }return null;
            }
        }
    }
}
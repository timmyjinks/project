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
        private List<StoreItem> Items = new List<StoreItem>();

        public void SetName(string name)
        {
            _name = name;
        }

        public StoreItem AddStoreItem(Product product, int quantity)
        {
            var q =
                from i in Items
                where i._product == product
                select i;
            if (quantity > 0)
            {
                if (Items.Count == 0)
                {
                    Items.Add(new StoreItem(product, quantity));
                    return Items[0];
                }
                else if (Items.Count != 0)
                {
                    int count = 0;
                    foreach (var prod in Items)
                    {
                        count++;
                        if (prod._product != product && count == Items.Count())
                        {
                            Items.Add(new StoreItem(product, quantity));
                            foreach (var obj in q)
                            {
                                return obj;
                            }
                            return null;
                        }
                        else if (prod._product == product)
                        {
                            foreach (var obj in q)
                            {
                                quantity = obj._quantity + quantity;
                                obj._quantity = quantity;
                                return obj;
                            }
                            return null;
                        }
                    }
                    return null;
                }
                else { return null; }
            }
            else { throw new InventoryStockToolLowException(); }
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            var q =
                from i in Items
                where i._product._id == id
                select i;
            if (quantity > 0)
            {
                foreach (var prod in q)
                {
                    if (quantity - prod._quantity > 0)
                    {
                        prod._quantity = 0;
                        return prod;
                    }else if (prod._product == null)
                    {
                        throw new ProductDoesNotExistException();
                    }
                    else
                    {
                        quantity = prod._quantity - quantity;
                        prod._quantity = quantity;
                        return prod;
                    }
                }return null;
            }
            else { throw new ArgumentOutOfRangeException(); }
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }

        public StoreItem FindStoreItemById(int id)
        {
            var q =
                from i in Items
                where i._product._id == id
                select i;
            if (id > 0)
            {
                foreach (var i in q)
                {
                    return i;
                }
                return null;
            }else { throw new InvalidException(); }
        }
    }
}
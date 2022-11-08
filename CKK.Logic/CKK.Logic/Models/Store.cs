using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private List<StoreItem> Items = new List<StoreItem>();

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public StoreItem AddStoreItem(Product product, int quantity)
        {
            var q =
                from i in Items
                where i.GetProduct() == product
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
                        if (prod.GetProduct() != product && count == Items.Count())
                        {
                            Items.Add(new StoreItem(product, quantity));
                            foreach (var obj in q)
                            {
                                return obj;
                            }
                            return null;
                        }
                        else if (prod.GetProduct() == product)
                        {
                            foreach (var obj in q)
                            {
                                quantity = obj.GetQuantity() + quantity;
                                obj.SetQuantity(quantity);
                                return obj;
                            }
                            return null;
                        }
                    }
                    return null;
                }
                else { return null; }
            }
            else { return null; }
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            var q =
                from i in Items
                where i.GetProduct().GetId() == id
                select i;
            foreach (var prod in q)
            {
                if (quantity - prod.GetQuantity() > 0)
                {
                    prod.SetQuantity(0);
                    return prod;
                }
                else
                {
                    quantity = prod.GetQuantity() - quantity;
                    prod.SetQuantity(quantity);
                    return prod;
                }
            }
            return null;
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }

        public StoreItem FindStoreItemById(int id)
        {
            var q =
                from i in Items
                where i.GetProduct().GetId() == id
                select i;
            foreach(var i in q)
            {
                return i;
            }return null;
        }
    }
}
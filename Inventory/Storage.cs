using System.Collections.Generic;


namespace Inventory
{
    public class Storage
    {
        List<Item> items;

        public Storage()
        {
             this.items = new List<Item>();
        }

        private Item FindItemById(string id)
        {
            return this.items.Find(i => i.Id == id);
        }

        public Item[] GetAllItems()
        {
            return this.items.ToArray();
        }

        public Item GetItemById(string id)
        {
            return FindItemById(id);
        }

        public Item FindItemByName(string name)
        {
            return this.items.Find(i => i.Name == name);
        }

        public void AddItem(Item item)
        {
            Item found = items.Find(i => i.Id == item.Id);
            if (found != null) {
                found.AddAmmount(item.Ammount);
            } else {
                items.Add(item);
            }

        }

        public void SetItemAmmount(string id, int ammount)
        {
            Item i = FindItemById(id);
            if (i != null)
            {
                int index = items.IndexOf(i);
                items[index].Ammount = ammount;

            }
        }

        public void RemoveItem(Item i)
        {
            items.Remove(i);
        }

        public void RemoveAll()
        {
            items.Clear();
        }

            public void RemoveItem(string id)
        {
            Item i = FindItemById(id);
            if (i != null)
            {
                RemoveItem(i);
            }
        }

        public void RemoveSomeElementFromItem(string id, int ammount)
        {
            Item i = FindItemById(id);
            if (i != null)
            {
                int left = i.ReduceAmmount(ammount);
                if (left == 0)
                {
                    RemoveItem(id);
                }
            }
                
        }

        public void RemoveSomeElementFromItem(Item i, int ammount)
        {
                int left = i.ReduceAmmount(ammount);
                if (left == 0)
                {
                items.Remove(i);
                }

        }
    }
}

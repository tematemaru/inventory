using System;
namespace Inventory
{
    public interface IItem
    {
        public IItem GetItem();
        public void SetItem(IItem item);
        public void AddAmmount(int ammount);

    }
}

using System;

namespace Inventory
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Storage s = new Storage();

            Console.WriteLine(s.GetAllItems().Length == 0);
            Console.WriteLine("-----------------------");
            s.RemoveAll();
            s.AddItem(new Item("1", "ItemName", 1));

            Console.WriteLine(s.GetAllItems().Length == 1);
            Item i1 = s.GetItemById("1");
            Console.WriteLine(i1.Name);
            Console.WriteLine("-----------------------");

            s.RemoveItem(i1);

            s.RemoveAll();
            Console.WriteLine(s.GetAllItems().Length == 0);
            Console.WriteLine("-----------------------");
            s.RemoveAll();

            s.AddItem(new Item("1", "ItemName", 1));

            s.RemoveSomeElementFromItem("1", 1);

            Console.WriteLine(s.GetAllItems().Length == 0);
            Console.WriteLine("-----------------------");
            s.RemoveAll();

            s.AddItem(new Item("1", "ItemName", 1));
            s.AddItem(new Item("1", "ItemName", 2));

            Item i2 = s.GetItemById("1");
            Console.WriteLine(i2.Name == "ItemName");
            Console.WriteLine(i2.Ammount == 3);
            Console.WriteLine("-----------------------");

            s.RemoveAll();
            s.AddItem(new Item("1", "ItemName", 1));
            s.AddItem(new Item("2", "ItemName2", 3));

            Item i3 = s.GetItemById("1");
            Item i4 = s.GetItemById("2");
            Console.WriteLine(i3.Name == "ItemName");
            Console.WriteLine(i3.Ammount == 1);

            Console.WriteLine(i4.Name == "ItemName2");
            Console.WriteLine(i4.Ammount == 3);

            Console.WriteLine("-----------------------");


            s.RemoveSomeElementFromItem("2", 1);
            Console.WriteLine(i4.Ammount == 2);

            Console.WriteLine("-----------------------");

            s.RemoveSomeElementFromItem(i4, 1);
            Console.WriteLine(i4.Ammount == 1);

            Console.WriteLine("-----------------------");

            s.RemoveSomeElementFromItem(i4, 1);
            Console.WriteLine(s.GetItemById("2") == null);
        }
    }
}

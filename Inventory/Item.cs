namespace Inventory
{
    public class Item
    {
        string id;
        string name;
        int ammount = 0;


        public Item(string id, string name, int ammount)
        {
            this.id = id;
            this.name = name;
            this.ammount = ammount;

        }

        public string Id
        {
            get { return id; }

        }

        public string Name
        {
            get { return name; }

        }

        public int Ammount
        {
            get { return ammount; }
            set { ammount = value; }

        }

        public int AddAmmount(int ammount)
        {
            this.ammount += ammount;

            return this.ammount;
        }



        public int ReduceAmmount(int ammount)
        {
            if (this.ammount <= ammount)
            {
                this.ammount = 0;
            } else
            {
                this.ammount -= ammount;
            }


            return this.ammount;
        }
    }
}

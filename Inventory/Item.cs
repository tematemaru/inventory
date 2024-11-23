namespace Inventory
{
    public class Item
    {
        string id;
        string name;
        int ammount;


        public Item(string id, string name, int ammount)
        {
            this.id = id;
            this.name = name;
            this.ammount = ammount;

        }

        public string Id
        {
            get { return this.id; }

        }

        public string Name
        {
            get { return this.name; }

        }

        public int Ammount
        {
            get { return this.ammount; }
            set { this.ammount = value; }

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

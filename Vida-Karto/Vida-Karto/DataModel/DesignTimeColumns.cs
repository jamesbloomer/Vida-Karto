namespace Vida_Karto.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DesignTimeColumns
    {
        public DesignTimeColumns()
        {
            this.SetUpTestData();
        }

        public ObservableCollection<Column> Columns { get; set; }

        private void SetUpTestData()
        {
            this.Columns = new ObservableCollection<Column>()
            {
                new Column()
                {
                    Name = "Column 1",
                    Cards = new ObservableCollection<Card>()
                    {
                        new Card() { Name = "First card" },
                        new Card() { Name = "Second card" },
                        new Card() { Name = "Third card" }
                    }
                },
                new Column()
                {
                    Name = "Second column",
                    Cards = new ObservableCollection<Card>()
                    {
                        new Card() { Name = "4 card" },
                        new Card() { Name = "5 card" },
                    }
                },
                new Column()
                {
                    Name = "The third column",
                    Cards = new ObservableCollection<Card>()
                    {
                        new Card() { Name = "6 card" },
                        new Card() { Name = "7 card" },
                        new Card() { Name = "8card" }
                    }
                },
                new Column()
                {
                    Name = "The fourth column",
                    Cards = new ObservableCollection<Card>()
                    {
                        new Card() { Name = "9 card" },
                        new Card() { Name = "10 card" }
                    }
                }
            };
        }
    }
}

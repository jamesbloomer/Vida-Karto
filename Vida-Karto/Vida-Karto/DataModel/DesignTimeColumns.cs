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
                    Name = "First column",
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
                    Name = "Third column",
                    Cards = new ObservableCollection<Card>()
                    {
                        new Card() { Name = "6 card" },
                        new Card() { Name = "7 card" },
                        new Card() { Name = "8 card" }
                    }
                },
                new Column()
                {
                    Name = "Fourth column",
                    Cards = new ObservableCollection<Card>()
                    {
                        new Card() { Name = "9 card" },
                        new Card() { Name = "10 card" }
                    }
                },
                new Column()
                {
                    Name = "Fifth column",
                    Cards = new ObservableCollection<Card>()
                    {
                        new Card() { Name = "11 card" },
                        new Card() { Name = "12 card" }
                    }
                },
                new Column()
                {
                    Name = "Sixth column",
                    Cards = new ObservableCollection<Card>()
                    {
                        new Card() { Name = "13 card" },
                        new Card() { Name = "14 card" },
                        new Card() { Name = "15 card" }
                    }
                }
            };
        }
    }
}

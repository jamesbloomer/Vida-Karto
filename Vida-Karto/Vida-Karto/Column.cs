namespace Vida_Karto
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Column
    {
        public string Name { get; set; }

        public ObservableCollection<Card> Cards { get; set; }
    }
}

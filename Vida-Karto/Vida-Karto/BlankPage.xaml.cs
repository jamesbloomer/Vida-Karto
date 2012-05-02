using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Vida_Karto
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage : Page
    {
        public BlankPage()
        {
            this.InitializeComponent();
        }

        public List<Column> Columns { get; set; }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.SetUpTestData();
            this.DataContext = this;
        }

        private void SetUpTestData()
        {
            this.Columns = new List<Column>()
            {
                new Column()
                {
                    Name = "Column 1",
                    Cards = new List<Card>()
                    {
                        new Card() { Name = "First card" },
                        new Card() { Name = "Second card" },
                        new Card() { Name = "Third card" }
                    }
                },
                new Column()
                {
                    Name = "Second column",
                    Cards = new List<Card>()
                    {
                        new Card() { Name = "4 card" },
                        new Card() { Name = "5 card" },
                    }
                },
                new Column()
                {
                    Name = "The third column",
                    Cards = new List<Card>()
                    {
                        new Card() { Name = "6 card" },
                        new Card() { Name = "7 card" },
                        new Card() { Name = "8card" }
                    }
                },
                new Column()
                {
                    Name = "The fourth column",
                    Cards = new List<Card>()
                    {
                        new Card() { Name = "9 card" },
                        new Card() { Name = "10 card" }
                    }
                }
            };
        }
    }
}

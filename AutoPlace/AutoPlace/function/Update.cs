using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AutoPlace.function
{
    class Update
    {
        AutoEntities AutoEntities = new AutoEntities();
        public void update(DataGrid DGClients)
        {
            AutoEntities.SaveChanges();
            DGClients.ItemsSource = AutoEntities.Card.ToList();
            return;
        }
    }
}

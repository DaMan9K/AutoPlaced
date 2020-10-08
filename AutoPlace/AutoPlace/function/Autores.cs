using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AutoPlace.function
{
    class Autores
    {
        AutoEntities AutoDB = new AutoEntities();

        public void Auto(TextBox TBLogin ,PasswordBox PBPassword)
        {
            if (String.IsNullOrEmpty(TBLogin.Text) || String.IsNullOrEmpty(PBPassword.Password))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Worker worker = AutoDB.Worker.Where(a => a.Login == TBLogin.Text & a.Password == PBPassword.Password).SingleOrDefault();
            if (worker == null)
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                TBLogin.Clear();
                PBPassword.Clear();
                return;
            }
            if(worker.Post == "Охраник" )
            {
                Windows.Main main = new Windows.Main();
                main.Show();
                return;
                
            }
            





        }
    }
}

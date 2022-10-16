using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prakt5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pair rn = new Pair();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Proverka(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1);
            Int32.TryParse(pair2.Text, out int p2);
            bool chek;
            chek = rn.Prov(p1,p2);
            if (chek == true) Itog.Text = "Числа равны";
            else Itog.Text = "Числа не равны";
        }

        private void Proizv(object sender, RoutedEventArgs e)
        {
            int proizv;
            Int32.TryParse(pair1.Text, out int p1);
            Int32.TryParse(pair2.Text, out int p2);
            proizv = rn.Peremnozh(p1,p2);
            Itog.Text = Convert.ToString(proizv);
        }

        private void Otric(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(pair3.Text, out int p3);
            Int32.TryParse(pair4.Text, out int p4);
            int paraNov1,paraNov2;
            rn.Vichit(p3, p4,out paraNov1,out paraNov2);
            Itog.Text = Convert.ToString($"{paraNov1};{paraNov2}");
        }

        private void TriPari(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(pair3.Text, out int p3);
            Int32.TryParse(pair4.Text, out int p4);
            Int32.TryParse(pair5.Text, out int p5);
            Int32.TryParse(pair6.Text, out int p6);
            int paraNov1, paraNov2;
            rn.Vichit(p3,p4,p5, p6, out paraNov1, out paraNov2);
            Itog.Text = Convert.ToString($"{paraNov1};{paraNov2}");
        }

        private void Spravka(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калитин Сергей ИСП-31, Вариант 13\n Задание:\n Создать базовый класс Pair (пара целых чисел)."+
                "Создать необходимые методы и свойства.Определить методы с операциями проверки на равенство и перемножения полей."+
                " Реализовать операцию вычитания пар по формуле (а, b) - (с, d) = (а - c, b - d).Создать перегруженный метод для вычитания трех пар чисел.");
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

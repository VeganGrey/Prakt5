using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt5
{
    internal class Pair
    {
        /// <summary>
        /// Класс для пар чисел и операций сравнения и вычитания
        /// </summary>
        public int Pair1 { get; set; }
        public int Pair2 { get; set; }
        /// <summary>
        /// Метод для Проверки чисел первой пары на равенство
        /// </summary>
        /// <returns>Логическое значение "верно" или "неверно"</returns>
        /// 
        public Pair()
        {
            Pair1 = 0;
            Pair2 = 0;
        }

        public bool Prov()
        {
            return Pair1 == Pair2;
        }
        /// <summary>
        /// Метод для нахождения произведния чисел в первой паре
        /// </summary>
        /// <returns></returns>
        public int Peremnozh()
        {
            return Pair1 * Pair2;
        }

        public void Vichit(Pair value,out int dop1,out int dop2)
        {
            dop1 = Pair1 - value.Pair1;
            dop2 = Pair2 - value.Pair2;
        }
        
        public void Vichit(Pair value1,Pair value2,out int dop1, out int dop2)
        {
            dop1 = Pair1 - value1.Pair1 - value2.Pair1;
            dop2 = Pair2 - value1.Pair1 - value2.Pair2;
        }
    }
}

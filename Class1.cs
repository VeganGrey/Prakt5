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
        private int _pair1, _pair2, _pair3, _pair4, _pair5, _pair6;

        public int Pair1 { get { return _pair1; } set { _pair1 = value; } }
        public int Pair2 { get { return _pair2; } set { _pair2 = value; } }
        public int Pair3 { get { return _pair3; } set { _pair3 = value; } }
        public int Pair4 { get { return _pair4; } set { _pair4 = value; } }
        public int Pair5 { get { return _pair5; } set { _pair5 = value; } }
        public int Pair6 { get { return _pair6; } set { _pair6 = value; } }
        /// <summary>
        /// Метод для Проверки чисел первой пары на равенство
        /// </summary>
        /// <returns>Логическое значение "верно" или "неверно"</returns>
        public bool Prov()
        {
            return _pair1 == _pair2;
        }
        /// <summary>
        /// Метод для нахождения произведния чисел в первой паре
        /// </summary>
        /// <returns></returns>
        public int Peremnozh()
        {
            return _pair1 * _pair2;
        }
        /// <summary>
        /// Метод для нахождения разности первой пары и второй пары
        /// </summary>
        /// <param name="dop1">Значения разности первого числа перв пары и второй пары</param>
        /// <param name="dop2">Значения разности второго числа перв пары и второй пары</param>
        public void Vichit(out int dop1,out int dop2)
        {
            dop1 = _pair1 - _pair3;
            dop2 = _pair2 - _pair4;
        }
        /// <summary>
        /// Метод для нахождения разности трех пар чисел
        /// </summary>
        /// <param name="p5">Значения первого числа третьей пары</param>
        /// <param name="p6">Значения второго числа третьей пары</param>
        /// <param name="dop1">Значения разности первого числа перв пары,второй пары,третьей пары</param>
        /// <param name="dop2">Значения разности второго числа перв пары,второй пары,третьей пары</param>
        public void Vichit(int p5,int p6,out int dop1, out int dop2)
        {
            _pair5 = p5; _pair6 = p6;
            dop1 = _pair1 - _pair3 - _pair5;
            dop2 = _pair2 - _pair4 - _pair6;
        }
    }
}

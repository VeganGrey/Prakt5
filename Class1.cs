﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt5
{
    internal class Pair
    {
        private int _pair1, _pair2, _pair3, _pair4, _pair5, _pair6;

        public int Pair1 { get { return _pair1; } set { _pair1 = value; } }
        public int Pair2 { get { return _pair2; } set { _pair2 = value; } }
        public int Pair3 { get { return _pair3; } set { _pair3 = value; } }
        public int Pair4 { get { return _pair4; } set { _pair4 = value; } }
        public int Pair5 { get { return _pair5; } set { _pair5 = value; } }
        public int Pair6 { get { return _pair6; } set { _pair6 = value; } }

        public bool Prov(int p1,int p2)
        {
            _pair1 = p1;
            _pair2 = p2;
            if (_pair1 == _pair2)
            {
                return true;
            }
            else return false;
        }

        public int Peremnozh(int p1, int p2)
        {
            _pair1 = p1;
            _pair2 = p2;
            int Proizv = 0;
            Proizv = _pair1* _pair2;
            return Proizv;
        }

        public void Vichit(int p3,int p4,out int dop1,out int dop2)
        {
            _pair3 = p3;
            _pair4 = p4;
            dop1 = _pair1 - _pair3;
            dop2 = _pair2 - _pair4;
        }

        public void Vichit(int p3, int p4,int p5,int p6,out int dop1, out int dop2)
        {
            _pair3 = p3;
            _pair4 = p4;
            _pair5 = p5;
            _pair6 = p6;
            dop1 = _pair1 - _pair3 - _pair5;
            dop2 = _pair2 - _pair4 - _pair6;
        }
    }
}

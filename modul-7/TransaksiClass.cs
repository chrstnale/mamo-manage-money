using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_7
{
    internal class TransaksiClass
    {
        protected int _uang;
        protected int Uang { get { return _uang;} set { _uang = value;  } }
        public TransaksiClass(int uang)
        {
            Uang = uang;
        }
        public virtual void Transaksi(int jumlah)
        {
            Uang = jumlah;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_7
{
    internal class TransaksiMasuk : TransaksiClass
    {
        public TransaksiMasuk(int uang) : base(uang)
        {
            Uang = uang;
        }
        public override void Transaksi(int jumlah)
        {
            Uang += jumlah;
        }
    }
}

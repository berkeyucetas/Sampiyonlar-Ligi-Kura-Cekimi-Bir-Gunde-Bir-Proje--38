using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şampiyonlar_Ligi_Kura_Çekimi
{
    internal class Takim
    {
        private string Takimİsim;
        private string TakimÜlke;

        public Takim(string isim, string ülke)
        {
            Takimİsim = isim;
            TakimÜlke = ülke;
        }
        public string TeamName
        {
            get
            {
                return Takimİsim;
            }
            set
            {
                Takimİsim = value;
            }
        }
        public string TeamCountry
        {
            get
            {
                return TakimÜlke;
            }
            set
            {
                TakimÜlke= value;
            }
        }
        public override string ToString()
        {
            return Takimİsim + "-" + TakimÜlke;
        }
    }
}

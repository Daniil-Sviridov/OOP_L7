using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L7
{
    internal class ACoder : ICoder
    {
        private int _k;
        private int _n;

        private string _alp;
        private string _ALP;

        public ACoder()
        {
            _alp = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            _ALP = _alp.ToUpper();

            _n = _alp.Length;
            _k = 3;
        }
        public void Decode(ref string in_str)
        {
            StringBuilder sb = new StringBuilder();
            int x = 0;

            for (int i = 0; i < in_str.Length; i++)
            {
                if (_alp.Contains(in_str[i]))
                {
                    x = (_alp.IndexOf(in_str[i]) - _k) % _n;
                    x = x + (x >= 0 ? 0 : _n);
                    sb.Append(_alp.Substring(x, 1));
                }
                else if (_ALP.Contains(in_str[i]))
                {
                    x = (_ALP.IndexOf(in_str[i]) - _k) % _n;
                    x = x + (x >= 0 ? 0 : _n);
                    sb.Append(_ALP.Substring(x, 1));
                }
                else sb.Append(in_str[i]);
            }

            in_str = sb.ToString();
        }

        public void Encode(ref string in_str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < in_str.Length; i++)
            {
                if (_alp.Contains(in_str[i]))
                {
                    int y = (_alp.IndexOf(in_str[i]) + _k) % _n;
                    //in_str[i] = _alp.Substring(y, 1);
                    sb.Append(_alp.Substring(y, 1));
                }
                else if (_ALP.Contains(in_str[i]))
                {
                    int y = (_ALP.IndexOf(in_str[i]) + _k) % _n;
                    //in_str[i] = _ALP.Substring(y, 1)
                    sb.Append(_ALP.Substring(y, 1));
                }
                else sb.Append(in_str[i]);
            }

            in_str = sb.ToString();
        }

    }
}

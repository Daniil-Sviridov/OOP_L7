using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L7
{
    internal class BCoder : ICoder
    {
        private string _alp;
        private int _n;

        public BCoder()
        {
            _alp = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            _n = _alp.Length;
        }

        public void Decode(ref string in_str)
        {
            string backUp = _alp;

            Encode(ref backUp);

            string _alp1 = backUp;

            backUp = _alp;

            _alp = _alp1;

            Encode(ref in_str);

            _alp1 = backUp;


        }

        public void Encode(ref string in_str)
        {

            StringBuilder sb = new StringBuilder();
            bool Up = false;

            int x = -1;

            for (int i = 0; i < in_str.Length; i++)
            {

                x = _alp.IndexOf(in_str[i].ToString().ToLower());

                if (x < 0)
                {
                    sb.Append(in_str[i]);
                    continue;
                }

                x = _n - 1 - x;

                Up = _alp.IndexOf(in_str[i]) < 0;

                sb.Append(Up ? _alp.Substring(x, 1).ToUpper() : _alp.Substring(x, 1));

            }

            in_str = sb.ToString();
        }
    }
}

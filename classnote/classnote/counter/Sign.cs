using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classnote
{
    class Sign
    {
        public int begin=0, end, at;
        public string lift, right, sign, str;
        public Sign(string instr, string sign)
        {
            str = instr;
            this.sign = sign;
            end = str.Length-1;
            at = instr.IndexOf(sign);
            if (at != -1)
            {
                lift = instr.Substring(0, at);
                right = instr.Substring(at+1, instr.Length - at-1);
                for (int a = at - 1; a > 0; a--)
                {
                    char c = instr.ElementAt(a);
                    if (!((c>='0'&&c<='9')||c=='.'))
                    {
                        begin = a+1;
                        lift = instr.Substring(a + 1, at - a - 1);
                        break;
                    }
                }
                for (int c = at + 1; c < instr.Length; c++)
                {
                    char cc = instr.ElementAt(c);
                    if (!((cc >= '0' && cc <= '9') || cc == '.'))
                    {
                        end = c-1;
                        right = instr.Substring(at + sign.Length, c - at - sign.Length);
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// 获取字符出局部答案
        /// </summary>
        /// <returns>局部答案</returns>
        public string GetAns()
        {
            double da = 0, db = 0;
            try
            {
                da = double.Parse(this.lift);
            }
            catch
            {
                da = 0;
            }
            try
            {
                db = double.Parse(right);
            }
            catch
            {
                db = 0;
            }
            string ans = "";
            switch (this.sign)
            {
                case "+": ans = (da + db).ToString(); break;
                case "-": ans = (da - db).ToString(); break;
                case "*": ans = (da * db).ToString(); break;
                case "/": ans = (da / db).ToString(); break;
                case "^": ans = (Math.Pow(da, db)).ToString(); break;
                case "=": ans = " false"; if (da == db) ans = "true"; break;
                case ">": ans = " false"; if (da > db) ans = "true"; break;
                case "<": ans = " false"; if (da < db) ans = "true"; break;
                case "!": ans = da+"-"+db; break;
            }
            return ans;
           // return new MyMath().counter(lift + sign + right);
        }
        /// <summary>
        /// 获得处理符号周边结果后的结果
        /// </summary>
        /// <returns></returns>
        public string GetString()
        {
            string ans = str.Substring(0, begin) + this.GetAns() + str.Substring(end+ 1, str.Length - end - 1);
             return ans;
        }
        
    }
}

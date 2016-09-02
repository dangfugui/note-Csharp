using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classnote
{
    class MyMath
    {
        private string str;
        //abs
        //log
        //pow
        /// <summary>
        /// 进行复杂计算
        /// </summary>
        /// <param name="str_now"></param>
        /// <returns>复杂计算结果</returns>
        public string multiple(string str_now)
        {
            str = str_now;
            Console.WriteLine(str);
            string sign = "";
            int at = 0;
            string[] signs = { "(", "^", "/", "*", "+", "-","=" };
            for (int i = 0; i < signs.Length; i++)
            {
                int find = str.IndexOf(signs[i]);
                if (find != -1)
                {
                    at = find;
                    sign = signs[i];
                     break;
                }
            }
            switch (sign)
            {
                case "(":
                    {
                        int qian = 0, kuo2 = 0;
                        for (int i = at; i < str.Length; i++)
                        {
                            if (str.ElementAt(i) == '(')
                            {
                                qian++;
                            }
                            if (str.ElementAt(i) == ')')
                            {
                                qian--;
                                if (qian == 0)
                                {
                                    kuo2 = i;
                                    break;
                                }
                            }
                        }
                        string s = multiple(str.Substring(at + 1, kuo2 - at - 1));
                        str = str_now.Substring(0, at) + s + str_now.Substring(kuo2 + 1, str_now.Length - kuo2 - 1);
                        multiple(str);
                        break;
                    }
                case "^":
                    {
                        multiple(new Sign(str, "^").GetString());
                        break;
                    }
                case "/":
                    {
                        multiple(new Sign(str, "/").GetString());
                        break;
                    }
                case "*":
                    {
                        multiple(new Sign(str, "*").GetString());
                        break;
                    }
                case "+":
                    {
                        int sx =str.IndexOf("-");
                        if (sx>0&&sx<at)
                        {
                            at = sx; sign = "-";
                            if (at < 1) break;
                            multiple(new Sign(str, "-").GetString());
                            break;
                        }
                        multiple(new Sign(str, "+").GetString());
                        break;
                    }
                case "-":
                    {
                        if (at < 1) break;
                        multiple(new Sign(str, "-").GetString());
                        break;
                    }
                case "=":
                    {
                        if (at < 1) break;
                        multiple(new Sign(str, "=").GetString());
                        break;
                    }
            }
            return str;
        }
    }

}

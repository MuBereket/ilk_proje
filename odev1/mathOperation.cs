using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace odev1
{
    internal class mathOperation
    {

        postfix p ;
        stack s=new stack();

        public mathOperation(String str) {
        p=new postfix(str);
          
        }

        public String opertor1
        {
            get
            {
                String[] metin1 = p.Post.Split(" ");
               
                double sonuc1 = 0;

                for (int i = 0; i < metin1.Length; i++)
                {
                    String str = metin1[i];  
                    if (str[0] != '*' && str[0] != '/' && str[0] != '+')
                    {
                        s.push(metin1[i]);
                    }
                    else
                    {
                        double o1, o2;
                        o1 = Convert.ToDouble(s.List[s.Top]);
                        s.pop();
                        o2 = Convert.ToDouble(s.List[s.Top]);
                        s.pop();
                        switch (metin1[i][0])
                        {
                            case '+':
                                sonuc1 = o2 + o1;
                                break;

                            case '*':
                                sonuc1 = o2 * o1;
                                break;
                            case '/':
                                sonuc1 = o2 / o1;
                                break;
                            default:
                                MessageBox.Show("hata var!!");
                                break;
                        }
                        s.push("" + sonuc1);

                    }

                }

                return "" + sonuc1;

            }
        }
    }
}

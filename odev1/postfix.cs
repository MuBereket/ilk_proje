using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace odev1
{
    internal class postfix
    {
        stack s = new stack();
        Form1 f = new Form1();
        String post = "";

        public string Post { get => post; set => post = value; }

        public postfix(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char x = str[i];
                switch (x)
                {
                    case '+':
                        if (s.bosmu())
                        {//Boşsa, işareti ekleyin
                            s.push("" + x);
                            post += " ";
                        }
                        //Bu işaretlerden biri yoksa, işareti ekleyin
                        else if (s.List[s.Top][0] != '*' && s.List[s.Top][0] != '/'
                            && s.List[s.Top][0] != '-')
                        {
                            s.push("" + x);
                            post += " ";
                        }
                        //Bu işaretlerden biri varsa, boşaltma işlemini ve
                        //ardından işaret için ekleme işlemini yapın.
                        else
                        {
                            post += " " + s.List[s.Top];
                            s.pop();
                            s.push("" + x);
                            post += " ";
                        }
                        break;

                    case '-':
                        //Boşsa, işareti ekleyin
                        if (s.bosmu())
                        {
                            s.push("" + '+');
                            post += " " + x;
                        }
                        //Bu işaretlerden biri yoksa, işareti ekleyin
                        else if (s.List[s.Top][0] != '*'
                            && s.List[s.Top][0] != '/' && s.List[s.Top][0] != '+')
                        {
                            s.push("" + '+');
                            post += " " + x;
                        }
                        //Bu işaretlerden biri varsa, boşaltma işlemini ve
                        //ardından işaret için ekleme işlemini yapın.
                        else
                        {
                            post += " " + s.List[s.Top];
                            s.pop();
                            s.push("" + '+');
                            post += " " + x;
                        }

                        break;
                    case '*'://işaret ekle
                        if (s.Top != -1 && s.List[s.Top][0]=='/') {
                            post += " " + s.List[s.Top];
                            s.pop();
                            s.push("" + x);
                            post += " ";
                        }
                        else { 
                        s.push("" + x);
                        post += " ";}
                        break;
                    case '/'://işaret ekle
                        if (s.Top != -1 && s.List[s.Top][0] == '*')
                        {
                            post += " " + s.List[s.Top];
                            s.pop();
                            s.push("" + x);
                            post += " ";
                        }
                        else
                        {
                            s.push("" + x);
                            post += " ";
                        }
                        break;
                    default://numaralar ekle
                        post += "" + x;
                        break;

                }


            }
            islem();
        }
        //Yığının içeriğini boşaltırsınız
        void islem()
        {
            while (!s.bosmu())
            {

                post += " " + s.List[s.Top];
                s.pop();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1
{
    internal class stack
    {
        int top = -1;
        string[] list = new string[100];


        public string[] List { get => list; set => list = value; }
        public int Top { get => top; set => top = value; }

        public void push(string s)
        {
            if (dolumu())
            {
                MessageBox.Show("Hafıza dolu");
            }
            else
            {
                Top++;
                List[Top] = s;
            }
        }
        public void pop()
        {
            if (bosmu())
            {
                MessageBox.Show("Hafıza boş");
            }
            else { Top--; }
        }
        public bool bosmu() { return Top == -1; }
        bool dolumu() { return Top == List.Length; }

    }



}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jajboze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click_Click(object sender, EventArgs e)
        {
            try { 
            char[] pole = textBox1.Text.ToCharArray();
            int last = pole.Last();
            int delka = pole.Length - 1;
            char max = pole.Max();
            if (last <= '9' && last >= '0'){
                for(int i = 0; delka >= i; i++){
                    if (pole[i] <= '9' && pole[i] >= '0'){
                        pole[i] = 'x';
                    }
                }
            }
            else{
                for (int i = 0; delka >= i; i++)
                {
                    if(delka == i){pole[i] = max;}
                }
            }
            string vypis = new string(pole);
            textBox2.Text = vypis;
            }
            catch { MessageBox.Show("PROBLEM"); }
        }
    }
}

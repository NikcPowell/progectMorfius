using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                   }
        double stroka1,stroka2,result;
        char funkc;
         
        private void button3_Click(object sender, EventArgs e)
        {
            stroka1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            funkc = (sender as Button).Text[0];
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            
            stroka2 = Convert.ToDouble(textBox1.Text);
                if (funkc == '+')
                {
                    Funcsions p = new Funcsions();
                    result = p.Summa(stroka1, stroka2);

                }

                if (funkc == '*')
                {
                    Funcsions p = new Funcsions();
                    result = p.Multiplay(stroka1, stroka2);

                }
                if (funkc == '-')
                {
                    Funcsions p = new Funcsions();
                    result = p.Substact(stroka1, stroka2);

                }
                if (funkc == '/')
                {
                    Funcsions p = new Funcsions();
                    result = p.Devidet(stroka1, stroka2);

                }
                textBox1.Text = result.ToString();
            
           
        }
        
                  
            
    

        


    }

    
}

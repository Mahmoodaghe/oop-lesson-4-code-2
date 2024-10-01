using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الرابعة_الكود_الثاني
{
    public partial class Form1 : Form
    {
        
        string[] a;
        int i = 0,l=0;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void addA_Click(object sender, EventArgs e)
        {

            if (i <=l)
            {
                a[i++] = number2.Text;
                number2.Focus();
                number2.Clear();
                
            }
            else
                MessageBox.Show("the array is full");
        }

        private void number1_TextChanged(object sender, EventArgs e)
        {//حدث لا تشغل الازرار الى عند وجود قيمة
            if ((number1.Text != ""))
                addA.Enabled = sumA.Enabled = showA.Enabled = deletA.Enabled = true;
            else
                addA.Enabled = sumA.Enabled = showA.Enabled = deletA.Enabled = false;
            
        }

        private void number1_KeyPress(object sender, KeyPressEventArgs e)
        {//داله لاتسمح الى بالمعالة مع الارقام
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
           addA.Enabled= sumA.Enabled = showA.Enabled = deletA.Enabled = false;
            number2.KeyPress += number1_KeyPress;
            number2.TextChanged +=number1_TextChanged;
             

        }

        private void deletA_Click(object sender, EventArgs e)
        {
            int b = listBox1.Items.Count;
            if (b > 0)
            {
                MessageBox.Show("هل انت متاك من عملية الحذف");
                deletA.Focus() ;
                for (int k = 0; k < b; k++)
                    listBox1.Items.Remove(listBox1.Items[0]);
                i = l = 0;
                a = new string[0];//هنا تم حذف عناصر المصفوفة
            
            }
            else
                MessageBox.Show("no element for delet it");

          
        }

        private void number1_Leave(object sender, EventArgs e)
        {
             l = int.Parse(number1.Text);
             //l = Convert.ToInt16(number1.Text);
            a = new string[l]; i = 0;
        }

        private void showA_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//لحذف الهناصر بعدا عمل كل مره اضافة
            if (i > 0)
                for (int k = 0; k < i; k++)
                {
                    listBox1.Items.Add(a[k]);
                }
            else
                MessageBox.Show("no in  element");
           }

        private void sumA_Click(object sender, EventArgs e)
        {
            int s,b, sum = 0;
            b = a.Length;
            if (b > 0)
            {
                for (int k = 0; k <= i; k++)
                {
                    s = Convert.ToInt16(a[k]);
                    sum = sum + s;
                }
                textBox3.Text = sum.ToString();
            }
            else
                MessageBox.Show("no element for sum it!");
            textBox3.BackColor = Color.Gray;   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deletA_MouseEnter(object sender, EventArgs e)
        {
            deletA.BackColor = Color.Red;
        }

        private void deletA_MouseHover(object sender, EventArgs e)
        {
            deletA.BackColor = Color.White;
        }

       /* private void number1_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace classnote
{
    public partial class FormCounter : Form
    {
        string item = "";
        public FormCounter()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            addnum("0");
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            addnum("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            addnum("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addnum("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addnum("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addnum("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addnum("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addnum("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addnum("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
           addnum("9");
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            if (listbox1.Items.Count > 0)  //清空所有项
             {
               listbox1.Items.Clear();
             }
            item = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            item = item.Substring(0, item.Length-1);
            addnum("");
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            addnum("/");
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            addnum("*");
            
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            addnum("-");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addnum("+");
        }

        private void btn_dian_Click(object sender, EventArgs e)
        {
            addnum(".");
        }
        private void addnum(string n)
        {
            item += n;
           // Console.WriteLine(listbox1.Items.Count + ">>" + listbox1.SelectedItems.Count);
            if (listbox1.Items.Count > 0)
            {
                listbox1.Items.RemoveAt(listbox1.Items.Count-1);
            }
            listbox1.Items.Add(item);
        }
        private void btn_equal_Click(object sender, EventArgs e)
        {
            myCounter(item);   
        }
        //textbox回车事件    添加全局this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                item = textbox.Text;
                myCounter(item);
                textbox.Text = "";
            }
        }

        private string myCounter(string str){
            string ans = "error";
            MyMath math = new MyMath();
            try
            {
                ans = math.multiple(str);
            }
            catch 
            {
                ans = "error";
            }
            addnum("=" + ans);
            listbox1.Items.Add("");
            listbox1.TopIndex = listbox1.Items.Count - (int)(listbox1.Height / listbox1.ItemHeight);
            item = "";
            return ans;
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

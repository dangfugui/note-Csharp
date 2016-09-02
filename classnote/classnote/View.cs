using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace classnote
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void counter_Click(object sender, EventArgs e)
        {
            new FormCounter().Show();       //图像化计算器
        }

        private void mynote_Click(object sender, EventArgs e)
        {
            new MyNote().Show();   //上课笔记
        }

        private void Type_Click(object sender, EventArgs e)
        {
            new MyNote().Type();
        }

        private void String_Click(object sender, EventArgs e)
        {
            new MyNote().TestString();
        }

        private void Math_Click(object sender, EventArgs e)
        {
            new MyNote().TestMath();
        }

        private void Char_Click(object sender, EventArgs e)
        {
            new MyNote().TestChar();
        }

        private void Enum_Click(object sender, EventArgs e)
        {
            new MyNote().myEnum();
        }

        private void Array_Click(object sender, EventArgs e)
        {
            new MyNote().MyArray();
        }

        private void Define_Click(object sender, EventArgs e)
        {
            new MyNote().Define();
        }

        private void ArrayList_Click(object sender, EventArgs e)
        {
            new Collections().myarrayList();
        }

        private void Stack_Click(object sender, EventArgs e)
        {
            new Collections().myStack();
        }

        private void Queue_Click(object sender, EventArgs e)
        {
            new Collections().myQueue();
        }

        private void Hashtable_Click(object sender, EventArgs e)
        {
            new Collections().myHashtable();
        }
      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWindows
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            HelloLabel.Text = "HelloWorld C#";

            //int num1 = 1;
            //int num2 = 2;
            //int sum = num1 + num2;

            //HelloLabel.Text = sum.ToString();
            //ToString() -> 정수형을 문자열로 바꿔주는 함수. Text에 정수형을 넣을 수 없으니 문자로 바꿔서 입력
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8]; // 8 e 8 lik 64 tane button oluşturmuş olduk.
            int top = 0;
            int left = 0;
            //i=0 ken j=0 (0,0) buttonu işaret eder bu şekilde bütün butonları
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //8 satır için bir dğer
            {
                //0,0-0,1 şeklinde tektek butonları gezer sonra üsteki for döngüsünü çağırıp 1,0-1,1 bu şekilde devam eder
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    //butonları yan yana alt alta yazabilmek için kullanılan kodlar
                    buttons[i, j].Left = left; //formun başlangıç değerine göre uzaklığı şeklinde yazmak
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]); //this formu işaret eder bu buttonları ekrana koy demek
                }
                top += 50;
                left = 0;
            }
        }
    }
}

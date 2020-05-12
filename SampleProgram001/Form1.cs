using System;
using System.Collections;
using System.Windows.Forms;

namespace SampleProgram001
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            al.Add("원숭이");
            al.Add("닭");
            al.Add("개");
            al.Add("돼지");
            al.Add("쥐");
            al.Add("소");
            al.Add("범");
            al.Add("토끼");
            al.Add("용");
            al.Add("뱀");
            al.Add("말");
            al.Add("양");

            MessageBox.Show(al[Convert.ToInt32(comboBox1.SelectedIndex)].ToString());
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            switch(comboBox2.SelectedIndex)
            {
                case 11:
                case 0:
                case 1:
                    result = "겨울";
                    break;

                case 2:
                case 3:
                case 4:
                    result = "봄";
                    break;

                case 5:
                case 6:
                case 7:
                    result = "여름";
                    break;

                case 8:
                case 9:
                case 10:
                    result = "가을";
                    break;
            }

            MessageBox.Show(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write("학년을 입력하세요 : ");
            int level = int.Parse(Console.ReadLine());
            string defaultText1 = "수강해야 하는 전공 학점:";
            string defaultText2 = "학점";

            switch (level)
            {
                case 1:
                    Console.WriteLine(defaultText1 + "12" + defaultText2);
                    break;
                case 2:
                    Console.WriteLine(defaultText1 + "18" + defaultText2);
                    break;
                case 3:
                    Console.WriteLine(defaultText1 + "10" + defaultText2);
                    break;
                case 4:
                    Console.WriteLine(defaultText1 + "18" + defaultText2);
                    break;
                default:
                    // 기본값을 아무것도 출력하지 않는다.
                    break;
            }
        }
    }
}

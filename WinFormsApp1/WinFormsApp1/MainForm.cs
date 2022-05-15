using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          
        }
        private void button_Cut_Click(object sender, EventArgs e)
        {
            //문자형 변수 선언
            String inputText = textBox_Input.Text; 
            String outputText = "";

            try
            {
                //정수형 변수 선언
                int front = Convert.ToInt32(textBox_Front.Text);
                int back = Convert.ToInt32(textBox_Back.Text);


                //remove = 시작값 종료값을 넣어 문자를 자르는 함수
                //입력한 문자
                //0 1 2 3 4 5
                outputText = inputText.Remove(0, front);
                outputText = outputText.Remove(outputText.Length - back, back);
                textBox_Output.Text = outputText;
            }
            catch (Exception)
            {
                MessageBox.Show("입력하신 문자 또는 자르기 값을 확인하시요");
            }
        }

        private void textBox_Front_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress_Number(sender, e);
        }

        private void textBox_Back_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress_Number(sender, e);
        }
        private void KeyPress_Number(object sender, KeyPressEventArgs e)
        {
            //! : Not 아니다
            // 숫자가 아닐 때만 
            if(!Char.IsNumber(e.KeyChar)&& e.KeyChar != 8)
            {
                //숫자가 아닌 값: 숫자를 제외한 모든 값은 키처리를 했다.
                //textbox 값이 입력되는 것이 아닌 textbox에는 입력이 안되었지만 키 입력을 완료했다는뜻
                e.Handled = true;

                //부정2개가 만나면 긍정
                //숫자가 아닐때 입력되지 않는다
                // 8이 아닐때 입력되지않는다
            }
        }
    }
}

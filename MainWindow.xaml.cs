using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Button_16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] btn = new Button[16];
        static int margin = 10;
        static int btnW = 50;
        static int btnH = 30;
        static int btnS = 3;

        public MainWindow() //생성자 함수
        {
            InitializeComponent();

            this.SizeToContent = SizeToContent.WidthAndHeight;//Canvas 사이즈에 맞춘다.

            canvas1.Width = 2 * margin + 4 * btnW + 3 * btnS;
            canvas1.Height = 2 * margin + 4 * btnW + 3 * btnS;
            // Form 프로그램에서는
            // ClientSize = new Size(2*margin+ 4 * btnW + 3 * btnS, 2*margin+ 4 * btnW + 3 * btnS);

            for (int i = 0; i < 16; i++)
            {
                btn[i] = new Button();
                btn[i].Content = i;
                btn[i].Width = btnW;
                btn[i].Height = btnH;
                btn[i].Click += btn_Click;

                //windowForm에서는 btn.Location을 사용했었음.
                Canvas.SetRight(btn[i], margin + i % 4 * (btnW + btnS));
                Canvas.SetBottom(btn[i], margin + i / 4 * (btnH + btnS));

                canvas1.Children.Add(btn[i]); //this.Controls.Add(btn[i])
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Content + "빈 버튼이 클릭되었습니다.");

        }
    }
}

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

namespace fooder
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<string> food = new List<string>();
        int x = 10;
        int y = 10;
        int num = 6;
        int ans;
        int shit = 0;
        int one = 0;
        Random rnd = new Random();
        List<string> Questions = new List<string>()
        {
            "請問" + Environment.NewLine +  "今天天氣" + Environment.NewLine + "好嗎?",
            "你今天" + Environment.NewLine + "心情" + Environment.NewLine + "好嗎?",
            "最近" + Environment.NewLine + "伙食" + Environment.NewLine + "好嗎?",
            "目前" + Environment.NewLine + "單身" + Environment.NewLine + "嗎?",
            "最近" + Environment.NewLine + "身體狀況" + Environment.NewLine + "好嗎?",
            "當我" + Environment.NewLine + "朋友" + Environment.NewLine + "好嗎?",
            "最近" + Environment.NewLine + "課業/工作" + Environment.NewLine + "順利嗎?",
            "你" + Environment.NewLine + "喜歡我" + Environment.NewLine + "嗎?",
            "你有時候" + Environment.NewLine + "真的" + Environment.NewLine + "很機掰",
            "枯藤老樹" + Environment.NewLine + "幫我接下去" + Environment.NewLine + "好嗎?"
        };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
            Question.IsEnabled = false;
            YesButton.IsEnabled = false;
            NoButton.IsEnabled = false;
        }

        private void Break_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Question.Text = "";
            ForWhat.Text = "還有" + num + "個";
            if (one == 0)
            {
                ForWhat.Text = "選擇早餐時段";
                Question.Text = "請輸入可能選擇" + Environment.NewLine + "還有" + num + "個";
                one++;
            }
            if (Break.Text == "重置")
            {
                food = new List<string>();
                num = 6;
                Question.Text = "";
                ForWhat.Text = "還有" + num + "個";
            }
            Yes.Text = "輸入";
            No.Text = "開始";
            Lunch.Text = "X";
            Dinner.Text = "X";
            Snack.Text = "X";
            Break.Text = "重置";
            LunchButton.IsEnabled = false;
            DinnerButton.IsEnabled = false;
            SnackButton.IsEnabled = false;
            Question.IsEnabled = true;
            YesButton.IsEnabled = true;
        }

        private void Lunch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Question.Text = "";
            ForWhat.Text = "還有" + num + "個";
            if (one == 0)
            {
                ForWhat.Text = "選擇午餐時段";
                Question.Text = "請輸入可能選擇" + Environment.NewLine + "還有" + num + "個";
                one++;
            }
            if (Lunch.Text == "重置")
            {
                food = new List<string>();
                num = 6;
                Question.Text = "";
                ForWhat.Text = "還有" + num + "個";
            }
             Yes.Text = "輸入";
            No.Text = "開始";
            Break.Text = "X";
            Dinner.Text = "X";
            Snack.Text = "X";
            Lunch.Text = "重置";
            BreakButton.IsEnabled = false;
            DinnerButton.IsEnabled = false;
            SnackButton.IsEnabled = false;
            Question.IsEnabled = true;
            YesButton.IsEnabled = true;
        }

        private void Dinner_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Question.Text = "";
            ForWhat.Text = "還有" + num + "個";
            if (one == 0)
            {
                ForWhat.Text = "選擇晚餐時段";
                Question.Text = "請輸入可能選擇" + Environment.NewLine + "還有" + num + "個";
                one++;
            }
            if (Dinner.Text == "重置")
            {
                food = new List<string>();
                num = 6;
                Question.Text = "";
                ForWhat.Text = "還有" + num + "個";
            }
            Yes.Text = "輸入";
            No.Text = "開始";
            Lunch.Text = "X";
            Break.Text = "X";
            Snack.Text = "X";
            Dinner.Text = "重置";
            LunchButton.IsEnabled = false;
            BreakButton.IsEnabled = false;
            SnackButton.IsEnabled = false;
            Question.IsEnabled = true;
            YesButton.IsEnabled = true;
        }

        private void Snack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Question.Text = "";
            ForWhat.Text = "還有" + num + "個";
            if (one == 0)
            {
                ForWhat.Text = "選擇點心時段";
                Question.Text = "請輸入可能選擇" + Environment.NewLine + "還有" + num + "個";
                one++;
            }
            if (Snack.Text == "重置")
            {
                food = new List<string>();
                num = 6;
                Question.Text = "";
                ForWhat.Text = "還有" + num + "個";
            }
            Yes.Text = "輸入";
            No.Text = "開始";
            Lunch.Text = "X";
            Dinner.Text = "X";
            Break.Text = "X";
            Snack.Text = "重置";
            LunchButton.IsEnabled = false;
            DinnerButton.IsEnabled = false;
            BreakButton.IsEnabled = false;
            Question.IsEnabled = true;
            YesButton.IsEnabled = true;
        }

        private void Yes_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (Yes.Text == "再看")
            {
                if (shit <= 5)
                {
                    MessageBox.Show("就吃" + food[ans] + "吧!","結果", MessageBoxButton.OK);
                    shit++;
                }
                else if (shit > 5)
                {
                    MessageBox.Show("吃屎吧你!","結果", MessageBoxButton.OK, MessageBoxImage.Warning);
                    MessageBox.Show("吃屎吧你!", "結果", MessageBoxButton.OK, MessageBoxImage.Warning);
                    MessageBox.Show("吃屎吧你!", "結果", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else if (Yes.Text == "結果")
            {
                Random answer = new Random();
                ans = answer.Next(0, 6);
                MessageBox.Show("就吃" + food[ans] + "吧!", "結果", MessageBoxButton.OK);
                Yes.Text = "再看";
            }
            else if (num >= 1)
            {
                if (Question.Text == "")
                {
                    MessageBox.Show("請輸入字詞");
                }
                else
                {
                    num--;
                    food.Add(Question.Text);
                    Question.Text = "請輸入可能選擇" + Environment.NewLine + "還有" + num + "個";
                    Question.Text = "";
                    ForWhat.Text = "還有" + num + "個";
                }
            }
            if (num == 0 && Yes.Text != "Yes")
            {
                Question.Text = "輸入完畢";
                YesButton.IsEnabled = false;
                NoButton.IsEnabled = true;
                Question.IsEnabled = false;
                ForWhat.Text = "開始遊戲";
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(10, 10, 460, 240))
            {
                y += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
                box2.Background = Brushes.Blue;
                box5.Background = Brushes.Blue;
                box6.Background = Brushes.Blue;
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(90, 10, 380, 240))
            {
                y += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(170, 10, 300, 240))
            {
                y += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(10, 90, 460, 160))
            {
                y += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
                box3.Background = Brushes.LightBlue;
                box7.Background = Brushes.LightBlue;
                box9.Background = Brushes.LightBlue;
                box10.Background = Brushes.LightBlue;
                box11.Background = Brushes.LightBlue;
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(90, 90, 380, 160))
            {
                y += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
                box3.Background = Brushes.LightBlue;
                box7.Background = Brushes.LightBlue;
                box9.Background = Brushes.LightBlue;
                box10.Background = Brushes.LightBlue;
                box11.Background = Brushes.LightBlue;
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(170, 90, 300, 160))
            {
                y += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(10, 170, 460, 80))
            {
                y += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                Question.Text = "查看結果";
                ForWhat.Text = "調查結束";
                Yes.Text = "結果";
                No.Text = "重來";
                box4.Background = Brushes.White;
                box8.Background = Brushes.White;
                box12.Background = Brushes.White;
                box13.Background = Brushes.White;
                box14.Background = Brushes.White;
                box15.Background = Brushes.White;
                box16.Background = Brushes.White;
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(90, 170, 380, 80))
            {
                y += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                Question.Text = "查看結果";
                ForWhat.Text = "調查結束";
                Yes.Text = "結果";
                No.Text = "重來";
                box4.Background = Brushes.White;
                box8.Background = Brushes.White;
                box12.Background = Brushes.White;
                box13.Background = Brushes.White;
                box14.Background = Brushes.White;
                box15.Background = Brushes.White;
                box16.Background = Brushes.White;
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(170, 170, 300, 80))
            {
                y += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                Question.Text = "查看結果";
                ForWhat.Text = "調查結束";
                Yes.Text = "結果";
                No.Text = "重來";
                box4.Background = Brushes.White;
                box8.Background = Brushes.White;
                box12.Background = Brushes.White;
                box13.Background = Brushes.White;
                box14.Background = Brushes.White;
                box15.Background = Brushes.White;
                box16.Background = Brushes.White;
            }
        }
    
        

        private void No_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(No.Text == "重來")
            {
                if(MessageBox.Show("確定重來?", "重來", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    List<string> food = new List<string>();
                    x = 10;
                    y = 10;
                    num = 6;
                    shit = 0;
                    Random rnd = new Random();
                    Self.Margin = new Thickness(10, 10, 460, 240);
                    Question.IsEnabled = false;
                    YesButton.IsEnabled = false;
                    NoButton.IsEnabled = false;
                    ForWhat.Text = "今天吃什麼";
                    Question.Text = "請選擇餐點時段";
                    Yes.Text = "Yes";
                    No.Text = "No";
                    Lunch.Text = "午餐";
                    Break.Text = "早餐";
                    Snack.Text = "點心";
                    Dinner.Text = "晚餐";
                    LunchButton.IsEnabled = true;
                    BreakButton.IsEnabled = true;
                    SnackButton.IsEnabled = true;
                    DinnerButton.IsEnabled = true;
                    box1.Background = Brushes.White;
                    box2.Background = Brushes.White;
                    box3.Background = Brushes.White;
                    box4.Background = Brushes.White;
                    box5.Background = Brushes.White;
                    box6.Background = Brushes.LightBlue;
                    box7.Background = Brushes.LightBlue;
                    box8.Background = Brushes.LightBlue;
                    box9.Background = Brushes.White;
                    box10.Background = Brushes.LightBlue;
                    box11.Background = Brushes.Blue;
                    box12.Background = Brushes.Blue;
                    box13.Background = Brushes.White;
                    box14.Background = Brushes.LightBlue;
                    box15.Background = Brushes.Blue;
                    box16.Background = Brushes.DarkBlue;
                    List<string> Questions = new List<string>()
                    {
                        "請問" + Environment.NewLine +  "今天天氣" + Environment.NewLine + "好嗎?",
                        "你今天" + Environment.NewLine + "心情" + Environment.NewLine + "好嗎?",
                        "最近" + Environment.NewLine + "伙食" + Environment.NewLine + "好嗎?",
                        "目前" + Environment.NewLine + "單身" + Environment.NewLine + "嗎?",
                        "最近" + Environment.NewLine + "身體狀況" + Environment.NewLine + "好嗎?",
                        "當我" + Environment.NewLine + "朋友" + Environment.NewLine + "好嗎?",
                        "最近" + Environment.NewLine + "課業/工作" + Environment.NewLine + "順利嗎?",
                        "你" + Environment.NewLine + "喜歡我" + Environment.NewLine + "嗎?",
                        "你有時候" + Environment.NewLine + "真的" + Environment.NewLine + "很機掰",
                        "枯藤老樹" + Environment.NewLine + "幫我接下去" + Environment.NewLine + "好嗎?"
                    };

                }
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(10, 10, 460, 240))
            {
                x += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
                box2.Background = Brushes.Blue;
                box5.Background = Brushes.Blue;
                box6.Background = Brushes.Blue;
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(90, 10, 380, 240))
            {
                x += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
                box3.Background = Brushes.LightBlue;
                box7.Background = Brushes.LightBlue;
                box9.Background = Brushes.LightBlue;
                box10.Background = Brushes.LightBlue;
                box11.Background = Brushes.LightBlue;
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(170, 10, 300, 240))
            {
                x += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                Question.Text = "查看結果";
                ForWhat.Text = "調查結束";
                Yes.Text = "結果";
                No.Text = "重來";
                box4.Background = Brushes.White;
                box8.Background = Brushes.White;
                box12.Background = Brushes.White;
                box13.Background = Brushes.White;
                box14.Background = Brushes.White;
                box15.Background = Brushes.White;
                box16.Background = Brushes.White;
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(10, 90, 460, 160))
            {
                x += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(90, 90, 380, 160))
            {
                x += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
                box3.Background = Brushes.LightBlue;
                box7.Background = Brushes.LightBlue;
                box9.Background = Brushes.LightBlue;
                box10.Background = Brushes.LightBlue;
                box11.Background = Brushes.LightBlue;
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(170, 90, 300, 160))
            {
                x += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                Question.Text = "查看結果";
                ForWhat.Text = "調查結束";
                Yes.Text = "結果";
                No.Text = "重來";
                box4.Background = Brushes.White;
                box8.Background = Brushes.White;
                box12.Background = Brushes.White;
                box13.Background = Brushes.White;
                box14.Background = Brushes.White;
                box15.Background = Brushes.White;
                box16.Background = Brushes.White;
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(10, 170, 460, 80))
            {
                x += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(90, 170, 380, 80))
            {
                x += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
            }
            else if (Yes.Text == "Yes" && Self.Margin == new Thickness(170, 170, 300, 80))
            {
                x += 80;
                Self.Margin = new Thickness(x, y, 470 - x, 250 - y);
                Question.Text = "查看結果";
                ForWhat.Text = "調查結束";
                Yes.Text = "結果";
                No.Text = "重來";
                box4.Background = Brushes.White;
                box8.Background = Brushes.White;
                box12.Background = Brushes.White;
                box13.Background = Brushes.White;
                box14.Background = Brushes.White;
                box15.Background = Brushes.White;
                box16.Background = Brushes.White;
            }
            else if (num == 0 && Yes.Text != "Yes")
            {
                YesButton.IsEnabled = true;
                Yes.Text = "Yes";
                No.Text = "No";
                int r = rnd.Next(0, Questions.Count);
                Question.Text = Questions[r];
                Questions.RemoveAt(r);
                Lunch.Text = "X";
                Dinner.Text = "X";
                Break.Text = "X";
                Snack.Text = "X";
                LunchButton.IsEnabled = false;
                DinnerButton.IsEnabled = false;
                BreakButton.IsEnabled = false;
                SnackButton.IsEnabled = false;
                box1.Background = Brushes.DarkBlue;
            }
        }

        private void Question_GotFocus(object sender, RoutedEventArgs e)
        {
            Question.Text = "";
            ForWhat.Text = "還有" + num + "個";
        }
    }
}

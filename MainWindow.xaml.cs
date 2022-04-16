using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PC_Component_Info
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int select_index = 2;
        public int selected_index;

        SystemInfo si = new SystemInfo();

        public MainWindow()
        {
            InitializeComponent();

            DataHandler.create();
            DataHandler.licenses();

            si.getGeneralSystemInfo();
            si.getProcessorInfo();
            si.getRamInfo();
            si.getOthersInfo();

            if (select_index == 1)
            {
                PageFrame_1.Content = new storage();
                //cpu_btn.Background = Brushes.White;
                //ram_btn.Background = Brushes.White;
                storage_btn.Background = Brushes.SkyBlue;
                sys_info_btn.Background = Brushes.White;
                selected_index = 1;
                Vars.page = 0;
            }

            if (select_index == 2)
            {
                PageFrame_1.Content = new sysinfo();
                //cpu_btn.Background = Brushes.White;
                //ram_btn.Background = Brushes.White;
                storage_btn.Background = Brushes.White;
                sys_info_btn.Background = Brushes.SkyBlue;
                selected_index = 2;
                Vars.page = 0;
            }
            page_index_bg();

           

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void storage_btn_Click(object sender, RoutedEventArgs e)
        {
            selected_index = 1;
            page_index_bg();
            Menu_Click();
        }

        private void sys_info_btn_Click(object sender, RoutedEventArgs e)
        {
            selected_index = 2;
            page_index_bg();
            Menu_Click();
        }

        private void File_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //Environment.Exit(0);
        }

        private void help_about_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow hw = new HelpWindow();

            hw.Show();
            Menu_Click();
        }

        private void refresh_speed_Click(object sender, RoutedEventArgs e)
        {

        }

        private void default_card_Click(object sender, RoutedEventArgs e)
        {

        }

        public void page_index_bg()
        {
   
            if (selected_index == 1)
            {
                
                PageFrame_1.Content = new storage();
                //cpu_btn.Background = Brushes.White;
                //ram_btn.Background = Brushes.White;
                storage_btn.Background = Brushes.SkyBlue;
                sys_info_btn.Background = Brushes.White;
                Vars.page = 1;
            }

            if (selected_index == 2)
            {
                PageFrame_1.Content = new sysinfo();
                //cpu_btn.Background = Brushes.White;
                //ram_btn.Background = Brushes.White;
                storage_btn.Background = Brushes.White;
                sys_info_btn.Background = Brushes.SkyBlue;
                Vars.page = 2;
            }
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            Menu_Click();
        }

        public void Menu_Click()
        {
            if (SP_1.ActualWidth > 100)
            {

                BeginStoryboard sb_t50 = this.FindResource("SB_sp_m_t50") as BeginStoryboard;
                sb_t50.Storyboard.Completed += new EventHandler(delegate (object sender1, EventArgs a)
                {
                    //SP_1.Width = 50;
                    storage_btn.Visibility = Visibility.Collapsed;
                    sys_info_btn.Visibility = Visibility.Collapsed;
                    CHB_DM.Visibility = Visibility.Collapsed;
                    HuÜI.Visibility = Visibility.Collapsed;
                    Exit.Visibility = Visibility.Collapsed;
                    PageFrame_1.Opacity = 1;
                });
                sb_t50.Storyboard.Begin();
            }
            else
            {
                BeginStoryboard sb_t200 = this.FindResource("SB_sp_m_t200") as BeginStoryboard;
                sb_t200.Storyboard.Begin();
                //SP_1.Width = 200;
                storage_btn.Visibility = Visibility.Visible;
                sys_info_btn.Visibility = Visibility.Visible;
                CHB_DM.Visibility = Visibility.Visible;
                HuÜI.Visibility= Visibility.Visible; 
                Exit.Visibility = Visibility.Visible;
                PageFrame_1.Opacity = 0.65;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CHB_DM_Checked(object sender, RoutedEventArgs e)
        {
            Vars.page = 0;
            main_sp.Background = new SolidColorBrush(Color.FromRgb(34, 34, 34));
            SP_1.Background = new SolidColorBrush(Color.FromRgb(48, 48, 48));
            Vars.BGC = new SolidColorBrush(Color.FromRgb(34, 34, 34));
            Vars.FGC = Brushes.White;
            test.Foreground = Vars.FGC;
            CHB_DM.Foreground = Vars.FGC;
            pu();
        }

        private void CHB_DM_Unchecked(object sender, RoutedEventArgs e)
        {
            Vars.page = 0;
            main_sp.Background = Brushes.White;
            SP_1.Background = Brushes.DarkGray;
            Vars.BGC = Brushes.White;
            Vars.FGC = Brushes.Black;
            test.Foreground = Vars.FGC;
            CHB_DM.Foreground = Vars.FGC;
            pu();
        }

        private void pu()
        {
            
            if (selected_index == 1)
            {
                PageFrame_1.Content = new storage();
                Vars.page = 1;
            }
            else if (selected_index == 2)
            {
                PageFrame_1.Content = new sysinfo();
                Vars.page = 2;
            }
        }

        private void PageFrame_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SP_1.ActualWidth > 100)
            {

                BeginStoryboard sb_t50 = this.FindResource("SB_sp_m_t50") as BeginStoryboard;
                sb_t50.Storyboard.Completed += new EventHandler(delegate (object sender1, EventArgs a)
                {
                    SP_1.Width = 50;
                    storage_btn.Visibility = Visibility.Collapsed;
                    sys_info_btn.Visibility = Visibility.Collapsed;
                    CHB_DM.Visibility = Visibility.Collapsed;
                    HuÜI.Visibility = Visibility.Collapsed;
                    Exit.Visibility = Visibility.Collapsed;
                    PageFrame_1.Opacity = 1;
                });
                sb_t50.Storyboard.Begin();
            }
        }
        /*public void timer()
{
   int i = 0;

   DispatcherTimer timer = new DispatcherTimer();

   timer.Interval = TimeSpan.FromMilliseconds(1000);

   timer.Tick += new EventHandler(delegate (object s, EventArgs a) {

       SystemInfo si = new SystemInfo();
       PC_Drive_Reader pcdr = new PC_Drive_Reader();

       storage st = new storage(); 

       Console.WriteLine(st.LBL_format_d1.Content + " " + i);

       i += 1;
       st.LBL_format_d1.Content = i.ToString();

       //si.getGeneralSystemInfo();
       //si.getProcessorInfo();
       si.getRamInfo();
       pcdr.Drive_Read();
       Console.WriteLine("test");

       page_index_bg();

       /*statusText.Text = string.Format("Timer Ticked: {0}ms",
         Environment.TickCount);
   });

   timer.Start();
}*/
    }
}

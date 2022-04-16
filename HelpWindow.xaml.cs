using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace PC_Component_Info
{
    /// <summary>
    /// Interaktionslogik für HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public string about = "PLP PC Info ist ein offizielles, lizensiertes, modern \ngestalltetes und leicht zu benutztendes Programm von \nProgrammerLP um zu erfahren, welche Komponenten\nin ihrem PC verbaut sind.";
        public string lizenz = "Dieses Produkt wurde von ProgrammerLP zur Verfügen gestellt \nNutzung nur für privat Anwender erlaubt! Siehe Lizenz Informationen. \n© - 2022 by ProgrammerLP. All rights reserved";
        public string version_text = "Version: 1.1.1.0";

        public HelpWindow()
        {
            InitializeComponent();

            LBL_About_Text.Content = about;
            LBL_Lizenz_Text.Content = lizenz;
            LBL_Version.Content = version_text;
            //LBL_OS_Name.Content = "Betriebsystem: " + sysinfo.OSN + " (" + sysinfo.OSA + ")";
            //LBL_CPU_Name.Content = sysinfo.cpuCores;
        }
        private void Exit_BTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void H_Ud_BTN_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://programmerlp-net.vercel.app");
        }

        private void H_DS_BTN_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://programmerlp-net.vercel.app");
        }

        private void H_LI_BTN_Click(object sender, RoutedEventArgs e)
        {
           cl_win clw = new cl_win();
            clw.Show();
        }

        private void H_HO_RM_BTN_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://programmerlp-net.vercel.app");
        }
    }

}

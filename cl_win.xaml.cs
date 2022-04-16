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
using System.Windows.Shapes;

namespace PC_Component_Info
{
    /// <summary>
    /// Interaktionslogik für cl_win.xaml
    /// </summary>
    public partial class cl_win : Window
    {
        public cl_win()
        {
            InitializeComponent();

            TB_cl.Text = "Neuigkeiten:\n" +
                         "-Changelog für aktuelle Version hinzugefügt\n" +
                         "-Das Menü ist jetzt animiert\n" +
                         "-Sie können nun außerhalb des Menüs klicken, damit  sich das Menü einklappt\n" +
                         "-Copyright Hinweis in Infos & Hilfe hinzugefügt" +
                         "\n\nFixes & Änderungen:\n" +
                         "---";

        }
    }
}

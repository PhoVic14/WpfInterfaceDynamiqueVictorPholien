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

namespace Act4CreationDynamiqueVictorPholien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            prepareInterface();
        }

        public void prepareInterface()
        {
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();
            grdMain.ColumnDefinitions.Add(coldef1);
            grdMain.ColumnDefinitions.Add(coldef2);
            grdMain.ColumnDefinitions.Add(coldef3);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            grdMain.RowDefinitions.Add(rowDef1);
            grdMain.RowDefinitions.Add(rowDef2);
            grdMain.RowDefinitions.Add(rowDef3);

            TextBlock txtbtop = new TextBlock();
            txtbtop.Text = "Textblock créé dynamiquement";
            txtbtop.Foreground = Brushes.Red;
            txtbtop.Background = Brushes.Yellow;
            txtbtop.FontFamily = new FontFamily("Arial Black");
            txtbtop.FontSize = 20;
            txtbtop.Height = 60;

            Grid.SetRow(txtbtop, 0);
            Grid.SetColumn(txtbtop, 0);
            grdMain.Children.Add(txtbtop);
            Grid.SetColumnSpan(txtbtop, 3);

            Button btn1 = new Button();
            Button btn2 = new Button();
            Button btn3 = new Button();

            btn1.Content = "bouton 1";
            btn2.Content = "bouton 2";
            btn3.Content = "bouton 3";


            Thickness myThickness = new Thickness();
            myThickness.Bottom = 20;
            myThickness.Left = 20;
            myThickness.Right = 20;
            myThickness.Top = 20;
            btn1.Margin = myThickness;

            myThickness.Bottom = 20;
            myThickness.Left = 20;
            myThickness.Right = 20;
            myThickness.Top = 20;
            btn2.Margin = myThickness;

            myThickness.Bottom = 20;
            myThickness.Left = 20;
            myThickness.Right = 20;
            myThickness.Top = 20;
            btn3.Margin = myThickness;

            Grid.SetRow(btn1, 1);
            Grid.SetColumn(btn1, 0);
            grdMain.Children.Add(btn1);

            Grid.SetRow(btn2, 1);
            Grid.SetColumn(btn2, 1);
            grdMain.Children.Add(btn2);

            Grid.SetRow(btn3, 1);
            Grid.SetColumn(btn3, 2);
            grdMain.Children.Add(btn3);

            StackPanel stkBloc1 = new StackPanel();
            TextBlock txtbBot = new TextBlock();
            TextBox txtBoxBot = new TextBox();

            txtbBot.Text = "infos :";
            txtbBot.Background = Brushes.Yellow;
            txtbBot.Height = 60;

            txtBoxBot.Text = "Ceci est un texte";

            Grid.SetRow(stkBloc1, 2);
            Grid.SetColumn(stkBloc1, 0);
            stkBloc1.Children.Add(txtbBot);

            Grid.SetRow(txtBoxBot, 2);
            Grid.SetColumn(txtBoxBot, 0);
            stkBloc1.Children.Add(txtBoxBot);

            grdMain.Children.Add(stkBloc1);
            Grid.SetColumnSpan(stkBloc1, 2);

            ComboBox cmb1 = new ComboBox();

            cmb1.Items.Add("1");
            cmb1.Items.Add("2");
            cmb1.Items.Add("3");

            myThickness.Bottom = 20;
            myThickness.Left = 20;
            myThickness.Right = 20;
            myThickness.Top = 20;
            cmb1.Margin = myThickness;

            Grid.SetRow(cmb1, 2);
            Grid.SetColumn(cmb1, 3);
            grdMain.Children.Add(cmb1);
        }
    }
}
   
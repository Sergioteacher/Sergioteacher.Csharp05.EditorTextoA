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


namespace Sergioteacher.Csharp05.EditorTextoA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Acercade_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Un editor");
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Ventana1_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.Key == Key.F1 )
            {
                e.Handled = true;
                MessageBox.Show("Ayuda");
            }
        }

        private void CommandBinding_CanExecute_Open(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_Open(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Open");
        }

        private void CommandBinding_CanExecute_Save(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_Save(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Save");
        }

        private void CommandBinding_CanExecute_New(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_New(object sender, ExecutedRoutedEventArgs e)
        {
            Tedit.Text = "";
        }

        private void CommandBinding_CanExecute_Help(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_Help(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Help");
        }

        private void CommandBinding_CanExecute_GuardarEn(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_GuardarEn(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Guardar en ...");
        }


        private void Tedit_TextChanged(object sender, TextChangedEventArgs e)
        {
            int fila = Tedit.GetLineIndexFromCharacterIndex(Tedit.CaretIndex);
            int columna = Tedit.CaretIndex - Tedit.GetCharacterIndexFromLineIndex(fila);
            Testado.Text = " Fila: " + (fila + 1).ToString() + ", Columna: " + (columna + 1).ToString();
        }

        private void Tedit_KeyUp(object sender, KeyEventArgs e)
        {
            int fila = Tedit.GetLineIndexFromCharacterIndex(Tedit.CaretIndex);
            int columna = Tedit.CaretIndex - Tedit.GetCharacterIndexFromLineIndex(fila);
            Testado.Text = " Fila: " + (fila + 1).ToString() + ", Columna: " + (columna + 1).ToString();
        }

        
    }


    /// <summary>
    /// xmlns:local="clr-namespace:Sergioteacher.Csharp05.EditorTextoA"
    /// xmlns:self="clr-namespace:Sergioteacher.Csharp05.EditorTextoA"
    /// Hay que definir un espacio de nombres 
    /// donde buscará
    /// por defecto WPF crea xmlns:local
    /// sino
    /// lo puedes llamar xmlns:self, por ej.  (sino no lo ha creado)
    /// </summary>
    public static class MisComandos
    {
        public static readonly RoutedUICommand GuardarEn = new RoutedUICommand
            (
                "GuardarEn",
                "GuardarEn",
                typeof(MisComandos),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.F2,ModifierKeys.Alt)
                }
            );
        // Aquí puedes crear nuevos comandos
    }
}

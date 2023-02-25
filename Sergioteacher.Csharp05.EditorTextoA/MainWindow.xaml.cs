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
        private Boolean modificado = false;

        /// <summary>
        /// Función principal.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }


        //  ########################################################################
        /// <summary>
        /// Atrapando el evento Clics desde el Menu -> Acerca de
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Acercade_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Un editor");
        }
        /// <summary>
        /// Atrapando el evento Clics desde el Menu -> Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Ventana1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (modificado)
            {
                MessageBoxResult resultado = MessageBox.Show("Se ha modificado, ¿Guardar?", "Duda...", MessageBoxButton.YesNo);
                switch (resultado)
                {
                    case MessageBoxResult.Yes:
                        MessageBox.Show("Se guardaría y sale", "Guardando...");
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Se sale sólo", "Borrando...");
                        break;
                }
            }
        }


        //  ########################################################################
        /// <summary>
        /// Acepta la captura del evento New
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_CanExecute_New(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        /// <summary>
        /// Implementación específica de la llamada a "Command" desde New
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_Executed_New(object sender, ExecutedRoutedEventArgs e)
        {
            if ( modificado )
            {
                MessageBoxResult resultado = MessageBox.Show("Se ha modificado, ¿Guardar?","Duda...",MessageBoxButton.YesNoCancel);
                switch (resultado)
                {
                    case MessageBoxResult.Yes:
                        MessageBox.Show("Se guardaría", "Guardando...");
                        Tedit.Text = "";
                        modificado = false;
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Pantalla limpia", "Borrando...");
                        Tedit.Text = "";
                        modificado = false;
                        break;
                    case MessageBoxResult.Cancel:
                        MessageBox.Show("Cancelado -> Na de na!", "Sin cambios");
                        break;
                }
            }
            else 
            {
                Tedit.Text = "";
            }
        }

        /// <summary>
        /// Acepta la captura del evento Open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_CanExecute_Open(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        /// <summary>
        /// Implementación específica de la llamada a "Command" desde Open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_Executed_Open(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Open");
        }

        /// <summary>
        /// Acepta la captura del evento Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_CanExecute_Save(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        /// <summary>
        /// Implementación específica de la llamada a "Command" desde Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_Executed_Save(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Save");
        }

        /// <summary>
        /// Acepta la captura del evento GuardarEn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_CanExecute_GuardarEn(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        /// <summary>
        /// Implementación específica de la llamada a "Command" desde GuardarEn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_Executed_GuardarEn(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Guardar en ...");
        }

        /// <summary>
        /// Acepta la captura del evento Print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_CanExecute_Print(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        /// <summary>
        /// Implementación específica de la llamada a "Command" desde Print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_Executed_Print(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Imprimiendo ...");
        }

        /// <summary>
        /// Acepta la captura del evento Help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_CanExecute_Help(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        /// <summary>
        /// Implementación específica de la llamada a "Command" desde Help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBinding_Executed_Help(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Help");
        }
        /*
         * Con en control desde el Command -> Help
         * gracias a "RoutedUICommand"
         * no hace falta capturar "F1"
         * ni implementar un evento Clic para el menu
         * 
        private void Ventana1_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.Key == Key.F1 )
            {
                e.Handled = true;
                MessageBox.Show("Ayuda");
            }
        }
        // en XAML -->  KeyDown="Ventana1_KeyDown"
        */



        


        private void Tedit_TextChanged(object sender, TextChangedEventArgs e)
        {
            int fila = Tedit.GetLineIndexFromCharacterIndex(Tedit.CaretIndex);
            int columna = Tedit.CaretIndex - Tedit.GetCharacterIndexFromLineIndex(fila);
            Testado.Text = " Fila: " + (fila + 1).ToString() + ", Columna: " + (columna + 1).ToString();

            modificado = true;
        }

        private void Tedit_KeyUp(object sender, KeyEventArgs e)
        {
            int fila = Tedit.GetLineIndexFromCharacterIndex(Tedit.CaretIndex);
            int columna = Tedit.CaretIndex - Tedit.GetCharacterIndexFromLineIndex(fila);
            Testado.Text = " Fila: " + (fila + 1).ToString() + ", Columna: " + (columna + 1).ToString();
        }

        
    }


    /*
     * ########################################################################
     * xmlns:local="clr-namespace:Sergioteacher.Csharp05.EditorTextoA"
     * xmlns:self="clr-namespace:Sergioteacher.Csharp05.EditorTextoA"
     * Hay que definir un espacio de nombres 
     * donde buscará
     * por defecto WPF crea xmlns:local
     * sino
     * lo puedes llamar xmlns:self, por ej.  (sino no lo ha creado)
    */

    /// <summary>
    /// Implementación de un "Command" customizado
    /// </summary>
    public static class MisComandos
    {
        /// <summary>
        /// Implementación específica de la llamada a "Command" desde GuardarEn
        /// </summary>
        public static readonly RoutedUICommand GuardarEn = new RoutedUICommand
            (
                "Guardar en otro archivo",
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

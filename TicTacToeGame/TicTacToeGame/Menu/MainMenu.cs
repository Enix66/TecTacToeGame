using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeGame.GameOptions;

//-------------------------------------------------------------------------------------------------Este Formulario nos permite mostrar un menú principal al usuario, que nos permita de manera intuitiva guiar al usuario por las diferentes opciones.
//-------------------------------------------------------------------------------------------------Los colores utilizados en el diseño del menú fueron escogidos de forma que sean complementarios, para que llame la atención los elementos más relevantes o importamtes del diseño.
namespace TicTacToeGame.Menu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonTutorial_Click(object sender, EventArgs e)
        {

        }


        //-----------------------------------------------------------------------------------------Botón Salir (Exit)
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();                                                                 // Nos permite cerrar el programa cuando el usuario seleccione el botón "Exit"
        }//----------------------------------------------------------------------------------------Fin del Evento

        //-----------------------------------------------------------------------------------------Imagen portada Tic Tac Toe
        private void ReferenceImage_Click(object sender, EventArgs e)
        {
            //-------------------------------------------------------------------------------------Inicio de Try - Catch
            try
            {
                System.Diagnostics.Process.Start("https://github.com/Enix66/TecTacToeGame");    // Nos permite hacer referencia a una página web. Inicia un proceso del sistema con una dirección web, lo cuál, se ejecutará en el navgador predeterminado.
            }
            catch   
            { }
        }//----------------------------------------------------------------------------------------Fin del evento

        //-----------------------------------------------------------------------------------------Botón Play
        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            GameOptions.GameOptions GO = new GameOptions.GameOptions();                         // Crea e instancia la variable "GO" de tipo "GameOption", que hace referencia al formulario del mismo nombre.
            GO.Show();                                                                          // Muestra el formulario "GameOption" mediante la variable "GO" y la función "show().
            this.Hide();                                                                        // Esconde el formulario actual mediante la función "Hide()".
        }//----------------------------------------------------------------------------------------Fin del Evento
    }
}

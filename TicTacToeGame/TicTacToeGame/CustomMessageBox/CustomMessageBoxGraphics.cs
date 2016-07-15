using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame.CustomMessageBox
{
    //---------------------------------------------------------------------------------------------Este formulario nos permite mostrar un nuevo "MessageBox"
    public partial class CustomMessageBoxGraphics : Form
    {
        public CustomMessageBoxGraphics()
        {
            InitializeComponent();
            hideObject();                                                                       // Llama al procedimiento "hideObject" 
        }

        #region "Definición de Variable"
        private static int number;                                                              // Define una variable "private static" de tipo "int" llamada "number"
        static CustomMessageBoxGraphics MessageBoxCustom;                                       // Define una variable "static" de tipo "CustomMessageBoxGraphics" con el nombre "MessageBoxCustom"
        static DialogResult Result = DialogResult.No;                                           // Define e inicializa una variable "static" de tipo "DialogResult" con el nombre "Result" y le asigna el valor que devuelve la función "DialogResult.No"
        #endregion

        #region "Evaluación de Datos y Construcción de la Ventana"
        //-----------------------------------------------------------------------------------------Aquí crea una función que contendrá todas las propiedades del "CustomMessageBox"
        public static DialogResult Show(string TextMSG, string Title, string BtnYes, string BtnNo, int num)
        {
            number = num;                                                                       // Le asigna a la variable "number" el valor que tenga la variable "num" que ingresa como parámetro
            MessageBoxCustom = new CustomMessageBoxGraphics();                                  // Construye el nuevo objeto "MessageBoxCustom" de tipo "CustomMessageBoxGraphics"
            MessageBoxCustom.TextMessage.Text = TextMSG;                                        // Aquí definimos el texto o mensaje de la venta que se mostrará, mediante la variable "TextMSG"
            MessageBoxCustom.Text = Title;                                                      // Aquí definimos el titulo de la venta, mediante la variable que entra como parámetro "Title"
            MessageBoxCustom.ButtonYes.Text = BtnYes;                                           // Aquí definimos el Texto del objeto "ButtonYes" mediante la variable que entra como parámetro "BtnYes"
            MessageBoxCustom.ButtonNo.Text = BtnNo;                                             // Aquí definimos el Texto del objeto "ButtonNo" mediante la variable que entra como parámetro "BtnNo"
            MessageBoxCustom.ShowDialog();                                                      // Le asignamos a la variable "MessageBoxCustom" la función "ShowDialog", la cuál, nos permite mostrar la ventana
            return Result;                                                                      // Retorna lo que contenga la variable "Result"
        }//----------------------------------------------------------------------------------------Fin de la Función
        #endregion

        #region "Procedimientos"
        //-----------------------------------------------------------------------------------------Procedimiento que nos permite ocultar el objeto "BottonYes" cuando
        public void hideObject()
        {
            //-------------------------------------------------------------------------------------Condición que evalúa si la variable "number" equivale al valor "2"
            if (number == 2)
            {
                this.ButtonYes.Hide();                                                          // Aquí se le asigna al botón "ButtonYes" la propiedad "Hide", la cuál nos permite esconder el objetp
            }//------------------------------------------------------------------------------------Fin de la Condición
        }//----------------------------------------------------------------------------------------Fin del Procedimiento
        #endregion

        #region "Eventos"
        //-----------------------------------------------------------------------------------------Botón Yes
        private void ButtonYes_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Yes;                                                          // Aquí le asignamos a la variable "Result" lo que devuelva la función "DialogResult.Yes"
            MessageBoxCustom.Close();                                                           // Aquí cerramos la venta una vez precionado el botón, mediante la función "Close"
        }//----------------------------------------------------------------------------------------Fin del Evento

        //-----------------------------------------------------------------------------------------Botón No
        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Result = DialogResult.No;                                                           // Aquí le asignamos a la variable "Result" lo que devuelva la función "DialogResult.No"
            MessageBoxCustom.Close();                                                           // Aquí cerramos la venta una vez precionado el botón, mediante la función "Close"
        }//----------------------------------------------------------------------------------------Fin del Evento
        #endregion
    }
}

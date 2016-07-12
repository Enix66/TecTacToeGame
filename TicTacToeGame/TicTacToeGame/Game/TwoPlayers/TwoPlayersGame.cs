using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TicTacToeGame.PlayersNames.PlayersNamesData;                                              // Se importa el paquete que nos permite utilizar la clase "NamesForPlayersClass" para obtener los datos correspondientes
using TicTacToeGame.Game.GameControl.TwoPlayersGameControl;                                     // Se importa el paquete que nos permite utilizar la clase "TwoPlayersGameClass" el cual, nos permite acceder a los datos lógicos del juego, tales como matrices y variables que almacenan los records del juego

//-------------------------------------------------------------------------------------------------Este formulario nos permite mostrar al usuario la interfaz para que pueda jugar. Este Formulario fue diseñado específicamente para el jugador vs jugador.
namespace TicTacToeGame.Game.TwoPlayers
{
    public partial class TwoPlayersGame : Form
    {
        TwoPlayersGameClass TPGC = new TwoPlayersGameClass();                                   // Crea e instancia la variable "TPGC" del tipo de la clase "TwoPlayersGameClass"

        int TiedGame = 9;                                                                       //Crea e inicializa la variable "TiedGame" en "9". Esta variable contiene el número de jugadas máximas para una partida

        public TwoPlayersGame()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------Procedimiento que nos permite inicializar el turno de jugador, al igual que mostrar el nombre de quien debe jugar actualmente.
        private void Initial()
        {
            //-------------------------------------------------------------------------------------Condicionales que evalúan cuál fue el dato seleccionado por el usuario con respecto al jugador que comenzará a jugar
            if (NamesForPlayersClass.turn == 1)                                                 // Evalúa si el jugador 1 será el que comience a jugar
                PlayerTurn.Text = NamesForPlayersClass.NamePlayer1;                             // Muestra en el objeto "PlayerTurn" el nombre del jugador que comenzará el juego, en este caso, sería el nombre del jugador 1
            else
                if (NamesForPlayersClass.turn == 2)                                             // Muestra en el objeto "PlayerTurn" el nombre del jugador que comenzará el juego, en este caso, sería el nombre del jugador 2
                    PlayerTurn.Text = NamesForPlayersClass.NamePlayer2;                         // Evalúa si el jugador 2 será el que comience a jugar
                else
                    PlayerTurn.Text = "Error";                                                  // Muestra aviso de error en caso de que falle algún dato
            //-------------------------------------------------------------------------------------Fin de Condicionales

            //-------------------------------------------------------------------------------------Aquí se inicializan los objetos "label" con los nombre correspondientes de los jugadores
            Player1WinsTitle.Text = NamesForPlayersClass.NamePlayer1 + " Wins:";                // Muestra el nombre del jugador 1
            Player2WinsTitle.Text = NamesForPlayersClass.NamePlayer2 + " Wins:";                // Muestra el nombre del jugador 2
            //-------------------------------------------------------------------------------------Fin de inicialización de Objetos "label"

            //-------------------------------------------------------------------------------------Aquí se inicializan los diferentes contadores, con los diferentes records
            Player1Wins.Text = Convert.ToString(TwoPlayersGameClass.Pl1Wins);                   // Maneja el conteo de partidas ganadas por el jugador 1
            Player2Wins.Text = Convert.ToString(TwoPlayersGameClass.Pl2Wins);                   // Maneja el conteo de partidas ganadas por el jugador 2
            DrawsGames.Text = Convert.ToString(TwoPlayersGameClass.DrawsGames);                 // Maneja el conteo de partidas empatadas
            //-------------------------------------------------------------------------------------Fin de inicialización de contadores
        }//----------------------------------------------------------------------------------------Fin del procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que nos permite inicializar los objetos principales del juego
        private void ObjectInitializes()
        {
            //-------------------------------------------------------------------------------------Inicializa todos los objetos "Button" que son parte del juego principal
            Pos00.Text = "";                                                                    // Borra el texto impreso en "Pos00"
            Pos01.Text = "";                                                                    // Borra el texto impreso en "Pos01"
            Pos02.Text = "";                                                                    // Borra el texto impreso en "Pos02"

            Pos10.Text = "";                                                                    // Borra el texto impreso en "Pos10"
            Pos11.Text = "";                                                                    // Borra el texto impreso en "Pos11"
            Pos12.Text = "";                                                                    // Borra el texto impreso en "Pos12"

            Pos20.Text = "";                                                                    // Borra el texto impreso en "Pos20"
            Pos21.Text = "";                                                                    // Borra el texto impreso en "Pos21"
            Pos22.Text = "";                                                                    // Borra el texto impreso en "Pos22"
            //-------------------------------------------------------------------------------------Fin de inicializado de objetos "Button"

            Initial();                                                                          //Llama al procedimiento "Initial", el cual, actualizará los datos correspondientes
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que nos permite inicializar el juego cada vez que sea necesario. Recibe como parámetro el número correspondiente al jugador ganador
        private void ProcessCall(int num)
        {
            TiedGame = 9;                                                                       // Inicializa la variable "TiedGame" en 9. Esta variable nos permite determinar si una partida termina en empate
            TPGC.GetScores(num);                                                                // Llama al procedimiento "GetScores" mediante la variable instanciada "TPGC", el cual, se encarga de almacenar los datos o records correspondientes a la partida actual (1 = Gana Jugador 1, 2 = Gana Jugador 2)
            TPGC.NewGame();                                                                     // Llama al procedimiento "NewGame" mediante la variable instanciada "TPGC", esto nos permitirá inicializar variables y matrices en la clase correspondiente
            ObjectInitializes();                                                                // Llama al procedimiento "ObjectIniTializes", el cual, nos permite inicializar los datos impresos o mostrados en los objetos "Button" del TicTacToe
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que evalúa si el juego terminó con algún jugador como ganador
        private void GameEvaluation(Button Pos)
        {
            //-------------------------------------------------------------------------------------Condicional que evalúa si es turno del jugador 1 o del jugador 2
            if (NamesForPlayersClass.turn == 1)
            {
                Pos.Text = "X";                                                                 // En caso de ser jugador 1, imprime el ícono o caracter indicado en el objeto correspondiente. En este caso el símbolo es "X"

                //---------------------------------------------------------------------------------Condicional que evalúa si la jugada es la ganadora para el jugador 1
                if (TPGC.PlayersWin(NamesForPlayersClass.turn))
                {
                    //-----------------------------------------------------------------------------Imprime un mensaje al usuario (Jugador 1), el cual, le notifica que es ganador de la partida
                    MessageBox.Show("Congratulations, Winner: " + NamesForPlayersClass.NamePlayer1, "Player 1 Win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
                    ProcessCall(1);                                                             // Llama al procedimiento "ProcessCall" que realizará los procesos necesarios para inicializar la partida, envía como parametro el dato "1", ya que, el ganador es el jugador 1
                }
                else
                {
                    NamesForPlayersClass.turn = 2;                                              // Asigna a la variable "turn" que se encuentra en la clase "NamesForPlayersClass", el valor "2", ya que, es el turno del jugador 2
                    Initial();                                                                  // Llama al procedimiento "Initial", para que actualice los datos correspondientes
                }//--------------------------------------------------------------------------------Fin de Condicional
            }
            else
            {
                Pos.Text = "O";                                                                 // En caso de ser jugador 2, imprime el ícono o caracter indicado en el objeto correspondiente. En este caso el símbolo es "O"

                //---------------------------------------------------------------------------------Condicional que evalúa si la jugada es la ganadora para el jugador 2
                if (TPGC.PlayersWin(NamesForPlayersClass.turn))
                {
                    //-----------------------------------------------------------------------------Imprime un mensaje al usuario (Jugador 2), el cual, le notifica que es ganador de la partida
                    MessageBox.Show("Congratulations, Winner: " + NamesForPlayersClass.NamePlayer2, "Player 2 Win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ProcessCall(2);                                                             // Llama al procedimiento "ProcessCall" que realizará los procesos necesarios para inicializar la partida, envía como parametro el dato "2", ya que, el ganador es el jugador 2
                }
                else
                {
                    NamesForPlayersClass.turn = 1;                                              // Asigna a la variable "turn" que se encuentra en la clase "NamesForPlayersClass", el valor "1", ya que, es el turno del jugador 1
                    Initial();                                                                  // Llama al procedimiento "Initial", para que actualice los datos correspondientes
                }//--------------------------------------------------------------------------------Fin de Condicional
            }//------------------------------------------------------------------------------------Fin de Condicional
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que evalúa si la partida a terminado como un empate
        private void TiedGameAction(Button Pos)
        {
            //-------------------------------------------------------------------------------------Condicional que muestra o imprime en el objeto "Button" el último símbolo correspondiente al turno o jugador. Esto mediante la evaluación del turno actual
            if (NamesForPlayersClass.turn == 1)
                Pos.Text = "X";                                                                 // Imprime en el objeto "Button" "Pos" el datos o valor "X"           
            else   
                Pos.Text = "O";                                                                 // Imprime en el objeto "Button" "Pos" el datos o valor "O"
            //------------------------------------------------------------------------------------Fin de la Condicional

            //-------------------------------------------------------------------------------------Muestra un mensaje al usuario, el cual, le informa que el juego ha terminado empate
            MessageBox.Show("Tied Game, Play Again", "Tied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            ProcessCall(3);                                                                     // Llama al procedimiento "ProcessCall" que realizará los procesos necesarios para inicializar la partida, envía como parametro el dato "3", ya que, la partida ha terminado empate                                                                
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que almacena en la matriz, cada dato correspondiente a la posición del botón seleccionado
        private void DataDeposit(Button Pos)
        {
            //-------------------------------------------------------------------------------------Condicional que evalúa la Primera Fila de la matriz, almacenando el dato correspondiente
            if (Pos.Name.Equals(Pos00.Name))
                TwoPlayersGameClass.TicTacToeBoard[0, 0] = NamesForPlayersClass.turn;           // Almacena en la posición correspondiente el número de turno almacenado en la variable "turn" que se encuentra en la clase "NamesForPlayersClass"
            else
                if (Pos.Name.Equals(Pos01.Name))
                    TwoPlayersGameClass.TicTacToeBoard[0, 1] = NamesForPlayersClass.turn;       // Almacena en la posición correspondiente el número de turno almacenado en la variable "turn" que se encuentra en la clase "NamesForPlayersClass"
                else
                    if (Pos.Name.Equals(Pos02.Name))
                        TwoPlayersGameClass.TicTacToeBoard[0, 2] = NamesForPlayersClass.turn;   // Almacena en la posición correspondiente el número de turno almacenado en la variable "turn" que se encuentra en la clase "NamesForPlayersClass"
            //-------------------------------------------------------------------------------------Fin de Evaluación de la primera fila

            //-------------------------------------------------------------------------------------Condicional que evalúa la Segunda Fila de la matriz, almacenando el dato correspondiente
            if (Pos.Name.Equals(Pos10.Name))
                TwoPlayersGameClass.TicTacToeBoard[1, 0] = NamesForPlayersClass.turn;           // Almacena en la posición correspondiente el número de turno almacenado en la variable "turn" que se encuentra en la clase "NamesForPlayersClass"
            else
                if (Pos.Name.Equals(Pos11.Name))
                   TwoPlayersGameClass.TicTacToeBoard[1, 1] = NamesForPlayersClass.turn;        // Almacena en la posición correspondiente el número de turno almacenado en la variable "turn" que se encuentra en la clase "NamesForPlayersClass"
                else
                    if (Pos.Name.Equals(Pos12.Name))
                        TwoPlayersGameClass.TicTacToeBoard[1, 2] = NamesForPlayersClass.turn;   // Almacena en la posición correspondiente el número de turno almacenado en la variable "turn" que se encuentra en la clase "NamesForPlayersClass"
            //-------------------------------------------------------------------------------------Fin de Evaluación de la segunda fila

            //-------------------------------------------------------------------------------------Condicional que evalúa la Tercera Fila de la matriz, almacenando el dato correspondiente
            if (Pos.Name.Equals(Pos20.Name))
                TwoPlayersGameClass.TicTacToeBoard[2, 0] = NamesForPlayersClass.turn;           // Almacena en la posición correspondiente el número de turno almacenado en la variable "turn" que se encuentra en la clase "NamesForPlayersClass"
            else
                if (Pos.Name.Equals(Pos21.Name))
                    TwoPlayersGameClass.TicTacToeBoard[2, 1] = NamesForPlayersClass.turn;       // Almacena en la posición correspondiente el número de turno almacenado en la variable "turn" que se encuentra en la clase "NamesForPlayersClass"
                else
                    if (Pos.Name.Equals(Pos22.Name))
                        TwoPlayersGameClass.TicTacToeBoard[2, 2] = NamesForPlayersClass.turn;   // Almacena en la posición correspondiente el número de turno almacenado en la variable "turn" que se encuentra en la clase "NamesForPlayersClass"
            //-------------------------------------------------------------------------------------Fin de Evaluación de la Tercera fila
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Evento que inicializa el formulario
        private void TwoPlayersGame_Load(object sender, EventArgs e)
        {
            Initial();                                                                          // Llama al procedimiento "Initial", que nos permite inicializar el nombre del jugador en el frame

            //-------------------------------------------------------------------------------------Bloqueo de Objetos 
            Player1Wins.ReadOnly = true;                                                        // Permite únicamente la lectura del objeto "Player1Wins"
            Player2Wins.ReadOnly = true;                                                        // Permite únicamente la lectura del objeto "Player2Wins"
            DrawsGames.ReadOnly = true;                                                         // Permite únicamente la lectura del objeto "DrawsGames"
            //-------------------------------------------------------------------------------------Fin del Bloqueo de Objetos
        }//----------------------------------------------------------------------------------------Fin del Evento

        //-----------------------------------------------------------------------------------------Botón Home
        private void HomeButton_Click(object sender, EventArgs e)
        {
            GameOptions.GameOptions GO = new GameOptions.GameOptions();                         // Crea e instancia la variable "GO" de tipo "GameOption", que hace referencia al formulario del mismo nombre.
            GO.Show();                                                                          // Muestra el formulario "GameOption" mediante la variable "GO" y la función "show().
            this.Hide();                                                                        // Esconde el formulario actual mediante la función "Hide()".
        }//----------------------------------------------------------------------------------------Fin del Evento

        //-----------------------------------------------------------------------------------------Evento Correspondiente a los botónes del TicTacToe (Tablero del Juego)
        private void ButtonActionPlayer(object sender, EventArgs e)
        {
            Button Pos = (Button)sender;                                                        // Crea e instancia en la variable "Pos", el objeto responsable de la ejecución del evento. En este caso es un objeto tipo "Button"

            //-------------------------------------------------------------------------------------Condición que verifica que en el objeto "Button" no haya sido presionado previamente
            if (Pos.Text.Equals(""))
            {
                DataDeposit(Pos);                                                               // Llama al procedimiento "DataDeposit" y envia como parametro el objeto "Pos"

                TiedGame -= 1;                                                                  // Reduce en 1 el dato almacenado en "TiedGame", para reducir el número de jugadas disponibles

                //---------------------------------------------------------------------------------Condición que evalúa si el juego queda empate después de realizar el número de jugadas correspondientes (9)
                if ((TiedGame == 0) && (TPGC.PlayersWin(NamesForPlayersClass.turn) == false))
                    TiedGameAction(Pos);                                                        // Llama al procedimiento "TiedGameAction" para que haga los procesos correspondientes a una partida finalizada como empate
                else
                    GameEvaluation(Pos);                                                        // Llama al procedimiento "GameEvaluation" para que haga los procesos correspondientes a una partida en la cual, algún jugador salga victorioso de la misma
                //---------------------------------------------------------------------------------Fin de la Condición
            }//------------------------------------------------------------------------------------Fin de la Condición
        }//----------------------------------------------------------------------------------------Fin del Evento
    }
}

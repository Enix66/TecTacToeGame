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
using TicTacToeGame.Game.GameControl;                                                           // Se importa el paquete que nos permite utilizar la clase "TwoPlayersGameClass" el cual, nos permite acceder a los datos lógicos del juego, tales como matrices y variables que almacenan los records del juego

//-------------------------------------------------------------------------------------------------Este formulario nos permite mostrar al usuario la interfaz para que pueda jugar.
namespace TicTacToeGame.Game.GraphicGameForm
{
    public partial class GameGraphic : Form
    {
        ProcessGameClass PGC = new ProcessGameClass();                                          // Crea e instancia la variable "PGC" del tipo de la clase "ProcessGameClass"

        public GameGraphic()
        {
            InitializeComponent();
        }

        #region "Procedimientos"
        //-----------------------------------------------------------------------------------------Región donde se manejan todos los datos relacionados con la parte gráfica o de interfaz
        #region "Manejo de Procesos Gráficos"
        //-----------------------------------------------------------------------------------------Este procedimiento nos permite actualizar el turno actual del jugador, es decir, imprime el nombre del jugador según el turno actual
        public void rotateNames()
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
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que nos permite inicializar el turno de jugador, al igual que mostrar el nombre de quien debe jugar actualmente.
        private void Initial()
        {

            rotateNames();                                                                      // Llama al Procedimiento "rotateNames", para actualizar el nombre del turno actual

            //-------------------------------------------------------------------------------------Aquí se inicializan los objetos "label" con los nombre correspondientes de los jugadores
            Player1WinsTitle.Text = NamesForPlayersClass.NamePlayer1 + " Wins:";                // Muestra el nombre del jugador 1
            Player2WinsTitle.Text = NamesForPlayersClass.NamePlayer2 + " Wins:";                // Muestra el nombre del jugador 2
            //-------------------------------------------------------------------------------------Fin de inicialización de Objetos "label"

            //-------------------------------------------------------------------------------------Aquí se inicializan los diferentes contadores, con los diferentes records
            Player1Wins.Text = Convert.ToString(ProcessGameClass.Pl1Wins);                      // Maneja el conteo de partidas ganadas por el jugador 1
            Player2Wins.Text = Convert.ToString(ProcessGameClass.Pl2Wins);                      // Maneja el conteo de partidas ganadas por el jugador 2
            DrawsGames.Text = Convert.ToString(ProcessGameClass.DrawsGames);                    // Maneja el conteo de partidas empatadas
            //-------------------------------------------------------------------------------------Fin de inicialización de contadores
        }//----------------------------------------------------------------------------------------Fin del procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que nos permite inicializar los objetos principales del juego
        private void ObjectInitializes()
        {
            //-------------------------------------------------------------------------------------Inicializa todos los objetos "Button" que son parte del juego principal
            Pos00.ResetText();                                                                  // Reinicia el texto impreso en "Pos00"
            Pos01.ResetText();                                                                  // Reinicia el texto impreso en "Pos01"
            Pos02.ResetText();                                                                  // Reinicia el texto impreso en "Pos02"

            Pos10.ResetText();                                                                  // Reinicia el texto impreso en "Pos10"
            Pos11.ResetText();                                                                  // Reinicia el texto impreso en "Pos11"
            Pos12.ResetText();                                                                  // Reinicia el texto impreso en "Pos12"

            Pos20.ResetText();                                                                  // Reinicia el texto impreso en "Pos20"
            Pos21.ResetText();                                                                  // Reinicia el texto impreso en "Pos21"
            Pos22.ResetText();                                                                  // Reinicia el texto impreso en "Pos22"
            //-------------------------------------------------------------------------------------Fin de inicializado de objetos "Button"

            Initial();                                                                          // Llama al procedimiento "Initial", el cual, actualizará los datos correspondientes
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que nos permite recargar los iconos del tablero cada vez que sea necesario, mediante los datos almacenados en la martriz "TicTacToeBoard"
        private void IconsRecharge()
        {
            PGC.iconObtain(0, 0, Pos00);                                                        // Retorna el icono correspondiente a la posición "0","0" según el dato almacenado en la matriz
            PGC.iconObtain(0, 1, Pos01);                                                        // Retorna el icono correspondiente a la posición "0","1" según el dato almacenado en la matriz
            PGC.iconObtain(0, 2, Pos02);                                                        // Retorna el icono correspondiente a la posición "0","2" según el dato almacenado en la matriz

            PGC.iconObtain(1, 0, Pos10);                                                        // Retorna el icono correspondiente a la posición "1","0" según el dato almacenado en la matriz
            PGC.iconObtain(1, 1, Pos11);                                                        // Retorna el icono correspondiente a la posición "1","1" según el dato almacenado en la matriz
            PGC.iconObtain(1, 2, Pos12);                                                        // Retorna el icono correspondiente a la posición "1","2" según el dato almacenado en la matriz

            PGC.iconObtain(2, 0, Pos20);                                                        // Retorna el icono correspondiente a la posición "2","0" según el dato almacenado en la matriz
            PGC.iconObtain(2, 1, Pos21);                                                        // Retorna el icono correspondiente a la posición "2","1" según el dato almacenado en la matriz
            PGC.iconObtain(2, 2, Pos22);                                                        // Retorna el icono correspondiente a la posición "2","2" según el dato almacenado en la matriz
        }//----------------------------------------------------------------------------------------Fin del Procedimiento
        #endregion
        //-----------------------------------------------------------------------------------------Fin de la Región

        //-----------------------------------------------------------------------------------------En esta región se procesan datos correspondientes al juego, es decir, aquí se almacenan datos y se procesa el inicio de una nueva partida
        #region "Funcionalidad del Juego"
        //-----------------------------------------------------------------------------------------Procedimiento que nos permite inicializar el juego cada vez que sea necesario. Recibe como parámetro el número correspondiente al jugador ganador, además se encarga de hacer que la Computadora juegue primero en caso de haber sido la selección del ususario
        private void ProcessCall(int num)
        {
            PGC.GetScores(num);                                                                 // Llama al procedimiento "GetScores" mediante la variable instanciada "PGC", el cual, se encarga de almacenar los datos o records correspondientes a la partida actual (1 = Gana Jugador 1, 2 = Gana Jugador 2)
            PGC.NewGame();                                                                      // Llama al procedimiento "NewGame" mediante la variable instanciada "PGC", esto nos permitirá inicializar variables y matrices en la clase correspondiente
            ObjectInitializes();                                                                // Llama al procedimiento "ObjectIniTializes", el cual, nos permite inicializar los datos impresos o mostrados en los objetos "Button" del TicTacToe

            //-------------------------------------------------------------------------------------Condición que evalúa si el usuario seleccionó el modo de juego "One Player" y también eligió que la Computadora comenzara la partida
            if ((ProcessGameClass.InitialTurn == 2) && (ProcessGameClass.PlayerVS == 1))
            {
                PGC.ComputerPlay();                                                             // Llama al Procedimiento "ComputerPlay" desde la variable instanciada "PGC", esto le indica al algoritmo "minimax" que realice una jugada
                IconsRecharge();                                                                // Recarga los iconos correspondientes según los valores almacenado en la matriz "TicTacToeBoard", mediante el procedimiento "IconsRecharge"
            }//------------------------------------------------------------------------------------Fin de la Condición
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que almacena en la matriz, cada dato correspondiente a la posición del botón seleccionado
        private void DataDeposit(Button Pos)
        {
            //-------------------------------------------------------------------------------------Condicionales que evalúan la Primera Fila de la matriz, almacenando el dato correspondiente
            if (Pos.Name.Equals(Pos00.Name))
                PGC.insertData(0, 0);                                                            // Llama al procedimiento "insertData", desde la variable instanciada "PGC", esto con el fin de ingresar el dato en la matriz correspondiente y en la posición que envia como parametro (x,y)
            else
                if (Pos.Name.Equals(Pos01.Name))
                PGC.insertData(0, 1);                                                        // Llama al procedimiento "insertData", desde la variable instanciada "PGC", esto con el fin de ingresar el dato en la matriz correspondiente y en la posición que envia como parametro (x,y)
            else
                    if (Pos.Name.Equals(Pos02.Name))
                PGC.insertData(0, 2);                                                    // Llama al procedimiento "insertData", desde la variable instanciada "PGC", esto con el fin de ingresar el dato en la matriz correspondiente y en la posición que envia como parametro (x,y)
            //-------------------------------------------------------------------------------------Fin de Evaluación de la primera fila

            //-------------------------------------------------------------------------------------Condicionales que evalúan la Segunda Fila de la matriz, almacenando el dato correspondiente
            if (Pos.Name.Equals(Pos10.Name))
                PGC.insertData(1, 0);                                                            // Llama al procedimiento "insertData", desde la variable instanciada "PGC", esto con el fin de ingresar el dato en la matriz correspondiente y en la posición que envia como parametro (x,y)
            else
                if (Pos.Name.Equals(Pos11.Name))
                PGC.insertData(1, 1);                                                        // Llama al procedimiento "insertData", desde la variable instanciada "PGC", esto con el fin de ingresar el dato en la matriz correspondiente y en la posición que envia como parametro (x,y)
            else
                    if (Pos.Name.Equals(Pos12.Name))
                PGC.insertData(1, 2);                                                    // Llama al procedimiento "insertData", desde la variable instanciada "PGC", esto con el fin de ingresar el dato en la matriz correspondiente y en la posición que envia como parametro (x,y)
            //-------------------------------------------------------------------------------------Fin de Evaluación de la segunda fila

            //-------------------------------------------------------------------------------------Condicionales que evalúan la Tercera Fila de la matriz, almacenando el dato correspondiente
            if (Pos.Name.Equals(Pos20.Name))
                PGC.insertData(2, 0);                                                            // Llama al procedimiento "insertData", desde la variable instanciada "PGC", esto con el fin de ingresar el dato en la matriz correspondiente y en la posición que envia como parametro (x,y)
            else
                if (Pos.Name.Equals(Pos21.Name))
                PGC.insertData(2, 1);                                                        // Llama al procedimiento "insertData", desde la variable instanciada "PGC", esto con el fin de ingresar el dato en la matriz correspondiente y en la posición que envia como parametro (x,y)
            else
                    if (Pos.Name.Equals(Pos22.Name))
                PGC.insertData(2, 2);                                                    // Llama al procedimiento "insertData", desde la variable instanciada "PGC", esto con el fin de ingresar el dato en la matriz correspondiente y en la posición que envia como parametro (x,y)
            //-------------------------------------------------------------------------------------Fin de Evaluación de la Tercera fila
        }//----------------------------------------------------------------------------------------Fin del Procedimiento
        #endregion
        //-----------------------------------------------------------------------------------------Fin de la Región

        //-----------------------------------------------------------------------------------------Aquí se evalúan los datos para dar una respuesta concreta al usuario; se determinan ganadores, cambios de turno, entre otros procesos críticos del juego
        #region "Evaluación de Datos"
        //-----------------------------------------------------------------------------------------Procedimiento que evalúa si el juego terminó con algún jugador como ganador
        private void GameEvaluation(Button Pos)
        {
            IconsRecharge();                                                                    // Recarga los iconos correspondientes según los valores almacenado en la matriz "TicTacToeBoard", mediante el procedimiento "IconsRecharge"

            //-------------------------------------------------------------------------------------Switch que evalúa si el ganador es el jugador 1 o el jugador 2, en caso de no existir ganador, mueve el turno al siguiente jugador
            switch (Convert.ToUInt16(PGC.PlayersWin(NamesForPlayersClass.turn)))
            {
                //---------------------------------------------------------------------------------Caso 1, significa si el ganador es el "jugador 1"
                case 1:
                    {
                        //-------------------------------------------------------------------------Imprime un mensaje al usuario (Jugador 1), el cual, le notifica que es ganador de la partida
                        MessageBox.Show("Congratulations, Winner: " + NamesForPlayersClass.NamePlayer1, "Player 1 Win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ProcessCall(1);                                                         // Llama al procedimiento "ProcessCall" que realizará los procesos necesarios para inicializar la partida, envía como parametro el dato "1", ya que, el ganador es el jugador 1
                    }break;                                                                     // La función "break", indica que ahí se sale del switch
                //---------------------------------------------------------------------------------Fin del Caso

                //---------------------------------------------------------------------------------Caso 1, significa si el ganador es el "jugador 2"
                case 2:
                    {
                        //-------------------------------------------------------------------------Imprime un mensaje al usuario (Jugador 2), el cual, le notifica que es ganador de la partida
                        MessageBox.Show("Congratulations, Winner: " + NamesForPlayersClass.NamePlayer2, "Player 2 Win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ProcessCall(2);                                                         // Llama al procedimiento "ProcessCall" que realizará los procesos necesarios para inicializar la partida, envía como parametro el dato "2", ya que, el ganador es el jugador 2
                    }break;                                                                     // La función "break", indica que ahí se sale del switch
                //---------------------------------------------------------------------------------Fin del Caso

                //---------------------------------------------------------------------------------El "default" se realiza en el momento que no se ejecuta ningun caso anterior, es decir, si ningún jugador ha ganado
                default:
                    {
                        //-------------------------------------------------------------------------Condición  que evalua el turno actual del jugador, con el proposito de cambiar el turno al siguiente jugador
                        if (NamesForPlayersClass.turn == 1)
                            NamesForPlayersClass.turn = 2;                                      // Asigna a la variable "turn" que se encuentra en la clase "NamesForPlayersClass", el valor "2", ya que, es el turno del jugador 2
                        else
                            NamesForPlayersClass.turn = 1;                                      // Asigna a la variable "turn" que se encuentra en la clase "NamesForPlayersClass", el valor "1", ya que, es el turno del jugador 1
                    }break;                                                                     // La función "break", indica que ahí se sale del switch
            }
            rotateNames();                                                                      // Llama al Procedimiento "rotateNames", para actualizar el nombre del turno actual
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que evalúa si la partida a terminado como un empate
        private void TiedGameAction(Button Pos)
        {
            //-------------------------------------------------------------------------------------Condicional que muestra o imprime en el objeto "Button" el último símbolo correspondiente al turno o jugador. Esto mediante la evaluación del turno actual
            if (NamesForPlayersClass.turn == 1)
            {
                Pos.ForeColor = Color.DodgerBlue;                                               // Al objeto "Pos", se le cambia la propiedad del color de caracter mediante la función "ForeColor" y se le asigna el color "DodgerBlue"
                Pos.Text = "X";                                                                 // Imprime en el objeto "Button" "Pos" el datos o valor "X"
            }
            else
            {
                Pos.ForeColor = Color.OrangeRed;                                                // Al objeto "Pos", se le cambia la propiedad del color de caracter mediante la función "ForeColor" y se le asigna el color "OrangeRed"
                Pos.Text = "O";                                                                 // Imprime en el objeto "Button" "Pos" el datos o valor "O"
            }//------------------------------------------------------------------------------------Fin de la Condición

            //-------------------------------------------------------------------------------------Muestra un mensaje al usuario, el cual, le informa que el juego ha terminado empate
            MessageBox.Show("Tied Game, Play Again", "Tied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            ProcessCall(3);                                                                     // Llama al procedimiento "ProcessCall" que realizará los procesos necesarios para inicializar la partida, envía como parametro el dato "3", ya que, la partida ha terminado empate                                                                
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que realiza todos los procesos correspondiente para determinar un ganador en el modo "One Player"
        public void GamePlayerVSComputer(Button Pos)
        {
            //-------------------------------------------------------------------------------------Condicional que evalúa si la jugada es la ganadora para el jugador 1
            if (PGC.PlayersWin(1) == 1)
            {
                //---------------------------------------------------------------------------------Imprime un mensaje al usuario (Jugador 1), el cual, le notifica que es ganador de la partida
                MessageBox.Show("Congratulations, Winner: " + NamesForPlayersClass.NamePlayer1, "Player 1 Win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ProcessCall(1);                                                                 // Llama al procedimiento "ProcessCall" que realizará los procesos necesarios para inicializar la partida, envía como parametro el dato "1", ya que, el ganador es el jugador 1
            }//------------------------------------------------------------------------------------Fin de Condicional
            else
            {
                PGC.ComputerPlay();                                                             // Llama al Procedimiento "ComputerPlay" desde la variable instanciada "PGC", esto le indica al algoritmo "minimax" que realice una jugada
                IconsRecharge();                                                                // Recarga los iconos correspondientes según los valores almacenado en la matriz "TicTacToeBoard", mediante el procedimiento "IconsRecharge"

                //---------------------------------------------------------------------------------Condicional que evalúa si la jugada es la ganadora para el jugador 2
                if (PGC.PlayersWin(2) == 2)
                {
                    //-----------------------------------------------------------------------------Imprime un mensaje al usuario (Jugador 2), el cual, le notifica que es ganador de la partida
                    MessageBox.Show("Congratulations, Winner: " + NamesForPlayersClass.NamePlayer2, "Player 2 Win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ProcessCall(2);                                                             // Llama al procedimiento "ProcessCall" que realizará los procesos necesarios para inicializar la partida, envía como parametro el dato "2", ya que, el ganador es el jugador 2
                }
                else
                {
                    //-----------------------------------------------------------------------------Condición que vealúa si el juego ha terminado empate
                    if ((PGC.CompleteBoard() == true))
                    {
                        TiedGameAction(Pos);                                                    // Llama al procedimiento "TiedGameAction" para que haga los procesos correspondientes a una partida finalizada como empate
                        ProcessCall(0);                                                         // Llama al procedimiento "ProcessCall" enviándole como parámetro el número "0", el cuál se encarga de realizar los procesos correspondientes para que la computadora haga la primera jugada. Se envía el "0" como parámetro con el fin de realizar únicamente la primera jugada de la computadora
                    }//----------------------------------------------------------------------------Fin de la condición
                }//--------------------------------------------------------------------------------Fin de la condición
            }//------------------------------------------------------------------------------------Fin de la condición
        }//----------------------------------------------------------------------------------------Fin del Procedimiento
        #endregion
        //-----------------------------------------------------------------------------------------Fin de la Región
        #endregion

        #region  "Eventos"
        //-----------------------------------------------------------------------------------------Evento que inicializa el formulario
        private void Game_Load(object sender, EventArgs e)
        {
            Initial();                                                                          // Llama al procedimiento "Initial", que nos permite inicializar el nombre del jugador en el frame

            //-------------------------------------------------------------------------------------Bloqueo de Objetos 
            PlayerTurn.ReadOnly = true;                                                         // Permite únicamente la lectura del objeto "PlayerTurn"
            Player1Wins.ReadOnly = true;                                                        // Permite únicamente la lectura del objeto "Player1Wins"
            Player2Wins.ReadOnly = true;                                                        // Permite únicamente la lectura del objeto "Player2Wins"
            DrawsGames.ReadOnly = true;                                                         // Permite únicamente la lectura del objeto "DrawsGames"
            //-------------------------------------------------------------------------------------Fin del Bloqueo de Objetos

            //-------------------------------------------------------------------------------------Condición que evalúa si el usuario seleccionó el modo de juego "One Player" y también eligió que la Computadora comenzara la partida
            if ((ProcessGameClass.PlayerVS == 1) && (ProcessGameClass.InitialTurn == 2))
            {
                ProcessCall(0);                                                                 // Llama al procedimiento "ProcessCall" enviándole como parámetro el número "0", el cuál se encarga de realizar los procesos correspondientes para que la computadora haga la primera jugada. Se envía el "0" como parámetro con el fin de realizar únicamente la primera jugada de la computadora
                NamesForPlayersClass.turn = 1;                                                  // Inicializa la variable "" de la clase "" en "", ya que, el turno siempre debe ser 1, pues, la jugada de la computadora se realiza de forma automática y de inmediato
            }//------------------------------------------------------------------------------------Fin de la Condición
        }//----------------------------------------------------------------------------------------Fin del Evento
        
        //-----------------------------------------------------------------------------------------Botón Home
        private void HomeButton_Click(object sender, EventArgs e)
        {
            PGC.NewGame();                                                                      // Llama al procedimiento "NewGame" mediante la variable instanciada "PGC", esto nos permitirá inicializar variables y matrices en la clase correspondiente
            ObjectInitializes();                                                                // Llama al procedimiento "ObjectIniTializes", el cual, nos permite inicializar los datos impresos o mostrados en los objetos "Button" del TicTacToe
            PGC.restoreVar();                                                                   // Llama al procedimiento "restoreVar" mediante la variable instanciada "PGC", esto nos permitirá inicializar los contadores correspondientes

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
                //---------------------------------------------------------------------------------Condición que evalúa cual fue el modo de juego que seleccionó el usuario (1= One Player, 2= Two Players)
                if (ProcessGameClass.PlayerVS == 1)
                {
                    #region "PC VS Player"                   

                    DataDeposit(Pos);                                                           // Llama al procedimiento "DataDeposit" y envia como parámetro el objeto "Pos"

                    //-----------------------------------------------------------------------------Condición que evalúa si el juego queda empate después de realizar el número de jugadas correspondientes (9)
                    if ((PGC.CompleteBoard() == true) && (PGC.PlayersWin(NamesForPlayersClass.turn) == 0))
                        TiedGameAction(Pos);                                                    // Llama al procedimiento "TiedGameAction" para que haga los procesos correspondientes a una partida finalizada como empate
                    else
                        GamePlayerVSComputer(Pos);                                              // Llama al procedimiento "GamePlayerVSComputer" para que haga los procesos correspondientes a una partida en la cual, algún jugador salga victorioso de la misma

                    #endregion
                }
                else
                {
                    #region "Player vs Player"
                    
                    //-----------------------------------------------------------------------------Condición que evalúa cual fue el modo de juego que seleccionó el usuario (1= One Player, 2= Two Players)
                    if (ProcessGameClass.PlayerVS == 2)
                    {
                        DataDeposit(Pos);                                                       // Llama al procedimiento "DataDeposit" y envia como parámetro el objeto "Pos

                        //-------------------------------------------------------------------------Condición que evalúa si el juego queda empate después de realizar el número de jugadas correspondientes (9)
                        if ((PGC.CompleteBoard() == true) && (PGC.PlayersWin(NamesForPlayersClass.turn) == 0))
                            TiedGameAction(Pos);                                                // Llama al procedimiento "TiedGameAction" para que haga los procesos correspondientes a una partida finalizada como empate
                        else
                            GameEvaluation(Pos);                                                // Llama al procedimiento "GameEvaluation" para que haga los procesos correspondientes a una partida en la cual, algún jugador salga victorioso de la misma
                        //-------------------------------------------------------------------------Fin de la Condición
                    }//----------------------------------------------------------------------------Fin de la Condición

                    #endregion
                }//--------------------------------------------------------------------------------Fin de la Condición

            }//------------------------------------------------------------------------------------Fin de la Condición
        }//----------------------------------------------------------------------------------------Fin del Evento
        #endregion
    }
}

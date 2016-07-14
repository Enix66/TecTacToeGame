using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------------------------------------------------------Se exportan estos paquetes con el fin de manipular objetos correspondientes a ls formularios
using System.Drawing;                                                                           // Nos permite utilizar la función "Color"
using System.Windows.Forms;                                                                     // En este caso nos permite utilizar los objetos "Button", para manipularlos
using TicTacToeGame.PlayersNames.PlayersNamesData;                                              // Se importa el paquete que nos permite utilizar la clase "PlayersNamesData" el cual, nos permite acceder a ciertos datos del juego, por ejemplo, el nombre de ambos jugadores y el turno inicial del jugador
//-------------------------------------------------------------------------------------------------Fin de exportado de paquetes

//-------------------------------------------------------------------------------------------------Esta clase nos permite manejar datos lógiucos y gráficos de la aplicación o juego
namespace TicTacToeGame.Game.GameControl
{
    class ProcessGameClass
    {
        //-----------------------------------------------------------------------------------------En esta se Definen la variables "public static", para que se puedan utilizar en todo el programa
        #region "Variables publicas de la Clase"

        public static double[,] TicTacToeBoard = new double[3, 3];                              // Aquí se define una matriz tipo "int" mediante la variable "TicTacToeBoard" de tamaño 3x3

        public static double InitialTurn;                                                       // Aquí se define la variable "IOnitialTurn" de tipo "double", el cual, almacenará de forma permanente (no dinámica) el primer turno que seleccionó el usuario

        public static double Pl1Wins, Pl2Wins, DrawsGames;                                      // Aqui se definen 3 variables de tipo "double": "Pl1Wins", "Pl2Wins" y "DrawsGames"

        public static double PlayerVS;
        #endregion
        //-----------------------------------------------------------------------------------------Fin de la región

        //-----------------------------------------------------------------------------------------En esta región están los procedimientos encargados de inicializar el juego o la partida
        #region "Inicializar Juego"
        //-----------------------------------------------------------------------------------------Procedimiento que nos permite inicializar las variables con los records correspondientes
        public void restoreVar()
        {
            Pl1Wins = 0;                                                                        // Asigna a la variavle "Pl1Wins" el valor o dato "0"
            Pl2Wins = 0;                                                                        // Asigna a la variavle "Pl2Wins" el valor o dato "0"
            DrawsGames = 0;                                                                     // Asigna a la variavle "DrawsGames" el valor o dato "0"
        }//---------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que inicializa los datos lógicos del juego para poder jugar una nueva partida
        public void NewGame()
        {
            //-------------------------------------------------------------------------------------Ciclo que recorre todas las filas de la matriz para inicializarlas
            for (int Row = 0; Row < 3; Row++)
            {
                //---------------------------------------------------------------------------------Ciclo que recorre todas las columnas de la matriz para inicializarlas
                for (int Col = 0; Col < 3; Col++)
                {
                    TicTacToeBoard[Row, Col] = 0;                                                // A cada campo de la matriz le asigna el valor o dato "0"
                }//--------------------------------------------------------------------------------Fin del Ciclo for
            }//------------------------------------------------------------------------------------Fin del Ciclo for

            //-------------------------------------------------------------------------------------Condición que evalúa si el modo de juego en "Player versus Computer" y si el turno que el usuario seleccionó para que jugará primero sea la computadora. En caso de no cumplirse las anteriores condiciones realiza el proceso
            if((ProcessGameClass.InitialTurn != 2) && (PlayerVS != 1))
                NamesForPlayersClass.turn = InitialTurn;                                        // Le asigna a la variable "turn" ubicada en la clase "NamesForPlayersClass", el valor que primer jugador que seleccionó el usuario
        }//----------------------------------------------------------------------------------------Fin del Procedimiento
        #endregion
        //-----------------------------------------------------------------------------------------Fin de la región

        //-----------------------------------------------------------------------------------------En esta región se obtienen o insertan los datos correspondientes
        #region "Obtención de Datos"
        //-----------------------------------------------------------------------------------------Este procedimiento aumenta los diferentes contadores con los records, para que sea posible mostrar los diferentes datos al usuario. Recibe como parámetro el datos que aumentará (1= Gana Jugador 1, 2= Gana Jugador 2, 3= Juego Empate)
        public void GetScores(int num)
        {
            //-------------------------------------------------------------------------------------Condicionales que evalúan cada caso para realizar el aumento correspondiente
            if (num == 1)                                                                       // Condición que evalúa si el parámetro recibido es "1", de ser así, el jugador 1 ganó la partida y se aumentará la variable correspondiente a este jugador
                Pl1Wins += 1;                                                                   // Aumenta en 1 la variable "Pl1Wins"
            else
                if (num == 2)                                                                   // Condición que evalúa si el parámetro recibido es "2", de ser así, el jugador 2 ganó la partida y se aumentará la variable correspondiente a este jugador
                    Pl2Wins += 1;                                                               // Aumenta en 1 la variable "Pl2Wins"
                else //----------------------------------------------------------------------------Ingresa en este caso cuando la partida ha terminado empate, recibe como parámetro el número 3
                    DrawsGames += 1;                                                            // Aumenta en 1 la variable "DrawsGames"
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que nos permite ingresar la jugada en la matriz como dato (1= jugador 1, 2= jugador 2)
        public void insertData(int x, int y)
        {
            TicTacToeBoard[x, y] = NamesForPlayersClass.turn;                                   // Almacena en la posición correspondiente el número de turno almacenado en la variable "turn" que se encuentra en la clase "NamesForPlayersClass"
        }//----------------------------------------------------------------------------------------Fin del Procedimiento

        //-----------------------------------------------------------------------------------------Procedimiento que nos permite almacenar que opción seleccionó el usuario con respecto al modo de juego (Player versus Player ó Player versus Computer), recibe como parametro el número correspondiente (1= Pl vs Pl, 2= Pl vs PC)
        public void PlayerVersusOption(double num)
        {
            PlayerVS = num;                                                                     // Almacena en la variable "double" "PlayerVS" el dato almacenado en la variable "num" de tipo "double"
        }//----------------------------------------------------------------------------------------Fin del Procedimiento
        #endregion
        //-----------------------------------------------------------------------------------------Fin de la Región

        //-----------------------------------------------------------------------------------------En esta Región se analizan los datos para imprimir o mostrar los caracteres correspondientes
        #region "Datos Gráficos e Iconos"
        //-----------------------------------------------------------------------------------------Procedimiento que nos ayuda a imprimir el icono con el color correspondiente de cada jugador
        public void iconObtain(int Row, int Col, Button Pos)
        {
            //-------------------------------------------------------------------------------------Condición que evalúa si en la posición de la matriz evaluada, hay una jugada del jugador 1, en caso de ser asi, selecciona el color correspondiente al icono e imprime el icono o caracter correspondiente "X"
            if (TicTacToeBoard[Row, Col] == 1)
            {
                Pos.ForeColor = Color.DodgerBlue;                                               // Cambia el Color del caracter a mostrar, mediante la función "ForeColor" y la función "Color". Se elige el Color "DodgerBlue"
                Pos.Text = "X";                                                                 // Imprime el icono correspondiente al jugador 1 "X"
            }
            else
            {
                //---------------------------------------------------------------------------------Condición que evalúa si en la posición de la matriz evaluada, hay una jugada del jugador 2 (o computer), en caso de ser así, selecciona el color correspondiente al icono e imprime el icono o caracter correspondiente "O"
                if (TicTacToeBoard[Row, Col] == 2)
                {
                    Pos.ForeColor = Color.OrangeRed;                                            // Cambia el Color del caracter a mostrar, mediante la función "ForeColor" y la función "Color". Se elige el Color "OrangeRed"
                    Pos.Text = "O";                                                             // Imprime el icono correspondiente al jugador 2 (o Computadora) "O"
                }
            }//------------------------------------------------------------------------------------Fin de la condición
        }//----------------------------------------------------------------------------------------Fin del Procedimiento
        #endregion
        //-----------------------------------------------------------------------------------------Fin de la Región

        //-----------------------------------------------------------------------------------------En esta región se evalúan datos correspondientes con el fin de obtener una respuesta
        #region "Evaluación de Datos"
        //-----------------------------------------------------------------------------------------Función encargado de buscar si existe un ganador, recibe como parámetro el posible jugador que puede ganar, devuelve el mismo número en caso de cumplirse como ganador
        public double PlayersWin(double num)
        {
            //-------------------------------------------------------------------------------------En esta Región se evalúan las filas y las columnas de juego (matriz)
            #region "Filas y Columnas"

            //-------------------------------------------------------------------------------------Ciclo que se ejecutará 3 veces para realizar la búsqueda en las 3 filas y las 3 columnas de las matriz
            for (int RowCol = 0; RowCol < 3; RowCol++)
            {
                //---------------------------------------------------------------------------------Condición que evalúa cada fila de la matriz en busca de un ganador
                if ((TicTacToeBoard[RowCol, 0] == num) && (TicTacToeBoard[RowCol, 1] == num) && (TicTacToeBoard[RowCol, 2] == num))
                {
                    return num;                                                                // Devuelve "num", en caso de existir un ganador
                }
                else
                {
                    //-----------------------------------------------------------------------------Condición que evalúa cada columna de la matriz en busca de un ganador
                    if ((TicTacToeBoard[0, RowCol] == num) && (TicTacToeBoard[1, RowCol] == num) && (TicTacToeBoard[2, RowCol] == num))
                    {
                        return num;                                                            // Devuelve "num", en caso de existir un ganador
                    }//----------------------------------------------------------------------------Fin de la condición
                }//--------------------------------------------------------------------------------Fin de la Condición
            }//------------------------------------------------------------------------------------Fin del Ciclo
            #endregion

            //-------------------------------------------------------------------------------------En esta Región se evalúan las diagonales de juego (matriz)
            #region "Diagonales"

            //-------------------------------------------------------------------------------------Condición que evalúa la diagonal izquierda de la matriz
            if ((TicTacToeBoard[0, 0] == num) && (TicTacToeBoard[1, 1] == num) && (TicTacToeBoard[2, 2] == num))
            {
                return num;                                                                    // Devuelve "num", en caso de existir un ganador
            }
            else
            {
                //-------------------------------------------------------------------------------------Condición que evalúa la diagonal derecha de la matriz
                if ((TicTacToeBoard[2, 0] == num) && (TicTacToeBoard[1, 1] == num) && (TicTacToeBoard[0, 2] == num))
                {
                    return num;                                                                // Devuelve "num", en caso de existir un ganador
                }//--------------------------------------------------------------------------------Fin de Condición
            }//------------------------------------------------------------------------------------Fin de Condición

            #endregion

            return 0;                                                                       // Devuelve "0" en caso de no existir ganador
        }//----------------------------------------------------------------------------------------Fin de la función

        //-----------------------------------------------------------------------------------------Función que nos permite averiguar si la matriz está completamente llena
        public bool CompleteBoard()
        {
            //-------------------------------------------------------------------------------------Ciclo que recorre todas las filas de la matriz para realizar la comprobación
            for (int Row = 0; Row < 3; Row++)
            {
                //---------------------------------------------------------------------------------Ciclo que recorre todas las columnas de la matriz para realizar la comprobación
                for (int Col = 0; Col < 3; Col++)
                {
                    if (TicTacToeBoard[Row, Col] == 0)                                          // Condición que verifica cada campo, en busca de algún lugar vacío
                        return false;                                                           // Devuelve "false", si el tablero aún no está lleno
                }//--------------------------------------------------------------------------------Fin del Ciclo for
            }//------------------------------------------------------------------------------------Fin del Ciclo for

            return true;                                                                        // Devuelve "true" cuando el tablero esté completo
        }//----------------------------------------------------------------------------------------Fin de la función
        #endregion
        //-----------------------------------------------------------------------------------------Fin de la Región

        //-----------------------------------------------------------------------------------------Aquí se inicia la region del algoritmo "MINIMAX", el cual se va a encargar del Jugador versus Computadora
        #region "Algoritmo MINIMAX"
        
        //-----------------------------------------------------------------------------------------Este procedimiento es el encargado de analizar el tablero y determinar en que posición jugará la computadora
        public void ComputerPlay()
        {
            //-------------------------------------------------------------------------------------Condición que evalúa si no ha terminado el juego, comprobando si existe un ganador o el juego finalizó empate
            if ((PlayersWin(1) == 0) && (PlayersWin(2) == 0) && (CompleteBoard() == false))
            {
                #region "Definición de Variables"
                //---------------------------------------------------------------------------------Aquí se crean e inicializan las variables
                int f = 0, c = 0;                                                               // Se crean e inicializan variables de tipo "int" "f" y "c" en "0"
                int v = int.MinValue;                                                           // Se almacena en la variable "int" "v" el valor mínimo de los "int"
                int aux;                                                                        // Se crea la variable "aux" de tipo "int"
                                                                                                //---------------------------------------------------------------------------------Fin de creado e inicializado de variables
                #endregion

                #region "Algoritmo para Determinar la Jugada"
                //---------------------------------------------------------------------------------Ciclo que recorre todas las filas de la matriz "TicTacToeBoard"
                for (int Row = 0; Row < 3; Row++)
                {
                    //------------------------------------------------------------------------------Ciclo que recorre todas las columnas de la matriz "TicTacToeBoard"
                    for (int Col = 0; Col < 3; Col++)
                    {
                        //-------------------------------------------------------------------------Condición que evalúa si el campo en la matriz "TicTacToeBoard" tiene el valor de "0", para saber si el campo está vacío
                        if (TicTacToeBoard[Row, Col] == 0)
                        {
                            TicTacToeBoard[Row, Col] = 2;                                       // Al campo le asigna el valor equivalente a una jugada de la Computadora

                            aux = Min();                                                        // A la variable "aux", se le asigna lo que retorne la función "Min"

                            //---------------------------------------------------------------------Condición que evalúa si la variable "aux" es mayor a los que tenga la variable "v"
                            if (aux > v)                                                        
                            {
                                v = aux;                                                        // A la variable "v" se le asigna lo que contenga la variable "aux"
                                f = Row;                                                        // A la variable "f" se le asigna lo que contenga la variable "Row" del ciclo for
                                c = Col;                                                        // A la variable "c" se le asigna lo que contenga la variable "Col" del ciclo for
                            }//--------------------------------------------------------------------Fin de la Condición

                            TicTacToeBoard[Row, Col] = 0;                                       // Vuelve a asignarle al campo anterior en la matriz "TicTacToeBoard" el valor de dato vacío "0"
                        }//------------------------------------------------------------------------Fin de la Condición
                    }//----------------------------------------------------------------------------Fin del Ciclo for
                }//--------------------------------------------------------------------------------Fin del Ciclo for
                TicTacToeBoard[f, c] = 2;                                                       // Cuando finaliza los ciclos y ya se determinó la siguiente jugada, almacena el dato en la matriz "TicTacToeBoard", en este caso es "2"
                #endregion
            }//------------------------------------------------------------------------------------Fin de la Condición
        }

        //-----------------------------------------------------------------------------------------Función que determina la máxima jugada posible. Es parte fundamental del algoritmo
        private int Max()
        {
            #region "En caso de haber finalizado la partida"
            //-------------------------------------------------------------------------------------Condición que evalúa si ya se ganó la partida o si la misma terminó empate
            if ((PlayersWin(1) == 1) || (PlayersWin(2) == 2) || (CompleteBoard() == true))
            {
                //---------------------------------------------------------------------------------Condición que evalúa si ya se ganó la partida
                if ((PlayersWin(1) == 1) || (PlayersWin(2) == 2))
                    return 0;                                                                   // Si ya se ganó la partida devuelve o retorna "0"
                else
                    return 1;                                                                   // Si se empata la partida, retorna "1"
                //---------------------------------------------------------------------------------Fin de la Condición
            }//------------------------------------------------------------------------------------Fin de la Condición
            #endregion

            #region "Variables de la Función"
            int v = int.MinValue;                                                               // Crea e inicializa "v" de tipo "int" y le asigna el valor mínimo del tipo correspondiente (int)
            int aux;                                                                            // Crea la variable "aux" de tipo "int"
            #endregion

            #region "Algoritmo de la Función"
            //---------------------------------------------------------------------------------Ciclo que recorre todas las filas de la matriz "TicTacToeBoard"
            for (int Row = 0; Row < 3; Row++)
            {
                //------------------------------------------------------------------------------Ciclo que recorre todas las columnas de la matriz "TicTacToeBoard"
                for (int Col = 0; Col < 3; Col++)
                {
                    //-------------------------------------------------------------------------Condición que evalúa si el campo en la matriz "TicTacToeBoard" tiene el valor de "0", para saber si el campo está vacío
                    if (TicTacToeBoard[Row, Col] == 0)
                    {
                        TicTacToeBoard[Row, Col] = 2;                                           // Al campo le asigna el valor equivalente a una jugada de la Computadora

                        aux = Min();                                                            // A la variable "aux", se le asigna lo que retorne la función "Min"

                        //-------------------------------------------------------------------------Condición que evalúa si la variable "aux" es mayor a los que tenga la variable "v"
                        if (aux > v)
                        {
                            v = aux;                                                            // A la variable "v" se le asigna lo que contenga la variable "aux"
                        }//------------------------------------------------------------------------Fin de la Condición

                        TicTacToeBoard[Row, Col] = 0;                                           // Vuelve a asignarle al campo anterior en la matriz "TicTacToeBoard" el valor de campo vacío "0"
                    }//----------------------------------------------------------------------------Fin de la Condición
                }//--------------------------------------------------------------------------------Fin del Ciclo for
            }//------------------------------------------------------------------------------------Fin del Ciclo for
            #endregion

            return v;                                                                           // Devuelve o retorna el dato almacenado en "v"
        }//----------------------------------------------------------------------------------------Fin de la Función

        //-----------------------------------------------------------------------------------------Función que determina la mínima jugada posible. Es parte fundamental del algoritmo
        private int Min()
        {
            #region "En caso de haber finalizado la partida"
            //-------------------------------------------------------------------------------------Condición que evalúa si ya se ganó la partida o si la misma terminó empate
            if ((PlayersWin(1) == 1) || (PlayersWin(2) == 2) || (CompleteBoard() == true))
            {
                //---------------------------------------------------------------------------------Condición que evalúa si ya se ganó la partida
                if ((PlayersWin(1) == 1) || (PlayersWin(2) == 2))
                    return 2;                                                                   // Si ya se ganó la partida devuelve o retorna "2"
                else
                    return 1;                                                                   // Si se empata la partida, retorna "1"
                //---------------------------------------------------------------------------------Fin de la Condición
            }//------------------------------------------------------------------------------------Fin de la Condición
            #endregion

            #region "Variables de la Función"
            int v = int.MaxValue;                                                               // Crea e inicializa "v" de tipo "int" y le asigna el valor máximo del tipo correspondiente (int)
            int aux;                                                                            // Crea la variable "aux" de tipo "int"
            #endregion

            #region "Algoritmo de la Función"
            //---------------------------------------------------------------------------------Ciclo que recorre todas las filas de la matriz "TicTacToeBoard"
            for (int Row = 0; Row < 3; Row++)
            {
                //------------------------------------------------------------------------------Ciclo que recorre todas las columnas de la matriz "TicTacToeBoard"
                for (int Col = 0; Col < 3; Col++)
                {
                    //-------------------------------------------------------------------------Condición que evalúa si el campo en la matriz "TicTacToeBoard" tiene el valor de "0", para saber si el campo está vacío
                    if (TicTacToeBoard[Row, Col] == 0)
                    {
                        TicTacToeBoard[Row, Col] = 1;                                           // Al campo le asigna el valor equivalente a una jugada del jugador 1

                        aux = Max();                                                            // A la variable "aux", se le asigna lo que retorne la función "Max"

                        //-------------------------------------------------------------------------Condición que evalúa si la variable "aux" es mayor a los que tenga la variable "v"
                        if (aux < v)
                        {
                            v = aux;                                                            // A la variable "v" se le asigna lo que contenga la variable "aux"
                        }//------------------------------------------------------------------------Fin de la Condición

                        TicTacToeBoard[Row, Col] = 0;                                           // // Vuelve a asignarle al campo anterior en la matriz "TicTacToeBoard" el valor de campo vacío "0"
                    }//----------------------------------------------------------------------------Fin de la Condición
                }//--------------------------------------------------------------------------------Fin del Ciclo for
            }//------------------------------------------------------------------------------------Fin del Ciclo for
            #endregion

            return v;                                                                           // Devuelve o retorna el dato almacenado en "v"
        }

        #endregion
    }

}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace proyecto_compiladores
{
    class funciones:constructor
    {
        private string leer_cadena_caracteres(string _cadena, int _posicion)
        {
            string cadena = _cadena;
            int posicion = _posicion;

            byte[] valoresASCII = Encoding.ASCII.GetBytes(cadena);

            switch (valoresASCII[posicion])
            {
                case 32:
                    Columna++;
                    return "[espacio]:32";
                case 10:
                    Linea++;
                    Columna = 1;
                    return "[Salto de Linea]:10";
                case 13:
                    Columna++;
                    return "[Fin de Linea]:13";
                case 9:
                    Columna = Columna + 8;
                    return "[Tabulación]:9";
                default:
                    Columna++;
                    string caracter = Convert.ToChar(valoresASCII[posicion]).ToString();
                    return caracter;
            }
        }

        public string crear_cadena_por_operacion(string _cadena, string _operacion)
        {
            string cadena = _cadena;
            string operacion = _operacion;
            int longitdud_cadena = cadena.Length;
            string cadena_contenido = null;
            if(longitdud_cadena > 0)
            {
                for (int i = 0; i <= longitdud_cadena - 1; i++)
                {
                    switch (operacion)
                    {
                        case "mostrar_caracteres":
                            MessageBox.Show(leer_cadena_caracteres(cadena, i));
                            break;
                        case "flujo_caracteres":
                            cadena_contenido += "[Caracter]: " + leer_cadena_caracteres(cadena, i) + Environment.NewLine;
                            break;
                        case "lineas_columnas":
                            cadena_contenido += "[Linea]: " + Linea + "  █  [Columna]: " + Columna + "  █  " + leer_cadena_caracteres(cadena, i) + Environment.NewLine;
                            break;
                    }
                }
                Linea = 1;
                Columna = 1;
                return cadena_contenido;
            }
            else
            {
                MessageBox.Show("Input Vacio");
                return null;
            }
        }

        public string carga_lectura_archivo()
        {
            string ruta_archivo = "";
            string contenido_archivo = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccione un Archivo";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ruta_archivo = openFileDialog.FileName;
                        StreamReader leer_archivo = new StreamReader(ruta_archivo);
                        contenido_archivo = leer_archivo.ReadToEnd();
                    }
                    catch (Exception ex)
                    {
                        contenido_archivo = "Error al cargar el archivo: " + ex.Message;
                    }
                }
            }
            return contenido_archivo;
        }

        public void generar_token_depurado(string _cadena)
        {
            //Inicializando Variables Necesarias
            int longitud_cadena = _cadena.Length - 1; string leer_caracter;
            char caracter; int estado = 0; string operadores_signos_lista = "[-:<>|+/&(){};,=*]";
            string lexema = null; string tipo_lexema = null; string linea_columna = null;
            mantenimiento _mantenimiento = new mantenimiento();
            string[] _tipo_lexema = { "Identificador", "Numero Entero", "Numero Decimal", "Operador", "Signo de Puntuación", "String", "Comentario", "Palabra Reservada" };
            Linea = 1; Columna = 1;
            int linea_caracter = 0; int columna_caracter = 0; string caracter_conflicto = null;

            //Metodo interno para ingresar los tokens analizados a la base de datos
            void db_insertar_token()
            {
                _mantenimiento.insertar_token(lexema, tipo_lexema, linea_columna);
                tipo_lexema = null; lexema = null; estado = 0;
            }

            //Metodo interno para generar token analizado [lexema, tipo_lexema]
            void insertar_token()
            {
                if (tipo_lexema == _tipo_lexema[0])
                {
                    tipo_lexema = comparar_lexema(lexema);
                    db_insertar_token();
                }
                else
                {
                    db_insertar_token();
                }
            }

            //Lectura y generacion de tokens
            for (int i = 0; i <= longitud_cadena; i++)
            {
                leer_caracter = leer_cadena_caracteres(_cadena, i);
                if(longitud_cadena != i)
                {
                    columna_caracter = Columna - 2;
                }
                else
                {
                    columna_caracter = Columna - 1;
                }

                //Estandarizacion y conversion del sitring obtenido a char.
                if (leer_caracter == "[espacio]:32")
                {
                    caracter = ' ';
                }
                else if (leer_caracter == "[Salto de Linea]:10")
                {
                    caracter = '\n';
                }
                else if (leer_caracter == "[Fin de Linea]:13")
                {
                    caracter = '\r';
                }
                else if (leer_caracter == "[Tabulación]:9")
                {
                    caracter = '\t';
                }
                else
                {
                    caracter = char.Parse(leer_caracter);
                }

                linea_columna = "Linea: " + Linea + ". Columna: " + columna_caracter;

                //Filtro e Identificación de lexemas
                switch (estado)
                {
                    case 0:
                        if (char.IsLetter(caracter))// Identificando ID
                        {
                            lexema += caracter.ToString();
                            tipo_lexema = _tipo_lexema[0];
                            estado = 1;
                        }
                        else if (char.IsNumber(caracter)) //Identificando Numero
                        {
                            lexema += caracter.ToString();
                            tipo_lexema = _tipo_lexema[1];
                            estado = 1;
                        }
                        else if (caracter == ':' || caracter == '>' || caracter == '<' || caracter == '=' ||
                                 caracter == '+' || caracter == '-' || caracter == '*' || caracter == '/' ||
                                 caracter == '|' || caracter == '&')//Identificar Operador
                        {
                            lexema += caracter.ToString();
                            tipo_lexema = _tipo_lexema[3];
                            estado = 1;
                        }
                        else if (caracter == '(' || caracter == ')' || caracter == '{' || caracter == '}' ||
                                 caracter == ';' || caracter == ',') //Identificar Signos de Puntuacion
                        {
                            lexema += caracter.ToString();
                            tipo_lexema = _tipo_lexema[4];
                            estado = 1;
                        }
                        else if (caracter == '"')//Identificar String [inicio]
                        {
                            lexema += caracter.ToString();
                            estado = 117;
                        }
                        else if (caracter == ' ' || caracter == '\n' || caracter == '\r' || caracter == '\t')//Reiniciando proceso
                        {
                            estado = 0;
                        }
                        else //error el caracter no cumple ninguno de los filtros [operadro, entero, decimal, id, signo]
                        {
                            lexema += caracter.ToString();
                            columna_caracter = Columna - 1;
                            linea_caracter = Linea;
                            caracter_conflicto = caracter.ToString();
                            estado = 1;
                            tipo_lexema = "Lexema error" + " - | Linea: " + linea_caracter + " | Columna: " + columna_caracter + " | " ;
                        }

                        //Agregar ultimo lexema de la cadena [CASO/ESTADO #0]
                        if (longitud_cadena == i && lexema != null)
                        {

                            insertar_token();
                        }
                        break;
                    case 1:
                        if (char.IsLetter(caracter) || char.IsNumber(caracter) || caracter == '_') //Identificando ID y Numeros
                        {
                            if (int.TryParse(lexema, out _) == true || lexema == "+" || lexema == "-" || lexema.Contains(".")) // Comprobando si el lexema es numerico o positivo/negativo
                            {
                                if (char.IsNumber(caracter)) //Comprobando si el caracter actual es numerico
                                {
                                    if (lexema == "+") //Filtro numero positivo o negativo [ +n || -n ]
                                    {
                                        tipo_lexema = _tipo_lexema[1];
                                        lexema = null;
                                        lexema += caracter.ToString();
                                    }
                                    else if(lexema == "-")
                                    {
                                        tipo_lexema = _tipo_lexema[1];
                                        lexema += caracter.ToString();
                                    }
                                    else //Agregar caracter numerico
                                    {
                                        lexema += caracter.ToString();
                                    }
                                }
                                else //Caracter actual no es numerico, el lexema no cumple las normas para ser un numero o un ID
                                {
                                    tipo_lexema = "Lexema error" + " - | Linea: " + linea_caracter + " | Columna: " + columna_caracter + " | ";
                                    lexema += caracter.ToString();
                                }
                            }
                            else if (Regex.IsMatch(lexema, operadores_signos_lista) == false)
                            {
                                lexema += caracter.ToString();
                            }
                            else //error al identificar ID, existe un operador y/o un signo de puntuacion dentro del lexema
                            {
                                tipo_lexema = "Lexema error " + " - | Linea: " + linea_caracter + " | Columna: " + columna_caracter + " | ";
                                lexema += caracter.ToString();
                            }
                        }
                        else if (caracter == '.')//Identificando Numero Decimal
                        {
                            if (int.TryParse(lexema, out _) == true)
                            {
                                lexema += caracter.ToString();
                                tipo_lexema = _tipo_lexema[2];
                            }
                            else
                            {
                                lexema += caracter.ToString();
                                columna_caracter = Columna - 1;
                                linea_caracter = Linea;
                                tipo_lexema = "Lexema error" + " - | Linea: " + linea_caracter + " | Columna: " + columna_caracter + " | ";
                            }
                        }
                        else if (caracter == '=' && lexema == ":" || caracter == '>' && lexema == "<" ||
                                 caracter == '|' && lexema == "|" || caracter == '&' && lexema == "&")//Identificando operador
                        {
                            lexema += caracter.ToString();
                            estado = 2;
                        }
                        else if (caracter == '*' && lexema == "/")//Identificando Comentarios
                        {
                            lexema += caracter.ToString();
                            tipo_lexema = _tipo_lexema[6] +" [Inicio]";
                            db_insertar_token();
                            estado = 118;
                        }
                        else if (caracter == ' ' || caracter == '\n' || caracter == '\r' || caracter == '\t') //Agregando lexema
                        {
                            insertar_token();
                        }
                        else //error el caracter no cumple ninguno de los filtros [operadro, entero, decimal, id, signo]
                        {
                            lexema += caracter.ToString();
                            columna_caracter = Columna - 1;
                            linea_caracter = Linea;
                            caracter_conflicto = caracter.ToString();
                            tipo_lexema = "Lexema error" + " - | Linea: " + linea_caracter + " | Columna: " + columna_caracter + " | ";
                        }

                        //Agregar ultimo lexema de la cadena [CASO/ESTADO #1]
                        if (longitud_cadena == i)
                        {
                            insertar_token();
                        }
                        break;
                    case 2:
                        if (caracter == ' ' || caracter == '\n' || caracter == '\r' || caracter == '\t') //Agregando lexema
                        {
                            insertar_token();
                        }
                        else //error el caracter no cumple ninguno de los filtros [operador]
                        {
                            lexema += caracter.ToString();
                            columna_caracter = Columna - 1;
                            linea_caracter = Linea;
                            caracter_conflicto = caracter.ToString();
                            tipo_lexema = "Lexema error" + " - | Linea: " + linea_caracter + " | Columna: " + columna_caracter + " | ";
                        }

                        //Agregar ultimo lexema de la cadena [CASO/ESTADO #2]
                        if (longitud_cadena == i)
                        {
                            insertar_token();
                        }
                        break;
                    case 117:
                        if (caracter != '\n')//Comprobando que el inicio del string este en la misma linea que el contenido
                        {
                            if (caracter == '"')//Validando el cierre del string e insertandolo
                            {
                                //agregar_lexema();
                                lexema += caracter.ToString();
                                estado = 2;
                                tipo_lexema = _tipo_lexema[5];
                                db_insertar_token();
                            }
                            else //agregar contenido al sitring
                            {
                                tipo_lexema = _tipo_lexema[5];
                                lexema += caracter.ToString();
                                if (longitud_cadena == i)
                                {
                                    tipo_lexema = "error string sin cierre";
                                    db_insertar_token();
                                }
                            }
                        }
                        else //error no cumple ninguna de las condiciones
                        {
                            estado = 2;
                            tipo_lexema = "error string";
                            db_insertar_token();
                        }
                        break;
                    case 118:
                        if (lexema != null)
                        {
                            if (lexema.Contains("*/") == true)
                            {
                                lexema = lexema.Remove(lexema.Length - 2);
                                db_insertar_token();
                                lexema += "*/";
                                estado = 2;
                                tipo_lexema = _tipo_lexema[6]+" [Cierre]";
                                db_insertar_token();
                            }
                            else
                            {
                                tipo_lexema = _tipo_lexema[6] + " [Contenido]";
                                if (caracter == '\n' || caracter == '\t')
                                {
                                    lexema += " ";
                                }
                                else
                                {
                                    lexema += caracter.ToString();
                                }
                            }
                        }
                        else
                        {
                            tipo_lexema = _tipo_lexema[6] + " [Contenido]";
                            lexema += caracter.ToString();
                        }

                        if (longitud_cadena == i)
                        {
                            if (lexema.Contains("*/") == true)
                            {
                                lexema = lexema.Remove(lexema.Length - 2);
                                db_insertar_token();
                                lexema += "*/";
                                estado = 2;
                                tipo_lexema = _tipo_lexema[6] + " [Cierre]";
                                db_insertar_token();
                            }
                        }
                        break;
                }
                //FIN CICLO FOR
            }
            _mantenimiento.insertar_errores();
            _mantenimiento.insertar_token_valido();
        }

        public string comparar_lexema(string _lexema)
        {
            string tipo_lexema = "Identificador";
            db_conexion cn = new db_conexion();
            constructor _constructor_lista = new constructor();
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "SELECT * FROM sys_palabra_reservada";
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if(_lexema.ToLower() == reader.GetString(1).ToLower())
                        {
                            tipo_lexema = "Palabra Reservada";
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error:" + e);
            }
            finally
            {
                conexion_db.Close();
            }

            return tipo_lexema;
        }

        public string regla_produccion_1_S()
        {
            //Esta regla valida: Main(){}
            string resultado = null;
            mantenimiento _mantenimiento = new mantenimiento();

            if(_mantenimiento.getToken().ToLower() == "main")
            {
                if (_mantenimiento.getToken() == "(") 
                {
                    if (_mantenimiento.getToken() == ")")
                    {
                        if (_mantenimiento.getToken() == "{")
                        {
                            if (_mantenimiento.getToken() == "}")
                            {

                                _mantenimiento.indice = _mantenimiento.indice - 1;
                                if (_mantenimiento.nextToken() == "")
                                {
                                    resultado = "GRAMÁTICA VALIDA. No se encontraron errores. ";
                                }
                                else // Verificar si existe alguna funcion, id, etc. fuera de la estructura main.
                                {
                                    resultado = "Error de sintaxis, token: " + _mantenimiento.nextToken() +". Fuera del main. " + _mantenimiento.linea_columna;
                                }

                            }
                            else
                            {
                                resultado = "Error de sintaxis en la " + _mantenimiento.linea_columna + ". Se Esperaba: }";
                            }
                        }
                        else
                        {
                            resultado = "Error de sintaxis en la " + _mantenimiento.linea_columna + ". Se Esperaba: {";
                        }
                    }
                    else
                    {
                        resultado = "Error de sintaxis en la " + _mantenimiento.linea_columna + ". Se Esperaba: )";
                    }
                }
                else
                {
                    resultado = "Error de sintaxis en la " + _mantenimiento.linea_columna + ". Se Esperaba: (";
                }
            }
            else
            {
                resultado = "Error de sintaxis en la " + _mantenimiento.linea_columna + ". Se Esperaba: Main";
            }

            _mantenimiento.indice = 1;

            return resultado;

        }

    }
}

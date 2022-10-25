using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyecto_compiladores
{
    class mantenimiento
    {
        db_conexion cn = new db_conexion();
        public int indice = 1;
        public string linea_columna = "";
        public List<Object> consultar_datos()
        {
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            List<Object> lista = new List<object>();
            string comando_sql = "SELECT * FROM sys_palabra_reservada ORDER BY id_palabra_reservada ASC";
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        palabras_reservadas _constructor = new palabras_reservadas();
                        _constructor.Id_Palabra_Reservada = int.Parse(reader.GetString(0));
                        _constructor.Palabra_Reservada = reader.GetString(1);
                        if (reader.GetString(2) == "A")
                        {
                            _constructor.Estado_Registro = "Activo";
                        }
                        else if(reader.GetString(2) == "B")
                        {
                            _constructor.Estado_Registro = "Baja";
                        }
                        lista.Add(_constructor);
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
            return lista;
        }

        public List<Object> consultar_tokens_error()
        {
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            List<Object> lista = new List<object>();
            string comando_sql = "SELECT * FROM sys_token_error ORDER BY id_token_error ASC";
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        token_error _construir_token = new token_error();
                        _construir_token.Id_Token_Error = int.Parse(reader.GetString(0));
                        _construir_token.Lexema = reader.GetString(1);
                        _construir_token.Error = reader.GetString(2);
                        _construir_token.Id_Token = int.Parse(reader.GetString(3));


                        lista.Add(_construir_token);
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
            return lista;
        }

        public List<Object> consultar_tokens_validos()
        {
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            List<Object> lista = new List<object>();
            string comando_sql = "SELECT * FROM sys_token_validado ORDER BY id_token_validado ASC";
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        token _construir_token = new token();
                        _construir_token.Id_Token = int.Parse(reader.GetString(0));
                        _construir_token.Lexema = reader.GetString(1);
                        _construir_token.Tipo_Lexema = reader.GetString(2);


                        lista.Add(_construir_token);
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
            return lista;
        }

        public List<Object> consultar_simbolos()
        {
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            List<Object> lista = new List<object>();
            string comando_sql = "SELECT * FROM sys_simbolo ORDER BY id_simbolo ASC";
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        simbolo _construir_simbolo = new simbolo();
                        _construir_simbolo.Id_Simbolo = reader.GetString(0);
                        _construir_simbolo.Tipo_Simbolo = reader.GetString(1);

                        lista.Add(_construir_simbolo);
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
            return lista;
        }

        public List<Object> consultar_tokens()
        {
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            List<Object> lista = new List<object>();
            string comando_sql = "SELECT * FROM sys_token ORDER BY id_token ASC";
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        token _construir_token = new token();
                        _construir_token.Id_Token = int.Parse(reader.GetString(0));
                        _construir_token.Lexema = reader.GetString(1);
                        _construir_token.Tipo_Lexema = reader.GetString(2);
                        
                        
                        lista.Add(_construir_token);
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
            return lista;
        }
        public bool insertar_token(string _lexema, string _tipo, string _linea_columna)
        {
            bool estado_consulta = false;
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "INSERT INTO sys_token(lexema, tipo_lexema, linea_columna) VALUES('" + _lexema + "',"+"'"+_tipo+"','"+_linea_columna+"');";
            try
            {
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                comando.ExecuteNonQuery();
                estado_consulta = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("error al ingresar datos:" + e);
                estado_consulta = false;
            }
            finally
            {
                conexion_db.Close();
            }
            return estado_consulta;
        }

        public bool vaciar_tokens()
        {
            bool estado_consulta = false;
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "TRUNCATE TABLE sys_token; TRUNCATE TABLE sys_token_error; TRUNCATE TABLE sys_token_validado; TRUNCATE TABLE sys_simbolo;";
            try
            {
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                comando.ExecuteNonQuery();
                estado_consulta = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("error al limpiar datos:" + e);
                estado_consulta = false;
            }
            finally
            {
                conexion_db.Close();
            }
            return estado_consulta;
        }

        public bool vaciar_simbolos()
        {
            bool estado_consulta = false;
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "TRUNCATE TABLE sys_simbolo;";
            try
            {
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                comando.ExecuteNonQuery();
                estado_consulta = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("error al limpiar datos:" + e);
                estado_consulta = false;
            }
            finally
            {
                conexion_db.Close();
            }
            return estado_consulta;
        }

        public bool insertar(string _palabra_reservada)
        {
            bool estado_consulta = false;
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "INSERT INTO sys_palabra_reservada(descripcion) VALUES('"+_palabra_reservada+ "');";
            try
            {
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                comando.ExecuteNonQuery();
                estado_consulta = true;
            }
            catch(Exception e)
            {
                MessageBox.Show("error al ingresar datos:" + e);
                estado_consulta = false;
            }
            finally
            {
                conexion_db.Close();
            }
            return estado_consulta;
        }

        public List<string> rellenar_campos(int _id)
        {
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
                        palabras_reservadas _constructor = new palabras_reservadas();
                        _constructor.Id_Palabra_Reservada = int.Parse(reader.GetString(0));
                        _constructor.Palabra_Reservada = reader.GetString(1);
                        _constructor.Estado_Registro = reader.GetString(2);

                        if (_id == _constructor.Id_Palabra_Reservada)
                        {
                            _constructor_lista.Actualizar_Datos.Add(_constructor.Id_Palabra_Reservada.ToString());
                            _constructor_lista.Actualizar_Datos.Add(_constructor.Palabra_Reservada.ToString());
                            _constructor_lista.Actualizar_Datos.Add(_constructor.Estado_Registro.ToString());
                            break;
                        }
                        else
                        {
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
            return _constructor_lista.Actualizar_Datos;
        }

        public bool actualizar_datos(int _id_palabra_reservada,string _palabra_reservada,string _estado_registro)
        {
            bool estado_consulta = false;
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "UPDATE sys_palabra_reservada SET descripcion='"+_palabra_reservada+"',estado_registro='"+_estado_registro+"' WHERE id_palabra_reservada="+_id_palabra_reservada+";";
            try
            {
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                comando.ExecuteNonQuery();
                estado_consulta = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("error al ingresar datos:" + e);
                estado_consulta = false;
            }
            finally
            {
                conexion_db.Close();
            }
            return estado_consulta;
        }

        public bool dar_baja(int _id_palabra_reservada)
        {
            bool estado_consulta = false;
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "UPDATE sys_palabra_reservada SET estado_registro='B'" + " WHERE id_palabra_reservada=" + _id_palabra_reservada + ";";
            try
            {
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                comando.ExecuteNonQuery();
                estado_consulta = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("error al dar de baja:" + e);
                estado_consulta = false;
            }
            finally
            {
                conexion_db.Close();
            }
            return estado_consulta;
        }

        public bool eliminar_registro(int _id_palabra_reservada)
        {
            bool estado_consulta = false;
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "DELETE FROM sys_palabra_reservada WHERE id_palabra_reservada=" + _id_palabra_reservada + ";";

            try
            {
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                comando.ExecuteNonQuery();
                estado_consulta = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("error al eliminar registro:" + e);
                estado_consulta = false;
            }
            finally
            {
                conexion_db.Close();
            }
            return estado_consulta;
        }

        public void insertar_errores()
        {
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "INSERT INTO sys_token_error SELECT 0 as id_token_error, lexema as lexema, tipo_lexema as error_lexema, id_token as id_token from sys_token where tipo_lexema like '%error%';";
            try
            {
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("error al ingresar errores:" + e);
            }
            finally
            {
                conexion_db.Close();
            }
        }

        public void insertar_token_valido()
        {
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "INSERT INTO sys_token_validado SELECT 0 as id_token_validado, lexema as lexema, tipo_lexema as tipo_lexema, linea_columna as linea_columna from sys_token where not (tipo_lexema like '%Comentario%' or tipo_lexema like '%error%');";
            try
            {
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("error al ingresar token valido:" + e);
            }
            finally
            {
                conexion_db.Close();
            }
        }

        public void generar_simbolos()
        {
            var lista_simbolos = new List<(string _id_simbolo, string _tipo_simbolo)>();
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "select lexema, tipo_lexema from sys_token_validado where tipo_lexema = 'Identificador';";
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string Id_Simbolo = reader.GetString(0);
                        string Tipo_Simbolo = reader.GetString(1);
                        if (lista_simbolos.Count() > 0)
                        {
                            bool agregar_simbolo = true;
                            for (int i = 0; i < lista_simbolos.Count(); i++)
                            {
                                if(lista_simbolos[i]._id_simbolo == Id_Simbolo)
                                {
                                    agregar_simbolo = false;
                                }
                            }

                            if(agregar_simbolo == true)
                            {
                                lista_simbolos.Add((_id_simbolo: Id_Simbolo, _tipo_simbolo: Tipo_Simbolo));
                            }
                        }
                        else
                        {
                            lista_simbolos.Add((_id_simbolo: Id_Simbolo, _tipo_simbolo: Tipo_Simbolo));
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

            for (int i = 0; i < lista_simbolos.Count(); i++)
            {
                insertar_simbolos(lista_simbolos[i]._id_simbolo, lista_simbolos[i]._tipo_simbolo);
            }

        }

        public void insertar_simbolos(string _id_simbolo, string _tipo_simbolo)
        {
            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            string comando_sql = "INSERT INTO sys_simbolo (id_simbolo, tipo_simbolo) VALUES ('"+_id_simbolo+"', '"+_tipo_simbolo+"');";
            try
            {
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("error al ingresar simbolo:" + e);
            }
            finally
            {
                conexion_db.Close();
            }
        }

        public string getToken()
        {

            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            List<Object> lista = new List<object>();
            string comando_sql = "SELECT * FROM sys_token_validado WHERE id_token_validado = " + indice;
            string lexema = ""; 
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lexema = reader.GetString(1);
                        linea_columna = reader.GetString(3);
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
                indice = indice + 1;
            }

            return lexema;
        }

        public string nextToken()
        {

            MySqlConnection conexion_db = cn.conexion_db();
            conexion_db.Open();
            List<Object> lista = new List<object>();
            int proximo_indice = indice + 1;
            string comando_sql = "SELECT * FROM sys_token_validado WHERE id_token_validado = " + proximo_indice;
            string lexema = "";
            try
            {
                MySqlDataReader reader;
                MySqlCommand comando = new MySqlCommand(comando_sql, conexion_db);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lexema = reader.GetString(1);
                        linea_columna = reader.GetString(3);
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

            return lexema;
        }

    }
}

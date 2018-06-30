using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using MySql.Data.MySqlClient;

namespace ProvaLiax_Ricardo_Tarozo
{
    class Conectar
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Conectar()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "db_prova_liax_ricardo_tarozo";
            uid = "root";
            password = "1233";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Não foi possível se conectar no banco de dados.  Contate o administrador");
                        break;

                    case 1045:
                        Console.WriteLine("Usuário e/ou senha inválido, por favor tente novamente");
                        break;
                }
                return false;
            }
        }

        //Fecha a conexão
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Insert statement

        public void Insert()
        {
            string query = "INSERT INTO genero (descricao) VALUES('?descricao')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    }
}


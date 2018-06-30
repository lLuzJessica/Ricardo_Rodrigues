using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaLiax_Ricardo_Tarozo
{
    class Aluno
    {
        private MySqlCommand command;
        private MySqlDataAdapter dAdapter;
        private DataSet dSet;

        public void Incluir(string nome, int idade, string nome_pai="",string nome_mae)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO Alunos (nome, idade, curso, nome_pai, nome_mae" + "VALUES('" + nome + "'," + idade + ",'" + nome_pai + "','" + nome_mae + "'", connection);
         }
    }
}


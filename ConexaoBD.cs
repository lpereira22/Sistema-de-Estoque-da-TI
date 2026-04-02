using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_de_Estoque_TI
{
    internal class ConexaoBD
    {
        string conexaoString = "server=localhost;database=Controle_de_Estoque;user=root;password=;";

        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conexaoBD = new MySqlConnection(conexaoString);
                conexaoBD.Open();
                return conexaoBD;
            }catch (MySqlException ex)
            {
                MessageBox.Show("Erro conexão: " + ex.Message);
                return null;
            }
        }
    }
}

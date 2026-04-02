using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_de_Estoque_TI
{
    internal class Item
    {
        private string _nome;
        private string _categoria;
        private bool _status;
        private int _quantidade;
        private int _quantidadeMinima;
        private string _local;
        private string _descricao;

        public Item(string nome, string categoria,bool status, int quantidade, int quantidadeMinima, string local, string descricao)
        {
            _nome = nome;
            _categoria = categoria;
            _status = status;
            _quantidade = quantidade;
            _quantidadeMinima = quantidadeMinima;
            _local = local;
            _descricao = descricao;
        }
    }
}

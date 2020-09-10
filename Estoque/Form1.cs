using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int qtdEstoque = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //INICIALIZANDO LISTAS
            InicializaListas();
            //INICIANDO VALOR ESTOQUE ANTES DE ATUALIZAR
            lbQtdEstoque.Text = qtdEstoque.ToString();

        }

        public void InicializaListas()
        {
            List<Produto> produtos = preencheListaProduto();
            List<Venda> vendas = preencheListaVenda();
            List<Filial> filiais = preencheListaFilial();

            grvProduto.DataSource = produtos;
            grvVenda.DataSource = vendas;
            qtdEstoque = produtos.Sum(x => (x.qtdeEstoque));
        }

        void atualizaEstoque()
        {
            foreach (DataGridViewRow grvRow in grvVenda.Rows)
            {
                RemoveProdutoVendido(grvRow.Cells["codigoProd"].Value.ToString(), grvRow.Cells["qtdVenda"].Value.ToString());
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(atualizaEstoque);
            thread.Start();
            grvProduto.Refresh();
            grvProduto.Update();
            lbQtdEstoque.Text = qtdEstoque.ToString();
            thread.Join();
        }

        private void RemoveProdutoVendido(string codidoProdutoVendido, string qtdVenda)
        {
            List<Produto> produtos = (List<Produto>)grvProduto.DataSource;

            foreach (var prodt in produtos.Where(x => x.codigoProd == Convert.ToInt32(codidoProdutoVendido)))
            {
                prodt.qtdeEstoque = (prodt.qtdeEstoque - Convert.ToInt32(qtdVenda));
            }
            qtdEstoque = produtos.Sum(x => (x.qtdeEstoque));
            grvProduto.DataSource = produtos;
        }

        private List<Filial> preencheListaFilial()
        {
            List<Filial> filiais = new List<Filial>();
            for (int i = 1; i <= 10; i++)
            {
                filiais.Add(new Filial()
                {
                    codigoFil = i,
                    nomeFil = "Filial " + i
                });
            }
            return filiais;
        }

        private List<Venda> preencheListaVenda()
        {
            Random random = new Random();
            List<Venda> vendas = new List<Venda>();
            for (int i = 1; i <= 50; i++)
            {
                vendas.Add(new Venda()
                {
                    numVenda = i,
                    qtdVenda = random.Next(1, 3),
                    vlrVenda = random.Next(100, 1000).ToString(),
                    codigoProd = random.Next(1, 10)
                });
            }
            return vendas;
        }

        private List<Produto> preencheListaProduto()
        {
            Random random = new Random();

            List<Produto> produtos = new List<Produto>();
            for (int i = 1; i <= 10; i++)
            {
                produtos.Add(new Produto()
                {
                    codigoProd = i,
                    nomeProd = "Produto " + i,
                    qtdeEstoque = random.Next(50, 200)
                });
            }
            return produtos;
        }
    }
    public class Filial
    {
        public int codigoFil { get; set; }
        public string nomeFil { get; set; }
    }

    public class Produto
    {
        public int codigoProd { get; set; }
        public string nomeProd { get; set; }
        public int qtdeEstoque { get; set; }
    }

    public class Venda
    {
        public int numVenda { get; set; }
        public int codigoProd { get; set; }
        public int qtdVenda { get; set; }
        public string vlrVenda { get; set; }
    }
}

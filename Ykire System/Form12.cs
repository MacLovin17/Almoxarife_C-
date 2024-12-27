using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ykire_System.Infra;

namespace Ykire_System
{
    public partial class Form12 : Form
    {
        public List<Cars> cars { get; private set; } = new List<Cars>();
        private CarsRepository _carsRepository;
        private bool ascendingOrder = true;
        public Form12()
        {
            InitializeComponent();
            lv_cars.ColumnClick += lv_cars_ColumnClick;
            _carsRepository = new CarsRepository();
            obterCars();
        }
        private void obterCars(string pesquisa = null)
        {
            cars = _carsRepository.Get(pesquisa);

            lv_cars.Items.Clear();
            foreach (var item in cars)
            {
                lv_cars.Items.Add(new ListViewItem(new String[] {
                    item.codigo.ToString(),
                    item.tag,
                    item.descricao,
                    item.placa,
                    item.ano,
                    item.crlv,
                    item.chassi,
                    item.renavam
                }));
            }

            if (cars.Count == 0)
            {
                MessageBox.Show("Nenhum registro encontrado.");
            }
        }
        private void AtualizarListView_Cars(List<Cars> cars)
        {
            lv_cars.Items.Clear();

            foreach (var item in cars)
            {
                lv_cars.Items.Add(new ListViewItem(new String[] {
                    item.codigo.ToString(),
                    item.tag,
                    item.descricao,
                    item.placa,
                    item.ano,
                    item.crlv,
                    item.chassi,
                    item.renavam
                }));
            }
        }
        private void lv_cars_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Verifica se o usuário clicou na segunda coluna (índice 1)
            if (e.Column == 2)
            {
                // Alterna entre crescente e decrescente
                if (ascendingOrder)
                    cars = cars.OrderBy(item => item.descricao).ToList();
                else
                    cars = cars.OrderByDescending(item => item.descricao).ToList();

                ascendingOrder = !ascendingOrder; // Alterna a ordem para o próximo clique
                AtualizarListView_Cars(cars);
            }
            if (e.Column == 1)
            {
                // Alterna entre crescente e decrescente
                if (ascendingOrder)
                    cars = cars.OrderBy(item => item.tag).ToList();
                else
                    cars = cars.OrderByDescending(item => item.tag).ToList();

                ascendingOrder = !ascendingOrder; // Alterna a ordem para o próximo clique
                AtualizarListView_Cars(cars);
            }

        }
        private void btnc_cad_veiculo_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = txt_matricula.Text;
                var tag = txt_tag.Text;
                var descricao = txt_desc_frota.Text;
                var placa = txt_placa.Text;
                var ano = txt_ano_frota.Text;
                var crlv = txt_crlv.Text;
                var chassi = txt_chassi.Text;
                var renavam = txt_renavam.Text;

                foreach (var item in cars)
                {
                    if (item.codigo.ToString() == codigo)
                        MessageBox.Show(codigo + "já está cadastrado no sistema.");
                }

                var car = new Cars(codigo, tag, descricao, placa, ano, crlv, chassi, renavam);
                cars.Add(car);

                var repository_cars = new CarsRepository();
                repository_cars.Add(car);

                lv_cars.Items.Add(new ListViewItem(new String[] { codigo, tag, descricao, placa, ano, crlv, chassi, renavam }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            txt_matricula.Text = "";
            txt_tag.Text = "";
            txt_desc_frota.Text = "";
            txt_placa.Text = "";
            txt_ano_frota.Text = "";
            txt_crlv.Text = "";
            txt_chassi.Text = "";
            txt_renavam.Text = "";

            MessageBox.Show("Veículo cadastrado");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lv_func_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            string textoPesquisa = txt_pesquisa_cars.Text.Trim();
            obterCars(textoPesquisa);
        }

        private void btn_pesquisa_Click_1(object sender, EventArgs e)
        {
            string textoPesquisa = txt_pesquisa_cars.Text.Trim();
            obterCars(textoPesquisa);
        }
    }
}

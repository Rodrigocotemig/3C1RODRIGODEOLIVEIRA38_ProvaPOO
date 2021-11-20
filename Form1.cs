using _3C1Rodrigo38_ProvaPOO.Code.DTO;
using _3C1Rodrigo38_ProvaPOO.Code.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1Rodrigo38_ProvaPOO
{
    public partial class Form1 : Form
    {
        SGBLL JOGOS_BLL = new SGBLL();
        SGDTO JOGOS_DTO = new SGDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = JOGOS_BLL.read();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JOGOS_DTO.JOGO = JogoTXT.Text;
            JOGOS_DTO.VALOR = Double.Parse(ValorTXT.Text);
            JOGOS_DTO.PLATAFORMA = PlataformaTXT.Text;
            JOGOS_BLL.create(JOGOS_DTO);
            dataGridView1.DataSource = JOGOS_BLL.read();
            MessageBox.Show("Jogo Adicionado com sucesso :D");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JOGOS_DTO.ID = int.Parse(IDTXT.Text);
            JOGOS_DTO.JOGO = JogoTXT.Text;
            JOGOS_DTO.VALOR = Double.Parse(ValorTXT.Text);
            JOGOS_DTO.PLATAFORMA = PlataformaTXT.Text;
            JOGOS_BLL.update(JOGOS_DTO);
            dataGridView1.DataSource = JOGOS_BLL.read();
            MessageBox.Show("Jogo Editado com sucesso :D");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JOGOS_DTO.ID = int.Parse(IDTXT.Text);
            JOGOS_BLL.destroy(JOGOS_DTO);
            dataGridView1.DataSource = JOGOS_BLL.read();
            MessageBox.Show("Jogo Deletado com sucesso :D");

        }
    }
}

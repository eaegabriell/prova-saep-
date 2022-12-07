using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace APPSaep
{
    public partial class FormPrincipal : Form
    {
        public static int valor = 0;
        public  static string texto = "";
        public FormPrincipal()
        {
            InitializeComponent();
            for (int i = 0; i < 12; i++)
            {
                check(i);
            }
        }



        public void check(int area)
        {
            SqlConnection con = ClassConnecta.ObterConexao();
            string query = "SELECT * FROM Alocacao WHERE area = '" + area + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                string color = "#0000FF";
                Color myColor = System.Drawing.ColorTranslator.FromHtml(color);
                if (area == 1)
                {
                    btn1.BackColor = myColor;
                    btn1.Enabled = true;
                }
                if (area == 2)
                {
                    btn2.BackColor = myColor;
                    btn2.Enabled = true;
                }
                if (area == 3)
                {
                    btn3.BackColor = myColor;
                    btn3.Enabled = true;
                }
                if (area == 4)
                {
                    btn4.BackColor = myColor;
                    btn4.Enabled = true;
                }
                if (area == 5)
                {
                    btn5.BackColor = myColor;
                    btn5.Enabled = true;
                }
                if (area == 6)
                {
                    btn6.BackColor = myColor;
                    btn6.Enabled = true;
                }
                if (area == 7)
                {
                    btn7.BackColor = myColor;
                    btn7.Enabled = true;
                }
                if (area == 8)
                {
                    btn8.BackColor = myColor;
                    btn8.Enabled = true;
                }
                if (area == 9)
                {
                    btn9.BackColor = myColor;
                    btn9.Enabled = true;
                }
                if (area == 10)
                {
                    btn10.BackColor = myColor;
                    btn10.Enabled = true;
                }
                if (area == 11)
                {
                    btn11.BackColor = myColor;
                    btn11.Enabled = true;
                }
            }
            else
            {

            }
        }

        public void btn10_Click(object sender, EventArgs e)
        {
            valor = 10;
            texto = "10";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            panelCarros.Visible = false;
            carregaCliente();
            panel1.Visible = false;
        }
        private void carrecaCBX(int area)
        {
            SqlConnection con = ClassConnecta.ObterConexao();
            string sql = "SELECT Automoveis.modelo FROM Alocacao inner join Automoveis ON Alocacao.Automovel = Automoveis.Id WHERE area='" + area + "' AND quantidade>0;";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Automoveis");
            cbxCarro.ValueMember = "Id";
            cbxCarro.DisplayMember = "modelo".Trim();
            cbxCarro.DataSource = ds.Tables["Automoveis"];
            con.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            valor = 3;
            texto = "3";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            valor = 5;
            texto = "5";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            valor = 2;
            texto = "2";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            valor = 7;
            texto = "7";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            valor = 4;
            texto = "4";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            valor = 9;
            texto = "9";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            valor = 8;
            texto = "8";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            valor = 11;
            texto = "11";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            valor = 1;
            texto = "1";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            valor = 6;
            texto = "6";
            panelBtn.Visible = false;
            carrecaCBX(valor);
            lblNumero.Text = texto;
            panelCarros.Visible = true;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carregaCliente()
        {
            SqlConnection con = ClassConnecta.ObterConexao();
            string sql = "SELECT * From Clientes ORDER BY nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Clientes");
            cbxCliente.ValueMember = "Id";
            cbxCliente.DisplayMember = "nome".Trim();
            cbxCliente.DataSource = ds.Tables["Clientes"];
            con.Close();
        }

        public void carregaconceci(int area, string modelo)
        {
            SqlConnection con = ClassConnecta.ObterConexao();
            string sql = "SELECT Concessionarias.concessionaria FROM Automoveis inner join Alocacao ON Automoveis.Id = Alocacao.Automovel INNER JOIN Concessionarias ON Alocacao.Concessionaria = Concessionarias.Id WHERE area='" + area + "' AND modelo='"+modelo+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Concessionarias");
            cbxCarro.ValueMember = "Id";
            cbxCarro.DisplayMember = "concessionaria".Trim();
            cbxCarro.DataSource = ds.Tables["Concessionarias"];
            con.Close();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            panelCarros.Visible = false;
            panel1.Visible = true;
            carregaconceci(valor,cbxCarro.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelBtn.Visible = true;
        }
    }
}
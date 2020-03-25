using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kilos;
        int precio;
        double dto;
        double producto1;
       double producto2;
        double producto3;
        



        private void button1_Click(object sender, EventArgs e)
        {
            lblproducto1.Text = txtProducto1.Text;
            lblproducto2.Text = txtProducto2.Text;
            lblproducto3.Text = txtProducto3.Text;

            producto1 = Convert.ToDouble(txtPrecio1.Text) * Convert.ToDouble(txtPeso1.Text);
            producto2 = Convert.ToDouble(txtPrecio2.Text) * Convert.ToDouble(txtPeso2.Text);
            producto3 = Convert.ToDouble(txtPrecio3.Text) * Convert.ToDouble(txtPeso3.Text);

            lblMuestrapre1.Text = Convert.ToString(producto1) +"  PESOS";
            lblMuestrapre2.Text = Convert.ToString(producto2) + "  PESOS";
            lblMuestrapre3.Text = Convert.ToString(producto3) + "  PESOS";
            dto = producto1 + producto2 + producto3;
            lblMuestrapreTotal.Text =Convert.ToString(dto) + "  PESOS";
            if (dto > 100)
            {
                label9lblMuestrapreTotalDto.Text = Convert.ToString(dto * 90 / 100) +" Pesos 10 % de descuento por su compra superior a $ 100  ";

            }
            else 
            {
                label9lblMuestrapreTotalDto.Text = "para su descuento debe superar los 100 pesos";
            }


        }
    }




     
    
}

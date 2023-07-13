using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoWindowsForm
{
    public partial class FrmFuentes : Form
    {
        Label lblTextoPrueba;
        TextBox txtTextoPrueba;
        Button btnAceptar;
        Panel panelVistaPrevia;
        Label lblVistaPrevia;
        Label lblTamaño;
        CheckBox chkNegrita;
        CheckBox chkCursiva;
        CheckBox chkSubrayado;
        

        NumericUpDown nudTamaño;
        public FrmFuentes()
        {
            InitializeComponent();

            chkNegrita = new CheckBox();
            chkNegrita.Text = "Negrita";
            chkNegrita.AutoSize = true;
            chkNegrita.Location = new Point(40, 100);
            chkNegrita.Click += chkNegrita_click;

            chkSubrayado = new CheckBox();
            chkSubrayado.Text = "Subrayado";
            chkSubrayado.AutoSize = true;
            chkSubrayado.Location = new Point(180, 100);
            chkSubrayado.Click += chkSubrayado_click;

            chkCursiva = new CheckBox();
            chkCursiva.Text = "Cursiva";
            chkCursiva.AutoSize = true;
            chkCursiva.Location = new Point(320, 100);
            chkCursiva.Click += chkCursiva_click;

            lblTextoPrueba = new Label();
            lblTextoPrueba.Text = "Texto de Prueba";
            lblTextoPrueba.Width = 200;
            lblTextoPrueba.Location = new Point(20, 20);

            txtTextoPrueba = new TextBox(); 
            txtTextoPrueba.Width=200;
            txtTextoPrueba.Location=new Point(220, 20);

            btnAceptar=new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Width = 100;
            btnAceptar.AutoSize = true;
            btnAceptar.Location = new Point(450, 20);
            btnAceptar.Click += btnAceptar_click;
            btnAceptar.MouseDown += btnAceptar_clickDerecho;

            lblVistaPrevia = new Label();

            panelVistaPrevia = new Panel();
            panelVistaPrevia.BorderStyle=BorderStyle.Fixed3D;
            AjustarAnchoYUbicacionDelPanelYEtiqueta(this, EventArgs.Empty);

            

            this.Resize += AjustarAnchoYUbicacionDelPanelYEtiqueta;

            lblTamaño= new Label();
            lblTamaño.Text = "Tamaño";
            lblTamaño.Width = 100;
            lblTamaño.Location= new Point(250, 160);
            
            nudTamaño=new NumericUpDown();
            nudTamaño.Value = 11;
            nudTamaño.Width = 100;
            nudTamaño.Location = new Point(250, 200);
            nudTamaño.ValueChanged += CambiarTamañoLabelPanel;



            panelVistaPrevia.Controls.Add(lblVistaPrevia);
            Controls.Add(panelVistaPrevia);
            Controls.Add(btnAceptar);
            Controls.Add(txtTextoPrueba);
            Controls.Add(lblTextoPrueba);
            Controls.Add(nudTamaño);
            Controls.Add(lblTamaño);
            Controls.Add(chkNegrita);
            Controls.Add(chkSubrayado);
            Controls.Add(chkCursiva);
        }

        private void chkCursiva_click(object? sender, EventArgs e)
        {
            AplicarEstilosYTamaño();
        }

        private void AplicarEstilosYTamaño()
        {
            FontStyle negrita = chkNegrita.Checked ? FontStyle.Bold : FontStyle.Regular;
            FontStyle cursiva = chkCursiva.Checked ? FontStyle.Italic : FontStyle.Regular;
            FontStyle subrayado = chkSubrayado.Checked ? FontStyle.Underline : FontStyle.Regular;
            FontStyle estilos= negrita | cursiva | subrayado;
            lblVistaPrevia.Font = new Font(lblVistaPrevia.Font.FontFamily, (float)nudTamaño.Value,estilos);
            
        }

        private void chkSubrayado_click(object? sender, EventArgs e)
        {
            AplicarEstilosYTamaño();
        }

        private void chkNegrita_click(object? sender, EventArgs e)
        {
            AplicarEstilosYTamaño();
        }

        private void btnAceptar_clickDerecho(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                MessageBox.Show("Se ha pulsado el clic derecho");
        }

        private void CambiarTamañoLabelPanel(object? sender, EventArgs e)
        {
            AplicarEstilosYTamaño();
        }

        private void btnAceptar_click(object? sender, EventArgs e)
        {
            lblVistaPrevia.Text=txtTextoPrueba.Text;
        }

        private void AjustarAnchoYUbicacionDelPanelYEtiqueta(object sender, EventArgs empty)
        {
            panelVistaPrevia.Width=this.Width-30;
            panelVistaPrevia.Location = new Point(5, this.Height-(panelVistaPrevia.Height+70));
            lblVistaPrevia.Width = panelVistaPrevia.Width;
            lblVistaPrevia.Height = panelVistaPrevia.Height;

        }
    }
}

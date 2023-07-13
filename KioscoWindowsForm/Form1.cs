namespace KioscoWindowsForm
{
    public partial class Form1 : Form
    {
        private TextBox txtNombre;
        private Button btnSalir;
        public Form1()
        {
            InitializeComponent();
            #region configuramos el textbox
            txtNombre = new TextBox();
            txtNombre.Text = "Estoy probando crear controles a mano";
            txtNombre.Width = 600;
            txtNombre.Font = new Font(txtNombre.Font.FontFamily, 14F, FontStyle.Bold);
            txtNombre.Location = new Point(100, 100);
            txtNombre.TextChanged += PonerTitulo;
            #endregion
            btnSalir = new Button();
            btnSalir.Text = "Salir";
            btnSalir.Width = 80;
            btnSalir.Height = 30;
            
            btnSalir.Click += btnSalir_Click;
            UbicarBotonSalir(this,EventArgs.Empty);
            this.Resize += UbicarBotonSalir;
            Controls.Add(txtNombre);
            Controls.Add(btnSalir);
        }

        private void UbicarBotonSalir(object? sender, EventArgs e)
        {
            btnSalir.Location = new Point(this.Width - (btnSalir.Width + 30), this.Height - (btnSalir.Height + 60));
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void PonerTitulo(object? sender, EventArgs e)
        {
            this.Text = txtNombre.Text;
        }
    }
}
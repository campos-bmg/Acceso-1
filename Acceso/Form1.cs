namespace Acceso
{
    public partial class Form1 : Form
    {
        public string defaultText = "Preparado para escanear...", emptyText = string.Empty;
        public Form1()
        {
            InitializeComponent();
            lblNombre.Text = defaultText;
            borrarTextos();
            
        }
        public void borrarTextos()
        {
            lblCarrera.Text = string.Empty;
            lblSemestre.Text = string.Empty;
            lblModalidad.Text = string.Empty;
            lblMatricula.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, imgAlumno.Width, imgAlumno.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 21;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            imgAlumno.Region = new Region(gp);
        }
    }
}
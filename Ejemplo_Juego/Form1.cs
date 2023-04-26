namespace Ejemplo_Juego
{
    public partial class Form1 : Form
    {
        int vel = 5;
        int posx, posy;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            posx = nave.Location.X;
            posy = nave.Location.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "x: " + posx.ToString() + "\ny: " + posy.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;
            tecla = char.ToUpper(tecla);

            if (tecla == 'W')
            {
                posy = posy - vel;
                nave.Location = new Point(posx, posy);
            }
            else if (tecla == 'S')
            {
                posy = posy + vel;
                nave.Location = new Point(posx, posy);
            }
            else if (tecla == 'A')
            {
                posx = posx - vel;
                nave.Location = new Point(posx, posy);
            }
            else if (tecla == 'D')
            {
                posx = posx + vel;
                nave.Location = new Point(posx, posy);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var tecla = e.KeyValue;
        }
    }
}
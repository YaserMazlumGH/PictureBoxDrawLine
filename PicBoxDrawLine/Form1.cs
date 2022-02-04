namespace PicBoxDrawLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, PaintEventArgs e)
        {
            Pen redPen = new Pen(Color.Red, 10);
            Pen bluePen = new Pen(Color.Blue, 6);
            Pen greenPen = new Pen(Color.Green, 24);
            Pen blackPen = new Pen(Color.Black, 14);

            float witdh = pictureBox1.Width;
            float height = pictureBox1.Height;

            Koord krd1 = new Koord { x1 = witdh * 0.08f, y1 = height * 0.24f, x2= witdh * 0.65f, y2= height * 0.40f };
            Koord krd2 = new Koord { x1 = witdh * 0.02f, y1 = height * 0.51f, x2 = witdh * 0.65f, y2 = height * 0.40f };
            Koord krd3 = new Koord { x1 = witdh * 0.03f, y1 = height * 0.86f, x2 = witdh * 0.65f, y2 = height * 0.40f };
            Koord krd4 = new Koord { x1 = witdh * 0.06f, y1 = height * 0.15f, x2 = witdh * 0.65f, y2 = height * 0.40f };


            DrawLine(redPen, krd1, e);
            DrawLine(bluePen, krd2, e);
            DrawLine(greenPen, krd3, e);
            DrawLine(blackPen, krd4, e);

        }

        public void DrawLine(Pen pen, Koord koordinatlar, PaintEventArgs p)
        {
            p.Graphics.DrawLine(pen, koordinatlar.x1, koordinatlar.y1, koordinatlar.x2, koordinatlar.y2);
        }

        public class Koord
        {
            public float x1 { get; set; }
            public float y1 { get; set; }
            public float x2 { get; set; }
            public float y2 { get; set; }
        }
    }
}
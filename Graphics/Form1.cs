
namespace Graphics
{
    using System.Drawing;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics=this.CreateGraphics();

            SolidBrush solidbrush=new SolidBrush(Color.Chocolate);
            SolidBrush solidbrush2=new SolidBrush(Color.Yellow);
            
            Pen pen=new Pen(solidbrush);

            // graphics.FillEllipse(solidbrush,new Rectangle(10,10,200,100));

            /*Rectangle rectangle = new Rectangle(10, 10, 200, 400);
            Region region = new Region(rectangle);
            graphics.FillRegion(solidbrush, region);*/


            //  graphics.FillPie(solidbrush2, new Rectangle(10, 10, 200, 200), 0, 90);
            // graphics.FillRectangle(solidbrush2,new RectangleF(10,10,200,100));

            graphics.DrawArc(pen, new Rectangle(10, 10, 200, 200), 0, 270);
        }
    }
}

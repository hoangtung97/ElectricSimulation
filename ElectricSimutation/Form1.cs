using MindFusion.Diagramming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricSimutation
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        Form form_2;
        public Form1()
        {
            InitializeComponent();
            btn_restoredown.Visible = false;
            btn_Openproperties.Visible = false;
            form_2 = new Form2();
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menu_home_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_fullscreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_restoredown.Visible = true;
            btn_fullscreen.Visible = false;
        }

        private void btn_restoredown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_fullscreen.Visible = true;
            btn_restoredown.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txb_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_project_Click(object sender, EventArgs e)
        {
            label_Menuname.Text = "Project";
            label_Menuname.Image = ElectricSimutation.Properties.Resources.PROJECT3;
        }

        private void btn_library_Click(object sender, EventArgs e)
        {
            label_Menuname.Text = "Library";
            label_Menuname.Image = ElectricSimutation.Properties.Resources.LIBRARY3;
        }

        private void btn_background_Click(object sender, EventArgs e)
        {
            //label_Menuname.Text = "Background";
            //label_Menuname.Image = ElectricSimutation.Properties.Resources.BACKGROUND3;      
                    
            form_2.Show();
            
        }

        private void btn_text_Click(object sender, EventArgs e)
        {
            label_Menuname.Text = "Text";
            label_Menuname.Image = ElectricSimutation.Properties.Resources.TEXT3;
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            label_Menuname.Text = "Help";
            label_Menuname.Image = ElectricSimutation.Properties.Resources.HELP3;
        }

        private void btn_option_Click(object sender, EventArgs e)
        {
            label_Menuname.Text = "Option";
            label_Menuname.Image = ElectricSimutation.Properties.Resources.OPTION3;
        }

        private void menu_Home_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            btn_Openproperties.Visible = true;
        }

        private void btn_Openproperties_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            btn_Openproperties.Visible = false;
        }

        #region create nodeshape image
        private void button3_Click(object sender, EventArgs e)
        {
            ShapeNode node = diagram1.Factory.CreateShapeNode(10, 10, 40, 20);
            node.Image = Image.FromFile(Environment.CurrentDirectory + @"\device\DC power supply.png");
            node.Transparent = true;
            node.ImageAlign = MindFusion.Drawing.ImageAlign.Fit;
        }

        private void Device_2_Click(object sender, EventArgs e)
        {
            ShapeNode node = diagram1.Factory.CreateShapeNode(10, 10, 40, 20);
            node.Image = Image.FromFile(Environment.CurrentDirectory + @"\device\Diesel generator.png");
            node.Transparent = true;
            node.ImageAlign = MindFusion.Drawing.ImageAlign.Fit;
        }

        private void Device_3_Click(object sender, EventArgs e)
        {
            ShapeNode node = diagram1.Factory.CreateShapeNode(10, 10, 40, 20);
            node.Image = Image.FromFile(Environment.CurrentDirectory + @"\device\Load cell.png");
            node.Transparent = true;
            node.ImageAlign = MindFusion.Drawing.ImageAlign.Fit;
        }

        private void Device_4_Click(object sender, EventArgs e)
        {
            ShapeNode node = diagram1.Factory.CreateShapeNode(10, 10, 40, 20);
            node.Image = Image.FromFile(Environment.CurrentDirectory + @"\device\Micro PLC 3.png");
            node.Transparent = true;
            node.ImageAlign = MindFusion.Drawing.ImageAlign.Fit;
        }

        private void Device_5_Click(object sender, EventArgs e)
        {
            ShapeNode node = diagram1.Factory.CreateShapeNode(10, 10, 40, 20);
            node.Image = Image.FromFile(Environment.CurrentDirectory + @"\device\Microchip.png");
            node.Transparent = true;
            node.ImageAlign = MindFusion.Drawing.ImageAlign.Fit;
        }

        private void Device_6_Click(object sender, EventArgs e)
        {
            ShapeNode node = diagram1.Factory.CreateShapeNode(10, 10, 40, 20);
            node.Image = Image.FromFile(Environment.CurrentDirectory + @"\device\Operator interface 1.png");
            node.Transparent = true;
            node.ImageAlign = MindFusion.Drawing.ImageAlign.Fit;
        }

        private void Device_7_Click(object sender, EventArgs e)
        {
            ShapeNode node = diagram1.Factory.CreateShapeNode(10, 10, 40, 20);
            node.Image = Image.FromFile(Environment.CurrentDirectory + @"\device\Power plant.png");
            node.Transparent = true;
            node.ImageAlign = MindFusion.Drawing.ImageAlign.Fit;
        }

        private void Device_8_Click(object sender, EventArgs e)
        {
            ShapeNode node = diagram1.Factory.CreateShapeNode(10, 10, 40, 20);
            node.Image = Image.FromFile(Environment.CurrentDirectory + @"\device\Rectifier 1.png");
            node.Transparent = true;
            node.ImageAlign = MindFusion.Drawing.ImageAlign.Fit;
        }

        #endregion

        #region properties

        

        bool firstClick = true;
        private void TextboxLine_Click(object sender, EventArgs e)
        {
            
            
            if (firstClick)
            {
                List<DiagramItem> ListItemDiagram = GetItemSelected();
                if (ListItemDiagram.Count == 1)
                {
                    if (ListItemDiagram[0].GetType() == typeof(DiagramLink))
                    {
                        TextboxLine.Text = ListItemDiagram[0].Text;
                    }
                }
                TextboxLine.SelectAll();
                firstClick = false;
            }
            
        }
        /// <summary>
        /// get all item seleted in diagram 
        /// </summary>
        /// <returns></returns>
        private List<DiagramItem> GetItemSelected()
        {
            List<DiagramItem> ListItemDiagram = new List<DiagramItem>();
            foreach (var item in diagram1.Items)
            {
                if (item.Selected == true)
                {
                    ListItemDiagram.Add(item);
                }
            }
            return ListItemDiagram;
        }
        private void TextboxLine_Leave(object sender, EventArgs e)
        {
            firstClick = !firstClick;
            List<DiagramItem> ListItemDiagram = GetItemSelected();
            if (ListItemDiagram.Count == 1)
            {
                if (ListItemDiagram[0].GetType() == typeof(DiagramLink))
                {
                    ListItemDiagram[0].Text = TextboxLine.Text;
                }
            }
        }

        private void diagram1_LinkSelected(object sender, LinkEventArgs e)
        {
             
            List<DiagramItem> ListItemDiagram = GetItemSelected();
            if (ListItemDiagram.Count == 1)
            {
                if (ListItemDiagram[0].GetType() == typeof(DiagramLink))
                {
                    try
                    {
                        TextboxLine.Text = ListItemDiagram[0].Text;
                        TextboxWidth.Text = ListItemDiagram[0].Pen.Width.ToString();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        
        private void diagram1_LinkCreated(object sender, LinkEventArgs e)
        {
            e.Link.Pen = new MindFusion.Drawing.Pen(Color.Blue, 0);
        }

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse
{
    public partial class Form1 : Form
    {
        public int xBound, yBound;
        public int xCurrent, yCurrent;
        List<Label> fields;
        List<string> history;
        string lastNode = "1";
        Timer timer;
        Random rnd;
        int moveCount = 1;
        int attempt = 0;
        bool isClosedPath = false;
        bool isRandPath = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            moveCount++;
            
            timer = new Timer();
            timer.Interval = (int)n_speed.Value;
            timer.Tick += OnTick;
            timer.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }

        private void btn_populateField_Click(object sender, EventArgs e)
        {
            fields = new List<Label>();
            Panel_Field.Controls.Clear();
            xBound =(int)n_X.Value;
            yBound = (int)n_Y.Value;
            Size size = new Size(Panel_Field.Size.Width / xBound -10 , Panel_Field.Size.Height / yBound - 10 );
            for (int i = 1; i <= yBound; i++)
            {
                for (int j = 1; j <= xBound; j++)
                {
                    Label l = new Label();
                    l.Name = string.Format("{0}_{1}",j,i);
                    l.Size = size;
                    l.Text = "";
                    l.BorderStyle = BorderStyle.Fixed3D;
                    l.BackColor = Color.LightGray;
                    l.Click += onClick;
                    fields.Add(l);
                    Panel_Field.Controls.Add(l);
                }

            }


        }


        void onClick(object sender, EventArgs e) {
            if (checkBox1.Checked)
            {
                foreach (Label field in fields)
                {
                    field.BackColor = Color.LightGray;
                    field.Text = "";
                }
                Label l = (Label)sender;
                l.BackColor = Color.Orange;
                l.Text = moveCount.ToString();
                string[] coord = l.Name.Split('_');
                xCurrent = Convert.ToInt32(coord[0]);
                yCurrent = Convert.ToInt32(coord[1]);
                Console.WriteLine(xCurrent + "_" + yCurrent);
            }
        }

        void OnTick(object sender, EventArgs e)
        {
            if (isRandPath)
            MoveHorseRandom();
        }

        void MoveHorseRandom()
        {

            int x = 0, y = 0;
            int xNext = xCurrent, yNext = yCurrent;
            while (!checkForFieldHistory(xNext, yNext))
            {
                x = 0;
                xNext = xCurrent;
                yNext = yCurrent;
                while(x == 0)
                {
                    x = rnd.Next(-2, 3);
                } 
                switch (x)
                {
                    case 1:
                        y = getSign(2);
                        break;
                    case 2:
                        y = getSign(1);
                        break;
                    case -1:
                        y = getSign(2);
                        break;
                    case -2:
                        y = getSign(1);
                        break;
                }
                xNext += x;
                yNext += y;
                Console.WriteLine(string.Format("{0}_{1}", x, y));
                attempt++;
                if (attempt == 150)
                {
                    isRandPath = false;
                    return;
                }
            }
            //Console.WriteLine(string.Format("{0}_{1}", xNext, yNext));
            attempt = 0;
            foreach (Label field in fields)
            {
                if (field.Name == string.Format("{0}_{1}", xNext, yNext))
                {
                    field.BackColor = Color.Orange;
                    field.Text = moveCount.ToString();
                    moveCount++;
                    xCurrent = xNext;
                    yCurrent = yNext;
                }
                else
                    field.BackColor = Color.LightGray;
            }

        }

        bool checkForFieldHistory(int x, int y)
        {
            if (x < 1 || x >= xBound + 2) return false;
            else if (y < 1 || y >= yBound + 2) return false;
            Label l = fields.Find(p => p.Name == string.Format("{0}_{1}", x, y));
            if (l == null || l.Text != "") return false;
            else return true;
        }

        int getSign(int number)
        {
            int r = rnd.Next(0, 2);
            switch (r)
            {
                case 0:
                    return number;

                case 1:
                    return number = Convert.ToInt32("-"+number);
            }
            return number;
        }

        void reOrginizePath()
        {
            Label node = fields.Find(p => p.Text == string.Format("{0}", lastNode));
            int xNode;
            int yNode;
            for (int j = history.Count - 1; j > 0; j--)
                {
                Label cmp = fields.Find(p => p.Text == string.Format("{0}", history[j]));
                xCmp;
                yCmp;
                
                }
            
        }
    }
}

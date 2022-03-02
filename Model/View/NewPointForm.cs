using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class NewPointForm : Form
    {
        public IPointMoveInterface point;
        public NewPointForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Если кликнули левой - то координаты точки
            if (e.Button == MouseButtons.Left)
            {
                //Задать координаты точки одним кликом
                //нельзя задать отридцательные координаты или координаты за пределами pictureBox
                XNumericUpDown.Value = e.X;
                YNumericUpDown.Value = e.Y;
            }
            else//если не левой
            {
                //и выбран режим колебательной точки, то ставим координаты центра колебаний
                if(comboBox1.Text == "Oscillatory")
                {
                    CenterYNumericUpDown.Value = e.Y;
                    CenterXNumericUpDown.Value = e.X;
                }
            }
        }

        private void NewPointForm_Load(object sender, EventArgs e)
        {
            //Выключаю кнопку когда не отладочный режим
#if !DEBUG
            RandomButton.Visible = false;
#endif

            //Если ее не вызвать, то при клике "Добавить" сразу после открытия окна программа падает
            XNumericUpDown_ValueChanged(sender, e);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Linear")
            {
                AcceleratedGroupBox.Visible = false;
                OcillatoryGroupBox.Visible = false;
                LinearGroupBox.Visible = true;
                groupBox2.Text = "Click to Set Point Coord";
            }
            if (comboBox1.Text == "Accelerated")
            {
                AcceleratedGroupBox.Visible = true;
                OcillatoryGroupBox.Visible = false;
                LinearGroupBox.Visible = false;
                groupBox2.Text = "Click to Set Point Coord";
                //перемещу показанный групбокс в позицию Равноускоренного. 
                //только чтобы выглядело красиво
                AcceleratedGroupBox.Location = LinearGroupBox.Location;
            }
            if (comboBox1.Text == "Oscillatory")
            {
                AcceleratedGroupBox.Visible = false;
                OcillatoryGroupBox.Visible = true;
                LinearGroupBox.Visible = false;
                groupBox2.Text = "Left Click to Set Point Coord and Right Click to Set Center Point for Oscillatory";
                //перемещу показанный групбокс в позицию Равноускоренного. 
                //только чтобы выглядело красиво
                OcillatoryGroupBox.Location = LinearGroupBox.Location;
            }

        }

        private void XNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //создание объекта точки
                if (comboBox1.Text == "Linear")
                {
                    LinearPointMove lPoint = new LinearPointMove();
                    //приходится приводить тип децимал из NumericUpDown в тип int
                    //(int) - это и есть приведение типов
                    lPoint.X = (int)XNumericUpDown.Value;
                    lPoint.Y = (int)YNumericUpDown.Value;
                    lPoint.SpeedX = (int)SpeedXNumericUpDown.Value;
                    lPoint.SpeedY = (int)SpeedYNumericUpDown.Value;
                    point = lPoint;

                }
                if (comboBox1.Text == "Accelerated")
                {
                    AcceleraatedPointMove aPoint = new AcceleraatedPointMove();
                    //приходится приводить тип децимал из NumericUpDown в тип int
                    //(int) - это и есть приведение типов
                    aPoint.X = (int)XNumericUpDown.Value;
                    aPoint.Y = (int)YNumericUpDown.Value;
                    aPoint.AccelerateX = (int)AccelerationXNumericUpDown.Value;
                    aPoint.AccelerateY = (int)AccelerationYNumericUpDown3.Value;
                    point = aPoint;
                }
                if (comboBox1.Text == "Oscillatory")
                {
                    OscillatoryPointMove oPoint = new OscillatoryPointMove();
                    //приходится приводить тип децимал из NumericUpDown в тип int
                    //(int) - это и есть приведение типов
                    oPoint.X = (int)XNumericUpDown.Value;
                    oPoint.Y = (int)YNumericUpDown.Value;
                    oPoint.TargetX = (int)CenterXNumericUpDown.Value;
                    oPoint.TargetY = (int)CenterYNumericUpDown.Value;
                    point = oPoint;
                }
            }
            catch(ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message, "неправильно указано значение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //обновить picturebox - обновление происходит в PictureBox.Paint
            //когда обновление было здесь - иногда не рисовалось
            pictureBox1.Invalidate();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            comboBox1.SelectedIndex = random.Next(3);

            XNumericUpDown.Value = random.Next(100,200);
            YNumericUpDown.Value = random.Next(100, 200);
            AccelerationXNumericUpDown.Value = random.Next(1,5);
            AccelerationYNumericUpDown3.Value = random.Next(1,5);
            SpeedXNumericUpDown.Value = random.Next(10);
            SpeedYNumericUpDown.Value = random.Next(10);
            CenterXNumericUpDown.Value = random.Next(100, 200);
            CenterYNumericUpDown.Value = random.Next(100, 200);
            ParametrNumericUpDown.Value = random.Next(2,10);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //взять граффику для пикчебокса
            Graphics g =e.Graphics;
            g.Clear(BackColor);//очистить пикчебокс
            //нарисовать точку
            g.DrawEllipse(Pens.Black, (int)XNumericUpDown.Value, (int)YNumericUpDown.Value, 3, 3);
            if (comboBox1.Text == "Oscillatory")
            {
                //нарисовать точку
                g.FillEllipse(Brushes.Black, (int)CenterXNumericUpDown.Value, (int)CenterYNumericUpDown.Value, 3, 3);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           // Close();
           //форму не надо закрывать достаточно пометить у кнопки свойсво DialogResult
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Close();
            //форму не надо закрывать достаточно пометить у кнопки свойсво DialogResult
        }
    }
}

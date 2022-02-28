using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FindForm : Form
    {
        //сюда передам список для поиска в нем
        public List<Model.IPointMoveInterface> pointList;
        public FindForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Чищу грид
            dataGridView1.Rows.Clear();

            //Добавляю в него все списка
            foreach (Model.IPointMoveInterface p in pointList)
            {
                //только если точка удовлетворяет условию
                //поле не равно 0 и хоордината равна значению поля
                if ((XNumericUpDown.Value != 0 && XNumericUpDown.Value == p.X) ||
                    (YNumericUpDown.Value != 0 && YNumericUpDown.Value == p.Y) ||
                    (YNumericUpDown.Value == 0 && XNumericUpDown.Value == 0))
                {
                    string type = "";
                    if (p.GetType() == typeof(Model.LinearPointMove))
                        type = "Linear";
                    if (p.GetType() == typeof(Model.AcceleraatedPointMove))
                        type = "Accelerated";
                    if (p.GetType() == typeof(Model.OscillatoryPointMove))
                        type = "Oscillatory";
                    dataGridView1.Rows.Add(type, p.X, p.Y);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace View
{
    public partial class Form1 : Form
    {
        //список
        List<Model.IPointMoveInterface> pointList = new List<Model.IPointMoveInterface>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            NewPointForm newPointForm = new NewPointForm();
            //вызываю форму ввода точки
            if (newPointForm.ShowDialog() == DialogResult.OK)
            {
                //Если в форме нажали 
                pointList.Add(newPointForm.point);
            }
            GridUpdate();
        }
        //этот метод обновит данные в гриде по списку точек
        private void GridUpdate()
        {
            //Чищу грид
            dataGridView1.Rows.Clear();

            //Добавляю в него все точки из списка
            foreach (Model.IPointMoveInterface p in pointList)
            {
                string type="";
                if (p.GetType() == typeof(Model.LinearPointMove))
                    type = "Linear";
                if (p.GetType() == typeof(Model.AcceleraatedPointMove))
                    type = "Accelerated";
                if (p.GetType() == typeof(Model.OscillatoryPointMove))
                    type = "Oscillatory";
                dataGridView1.Rows.Add(type, p.X,p.Y);
            }
            //Обновить пикчебокс
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //перебрать все точки и нарисовать
            foreach (Model.IPointMoveInterface p in pointList)
            {
                e.Graphics.DrawEllipse(Pens.Black, p.X, p.Y, 3, 3);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //передвинуть все точки
            foreach (Model.IPointMoveInterface p in pointList)
            {
                p.MovePoint();
            }
            //обновить значения их координат в гриде и нарисовать
            GridUpdate();
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //запустить таймер отображения движения точек
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //остановить таймер отображения движения точек
            timer1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Вызвать диалог и если пользователь нажал ОК
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //xmlserializer не хочет сериализовать интерфейс
                //binaryFormatter - устарел, так пишет visual Studio
                //буду делать через json
                string _filePath = saveFileDialog1.FileName;//@"c:\11.txt";


                //Сначала соберу список всех точек уже в сериализованном виде
                //чтобы при десериализации выяснить тип - добавляю поле только для чтения которое возвращает тип
                //Это поле ддобавлено в каждый класс
                List<string> serielizedObj = new List<string>();
                foreach (Model.IPointMoveInterface p in pointList)
                {
                    //Это нужно только для нормальной сериализации
                    //без приведения сериализуются только координаты
                    //соответственно определяю тип каждой точки, привожу точку к этому типу и сериализую ее
                    if (p.GetType() == typeof(Model.LinearPointMove))
                    {
                        string serialized = System.Text.Json.JsonSerializer.Serialize((Model.LinearPointMove)p);
                        serielizedObj.Add(serialized);
                    }
                    if (p.GetType() == typeof(Model.AcceleraatedPointMove))
                    {
                        string serialized = System.Text.Json.JsonSerializer.Serialize((Model.AcceleraatedPointMove)p);
                        serielizedObj.Add(serialized);
                    }
                    if (p.GetType() == typeof(Model.OscillatoryPointMove))
                    {
                        string serialized = System.Text.Json.JsonSerializer.Serialize((Model.OscillatoryPointMove)p);
                        serielizedObj.Add(serialized);
                    }
                }
                //сохраняю в файл
                using (FileStream fs = new FileStream(_filePath, FileMode.OpenOrCreate))
                {
                    System.Text.Json.JsonSerializer.Serialize(fs, serielizedObj);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Вызвать диалог и если пользователь нажал ОК
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string _filePath = openFileDialog1.FileName;

                //сначала получаю строки
                List<string> serielizedObj = new List<string>();
                using (FileStream fs = new FileStream(_filePath, FileMode.OpenOrCreate))
                {

                    serielizedObj = System.Text.Json.JsonSerializer.Deserialize<List<string>>(fs);
                }
                //чищу список точек
                pointList.Clear();
                //прохожусь по всем строкам
                foreach (string s in serielizedObj)
                {
                    //если строка содежит название класса, то создаю объект этого красса
                    //десериализую строку а этот объект
                    //и добавляю этот объект в список точек.
                    if (s.Contains("LinearPointMove"))
                    {
                        Model.LinearPointMove point = System.Text.Json.JsonSerializer.Deserialize<Model.LinearPointMove>(s);
                        pointList.Add(point);
                    }
                    if (s.Contains("AcceleraatedPointMove"))
                    {
                        Model.AcceleraatedPointMove point = System.Text.Json.JsonSerializer.Deserialize<Model.AcceleraatedPointMove>(s);
                        pointList.Add(point);
                    }
                    if (s.Contains("OscillatoryPointMove"))
                    {
                        Model.OscillatoryPointMove point = System.Text.Json.JsonSerializer.Deserialize<Model.OscillatoryPointMove>(s);
                        pointList.Add(point);
                    }
                }
                //обновляю список точек
                GridUpdate();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //создам форму
            FindForm fnfrm = new FindForm();
            //передам в нее список точек
            fnfrm.pointList = pointList;
            //покажу форму, она уже сама разберется
            fnfrm.Show();

        }
    }
}

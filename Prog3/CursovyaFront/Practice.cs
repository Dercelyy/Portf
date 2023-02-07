using CursovyaFront.Properties;
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

namespace CursovyaFront
{
    public partial class Practice : Form
    {
        DrawGraph G;
        List<Vertex> V;
        List<Edge> E;

        public Practice()
        {
            InitializeComponent();

            V = new List<Vertex>();
            E = new List<Edge>();
            G = new DrawGraph(sheet.Width, sheet.Height);

            dataGridView1.RowCount = 8;
            dataGridView1.ColumnCount = 8;
            for (int i = 0; (i <= (dataGridView1.Rows.Count - 1)); i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = string.Format("X" + (i + 1).ToString(), "0");
            }
        }

        Random r = new Random();
        List<int> arrRand = new List<int> { };

        List<int[,]> matrixSmejn = new List<int[,]> { };
        List<int[,]> coordVert = new List<int[,]> { };
        List<int> vertForDraw = new List<int> { };
        List<int> edgeForDraw = new List<int> { };
        List<int> reversPaths = new List<int> { };

        int rand = 0;
        int temp = 0;
        int step = 0;
        int kError = 0;
        string strFW;
        int minPut;
        int kMinPaths;
        string textProtocol;

        private void button1_Click(object sender, EventArgs e)
        {
            Form fr1 = Application.OpenForms[0];
            this.Hide();
            fr1.Show();
        }

        private void Practice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form fr1 = Application.OpenForms[0];
            this.Hide();
            fr1.Show();
        }

        private void Practice_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Орграф G=(X,U) задан матрице смежности.\n" +
                "Требуется определить:\n" +
                "a) Длины минимальных путей из X1 в достижимые вершины орграфа G;\n" +
                "b) Минимальный путь из X1 в X8 в орграфе G;\n" +
                "c) Общее число минимальных путей из X1 в X8 в орграфе G.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for(int i = 0; i < Data.visitedArr.Count; i++)
            {
                arrRand.Add(Data.visitedArr[i]);
            }

            fillGraf();
            newGraf();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool well = false;

            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                switch (step)
                {
                    case 0:
                        {
                            button1.Enabled = false;
                            if (strFW.Length == Convert.ToInt32(textBox1.Text))
                            {
                                for (int i = 0; i < textBox2.Text.Length; i++)
                                {
                                    if (strFW.Contains(textBox2.Text[i]))
                                    {
                                        well = true;
                                    }
                                    else
                                    {
                                        well = false;
                                        break;
                                    }
                                }
                                if (well)
                                {
                                    step++;
                                    RandGraf(rand);
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    label1.Text = "Введите количество вершин FW2:";

                                    minPath();

                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Введены неверные индексы вершин FW1!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    kError++;
                                    textProtocol += ("\nОшибка № " + kError+ " - Введены неверные индексы вершин FW1!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Введено неверное количество вершин FW1!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                kError++;
                                textProtocol += ("\nОшибка № " + kError + " - Введено неверное количество вершин FW1!");
                            }
                            break;
                        }
                    case 1:
                        {
                            if (strFW.Length == Convert.ToInt32(textBox1.Text))
                            {
                                for (int i = 0; i < textBox2.Text.Length; i++)
                                {
                                    if (strFW.Contains(textBox2.Text[i]))
                                    {
                                        well = true;
                                    }
                                    else
                                    {
                                        well = false;
                                        break;
                                    }
                                }
                                if (well)
                                {
                                    step++;
                                    RandGraf(rand);
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    label1.Text = "Введите количество вершин FW3:";
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Введены неверные индексы вершин FW2!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    kError++;
                                    textProtocol += ("\nОшибка № " + kError + " - Введены неверные индексы вершин FW2!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Введено неверное количество вершин FW2!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                kError++;
                                textProtocol += ("\nОшибка № " + kError + " - Введено неверное количество вершин FW2!");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (strFW.Length == Convert.ToInt32(textBox1.Text))
                            {
                                for (int i = 0; i < textBox2.Text.Length; i++)
                                {
                                    if (strFW.Contains(textBox2.Text[i]))
                                    {
                                        well = true;
                                    }
                                    else
                                    {
                                        well = false;
                                        break;
                                    }
                                }
                                if (well)
                                {
                                    step++;
                                    RandGraf(rand);
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    label1.Text = "Введите количество вершин FW4:";
                                }
                                else
                                {
                                    MessageBox.Show("Введены неверные индексы вершин FW3!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    kError++;
                                    textProtocol += ("\nОшибка № " + kError + " - Введены неверные индексы вершин FW3!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Введено неверное количество вершин FW3!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                kError++;
                                textProtocol += ("\nОшибка № " + kError + " - Введено неверное количество вершин FW3!");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (strFW.Length == Convert.ToInt32(textBox1.Text))
                            {
                                for (int i = 0; i < textBox2.Text.Length; i++)
                                {
                                    if (strFW.Contains(textBox2.Text[i]))
                                    {
                                        well = true;
                                    }
                                    else
                                    {
                                        well = false;
                                        break;
                                    }
                                }
                                if (well)
                                {
                                    //step = 4, последний уровень графа
                                    step++;
                                    RandGraf(rand);

                                    label1.Text = "Длина минимального пути X1->X8:";
                                    label2.Text = "Определите обратный минимальный путь от X8->X1";
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("Введены неверные индексы вершин FW4!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    kError++;
                                    textProtocol += ("\nОшибка № " + kError + " - Введены неверные индексы вершин FW4!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Введено неверное количество вершин FW4!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                kError++;
                                textProtocol += ("\nОшибка № " + kError + " - Введено неверное количество вершин FW4!");
                            }
                            break;
                        }
                    case 4:
                        {
                            minPath();
                            if(Convert.ToInt32(textBox1.Text) == minPut)
                            {
                                if(textBox2.Text.Length == 0)
                                {
                                    well = false;
                                }
                                else
                                {
                                    for (int i = 0; i < reversPaths.Count; i++)
                                    {
                                        if (reversPaths[i] == Convert.ToInt32(textBox2.Text))
                                        {
                                            well = true;
                                            break;
                                        }
                                        else
                                        {
                                            well = false;
                                        }
                                    }
                                }
                                if(well)
                                {
                                    //step = 5
                                    step++;
                                    RandGraf(rand);

                                    label1.Text = "Введите общее число минимальных путей из X1 в X8:";
                                    label2.Text = "";
                                    textBox1.Text = "";
                                    textBox2.Text = "-";
                                    textBox2.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Введен неверный минимальный путь X8-X1!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    kError++;
                                    textProtocol += ("\nОшибка № " + kError + " - Введен неверный минимального путь X8-X1!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Введена неверная длина минимального пути!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                kError++;
                                textProtocol += ("\nОшибка № " + kError + " - Введена неверная длина минимального пути!");
                            }

                            break;
                        }
                    case 5:
                        {
                            minPath();
                            if (Convert.ToInt32(textBox1.Text) == kMinPaths)
                            {
                                if (temp == 3)
                                {
                                    if (MessageBox.Show("Вы выполнили 3 упражнения по нахождению Фронта волны, далее необходимо сохранить протокол.", "Сообщение", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                                    {
                                        button1.Enabled = true;
                                        this.Hide();
                                        Protocol protocolForm = new Protocol();
                                        protocolForm.ShowDialog();

                                    }
                                }
                                else
                                {
                                    if (MessageBox.Show("Вы выполнили упражнение.\nДля перехода к следующему упражнению нажмите - Да.\nДля выхода в главное меню нажмите - Нет." +
                                    "", "Сообщение", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        textProtocol += ("\nВсего ошибок: " + kError);
                                        textProtocol += ("\n");
                                        Data.text += textProtocol;

                                        button1.Enabled = true;
                                        kError = 0;
                                        label1.Text = "Введите количество вершин FW1:";
                                        label2.Text = "Ведите индексы вершин без пробелов:";
                                        textBox1.Text = "";
                                        textBox2.Text = "";
                                        textBox2.Enabled = true;
                                        step++;
                                        RandGraf(rand);
                                    }
                                    else
                                    {
                                        textProtocol += ("\nВсего ошибок: " + kError);
                                        textProtocol += ("\n");
                                        Data.text += textProtocol;

                                        button1.Enabled = true;
                                        label1.Text = "Введите количество вершин FW1:";
                                        label2.Text = "Ведите индексы вершин без пробелов:";
                                        textBox1.Text = "";
                                        textBox2.Text = "";
                                        textBox2.Enabled = true;

                                        Form fr1 = Application.OpenForms[0];
                                        this.Hide();
                                        fr1.Show();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Введено неверное количество минимальных путей!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                kError++;
                                textProtocol += ("\nОшибка № " + kError + " - Введено неверное количество минимальных путей!");
                            }
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Поля не могут быть пустыми!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void newGraf()
        {
            if (temp < 10)
            {
                rand = r.Next(0, 10);
                RandGraf(rand);
                richTextBox1.AppendText("\nГраф №: " + (rand + 1));
                textProtocol += ("\nГраф №: " + (rand + 1));
                temp++;
            }
            else
            {
                MessageBox.Show("Вы выполнили все упражнения!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void RandGraf(int random)
        {
            if (!arrRand.Contains(random))
            {
                rand = random;

                if(step == 0)
                {
                    strFW = "";
                    for (int k = 0; k < 8; k++)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            dataGridView1.Rows[k].Cells[l].Value = matrixSmejn[random][k, l];
                        }
                    }

                    coordGraf(random);
                    G.drawVertex(V[0].x, V[0].y, (0 + 1).ToString());
                    vertForDraw.Add(0);
                    
                    for (int l = 0; l < 8; l++)
                    {
                        if (matrixSmejn[random][0, l] == 1)
                        {
                            vertForDraw.Add(l);
                            strFW += (l+1).ToString();
                        }
                    }
                    
                    for (int k = 0; k < E.Count; k++)
                    {
                        if (E[k].v1 == vertForDraw[0])
                        {
                            edgeForDraw.Add(k);
                        }
                    }
                }

                if(step == 1)
                {
                    dravGraf(random);
                }

                if(step == 2)
                {
                    dravGraf(random);
                }

                if (step == 3)
                {
                    dravGraf(random);
                }

                if (step == 4)
                {
                    dravGraf(random);
                }
                if(step == 6)
                {
                    G.clearSheet();
                    vertForDraw.Clear();
                    edgeForDraw.Clear();
                    arrRand.Add(random);
                    Data.visitedArr.Add(random);
                    step = 0;
                    newGraf();
                }
                sheet.Image = G.GetBitmap();
            }
            else
            {
                random = r.Next(0, 10);
                RandGraf(random);
            }
        }

        public void dravGraf(int rnd)
        {
            strFW = "";
            for (int i = 0; i < vertForDraw.Count; i++)
            {
                G.drawVertex(V[vertForDraw[i]].x, V[vertForDraw[i]].y, (vertForDraw[i] + 1).ToString());
            }

            for (int j = 0; j < edgeForDraw.Count; j++)
            {
                G.drawEdge(V[E[edgeForDraw[j]].v1], V[E[edgeForDraw[j]].v2], E[edgeForDraw[j]]);
            }

            int countVert = vertForDraw.Count;

            for (int n = 0; n < countVert; n++)
            {
                for (int p = 0; p < 8; p++)
                {
                    if (matrixSmejn[rnd][vertForDraw[n], p] == 1 && !vertForDraw.Contains(p))
                    {
                        vertForDraw.Add(p);
                        strFW += (p+1).ToString();

                        for (int k = 0; k < E.Count; k++)
                        {
                            if (E[k].v2 == p)
                            {
                                edgeForDraw.Add(k);
                            }
                        }
                    }
                }
            }
        }

        public void coordGraf(int rand)
        {
            V.Clear();
            E.Clear();
            switch (rand)
            {
                case 0:
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            V.Add(new Vertex(coordVert[0][0, i], coordVert[0][1, i]));
                        }
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                if (matrixSmejn[0][k, l] == 1)
                                {
                                    E.Add(new Edge(k, l));
                                }
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            V.Add(new Vertex(coordVert[1][0, i], coordVert[1][1, i]));
                        }
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                if (matrixSmejn[1][k, l] == 1)
                                {
                                    E.Add(new Edge(k, l));
                                }
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            V.Add(new Vertex(coordVert[2][0, i], coordVert[2][1, i]));
                        }
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                if (matrixSmejn[2][k, l] == 1)
                                {
                                    E.Add(new Edge(k, l));
                                }
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            V.Add(new Vertex(coordVert[3][0, i], coordVert[3][1, i]));
                        }
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                if (matrixSmejn[3][k, l] == 1)
                                {
                                    E.Add(new Edge(k, l));
                                }
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            V.Add(new Vertex(coordVert[4][0, i], coordVert[4][1, i]));
                        }
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                if (matrixSmejn[4][k, l] == 1)
                                {
                                    E.Add(new Edge(k, l));
                                }
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            V.Add(new Vertex(coordVert[5][0, i], coordVert[5][1, i]));
                        }
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                if (matrixSmejn[5][k, l] == 1)
                                {
                                    E.Add(new Edge(k, l));
                                }
                            }
                        }
                        break;
                    }
                case 6:
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            V.Add(new Vertex(coordVert[6][0, i], coordVert[6][1, i]));
                        }
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                if (matrixSmejn[6][k, l] == 1)
                                {
                                    E.Add(new Edge(k, l));
                                }
                            }
                        }
                        break;
                    }
                case 7:
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            V.Add(new Vertex(coordVert[7][0, i], coordVert[7][1, i]));
                        }
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                if (matrixSmejn[7][k, l] == 1)
                                {
                                    E.Add(new Edge(k, l));
                                }
                            }
                        }
                        break;
                    }
                case 8:
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            V.Add(new Vertex(coordVert[8][0, i], coordVert[8][1, i]));
                        }
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                if (matrixSmejn[8][k, l] == 1)
                                {
                                    E.Add(new Edge(k, l));
                                }
                            }
                        }
                        break;
                    }
                case 9:
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            V.Add(new Vertex(coordVert[9][0, i], coordVert[9][1, i]));
                        }
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                if (matrixSmejn[9][k, l] == 1)
                                {
                                    E.Add(new Edge(k, l));
                                }
                            }
                        }
                        break;
                    }
            }
        }
        
        public void minPath()
        {
            minPut = 0;
            reversPaths.Clear();
            kMinPaths = 0;

            switch(rand)
            {
                case 0:
                    {
                        minPut = 4;
                        reversPaths.Add(82361);
                        reversPaths.Add(84761);
                        reversPaths.Add(85761);
                        reversPaths.Add(85361);
                        kMinPaths = reversPaths.Count;
                        break;
                    }
                case 1:
                    {
                        minPut = 4;
                        reversPaths.Add(85231);
                        reversPaths.Add(86431);
                        reversPaths.Add(87431);
                        reversPaths.Add(86231);
                        reversPaths.Add(85431);
                        kMinPaths = reversPaths.Count;
                        break;
                    }
                case 2:
                    {
                        minPut = 4;
                        reversPaths.Add(84231);
                        reversPaths.Add(84651);
                        reversPaths.Add(84631);
                        reversPaths.Add(87651);
                        reversPaths.Add(87231);
                        reversPaths.Add(87631);
                        kMinPaths = reversPaths.Count;
                        break;
                    }
                case 3:
                    {
                        minPut = 4;
                        reversPaths.Add(82651);
                        reversPaths.Add(82751);
                        reversPaths.Add(83751);
                        reversPaths.Add(83651);
                        reversPaths.Add(84651);
                        kMinPaths = reversPaths.Count;
                        break;
                    }
                case 4:
                    {
                        minPut = 4;
                        reversPaths.Add(83421);
                        reversPaths.Add(83721);
                        reversPaths.Add(85421);
                        reversPaths.Add(86421);
                        reversPaths.Add(86721);
                        kMinPaths = reversPaths.Count;
                        break;
                    }
                case 5:
                    {
                        minPut = 4;
                        reversPaths.Add(84521);
                        reversPaths.Add(84371);
                        reversPaths.Add(84571);
                        reversPaths.Add(86371);
                        reversPaths.Add(86521);
                        reversPaths.Add(86571);
                        kMinPaths = reversPaths.Count;
                        break;
                    }
                case 6:
                    {
                        minPut = 4;
                        reversPaths.Add(84251);
                        reversPaths.Add(84371);
                        reversPaths.Add(84251);
                        reversPaths.Add(86251);
                        reversPaths.Add(86271);
                        reversPaths.Add(86371);
                        kMinPaths = reversPaths.Count;
                        break;
                    }
                case 7:
                    {
                        minPut = 4;
                        reversPaths.Add(84321);
                        reversPaths.Add(84361);
                        reversPaths.Add(84761);
                        reversPaths.Add(84721);
                        kMinPaths = reversPaths.Count;
                        break;
                    }
                case 8:
                    {
                        minPut = 4;
                        reversPaths.Add(82531);
                        reversPaths.Add(82631);
                        reversPaths.Add(84531);
                        reversPaths.Add(84631);
                        reversPaths.Add(87631);
                        kMinPaths = reversPaths.Count;
                        break;
                    }
                case 9:
                    {
                        minPut = 4;
                        reversPaths.Add(82531);
                        reversPaths.Add(82631);
                        reversPaths.Add(84531);
                        reversPaths.Add(84631);
                        reversPaths.Add(87631);
                        kMinPaths = reversPaths.Count;
                        break;
                    }
            }
            
        }

        public void fillGraf()
        {
            int[,] myArr1 = {
                {0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 1, 0, 0, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 1, 0, 0, 0, 1, 0},
                {0, 0, 0, 1, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };

            int[,] coordinate1 = {
                {150, 150, 75, 260, 37, 150, 225, 150},
                {30, 210, 150, 210, 210, 90, 150, 300}
            };

            matrixSmejn.Add(myArr1);
            coordVert.Add(coordinate1);

            int[,] myArr2 = {
                {0, 0, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 1, 0, 0},
                {0, 1, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 1, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };

            int[,] coordinate2 = {
                {150, 75, 150, 225, 37, 150, 260, 150},
                {30, 150, 90, 150, 210, 210, 210, 300}
            };

            matrixSmejn.Add(myArr2);
            coordVert.Add(coordinate2);

            int[,] myArr3 = {
                {0, 0, 1, 0, 1, 0, 0, 0},
                {0, 0, 0, 1, 0, 0, 1, 0},
                {0, 1, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 1, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };

            int[,] coordinate3 = {
                {150, 75, 75, 75, 225, 225, 225, 150},
                {30, 150, 90, 210, 90, 150, 210, 300}
            };

            matrixSmejn.Add(myArr3);
            coordVert.Add(coordinate3);

            int[,] myArr4 = {
                {0, 0, 0, 0, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 1, 1, 0},
                {0, 1, 1, 1, 0, 0, 0, 0},
                {0, 1, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };

            int[,] coordinate4 = {
                {150, 75, 150, 225, 150, 75, 225, 150},
                {30, 210, 210, 210, 90, 150, 150, 300}
            };

            matrixSmejn.Add(myArr4);
            coordVert.Add(coordinate4);

            int[,] myArr5 = {
                {0, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 1, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 1, 0, 1, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 1, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };

            int[,] coordinate5 = {
                {150, 150, 37, 75, 150, 260, 225, 150},
                {30, 90, 210, 150, 210, 210, 150, 300}
            };

            matrixSmejn.Add(myArr5);
            coordVert.Add(coordinate5);

            int[,] myArr6 = {
                {0, 1, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 1, 0, 0, 0},
                {0, 0, 0, 1, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 1, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 1, 0, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };

            int[,] coordinate6 = {
                {150, 75, 225, 75, 75, 225, 225, 150},
                {30, 90, 150, 210, 150, 210, 90, 300}
            };

            matrixSmejn.Add(myArr6);
            coordVert.Add(coordinate6);

            int[,] myArr7 = {
                {0, 0, 0, 0, 1, 0, 1, 0},
                {0, 0, 0, 1, 0, 1, 0, 0},
                {0, 0, 0, 1, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 1, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };

            int[,] coordinate7 = {
                {150, 75, 225, 75, 75, 225, 225, 150},
                {30, 150, 150, 210, 90, 210, 90, 300}
            };

            matrixSmejn.Add(myArr7);
            coordVert.Add(coordinate7);

            int[,] myArr8 = {
                {0, 1, 0, 0, 0, 1, 0, 0},
                {0, 0, 1, 0, 0, 0, 1, 0},
                {0, 0, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 0, 1, 0, 1, 0},
                {0, 0, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };

            int[,] coordinate8 = {
                {150, 75, 75, 150, 260, 225, 225, 225},
                {30, 90, 150, 210, 120, 90, 150, 300}
            };

            matrixSmejn.Add(myArr8);
            coordVert.Add(coordinate8);

            int[,] myArr9 = {
                {0, 0, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 1, 0, 1, 0, 0, 0, 0},
                {0, 1, 0, 1, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };

            int[,] coordinate9 = {
                {150, 37, 150, 150, 75, 225, 260, 150},
                {30, 210, 90, 210, 150, 150, 210, 300}
            };

            matrixSmejn.Add(myArr9);
            coordVert.Add(coordinate9);

            int[,] myArr10 = {
                {0, 0, 0, 0, 1, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 1, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 1, 0, 0, 0, 1, 0},
                {0, 1, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 0}
            };

            int[,] coordinate10 = {
                {150, 75, 225, 225, 75, 225, 75, 150},
                {30, 210, 150, 210, 90, 90, 150, 300}
            };

            matrixSmejn.Add(myArr10);
            coordVert.Add(coordinate10);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != '\b')
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Theory tr = new Theory();

            string curDir = Directory.GetCurrentDirectory();
            tr.webBrowser1.Url = new Uri(String.Format("file:///{0}/orgraf.html", curDir));
            tr.Show();
        }
    }

    class Vertex
    {
        public int x, y;

        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Edge
    {
        public int v1, v2;

        public Edge(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }


    class DrawGraph
    {
        Bitmap bitmap;
        Pen blackPen;
        Pen redPen;
        Pen darkGoldPen;
        Graphics gr;
        Font fo;
        Brush br;
        PointF point;
        public int R = 20; //радиус окружности вершины

        public DrawGraph(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            gr = Graphics.FromImage(bitmap);
            clearSheet();
            blackPen = new Pen(Color.Black);
            blackPen.Width = 2;
            redPen = new Pen(Color.Red);
            redPen.Width = 2;
            darkGoldPen = new Pen(Color.DarkGoldenrod);
            darkGoldPen.Width = 2;
            fo = new Font("Arial", 15);
            br = Brushes.Black;
        }

        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        public void clearSheet()
        {
            gr.Clear(Color.White);
        }

        public void drawVertex(int x, int y, string number)
        {
            gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
            gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
            point = new PointF(x - 9, y - 9);
            gr.DrawString(number, fo, br, point);
        }

        public void drawEdge(Vertex V1, Vertex V2, Edge E)
        {

            gr.DrawLine(darkGoldPen, V1.x, V1.y, V2.x, V2.y);
            point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
            drawVertex(V1.x, V1.y, (E.v1 + 1).ToString());
            drawVertex(V2.x, V2.y, (E.v2 + 1).ToString());
        }

        public void drawALLGraph(List<Vertex> V, List<Edge> E)
        {
            //рисуем ребра
            for (int i = 0; i < E.Count; i++)
            {
                gr.DrawLine(darkGoldPen, V[E[i].v1].x, V[E[i].v1].y, V[E[i].v2].x, V[E[i].v2].y);
                point = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
            }
            //рисуем вершины
            for (int i = 0; i < V.Count; i++)
            {
                drawVertex(V[i].x, V[i].y, (i + 1).ToString());
            }
        }
    }
}

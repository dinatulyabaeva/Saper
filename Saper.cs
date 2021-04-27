using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace saper
{
    public partial class MainForm : Form
    {
        int seconds;
        int minutes;
        int size = 40;
        int width = 9;
        int height = 9;
        bool isFirstClick = true;
        int cellsOpened = 0;
        int bombs = 0;
        int bombPercent;
        FieldButton[,] field;
        public MainForm()
        {
            InitializeComponent();
            //richTextBox_for_scores.Text=File.ReadAllText("score.t$");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            field = new FieldButton[width, height];
            //GenerateField();
        }
        
        void FieldButtonClick(object sender, MouseEventArgs e)
            //превое нажатие всегда на пустую клетку
            //генерация заново значения isBomb клеток, если нажал на бомбу
        {

            FieldButton clickedButton = (FieldButton)sender;
            if (e.Button == MouseButtons.Left && clickedButton.isClickable)  
            {
                if (clickedButton.isBomb)
                {
                    if (isFirstClick)
                    {
                        clickedButton.isBomb = false;
                        isFirstClick = false;
                        bombs--;
                        OpenRegion(clickedButton.xCoord, clickedButton.yCoord, clickedButton);
                    }
                    else
                    {
                        Explode();
                    }

                }
                else
                {
                    EmptyFieldButtonClick(clickedButton); //показываем количество бомб вокруг
                }
                isFirstClick = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                clickedButton.isClickable = !clickedButton.isClickable;
                if (!clickedButton.isClickable)
                {
                    clickedButton.Image = Image.FromFile("C:/Users/пк/Desktop/з.png");
                }
                else
                {
                    clickedButton.Image = Image.FromFile("C:/Users/пк/Desktop/4.png");
                }
            }
            Win();

        }
        void Explode()
        {
            foreach (FieldButton button in field)
            {
                if (button.isBomb)
                {
                    button.Image = Image.FromFile("C:/Users/пк/Desktop/4.png");
                }
            }
            timer.Stop();
            MessageBox.Show("Увы...\nЗатраченное время: " + label.Text, "Поражение", MessageBoxButtons.OK);
            //Application.Restart();
        }
        void EmptyFieldButtonClick(FieldButton clickedButton)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (field[x, y] == clickedButton)
                    {
                        //bombsAround = CountBombsAround(x, y);
                        OpenRegion(x, y, clickedButton);
                    }
                }
            }
        }
        void OpenRegion(int xCoord, int yCoord, FieldButton clickedButton)
        {
            Queue<FieldButton> queue = new Queue<FieldButton>();
            queue.Enqueue(clickedButton);
            clickedButton.wasAdded = true;
            while (queue.Count > 0)
            {
                FieldButton currentCell = queue.Dequeue();
                OpenCell(currentCell.xCoord, currentCell.yCoord, currentCell);
                cellsOpened++;
                if (BombsAround(currentCell.xCoord, currentCell.yCoord) == 0)
                {
                    for (int j = currentCell.yCoord - 1; j <= currentCell.yCoord + 1; j++) 
                    {
                        for (int i = currentCell.xCoord - 1; i <= currentCell.xCoord + 1; i++)
                        {
                            if (i == currentCell.xCoord && j == currentCell.yCoord)
                            {
                                continue;
                            }
                            if (i >= 0 && i < width && j < height && j >= 0)
                            {
                                if (!field[i, j].wasAdded)
                                {
                                    queue.Enqueue(field[i, j]);
                                    field[i, j].wasAdded = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        void OpenCell(int x, int y, FieldButton clickedButton)
        {
            int bombsAround = BombsAround(x,y);
            if (bombsAround == 0)
            {
                //если 0 бомб вокруг, ничего не пишем
            }
            else
            {
                clickedButton.Text = "" + bombsAround; //записываем количество бомб вокруг
            }
            clickedButton.Enabled = false;
        }
        int BombsAround(int xB, int yB)
        {
            int bombsAround = 0;
            for (int x = xB - 1; x <= xB + 1; x++)
            {
                for (int y = yB - 1; y <= yB + 1; y++)
                {
                    if (x >= 0 && x < width && y >= 0 && y < height)
                    {
                        if (field[x, y].isBomb == true)
                        {
                            bombsAround++;
                        }
                    }
                }
            }
            return bombsAround;
        }
        void Win()
        {
            int cells = width * height;
            int emptyCells = cells - bombs;
            if (cellsOpened >= emptyCells)
            {
                timer.Stop();
                MessageBox.Show("Победа!\nЗатраченное время: " + label.Text, "Победа", MessageBoxButtons.OK);
            }
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("всем приветики, это сапер от Дины");
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

            /*public void GenerateField()
            {
                Random random = new Random();
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        FieldButton newbutton = new FieldButton();
                        newbutton.Location = new Point(i * offset, j * offset);
                        newbutton.Size = new Size(offset, offset);
                        newbutton.isClickable = true;
                        if (random.Next(0, 100) <= bombPercent)
                        {
                            newbutton.isBomb = true;
                        }
                        newbutton.xCoord = i;
                        newbutton.yCoord = j;
                        Controls.Add(newbutton);
                        newbutton.MouseUp += new MouseEventHandler(FieldButtonClick);
                        field[i, j] = newbutton;
                    }
                }
            }*/

        private void легкийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    FieldButton newbutton = new FieldButton();
                    newbutton.Location = new Point(i * size, j * size);
                    newbutton.Size = new Size(size, size);
                    newbutton.isClickable = true;
                    if (random.Next(0, 100) <= 2)
                    {
                        newbutton.isBomb = true;
                    }
                    newbutton.xCoord = i;
                    newbutton.yCoord = j;
                    Controls.Add(newbutton);
                    newbutton.MouseUp += new MouseEventHandler(FieldButtonClick);
                    field[i, j] = newbutton;
                }
            }
            
        }

        private void среднийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    FieldButton newbutton = new FieldButton();
                    newbutton.Location = new Point(i * size, j * size);
                    newbutton.Size = new Size(size, size);
                    newbutton.isClickable = true;
                    if (random.Next(0, 100) <= 20)
                    {
                        newbutton.isBomb = true;
                    }
                    newbutton.xCoord = i;
                    newbutton.yCoord = j;
                    Controls.Add(newbutton);
                    newbutton.MouseUp += new MouseEventHandler(FieldButtonClick);
                    field[i, j] = newbutton;
                }
            }
        }

        private void сложныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    FieldButton newbutton = new FieldButton();
                    newbutton.Location = new Point(i * size, j * size);
                    newbutton.Size = new Size(size, size);
                    newbutton.isClickable = true;
                    if (random.Next(0, 100) <= 50)
                    {
                        newbutton.isBomb = true;
                    }
                    newbutton.xCoord = i;
                    newbutton.yCoord = j;
                    Controls.Add(newbutton);
                    newbutton.MouseUp += new MouseEventHandler(FieldButtonClick);
                    field[i, j] = newbutton;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds += 1;

            if (seconds == 60)
            {
                seconds = 0;
                minutes += 1;
            }

            label.Text =  minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }
    class FieldButton : Button
    {
        public bool isBomb;
        public bool isClickable;
        public bool wasAdded;
        public int xCoord;
        public int yCoord;
    }
}

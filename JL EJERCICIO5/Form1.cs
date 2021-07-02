using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JL_EJERCICIO5//Josselin Carolina Lopez Diaz 20181008622
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fila;
            int column;
           

            int[,] matriz;
            fila = int.Parse(textBox1.Text);
            column = int.Parse(textBox2.Text);
             matriz = new int [fila,column];
            Random aleatorio = new Random();
            for ( int f=0; f<fila;f++)
            {

                for (int c = 0; c < column; c++)
                {



                    matriz[f, c] = aleatorio.Next(0, 100);

                        
                }

            }
            for (int f = 0; f < fila; f++)
            {

                for (int c = 0; c < column; c++)
                {


                    listBox1.Items.Add(matriz[f, c]);
                    


                }

            }

          











        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
            
        }
        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
            listBox1.Focus();
        }


    }
}


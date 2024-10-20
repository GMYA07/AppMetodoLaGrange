using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Variables Globales a Usar para poder resolver el problema
        private List<int> listPuntosX;
        private List<int> listPuntosY;

        public Form1()
        {
            InitializeComponent();
            /*aqui inicializamos las listas*/
            listPuntosX = new List<int>();
            listPuntosY = new List<int>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSolucion_Click(object sender, EventArgs e) 
        {
            /*esta variable almacenara la sumatoria*/
            string polinomioSumatoria = "";

            for (int i = 0; i < listPuntosX.Count; i++)
            {
                /*en estas dos asignaciones almacenamos tanto los y y tambien algunos parentecis*/
                polinomioSumatoria += "((" + listPuntosY[i] + ") * ";
                polinomioSumatoria += " (";
                for (int j = 0; j < listPuntosY.Count; j++)
                {
                    /*esta condicion ayuda para no agregar el x de la posicon en la q estamos*/
                    if (i != j)
                    {
                        /*esta condicion nos ayuda a no colocar un asterico siempre al final de cada parte del polinomio*/
                        if (j == listPuntosY.Count - 1)
                        {
                            polinomioSumatoria += "(X-" + listPuntosX[j] + ")" + "/" + (listPuntosX[i] - listPuntosX[j]);
                        }
                        else
                        {
                            polinomioSumatoria += "(X-" + listPuntosX[j] + ")" + "/" + (listPuntosX[i] - listPuntosX[j]) + " * ";
                        }
                       
                    }


                }
                /*esta condicion nos ayuda a no colocar un signo de suma siempre al final de cada parte del polinomio*/
                if (i == listPuntosX.Count - 1)
                {
                    polinomioSumatoria += " ))";
                }
                else
                {
                    polinomioSumatoria += " )) + ";
                }
                
            }

            labelPolinomio.Text += polinomioSumatoria;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*aqui optenemos los puntos*/
            int x = int.Parse(puntoX.Text);
            int y = int.Parse(puntoY.Text);
            /*aqui lo agregamos a la lista*/
            listPuntosX.Add(x);
            listPuntosY.Add(y);
            /*aqui lo agregamos al datagrid para q se observe*/
            tablaPuntos.Rows.Add(x,y);
            /*aqui limpiamos los inputs*/
            puntoX.Text = "";
            puntoY.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /*en este caso el boton limpia todo para poder realizar otro ejercicio*/
            labelPolinomio.Text = "Polinomio: ";
            tablaPuntos.Rows.Clear();
            listPuntosX.Clear();
            listPuntosY.Clear();
        }

        private void labelPolinomio_Click(object sender, EventArgs e)
        {

        }
    }
}

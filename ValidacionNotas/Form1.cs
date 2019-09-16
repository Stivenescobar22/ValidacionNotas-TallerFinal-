using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacionNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Realizar un programa que permita ingresar 5 notas (incluye decimales), con base a lo anterior realice las siguientes validaciones

            lblmensaje1.Text = "Ingrese una nota de 0 a 5 en cada opcion";
            lblmensaje1.Visible = true;
           

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            float nota1 = float.Parse(txtnot1.Text);
            float nota2 = float.Parse(txtnot2.Text);
            float nota3 = float.Parse(txtnot3.Text);
            float nota4 = float.Parse(txtnot4.Text);
            float nota5 = float.Parse(txtnot5.Text);

            float promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            

            if (promedio <= 1){

                lblnotafinal.Text = promedio.ToString();
                lblnotafinal.Visible = true;
                lblmensaje2.Text = "Repruebas la materia y pierdes la opcion";
                lblmensaje3.Text = " de realizar proceso de recuperacion";
                lblmensaje2.Visible = true;
                lblmensaje3.Visible = true;
                lblnotafinal.ForeColor = Color.Red;
                txtnot1.Text = "";
                txtnot2.Text = "";
                txtnot3.Text = "";
                txtnot4.Text = "";
                txtnot5.Text = "";
            }
            else if (promedio <= 2.9){

                lblnotafinal.Text = promedio.ToString();
                lblnotafinal.Visible = true;
                lblmensaje2.Text = "Repruebas la materia pero puedes hacer";
                lblmensaje3.Text = "el taller de habilitacion";
                lblmensaje2.Visible = true;
                lblmensaje3.Visible = true;
                lblnotafinal.ForeColor = Color.Red;
                txtnot1.Text = "";
                txtnot2.Text = "";
                txtnot3.Text = "";
                txtnot4.Text = "";
                txtnot5.Text = "";

            }
            else if (promedio <= 3.9){

                lblnotafinal.Text = promedio.ToString();
                lblnotafinal.Visible = true;
                lblmensaje2.Text = "Aprobaste la materia pero tienes";
                lblmensaje3.Text = "plan para mejorar";
                lblmensaje2.Visible = true;
                lblmensaje3.Visible = true;
                lblnotafinal.ForeColor = Color.Green;
                txtnot1.Text = "";
                txtnot2.Text = "";
                txtnot3.Text = "";
                txtnot4.Text = "";
                txtnot5.Text = "";
            }
            else if (promedio <= 4.5){

                lblnotafinal.Text = promedio.ToString();
                lblnotafinal.Visible = true;
                lblmensaje2.Text = "Aprobaste la materia con un buen";
                lblmensaje3.Text = "rendimiento";
                lblmensaje2.Visible = true;
                lblmensaje3.Visible = true;
                lblnotafinal.ForeColor = Color.Green;
                txtnot1.Text = "";
                txtnot2.Text = "";
                txtnot3.Text = "";
                txtnot4.Text = "";
                txtnot5.Text = "";

            }
            else if (promedio <= 4.9){

                lblnotafinal.Text = promedio.ToString();
                lblnotafinal.Visible = true;
                lblmensaje2.Text = "Aprobaste la materia con un";
                lblmensaje3.Text = "rendimiento excelente";
                lblmensaje2.Visible = true;
                lblmensaje3.Visible = true;
                lblnotafinal.ForeColor = Color.Green;
                txtnot1.Text = "";
                txtnot2.Text = "";
                txtnot3.Text = "";
                txtnot4.Text = "";
                txtnot5.Text = "";

            }
            else if (promedio >= 5){

                lblnotafinal.Text = promedio.ToString();
                lblnotafinal.Visible = true;
                lblmensaje2.Text = "Te Graduas con Honores";
                lblmensaje2.Visible = true;
                lblnotafinal.ForeColor = Color.Blue;
                txtnot1.Text = "";
                txtnot2.Text = "";
                txtnot3.Text = "";
                txtnot4.Text = "";
                txtnot5.Text = "";

            }
        }

       
        


       

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

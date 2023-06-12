using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgressBar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_AtivaProgressBar_Click(object sender, EventArgs e)
        {
            //ProgressBar -> Barra de progresso
            progressBar1.Visible = true;//Torna o ProgressBar visível
            progressBar1.Minimum = 0;//Define o valor mínimo do ProgressBar como 0
            progressBar1.Maximum = 100;//Define o valor máximo do ProgressBar como 100
            progressBar1.Value = 0;//Define o valor atual do ProgressBar como 0

            timer1.Enabled = true; //Ativa o Timer para iniciar a atualização do ProgressBar
        }

        private void timer1_Tick(object sender, EventArgs e)                                            
        {                                       
            if (progressBar1.Value >= progressBar1.Maximum)//Verifica se o valor atual da barra do ProgresBar   
            {                                              //atingiu ou ultrapassou o valor máximo
                
                timer1.Enabled = false; //Desativa o Timer quando o ProgressBar atinge o valor máximo
                MessageBox.Show("Tarefa concluída!");//Exibe uma mensagem informando que a tarefa foi concluída
            }
            else
            {
                progressBar1.Value++; //Incrementa o valor do ProgressBar em 1 
                                      //para mostrar o progresso gradualmente
            }

            //Timer -> controla a frequência de atualização do ProgressBar,
            //tornando a animação suave e mostrando o progresso gradual da tarefa.
            //Isso dá ao usuário a sensação de que algo está acontecendo e ajuda a
            //indicar que a tarefa está progredindo.
        }
    }
}

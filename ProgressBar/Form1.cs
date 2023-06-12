namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ProgressBar -> Barra de progresso
             progressBar1.Minimum = 0;//Define o valor mínimo do ProgressBar como 0
             progressBar1.Maximum = 100;//Define o valor máximo do ProgressBar como 100
             //progressBar1.Value -> Valor atual da barra
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if( progressBar1.Value >= progressBar1.Maximum)//Verifica se o valor atual da barra do ProgresBar
            {                                              //atingiu ou ultrapassou o valor máximo
               
                this.timer1.Enabled = false;//Desativa o Timer para parar a atualização do ProgressBar
                MessageBox.Show("Tarefa concluída!");//Exibe uma mensagem informando que a tarefa foi concluída
            }
            else
            {
                progressBar1.Value++;//Incrementa o valor do ProgressBar em 1 
                                     //para mostrar o progresso gradualmente
            }

            //Timer -> controla a frequência de atualização do ProgressBar,
            //tornando a animação suave e mostrando o progresso gradual da tarefa.
            //Isso dá ao usuário a sensação de que algo está acontecendo e ajuda a
            //indicar que a tarefa está progredindo.
        }

        private void buttonEX2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void buttonEX3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
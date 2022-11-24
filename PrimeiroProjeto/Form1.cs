using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          MessageBox.Show("no arquivo program.cs existe o metodo inicial declarado como static void Main().\n" +
                            "O Metodo main() é o principal metodo do programa, onde o progrma se inicia.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todo projeto Windows Forms App é criado um formulario composto por dois arquivos:\n\n" +
                          "Form1.Designer.cs -> é o arquivo responsável por criar os objetos visuais do form em tempo de design. \n\n" +
                          "Form1.cs -> responsavel por armazenar o codigo fonte das regra do formulario.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form1.resx -> arquivo de recurso responsavel por armazenar imagens, icones, arquivos etc. É um ataolho para acessar" +
                            " os arquivos fisicos na pasta Resources.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O arquivo de configuração App.config permite armazenar informações do aplicativo de forma dinâmica.\n" + 
                "Essas informações pode ser dados de conexão, configurações de preferências do usuário e outras informações em tempo de exec.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contém um conjunto de referências de namespaces de classes e objetos que o projeto precisa para ser executado.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contém as propriedades do projeto.\n\n"   + 
                "Nas propriedades posso alterar o nome do projeto.\n"+
                "Posso o pacote .NET Framework.\n" +
                "Alterar tipo de projeto (Windows/Console/Class Library).\n" +
                "Alterar o icone da aplicação");
        }
    }
}

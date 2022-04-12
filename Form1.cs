using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        private bool flagPinta = false; // para controlar quando se deve pintar
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private bool flagApagar = false; // Parallel controlar quando se deve apagar 
        private Image imagemASalvar;
        private Graphics graphicsImagemASalvar;

        public Form1()
        {
            
            InitializeComponent();

            //define um feedback visual ao passar o maouse sobre os butões
            buttonApagar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonLimpar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;

            for (int i = 2; i <=50; i += 2) // ira prencher a comboBox de 2 até 50 contando de 2 em 2
            {
                comboBoxEspessura.Items.Add(i);
            }
            comboBoxEspessura.Text = "6"; // define o numero que ira aparecer no comboBox 
            comboBoxEspessura.IntegralHeight = false;
            comboBoxEspessura.MaxDropDownItems = 5;// define a quantidade de itens que aparece quando selecionar a comboBox

            espessuraCaneta = float.Parse(comboBoxEspessura.Text); // converte o texto da comboBox para float
            graphicsPainelPintura = panelPintura.CreateGraphics(); // o graphics perminte o desenho sobre o controle
            corBorracha = panelPintura.BackColor; // especifica a cor padrao da borracha

            // codigo para criar uma imagem e poder salvar o desenho nela
            imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); //imagem para salvar
            graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo graphics da imgaem para salvar de forma que podermos desenhar nela
            graphicsImagemASalvar.Clear(panelPintura.BackColor); 

        }

        //definindo a cor da caneta
        private void CorDaCaneta_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var corEscolida = colorDialog.ShowDialog();
           if(corEscolida == DialogResult.OK)
            {
                buttonCorDaCaneta.BackColor = colorDialog.Color;
            }
        }

        private void panelPintura_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)// se clicar com o botao esquerdo do mouse
            {
                flagPinta = true;
            }
        }

        private void panelPintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagPinta = false;
        }

        private void panelPintura_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPinta)
            {
                if (!flagApagar) // se flagApagar for falso vai desenha
                {   
                    // desenhando no elipse
                    graphicsPainelPintura
                        .DrawEllipse(new Pen(buttonCorDaCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                    
                    // desenhando na imagem para salvar
                    graphicsImagemASalvar
                        .DrawEllipse(new Pen(buttonCorDaCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else // se flagApagar for verdadeiro vai apagar(passar a cor da borracha por cima)
                {
                    graphicsPainelPintura
                        .DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));

                    graphicsImagemASalvar
                       .DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));

                }

            }
        }

        // ocorre quando é feita uma alteração do item da comboBox
        private void comboBoxEspessura_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxEspessura.SelectedItem.ToString());
        }

        private void buttonApagar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // se clicar com o botao direito do mouse
            {
                var colorDialog = new ColorDialog();

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color; // seleciona a cor da borracha
                }
            }
            else
            {
                if (!flagApagar)
                {
                    flagApagar = true;
                    buttonApagar.BackColor = corBorracha; // a cor do botao sera a mesma da borracha
                }
                else
                {
                    flagApagar = false;
                    buttonApagar.BackColor = Color.Black; // a cor do botao voltara ao padrao
                }

            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza? Todo o desenho será apagado!", "Apagar desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                graphicsPainelPintura.Clear(Color.White);
                imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); //imagem para salvar
                graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo graphics da imgaem para salvar de forma que podermos desenhar nela
                graphicsImagemASalvar.Clear(panelPintura.BackColor);

            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                    
                }
            }
        }

        private void panelPintura_Resize(object sender, EventArgs e) // evento disparado sempre que o painel é redimencionado
        {
            graphicsPainelPintura = panelPintura.CreateGraphics(); // atualiza a referencia do obejeto graphics do painel
            var imgTemp = new Bitmap(panelPintura.Width, panelPintura.Width);//criamos uma imagem temporaria
            var graphicsImgTemp = Graphics.FromImage(imgTemp);
            graphicsImgTemp.DrawImage(imagemASalvar, 0, 0); // desenhamos a imagem antiga na imagem temporaria
            imagemASalvar = imgTemp;
            graphicsImagemASalvar = graphicsImgTemp;
        }
    }
}

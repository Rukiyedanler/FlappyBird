using System;
using System.Windows.Forms;

namespace FlappyBird2
{
    public partial class Form1 : Form
    {
        int yercekimi = 11;
        int skor = 0;
        int boruhizi = 8 ;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1event(object sender, EventArgs e)
        {
            Random random = new Random();
            int yeniYukseklik = random.Next(0, 300);
            bird.Top += yercekimi;
            engel1.Left -= boruhizi;
            engel2.Left -= boruhizi;
            engel3.Left -= boruhizi;
            engel4.Left -= boruhizi;
            skoryazi.Text = "Score:" + skor;
           

            if (engel1.Left < -100 )
            {


                engel1.Top = yeniYukseklik+100;
                engel1.Height = yeniYukseklik+100;
                engel1.Left = 300;
                skor++;
                


            }
            if(engel2.Left<-100)
            {
                
                int sabitY = engel2.Top;
                engel2.Height = yeniYukseklik;
                engel2.Top = sabitY;
                engel2.Left = 300;
                skor++;
            }
            
            if (bird.Bounds.IntersectsWith(engel1.Bounds) || bird.Bounds.IntersectsWith(engel2.Bounds)||bird.Bounds.IntersectsWith(zemin.Bounds))
            {
                oyunsonu();
            }
            //Oyun hýzýný Hýzlandýrma
           // if (skor > 5)
          //  {
             //   boruhizi = 15;
            //}
            if(bird.Top<-25)
            {
                oyunsonu();
            }
        }

        private void down(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space) {
                yercekimi = -11;
            }

        }

        

        private void up(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                yercekimi = +11;
            }
        }
        private void oyunsonu()
        {
            timer1.Stop();
            skoryazi.Text = "Oyun Kaybedildi";
            MessageBox.Show("Skorunuz =0" + skor);
            //Application.Restart();  
            

        }
       
    }
}

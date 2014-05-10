using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace ProektnaVP
{
    public partial class Form1 : Form
    {
        Bitmap bit;
        List<Cloud> clouds; 
        List<Coins> coins;
        List<Rock> rocks;
        Explode explode;
        Plane plane;
        Graphics g;
        int points;
        List<int> Score; //niza so rezultati koja se prikazuva vo High score
        string str;
        bool puka; //promenliva koja kazuva dali e puknato

        Sound sound;

        public Form1()
        {
            InitializeComponent();

            sound = new Sound();

            puka = false; //inicijalno ne e puknato
            str = "";
            lbYourScore.Visible = false; //ovaa labela ni pokazuva kolku e nasiot rezultat koga ke zavrsi igrata
            Score = new List<int>(); 

            
            startGame();
            
        }

        public void startGame()
        {
            label1.Visible = false;
            BackColor = Color.White;
            lbYourScore.Visible = false;
            lbScore.Visible = false;
            puka = false;

            points = 0;
            label1.Visible = true;
            label1.Enabled = true;

            g = this.CreateGraphics();
            plane = new Plane(15, 15, bit);
            
            rocks = new List<Rock>();
            coins = new List<Coins>();
            clouds = new List<Cloud>();
            explode = new Explode(0,0,bit);

         
        }

        public void startTimer()
        {
            CoinsTimer.Start();
            MoveTimer.Start();
            NewRockTimer.Start();
            DrawTimer.Start();
            CloudTimer.Start();
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            plane.Move();
            if (!puka)
            {
                //sound.playMainMusic();
                

                    plane.bullet.Y = plane.Y + 20;
                    plane.bullet.speed = plane.speed;
                    plane.bullet.moveRock();
                
                    
            }
       
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            plane.speed = 5;
            //
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //dokolku se pritisne space avionot se kacuva nagore
            if (e.KeyCode == Keys.Space)
            {
                plane.speed -= 25;
            }
            //dokolku se pritisne A , avionot puka
            if (e.KeyCode == Keys.A)
            {
                
                sound.playMachineGun();
                puka = true;
            }
            
        }

        private void NewRockTimer_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int Rock1Y = ran.Next(plane.Height, (Height / 2) - plane.Height);
            int Rock2Y = ran.Next(Height / 2, Height-plane.Height);
            
            Rock rock1 = new Rock(Width - 10, Rock1Y,bit);
               
            Rock rock2 = new Rock(Width-10, Rock2Y,bit);
            
            rocks.Add(rock1);
            rocks.Add(rock2);

        }

        public void GameOver()
        {
            MoveTimer.Stop();
            NewRockTimer.Stop();
            DrawTimer.Stop();
            CoinsTimer.Start();
            CloudTimer.Stop();
        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.LightBlue);
            plane.Draw(g);

            foreach (Rock r in rocks)
            {
                r.speed +=3  ;
                r.Move();
                if (puka)
                {
                    if (plane.bullet.Collisision(r.X, r.Y, r.Width, r.Height))
                    {
                        explode.X = r.X;
                        explode.Y = r.Y;
                        explode.Draw(g);
                        r.X = -100;
                        r.Y = -100;
                    }
                }
                
                if(plane.Collisision(r.X,r.Y,r.Width,r.Height) || plane.Y > this.Height || plane.Y < -9){

                    
                    lbYourScore.Text = "GAME OVER \n Your score is " + points + " points";
                    lbYourScore.Visible = true;
                    GameOver();

                    sound.playGameOverMusic();
                    if (Score.Count <= 2)
                    {
                        Score.Add(points);
                    }
                    else
                    {
                        Score.RemoveAt(0);
                        Score.Add(points);
                    }
                    

                    str = "";
                    Enabled(true);
                    label1.Visible = false;
                  
                }
                r.Draw(g);
            }

            
            foreach (Coins c in coins)
            {
                c.speed += 1;
                c.Move();
                if (plane.Collisision(c.X, c.Y, c.Width, c.Height))
                {
                    c.X = -100;
                    c.Y = -100;
                    points++;
                   
                }
                c.Draw(g);

            }
            
            foreach (Cloud c in clouds)
            {

                c.move();
                if (plane.bullet.Collisision(c.X, c.Y, c.Width, c.Height))
                {
                    c.X = -10;
                    c.Y = -10;

                    if (puka)
                    {
                        points += 10;
                    }
                }
                c.Draw(g);
            }
            

            if (puka)
            {
                plane.bullet.Y += 3;
                plane.bullet.moveRock();
                plane.Fire(g, plane.bullet);
            }
            

            label1.Text = points.ToString();

        }

        public void Enabled(bool b)
        {
            btnStart.Visible = b;
            btnStart.Enabled = b;
            btnHigh.Visible = b;
            btnHigh.Enabled = b;
            btnExit.Visible = b;
            btnExit.Enabled = b;
            pbStartBackgrounf.Visible = b;
            pbStartBackgrounf.Enabled = b;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Enabled(false);
            startGame();
            startTimer();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            Score.Sort();
            string str = "BEST SCORE";
            foreach(int i in Score){
                str += "\n" + i;

            }
            lbScore.Text = str;
            lbScore.Visible = true;
            label1.Visible = false;
            lbYourScore.Visible = false;
            
            pbStartBackgrounf.Visible=false;
            pbStartBackgrounf.Enabled = false;
           
            GameOver();
            this.BackColor = Color.Red;
        }

        
        

        private void Form1_Resize(object sender, EventArgs e)
        {
            pbStartBackgrounf.Width = this.Width;
            pbStartBackgrounf.Height = this.Height;
            
        }

        private void CloudTimer_Tick_1(object sender, EventArgs e)
        {
            Random ran = new Random();
            Cloud cloud = new Cloud(Width - 10, ran.Next(0, Height),bit);
            clouds.Add(cloud);
       
        }

        private void CoinsTimer_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            Coins coin = new Coins(Width - 10, ran.Next(0, Height), bit);
            coins.Add(coin);
        }

        
    }
}
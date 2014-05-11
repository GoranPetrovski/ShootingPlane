ShootingPlane
=============



Целта на мојата семинарска задаца е создавање на играт SHOOTING - PLANE.
При пишување на кодот не се водев по некоја веке постоечка имплементација туку сам ја смислив идејата за целата игра. Сепак идејата за движењето на авионот ми беа воглавно од популарната игра Flappy Bird . Целта на играта е да се избегнат пречките што е можно подобро а со тоа и правење на подобар резултат . Поените воглавно можете да ги постигнете на два начини, првиот начин е преку собирањето на парички, додека вториот  начин е со пукање на облаче. На вториот начин вие можете да освоите максимални 10 поени, што би значело значително зглемување на вашите поени.
Кодот на мојата игра се состои од неколку класи ( Bullet, Cloud, Coins, Explode, Plane, Rock) кои наследуваат од класата  MovingObject. Од класата MovingObject останатите класи наследуваат 
методите  Draw(Graphics  g)    и Collision

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
                    lbNumPoints.Visible = false;
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
            lbNumPoints.Text = points.ToString();
        }

Bullet    - класа за куршумот кој што се имплементира во класата  Plane 
Cloud - класа за облаците, за која во главната форма се чува низа од оваа класа
Coins - во главната форма се чува листа од оваа класа
Explode -во главната форама се проверува колизија , и доколку има се исцртува експлозијата
Plane  -  класа за авионот во која дополнително има метод за пукање
public void Fire(Graphics g, Bullet b){
   	b.X += 3;
	b.moveRock();
   	b.Draw(g);
}
 
Rock - класа за карпите кои што авионот треба да ги избегнува
 
За да функционира играта имам употебено пет тајмери
CoinsTimer    - тајмер за креирање на паричките и додавање во низа од парички
MoveTimer     - тајмер за движењето на авионот и курсумот заедно со него
NewRockTime	- тајмер за креирање на нови карпи (објекти кои треба да ги избегнуваме DrawTimer	- тајмер за цртање на паричките, облаците, авионот и карпите
CloudTimer	- тајмер за креирањето на облаците и додавање во низа од облаци


ПРАВИЛА НА ИГРАТА
=======
Авионот е клучниот обијект во целата игра, кој постојано пага надулу. Со притискање на копчето
"SPACE"  авионот се качува нагоре . Со помош на копчето "A" авионот  пука при што , доколку покне во облак добива максимални 10 поени , а доколку пукне во карпа карпата експлодира.
Целта е да се освојат што е можно повеќе поени.

Ова е изгледот на почетокот на апликацијата
 
<img src="http://i.imgur.com/WT3Dy4m.png" />

Доколку претиснеме на копчето HEIGH SCORE  ни се прикажуваат најдобрите резултати
Резултатите ги чуваме во листа ( List<int> Score ) . Па пота ја изминуваме листата ги запишуваме резултатите во лабела која подоцна ја ставаме на видлива ( Visible=true).
 
<img src="http://i.imgur.com/j0FGM3Q.png" />

Ова е како изгледа апликацијата кога сме ја стартувале
 
<img src="http://i.imgur.com/KPY8XTd.png" />

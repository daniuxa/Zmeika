using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Zmeika
{
    class Zmei
    {
        public static readonly int MaxSize = 210;
        private readonly int StartSize = 10;

        public List<Point> body { get; set; }
        
       // public int Length { get; private set; }
        private Direction direction;

        public Zmei()
        {
            direction = Direction.Up;
            body = new List<Point>();
            
            for (int i = 0; i < StartSize; i++)
            {
                body.Add(new Point(200, 200 + i * 10));
            }
        }
        public Zmei(int StartSize)
        {
            if (StartSize <= 0)
            {
                throw new SizeException(StartSize, "Incorrect size of snake");
            }
            this.StartSize = StartSize;
            direction = Direction.Up;
            body = new List<Point>();

            for (int i = 0; i < StartSize; i++)
            {
                body.Add(new Point(200, 200 + i * 10));
            }
        }

        public int Move(PaintEventArgs paint, Direction direction, bool WithBorders = true, bool increaseSnake = false)
        {
            int Return = 0;
            //List<Point> tmpArr = new List<Point>();
            SolidBrush b = new SolidBrush(Color.Black);

            if ((this.direction == Direction.Up && direction == Direction.Down) || 
                (this.direction == Direction.Down && direction == Direction.Up) ||
                (this.direction == Direction.Left && direction == Direction.Right) ||
                (this.direction == Direction.Right && direction == Direction.Left) ||
                (body[0].X == -10 || body[0].X == 410 || body[0].Y == -10 || body[0].Y == 410))
            {
                //Bad event
            }
            else
            {
                //Good event
                this.direction = direction;
            }

            //this.direction = direction;

            if (this.direction != Direction.Default)
            {
                if (WithBorders == false && /*(body[0].X - 10 == body[1].X || body[0].X + 10 == body[1].X || body[0].Y - 10 == body[1].Y || body[0].Y + 10 == body[1].Y)  &&*/ (body[0].X == -10 || body[0].X == 410 || body[0].Y == -10 || body[0].Y == 410))
                {
                    if (this.direction == Direction.Up)
                    {
                        //tmpArr.Add(new Point(body[0].X, 400));
                        body.Insert(0, new Point(body[0].X, 400));
                    }
                    else if (this.direction == Direction.Right)
                    {
                        //tmpArr.Add(new Point(0, body[0].Y));
                        body.Insert(0, new Point(0, body[0].Y));
                    }
                    else if (this.direction == Direction.Down)
                    {
                        //tmpArr.Add(new Point(body[0].X, 0));
                        body.Insert(0, new Point(body[0].X, 0));
                    }
                    else if (this.direction == Direction.Left)
                    {
                        //tmpArr.Add(new Point(400, body[0].Y));
                        body.Insert(0, new Point(400, body[0].Y));
                    }
                }
                else
                {
                    if (this.direction == Direction.Up)
                    {
                        //tmpArr.Add(new Point(body[0].X, body[0].Y - 10));
                        body.Insert(0, new Point(body[0].X, body[0].Y - 10));
                    }
                    else if (this.direction == Direction.Right)
                    {
                       //tmpArr.Add(new Point(body[0].X + 10, body[0].Y));
                        body.Insert(0, new Point(body[0].X + 10, body[0].Y));
                    }
                    else if (this.direction == Direction.Down)
                    {
                        //tmpArr.Add(new Point(body[0].X, body[0].Y + 10));
                        body.Insert(0, new Point(body[0].X, body[0].Y + 10));
                    }
                    else if (this.direction == Direction.Left)
                    {
                        //tmpArr.Add(new Point(body[0].X - 10, body[0].Y));
                        body.Insert(0, new Point(body[0].X - 10, body[0].Y));
                    }
                }
               
                 //tmpArr.AddRange(body);
                 if (increaseSnake == false)
                {
                    body.RemoveAt(body.Count - 1);
                }
            }

            
            for (int i = 0, check = 0; i < body.Count; i++)
            {
                if (i != 0 && body[0] == body[i] && Return != 1)
                {
                    Return = 1;
                    check = 1;
                }
                if (i == 0 && WithBorders == true && (body[0].X == 0 || body[0].X == 400 || body[0].Y == 0 || body[0].Y == 400))
                {
                    Return = 1;
                    check = 1;
                }


                if (check == 0)
                {
                    paint.Graphics.FillEllipse(b, body[i].X, body[i].Y, 10, 10);
                }
                else
                {
                    SolidBrush b1 = new SolidBrush(Color.Red);
                    paint.Graphics.FillEllipse(b1, body[i].X, body[i].Y, 10, 10);
                    check = 0;
                }
            }   
            
            if (body.Count == MaxSize)
            {
                return 2;
            }

            return Return;
        }



    }
}

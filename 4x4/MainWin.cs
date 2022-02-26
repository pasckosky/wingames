using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{

    public partial class MainWin : Form
    {
        public enum Slide
        {
            Down,
            Up,
            Left,
            Right
        }

        public enum Pusher
        {
            Relaxed,
            Pushed
        }

        private enum Dot
        {
            Black = 0,
            Green,
            Red,
            Blue,
            Yellow,
            White,
        }

        private Dot[,] table;
        private Pusher[] v;
        private Pusher[] h;

        private void tableSlide(Slide what, int j, bool update=true)
        {
            bool vertical;
            int delta;
            if (j < 0)
                return;

            switch (what)
            {
                case Slide.Down:
                    this.v[j] = Pusher.Pushed;
                    vertical = true;
                    delta = 1;
                    break;
                case Slide.Up:
                    this.v[j] = Pusher.Relaxed;
                    vertical = true;
                    delta = -1;
                    break;
                case Slide.Left:
                    this.h[j] = Pusher.Relaxed;
                    vertical = false;
                    delta = -1;
                    break;
                case Slide.Right:
                    this.h[j] = Pusher.Pushed;
                    vertical = false;
                    delta = +1;
                    break;
                default:
                    // impossible case, but needed 
                    // because compiler is stupid and would mark vertical and delta as unassigned
                    return;
            }

            if (vertical)
            {
                // push up/down column j
                foreach (int jr in Extensions.Range(5))
                {
                    if (delta > 0)
                        // down
                        this.table[j + 1, 5 - jr] = this.table[j + 1, 4 - jr];
                    else
                        this.table[j + 1, jr] = this.table[j + 1, jr + 1];
                }
                this.table[j + 1, (delta > 0) ? 0 : 5] = Dot.White;
            }
            else
            {
                // push left/right row j
                foreach (int jc in Extensions.Range(5))
                {
                    if (delta > 0)
                        // down
                        this.table[5 - jc, j + 1] = this.table[4 - jc, j + 1];
                    else
                        this.table[jc, j + 1] = this.table[jc + 1, j + 1];
                }
                this.table[(delta > 0) ? 0 : 5, j + 1] = Dot.White;
            }

            if (update)
                this.apply();
        }

        public MainWin()
        {
            InitializeComponent();
            this.resetBoard();
        }

        private void resetBoard()
        {
            this.table = new Dot[6, 6];
            foreach (int y in Extensions.Range(6))
            {
                foreach (int x in Extensions.Range(6))
                {
                    Dot c;

                    c = Dot.Black;
                    if (x == 0 && y == 0)
                        c = Dot.Green;
                    else if (x == 0 && y == 5)
                        c = Dot.Red;
                    else if (x == 5 && y == 0)
                        c = Dot.Blue;
                    else if (x == 5 && y == 5)
                        c = Dot.Yellow;
                    else if (x == 0 || y == 0)
                        c = Dot.Black;
                    else if (x == 5 || y == 5)
                        c = Dot.White;
                    else if (x < 3 && y < 3)
                        c = Dot.Green;
                    else if (x < 3 && y >= 3)
                        c = Dot.Red;
                    else if (x >= 3 && y < 3)
                        c = Dot.Blue;
                    else
                        c = Dot.Yellow;

                    this.table[x, y] = c;
                }
            }
            this.v = new Pusher[4];
            this.h = new Pusher[4];

            foreach (int j in Extensions.Range(4))
            {
                this.v[j] = Pusher.Relaxed;
                this.h[j] = Pusher.Relaxed;
            }

            foreach (Button b in Extensions.asIterable(this.r1Left, this.r2Left, this.r3Left, this.r4Left))
                b.Text = "ß"; // wingdings left
            foreach (Button b in Extensions.asIterable(this.r1Right, this.r2Right, this.r3Right, this.r4Right))
                b.Text = "à"; // wingdings right
            foreach (Button b in Extensions.asIterable(this.c1Down, this.c2Down, this.c3Down, this.c4Down))
                b.Text = "â"; // wingdings down
            foreach (Button b in Extensions.asIterable(this.c1Up, this.c2Up, this.c3Up, this.c4Up))
                b.Text = "á"; // wingdings up

            this.apply();
        }

        private void apply()
        {
            foreach (Tuple<int, Label> dot in Extensions.asIterable(this.d00, this.d10, this.d20, this.d30, this.d40, this.d50,
                                                                    this.d01, this.d11, this.d21, this.d31, this.d41, this.d51,
                                                                    this.d02, this.d12, this.d22, this.d32, this.d42, this.d52,
                                                                    this.d03, this.d13, this.d23, this.d33, this.d43, this.d53,
                                                                    this.d04, this.d14, this.d24, this.d34, this.d44, this.d54,
                                                                    this.d05, this.d15, this.d25, this.d35, this.d45, this.d55)
                                                        .enumerate())
            {
                int x = dot.Item1 % 6;
                int y = dot.Item1 / 6;
                Label ctrl = dot.Item2;
                bool showArrow;

                showArrow = false;
                switch (this.table[x, y])
                {
                    case Dot.Black:
                        ctrl.BackColor = Color.Black;
                        break;
                    case Dot.Blue:
                        ctrl.BackColor = Color.Blue;
                        break;
                    case Dot.Green:
                        ctrl.BackColor = Color.Green;
                        break;
                    case Dot.Red:
                        ctrl.BackColor = Color.Red;
                        break;
                    case Dot.Yellow:
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case Dot.White:
                        ctrl.BackColor = Color.White;
                        showArrow = true;
                        break;
                }

                if (!showArrow)
                {
                    if (ctrl.Text != "")
                        ctrl.Text = "";
                }
                else if (x == 0 && y > 0 && y < 5)
                    ctrl.Text = "à";
                else if (x == 5 && y > 0 && y < 5)
                    ctrl.Text = "ß";
                else if (y == 0 && x > 0 && x < 5)
                    ctrl.Text = "â";
                else if (y == 5 && x > 0 && x < 5)
                    ctrl.Text = "á";

            }

            foreach (Tuple<int, Button> pusher in Extensions.asIterable(this.c1Down, this.c2Down, this.c3Down, this.c4Down).enumerate())
                pusher.Item2.Visible = this.v[pusher.Item1] == Pusher.Relaxed;
            foreach (Tuple<int, Button> pusher in Extensions.asIterable(this.c1Up, this.c2Up, this.c3Up, this.c4Up).enumerate())
                pusher.Item2.Visible = this.v[pusher.Item1] == Pusher.Pushed;
            foreach (Tuple<int, Button> pusher in Extensions.asIterable(this.r1Left, this.r2Left, this.r3Left, this.r4Left).enumerate())
                pusher.Item2.Visible = this.h[pusher.Item1] == Pusher.Pushed;
            foreach (Tuple<int, Button> pusher in Extensions.asIterable(this.r1Right, this.r2Right, this.r3Right, this.r4Right).enumerate())
                pusher.Item2.Visible = this.h[pusher.Item1] == Pusher.Relaxed;

            foreach (Button b in Extensions.asIterable(this.c1Down, this.c2Down, this.c3Down, this.c4Down,
                                                       this.c1Up, this.c2Up, this.c3Up, this.c4Up,
                                                       this.r1Left, this.r2Left, this.r3Left, this.r4Left,
                                                       this.r1Right, this.r2Right, this.r3Right, this.r4Right))
            {
                b.BackColor = Color.White;
            }
        }

        private void Slide_Click(object sender, EventArgs e)
        {
            Button b;

            b = (Button)sender;

            this.tableSlide(Slide.Down, Extensions.asIterable(this.c1Down, this.c2Down, this.c3Down, this.c4Down).Which(b));
            this.tableSlide(Slide.Up, Extensions.asIterable(this.c1Up, this.c2Up, this.c3Up, this.c4Up).Which(b));
            this.tableSlide(Slide.Left, Extensions.asIterable(this.r1Left, this.r2Left, this.r3Left, this.r4Left).Which(b));
            this.tableSlide(Slide.Right, Extensions.asIterable(this.r1Right, this.r2Right, this.r3Right, this.r4Right).Which(b));
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            this.resetBoard();
        }

        private void cmdShuffle_Click(object sender, EventArgs e)
        {
            Random r;

            r = new Random();
            foreach (int j in Extensions.Range(100))
            {
                int jd;
                Slide sl;
                int je;

                jd = r.Next() % 2;
                je = r.Next() % 4;

                if (jd == 0)
                {
                    // h
                    if (this.h[je] == Pusher.Relaxed)
                        sl = Slide.Right;
                    else
                        sl = Slide.Left;
                }
                else
                {
                    // v
                    if (this.v[je] == Pusher.Relaxed)
                        sl = Slide.Down;
                    else
                        sl = Slide.Up;

                }
                this.tableSlide(sl, je, false);

            }

            // bring to canonical form
            foreach (int jr in Extensions.Range(4))
            {
                if (this.h[jr] == Pusher.Pushed)
                    this.tableSlide(Slide.Left, jr, false);
                if (this.v[jr] == Pusher.Pushed)
                    this.tableSlide(Slide.Up, jr, false);
            }
            this.apply();
        }

        private void dotPaint(object sender, PaintEventArgs e)
        {
            Label obj = (Label)sender;
            Graphics g = e.Graphics;
            Color c = obj.BackColor;

            float ratio = 0.8f;
            if (Extensions.asIterable(this.d00, this.d05, this.d50, this.d55).Which(obj) != -1)
            {
                // angle
                ratio = 0.4f;
            }

            float w = obj.Width;
            float h = obj.Height;
            float cx = w / 2;
            float cy = h / 2;
            float r = Extensions.asIterable(cx, cy).Min() * ratio;

            RectangleF recF = new RectangleF(cx - r, cy - r, r * 2, r * 2);

            g.Clear(Color.Black);
            g.FillEllipse(new SolidBrush(c), recF);
        }
    }

    public static class Extensions
    {
        public static IEnumerable<T> asIterable<T>(params T[] sequence)
        {
            return sequence;
        }
        public static IEnumerable<Tuple<int, T>> enumerate<T>(this IEnumerable<T> sequence)
        {
            int j;

            j = 0;
            foreach (T obj in sequence)
            {
                yield return new Tuple<int, T>(j, obj);
                j++;
            }
        }

        public static bool isIn<T>(this T test, params T[] options)
        {
            foreach (T elt in options)
            {
                if (test.GetType().IsSubclassOf(typeof(Control)))
                {
                    // Controls are not comparable
                    Control a, b;

                    a = elt as Control;
                    b = test as Control;
                    if (a == b)
                        return true;
                }
                else if (Comparer<T>.Default.Compare(elt, test) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static int Which<T>(this IEnumerable<T> sequence, T test)
        {
            foreach (Tuple<int, T> elt in sequence.enumerate())
            {
                if (test.GetType().IsSubclassOf(typeof(Control)))
                {
                    // Controls are not comparable
                    Control a, b;

                    a = elt.Item2 as Control;
                    b = test as Control;
                    if (a == b)
                        return elt.Item1;
                }
                else
                {
                    if (Comparer<T>.Default.Compare(elt.Item2, test) == 0)
                        return elt.Item1;
                }
            }

            return -1;
        }

        public static IEnumerable<int> Range(int n)
        {
            for (int j1 = 0; j1 < n; j1++)
            {
                yield return j1;
            }
        }
    }
}

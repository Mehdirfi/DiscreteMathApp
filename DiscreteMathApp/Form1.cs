using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

//MessageBox.Show("کوتاه‌ترین مسیر") is comment use ctrl + f to find and uncomment it
//right_click and come to front for the greeting page to move it to the front
namespace DiscreteMathApp
{
    public partial class DiscreteMathApp : Form
    {
        // داده‌های گراف
        List<Point> vertices = new List<Point>();
        // List<> ? یک ارایه پیشرفته پویا است که مانند یک ظرف عمل میکند و میتواند هر نوع داده ای را درون خودش نگه دارد
        // Point? که یک نقطه با مختصات ایکس و ایگرگ را نشان میدهد system.drawing یک کلاس اماده است در فضای 
        // List<point> ? یک ظرف که میتواند چندین نقطه را درون خودش نگه دارد
        //یک لیست خالی به نام ورتیکز بساز که مختصات هر راس را درون خود نگه دارد 
        //هربار کاربر راس جدید اضافه کند یک پوینت جدید شامل یک ایکس و یک ایگرگ به این لیست اضافه میشود
        List<Tuple<int, int>> edges = new List<Tuple<int, int>>();
        //<Tuple<int, int>>? کلا تاپل یک ساختار ساده برای نگهداری چند مقدار کنار هم است
        // یک لیست خالی به نام ایدجز بساز که جفت عدد صحیح را درون خود نگه میدارد
        //درواقع این لیست قرار است هر یال را به صورت یک زوج دوتایی از راس مبدا و راس مقصد درون خود ذخیره کند
        // به این دلیل از لیست استفاده کردیم چون نمیدونیم کاربر چقدر میخواد راس اضافه کنه

        // وضعیت‌های حالت
        bool isAddVertexMode = false; // آیا در حالت افزودن راس هستیم؟
        bool isAddEdgeMode = false; // آیا در حالت افزودن یال هستیم؟
        int selectedVertexForEdge = -1; // راس انتخاب شده برای یال؟ مقدار اولیه منفی یک است یعنی هیچ راسی انتخاب نشده است

        int vertices_count = 0;
        int edges_count = 0;

        // دو استک برای دو دکمه عقب گرد و جلو گرد
        Stack<GraphState> undoStack = new Stack<GraphState>();
        Stack<GraphState> redoStack = new Stack<GraphState>();

        public class GraphState // یک کلاس برای ذخیره وضعیت گراف
        {
            public List<Point> Vertices { get; set; }
            public List<Tuple<int, int>> Edges { get; set; }

            public GraphState(List<Point> vertices, List<Tuple<int, int>> edges) // راس ها و یال ها رو کپی کن
            {
                Vertices = new List<Point>(vertices);
                Edges = new List<Tuple<int, int>>(edges);
            }
        }
        public DiscreteMathApp() // کانسترکتور
        {
            InitializeComponent();

            //ظاهری
            SetGradientBackground(); // تابعی که پایین تر خودمون نوشتیم برای پس زمینه گرادیان 
            panelWelcome.Paint += (s, e) => // رسم یه کارد گرد در پنل خوش آمد گویی
            {
                Panel pnl = s as Panel; // شئ فرستنده را به یک پنل تبدیل کن تا بتوانیم از خصوصیات پنل استفاده کنیم
                Graphics g = e.Graphics; // ابزار نقاشی را از رویداد بگیریم تا بتونیم باهاش دایره مستطیل و .. بکشیم
                g.SmoothingMode = SmoothingMode.AntiAlias; // لبه های اشکال رو صاف و بدون دندانه کن

                Rectangle rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1); // یک مستطیل به اندازه پنل بساز ولی عرض و ارتفاعش یکی کمتر
                int radius = 25; // شعاع انحنای گوشه ها 25 پیکسل باشه
                // نکته: از عرض و ارتفاع برای این یک واحد کم کردیم که حاشیه بیرون از پنل کشیده نشه

                // ساخت مسیر گرد
                GraphicsPath path = new GraphicsPath(); // یک مسیر گرافیکی جدید بساز که میتواند شامل چند قوس ، خط یا منحنی باشد که قراره گوشه های گرد را در ان بزاریم
                // اضافه کردن 4 قوس برای گرد کردن گوشه ها
                // پارامتر های پرانتز به ترتیب : موقعیت شروع از چپ راست یا بالا پایین - عرض و ارتفاع قوس - زاویه یا درجه شروع - زاویه چرخش
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // گوشه بالا چپ
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); // گوشه بالا راست
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); // گوشه پایین راست
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90); // گوشه پایین چپ
                path.CloseFigure(); // مسیر را ببند یعنی اخرین نقطه را به اولی وصل کن

                // کشیدن حاشیه سفید
                using (Pen pen = new Pen(Color.White, 1.5f)) // یه قلم جدید با ضخامت 1 و نیم بساز
                {
                    g.DrawPath(pen, path); // مسیری که ساختیم رو با این قلم روی پنل بکش
                }
            };




            // رسم گراف
            pictureBoxCanvas.MouseClick += (s, e) => // هروقت کاربر روی اون صفحه سفیده یا همون بوم نقاشی کلیک میکنه
            {
                if (isAddVertexMode) // اگر حالت افزودن راس فعال باشه
                {
                    SaveState(); // قبل هر تغییری بیایم وضعیت فعلی رو در استک آندو ذخیره کنیم
                    vertices.Add(e.Location); // مختصات جایی که کاربر کلیک کرده رو به لیست راس ها اضافه کن

                    //a
                    listBox1.Items.Add(e.Location);
                    //textBox1.Text = Convert.ToString(vertices[0].X);//should be erased

                    pictureBoxCanvas.Invalidate(); // به بوم نقاشی بگو تا خودش رو دوباره بکشه تا راس جدید نمایش داده بشه

                    vertices_count++;//a
                }
                else if (isAddEdgeMode) // اگه حالت افزودن یال فعال باشه
                {
                    int clickedVertex = FindNearestVertex(e.Location); // نزدیک ترین راس به محل کلیک رو پیدا کن
                    if (clickedVertex != -1) // اگه راسی پیدا شد
                    {
                        if (selectedVertexForEdge == -1) // اگه این اولین راسی بوده که کاربر انتخاب کرده
                        {
                            selectedVertexForEdge = clickedVertex; // اونو به عنوان راس اول انتخاب کن

                        }
                        else // اگر راس دوم است یعنی قبلا یکی ذخیره شده
                        {
                            SaveState();
                            edges.Add(Tuple.Create(selectedVertexForEdge, clickedVertex)); // یال جدید بین دو راس رو به لیست یال ها اضافه کن
                            selectedVertexForEdge = -1; // راس انتخاب شده رو ریست کن برای یال بعدی
                            pictureBoxCanvas.Invalidate(); // صفحه را دوباره بکش تا یال جدید نمایش داده بشه


                            //a
                            listBox2.Items.Add(Tuple.Create(selectedVertexForEdge, clickedVertex));//a
                            //textBox1.Text = Convert.ToString(edges[0].Item1);//should be erased
                            edges_count++;//a

                        }
                    }
                }



            };
            pictureBoxCanvas.Paint += (s, e) => // نمایش گراف روی صفحه
            {
                Graphics g = e.Graphics; // ابزار نقاشی را دریافت کن

                // رسم یال‌ها
                foreach (var edge in edges) // برای هر یال در لیست یال ها
                {
                    Point p1 = vertices[edge.Item1]; // مختصات راس اول رو بگیر
                    Point p2 = vertices[edge.Item2]; // مختصات راس دوم رو بگیر
                    g.DrawLine(Pens.Black, p1, p2); // یک خط سیاه بین دو راس بکش
                }

                // رسم راس‌ها
                for (int i = 0; i < vertices.Count; i++) // برای هر راس در لیست راس ها
                {
                    Point p = vertices[i];
                    g.FillEllipse(Brushes.LightBlue, p.X - 10, p.Y - 10, 20, 20); // یک دایره ابی روشن به قطر 20 پیکسل در مرکز راس بکش
                    g.DrawEllipse(Pens.Black, p.X - 10, p.Y - 10, 20, 20); // یه حاشیه سیاه دور دایره بکش
                    g.DrawString((i + 1).ToString(), this.Font, Brushes.Black, p.X - 5, p.Y - 7); // شماره راس رو داخل دایره بکش
                }
            };



            // اتصال دکمه ها

            lblMenuIcon.Click += (s, e) => // مدیریت کلیک روی آیکون منو
            {
                if (panelMenu.Visible == true)
                {
                    panelMenu.Visible = false;
                }
                else panelMenu.Visible = true;
                // یعنی کاربر اگه روی منوی صفحه اصلی زد، چک بکن که قبلا باز نباشه منو، اگه باز بود ببندش
                // اگه باز نبود ، بازش کن
            };
            btnGraphMenu.Click += (s, e) => // مدیریت کلیک روی آیتم گراف از منو
            {
                panelMenu.Visible = false; // یعنی اگه کاربر در منو روی آیتم گراف زد بیا دیگه منو رو ببند
                panelGraph.Visible = true;

            };

            btnAddVertex.Click += (s, e) => // کاربر روی افزودن راس کلیک کند
            {
                if (isAddVertexMode == true) // اگه قبلا فعال بود
                {
                    isAddVertexMode = false;
                    btnAddVertex.BackColor = Color.FromArgb(0, 64, 64);
                }
                else
                {
                    isAddVertexMode = true; // فعال شدن حالت افزودن راس
                    btnAddVertex.BackColor = Color.Green; // دکمه  انتخاب راس رو رنگشو تغییر بده که کاربر بفهمه انتخاب شده 

                }

                isAddEdgeMode = false; // اگر حالت افزودن یال فعال بود ان را غیر فعال کن
                selectedVertexForEdge = -1; // ریست کردن راس انتخاب شده برای یال یعنی دوباره به حالتی برگردیم که هنوز هیچ راسی انتخاب نشده
                btnAddEdge.BackColor = Color.FromArgb(37, 108, 186); // دکمه افزودن یال رو دکمشو دوباره به حالت عادی برگردون
            };
            btnAddEdge.Click += (s, e) => // روی افزودن یال کلیک کند
            {
                if (isAddEdgeMode == true)
                {
                    isAddEdgeMode = false;
                    btnAddEdge.BackColor = Color.FromArgb(37, 108, 186);
                }
                else
                {
                    isAddEdgeMode = true; // حالت اضافه کردن یال رو فعال کن
                    btnAddEdge.BackColor = Color.Green; // تغییر رنگ دکمه افزودن یال برای انتخاب شده
                }

                isAddVertexMode = false; // اگر حالت اضافه کردن راس فعال بوده اونو غیر فعال کن
                selectedVertexForEdge = -1; // ریست کردن راس انتخاب شده و اماده شدن برای انتخاب راس جدید   
                btnAddVertex.BackColor = Color.FromArgb(0, 64, 64); // ریست کردن رنگ دکمه افزودن راس به حالت انتخاب نشده
            };

            btnClearGraph.Click += (s, e) => // اگر روی دکمه کلیر بزند
            {
                ClearAll();
            };
            btnBacktoHome.Click += (s, e) =>
            {
                panelGraph.Visible = false;
                ShortestPathPanel.Visible = false;
                ClearAll();
            };
            btnShortestPath.Click += (s, e) => // روی دکمه کوتاه ترین مسیر کلیک کرد
            {
                if (ShortestPathPanel.Visible == true) ShortestPathPanel.Visible = false;
                else ShortestPathPanel.Visible = true;
                
            };

            btnUndo.Click += (s, e) =>
            {
                Undo();
                //a
                vertices_count = vertices.Count;
                edges_count = edges.Count;
            };
            btnRedo.Click += (s, e) =>
            {
                Redo();

                //a
                vertices_count = vertices.Count;
                edges_count = edges.Count;
            };




        }

        //ظاهری
        private void SetGradientBackground() // رنگ پس زمینه گرادیان
        {
            LinearGradientBrush brush = new LinearGradientBrush( // یک قلم مو یا براش که رنگ را به صورت خطی و شیب دار میکشد که نامش را براش گذاشتیم
            panelGradient.ClientRectangle, // ناحیه ای که باید رنگ شود که اینجا کل پنل است
            Color.FromArgb(3, 12, 62), // رنگ اول ابی خیلی تیره
            Color.FromArgb(81, 24, 152), // رنگ دوم بنفش
            45f); // زاویه گرادیان که 45 درجه است اینجا یعنی از گوشه بالا چپ به پایین راست
            panelGradient.Paint += (s, e) => // هروقت پنل نیاز به کشیده شدن یا اجرا شدن دارد
            {
                e.Graphics.FillRectangle(brush, panelGradient.ClientRectangle); // بیا کل پنل را با اون براشی که قبل تر ساختیم رنگ کن
            };
        }




        private void ClearAll() // برای کلیر یه تابع جداگانه تعریف کردم تا موقع برگشت به خانه بشه صداش زد
        {
            SaveState();

            isAddVertexMode = false;
            isAddEdgeMode = false;
            selectedVertexForEdge = -1;

            btnAddVertex.BackColor = Color.FromArgb(0, 64, 64);
            btnAddEdge.BackColor = Color.FromArgb(37, 108, 186);

            vertices.Clear(); // همه راس ها را از لیست پاک کن
            edges.Clear(); // همه یال ها رو از لیست پاک کن
            pictureBoxCanvas.Invalidate(); // به بوم نقاشی بگو همه چیو دوباره بکش



            // a
            listBox1.Items.Clear();//a
            listBox2.Items.Clear();//a
            listBox3.Items.Clear();//a
            vertices_count = 0;//a
            edges_count = 0;//a
            errorTextbox.Text = "";//a
            errorTextbox.Visible = false;//a
            listBox3.Text = "";//a
            Pathes.Clear();//a
            textBox4.Clear();//a
            listBox4.Items.Clear();//a
            textBox1.Clear();//a
        }

        





        private int FindNearestVertex(Point clickLocation) // این تابع بررسی میکنه که کاربر روی کدوم راس کلیک کرده
        {
            for (int i = 0; i < vertices.Count; i++) // به ترتیب همه راس ها رو بررسی کن
            {
                double dx = vertices[i].X - clickLocation.X; // مختصات ایکس راس شماره آی رو پیدا کن بعد بیا اختلاف این راس با محل کلیک رو پیدا کن
                double dy = vertices[i].Y - clickLocation.Y; // مختصات ایگرگ راس شماره آی رو پیدا کن بعد بیا اختلاف این راس با محل کلیک رو پیدا کن
                double distance = Math.Sqrt(dx * dx + dy * dy); // فاصله رو به کمک الگوریتم اقلیدسی یا همون فیثاغورث پیدا کن
                if (distance < 15) return i; // اگه فاصله کمتر از 15 پیکسل باشه همون راس رو برگردون
            }
            return -1; // اگه هیچ راسی نزدیک محل کلیک شده نبود هیچ کاری نکن
        }



        private void SaveState()
        {
            GraphState currentState = new GraphState(vertices, edges);
            undoStack.Push(currentState);
            redoStack.Clear();
        }

        private void Undo()
        {
            // 1. اگر استک خالی است، کاری نکن
            if (undoStack.Count == 0) return;
            // وضعیت فعلی را ذخیره کن
            GraphState currentState = new GraphState(vertices, edges);
            redoStack.Push(currentState);

            GraphState previousState = undoStack.Pop(); // اخرین وضعیت را بردار

            // 4. راس‌ها و یال‌ها را به آن وضعیت برگردان
            vertices = previousState.Vertices;
            edges = previousState.Edges;

            // 5. صفحه را دوباره بکش
            pictureBoxCanvas.Invalidate();

            
        }

        private void Redo()
        {
            if (redoStack.Count == 0) return;

            GraphState currentState = new GraphState(vertices, edges);
            undoStack.Push(currentState);

            GraphState nextState = redoStack.Pop();

            // 4. راس‌ها و یال‌ها را به آن وضعیت برگردان
            vertices = nextState.Vertices;
            edges = nextState.Edges;

            // 5. صفحه را دوباره بکش
            pictureBoxCanvas.Invalidate();


        }











        private void DiscreteMathApp_Load(object sender, EventArgs e)
        {
            ShortestPathPanel.Visible = false;//a

        }

        private void MenuDisable_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false; // غیر فعال کردن نمایش منو اگر کاربر روی جایی غیر از منوی باز شده کلیک کند
        }

        private void chkVertexCount_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxCanvas_Click(object sender, EventArgs e)
        {

        }

        private void btnClearGraph_Click(object sender, EventArgs e)
        {

        }

        private void btnShortestPath_Click(object sender, EventArgs e)
        {
            
        }

        private void ShortestPathPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        int fV, sV;
        List<List<int>> Pathes = new List<List<int>>();
        
        void FindAllPaths(int current, int target, List<int> path, bool[] visited)////
        {
            
            visited[current] = true;
            path.Add(current + 1);

            if (current == target)
            {
                
                Pathes.Add(new List<int>(path));
                listBox3.Items.Add(string.Join(" -> ", path));
                
            }
            else
            {
                for (int i = 0; i < edges_count; i++)
                {
                    if (edges[i].Item1 == current && !visited[edges[i].Item2])
                    {
                        FindAllPaths(edges[i].Item2, target, path, visited);
                    }
                    else if (edges[i].Item2 == current && !visited[edges[i].Item1])
                    {
                        FindAllPaths(edges[i].Item1, target, path, visited);
                    }
                }
            }

            path.RemoveAt(path.Count - 1);
            visited[current] = false;
            
        }////


        int second = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerShowerLabel.Text = Convert.ToString(second);
            second--;
            if (second == -1)
            {
                timer1.Stop();
                errorTextbox.Visible = false;
                firstVertex.Enabled = true;
                secondVertex.Enabled = true;
                firstVertex.BackColor = Color.Lime;
                secondVertex.BackColor = Color.Lime;
                timerShowerLabel.Visible = false;
                errorTextbox.Text = "";
                second = 3;
                timerShowerLabel.Text = "4";
            }
        }
        
        private void btnAddVertex_Click(object sender, EventArgs e)
        {

        }
        double len(int f,int s)
        {
            f -= 1;
            s -= 1;
            return Math.Round(Math.Pow(Math.Pow(vertices[s].X - vertices[f].X, 2) + Math.Pow(vertices[s].Y - vertices[f].Y, 2), 0.5), 2);
            
        }
        
        List<double> shortest_path = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            /*bool isThere = false;
            for (int j = 0; j < edges.Count; j++)
            {
                if ((edges[j].Item1 == fV - 1 && edges[j].Item2 == sV - 1) || (edges[j].Item1 == sV - 1 && edges[j].Item2 == fV - 1))
                {
                    isThere = true;
                    break;
                }
            }*/
            Pathes.Clear();
            listBox3.Items.Clear();
            fV = (int)firstVertex.Value;
            sV = (int)secondVertex.Value;
            if (vertices_count < fV || vertices_count < sV)
            {
                errorTextbox.Visible = true;
                firstVertex.Enabled = false;
                secondVertex.Enabled = false;
                errorTextbox.Text = "همچین راسی وجود ندارد";
                timerShowerLabel.Visible = true;
                timer1.Start();
                if (vertices_count < fV)
                {
                    firstVertex.BackColor = Color.Red;
                }
                if (vertices_count < sV)
                {
                    secondVertex.BackColor = Color.Red;
                }
            }
            /*else if (isThere == false)
            {
                errorTextbox.Visible = true;
                errorTextbox.Text = "هیچ مسیری وجود ندارد";
                timer1.Start();
                timerShowerLabel.Visible = true;
            }*/

            else//v path finder
            {
                
                List<int> path = new List<int>();////
                bool[] visited = new bool[vertices_count];

                FindAllPaths(fV - 1, sV - 1, path, visited);////
                shortest_path.Clear();
                listBox4.Items.Clear();


                for (int i = 0; i < Pathes.Count; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < Pathes[i].Count - 1; j++)
                    {

                        //listBox4.Items.Add(len(Pathes[i][j], Pathes[i][j + 1]));
                        sum += len(Pathes[i][j], Pathes[i][j + 1]);
                    }
                    shortest_path.Add(sum);
                    listBox4.Items.AddRange(new object[] { i + 1 + ": " + sum});

                }
                int index = 0;
                double min = shortest_path[0];
                for (int i = 0; i < shortest_path.Count; i++)
                {
                    if (shortest_path[i] < min)
                    {
                        min = shortest_path[i];
                        index = i;
                    }
                }
                
                textBox1.Text = Convert.ToString(min);
                textBox4.Text = Convert.ToString(listBox3.Items[index]);
                
            } 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFullCalc_Click(object sender, EventArgs e)
        {

        }

        private void secondVertex_ValueChanged(object sender, EventArgs e)
        {

        }
        ////Explain: now a function to define the path length and way to get the relationship between vertex, and also get their direction
        
    }
}

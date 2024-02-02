namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TableLayoutPanel grid = new TableLayoutPanel();
            grid.Size = new System.Drawing.Size(500, 500);
            grid.Dock = DockStyle.Fill;
            grid.RowCount = 8;

            for (int i = 0; i < 8; i++)
            {
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 8f));
                for (int j = 0; j < 8; j++)
                {
                    Button chessSquare = new Button();
                    chessSquare.FlatStyle = FlatStyle.Flat;
                    chessSquare.FlatAppearance.BorderSize = 0;
                    chessSquare.Dock = DockStyle.Fill;


                    chessSquare.Size = new System.Drawing.Size(62, 62);

                    if ((i + j) % 2 == 0)
                        chessSquare.BackColor = Color.Black;
                    else
                        chessSquare.BackColor = Color.White;

                    grid.Controls.Add(chessSquare, j, i);
                }
            }

            Controls.Add(grid);
        }
    }
}

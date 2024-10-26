namespace WinFormsApp49
{
    public partial class Form1 : Form
    {
        private int clicked = 0, check = 0;
        public Form1()
        {
            InitializeComponent();

            TicTacToeButton [] buttons = new TicTacToeButton [9];
            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new TicTacToeButton(100) { Location = new Point(100 + 150 *(i % 3), 50 + 150 * (i / 3))};
                buttons[i].Click += Button1_Click;
            }
            this.Controls.AddRange(buttons);
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if(string.IsNullOrEmpty((sender as TicTacToeButton).Text))
            {
                if (clicked % 2 == 0) (sender as TicTacToeButton).ToCross();
                else (sender as TicTacToeButton).ToNull();
                clicked++;
                check++;

            }
        }
    }
}

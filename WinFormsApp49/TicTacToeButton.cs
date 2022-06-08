using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp49
{
    public class TicTacToeButton : Button
    {
        public TicTacToeButton(int size)
        {
            this.Width = size;
            this.Height = size;
        }

        public void ToCross()
        {
            this.Text = "X";
        }
        public void ToNull()
        {
            this.Text = "O";
        }
        
        new public int Size { get { return this.Width; } }
    }
}

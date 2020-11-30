using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    public partial class GoblimsGame_Frm : Form
    {

        Game_Engine game_Engine;


        public GoblimsGame_Frm()
        {
            InitializeComponent();
            game_Engine = new Game_Engine();
        }

        private void GoblimsGame_Frm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            game_Engine.MovePlayer(Movement.UP);
        }
    }
}

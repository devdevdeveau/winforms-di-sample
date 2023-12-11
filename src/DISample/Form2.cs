using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISample
{
    public partial class Form2 : Form
    {
        private readonly GameState _gameState;

        public Form2(GameState gameState)
        {
            _gameState = gameState;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("O");
        }
    }
}

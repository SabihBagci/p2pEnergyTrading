using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2pEnergyTrading
{
    public partial class SellPrompt : Form
    {
        private readonly User user;
        public Post result;
        public SellPrompt( User user )
        {
            this.user = user;
            InitializeComponent();
            EnergyInput.Maximum = ((decimal)user.Energy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = new Post(user.Uid, EnergyInput.Value.ToString(), PriceInput.Value.ToString());
            PostingManager.Instance.AddPosting(result);
        }

        private void EnergyInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PriceInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SellPrompt_Load(object sender, EventArgs e)
        {

        }
    }
}

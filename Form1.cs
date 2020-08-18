using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit;
using NUnit.Framework;

namespace Promotion_App
{
    [TestFixture]
    public partial class Form1 : Form
    {
        int A = 50;
        int B = 30;
        int C = 20;
        int D = 15;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            TestMethod();  
        }

        [Test]
        public void TestMethod()
        {
            int promotion1 = 1 * A;
            Assert.AreEqual(promotion1, 50);
            MessageBox.Show(promotion1.ToString());
            int promotion2 = 1 * B;
            Assert.AreEqual(promotion2, 30);
            MessageBox.Show(promotion2.ToString());
            int promotion3 = 1 * C;
            Assert.AreEqual(promotion3, 20);
            MessageBox.Show(promotion3.ToString());
        }
    }
}

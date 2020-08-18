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
            // First Set of Test Cases and Statements

            int promotion1 = 1 * A;
            Assert.AreEqual(promotion1, 50);
            MessageBox.Show(promotion1.ToString());
            int promotion2 = 1 * B;
            Assert.AreEqual(promotion2, 30);
            MessageBox.Show(promotion2.ToString());
            int promotion3 = 1 * C;
            Assert.AreEqual(promotion3, 20);
            MessageBox.Show(promotion3.ToString());
            int Sum1 = promotion1 + promotion2 + promotion3;
            Assert.AreEqual(Sum1,promotion1+promotion2+promotion3);


            // New Set Of Statements and Test Cases


            int secondpromotion1 = 5 * A;
            int secondpromotion2 = 5 * B;
            int secondpromotion3 = 1 * C;
            int Sum2 = secondpromotion1 + secondpromotion2 + secondpromotion3;
            Assert.AreEqual(Sum2, secondpromotion1 + secondpromotion2 + secondpromotion3);

            // New Set Of Statements and Test Cases

            int thirdPromotion1 = 3 * A;
            int thirdPromotion2 = 5 * B;
            int thirdPromotion3 = 1 * C;
            int thirdPromotion4 = 1 * D;
            int Sum3 = thirdPromotion1 + thirdPromotion2 + thirdPromotion3 + thirdPromotion4;
            Assert.AreEqual(Sum3, thirdPromotion1 + thirdPromotion2 + thirdPromotion3 + thirdPromotion4);
        }
    }
}

namespace PizzaApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPO_Click(object sender, EventArgs e)
        {

            int rbHawaianSmall = 100;
            int rbHawaianMedium = 150;
            int rbHawaianLarge = 200;

            int rbHaCSmall = 200;
            int rbHaCMedium = 300;
            int rbHaCLarge = 400;


            rtxtReceipt.Text += "Your Order is: \n";

            rtxtReceipt.Text += "\n";

            float pizzaTotal = 0;

            float hwSmall;
            float hwMedium;
            float hwLarge;
            if (rbHawaian.Checked)
            {
                rtxtReceipt.Text += "Hawaiian Pizza \n";

                if (rbSmall.Checked)
                {
                    if (rbThin.Checked)
                    {
                        hwSmall = rbHawaianSmall;
                        rtxtReceipt.Text += "\t Small and Thin Crust \t" + hwSmall;
                        pizzaTotal += hwSmall;
                    }
                    else if (rbThick.Checked)
                    {
                        hwSmall = rbHawaianSmall / 0.5f;
                        rtxtReceipt.Text += "\t Small and Thick Crust \t" + hwSmall;
                        pizzaTotal += hwSmall;

                    }

                }
                if (rbMedium.Checked)
                {
                    if (rbThin.Checked)
                    {
                        hwMedium = rbHawaianMedium;
                        rtxtReceipt.Text += "\t Medium and Thin Crust \t" + hwMedium;
                        pizzaTotal += hwMedium;
                    }
                    else if (rbThick.Checked)
                    {
                        hwMedium = rbHawaianMedium / 0.5f;
                        rtxtReceipt.Text += "\t Medium and Thick Crust \t" + hwMedium;
                        pizzaTotal += hwMedium;
                    }
                }

                if (rbLarge.Checked)
                {
                    if (rbThin.Checked)
                    {
                        hwLarge = rbHawaianLarge;
                        rtxtReceipt.Text += "\t Large and Thin Crust \t" + hwLarge;
                        pizzaTotal += hwLarge;
                    }
                    else if (rbThick.Checked)
                    {
                        hwLarge = rbHawaianLarge / 0.5f;
                        rtxtReceipt.Text += "\t Large and Thick Crust \t" + hwLarge;
                        pizzaTotal += hwLarge;
                    }
                }
            }

            float overallTotal = 0;

            float hacSmall;
            float hacMedium;
            float hacLarge;

            if (rbHaC.Checked)
            {
                rtxtReceipt.Text += "Ham and Cheese Pizza \n";

                if (rbSmall.Checked)
                {
                    if (rbThin.Checked)
                    {
                        hacSmall = rbHaCSmall;
                        rtxtReceipt.Text += "\t Small and Thin Crust \t" + hacSmall;
                        pizzaTotal += hacSmall;
                    }
                    else if (rbThick.Checked)
                    {
                        hacSmall = rbHaCSmall / 0.5f;
                        rtxtReceipt.Text += "\t Small and Thick Crust \t" + hacSmall;
                        pizzaTotal += hacSmall;
                    }
                }

                if (rbMedium.Checked)
                {
                    if (rbThin.Checked)
                    {
                        hacMedium = rbHaCMedium;
                        rtxtReceipt.Text += "\t Medium and Thin Crust \t" + hacMedium;
                        pizzaTotal += hacMedium;
                    }
                    else if (rbThick.Checked)
                    {
                        hacMedium = rbHaCMedium / 0.5f;
                        rtxtReceipt.Text += "\t Medium and Thick Crust \t" + hacMedium;
                        pizzaTotal += hacMedium;
                    }
                }

                if (rbLarge.Checked)
                {
                    if (rbThin.Checked)
                    {
                        hacLarge = rbHaCLarge;
                        rtxtReceipt.Text += "\t Large and Thin Crust \t" + hacLarge;
                        pizzaTotal += hacLarge;
                    }
                    else if (rbThick.Checked)
                    {
                        hacLarge = rbHaCLarge / 0.5f;
                        rtxtReceipt.Text += "\t Large and Thick Crust \t" + hacLarge;
                        pizzaTotal += hacLarge;
                    }

                }

            }

            rtxtReceipt.Text += "\n";
            rtxtReceipt.Text += "\n";

            rtxtReceipt.Text += "Extra Toppings: \n";

            float total = 0;

            int tomatoes = 10, onions = 10;
            int pineapple = 15;
            int xtracheese = 20, mushrooms = 20;

            if (cbCheese.Checked)
            {
                rtxtReceipt.Text += "\t Extra Cheese \t" + xtracheese + "\n";
                total += xtracheese;

            }

            if (cbMushroom.Checked)
            {
                rtxtReceipt.Text += "\t Mushrooms \t" + mushrooms + "\n";
                total += mushrooms;

            }

            if (cbOnion.Checked)
            {
                rtxtReceipt.Text += "\t Onions \t \t" + onions + "\n";
                total += onions;

            }

            if (cbPineapple.Checked)
            {
                rtxtReceipt.Text += "\t Pineapple \t" + pineapple + "\n";
                total += pineapple;

            }

            if (cbTomatoe.Checked)
            {
                rtxtReceipt.Text += "\t Tomatoes \t" + tomatoes + "\n";
                total += tomatoes;

            }

            rtxtReceipt.Text += "\n";
            rtxtReceipt.Text += "\t \t \tEXTRA TOPPINGS TOTAL: \t" + total;
            rtxtReceipt.Text += "\n";
            rtxtReceipt.Text += "\n";

            overallTotal = pizzaTotal + total;
            rtxtReceipt.Text += "\t \t \t \tOVERALL TOTAL: \t" + overallTotal;
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            rtxtReceipt.Clear();
            if (rbHawaian.Checked)
                rbHawaian.Checked = false;
            if (rbHaC.Checked)
                rbHaC.Checked = false;
            if (rbSmall.Checked)
                rbSmall.Checked = false;
            if (rbMedium.Checked)
                rbMedium.Checked = false;
            if (rbLarge.Checked)
                rbLarge.Checked = false;
            if (rbThin.Checked)
                rbThin.Checked = false;
            if (rbThick.Checked)
                rbThick.Checked = false;
            if (cbCheese.Checked)
                cbCheese.Checked = false;
            if (cbMushroom.Checked)
                cbMushroom.Checked = false;
            if (cbOnion.Checked)
                cbOnion.Checked = false;
            if (cbPineapple.Checked)
                cbPineapple.Checked = false;
            if (cbTomatoe.Checked)
                cbTomatoe.Checked = false;
        }
    }
}
       









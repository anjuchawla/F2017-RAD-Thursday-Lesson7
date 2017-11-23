/*
 * Name : Anju Chawla
 * Date : November, 2017
 * Purpose: To allow the user to select coffee and syrup flavours.
 * New coffee flavours can be added and old ones removed. 
 * The entire coffee list can be cleared and number of coffee flavours can be displayed.
 * Can print all available coffee flavours and only selected ones too.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson6
{
    public partial class frmCoffeeSyrup : Form
    {
        public frmCoffeeSyrup()
        {
            InitializeComponent();
        }
      
       
        /// <summary>
        /// Close/terminate the application
        /// </summary>
        /// <param name="sender">The sender of the event-the Exit menu item</param>
        /// <param name="e">The event arguments</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void printAllDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Handle printing and print previews when printing all flavours.

            Font printFont = new Font("Arial", 12);
            float lineHeightFloat = printFont.Height + 2;
            float horizontalPrintLocationFloat = e.MarginBounds.Left;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            string printLineString;

            //Print the heading
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawString("Coffee Flavours", headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);

            // Loop through the entire list.
            //for (int listIndexInteger = 0; listIndexInteger < CoffeeComboBox.Items.Count - 1; listIndexInteger++)
            if (cboCoffee.Items.Count > 0)
            {
                foreach (Object flavor in cboCoffee.Items)
                {
                    //increment the  Y position for the next line.
                    verticalPrintLocationFloat += lineHeightFloat;

                    //Set up a line
                    //PrintLineString = CoffeeComboBox.Items[ListIndexInteger].ToString();
                    printLineString = flavor.ToString();
                    //Send the line to the graphics page object.
                    e.Graphics.DrawString(printLineString, printFont,
                        Brushes.Black, horizontalPrintLocationFloat,
                        verticalPrintLocationFloat);
                } // end for
            }
            else
            {
                MessageBox.Show("No coffee flavours available", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void printSelectedDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Handle printing and print previews when printing selected items.

            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float lineHeightFloat = printFont.Height + 2;
            float horizontalPrintLocationFloat = e.MarginBounds.Left;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            string printLineString;

            //Set up and display heading lines
            printLineString = "Print Selected Item";
            e.Graphics.DrawString(printLineString, headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);
            printLineString = "by Anju Chawla";
            verticalPrintLocationFloat += lineHeightFloat;
            e.Graphics.DrawString(printLineString, headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);

            // Leave a blank line between the heading and detail line.
            verticalPrintLocationFloat += lineHeightFloat * 2;
            // Set up the selected line.
            printLineString = "Coffee: " + cboCoffee.Text +
                "     Syrup: " + lstSyrup.Text;
            // Send the line to the graphics page object.
            e.Graphics.DrawString(printLineString, printFont,
                Brushes.Black, horizontalPrintLocationFloat,
                  verticalPrintLocationFloat);

        }
        /// <summary>
        /// It displays information about the company and the product
        /// </summary>
        /// <param name="sender">The About menu item</param>
        /// <param name="e">Event Arguments</param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            frmAbout info = new frmAbout();
            info.ShowDialog();
        }
        /// <summary>
        /// Allows th user to add a new coffee flavour to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAddCoffeeFlavour_Click(object sender, EventArgs e)
        {
            bool itemFound;
            

            //if the user has provided a new flavour
            if(cboCoffee.Text.Trim() != String.Empty)
            {
                itemFound = CheckFlavour(cboCoffee.Text);
                if(itemFound) //flavour already present
                {
                    MessageBox.Show("Duplicate flavour cannot be added",
                        "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboCoffee.SelectAll();
                    cboCoffee.Focus();

                }
                else
                {
                    //add the flavour
                    cboCoffee.Items.Add(cboCoffee.Text.Trim());
                    cboCoffee.Text = String.Empty;
                }

            }
            else // no flavour provided
            {
                MessageBox.Show("Enter a coffee flavour to add", "Missing Data", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCoffee.Focus();
            }

        }

        private bool CheckFlavour(string text)
        {
           
            foreach(Object item in cboCoffee.Items)
            {
              
                return text.Equals((String)item, StringComparison.CurrentCultureIgnoreCase);
            }

            return false;



        }

        private void tsmiRemoveCoffeeFlavour_Click(object sender, EventArgs e)
        {
            //to force the user to select from the list
            cboCoffee.DropDownStyle = ComboBoxStyle.DropDownList;
            

         
        }

        private void cboCoffee_SelectedIndexChanged(object sender, EventArgs e)
        {
            //no selection made
            if (cboCoffee.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the flavour to delete", "Delete Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCoffee.Focus();
            }
            else
            {
                cboCoffee.Items.Remove(cboCoffee.Text);
            }

            //back to default
            cboCoffee.DropDownStyle = ComboBoxStyle.DropDown;
        }

       /// <summary>
       /// Print the selected options
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void tsmiPrintSelected_Click(object sender, EventArgs e)
        {
            if (lstSyrup.SelectedIndex == -1)
                lstSyrup.SelectedIndex = 0;

            if (cboCoffee.SelectedIndex != -1)
                printSelectedDocument.Print();
            else
            {
                MessageBox.Show("Please select a Coffee flavour", "Print Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCoffee.Focus();
            }

        }

        private void tsmiPreviewSelected_Click(object sender, EventArgs e)
        {
            if (lstSyrup.SelectedIndex == -1)
                lstSyrup.SelectedIndex = 0;

            if (cboCoffee.SelectedIndex != -1)
            {
                printPreviewDialog1.Document = printSelectedDocument;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a Coffee flavour", "Print Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCoffee.Focus();
            }

        }

        private void tsmiPrintAll_Click(object sender, EventArgs e)
        {
            printAllDocument.Print();
        }

        private void tsmiPreviewAll_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printAllDocument;
            printPreviewDialog1.ShowDialog();
        }
    }
}

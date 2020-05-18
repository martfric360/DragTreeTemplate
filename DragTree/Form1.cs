using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DragTree 
{
    public partial class Form1 : Form
    {
        // TODO - create an int variable to track currentRow,
        int currentRow = 1;
        // TODO - create a Stopwatch object called stopwatch 
        Stopwatch stopwatch = new Stopwatch(); 
        // TODO - create a timer on the form called lightTimer (interval 400ms)
       

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // TODO - start the timer
            lightTimer.Enabled = true;
            
            
        }



        private void goButton_Click(object sender, EventArgs e)
        {
            // TODO - stop the stopwatch
            stopwatch.Stop();
            // TODO - check if the ellapsed time in milliseconds is > 0. 
            if(stopwatch.ElapsedMilliseconds > 0)
            {
                timeLabel.Text = Convert.ToString(stopwatch.ElapsedMilliseconds);
            }
            else
            {
                timeLabel.Text = "Foul Start"; 
            }
            

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // TODO - reset the stopwatch
            stopwatch.Reset();
            lightTimer.Stop();
            // TODO - put rows 1-3 colours back to DimGray and row 4 back to DarkOliveGreen
            row4col2.BackColor = Color.DarkOliveGreen;
            row4col1.BackColor = Color.DarkOliveGreen;
            row3col2.BackColor = Color.DimGray;
            row3col1.BackColor = Color.DimGray;
            row2col2.BackColor = Color.DimGray;
            row2col1.BackColor = Color.DimGray;
            row1col2.BackColor = Color.DimGray;
            row1col1.BackColor = Color.DimGray;
            // TODO - reset row value and timeLabel text
            timeLabel.Text = "0.000";
            currentRow = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // TODO - increment the currentRow value by 1
            // TODO - create a switch block that checks currentRow. In each case
            // it will light up the appropriate lights, (labels). 
            currentRow++; 
            switch (currentRow)
            {
                case 2:
                    row1col1.BackColor = Color.Yellow;
                    row1col2.BackColor = Color.Yellow; 
                    break;
                case 3:
                    row2col1.BackColor = Color.Yellow;
                    row2col2.BackColor = Color.Yellow;
                    break;
                case 4:
                    row3col1.BackColor = Color.Yellow;
                    row3col2.BackColor = Color.Yellow;
                    break;
                case 5:
                    row4col1.BackColor = Color.Green;
                    row4col2.BackColor = Color.Green;
                    stopwatch.Start();
                    break;
                
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HighPerformaceWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StringBuilderPerformace();
        }

        public String StringBuilderPerformace()
        {
            StringBuilder sb = new StringBuilder();
            String str = "";
            int start = DateTime.Now.Millisecond;
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
                sb.Append(", ");
            }
            str = sb.ToString();
            int end = DateTime.Now.Millisecond;
            //Console.WriteLine(str);
            Console.WriteLine("Took: " + (end-start) +" ms.");
            
            return "";
        }
    }
}
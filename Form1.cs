using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shiney_waffle
{
    public partial class Form1 : Form
    {
        private static Script script;

        public Form1()
        {
            InitializeComponent();
        }

        private static double TableTestReverse()
        {
            string scriptCode = @"return dosum{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}";

            script = new Script();

            script.Globals["dosum"] = (Func<List<int>, int>)(l => l.OfType<int>().Sum());

            DynValue res = script.DoString(scriptCode);

            return res.Number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DynValue res = luaScript.Globals.Get(luaScript.Globals["getStates"]);
            //label1.Text = "Result of function is " + EnumerableTest().ToString();
            label1.Text = "Result of returning a table is " + TableTestReverse().ToString();
        }
    }
}

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


        private static Table GetNumberTable(Script script)
        {
            Table tbl = new Table(script);

            for (int i = 1; i <= 10; i++)
                tbl[i] = i;

            return tbl;
        }

        private static double TableTest2()
        {
            string scriptCode = @"
                total = 0

                tbl = getNumbers()

                for _, i in ipairs(tbl) do 
                    total = total + i
                end

                return total
            ";

            script = new Script();

            script.Globals["getNumbers"] = (Func<Script, Table>)GetNumberTable;

            DynValue res = script.DoString(scriptCode);

            return res.Number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DynValue res = luaScript.Globals.Get(luaScript.Globals["getStates"]);
            //label1.Text = "Result of function is " + EnumerableTest().ToString();
            label1.Text = "Result of returning a table is " + TableTest2().ToString();
        }
    }
}

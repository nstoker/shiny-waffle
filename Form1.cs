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

        double CallMyClass1()
        {
            string scriptCode = @"return obj.calcHyponenuse(3, 4)";

            UserData.RegisterAssembly();

            script = new Script();

            script.Globals["obj"] = new myClass();

            DynValue res = script.DoString(scriptCode);

            return res.Number;
        }

        double CallMyClass2()
        {
            string scriptCode = @"return obj.calcHyponenuse(3, 4)";

            UserData.RegisterType<myClass>();

            script = new Script();

            DynValue obj = UserData.Create(new myClass());

            script.Globals.Set("obj", obj);

            DynValue res = script.DoString(scriptCode);

            return res.Number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DynValue res = luaScript.Globals.Get(luaScript.Globals["getStates"]);
            //label1.Text = "Result of function is " + EnumerableTest().ToString();
            label1.Text = "hypotenuse is " + CallMyClass2().ToString();
        }
    }

    [MoonSharpUserData]
    class myClass
    {
        public double calcHyponenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
    }
}

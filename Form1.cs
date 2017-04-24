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

            InitialiseMoonsharp();
        }

        private static int Mul(int a, int b)
        {
            return a * b;
        }

        private string MoonSharpFactorialSource()
        {
            string script = @"
                -- defines a factorial function
                function fact(n)
                  if(n==0) then
                    return 1
                  else
                    return n*fact(n-1)
                  end
                end";

            return script;
        }

        private double CallbackTest()
        {
            string scriptCode = MoonSharpFactorialSource();

            script = new Script();

            script.DoString(MoonSharpFactorialSource());

            script.Globals["Mul"] = (Func<int,int,int>)Mul;
            DynValue res = script.Call(script.Globals["fact"], 4);
            return res.Number;
        }

        private static IEnumerable<int> GetNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i;
            }
        }

        private static double EnumerableTest()
        {
            string scriptCode = @"
                total = 0;

                for i in getNumbers() do
                  total = total + i;
                end

                return total;
                ";

            script = new Script();
            script.Globals["getNumbers"] = (Func<IEnumerable<int>>)GetNumbers;
            
            DynValue res = script.DoString(scriptCode);
            return res.Number;
            
        }
        private void InitialiseMoonsharp()
        {
            //// Sets up the moonsharp environment
            //try
            //{
            //    luaScript = new Script();
            //    luaScript.Options.ScriptLoader = new EmbeddedResourcesScriptLoader();
            //    Script.DefaultOptions.ScriptLoader = new EmbeddedResourcesScriptLoader();
            //    ((ScriptLoaderBase)luaScript.Options.ScriptLoader).ModulePaths = new string[] { "Scripts/?.lua", "Scripts/?" };
            //    luaScript.LoadFile("Scripts/smwrapper.lua",null,"wrapper");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"EXCEPTION {ex}");
            //    throw;
            //}
        }

        private static List<int> GetNumberList()
        {
            List<int> lst = new List<int>();

            for (int i = 1; i <= 10; i++)
                lst.Add(i);

            return lst;
        }

        private static double TableTest1()
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

            script.Globals["getNumbers"] = (Func<List<int>>)GetNumberList;

            DynValue res = script.DoString(scriptCode);

            return res.Number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DynValue res = luaScript.Globals.Get(luaScript.Globals["getStates"]);
            //label1.Text = "Result of function is " + EnumerableTest().ToString();
            label1.Text = "Result of returning a table is " + TableTest1().ToString();
        }
    }
}

using MoonSharp.Interpreter;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace shiney_waffle
{
    /// <summary>
    /// This is a form to test the LUA script handling.
    /// </summary>
    public partial class Form1 : Form
    {
        private static Script script;

        #region WinFormControls
        /// <summary>
        /// Main initialiser
        /// </summary>
        public Form1()
        {
            script = new Script();

            InitializeComponent();

            createNewScript();
        }



        /// <summary>
        /// Creates a new script based on the standard template.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newScript_Click(object sender, EventArgs e)
        {
            createNewScript();
        }



        /// <summary>
        /// Load a script from the file system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.InitialDirectory= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "lua files (*.lua)|*.lua|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                if(File.Exists(openFileDialog.FileName))
                {
                    richTextBoxWithLineNumbers1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }



        /// <summary>
        /// Save Script to file system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveScript_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "lua files (*.lua)|*.lua|All files (*.*)|*.*";
            saveDialog.FilterIndex = 0;
            saveDialog.RestoreDirectory = true;
            saveDialog.OverwritePrompt = true;
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if(saveDialog.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, richTextBoxWithLineNumbers1.Text);
            }
        }



        /// <summary>
        /// Run the test code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testScript_Click(object sender, EventArgs e)
        {
            script.LoadString(richTextBoxWithLineNumbers1.Text);
            throw new NotImplementedException();
        }
        #endregion



        /// <summary>
        /// Create a new script based on the template
        /// </summary>
        private void createNewScript()
        {
            richTextBoxWithLineNumbers1.Clear();

            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "Scripts.client_sm.lua";

            using (Stream stream = assembly.GetManifestResourceStream("shiney_waffle." + resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                richTextBoxWithLineNumbers1.Text = reader.ReadToEnd();
            }
        }
    }
}

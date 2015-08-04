﻿namespace TTR.Code
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml.Serialization;

    [Serializable]
    public class CodeSnippet
    {
        [NonSerialized]
        private static readonly string skeltonCode0 = "namespace TestNamespace { {0} public class TestClass { {1} public void Initialize() { {2} } public void Run() { {3} } } }";

        [NonSerialized]
        private static readonly string skeletonCode =
            // This looks stupid in the source code but allows the verbatim string to better display
            // spacing in text boxes (which is currently being used for debugging purposes)
@"namespace TestNamespace 
{
    {0}
    public class TestClass
    {
        {1}
        public void Initialize() 
        {
            {2}
        } 
        public void Run() 
        {
            {3}
        }
    } 
}";

        public string CodeName
        {
            get;
            set;
        }

        public string UsingStatements
        {
            get;
            set;
        }

        public string VariableDeclarations
        {
            get;
            set;
        }

        public string VariableInitialization
        {
            get;
            set;
        }

        public string CodeToTime
        {
            get;
            set;
        }

        public CodeSnippet()
        {
            this.UsingStatements = string.Empty;
            this.VariableDeclarations = string.Empty;
            this.VariableInitialization = string.Empty;
            this.CodeToTime = string.Empty;
        }

        public CodeSnippet(CodeSnippet codeSnippet)
        {
            this.CodeName = codeSnippet.CodeName;
            this.UsingStatements = codeSnippet.UsingStatements;
            this.VariableDeclarations = codeSnippet.VariableDeclarations;
            this.VariableInitialization = codeSnippet.VariableInitialization;
            this.CodeToTime = codeSnippet.CodeToTime;
        }

        public CodeSnippet(string usingStatements, string variableDeclarations, string variableInitialization, string codeToTime)
        {
            this.UsingStatements = usingStatements;
            this.VariableDeclarations = variableDeclarations;
            this.VariableInitialization = variableInitialization;
            this.CodeToTime = codeToTime;
        }

        public string AsCompilableString()
        {
            // I certainly don't like this as a final solution but for the moment it suffices and is easy to work with (at this size)
            // I originally intended to simply use string.format with this code but the string literals are not playing nicely
            // with the verbatim string that I want to use right now to increase ease of development

            var sb = new StringBuilder(skeletonCode);

            sb.Replace("{0}", this.UsingStatements);
            sb.Replace("{1}", this.VariableDeclarations);
            sb.Replace("{2}", this.VariableInitialization);
            sb.Replace("{3}", this.CodeToTime);

            return sb.ToString();
        }

        public void SaveTo(string filename)
        {
            string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "TTRCode", filename + ".ttrx");

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(fs, this);
            }
        }

        public static bool LoadFromDialog(out CodeSnippet codeSnippet)
        {
            codeSnippet = null;

            System.Windows.Forms.OpenFileDialog fileDialog = new System.Windows.Forms.OpenFileDialog();

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    using (Stream stream = fileDialog.OpenFile())
                    {
                        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        codeSnippet = (CodeSnippet)binaryFormatter.Deserialize(stream);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                }
            }

            return false;
        }

        public static CodeSnippet Load(string path)
        {
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (CodeSnippet)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
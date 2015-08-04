namespace TTR.Code
{
    using System;
    using System.Collections.Generic;

    public class TempCodeSnippet : CodeSnippet
    {
        private string sessionName = null;

        private static int tempSessionNameCount = 0;

        private static readonly string tempSessionNameBase = "TTR_TempSessionName";

        private static Dictionary<TempCodeSnippet, string> sessionNameDictionary = new Dictionary<TempCodeSnippet, string>();

        public string SessionName
        {
            get
            {
                if (this.sessionName == null)
                {
                    if (!string.IsNullOrWhiteSpace(this.CodeName))
                    {
                        this.sessionName = this.CodeName;
                    }
                    else
                    {
                        this.sessionName = GetNextTempSessionName();
                    }
                }

                return this.sessionName;
            }
        }

        public TempCodeSnippet(CodeSnippet codeSnippet) :
            base (codeSnippet)
        {
        }

        private static string GetNextTempSessionName()
        {
            string name = tempSessionNameBase + tempSessionNameCount;

            tempSessionNameCount++;

            return name;
        }
    }
}

namespace TimeToRun.Types
{
    using System.Text;

    public class CompilableString
    {
        private readonly string skeletonCode = @"namespace TestNamespace 
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

        private string usingStatements; //{0} in skeletonCode
        private string variableDeclarations; //{1} in skeletonCode
        private string variableInitialization; //{2} in skeletonCode
        private string codeToTime; //{3} in skeletonCode

        public CompilableString(string usingStatements, string variableDeclarations, string variableInitialization, string codeToTime)
        {
            this.usingStatements = usingStatements;
            this.variableDeclarations = variableDeclarations;
            this.variableInitialization = variableInitialization;
            this.codeToTime = codeToTime;
        }

        public override string ToString()
        {
            // I certainly don't like this as a final solution but for the moment it suffices and is easy to work with (at this size)
            // I originally intended to simply use string.format with this code but the string literals are not playing nicely
            // with the verbatim string that I want to use right now to increase ease of development

            var sb = new StringBuilder(skeletonCode);
            sb.Replace("{0}", this.usingStatements);
            sb.Replace("{1}", this.variableDeclarations);
            sb.Replace("{2}", this.variableInitialization);
            sb.Replace("{3}", this.codeToTime);
            return sb.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTR
{
    using TTR.Code;

    public interface ICodeSnippetTextSet
    {
        void DisplayDefaultText();

        void SetCurrentCodeSnippet(CodeSnippet codeSnippet);

        CodeSnippet GetCurrentCodeSnippet();
    }
}

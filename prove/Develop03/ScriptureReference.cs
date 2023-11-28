using System;

namespace Develop03
{
    public class ScriptureReference
    {
        public string Reference { get; private set; } // Reference text

        public ScriptureReference(string reference)
        {
            Reference = reference;
        }
    }
}

using Workflow;
using System.Diagnostics;

namespace Steps
{
    public class Clean : Step
    {
        private readonly string projectPath;

        public Clean(string projectPath)
        {
            this.projectPath = projectPath;
        }

        public override void Execute()
        {
            Process.Start("cmd.exe", "/c \"" + projectPath + "\\Binaries\\Win64\\UE4Editor.exe\" " + projectPath + ".uproject /clean");
        }
    }
}
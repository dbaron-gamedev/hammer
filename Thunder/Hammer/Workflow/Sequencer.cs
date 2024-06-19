namespace Workflow
{
    public class Sequencer
    {
        private readonly List<Step> steps;

        public Sequencer()
        {
            steps = new List<Step>();
        }

        public void AddStep(Step step)
        {
            steps.Add(step);
        }

        public void Execute()
        {
            foreach (Step step in steps)
            {
                step.Execute();
            }
        }
    }
}
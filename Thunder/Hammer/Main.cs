using Steps;
using Workflow;

var sequencer = new Sequencer();
sequencer.AddStep(new Clean("C:\\UnrealProjects\\MyProject")); //TODO: Project entity should hold path info.
sequencer.Execute();
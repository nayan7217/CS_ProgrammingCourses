using CS_Module6_Exercise_Q1;


List<IActivity> activityList = new List<IActivity>();


activityList.Add(new Plan());
activityList.Add(new Design());
activityList.Add(new Coding());
activityList.Add(new Deployment()); 


WorkflowEngine workflowEngine = new WorkflowEngine();

workflowEngine.Run(activityList);


using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;
using optcdkcs;

namespace OptSgstudio
{
    sealed class Program
    {

        public static void Main(string[] args)
        {
            OptAWSCDKFun stackInfo = new OptAWSCDKFun("opt-dev-SGMStudio");

            //Console.WriteLine(stackInfo.stackProps.Project);
            var app = new App();
            new OptSgstudioStack(app, stackInfo.StackName("studio"), new StackProps
            {
                //Name of Stack: opt-SGMS-dev-studio
                Description = stackInfo.StackName("studio"),
                Env = stackInfo.CreateEnv(),
                Synthesizer = stackInfo.CreateStackSynthesizer("studio")
            });
            app.Synth();
        }
    }
}

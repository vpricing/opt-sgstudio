using Amazon.CDK;
using Constructs;
using Amazon.CDK.AWS.Sagemaker;
using Amazon.CDK.AWS.IAM;

namespace OptSgstudio
{
    public class OptSgstudioStack : Stack
    {
        internal OptSgstudioStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            Role optStudioRole;
            string DomainName = "vol-opt-studio-dev";

            CfnDomain optStudioDomain = new CfnDomain(this, "optStudio-Domain", new CfnDomainProps
            {
                AuthMode = "IAM",
                DefaultUserSettings = new 


            })
            
        }
    }
}

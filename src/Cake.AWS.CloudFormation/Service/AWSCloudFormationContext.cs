using Cake.AWS.CloudFormation.Models;
using Cake.Core;

namespace Cake.AWS.CloudFormation.Service
{
    internal class AWSCloudFormationContext
    {
        public AWSCloudFormationContext(ICakeContext cakeContext, AuthenticationSettings authenticationSettings)
        {
            
        }

        public void Create(CreateStackRequest createStackRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}
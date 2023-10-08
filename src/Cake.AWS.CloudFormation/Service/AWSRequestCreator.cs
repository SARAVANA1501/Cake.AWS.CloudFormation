using System.Linq;
using Amazon.CloudFormation.Model;

namespace Cake.AWS.CloudFormation.Service
{
    internal static class AWSRequestCreator
    {
        public static CreateStackRequest CreateRequest(this Models.CreateStackRequest createStackRequest)
            => new CreateStackRequest
            {
                Capabilities = createStackRequest.Capabilities?.ToList(),
                ClientRequestToken = createStackRequest.ClientRequestToken,
                DisableRollback = createStackRequest.DisableRollback,
                EnableTerminationProtection = createStackRequest.EnableTerminationProtection,
                NotificationARNs = createStackRequest.NotificationARNs?.ToList(),
                OnFailure = createStackRequest.OnFailure,
                Parameters = createStackRequest.Parameters?
                    .Select(t =>
                        new Parameter { ParameterKey = t.Key, ParameterValue = t.Value }).ToList(),
                ResourceTypes = createStackRequest.ResourceTypes?.ToList(),
                RetainExceptOnCreate = createStackRequest.RetainExceptOnCreate,
                RoleARN = createStackRequest.RoleARN,
                StackName = createStackRequest.StackName,
                StackPolicyBody = createStackRequest.StackPolicyBody,
                StackPolicyURL = createStackRequest.StackPolicyURL,
                Tags = createStackRequest.Tags?
                    .Select(t => new Tag() { Key = t.Key, Value = t.Value }).ToList(),
                TemplateBody = createStackRequest.TemplateBody,
                TemplateURL = createStackRequest.TemplateURL,
                TimeoutInMinutes = createStackRequest.TimeoutInMinutes
            };
    }
}
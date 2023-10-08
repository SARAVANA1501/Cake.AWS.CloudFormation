using System.Collections.Generic;

namespace Cake.AWS.CloudFormation.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateStackRequest
    {
        public string[] Capabilities { get; set; }
        public string ClientRequestToken { get; set; }
        public bool DisableRollback { get; set; }
        public bool EnableTerminationProtection { get; set; }
        public string[] NotificationARNs { get; set; }
        public string OnFailure { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public string[] ResourceTypes { get; set; }
        public bool RetainExceptOnCreate { get; set; }
        public string RoleARN { get; set; }
        public string StackName { get; set; }
        public string StackPolicyBody { get; set; }
        public string StackPolicyURL { get; set; }
        public Dictionary<string, string> Tags { get; set; }
        public string TemplateBody { get; set; }
        public string TemplateURL { get; set; }
        public int TimeoutInMinutes { get; set; }
        public AuthenticationSettings AuthenticationSettings { get; set; }
        public bool CanWaitForCompletion { get; set; }
    }
}
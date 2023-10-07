using Amazon.Runtime;

namespace Cake.AWS.CloudFormation.Models
{
    public class AuthenticationSettings
    {
        public AuthTypeEnum AuthType { get; set; }
        public AWSCredentials AwsCredentials { get; set; }
        public string AWSAccessKeyId { get; set; }
        public string AWSSecretAccessKey { get; set; }
        public string Region { get; set; }
    }
}
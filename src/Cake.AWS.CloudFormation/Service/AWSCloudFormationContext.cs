using System.Threading.Tasks;
using Amazon;
using Amazon.CloudFormation;
using Cake.AWS.CloudFormation.Models;
using Cake.Core;
using Cake.Core.Diagnostics;

namespace Cake.AWS.CloudFormation.Service
{
    internal class AWSCloudFormationContext
    {
        private readonly ICakeContext _cakeContext;
        private AmazonCloudFormationClient _client;
        private readonly AuthenticationSettings _authenticationSettings;

        public AWSCloudFormationContext(ICakeContext cakeContext, AuthenticationSettings authenticationSettings)
        {
            _cakeContext = cakeContext;
            this._authenticationSettings = authenticationSettings;
            this.CreateClient(authenticationSettings);
        }

        private void CreateClient(AuthenticationSettings authenticationSettings)
        {
            if (string.IsNullOrWhiteSpace(authenticationSettings.Region) ||
                RegionEndpoint.GetBySystemName(authenticationSettings.Region) == null)
            {
                throw new CakeException("Invalid Region.");
            }

            var region = RegionEndpoint.GetBySystemName(authenticationSettings.Region);
            var client = authenticationSettings.AuthType switch
            {
                AuthTypeEnum.UseSystemRole => new AmazonCloudFormationClient(region),
                AuthTypeEnum.UserClientIdSecret => new AmazonCloudFormationClient(authenticationSettings.AWSAccessKeyId,
                    authenticationSettings.AWSSecretAccessKey, region),
                AuthTypeEnum.UseAWSCredential => new AmazonCloudFormationClient(authenticationSettings.AwsCredentials,
                    region),
                _ => throw new CakeException("Invalid authentication configuration.")
            };
            this._client = client;
        }

        public async Task CreateAsync(CreateStackRequest createStackRequest)
        {
            this._cakeContext.Log.Information("Starting Cloudformation stack creation.");
            this._cakeContext.Log.Debug($"Region selected: {this._authenticationSettings.Region}");
            var response = await this._client.CreateStackAsync(createStackRequest.CreateRequest());
        }
    }
}
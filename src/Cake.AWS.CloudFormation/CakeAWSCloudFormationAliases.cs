using Cake.Core;
using Cake.Core.Annotations;
using Cake.AWS.CloudFormation.Models;
using Cake.AWS.CloudFormation.Service;

namespace Cake.AWS.CloudFormation
{
    /// <summary>
    /// Cake Add-in to create or update the Cloudformation stack in AWS cloud.
    /// </summary>
    [CakeAliasCategory("CakeAWSCloudFormation")]
    public static class CakeAWSCloudFormationAliases
    {
        /// <summary>
        /// Create Cloudformation stack in AWS cloud.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="createStackRequest"></param>
        [CakeMethodAlias]
        public static void CreateCloudFormationStack(this ICakeContext ctx, CreateStackRequest createStackRequest)
        {
            var context = new AWSCloudFormationContext(ctx, createStackRequest.AuthenticationSettings);
            context.CreateAsync(createStackRequest).Wait();
        }
    }
}
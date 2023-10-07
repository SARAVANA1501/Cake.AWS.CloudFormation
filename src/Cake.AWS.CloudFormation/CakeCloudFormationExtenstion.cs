using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.Diagnostics;
using Amazon;
using Amazon.CloudFormation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime;
using Cake.AWS.CloudFormation.Models;
using Cake.AWS.CloudFormation.Service;

namespace Cake.AWS.CloudFormation
{
    /// <summary>
    /// 
    /// </summary>
    [CakeAliasCategory("CakeCloudFormationExtenstion")]
    public static class CakeCloudFormationExtenstionAliases
    {
        [CakeMethodAlias]
        public static void CreateCloudFormationStack(this ICakeContext ctx, CreateStackRequest createStackRequest)
        {
            var context = new AWSCloudFormationContext(ctx, createStackRequest.AuthenticationSettings);
            context.Create(createStackRequest);
        }
    }
}
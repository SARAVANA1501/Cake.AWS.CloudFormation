# Cake.AWS.CloudFormation
Cake add-in helps to create or update the Cloudformation stack of the AWS cloud.

![example workflow](https://github.com/SARAVANA1501/Cake.AWS.CloudFormation/actions/workflows/build.yml/badge.svg)

### How to use?

#### Prerequisite

Make sure the role or machine used for the deployment having following permissions

```
"cloudformation:CreateChangeSet",
"cloudformation:CreateStack",
"cloudformation:DeleteStack",
"cloudformation:DescribeChangeSet",
"cloudformation:DescribeStackEvents",
"cloudformation:DescribeStacks",
"cloudformation:ExecuteChangeSet",
"cloudformation:GetTemplateSummary",
"cloudformation:ListStackResources",
"cloudformation:UpdateStack"
```
#### Sample code
```
using Cake.AWS.CloudFormation.Models;
using Cake.AWS.CloudFormation;

Task("Default")
.Does((context) => {
    var config = new CreateStackRequest{
        AuthenticationSettings=new AuthenticationSettings{
            AuthType=AuthTypeEnum.UseSystemRole,
            Region="eu-west-1"
        },
        StackName="test-stack",
        TemplateBody=@"Resources:
                        HelloBucket:
                          Type: 'AWS::S3::Bucket'
                          Properties:
                            AccessControl: PublicRead"
    };
    context.CreateCloudFormationStack(config);
});
```
# Multiple Endpoint Lamba C# Project

This starter project consists of:

- serverless.template - an AWS CloudFormation Serverless Application Model template file for declaring your Serverless functions and other AWS resources. Especially API endpoints to map to the same lambda
- Function.cs - class file containing the C# method mapped to the single function declared in the template file
- aws-lambda-tools-defaults.json - default argument settings for use with Visual Studio and command line deployment tools for AWS

Please create a s3 bucket( in region us-east-1, to change region => modify aws-lambda-tools-defaults.json) and have it's name handy. It will be used while deploying

## Here are some steps to follow to get started from the command line:

Once you have edited your template and code you can deploy your application using the [Amazon.Lambda.Tools Global Tool](https://github.com/aws/aws-extensions-for-dotnet-cli#aws-lambda-amazonlambdatools) from the command line.

Install Amazon.Lambda.Tools Global Tools if not already installed.

```
    dotnet tool install -g Amazon.Lambda.Tools
```

If already installed check if new version is available.

```
    dotnet tool update -g Amazon.Lambda.Tools
```

Deploy application

```
    dotnet lambda deploy-serverless
```

After the deployment is completed, you would see the Endpoints in the command line logs

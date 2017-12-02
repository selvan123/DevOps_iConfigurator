
aws cloudformation create-stack --stack-name stackjenkins --template-body "file://D:\Users\sjamgade\Desktop\DevOps_iConfigurator\DevOps_iConfigurator\CF_Batch_Script\JenkinsJsonScript.json" --parameters ParameterKey=InstanceType,ParameterValue=t2.micro ParameterKey=KeyName,ParameterValue=Key_pair_demo --capabilities CAPABILITY_IAM

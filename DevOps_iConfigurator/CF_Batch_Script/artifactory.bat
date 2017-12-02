aws cloudformation create-stack --stack-name stackartifactory --template-body "file://D:\Users\sjamgade\Desktop\DevOps_iConfigurator\DevOps_iConfigurator\CF_Batch_Script\artifactory.json" --parameters ParameterKey=InstanceType,ParameterValue=t2.micro ParameterKey=KeyName,ParameterValue=Key_pair_demo --capabilities CAPABILITY_IAM


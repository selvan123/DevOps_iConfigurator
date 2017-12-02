aws cloudformation create-stack --stack-name stacktomcat2 --template-body "file://D:\Users\sjamgade\Desktop\DevOps_iConfigurator\DevOps_iConfigurator\CF_Batch_Script\Tomcat_version1.json" --parameters ParameterKey=InstanceType,ParameterValue=t2.micro ParameterKey=KeyName,ParameterValue=Key_pair_demo --capabilities CAPABILITY_IAM


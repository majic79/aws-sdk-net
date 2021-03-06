using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ECS;
using Amazon.ECS.Model;

namespace AWSSDKDocSamples.Amazon.ECS.Generated
{
    class ECSSamples : ISample
    {
        static IAmazonECS client = new AmazonECSClient();
        public void ECSCreateCluster()
        {
            #region to-create-a-new-cluster-1472514079365

            var response = client.CreateCluster(new CreateClusterRequest 
            {
                ClusterName = "my_cluster"
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void ECSCreateService()
        {
            #region to-create-a-new-service-1472512584282

            var response = client.CreateService(new CreateServiceRequest 
            {
                DesiredCount = 10,
                ServiceName = "ecs-simple-service",
                TaskDefinition = "hello_world"
            });

            Service service = response.Service;

            #endregion
        }

        public void ECSCreateService()
        {
            #region to-create-a-new-service-behind-a-load-balancer-1472512484823

            var response = client.CreateService(new CreateServiceRequest 
            {
                DesiredCount = 10,
                LoadBalancers = new List<LoadBalancer> {
                    new LoadBalancer {
                        ContainerName = "simple-app",
                        ContainerPort = 80,
                        LoadBalancerName = "EC2Contai-EcsElast-15DCDAURT3ZO2"
                    }
                },
                Role = "ecsServiceRole",
                ServiceName = "ecs-simple-service-elb",
                TaskDefinition = "console-sample-app-static"
            });

            Service service = response.Service;

            #endregion
        }

        public void ECSDeleteCluster()
        {
            #region to-delete-an-empty-cluster-1472512705352

            var response = client.DeleteCluster(new DeleteClusterRequest 
            {
                Cluster = "my_cluster"
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void ECSDeleteService()
        {
            #region e8183e38-f86e-4390-b811-f74f30a6007d

            var response = client.DeleteService(new DeleteServiceRequest 
            {
                Service = "my-http-service"
            });


            #endregion
        }

        public void ECSDeregisterContainerInstance()
        {
            #region bf624927-cf64-4f4b-8b7e-c024a4e682f6

            var response = client.DeregisterContainerInstance(new DeregisterContainerInstanceRequest 
            {
                Cluster = "default",
                ContainerInstance = "container_instance_UUID",
                Force = true
            });


            #endregion
        }

        public void ECSDescribeClusters()
        {
            #region ba88d100-9672-4231-80da-a4bd210bf728

            var response = client.DescribeClusters(new DescribeClustersRequest 
            {
                Clusters = new List<string> {
                    "default"
                }
            });

            List<Cluster> clusters = response.Clusters;
            List<Failure> failures = response.Failures;

            #endregion
        }

        public void ECSDescribeContainerInstances()
        {
            #region c8f439de-eb27-4269-8ca7-2c0a7ba75ab0

            var response = client.DescribeContainerInstances(new DescribeContainerInstancesRequest 
            {
                Cluster = "default",
                ContainerInstances = new List<string> {
                    "f2756532-8f13-4d53-87c9-aed50dc94cd7"
                }
            });

            List<ContainerInstance> containerInstances = response.ContainerInstances;
            List<Failure> failures = response.Failures;

            #endregion
        }

        public void ECSDescribeServices()
        {
            #region to-describe-a-service-1472513256350

            var response = client.DescribeServices(new DescribeServicesRequest 
            {
                Services = new List<string> {
                    "ecs-simple-service"
                }
            });

            List<Failure> failures = response.Failures;
            List<Service> services = response.Services;

            #endregion
        }

        public void ECSDescribeTaskDefinition()
        {
            #region 4c21eeb1-f1da-4a08-8c44-297fc8d0ea88

            var response = client.DescribeTaskDefinition(new DescribeTaskDefinitionRequest 
            {
                TaskDefinition = "hello_world:8"
            });

            TaskDefinition taskDefinition = response.TaskDefinition;

            #endregion
        }

        public void ECSDescribeTasks()
        {
            #region a90b0cde-f965-4946-b55e-cfd8cc54e827

            var response = client.DescribeTasks(new DescribeTasksRequest 
            {
                Tasks = new List<string> {
                    "c5cba4eb-5dad-405e-96db-71ef8eefe6a8"
                }
            });

            List<Failure> failures = response.Failures;
            List<Task> tasks = response.Tasks;

            #endregion
        }

        public void ECSListClusters()
        {
            #region e337d059-134f-4125-ba8e-4f499139facf

            var response = client.ListClusters(new ListClustersRequest 
            {
            });

            List<string> clusterArns = response.ClusterArns;

            #endregion
        }

        public void ECSListContainerInstances()
        {
            #region 62a82a94-713c-4e18-8420-1d2b2ba9d484

            var response = client.ListContainerInstances(new ListContainerInstancesRequest 
            {
                Cluster = "default"
            });

            List<string> containerInstanceArns = response.ContainerInstanceArns;

            #endregion
        }

        public void ECSListServices()
        {
            #region 1d9a8037-4e0e-4234-a528-609656809a3a

            var response = client.ListServices(new ListServicesRequest 
            {
            });

            List<string> serviceArns = response.ServiceArns;

            #endregion
        }

        public void ECSListTaskDefinitionFamilies()
        {
            #region b5c89769-1d94-4ca2-a79e-8069103c7f75

            var response = client.ListTaskDefinitionFamilies(new ListTaskDefinitionFamiliesRequest 
            {
            });

            List<string> families = response.Families;

            #endregion
        }

        public void ECSListTaskDefinitionFamilies()
        {
            #region 8a4cf9a6-42c1-4fe3-852d-99ac8968e11b

            var response = client.ListTaskDefinitionFamilies(new ListTaskDefinitionFamiliesRequest 
            {
                FamilyPrefix = "hpcc"
            });

            List<string> families = response.Families;

            #endregion
        }

        public void ECSListTaskDefinitions()
        {
            #region b381ebaf-7eba-4d60-b99b-7f6ae49d3d60

            var response = client.ListTaskDefinitions(new ListTaskDefinitionsRequest 
            {
            });

            List<string> taskDefinitionArns = response.TaskDefinitionArns;

            #endregion
        }

        public void ECSListTaskDefinitions()
        {
            #region 734e7afd-753a-4bc2-85d0-badddce10910

            var response = client.ListTaskDefinitions(new ListTaskDefinitionsRequest 
            {
                FamilyPrefix = "wordpress"
            });

            List<string> taskDefinitionArns = response.TaskDefinitionArns;

            #endregion
        }

        public void ECSListTasks()
        {
            #region 9a6ec707-1a77-45d0-b2eb-516b5dd9e924

            var response = client.ListTasks(new ListTasksRequest 
            {
                Cluster = "default"
            });

            List<string> taskArns = response.TaskArns;

            #endregion
        }

        public void ECSListTasks()
        {
            #region 024bf3b7-9cbb-44e3-848f-9d074e1fecce

            var response = client.ListTasks(new ListTasksRequest 
            {
                Cluster = "default",
                ContainerInstance = "f6bbb147-5370-4ace-8c73-c7181ded911f"
            });

            List<string> taskArns = response.TaskArns;

            #endregion
        }

        public void ECSRegisterTaskDefinition()
        {
            #region to-register-a-task-definition-1470764550877

            var response = client.RegisterTaskDefinition(new RegisterTaskDefinitionRequest 
            {
                ContainerDefinitions = new List<ContainerDefinition> {
                    new ContainerDefinition {
                        Name = "sleep",
                        Command = new List<string> {
                            "sleep",
                            "360"
                        },
                        Cpu = 10,
                        Essential = true,
                        Image = "busybox",
                        Memory = 10
                    }
                },
                Family = "sleep360",
                TaskRoleArn = "",
                Volumes = new List<Volume> {
                    
                }
            });

            TaskDefinition taskDefinition = response.TaskDefinition;

            #endregion
        }

        public void ECSRunTask()
        {
            #region 6f238c83-a133-42cd-ab3d-abeca0560445

            var response = client.RunTask(new RunTaskRequest 
            {
                Cluster = "default",
                TaskDefinition = "sleep360:1"
            });

            List<Task> tasks = response.Tasks;

            #endregion
        }

        public void ECSUpdateService()
        {
            #region cc9e8900-0cc2-44d2-8491-64d1d3d37887

            var response = client.UpdateService(new UpdateServiceRequest 
            {
                Service = "my-http-service",
                TaskDefinition = "amazon-ecs-sample"
            });


            #endregion
        }

        public void ECSUpdateService()
        {
            #region 9581d6c5-02e3-4140-8cc1-5a4301586633

            var response = client.UpdateService(new UpdateServiceRequest 
            {
                DesiredCount = 10,
                Service = "my-http-service"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}
// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from 'src\OpenTelemetry.SemanticConventions\scripts\templates\registry\SemanticConventionsAttributes.cs.j2' </auto-generated>

#nullable enable

#pragma warning disable CS1570 // XML comment has badly formed XML

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class CloudAttributes
{
    /// <summary>
    /// The cloud account ID the resource is assigned to.
    /// </summary>
    public const string AttributeCloudAccountId = "cloud.account.id";

    /// <summary>
    /// Cloud regions often have multiple, isolated locations known as zones to increase availability. Availability zone represents the zone where the resource is running.
    /// </summary>
    /// <remarks>
    /// Availability zones are called "zones" on Alibaba Cloud and Google Cloud.
    /// </remarks>
    public const string AttributeCloudAvailabilityZone = "cloud.availability_zone";

    /// <summary>
    /// The cloud platform in use.
    /// </summary>
    /// <remarks>
    /// The prefix of the service SHOULD match the one specified in <c>cloud.provider</c>.
    /// </remarks>
    public const string AttributeCloudPlatform = "cloud.platform";

    /// <summary>
    /// Name of the cloud provider.
    /// </summary>
    public const string AttributeCloudProvider = "cloud.provider";

    /// <summary>
    /// The geographical region the resource is running.
    /// </summary>
    /// <remarks>
    /// Refer to your provider's docs to see the available regions, for example <a href="https://www.alibabacloud.com/help/doc-detail/40654.htm">Alibaba Cloud regions</a>, <a href="https://aws.amazon.com/about-aws/global-infrastructure/regions_az/">AWS regions</a>, <a href="https://azure.microsoft.com/global-infrastructure/geographies/">Azure regions</a>, <a href="https://cloud.google.com/about/locations">Google Cloud regions</a>, or <a href="https://www.tencentcloud.com/document/product/213/6091">Tencent Cloud regions</a>.
    /// </remarks>
    public const string AttributeCloudRegion = "cloud.region";

    /// <summary>
    /// Cloud provider-specific native identifier of the monitored cloud resource (e.g. an <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a> on AWS, a <a href="https://learn.microsoft.com/rest/api/resources/resources/get-by-id">fully qualified resource ID</a> on Azure, a <a href="https://google.aip.dev/122#full-resource-names">full resource name</a> on GCP).
    /// </summary>
    /// <remarks>
    /// On some cloud providers, it may not be possible to determine the full ID at startup,
    /// so it may be necessary to set <c>cloud.resource_id</c> as a span attribute instead.
    /// <p>
    /// The exact value to use for <c>cloud.resource_id</c> depends on the cloud provider.
    /// The following well-known definitions MUST be used if you set this attribute and they apply:
    /// <ul>
    ///   <li><strong>AWS Lambda:</strong> The function <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>.
    /// Take care not to use the "invoked ARN" directly but replace any
    /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">alias suffix</a>
    /// with the resolved function version, as the same runtime instance may be invocable with
    /// multiple different aliases.</li>
    ///   <li><strong>GCP:</strong> The <a href="https://cloud.google.com/iam/docs/full-resource-names">URI of the resource</a></li>
    ///   <li><strong>Azure:</strong> The <a href="https://docs.microsoft.com/rest/api/resources/resources/get-by-id">Fully Qualified Resource ID</a> of the invoked function,
    /// <em>not</em> the function app, having the form
    /// <c>/subscriptions/<SUBSCRIPTION_GUID>/resourceGroups/<RG>/providers/Microsoft.Web/sites/<FUNCAPP>/functions/<FUNC></c>.
    /// This means that a span attribute MUST be used, as an Azure function app can host multiple functions that would usually share
    /// a TracerProvider.</li>
    /// </ul>
    /// </remarks>
    public const string AttributeCloudResourceId = "cloud.resource_id";

    /// <summary>
    /// The cloud platform in use.
    /// </summary>
    public static class CloudPlatformValues
    {
        /// <summary>
        /// Alibaba Cloud Elastic Compute Service.
        /// </summary>
        public const string AlibabaCloudEcs = "alibaba_cloud_ecs";

        /// <summary>
        /// Alibaba Cloud Function Compute.
        /// </summary>
        public const string AlibabaCloudFc = "alibaba_cloud_fc";

        /// <summary>
        /// Red Hat OpenShift on Alibaba Cloud.
        /// </summary>
        public const string AlibabaCloudOpenshift = "alibaba_cloud_openshift";

        /// <summary>
        /// AWS Elastic Compute Cloud.
        /// </summary>
        public const string AwsEc2 = "aws_ec2";

        /// <summary>
        /// AWS Elastic Container Service.
        /// </summary>
        public const string AwsEcs = "aws_ecs";

        /// <summary>
        /// AWS Elastic Kubernetes Service.
        /// </summary>
        public const string AwsEks = "aws_eks";

        /// <summary>
        /// AWS Lambda.
        /// </summary>
        public const string AwsLambda = "aws_lambda";

        /// <summary>
        /// AWS Elastic Beanstalk.
        /// </summary>
        public const string AwsElasticBeanstalk = "aws_elastic_beanstalk";

        /// <summary>
        /// AWS App Runner.
        /// </summary>
        public const string AwsAppRunner = "aws_app_runner";

        /// <summary>
        /// Red Hat OpenShift on AWS (ROSA).
        /// </summary>
        public const string AwsOpenshift = "aws_openshift";

        /// <summary>
        /// Azure Virtual Machines.
        /// </summary>
        public const string AzureVm = "azure_vm";

        /// <summary>
        /// Azure Container Apps.
        /// </summary>
        public const string AzureContainerApps = "azure_container_apps";

        /// <summary>
        /// Azure Container Instances.
        /// </summary>
        public const string AzureContainerInstances = "azure_container_instances";

        /// <summary>
        /// Azure Kubernetes Service.
        /// </summary>
        public const string AzureAks = "azure_aks";

        /// <summary>
        /// Azure Functions.
        /// </summary>
        public const string AzureFunctions = "azure_functions";

        /// <summary>
        /// Azure App Service.
        /// </summary>
        public const string AzureAppService = "azure_app_service";

        /// <summary>
        /// Azure Red Hat OpenShift.
        /// </summary>
        public const string AzureOpenshift = "azure_openshift";

        /// <summary>
        /// Google Bare Metal Solution (BMS).
        /// </summary>
        public const string GcpBareMetalSolution = "gcp_bare_metal_solution";

        /// <summary>
        /// Google Cloud Compute Engine (GCE).
        /// </summary>
        public const string GcpComputeEngine = "gcp_compute_engine";

        /// <summary>
        /// Google Cloud Run.
        /// </summary>
        public const string GcpCloudRun = "gcp_cloud_run";

        /// <summary>
        /// Google Cloud Kubernetes Engine (GKE).
        /// </summary>
        public const string GcpKubernetesEngine = "gcp_kubernetes_engine";

        /// <summary>
        /// Google Cloud Functions (GCF).
        /// </summary>
        public const string GcpCloudFunctions = "gcp_cloud_functions";

        /// <summary>
        /// Google Cloud App Engine (GAE).
        /// </summary>
        public const string GcpAppEngine = "gcp_app_engine";

        /// <summary>
        /// Red Hat OpenShift on Google Cloud.
        /// </summary>
        public const string GcpOpenshift = "gcp_openshift";

        /// <summary>
        /// Red Hat OpenShift on IBM Cloud.
        /// </summary>
        public const string IbmCloudOpenshift = "ibm_cloud_openshift";

        /// <summary>
        /// Compute on Oracle Cloud Infrastructure (OCI).
        /// </summary>
        public const string OracleCloudCompute = "oracle_cloud_compute";

        /// <summary>
        /// Kubernetes Engine (OKE) on Oracle Cloud Infrastructure (OCI).
        /// </summary>
        public const string OracleCloudOke = "oracle_cloud_oke";

        /// <summary>
        /// Tencent Cloud Cloud Virtual Machine (CVM).
        /// </summary>
        public const string TencentCloudCvm = "tencent_cloud_cvm";

        /// <summary>
        /// Tencent Cloud Elastic Kubernetes Service (EKS).
        /// </summary>
        public const string TencentCloudEks = "tencent_cloud_eks";

        /// <summary>
        /// Tencent Cloud Serverless Cloud Function (SCF).
        /// </summary>
        public const string TencentCloudScf = "tencent_cloud_scf";
    }

    /// <summary>
    /// Name of the cloud provider.
    /// </summary>
    public static class CloudProviderValues
    {
        /// <summary>
        /// Alibaba Cloud.
        /// </summary>
        public const string AlibabaCloud = "alibaba_cloud";

        /// <summary>
        /// Amazon Web Services.
        /// </summary>
        public const string Aws = "aws";

        /// <summary>
        /// Microsoft Azure.
        /// </summary>
        public const string Azure = "azure";

        /// <summary>
        /// Google Cloud Platform.
        /// </summary>
        public const string Gcp = "gcp";

        /// <summary>
        /// Heroku Platform as a Service.
        /// </summary>
        public const string Heroku = "heroku";

        /// <summary>
        /// IBM Cloud.
        /// </summary>
        public const string IbmCloud = "ibm_cloud";

        /// <summary>
        /// Oracle Cloud Infrastructure (OCI).
        /// </summary>
        public const string OracleCloud = "oracle_cloud";

        /// <summary>
        /// Tencent Cloud.
        /// </summary>
        public const string TencentCloud = "tencent_cloud";
    }
}

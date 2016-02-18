/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the marketplacecommerceanalytics-2015-07-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.AWSMarketplaceCommerceAnalytics.Model;
using Amazon.AWSMarketplaceCommerceAnalytics.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AWSMarketplaceCommerceAnalytics
{
    /// <summary>
    /// Implementation for accessing AWSMarketplaceCommerceAnalytics
    ///
    /// Provides AWS Marketplace business intelligence data on-demand.
    /// </summary>
    public partial class AmazonAWSMarketplaceCommerceAnalyticsClient : AmazonServiceClient, IAmazonAWSMarketplaceCommerceAnalytics
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonAWSMarketplaceCommerceAnalyticsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAWSMarketplaceCommerceAnalyticsConfig()) { }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAWSMarketplaceCommerceAnalyticsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonAWSMarketplaceCommerceAnalyticsClient Configuration Object</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(AmazonAWSMarketplaceCommerceAnalyticsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(AWSCredentials credentials)
            : this(credentials, new AmazonAWSMarketplaceCommerceAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAWSMarketplaceCommerceAnalyticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Credentials and an
        /// AmazonAWSMarketplaceCommerceAnalyticsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAWSMarketplaceCommerceAnalyticsClient Configuration Object</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(AWSCredentials credentials, AmazonAWSMarketplaceCommerceAnalyticsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAWSMarketplaceCommerceAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAWSMarketplaceCommerceAnalyticsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAWSMarketplaceCommerceAnalyticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAWSMarketplaceCommerceAnalyticsClient Configuration Object</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAWSMarketplaceCommerceAnalyticsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAWSMarketplaceCommerceAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAWSMarketplaceCommerceAnalyticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAWSMarketplaceCommerceAnalyticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAWSMarketplaceCommerceAnalyticsClient Configuration Object</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAWSMarketplaceCommerceAnalyticsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  GenerateDataSet


        /// <summary>
        /// Given a data set type and data set publication date, asynchronously publishes the
        /// requested data set to the specified S3 bucket and notifies the specified SNS topic
        /// once the data is available. Returns a unique request identifier that can be used to
        /// correlate requests with notifications from the SNS topic. Data sets will be published
        /// in comma-separated values (CSV) format with the file name {data_set_type}_YYYY-MM-DD.csv.
        /// If a file with the same name already exists (e.g. if the same data set is requested
        /// twice), the original file will be overwritten by the new file. Requires a Role with
        /// an attached permissions policy providing Allow permissions for the following actions:
        /// s3:PutObject, s3:GetBucketLocation, sns:GetTopicAttributes, sns:Publish, iam:GetRolePolicy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataSet service method.</param>
        /// 
        /// <returns>The response from the GenerateDataSet service method, as returned by AWSMarketplaceCommerceAnalytics.</returns>
        /// <exception cref="Amazon.AWSMarketplaceCommerceAnalytics.Model.MarketplaceCommerceAnalyticsException">
        /// This exception is thrown when an internal service error occurs.
        /// </exception>
        public GenerateDataSetResponse GenerateDataSet(GenerateDataSetRequest request)
        {
            var marshaller = new GenerateDataSetRequestMarshaller();
            var unmarshaller = GenerateDataSetResponseUnmarshaller.Instance;

            return Invoke<GenerateDataSetRequest,GenerateDataSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GenerateDataSetResponse> GenerateDataSetAsync(GenerateDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GenerateDataSetRequestMarshaller();
            var unmarshaller = GenerateDataSetResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataSetRequest,GenerateDataSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
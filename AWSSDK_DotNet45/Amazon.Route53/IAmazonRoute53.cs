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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Route53.Model;

namespace Amazon.Route53
{
    /// <summary>
    /// Interface for accessing Route53
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRoute53 : IDisposable
    {

        
        #region  AssociateVPCWithHostedZone

        /// <summary>
        /// This action associates a VPC with an hosted zone. 
        /// 
        ///  
        /// <para>
        ///  To associate a VPC with an hosted zone, send a <code>POST</code> request to the <code>2013-04-01/hostedzone/<i>hosted
        /// zone ID</i>/associatevpc</code> resource. The request body must include an XML document
        /// with a <code>AssociateVPCWithHostedZoneRequest</code> element. The response returns
        /// the <code>AssociateVPCWithHostedZoneResponse</code> element that contains <code>ChangeInfo</code>
        /// for you to track the progress of the <code>AssociateVPCWithHostedZoneRequest</code>
        /// you made. See <code>GetChange</code> operation for how to track the progress of your
        /// change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone service method.</param>
        /// 
        /// <returns>The response from the AssociateVPCWithHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Route
        /// 53 returns this error when the VPC specified by <code>VPCId</code> does not belong
        /// to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PublicZoneVPCAssociationException">
        /// The hosted zone you are trying to associate VPC with doesn't have any VPC association.
        /// Route 53 currently doesn't support associate a VPC with a public hosted zone.
        /// </exception>
        AssociateVPCWithHostedZoneResponse AssociateVPCWithHostedZone(AssociateVPCWithHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVPCWithHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssociateVPCWithHostedZoneResponse> AssociateVPCWithHostedZoneAsync(AssociateVPCWithHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ChangeResourceRecordSets

        /// <summary>
        /// Use this action to create or change your authoritative DNS information. To use this
        /// action, send a <code>POST</code> request to the <code>2013-04-01/hostedzone/<i>hosted
        /// Zone ID</i>/rrset</code> resource. The request body must include an XML document with
        /// a <code>ChangeResourceRecordSetsRequest</code> element.
        /// 
        ///  
        /// <para>
        /// Changes are a list of change items and are considered transactional. For more information
        /// on transactional changes, also known as change batches, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/RRSchanges.html#RRSchanges_API">Creating,
        /// Changing, and Deleting Resource Record Sets Using the Route 53 API</a> in the <i>Amazon
        /// Route 53 Developer Guide</i>.
        /// </para>
        ///  <important>Due to the nature of transactional changes, you cannot delete the same
        /// resource record set more than once in a single change batch. If you attempt to delete
        /// the same change batch more than once, Route 53 returns an <code>InvalidChangeBatch</code>
        /// error.</important> 
        /// <para>
        /// In response to a <code>ChangeResourceRecordSets</code> request, your DNS data is changed
        /// on all Route 53 DNS servers. Initially, the status of a change is <code>PENDING</code>.
        /// This means the change has not yet propagated to all the authoritative Route 53 DNS
        /// servers. When the change is propagated to all hosts, the change returns a status of
        /// <code>INSYNC</code>.
        /// </para>
        ///  
        /// <para>
        /// Note the following limitations on a <code>ChangeResourceRecordSets</code> request:
        /// </para>
        ///  
        /// <para>
        /// - A request cannot contain more than 100 Change elements.
        /// </para>
        ///  
        /// <para>
        /// - A request cannot contain more than 1000 ResourceRecord elements.
        /// </para>
        ///  
        /// <para>
        /// The sum of the number of characters (including spaces) in all <code>Value</code> elements
        /// in a request cannot exceed 32,000 characters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets service method.</param>
        /// 
        /// <returns>The response from the ChangeResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidChangeBatchException">
        /// This error contains a list of one or more error messages. Each error message indicates
        /// one error in the change batch. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/APIReference/API_ChangeResourceRecordSets.html#example_Errors">Example
        /// InvalidChangeBatch Errors</a>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Route 53 was still processing a prior request.
        /// </exception>
        ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ChangeResourceRecordSetsResponse> ChangeResourceRecordSetsAsync(ChangeResourceRecordSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ChangeTagsForResource

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ChangeTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        ChangeTagsForResourceResponse ChangeTagsForResource(ChangeTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ChangeTagsForResourceResponse> ChangeTagsForResourceAsync(ChangeTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateHealthCheck

        /// <summary>
        /// This action creates a new health check.
        /// 
        ///  
        /// <para>
        ///  To create a new health check, send a <code>POST</code> request to the <code>2013-04-01/healthcheck</code>
        /// resource. The request body must include an XML document with a <code>CreateHealthCheckRequest</code>
        /// element. The response returns the <code>CreateHealthCheckResponse</code> element that
        /// contains metadata about the health check.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the CreateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckAlreadyExistsException">
        /// The health check you are trying to create already exists. Route 53 returns this error
        /// when a health check has already been created with the specified <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHealthChecksException">
        /// 
        /// </exception>
        CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateHostedZone

        /// <summary>
        /// This action creates a new hosted zone.
        /// 
        ///  
        /// <para>
        /// To create a new hosted zone, send a <code>POST</code> request to the <code>2013-04-01/hostedzone</code>
        /// resource. The request body must include an XML document with a <code>CreateHostedZoneRequest</code>
        /// element. The response returns the <code>CreateHostedZoneResponse</code> element that
        /// contains metadata about the hosted zone.
        /// </para>
        ///  
        /// <para>
        /// Route 53 automatically creates a default SOA record and four NS records for the zone.
        /// The NS records in the hosted zone are the name servers you give your registrar to
        /// delegate your domain to. For more information about SOA and NS records, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/SOA-NSrecords.html">NS
        /// and SOA Records that Route 53 Creates for a Hosted Zone</a> in the <i>Amazon Route
        /// 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you create a zone, its initial status is <code>PENDING</code>. This means that
        /// it is not yet available on all DNS servers. The status of the zone changes to <code>INSYNC</code>
        /// when the NS and SOA records are available on all Route 53 DNS servers. 
        /// </para>
        ///  
        /// <para>
        /// When trying to create a hosted zone using a reusable delegation set, you could specify
        /// an optional DelegationSetId, and Route53 would assign those 4 NS records for the zone,
        /// instead of alloting a new one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone service method.</param>
        /// 
        /// <returns>The response from the CreateHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotAvailableException">
        /// Route 53 allows some duplicate domain names, but there is a maximum number of duplicate
        /// names. This error indicates that you have reached that maximum. If you want to create
        /// another hosted zone with the same name and Route 53 generates this error, you can
        /// request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneAlreadyExistsException">
        /// The hosted zone you are trying to create already exists. Route 53 returns this error
        /// when a hosted zone has already been created with the specified <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// This error indicates that the specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Route
        /// 53 returns this error when the VPC specified by <code>VPCId</code> does not belong
        /// to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHostedZonesException">
        /// This error indicates that you've reached the maximum number of hosted zones that can
        /// be created for the current AWS account. You can request an increase to the limit on
        /// the <a href="http://aws.amazon.com/route53-request/">Contact Us</a> page.
        /// </exception>
        CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateHostedZoneResponse> CreateHostedZoneAsync(CreateHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReusableDelegationSet

        /// <summary>
        /// This action creates a reusable delegationSet.
        /// 
        ///  
        /// <para>
        ///  To create a new reusable delegationSet, send a <code>POST</code> request to the <code>2013-04-01/delegationset</code>
        /// resource. The request body must include an XML document with a <code>CreateReusableDelegationSetRequest</code>
        /// element. The response returns the <code>CreateReusableDelegationSetResponse</code>
        /// element that contains metadata about the delegationSet. 
        /// </para>
        ///  
        /// <para>
        ///  If the optional parameter HostedZoneId is specified, it marks the delegationSet associated
        /// with that particular hosted zone as reusable. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the CreateReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetAlreadyCreatedException">
        /// A delegation set with the same owner and caller reference combination has already
        /// been created.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetAlreadyReusableException">
        /// The specified delegation set has already been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotAvailableException">
        /// Route 53 allows some duplicate domain names, but there is a maximum number of duplicate
        /// names. This error indicates that you have reached that maximum. If you want to create
        /// another hosted zone with the same name and Route 53 generates this error, you can
        /// request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotFoundException">
        /// The specified HostedZone cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// At least one of the specified arguments is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// The limits specified for a resource have been exceeded.
        /// </exception>
        CreateReusableDelegationSetResponse CreateReusableDelegationSet(CreateReusableDelegationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReusableDelegationSetResponse> CreateReusableDelegationSetAsync(CreateReusableDelegationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteHealthCheck

        /// <summary>
        /// This action deletes a health check. To delete a health check, send a <code>DELETE</code>
        /// request to the <code>2013-04-01/healthcheck/<i>health check ID</i></code> resource.
        /// 
        ///  <important> You can delete a health check only if there are no resource record sets
        /// associated with this health check. If resource record sets are associated with this
        /// health check, you must disassociate them before you can delete your health check.
        /// If you try to delete a health check that is associated with resource record sets,
        /// Route 53 will deny your request with a <code>HealthCheckInUse</code> error. For information
        /// about disassociating the records from your health check, see <a>ChangeResourceRecordSets</a>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck service method.</param>
        /// 
        /// <returns>The response from the DeleteHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckInUseException">
        /// There are resource records associated with this health check. Before you can delete
        /// the health check, you must disassociate it from the resource record sets.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteHostedZone

        /// <summary>
        /// This action deletes a hosted zone. To delete a hosted zone, send a <code>DELETE</code>
        /// request to the <code>2013-04-01/hostedzone/<i>hosted zone ID</i></code> resource.
        /// 
        ///  
        /// <para>
        /// For more information about deleting a hosted zone, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DeleteHostedZone.html">Deleting
        /// a Hosted Zone</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  <important> You can delete a hosted zone only if there are no resource record sets
        /// other than the default SOA record and NS resource record sets. If your hosted zone
        /// contains other resource record sets, you must delete them before you can delete your
        /// hosted zone. If you try to delete a hosted zone that contains other resource record
        /// sets, Route 53 will deny your request with a <code>HostedZoneNotEmpty</code> error.
        /// For information about deleting records from your hosted zone, see <a>ChangeResourceRecordSets</a>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone service method.</param>
        /// 
        /// <returns>The response from the DeleteHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotEmptyException">
        /// The hosted zone contains resource record sets in addition to the default NS and SOA
        /// resource record sets. Before you can delete the hosted zone, you must delete the additional
        /// resource record sets.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Route 53 was still processing a prior request.
        /// </exception>
        DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteHostedZoneResponse> DeleteHostedZoneAsync(DeleteHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReusableDelegationSet

        /// <summary>
        /// This action deletes a reusable delegation set. To delete a reusable delegation set,
        /// send a <code>DELETE</code> request to the <code>2013-04-01/delegationset/<i>delegation
        /// set ID</i></code> resource.
        /// 
        ///  <important> You can delete a reusable delegation set only if there are no associated
        /// hosted zones. If your reusable delegation set contains associated hosted zones, you
        /// must delete them before you can delete your reusable delegation set. If you try to
        /// delete a reusable delegation set that contains associated hosted zones, Route 53 will
        /// deny your request with a <code>DelegationSetInUse</code> error.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetInUseException">
        /// The specified delegation contains associated hosted zones which must be deleted before
        /// the reusable delegation set can be deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        DeleteReusableDelegationSetResponse DeleteReusableDelegationSet(DeleteReusableDelegationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteReusableDelegationSetResponse> DeleteReusableDelegationSetAsync(DeleteReusableDelegationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateVPCFromHostedZone

        /// <summary>
        /// This action disassociates a VPC from an hosted zone. 
        /// 
        ///  
        /// <para>
        ///  To disassociate a VPC to a hosted zone, send a <code>POST</code> request to the <code>2013-04-01/hostedzone/<i>hosted
        /// zone ID</i>/disassociatevpc</code> resource. The request body must include an XML
        /// document with a <code>DisassociateVPCFromHostedZoneRequest</code> element. The response
        /// returns the <code>DisassociateVPCFromHostedZoneResponse</code> element that contains
        /// <code>ChangeInfo</code> for you to track the progress of the <code>DisassociateVPCFromHostedZoneRequest</code>
        /// you made. See <code>GetChange</code> operation for how to track the progress of your
        /// change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone service method.</param>
        /// 
        /// <returns>The response from the DisassociateVPCFromHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Route
        /// 53 returns this error when the VPC specified by <code>VPCId</code> does not belong
        /// to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LastVPCAssociationException">
        /// The VPC you are trying to disassociate from the hosted zone is the last the VPC that
        /// is associated with the hosted zone. Route 53 currently doesn't support disassociate
        /// the last VPC from the hosted zone.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.VPCAssociationNotFoundException">
        /// The VPC you specified is not currently associated with the hosted zone.
        /// </exception>
        DisassociateVPCFromHostedZoneResponse DisassociateVPCFromHostedZone(DisassociateVPCFromHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVPCFromHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisassociateVPCFromHostedZoneResponse> DisassociateVPCFromHostedZoneAsync(DisassociateVPCFromHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetChange

        /// <summary>
        /// This action returns the current status of a change batch request. The status is one
        /// of the following values:
        /// 
        ///  
        /// <para>
        /// - <code>PENDING</code> indicates that the changes in this request have not replicated
        /// to all Route 53 DNS servers. This is the initial status of all change batch requests.
        /// </para>
        ///  
        /// <para>
        /// - <code>INSYNC</code> indicates that the changes have replicated to all Amazon Route
        /// 53 DNS servers. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChange service method.</param>
        /// 
        /// <returns>The response from the GetChange service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchChangeException">
        /// 
        /// </exception>
        GetChangeResponse GetChange(GetChangeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChange operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetChangeResponse> GetChangeAsync(GetChangeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCheckerIpRanges

        /// <summary>
        /// To retrieve a list of the IP ranges used by Amazon Route 53 health checkers to check
        /// the health of your resources, send a <code>GET</code> request to the <code>2013-04-01/checkeripranges</code>
        /// resource. You can use these IP addresses to configure router and firewall rules to
        /// allow health checkers to check the health of your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges service method.</param>
        /// 
        /// <returns>The response from the GetCheckerIpRanges service method, as returned by Route53.</returns>
        GetCheckerIpRangesResponse GetCheckerIpRanges(GetCheckerIpRangesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCheckerIpRanges operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetCheckerIpRangesResponse> GetCheckerIpRangesAsync(GetCheckerIpRangesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGeoLocation

        /// <summary>
        /// To retrieve a single geo location, send a <code>GET</code> request to the <code>2013-04-01/geolocation</code>
        /// resource with one of these options: continentcode | countrycode | countrycode and
        /// subdivisioncode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation service method.</param>
        /// 
        /// <returns>The response from the GetGeoLocation service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchGeoLocationException">
        /// The geo location you are trying to get does not exist.
        /// </exception>
        GetGeoLocationResponse GetGeoLocation(GetGeoLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeoLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetGeoLocationResponse> GetGeoLocationAsync(GetGeoLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHealthCheck

        /// <summary>
        /// To retrieve the health check, send a <code>GET</code> request to the <code>2013-04-01/healthcheck/<i>health
        /// check ID</i></code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Route 53 endpoint. Please
        /// consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        GetHealthCheckResponse GetHealthCheck(GetHealthCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckResponse> GetHealthCheckAsync(GetHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHealthCheckCount

        /// <summary>
        /// To retrieve a count of all your health checks, send a <code>GET</code> request to
        /// the <code>2013-04-01/healthcheckcount</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckCount service method, as returned by Route53.</returns>
        GetHealthCheckCountResponse GetHealthCheckCount(GetHealthCheckCountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckCountResponse> GetHealthCheckCountAsync(GetHealthCheckCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHealthCheckLastFailureReason

        /// <summary>
        /// If you want to learn why a health check is currently failing or why it failed most
        /// recently (if at all), you can get the failure reason for the most recent failure.
        /// Send a <code>GET</code> request to the <code>2013-04-01/healthcheck/<i>health check
        /// ID</i>/lastfailurereason</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckLastFailureReason service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        GetHealthCheckLastFailureReasonResponse GetHealthCheckLastFailureReason(GetHealthCheckLastFailureReasonRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckLastFailureReason operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckLastFailureReasonResponse> GetHealthCheckLastFailureReasonAsync(GetHealthCheckLastFailureReasonRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHealthCheckStatus

        /// <summary>
        /// To retrieve the health check status, send a <code>GET</code> request to the <code>2013-04-01/healthcheck/<i>health
        /// check ID</i>/status</code> resource. You can use this call to get a health check's
        /// current status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckStatus service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        GetHealthCheckStatusResponse GetHealthCheckStatus(GetHealthCheckStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckStatusResponse> GetHealthCheckStatusAsync(GetHealthCheckStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHostedZone

        /// <summary>
        /// To retrieve the delegation set for a hosted zone, send a <code>GET</code> request
        /// to the <code>2013-04-01/hostedzone/<i>hosted zone ID</i></code> resource. The delegation
        /// set is the four Route 53 name servers that were assigned to the hosted zone when you
        /// created it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone service method.</param>
        /// 
        /// <returns>The response from the GetHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHostedZoneResponse> GetHostedZoneAsync(GetHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReusableDelegationSet

        /// <summary>
        /// To retrieve the reusable delegation set, send a <code>GET</code> request to the <code>2013-04-01/delegationset/<i>delegation
        /// set ID</i></code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the GetReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        GetReusableDelegationSetResponse GetReusableDelegationSet(GetReusableDelegationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetReusableDelegationSetResponse> GetReusableDelegationSetAsync(GetReusableDelegationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGeoLocations

        /// <summary>
        /// To retrieve a list of supported geo locations, send a <code>GET</code> request to
        /// the <code>2013-04-01/geolocations</code> resource. The response to this request includes
        /// a <code>GeoLocationDetailsList</code> element with zero, one, or multiple <code>GeoLocationDetails</code>
        /// child elements. The list is sorted by country code, and then subdivision code, followed
        /// by continents at the end of the list. 
        /// 
        ///  
        /// <para>
        ///  By default, the list of geo locations is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// If the list is truncated, <code>IsTruncated</code> will be set to <i>true</i> and
        /// a combination of <code>NextContinentCode, NextCountryCode, NextSubdivisionCode</code>
        /// will be populated. You can pass these as parameters to <code>StartContinentCode, StartCountryCode,
        /// StartSubdivisionCode</code> to control the geo location that the list begins with.
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListGeoLocationsResponse ListGeoLocations();

        /// <summary>
        /// To retrieve a list of supported geo locations, send a <code>GET</code> request to
        /// the <code>2013-04-01/geolocations</code> resource. The response to this request includes
        /// a <code>GeoLocationDetailsList</code> element with zero, one, or multiple <code>GeoLocationDetails</code>
        /// child elements. The list is sorted by country code, and then subdivision code, followed
        /// by continents at the end of the list. 
        /// 
        ///  
        /// <para>
        ///  By default, the list of geo locations is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// If the list is truncated, <code>IsTruncated</code> will be set to <i>true</i> and
        /// a combination of <code>NextContinentCode, NextCountryCode, NextSubdivisionCode</code>
        /// will be populated. You can pass these as parameters to <code>StartContinentCode, StartCountryCode,
        /// StartSubdivisionCode</code> to control the geo location that the list begins with.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations service method.</param>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListGeoLocationsResponse ListGeoLocations(ListGeoLocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeoLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListGeoLocationsResponse> ListGeoLocationsAsync(ListGeoLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListHealthChecks

        /// <summary>
        /// To retrieve a list of your health checks, send a <code>GET</code> request to the
        /// <code>2013-04-01/healthcheck</code> resource. The response to this request includes
        /// a <code>HealthChecks</code> element with zero, one, or multiple <code>HealthCheck</code>
        /// child elements. By default, the list of health checks is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the health check
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Route 53 endpoint. Please
        /// consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListHealthChecksResponse ListHealthChecks();

        /// <summary>
        /// To retrieve a list of your health checks, send a <code>GET</code> request to the
        /// <code>2013-04-01/healthcheck</code> resource. The response to this request includes
        /// a <code>HealthChecks</code> element with zero, one, or multiple <code>HealthCheck</code>
        /// child elements. By default, the list of health checks is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the health check
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks service method.</param>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Route 53 endpoint. Please
        /// consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHealthChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListHealthChecksResponse> ListHealthChecksAsync(ListHealthChecksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListHostedZones

        /// <summary>
        /// To retrieve a list of your hosted zones, send a <code>GET</code> request to the <code>2013-04-01/hostedzone</code>
        /// resource. The response to this request includes a <code>HostedZones</code> element
        /// with zero, one, or multiple <code>HostedZone</code> child elements. By default, the
        /// list of hosted zones is displayed on a single page. You can control the length of
        /// the page that is displayed by using the <code>MaxItems</code> parameter. You can use
        /// the <code>Marker</code> parameter to control the hosted zone that the list begins
        /// with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        ListHostedZonesResponse ListHostedZones();

        /// <summary>
        /// To retrieve a list of your hosted zones, send a <code>GET</code> request to the <code>2013-04-01/hostedzone</code>
        /// resource. The response to this request includes a <code>HostedZones</code> element
        /// with zero, one, or multiple <code>HostedZone</code> child elements. By default, the
        /// list of hosted zones is displayed on a single page. You can control the length of
        /// the page that is displayed by using the <code>MaxItems</code> parameter. You can use
        /// the <code>Marker</code> parameter to control the hosted zone that the list begins
        /// with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones service method.</param>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListHostedZonesResponse> ListHostedZonesAsync(ListHostedZonesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceRecordSets

        /// <summary>
        /// Imagine all the resource record sets in a zone listed out in front of you. Imagine
        /// them sorted lexicographically first by DNS name (with the labels reversed, like "com.amazon.www"
        /// for example), and secondarily, lexicographically by record type. This operation retrieves
        /// at most MaxItems resource record sets from this list, in order, starting at a position
        /// specified by the Name and Type arguments:
        /// 
        ///  <ul> <li>If both Name and Type are omitted, this means start the results at the first
        /// RRSET in the HostedZone.</li> <li>If Name is specified but Type is omitted, this means
        /// start the results at the first RRSET in the list whose name is greater than or equal
        /// to Name. </li> <li>If both Name and Type are specified, this means start the results
        /// at the first RRSET in the list whose name is greater than or equal to Name and whose
        /// type is greater than or equal to Type.</li> <li>It is an error to specify the Type
        /// but not the Name.</li> </ul> 
        /// <para>
        /// Use ListResourceRecordSets to retrieve a single known record set by specifying the
        /// record set's name and type, and setting MaxItems = 1
        /// </para>
        ///  
        /// <para>
        /// To retrieve all the records in a HostedZone, first pause any processes making calls
        /// to ChangeResourceRecordSets. Initially call ListResourceRecordSets without a Name
        /// and Type to get the first page of record sets. For subsequent calls, set Name and
        /// Type to the NextName and NextType values returned by the previous response. 
        /// </para>
        ///  
        /// <para>
        /// In the presence of concurrent ChangeResourceRecordSets calls, there is no consistency
        /// of results across calls to ListResourceRecordSets. The only way to get a consistent
        /// multi-page snapshot of all RRSETs in a zone is to stop making changes while pagination
        /// is in progress.
        /// </para>
        ///  
        /// <para>
        /// However, the results from ListResourceRecordSets are consistent within a page. If
        /// MakeChange calls are taking place concurrently, the result of each one will either
        /// be completely visible in your results or not at all. You will not see partial changes,
        /// or changes that do not ultimately succeed. (This follows from the fact that MakeChange
        /// is atomic) 
        /// </para>
        ///  
        /// <para>
        /// The results from ListResourceRecordSets are strongly consistent with ChangeResourceRecordSets.
        /// To be precise, if a single process makes a call to ChangeResourceRecordSets and receives
        /// a successful response, the effects of that change will be visible in a subsequent
        /// call to ListResourceRecordSets by that process.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets service method.</param>
        /// 
        /// <returns>The response from the ListResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListResourceRecordSetsResponse> ListResourceRecordSetsAsync(ListResourceRecordSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReusableDelegationSets

        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>2013-04-01/delegationset</code> resource. The response to this request
        /// includes a <code>DelegationSets</code> element with zero, one, or multiple <code>DelegationSet</code>
        /// child elements. By default, the list of delegation sets is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the delegation
        /// set that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListReusableDelegationSetsResponse ListReusableDelegationSets();

        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>2013-04-01/delegationset</code> resource. The response to this request
        /// includes a <code>DelegationSets</code> element with zero, one, or multiple <code>DelegationSet</code>
        /// child elements. By default, the list of delegation sets is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the delegation
        /// set that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets service method.</param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListReusableDelegationSetsResponse ListReusableDelegationSets(ListReusableDelegationSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReusableDelegationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(ListReusableDelegationSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResources

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResources service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        ListTagsForResourcesResponse ListTagsForResources(ListTagsForResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourcesResponse> ListTagsForResourcesAsync(ListTagsForResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateHealthCheck

        /// <summary>
        /// This action updates an existing health check.
        /// 
        ///  
        /// <para>
        ///  To update a health check, send a <code>POST</code> request to the <code>2013-04-01/healthcheck/<i>health
        /// check ID</i></code> resource. The request body must include an XML document with an
        /// <code>UpdateHealthCheckRequest</code> element. The response returns an <code>UpdateHealthCheckResponse</code>
        /// element, which contains metadata about the health check.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the UpdateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckVersionMismatchException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        UpdateHealthCheckResponse UpdateHealthCheck(UpdateHealthCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateHealthCheckResponse> UpdateHealthCheckAsync(UpdateHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateHostedZoneComment

        /// <summary>
        /// To update the hosted zone comment, send a <code>POST</code> request to the <code>2013-04-01/hostedzone/<i>hosted
        /// zone ID</i></code> resource. The request body must include an XML document with a
        /// <code>UpdateHostedZoneCommentRequest</code> element. The response to this request
        /// includes the modified <code>HostedZone</code> element.
        /// 
        ///  <note> The comment can have a maximum length of 256 characters.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment service method.</param>
        /// 
        /// <returns>The response from the UpdateHostedZoneComment service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        UpdateHostedZoneCommentResponse UpdateHostedZoneComment(UpdateHostedZoneCommentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHostedZoneComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateHostedZoneCommentResponse> UpdateHostedZoneCommentAsync(UpdateHostedZoneCommentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
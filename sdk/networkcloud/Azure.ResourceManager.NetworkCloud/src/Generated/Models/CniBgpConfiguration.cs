// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> CniBgpConfiguration represents the Calico BGP configuration. </summary>
    public partial class CniBgpConfiguration
    {
        /// <summary> Initializes a new instance of CniBgpConfiguration. </summary>
        public CniBgpConfiguration()
        {
            BgpPeers = new ChangeTrackingList<BgpPeer>();
            CommunityAdvertisements = new ChangeTrackingList<CommunityAdvertisement>();
            ServiceExternalPrefixes = new ChangeTrackingList<string>();
            ServiceLoadBalancerPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CniBgpConfiguration. </summary>
        /// <param name="bgpPeers"> The list of BgpPeer entities that the Hybrid AKS cluster will peer with in addition to peering that occurs automatically with the switch fabric. </param>
        /// <param name="communityAdvertisements">
        /// The list of prefix community advertisement properties. Each prefix community specifies a prefix, and the
        /// communities that should be associated with that prefix when it is announced.
        /// </param>
        /// <param name="nodeMeshPassword"> The password of the Calico node mesh. It defaults to a randomly-generated string when not provided. </param>
        /// <param name="serviceExternalPrefixes"> The subnet blocks in CIDR format for Kubernetes service external IPs to be advertised over BGP. </param>
        /// <param name="serviceLoadBalancerPrefixes">
        /// The subnet blocks in CIDR format for Kubernetes load balancers. Load balancer IPs will only be advertised if they
        /// are within one of these blocks.
        /// </param>
        internal CniBgpConfiguration(IList<BgpPeer> bgpPeers, IList<CommunityAdvertisement> communityAdvertisements, string nodeMeshPassword, IList<string> serviceExternalPrefixes, IList<string> serviceLoadBalancerPrefixes)
        {
            BgpPeers = bgpPeers;
            CommunityAdvertisements = communityAdvertisements;
            NodeMeshPassword = nodeMeshPassword;
            ServiceExternalPrefixes = serviceExternalPrefixes;
            ServiceLoadBalancerPrefixes = serviceLoadBalancerPrefixes;
        }

        /// <summary> The list of BgpPeer entities that the Hybrid AKS cluster will peer with in addition to peering that occurs automatically with the switch fabric. </summary>
        public IList<BgpPeer> BgpPeers { get; }
        /// <summary>
        /// The list of prefix community advertisement properties. Each prefix community specifies a prefix, and the
        /// communities that should be associated with that prefix when it is announced.
        /// </summary>
        public IList<CommunityAdvertisement> CommunityAdvertisements { get; }
        /// <summary> The password of the Calico node mesh. It defaults to a randomly-generated string when not provided. </summary>
        public string NodeMeshPassword { get; set; }
        /// <summary> The subnet blocks in CIDR format for Kubernetes service external IPs to be advertised over BGP. </summary>
        public IList<string> ServiceExternalPrefixes { get; }
        /// <summary>
        /// The subnet blocks in CIDR format for Kubernetes load balancers. Load balancer IPs will only be advertised if they
        /// are within one of these blocks.
        /// </summary>
        public IList<string> ServiceLoadBalancerPrefixes { get; }
    }
}

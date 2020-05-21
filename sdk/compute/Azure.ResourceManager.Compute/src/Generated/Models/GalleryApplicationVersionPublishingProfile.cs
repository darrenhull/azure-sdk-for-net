// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The publishing profile of a gallery Image Version. </summary>
    public partial class GalleryApplicationVersionPublishingProfile : GalleryArtifactPublishingProfileBase
    {
        /// <summary> Initializes a new instance of GalleryApplicationVersionPublishingProfile. </summary>
        /// <param name="source"> The source image from which the Image Version is going to be created. </param>
        public GalleryApplicationVersionPublishingProfile(UserArtifactSource source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            Source = source;
        }

        /// <summary> Initializes a new instance of GalleryApplicationVersionPublishingProfile. </summary>
        /// <param name="targetRegions"> The target regions where the Image Version is going to be replicated to. This property is updatable. </param>
        /// <param name="replicaCount"> The number of replicas of the Image Version to be created per region. This property would take effect for a region when regionalReplicaCount is not specified. This property is updatable. </param>
        /// <param name="excludeFromLatest"> If set to true, Virtual Machines deployed from the latest version of the Image Definition won&apos;t use this Image Version. </param>
        /// <param name="publishedDate"> The timestamp for when the gallery Image Version is published. </param>
        /// <param name="endOfLifeDate"> The end of life date of the gallery Image Version. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="storageAccountType"> Specifies the storage account type to be used to store the image. This property is not updatable. </param>
        /// <param name="source"> The source image from which the Image Version is going to be created. </param>
        /// <param name="contentType"> Optional. May be used to help process this file. The type of file contained in the source, e.g. zip, json, etc. </param>
        /// <param name="enableHealthCheck"> Optional. Whether or not this application reports health. </param>
        internal GalleryApplicationVersionPublishingProfile(IList<TargetRegion> targetRegions, int? replicaCount, bool? excludeFromLatest, DateTimeOffset? publishedDate, DateTimeOffset? endOfLifeDate, StorageAccountType? storageAccountType, UserArtifactSource source, string contentType, bool? enableHealthCheck) : base(targetRegions, replicaCount, excludeFromLatest, publishedDate, endOfLifeDate, storageAccountType)
        {
            Source = source;
            ContentType = contentType;
            EnableHealthCheck = enableHealthCheck;
        }

        /// <summary> The source image from which the Image Version is going to be created. </summary>
        public UserArtifactSource Source { get; set; }
        /// <summary> Optional. May be used to help process this file. The type of file contained in the source, e.g. zip, json, etc. </summary>
        public string ContentType { get; set; }
        /// <summary> Optional. Whether or not this application reports health. </summary>
        public bool? EnableHealthCheck { get; set; }
    }
}
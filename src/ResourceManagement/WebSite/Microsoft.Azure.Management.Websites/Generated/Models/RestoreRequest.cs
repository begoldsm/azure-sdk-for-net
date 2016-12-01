// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Description of a restore request
    /// </summary>
    [JsonTransformation]
    public partial class RestoreRequest : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RestoreRequest class.
        /// </summary>
        public RestoreRequest() { }

        /// <summary>
        /// Initializes a new instance of the RestoreRequest class.
        /// </summary>
        public RestoreRequest(String name, String location, String id = default(String), String kind = default(String), String type = default(String), IDictionary<string, String> tags = default(IDictionary<string, String>), string storageAccountUrl = default(string), string blobName = default(string), bool? overwrite = default(bool?), string siteName = default(string), IList<DatabaseBackupSetting> databases = default(IList<DatabaseBackupSetting>), bool? ignoreConflictingHostNames = default(bool?), BackupRestoreOperationType? operationType = default(BackupRestoreOperationType?), bool? adjustConnectionStrings = default(bool?), string hostingEnvironment = default(string))
            : base(name, location, id, kind, type, tags)
        {
            StorageAccountUrl = storageAccountUrl;
            BlobName = blobName;
            Overwrite = overwrite;
            SiteName = siteName;
            Databases = databases;
            IgnoreConflictingHostNames = ignoreConflictingHostNames;
            OperationType = operationType;
            AdjustConnectionStrings = adjustConnectionStrings;
            HostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// SAS URL to the container
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountUrl")]
        public string StorageAccountUrl { get; set; }

        /// <summary>
        /// Name of a blob which contains the backup
        /// </summary>
        [JsonProperty(PropertyName = "properties.blobName")]
        public string BlobName { get; set; }

        /// <summary>
        /// True if the restore operation can overwrite target site. "True"
        /// needed if trying to restore over an existing site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Name of a site (Web App)
        /// </summary>
        [JsonProperty(PropertyName = "properties.siteName")]
        public string SiteName { get; set; }

        /// <summary>
        /// Collection of databses which should be restored. This list has to
        /// match the list of databases included in the backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databases")]
        public IList<DatabaseBackupSetting> Databases { get; set; }

        /// <summary>
        /// Changes a logic when restoring a site with custom domains. If
        /// "true", custom domains are removed automatically. If "false",
        /// custom domains are added to
        /// the site object when it is being restored, but that
        /// might fail due to conflicts during the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ignoreConflictingHostNames")]
        public bool? IgnoreConflictingHostNames { get; set; }

        /// <summary>
        /// Operation type. Possible values include: 'Default', 'Clone',
        /// 'Relocation'
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationType")]
        public BackupRestoreOperationType? OperationType { get; set; }

        /// <summary>
        /// Gets or sets a flag showing if SiteConfig.ConnectionStrings should
        /// be set in new site
        /// </summary>
        [JsonProperty(PropertyName = "properties.adjustConnectionStrings")]
        public bool? AdjustConnectionStrings { get; set; }

        /// <summary>
        /// App Service Environment name, if needed (only when restoring a
        /// site to an App Service Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostingEnvironment")]
        public string HostingEnvironment { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

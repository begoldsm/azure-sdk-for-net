// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Container with items backed up using MAB backup engine.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MABWindowsContainer")]
    public partial class MabContainer : ProtectionContainer
    {
        /// <summary>
        /// Initializes a new instance of the MabContainer class.
        /// </summary>
        public MabContainer() { }

        /// <summary>
        /// Initializes a new instance of the MabContainer class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the container.</param>
        /// <param name="backupManagementType">Type of backup managemenent for
        /// the container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql'</param>
        /// <param name="registrationStatus">Status of registration of the
        /// container with the Recovery Services Vault.</param>
        /// <param name="healthStatus">Status of health of the
        /// container.</param>
        /// <param name="containerType">Type of the container. The value of
        /// this property for: 1. Compute Azure VM is
        /// Microsoft.Compute/virtualMachines 2. Classic Compute Azure VM is
        /// Microsoft.ClassicCompute/virtualMachines 3. Windows machines
        /// (like MAB, DPM etc) is Windows 4. Azure SQL instance is
        /// AzureSqlContainer.</param>
        /// <param name="canReRegister">Can the container be registered one
        /// more time.</param>
        /// <param name="containerId">ContainerID represents the
        /// container.</param>
        /// <param name="protectedItemCount">Number of items backed up in this
        /// container.</param>
        /// <param name="agentVersion">Agent version of this container.</param>
        /// <param name="extendedInfo">Additional information for this
        /// container</param>
        public MabContainer(string friendlyName = default(string), BackupManagementType? backupManagementType = default(BackupManagementType?), string registrationStatus = default(string), string healthStatus = default(string), string containerType = default(string), bool? canReRegister = default(bool?), long? containerId = default(long?), long? protectedItemCount = default(long?), string agentVersion = default(string), MabContainerExtendedInfo extendedInfo = default(MabContainerExtendedInfo))
            : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType)
        {
            CanReRegister = canReRegister;
            ContainerId = containerId;
            ProtectedItemCount = protectedItemCount;
            AgentVersion = agentVersion;
            ExtendedInfo = extendedInfo;
        }

        /// <summary>
        /// Gets or sets can the container be registered one more time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "canReRegister")]
        public bool? CanReRegister { get; set; }

        /// <summary>
        /// Gets or sets containerID represents the container.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "containerId")]
        public long? ContainerId { get; set; }

        /// <summary>
        /// Gets or sets number of items backed up in this container.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protectedItemCount")]
        public long? ProtectedItemCount { get; set; }

        /// <summary>
        /// Gets or sets agent version of this container.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets additional information for this container
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "extendedInfo")]
        public MabContainerExtendedInfo ExtendedInfo { get; set; }

    }
}

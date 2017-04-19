// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Hive metastore add or update parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UpdateHiveMetaStoreParameters
    {
        /// <summary>
        /// Initializes a new instance of the UpdateHiveMetaStoreParameters
        /// class.
        /// </summary>
        public UpdateHiveMetaStoreParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateHiveMetaStoreParameters
        /// class.
        /// </summary>
        /// <param name="serverUri">Gets or sets URL of the server to connect
        /// to. For example: myserver.database.windows.net,
        /// myserver.cloudapp.net</param>
        /// <param name="databaseName">Gets or sets the name of the database to
        /// connect to.</param>
        /// <param name="runtimeVersion">Gets or sets the Hive version
        /// associated with the metastore. Format: 1.2.3.4</param>
        /// <param name="userName">Sets the user name for the
        /// connection.</param>
        /// <param name="password">Sets the password for the
        /// connection.</param>
        public UpdateHiveMetaStoreParameters(string serverUri = default(string), string databaseName = default(string), string runtimeVersion = default(string), string userName = default(string), string password = default(string))
        {
            ServerUri = serverUri;
            DatabaseName = databaseName;
            RuntimeVersion = runtimeVersion;
            UserName = userName;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL of the server to connect to. For example:
        /// myserver.database.windows.net, myserver.cloudapp.net
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverUri")]
        public string ServerUri { get; set; }

        /// <summary>
        /// Gets or sets the name of the database to connect to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the Hive version associated with the metastore.
        /// Format: 1.2.3.4
        /// </summary>
        [JsonProperty(PropertyName = "properties.runtimeVersion")]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Gets or sets sets the user name for the connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets sets the password for the connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

    }
}
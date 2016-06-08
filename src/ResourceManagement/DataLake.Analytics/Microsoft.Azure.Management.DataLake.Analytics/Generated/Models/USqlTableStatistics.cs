// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL table statistics item.
    /// </summary>
    public partial class USqlTableStatistics : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlTableStatistics class.
        /// </summary>
        public USqlTableStatistics() { }

        /// <summary>
        /// Initializes a new instance of the USqlTableStatistics class.
        /// </summary>
        public USqlTableStatistics(string computeAccountName = default(string), Guid? version = default(Guid?), string databaseName = default(string), string schemaName = default(string), string tableName = default(string), string name = default(string), string userStatName = default(string), string statDataPath = default(string), DateTimeOffset? createTime = default(DateTimeOffset?), DateTimeOffset? updateTime = default(DateTimeOffset?), bool? isUserCreated = default(bool?), bool? isAutoCreated = default(bool?), bool? hasFilter = default(bool?), string filterDefinition = default(string), IList<string> colNames = default(IList<string>))
            : base(computeAccountName, version)
        {
            DatabaseName = databaseName;
            SchemaName = schemaName;
            TableName = tableName;
            Name = name;
            UserStatName = userStatName;
            StatDataPath = statDataPath;
            CreateTime = createTime;
            UpdateTime = updateTime;
            IsUserCreated = isUserCreated;
            IsAutoCreated = isAutoCreated;
            HasFilter = hasFilter;
            FilterDefinition = filterDefinition;
            ColNames = colNames;
        }

        /// <summary>
        /// Gets or sets gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the name of the schema associated with
        /// this table and database.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the name of the table.
        /// </summary>
        [JsonProperty(PropertyName = "tableName")]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the name of the table statistics.
        /// </summary>
        [JsonProperty(PropertyName = "statisticsName")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the name of the user statistics.
        /// </summary>
        [JsonProperty(PropertyName = "userStatName")]
        public string UserStatName { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the path to the statistics data.
        /// </summary>
        [JsonProperty(PropertyName = "statDataPath")]
        public string StatDataPath { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the creation time of the statistics.
        /// </summary>
        [JsonProperty(PropertyName = "createTime")]
        public DateTimeOffset? CreateTime { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the last time the statistics were
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "updateTime")]
        public DateTimeOffset? UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the switch indicating if these
        /// statistics are user created.
        /// </summary>
        [JsonProperty(PropertyName = "isUserCreated")]
        public bool? IsUserCreated { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the switch indicating if these
        /// statistics are automatically created.
        /// </summary>
        [JsonProperty(PropertyName = "isAutoCreated")]
        public bool? IsAutoCreated { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the switch indicating if these
        /// statistics have a filter.
        /// </summary>
        [JsonProperty(PropertyName = "hasFilter")]
        public bool? HasFilter { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the filter definition for the statistics.
        /// </summary>
        [JsonProperty(PropertyName = "filterDefinition")]
        public string FilterDefinition { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the list of column names associated with
        /// these statistics.
        /// </summary>
        [JsonProperty(PropertyName = "colNames")]
        public IList<string> ColNames { get; set; }

    }
}

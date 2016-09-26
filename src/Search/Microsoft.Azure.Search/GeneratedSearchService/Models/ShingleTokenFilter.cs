// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Creates combinations of tokens as a single token. This token filter is
    /// implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/shingle/ShingleFilter.html" />
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.ShingleTokenFilter")]
    public partial class ShingleTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the ShingleTokenFilter class.
        /// </summary>
        public ShingleTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the ShingleTokenFilter class.
        /// </summary>
        public ShingleTokenFilter(string name, int? maxShingleSize = default(int?), int? minShingleSize = default(int?), bool? outputUnigrams = default(bool?), bool? outputUnigramsIfNoShingles = default(bool?), string tokenSeparator = default(string), string filterToken = default(string))
            : base(name)
        {
            MaxShingleSize = maxShingleSize;
            MinShingleSize = minShingleSize;
            OutputUnigrams = outputUnigrams;
            OutputUnigramsIfNoShingles = outputUnigramsIfNoShingles;
            TokenSeparator = tokenSeparator;
            FilterToken = filterToken;
        }

        /// <summary>
        /// Gets or sets the maximum shingle size. Default is 2.
        /// </summary>
        [JsonProperty(PropertyName = "maxShingleSize")]
        public int? MaxShingleSize { get; set; }

        /// <summary>
        /// Gets or sets the minimum shingle size. Default is 2.
        /// </summary>
        [JsonProperty(PropertyName = "minShingleSize")]
        public int? MinShingleSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the output stream will
        /// contain the input tokens (unigrams) as well as shingles. Default
        /// is true.
        /// </summary>
        [JsonProperty(PropertyName = "outputUnigrams")]
        public bool? OutputUnigrams { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to output unigrams for
        /// those times when no shingles are available. This property takes
        /// precedence when outputUnigrams is set to false. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "outputUnigramsIfNoShingles")]
        public bool? OutputUnigramsIfNoShingles { get; set; }

        /// <summary>
        /// Gets or sets the string to use when joining adjacent tokens to
        /// form a shingle. Default is a single space (" ").
        /// </summary>
        [JsonProperty(PropertyName = "tokenSeparator")]
        public string TokenSeparator { get; set; }

        /// <summary>
        /// Gets or sets the string to insert for each position at which there
        /// is no token. Default is an underscore ("_").
        /// </summary>
        [JsonProperty(PropertyName = "filterToken")]
        public string FilterToken { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

//****************************************
// This file was autogenerated by a tool.
// Do not modify it.
//****************************************
namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A locality hint that can be used by the Batch service to select a compute node on which to start a new task.
    /// </summary>
    public partial class AffinityInformation : ITransportObjectProvider<Models.AffinityInformation>, IPropertyMetadata
    {
        private readonly string affinityId;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="AffinityInformation"/> class.
        /// </summary>
        /// <param name='affinityId'>An opaque string that represents a previously run task or compute node.</param>
        public AffinityInformation(
            string affinityId)
        {
            this.affinityId = affinityId;
        }

        internal AffinityInformation(Models.AffinityInformation protocolObject)
        {
            this.affinityId = protocolObject.AffinityId;
        }

        #endregion Constructors

        #region AffinityInformation

        /// <summary>
        /// Gets an opaque string that represents a previously run task or compute node.
        /// </summary>
        public string AffinityId
        {
            get { return this.affinityId; }
        }

        #endregion // AffinityInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.AffinityInformation ITransportObjectProvider<Models.AffinityInformation>.GetTransportObject()
        {
            Models.AffinityInformation result = new Models.AffinityInformation()
            {
                AffinityId = this.AffinityId,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}
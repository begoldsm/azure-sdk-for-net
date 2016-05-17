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
    /// A reference to an application package to be installed on compute nodes in a pool.
    /// </summary>
    public partial class ApplicationPackageReference : ITransportObjectProvider<Models.ApplicationPackageReference>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<string> ApplicationIdProperty;
            public readonly PropertyAccessor<string> VersionProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.ApplicationIdProperty = this.CreatePropertyAccessor<string>("ApplicationId", BindingAccess.Read | BindingAccess.Write);
                this.VersionProperty = this.CreatePropertyAccessor<string>("Version", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.ApplicationPackageReference protocolObject) : base(BindingState.Bound)
            {
                this.ApplicationIdProperty = this.CreatePropertyAccessor(
                    protocolObject.ApplicationId,
                    "ApplicationId",
                    BindingAccess.Read);
                this.VersionProperty = this.CreatePropertyAccessor(
                    protocolObject.Version,
                    "Version",
                    BindingAccess.Read);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationPackageReference"/> class.
        /// </summary>
        public ApplicationPackageReference()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal ApplicationPackageReference(Models.ApplicationPackageReference protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region ApplicationPackageReference

        /// <summary>
        /// Gets or sets the id of the application to be installed on the compute nodes. 
        /// </summary>
        public string ApplicationId
        {
            get { return this.propertyContainer.ApplicationIdProperty.Value; }
            set { this.propertyContainer.ApplicationIdProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the version of the application to be installed on the compute nodes.
        /// </summary>
        /// <remarks>
        /// If not specified, the default version of the application, as defined in the application settings, is installed. 
        /// If no default version is defined in the application settings, you must specify a version in the <see cref="ApplicationPackageReference"/>.
        /// </remarks>
        public string Version
        {
            get { return this.propertyContainer.VersionProperty.Value; }
            set { this.propertyContainer.VersionProperty.Value = value; }
        }

        #endregion // ApplicationPackageReference

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.ApplicationPackageReference ITransportObjectProvider<Models.ApplicationPackageReference>.GetTransportObject()
        {
            Models.ApplicationPackageReference result = new Models.ApplicationPackageReference()
            {
                ApplicationId = this.ApplicationId,
                Version = this.Version,
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<ApplicationPackageReference> ConvertFromProtocolCollection(IEnumerable<Models.ApplicationPackageReference> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ApplicationPackageReference> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ApplicationPackageReference(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<ApplicationPackageReference> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.ApplicationPackageReference> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ApplicationPackageReference> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ApplicationPackageReference(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<ApplicationPackageReference> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.ApplicationPackageReference> protoCollection)
        {
            IReadOnlyList<ApplicationPackageReference> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new ApplicationPackageReference(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}
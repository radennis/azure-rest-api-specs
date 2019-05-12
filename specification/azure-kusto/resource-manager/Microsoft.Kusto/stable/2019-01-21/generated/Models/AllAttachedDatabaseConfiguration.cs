// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing an attached database configuration for a all
    /// attached database kind.
    /// </summary>
    [Newtonsoft.Json.JsonObject("All")]
    [Rest.Serialization.JsonTransformation]
    public partial class AllAttachedDatabaseConfiguration : AttachedDatabaseConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the AllAttachedDatabaseConfiguration
        /// class.
        /// </summary>
        public AllAttachedDatabaseConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AllAttachedDatabaseConfiguration
        /// class.
        /// </summary>
        /// <param name="clusterResourceId">The resource id of the cluster
        /// where the databases you would like to attach reside.</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="databaseNames">The list of current databases that are
        /// attached.</param>
        public AllAttachedDatabaseConfiguration(string clusterResourceId, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IList<string> databaseNames = default(IList<string>))
            : base(id, name, type, location)
        {
            DatabaseNames = databaseNames;
            ClusterResourceId = clusterResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of current databases that are attached.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseNames")]
        public IList<string> DatabaseNames { get; private set; }

        /// <summary>
        /// Gets or sets the resource id of the cluster where the databases you
        /// would like to attach reside.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterResourceId")]
        public string ClusterResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ClusterResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClusterResourceId");
            }
        }
    }
}

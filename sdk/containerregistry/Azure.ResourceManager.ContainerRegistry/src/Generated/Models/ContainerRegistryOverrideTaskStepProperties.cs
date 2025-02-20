// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The ContainerRegistryOverrideTaskStepProperties. </summary>
    public partial class ContainerRegistryOverrideTaskStepProperties
    {
        /// <summary> Initializes a new instance of ContainerRegistryOverrideTaskStepProperties. </summary>
        public ContainerRegistryOverrideTaskStepProperties()
        {
            Arguments = new ChangeTrackingList<ContainerRegistryRunArgument>();
            Values = new ChangeTrackingList<ContainerRegistryTaskOverridableValue>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryOverrideTaskStepProperties. </summary>
        /// <param name="contextPath"> The source context against which run has to be queued. </param>
        /// <param name="file"> The file against which run has to be queued. </param>
        /// <param name="arguments">
        /// Gets or sets the collection of override arguments to be used when
        /// executing a build step.
        /// </param>
        /// <param name="target"> The name of the target build stage for the docker build. </param>
        /// <param name="values"> The collection of overridable values that can be passed when running a Task. </param>
        /// <param name="updateTriggerToken"> Base64 encoded update trigger token that will be attached with the base image trigger webhook. </param>
        internal ContainerRegistryOverrideTaskStepProperties(string contextPath, string file, IList<ContainerRegistryRunArgument> arguments, string target, IList<ContainerRegistryTaskOverridableValue> values, string updateTriggerToken)
        {
            ContextPath = contextPath;
            File = file;
            Arguments = arguments;
            Target = target;
            Values = values;
            UpdateTriggerToken = updateTriggerToken;
        }

        /// <summary> The source context against which run has to be queued. </summary>
        public string ContextPath { get; set; }
        /// <summary> The file against which run has to be queued. </summary>
        public string File { get; set; }
        /// <summary>
        /// Gets or sets the collection of override arguments to be used when
        /// executing a build step.
        /// </summary>
        public IList<ContainerRegistryRunArgument> Arguments { get; }
        /// <summary> The name of the target build stage for the docker build. </summary>
        public string Target { get; set; }
        /// <summary> The collection of overridable values that can be passed when running a Task. </summary>
        public IList<ContainerRegistryTaskOverridableValue> Values { get; }
        /// <summary> Base64 encoded update trigger token that will be attached with the base image trigger webhook. </summary>
        public string UpdateTriggerToken { get; set; }
    }
}

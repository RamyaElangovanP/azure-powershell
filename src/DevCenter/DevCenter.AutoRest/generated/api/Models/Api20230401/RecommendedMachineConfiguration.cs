// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>Properties for a recommended machine configuration.</summary>
    public partial class RecommendedMachineConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IRecommendedMachineConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IRecommendedMachineConfigurationInternal
    {

        /// <summary>Backing field for <see cref="Memory" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRange _memory;

        /// <summary>Recommended memory range.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRange Memory { get => (this._memory = this._memory ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ResourceRange()); }

        /// <summary>Maximum value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public int? MemoryMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)Memory).Max; }

        /// <summary>Minimum value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public int? MemoryMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)Memory).Min; }

        /// <summary>Internal Acessors for Memory</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRange Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IRecommendedMachineConfigurationInternal.Memory { get => (this._memory = this._memory ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ResourceRange()); set { {_memory = value;} } }

        /// <summary>Internal Acessors for MemoryMax</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IRecommendedMachineConfigurationInternal.MemoryMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)Memory).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)Memory).Max = value; }

        /// <summary>Internal Acessors for MemoryMin</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IRecommendedMachineConfigurationInternal.MemoryMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)Memory).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)Memory).Min = value; }

        /// <summary>Internal Acessors for VCpUs</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRange Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IRecommendedMachineConfigurationInternal.VCpUs { get => (this._vCpUs = this._vCpUs ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ResourceRange()); set { {_vCpUs = value;} } }

        /// <summary>Internal Acessors for VCpUsMax</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IRecommendedMachineConfigurationInternal.VCpUsMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)VCpUs).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)VCpUs).Max = value; }

        /// <summary>Internal Acessors for VCpUsMin</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IRecommendedMachineConfigurationInternal.VCpUsMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)VCpUs).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)VCpUs).Min = value; }

        /// <summary>Backing field for <see cref="VCpUs" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRange _vCpUs;

        /// <summary>Recommended vCPU range.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRange VCpUs { get => (this._vCpUs = this._vCpUs ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ResourceRange()); }

        /// <summary>Maximum value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public int? VCpUsMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)VCpUs).Max; }

        /// <summary>Minimum value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public int? VCpUsMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRangeInternal)VCpUs).Min; }

        /// <summary>Creates an new <see cref="RecommendedMachineConfiguration" /> instance.</summary>
        public RecommendedMachineConfiguration()
        {

        }
    }
    /// Properties for a recommended machine configuration.
    public partial interface IRecommendedMachineConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>Maximum value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Maximum value.",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(int) })]
        int? MemoryMax { get;  }
        /// <summary>Minimum value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Minimum value.",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(int) })]
        int? MemoryMin { get;  }
        /// <summary>Maximum value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Maximum value.",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(int) })]
        int? VCpUsMax { get;  }
        /// <summary>Minimum value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Minimum value.",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(int) })]
        int? VCpUsMin { get;  }

    }
    /// Properties for a recommended machine configuration.
    internal partial interface IRecommendedMachineConfigurationInternal

    {
        /// <summary>Recommended memory range.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRange Memory { get; set; }
        /// <summary>Maximum value.</summary>
        int? MemoryMax { get; set; }
        /// <summary>Minimum value.</summary>
        int? MemoryMin { get; set; }
        /// <summary>Recommended vCPU range.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IResourceRange VCpUs { get; set; }
        /// <summary>Maximum value.</summary>
        int? VCpUsMax { get; set; }
        /// <summary>Minimum value.</summary>
        int? VCpUsMin { get; set; }

    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Extensions;

    /// <summary>A tag rule belonging to NewRelic account</summary>
    public partial class TagRule :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.ITagRule,
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.ITagRuleInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.Resource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).Id; }

        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty,
        /// all resources will be captured.
        /// If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are
        /// specified, the rules will only include resources with the associated tags.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IFilteringTag[] LogRuleFilteringTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleFilteringTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleFilteringTag = value ?? null /* arrayOf */; }

        /// <summary>Flag specifying if AAD logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendAadLogsStatus? LogRuleSendAadLog { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendAadLog; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendAadLog = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendAadLogsStatus)""); }

        /// <summary>
        /// Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendActivityLogsStatus? LogRuleSendActivityLog { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendActivityLog; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendActivityLog = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendActivityLogsStatus)""); }

        /// <summary>Flag specifying if subscription logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendSubscriptionLogsStatus? LogRuleSendSubscriptionLog { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendSubscriptionLog; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendSubscriptionLog = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendSubscriptionLogsStatus)""); }

        /// <summary>List of filtering tags to be used for capturing metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IFilteringTag[] MetricRuleFilteringTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).MetricRuleFilteringTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).MetricRuleFilteringTag = value ?? null /* arrayOf */; }

        /// <summary>Flag specifying if metrics should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendMetricsStatus? MetricRuleSendMetric { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).MetricRuleSendMetric; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).MetricRuleSendMetric = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendMetricsStatus)""); }

        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string MetricRuleUserEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).MetricRuleUserEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).MetricRuleUserEmail = value ?? null; }

        /// <summary>Internal Acessors for LogRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.ILogRules Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.ITagRuleInternal.LogRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).LogRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).LogRule = value; }

        /// <summary>Internal Acessors for MetricRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMetricRules Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.ITagRuleInternal.MetricRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).MetricRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).MetricRule = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesProperties Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.ITagRuleInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.MonitoringTagRulesProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.ITagRuleInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.MonitoringTagRulesProperties()); set => this._property = value; }

        /// <summary>Provisioning State of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="TagRule" /> instance.</summary>
        public TagRule()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// A tag rule belonging to NewRelic account
    public partial interface ITagRule :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResource
    {
        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty,
        /// all resources will be captured.
        /// If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are
        /// specified, the rules will only include resources with the associated tags.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty, all resources will be captured.
        If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.",
        SerializedName = @"filteringTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IFilteringTag) })]
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IFilteringTag[] LogRuleFilteringTag { get; set; }
        /// <summary>Flag specifying if AAD logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag specifying if AAD logs should be sent for the Monitor resource.",
        SerializedName = @"sendAadLogs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendAadLogsStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendAadLogsStatus? LogRuleSendAadLog { get; set; }
        /// <summary>
        /// Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.",
        SerializedName = @"sendActivityLogs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendActivityLogsStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendActivityLogsStatus? LogRuleSendActivityLog { get; set; }
        /// <summary>Flag specifying if subscription logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag specifying if subscription logs should be sent for the Monitor resource.",
        SerializedName = @"sendSubscriptionLogs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendSubscriptionLogsStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendSubscriptionLogsStatus? LogRuleSendSubscriptionLog { get; set; }
        /// <summary>List of filtering tags to be used for capturing metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of filtering tags to be used for capturing metrics.",
        SerializedName = @"filteringTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IFilteringTag) })]
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IFilteringTag[] MetricRuleFilteringTag { get; set; }
        /// <summary>Flag specifying if metrics should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag specifying if metrics should be sent for the Monitor resource.",
        SerializedName = @"sendMetrics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendMetricsStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendMetricsStatus? MetricRuleSendMetric { get; set; }
        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User Email",
        SerializedName = @"userEmail",
        PossibleTypes = new [] { typeof(string) })]
        string MetricRuleUserEmail { get; set; }
        /// <summary>Provisioning State of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State of the resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// A tag rule belonging to NewRelic account
    internal partial interface ITagRuleInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api30.IResourceInternal
    {
        /// <summary>Set of rules for sending logs for the Monitor resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.ILogRules LogRule { get; set; }
        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty,
        /// all resources will be captured.
        /// If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are
        /// specified, the rules will only include resources with the associated tags.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IFilteringTag[] LogRuleFilteringTag { get; set; }
        /// <summary>Flag specifying if AAD logs should be sent for the Monitor resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendAadLogsStatus? LogRuleSendAadLog { get; set; }
        /// <summary>
        /// Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendActivityLogsStatus? LogRuleSendActivityLog { get; set; }
        /// <summary>Flag specifying if subscription logs should be sent for the Monitor resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendSubscriptionLogsStatus? LogRuleSendSubscriptionLog { get; set; }
        /// <summary>Set of rules for sending metrics for the Monitor resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMetricRules MetricRule { get; set; }
        /// <summary>List of filtering tags to be used for capturing metrics.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IFilteringTag[] MetricRuleFilteringTag { get; set; }
        /// <summary>Flag specifying if metrics should be sent for the Monitor resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SendMetricsStatus? MetricRuleSendMetric { get; set; }
        /// <summary>User Email</summary>
        string MetricRuleUserEmail { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IMonitoringTagRulesProperties Property { get; set; }
        /// <summary>Provisioning State of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}
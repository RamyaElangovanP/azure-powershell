﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Automation.Cmdlet;
using Microsoft.Azure.Commands.Automation.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WindowsAzure.Commands.Common.Test.Mocks;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Moq;
using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.ResourceManager.Automation.Test.UnitTests
{
    [TestClass]
    public class SetAzureAutomationModuleTest : RMTestBase
    {
        private Mock<IAutomationPSClient> mockAutomationClient;

        private MockCommandRuntime mockCommandRuntime;

        private SetAzureAutomationModule cmdlet;

        [TestInitialize]
        public void SetupTest()
        {
            this.mockAutomationClient = new Mock<IAutomationPSClient>();
            this.mockCommandRuntime = new MockCommandRuntime();
            this.cmdlet = new SetAzureAutomationModule
            {
                AutomationClient = this.mockAutomationClient.Object,
                CommandRuntime = this.mockCommandRuntime
            };
        }

        [TestMethod]
        public void SetAzureAutomationModuleByNameSuccessfull()
        {
            // Setup
            string resourceGroupName = "resourceGroup";
            string accountName = "automation";
            string packageName = "module";
            Uri contentLinkURI = new Uri("https://azure.com/");

            this.mockAutomationClient.Setup(f => f.UpdateModule(resourceGroupName, accountName, packageName, contentLinkURI, string.Empty, false));

            // Test
            this.cmdlet.ResourceGroupName = resourceGroupName;
            this.cmdlet.AutomationAccountName = accountName;
            this.cmdlet.Name = packageName;
            this.cmdlet.ContentLinkUri = contentLinkURI;
            this.cmdlet.ContentLinkVersion = string.Empty;
            this.cmdlet.ExecuteCmdlet();

            // Assert
            this.mockAutomationClient.Verify(f => f.UpdateModule(resourceGroupName, accountName, packageName, contentLinkURI, string.Empty, false), Times.Once());
        }


        [TestMethod]
        public void SetAzureAutomationPowershell72ModuleByNameSuccessfull()
        {
            // Setup
            string resourceGroupName = "resourceGroup";
            string accountName = "automation";
            string packageName = "module";
            Uri contentLinkURI = new Uri("https://azure.com/");

            this.mockAutomationClient.Setup(f => f.UpdateModule(resourceGroupName, accountName, packageName, contentLinkURI, string.Empty, true));

            // Test
            this.cmdlet.ResourceGroupName = resourceGroupName;
            this.cmdlet.AutomationAccountName = accountName;
            this.cmdlet.Name = packageName;
            this.cmdlet.ContentLinkUri = contentLinkURI;
            this.cmdlet.ContentLinkVersion = string.Empty;
            this.cmdlet.RuntimeVersion = "7.2";
            this.cmdlet.ExecuteCmdlet();

            // Assert
            this.mockAutomationClient.Verify(f => f.UpdateModule(resourceGroupName, accountName, packageName, contentLinkURI, string.Empty, true), Times.Once());
        }
    }
}


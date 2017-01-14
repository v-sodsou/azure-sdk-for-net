﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Fluent.Tests.Common;
using Microsoft.Azure.Management.Resource.Fluent.Core;
using System.IO;
using Xunit;

namespace Azure.Tests.WebApp
{
    public class CertificatesTests
    {
        private static readonly string GroupName = "javacsmrg319";
        private static readonly string CertificateName = "javagoodcert319";

        [Fact(Skip = "TODO: Convert to recorded tests")]
        public void CanCRDCertificate()
        {
            var keyVaultManager = TestHelper.CreateKeyVaultManager();
            var appServiceManager = TestHelper.CreateAppServiceManager();

            var vault = keyVaultManager.Vaults.GetByGroup(GroupName, "bananagraphwebapp319com");
            var certificate = appServiceManager.AppServiceCertificates.Define("bananacert")
                .WithRegion(Region.US_WEST)
                .WithExistingResourceGroup(GroupName)
                .WithExistingCertificateOrder(appServiceManager.AppServiceCertificateOrders.GetByGroup(GroupName, "graphwebapp319"))
                .Create();
            Assert.NotNull(certificate);

            // CREATE
            certificate = appServiceManager.AppServiceCertificates.Define(CertificateName)
                .WithRegion(Region.US_EAST)
                .WithExistingResourceGroup(GroupName)
                .WithPfxFile("/Users/jianghlu/Documents/code/certs/myserver.Pfx")
                .WithPfxPassword("StrongPass!123")
                .Create();
            Assert.NotNull(certificate);
        }
    }
}
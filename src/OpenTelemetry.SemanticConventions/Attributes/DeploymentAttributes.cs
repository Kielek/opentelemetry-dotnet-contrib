// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from 'src\OpenTelemetry.SemanticConventions\scripts\templates\registry\SemanticConventionsAttributes.cs.j2' </auto-generated>

#nullable enable

#pragma warning disable CS1570 // XML comment has badly formed XML

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class DeploymentAttributes
{
    /// <summary>
    /// 'Deprecated, use <c>deployment.environment.name</c> instead.'.
    /// </summary>
    [Obsolete("Deprecated, use <c>deployment.environment.name</c> instead.")]
    public const string AttributeDeploymentEnvironment = "deployment.environment";

    /// <summary>
    /// Name of the <a href="https://wikipedia.org/wiki/Deployment_environment">deployment environment</a> (aka deployment tier).
    /// </summary>
    /// <remarks>
    /// <c>deployment.environment.name</c> does not affect the uniqueness constraints defined through
    /// the <c>service.namespace</c>, <c>service.name</c> and <c>service.instance.id</c> resource attributes.
    /// This implies that resources carrying the following attribute combinations MUST be
    /// considered to be identifying the same service:
    /// <ul>
    ///   <li><c>service.name=frontend</c>, <c>deployment.environment.name=production</c></li>
    ///   <li><c>service.name=frontend</c>, <c>deployment.environment.name=staging</c>.</li>
    /// </ul>
    /// </remarks>
    public const string AttributeDeploymentEnvironmentName = "deployment.environment.name";

    /// <summary>
    /// The id of the deployment.
    /// </summary>
    public const string AttributeDeploymentId = "deployment.id";

    /// <summary>
    /// The name of the deployment.
    /// </summary>
    public const string AttributeDeploymentName = "deployment.name";

    /// <summary>
    /// The status of the deployment.
    /// </summary>
    public const string AttributeDeploymentStatus = "deployment.status";

    /// <summary>
    /// The status of the deployment.
    /// </summary>
    public static class DeploymentStatusValues
    {
        /// <summary>
        /// failed.
        /// </summary>
        public const string Failed = "failed";

        /// <summary>
        /// succeeded.
        /// </summary>
        public const string Succeeded = "succeeded";
    }
}

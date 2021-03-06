//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.IdentityModel.Diagnostics.Application
{
    using System.Runtime;
    using System.Runtime.Diagnostics;
    using System.Security;
    
    
    internal partial class TD
    {
        
        static System.Resources.ResourceManager resourceManager;
        
        static System.Globalization.CultureInfo resourceCulture;
        
        [System.Security.SecurityCriticalAttribute()]
        static System.Runtime.Diagnostics.EventDescriptor[] eventDescriptors;
        
        static object syncLock = new object();
        
        // Double-checked locking pattern requires volatile for read/write synchronization
        static volatile bool eventDescriptorsCreated;
        
        private TD()
        {
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification="This is an auto-generated code, some ETW/TraceSource mixed code would use it.")]
        static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceManager, null))
                {
                    resourceManager = new System.Resources.ResourceManager("System.IdentityModel.Diagnostics.Application.TD", typeof(TD).Assembly);
                }
                return resourceManager;
            }
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification="This template is shared across all assemblies, some of which use this accessor.")]
        internal static System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=5406, Level=Error, Channel=Debug
        /// </summary>
        internal static bool GetIssuerNameFailureIsEnabled()
        {
            return (FxTrace.ShouldTraceError && TD.IsEtwEventEnabled(0));
        }
        
        /// <summary>
        /// Gets trace definition like: Retrieval of issuer name from tokenId:{0} failed.
        /// Event description ID=5406, Level=Error, Channel=Debug
        /// </summary>
        /// <param name="eventTraceActivity">The event trace activity</param>
        /// <param name="tokenID">Parameter 0 for event: Retrieval of issuer name from tokenId:{0} failed.</param>
        internal static void GetIssuerNameFailure(System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string tokenID)
        {
            TracePayload payload = FxTrace.Trace.GetSerializedPayload(null, null, null, true);
            if (TD.IsEtwEventEnabled(0))
            {
                TD.WriteEtwEvent(0, eventTraceActivity, tokenID, payload.HostReference, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=5405, Level=Verbose, Channel=Debug
        /// </summary>
        internal static bool GetIssuerNameSuccessIsEnabled()
        {
            return (FxTrace.ShouldTraceVerbose && TD.IsEtwEventEnabled(1));
        }
        
        /// <summary>
        /// Gets trace definition like: Retrieval of issuer name:{0} from tokenId:{1} succeeded.
        /// Event description ID=5405, Level=Verbose, Channel=Debug
        /// </summary>
        /// <param name="eventTraceActivity">The event trace activity</param>
        /// <param name="issuerName">Parameter 0 for event: Retrieval of issuer name:{0} from tokenId:{1} succeeded.</param>
        /// <param name="tokenID">Parameter 1 for event: Retrieval of issuer name:{0} from tokenId:{1} succeeded.</param>
        internal static void GetIssuerNameSuccess(System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string issuerName, string tokenID)
        {
            TracePayload payload = FxTrace.Trace.GetSerializedPayload(null, null, null, true);
            if (TD.IsEtwEventEnabled(1))
            {
                TD.WriteEtwEvent(1, eventTraceActivity, issuerName, tokenID, payload.HostReference, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=5404, Level=Error, Channel=Debug
        /// </summary>
        internal static bool TokenValidationFailureIsEnabled()
        {
            return (FxTrace.ShouldTraceError && TD.IsEtwEventEnabled(2));
        }
        
        /// <summary>
        /// Gets trace definition like: SecurityToken (type '{0}' and id '{1}') validation failed. {2}
        /// Event description ID=5404, Level=Error, Channel=Debug
        /// </summary>
        /// <param name="eventTraceActivity">The event trace activity</param>
        /// <param name="tokenType">Parameter 0 for event: SecurityToken (type '{0}' and id '{1}') validation failed. {2}</param>
        /// <param name="tokenID">Parameter 1 for event: SecurityToken (type '{0}' and id '{1}') validation failed. {2}</param>
        /// <param name="errorMessage">Parameter 2 for event: SecurityToken (type '{0}' and id '{1}') validation failed. {2}</param>
        internal static void TokenValidationFailure(System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string tokenType, string tokenID, string errorMessage)
        {
            TracePayload payload = FxTrace.Trace.GetSerializedPayload(null, null, null, true);
            if (TD.IsEtwEventEnabled(2))
            {
                TD.WriteEtwEvent(2, eventTraceActivity, tokenType, tokenID, errorMessage, payload.HostReference, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=5402, Level=Verbose, Channel=Debug
        /// </summary>
        internal static bool TokenValidationStartedIsEnabled()
        {
            return (FxTrace.ShouldTraceVerbose && TD.IsEtwEventEnabled(3));
        }
        
        /// <summary>
        /// Gets trace definition like: SecurityToken (type '{0}' and id '{1}') validation started.
        /// Event description ID=5402, Level=Verbose, Channel=Debug
        /// </summary>
        /// <param name="eventTraceActivity">The event trace activity</param>
        /// <param name="tokenType">Parameter 0 for event: SecurityToken (type '{0}' and id '{1}') validation started.</param>
        /// <param name="tokenID">Parameter 1 for event: SecurityToken (type '{0}' and id '{1}') validation started.</param>
        internal static void TokenValidationStarted(System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string tokenType, string tokenID)
        {
            TracePayload payload = FxTrace.Trace.GetSerializedPayload(null, null, null, true);
            if (TD.IsEtwEventEnabled(3))
            {
                TD.WriteEtwEvent(3, eventTraceActivity, tokenType, tokenID, payload.HostReference, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=5403, Level=Verbose, Channel=Debug
        /// </summary>
        internal static bool TokenValidationSuccessIsEnabled()
        {
            return (FxTrace.ShouldTraceVerbose && TD.IsEtwEventEnabled(4));
        }
        
        /// <summary>
        /// Gets trace definition like: SecurityToken (type '{0}' and id '{1}') validation succeeded.
        /// Event description ID=5403, Level=Verbose, Channel=Debug
        /// </summary>
        /// <param name="eventTraceActivity">The event trace activity</param>
        /// <param name="tokenType">Parameter 0 for event: SecurityToken (type '{0}' and id '{1}') validation succeeded.</param>
        /// <param name="tokenID">Parameter 1 for event: SecurityToken (type '{0}' and id '{1}') validation succeeded.</param>
        internal static void TokenValidationSuccess(System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string tokenType, string tokenID)
        {
            TracePayload payload = FxTrace.Trace.GetSerializedPayload(null, null, null, true);
            if (TD.IsEtwEventEnabled(4))
            {
                TD.WriteEtwEvent(4, eventTraceActivity, tokenType, tokenID, payload.HostReference, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Creates the event descriptors array
        /// </summary>
        // Critical = Sets the SecurityCritical member eventDescriptors
        // Safe = We control what the event descriptors contain
        [System.Security.SecuritySafeCriticalAttribute()]
        static void CreateEventDescriptors()
        {
            System.Runtime.Diagnostics.EventDescriptor[] descriptors = new System.Runtime.Diagnostics.EventDescriptor[] {
                    new System.Runtime.Diagnostics.EventDescriptor(5406, 0, (byte)TraceChannel.Debug, (byte)TraceEventLevel.Error, (byte)TraceEventOpcode.Info, 0xa35, 0x1000000000000010),
                    new System.Runtime.Diagnostics.EventDescriptor(5405, 0, (byte)TraceChannel.Debug, (byte)TraceEventLevel.Verbose, (byte)TraceEventOpcode.Info, 0xa35, 0x1000000000000010),
                    new System.Runtime.Diagnostics.EventDescriptor(5404, 0, (byte)TraceChannel.Debug, (byte)TraceEventLevel.Error, (byte)TraceEventOpcode.Info, 0xa34, 0x1000000000000010),
                    new System.Runtime.Diagnostics.EventDescriptor(5402, 0, (byte)TraceChannel.Debug, (byte)TraceEventLevel.Verbose, (byte)TraceEventOpcode.Info, 0xa34, 0x1000000000000010),
                    new System.Runtime.Diagnostics.EventDescriptor(5403, 0, (byte)TraceChannel.Debug, (byte)TraceEventLevel.Verbose, (byte)TraceEventOpcode.Info, 0xa34, 0x1000000000000010)};
            // The hashcodes calculated from PTCop for TD.CreateEventDescriptors are unstable when just declaring
            // a local field of ushort[] if the array is non-empty and contains more than 2 entries, because
            // the c#-compiler is using some private types for optimization. The type name follows the following pattern:
            // <PrivateImplementationDetails>{6BAE93FD-290B-4DE0-BCEE-366B30800FDF} (where the GUID is changing with every build)
            // To scope the change to unblock PTCop as much as possible we wrap the list of End2EndEvents in a List<ushort>
            System.Collections.Generic.List<ushort> e2eEvents = new System.Collections.Generic.List<ushort>(5);
            e2eEvents.Add(5402);
            e2eEvents.Add(5403);
            e2eEvents.Add(5404);
            e2eEvents.Add(5405);
            e2eEvents.Add(5406);
            FxTrace.UpdateEventDefinitions(descriptors, e2eEvents.ToArray());
            eventDescriptors = descriptors;
        }
        
        /// <summary>
        /// Ensures that the event descriptors array is initialized
        /// </summary>
        static void EnsureEventDescriptors()
        {
            if (eventDescriptorsCreated)
            {
                return;
            }
            System.Threading.Monitor.Enter(syncLock);
            try
            {
                if (eventDescriptorsCreated)
                {
                    return;
                }
                CreateEventDescriptors();
                eventDescriptorsCreated = true;
            }
            finally
            {
                System.Threading.Monitor.Exit(syncLock);
            }
        }
        
        /// <summary>
        /// Check if ETW tracing is enabled for the particular event
        /// </summary>
        /// <param name="eventIndex">The index of the event descriptor</param>
        static bool IsEtwEventEnabled(int eventIndex)
        {
            if (FxTrace.Trace.IsEtwProviderEnabled)
            {
                EnsureEventDescriptors();
                return FxTrace.IsEventEnabled(eventIndex);
            }
            return false;
        }
        
        /// <summary>
        /// Writes ETW trace event
        ///</summary>
        /// <param name="eventIndex">The index of the event descriptor</param>>
        /// <param name="eventParam0">A parameter of the ETW event</param>>
        /// <param name="eventParam1">A parameter of the ETW event</param>>
        /// <param name="eventParam2">A parameter of the ETW event</param>>
        /// <param name="eventParam3">A parameter of the ETW event</param>>
        // Critical = Calls SecurityCritical method EtwProvider.WriteEvent
        // Safe = We only allow setting of provider id from SecurityCritical code, access to EventDescriptors is SecurityCritical, and ETW limits buffer sizes.
        [System.Security.SecuritySafeCriticalAttribute()]
        static bool WriteEtwEvent(int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3)
        {
            EnsureEventDescriptors();
            return FxTrace.Trace.EtwProvider.WriteEvent(ref eventDescriptors[eventIndex], eventParam0, eventParam1, eventParam2, eventParam3);
        }
        
        /// <summary>
        /// Writes ETW trace event
        ///</summary>
        /// <param name="eventIndex">The index of the event descriptor</param>>
        /// <param name="eventParam0">A parameter of the ETW event</param>>
        /// <param name="eventParam1">A parameter of the ETW event</param>>
        /// <param name="eventParam2">A parameter of the ETW event</param>>
        /// <param name="eventParam3">A parameter of the ETW event</param>>
        /// <param name="eventParam4">A parameter of the ETW event</param>>
        // Critical = Calls SecurityCritical method EtwProvider.WriteEvent
        // Safe = We only allow setting of provider id from SecurityCritical code, access to EventDescriptors is SecurityCritical, and ETW limits buffer sizes.
        [System.Security.SecuritySafeCriticalAttribute()]
        static bool WriteEtwEvent(int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3, string eventParam4)
        {
            EnsureEventDescriptors();
            return FxTrace.Trace.EtwProvider.WriteEvent(ref eventDescriptors[eventIndex], eventParam0, eventParam1, eventParam2, eventParam3, eventParam4);
        }
        
        /// <summary>
        /// Writes ETW trace event
        ///</summary>
        /// <param name="eventIndex">The index of the event descriptor</param>>
        /// <param name="eventParam0">A parameter of the ETW event</param>>
        /// <param name="eventParam1">A parameter of the ETW event</param>>
        /// <param name="eventParam2">A parameter of the ETW event</param>>
        /// <param name="eventParam3">A parameter of the ETW event</param>>
        /// <param name="eventParam4">A parameter of the ETW event</param>>
        /// <param name="eventParam5">A parameter of the ETW event</param>>
        // Critical = Calls SecurityCritical method EtwProvider.WriteEvent
        // Safe = We only allow setting of provider id from SecurityCritical code, access to EventDescriptors is SecurityCritical, and ETW limits buffer sizes.
        [System.Security.SecuritySafeCriticalAttribute()]
        static bool WriteEtwEvent(int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3, string eventParam4, string eventParam5)
        {
            EnsureEventDescriptors();
            return FxTrace.Trace.EtwProvider.WriteEvent(ref eventDescriptors[eventIndex], eventParam0, eventParam1, eventParam2, eventParam3, eventParam4, eventParam5);
        }
    }
}


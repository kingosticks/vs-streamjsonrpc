﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StreamJsonRpc; 
using System;


/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
// This class was auto-generated by the StronglyTypedResourceBuilder
// class via a tool like ResGen or Visual Studio.
// To add or remove a member, edit your .ResX file then rerun ResGen
// with the /str option, or rebuild your VS project.
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
internal class Resources {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal Resources() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StreamJsonRpc.Resources", typeof(Resources).Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    }
    
    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Globalization.CultureInfo Culture {
        get {
            return resourceCulture;
        }
        set {
            resourceCulture = value;
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Both readable and writable are null..
    /// </summary>
    internal static string BothReadableWritableAreNull {
        get {
            return ResourceManager.GetString("BothReadableWritableAreNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A CancellationToken is only allowed as the last parameter..
    /// </summary>
    internal static string CancellationTokenMustBeLastParameter {
        get {
            return ResourceManager.GetString("CancellationTokenMustBeLastParameter", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This cannot be done after GetAsyncEnumerator has already been called..
    /// </summary>
    internal static string CannotBeCalledAfterGetAsyncEnumerator {
        get {
            return ResourceManager.GetString("CannotBeCalledAfterGetAsyncEnumerator", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to &quot;{0}&quot; is not an interface..
    /// </summary>
    internal static string ClientProxyTypeArgumentMustBeAnInterface {
        get {
            return ResourceManager.GetString("ClientProxyTypeArgumentMustBeAnInterface", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to .NET methods &apos;{0}&apos; and &apos;{1}&apos; cannot both map to the same request method name: &apos;{2}&apos;..
    /// </summary>
    internal static string ConflictingMethodAttributeValue {
        get {
            return ResourceManager.GetString("ConflictingMethodAttributeValue", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to All overloads and overrides of the &apos;{0}&apos; method must share a common value for {1}.{2}..
    /// </summary>
    internal static string ConflictingMethodNameAttribute {
        get {
            return ResourceManager.GetString("ConflictingMethodNameAttribute", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A method with the same name and equivalent parameters has already been registered..
    /// </summary>
    internal static string ConflictMethodSignatureAlreadyRegistered {
        get {
            return ResourceManager.GetString("ConflictMethodSignatureAlreadyRegistered", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The JSON-RPC connection with the remote party was lost before the request could complete..
    /// </summary>
    internal static string ConnectionDropped {
        get {
            return ResourceManager.GetString("ConnectionDropped", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Got a request to execute &apos;{0}&apos; but have no callback object. Dropping the request..
    /// </summary>
    internal static string DroppingRequestDueToNoTargetObject {
        get {
            return ResourceManager.GetString("DroppingRequestDueToNoTargetObject", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This enumeration has already prefetched elements once..
    /// </summary>
    internal static string ElementsAlreadyPrefetched {
        get {
            return ResourceManager.GetString("ElementsAlreadyPrefetched", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The value {0} is not among the recognized or supported members of the enum type..
    /// </summary>
    internal static string EnumValueNotRecognized {
        get {
            return ResourceManager.GetString("EnumValueNotRecognized", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Error writing JSON RPC Message: {0}: {1}.
    /// </summary>
    internal static string ErrorWritingJsonRpcMessage {
        get {
            return ResourceManager.GetString("ErrorWritingJsonRpcMessage", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Error writing JSON RPC Result: {0}: {1}.
    /// </summary>
    internal static string ErrorWritingJsonRpcResult {
        get {
            return ResourceManager.GetString("ErrorWritingJsonRpcResult", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Failure deserializing incoming JSON RPC &apos;{0}&apos;: {1}.
    /// </summary>
    internal static string FailureDeserializingJsonRpc {
        get {
            return ResourceManager.GetString("FailureDeserializingJsonRpc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Deserializing JSON-RPC argument with name &quot;{0}&quot; and position {1} to type &quot;{2}&quot; failed: {3}.
    /// </summary>
    internal static string FailureDeserializingRpcArgument {
        get {
            return ResourceManager.GetString("FailureDeserializingRpcArgument", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Deserializing JSON-RPC result to type {0} failed with {1}: {2}.
    /// </summary>
    internal static string FailureDeserializingRpcResult {
        get {
            return ResourceManager.GetString("FailureDeserializingRpcResult", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A fatal exception was thrown from the server method {0}: {1}.
    /// </summary>
    internal static string FatalExceptionWasThrown {
        get {
            return ResourceManager.GetString("FatalExceptionWasThrown", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The buffer is empty. Call the async method to fill it first..
    /// </summary>
    internal static string FillBufferFirst {
        get {
            return ResourceManager.GetString("FillBufferFirst", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unable to cast given Type to IProgress&lt;T&gt;.
    /// </summary>
    internal static string FindIProgressOfTError {
        get {
            return ResourceManager.GetString("FindIProgressOfTError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The configuration is locked because this formatter has already been associated with a JsonRpc instance..
    /// </summary>
    internal static string FormatterConfigurationLockedAfterJsonRpcAssigned {
        get {
            return ResourceManager.GetString("FormatterConfigurationLockedAfterJsonRpcAssigned", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Failed parsing Content-Length header into a positive integer..
    /// </summary>
    internal static string HeaderContentLengthNotParseable {
        get {
            return ResourceManager.GetString("HeaderContentLengthNotParseable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The size of the message header exceeds the maximum supported size..
    /// </summary>
    internal static string HeaderValueTooLarge {
        get {
            return ResourceManager.GetString("HeaderValueTooLarge", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This operation is only appropriate for inbound messages..
    /// </summary>
    internal static string InboundMessageOnly {
        get {
            return ResourceManager.GetString("InboundMessageOnly", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This operation is not allowed after listening for messages has started..
    /// </summary>
    internal static string InvalidAfterListenHasStarted {
        get {
            return ResourceManager.GetString("InvalidAfterListenHasStarted", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This operation is not allowed before listening for messages has started..
    /// </summary>
    internal static string InvalidBeforeListenHasStarted {
        get {
            return ResourceManager.GetString("InvalidBeforeListenHasStarted", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to JSON RPC must not be null..
    /// </summary>
    internal static string JsonRpcCannotBeNull {
        get {
            return ResourceManager.GetString("JsonRpcCannotBeNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Conflicting JsonRpcMethodAttribute and JsonRpcIgnoreAttribute found on the same method: {0}..
    /// </summary>
    internal static string JsonRpcMethodAndIgnoreAttributesFound {
        get {
            return ResourceManager.GetString("JsonRpcMethodAndIgnoreAttributesFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Interfaces with events cannot be marshaled..
    /// </summary>
    internal static string MarshalableInterfaceHasEvents {
        get {
            return ResourceManager.GetString("MarshalableInterfaceHasEvents", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Interfaces with properties cannot be marshaled..
    /// </summary>
    internal static string MarshalableInterfaceHasProperties {
        get {
            return ResourceManager.GetString("MarshalableInterfaceHasProperties", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Marshaled interfaces must extend IDisposable..
    /// </summary>
    internal static string MarshalableInterfaceNotDisposable {
        get {
            return ResourceManager.GetString("MarshalableInterfaceNotDisposable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This tracked object cannot be included in a notification. Only messages including an &quot;id&quot; property are supported..
    /// </summary>
    internal static string MarshaledObjectInNotificationError {
        get {
            return ResourceManager.GetString("MarshaledObjectInNotificationError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This tracked object should not be part of any response or notification..
    /// </summary>
    internal static string MarshaledObjectInResponseOrNotificationError {
        get {
            return ResourceManager.GetString("MarshaledObjectInResponseOrNotificationError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} has ref or out parameter(s), which is not supported.
    /// </summary>
    internal static string MethodHasRefOrOutParameters {
        get {
            return ResourceManager.GetString("MethodHasRefOrOutParameters", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} parameter(s) (excluding any CancellationToken): {1}, but the request supplies {2}.
    /// </summary>
    internal static string MethodParameterCountDoesNotMatch {
        get {
            return ResourceManager.GetString("MethodParameterCountDoesNotMatch", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} parameters are not compatible with the arguments provided in the request..
    /// </summary>
    internal static string MethodParametersNotCompatible {
        get {
            return ResourceManager.GetString("MethodParametersNotCompatible", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Listening must be started first..
    /// </summary>
    internal static string MustBeListening {
        get {
            return ResourceManager.GetString("MustBeListening", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This cannot be done after listening has started..
    /// </summary>
    internal static string MustNotBeListening {
        get {
            return ResourceManager.GetString("MustNotBeListening", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A non-negative integer is required..
    /// </summary>
    internal static string NonNegativeIntegerRequired {
        get {
            return ResourceManager.GetString("NonNegativeIntegerRequired", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Out of band streams/pipes are not supported in this configuration. Have you set a MultiplexingStream on the formatter?.
    /// </summary>
    internal static string NotSupportedWithoutMultiplexingStream {
        get {
            return ResourceManager.GetString("NotSupportedWithoutMultiplexingStream", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This operation is only appropriate for outbound messages..
    /// </summary>
    internal static string OutboundMessageOnly {
        get {
            return ResourceManager.GetString("OutboundMessageOnly", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Parameter is not in the form of a single object.
    /// </summary>
    internal static string ParameterNotObject {
        get {
            return ResourceManager.GetString("ParameterNotObject", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to JSON-RPC 1.0 does not support named arguments (parameters passed within an object). Use positional arguments (parameter arrays) or set protocol version to 2.0..
    /// </summary>
    internal static string ParameterObjectsNotSupportedInJsonRpc10 {
        get {
            return ResourceManager.GetString("ParameterObjectsNotSupportedInJsonRpc10", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A positive integer is required..
    /// </summary>
    internal static string PositiveIntegerRequired {
        get {
            return ResourceManager.GetString("PositiveIntegerRequired", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Reached end of stream..
    /// </summary>
    internal static string ReachedEndOfStream {
        get {
            return ResourceManager.GetString("ReachedEndOfStream", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Reading JSON RPC from the stream failed with {0}: {1}.
    /// </summary>
    internal static string ReadingJsonRpcStreamFailed {
        get {
            return ResourceManager.GetString("ReadingJsonRpcStreamFailed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Relay connection has already been established..
    /// </summary>
    internal static string RelayAlreadySet {
        get {
            return ResourceManager.GetString("RelayAlreadySet", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to An argument was not supplied for a required parameter..
    /// </summary>
    internal static string RequiredArgumentMissing {
        get {
            return ResourceManager.GetString("RequiredArgumentMissing", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This property name is reserved by the JSON-RPC spec or this library..
    /// </summary>
    internal static string ReservedPropertyName {
        get {
            return ResourceManager.GetString("ReservedPropertyName", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Response is not error..
    /// </summary>
    internal static string ResponseIsNotError {
        get {
            return ResourceManager.GetString("ResponseIsNotError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Failed to serialize the response..
    /// </summary>
    internal static string ResponseSerializationFailure {
        get {
            return ResourceManager.GetString("ResponseSerializationFailure", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Response is in an unexpected format.  Only error and result are supported: {0}.
    /// </summary>
    internal static string ResponseUnexpectedFormat {
        get {
            return ResourceManager.GetString("ResponseUnexpectedFormat", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to No method by the name &apos;{0}&apos; is found..
    /// </summary>
    internal static string RpcMethodNameNotFound {
        get {
            return ResourceManager.GetString("RpcMethodNameNotFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Stream has been disposed.
    /// </summary>
    internal static string StreamDisposed {
        get {
            return ResourceManager.GetString("StreamDisposed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The stream must be readable..
    /// </summary>
    internal static string StreamMustBeReadable {
        get {
            return ResourceManager.GetString("StreamMustBeReadable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The stream must be writeable..
    /// </summary>
    internal static string StreamMustBeWriteable {
        get {
            return ResourceManager.GetString("StreamMustBeWriteable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The {0} and {1} parameters exceed length of array..
    /// </summary>
    internal static string SumOfTwoParametersExceedsArrayLength {
        get {
            return ResourceManager.GetString("SumOfTwoParametersExceedsArrayLength", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A target object should be supplied if and only if the method is not static..
    /// </summary>
    internal static string TargetObjectAndMethodStaticFlagMismatch {
        get {
            return ResourceManager.GetString("TargetObjectAndMethodStaticFlagMismatch", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The task is not completed..
    /// </summary>
    internal static string TaskNotCompleted {
        get {
            return ResourceManager.GetString("TaskNotCompleted", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The task was cancelled..
    /// </summary>
    internal static string TaskWasCancelled {
        get {
            return ResourceManager.GetString("TaskWasCancelled", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Text encoding is not supported because the formatter &quot;{0}&quot; does not implement &quot;{1}&quot;..
    /// </summary>
    internal static string TextEncoderNotApplicable {
        get {
            return ResourceManager.GetString("TextEncoderNotApplicable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The length of this list must equal the length of the arguments list..
    /// </summary>
    internal static string TypedArgumentsLengthMismatch {
        get {
            return ResourceManager.GetString("TypedArgumentsLengthMismatch", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unable to find method &apos;{0}/{1}&apos; on {2} for the following reasons: {3}.
    /// </summary>
    internal static string UnableToFindMethod {
        get {
            return ResourceManager.GetString("UnableToFindMethod", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unexpected error processing JSON-RPC message: {0}.
    /// </summary>
    internal static string UnexpectedErrorProcessingJsonRpc {
        get {
            return ResourceManager.GetString("UnexpectedErrorProcessingJsonRpc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A response was received without a request having been sent..
    /// </summary>
    internal static string UnexpectedResponseWithNoMatchingRequest {
        get {
            return ResourceManager.GetString("UnexpectedResponseWithNoMatchingRequest", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unexpected token &apos;{0}&apos; while parsing header..
    /// </summary>
    internal static string UnexpectedTokenReadingHeader {
        get {
            return ResourceManager.GetString("UnexpectedTokenReadingHeader", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This remote object no longer exists..
    /// </summary>
    internal static string UnknownTokenToMarshaledObject {
        get {
            return ResourceManager.GetString("UnknownTokenToMarshaledObject", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unable to recognize incoming message as one the JSON-RPC 2.0 defined message types..
    /// </summary>
    internal static string UnrecognizableMessage {
        get {
            return ResourceManager.GetString("UnrecognizableMessage", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Incoming JSON-RPC message did not conform to a recognized pattern..
    /// </summary>
    internal static string UnrecognizedIncomingJsonRpc {
        get {
            return ResourceManager.GetString("UnrecognizedIncomingJsonRpc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unsupported event handler type on &quot;{0}&quot;. Only EventHandler and EventHandler&lt;T&gt; are supported..
    /// </summary>
    internal static string UnsupportedEventHandlerTypeOnClientProxyInterface {
        get {
            return ResourceManager.GetString("UnsupportedEventHandlerTypeOnClientProxyInterface", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Generic methods are not supported..
    /// </summary>
    internal static string UnsupportedGenericMethodsOnClientProxyInterface {
        get {
            return ResourceManager.GetString("UnsupportedGenericMethodsOnClientProxyInterface", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unsupported JSON-RPC protocol version {0}. The supported protocol versions are: {1}.
    /// </summary>
    internal static string UnsupportedJsonRpcProtocolVersion {
        get {
            return ResourceManager.GetString("UnsupportedJsonRpcProtocolVersion", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Method &quot;{0}&quot; has unsupported return type &quot;{1}&quot;. Only Task-returning methods are supported..
    /// </summary>
    internal static string UnsupportedMethodReturnTypeOnClientProxyInterface {
        get {
            return ResourceManager.GetString("UnsupportedMethodReturnTypeOnClientProxyInterface", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Properties are not supported for service interfaces..
    /// </summary>
    internal static string UnsupportedPropertiesOnClientProxyInterface {
        get {
            return ResourceManager.GetString("UnsupportedPropertiesOnClientProxyInterface", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This operation can only be performed once on this object..
    /// </summary>
    internal static string UsableOnceOnly {
        get {
            return ResourceManager.GetString("UsableOnceOnly", resourceCulture);
        }
    }
}

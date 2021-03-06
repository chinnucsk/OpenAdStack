﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OAuthSecurity.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OAuthSecurity.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier.
        /// </summary>
        internal static string AcsNameClaimType {
            get {
                return ResourceManager.GetString("AcsNameClaimType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary.
        /// </summary>
        internal static string BinarySecurityTokenEncodingType {
            get {
                return ResourceManager.GetString("BinarySecurityTokenEncodingType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd.
        /// </summary>
        internal static string BinarySecurityTokenNs {
            get {
                return ResourceManager.GetString("BinarySecurityTokenNs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://schemas.xmlsoap.org/ws/2009/11/swt-token-profile-1.0.
        /// </summary>
        internal static string BinarySecurityTokenValueType {
            get {
                return ResourceManager.GetString("BinarySecurityTokenValueType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot read token. If you are using SWT, make sure to configure SimpleWebTokenHandler. Token: {0}.
        /// </summary>
        internal static string CannotReadToken {
            get {
                return ResourceManager.GetString("CannotReadToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Claim value cannot be empty.
        /// </summary>
        internal static string ClaimValueEmpty {
            get {
                return ResourceManager.GetString("ClaimValueEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.
        /// </summary>
        internal static string DefaultNameClaimType {
            get {
                return ResourceManager.GetString("DefaultNameClaimType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Audience Uri of the incoming token is not expected. Expected AudienceUri is.
        /// </summary>
        internal static string ExpectedAudienceUri {
            get {
                return ResourceManager.GetString("ExpectedAudienceUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Handler cannot read this token..
        /// </summary>
        internal static string HandlerCannotReadToken {
            get {
                return ResourceManager.GetString("HandlerCannotReadToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Issuer of the token is not trusted. Trusted issuer is.
        /// </summary>
        internal static string IssuerNotTrusted {
            get {
                return ResourceManager.GetString("IssuerNotTrusted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &lt;add&gt; element is malformed. The right format is: &lt;add issuerIdentifier=\&quot;issuer identifier\&quot; name=\&quot;issuer friendly name\&quot;.
        /// </summary>
        internal static string MalformedElement {
            get {
                return ResourceManager.GetString("MalformedElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &lt;remove&gt; node should have a issuerIdentifier attribute.
        /// </summary>
        internal static string MissingIssuerIdentifier {
            get {
                return ResourceManager.GetString("MissingIssuerIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &lt;remove&gt; node should have a serviceName attribute.
        /// </summary>
        internal static string MissingServiceNameAttribute {
            get {
                return ResourceManager.GetString("MissingServiceNameAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No OAuth token was available to the service for authentication..
        /// </summary>
        internal static string NoOAuthToken {
            get {
                return ResourceManager.GetString("NoOAuthToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not implemented.
        /// </summary>
        internal static string NotImplemented {
            get {
                return ResourceManager.GetString("NotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There should be only one xml element as the configuration of this class.
        /// </summary>
        internal static string OnlyOneXmlElement {
            get {
                return ResourceManager.GetString("OnlyOneXmlElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to rawToken is null or empty.
        /// </summary>
        internal static string RawTokenNullOrEmpty {
            get {
                return ResourceManager.GetString("RawTokenNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature verification of the incoming token failed..
        /// </summary>
        internal static string SignatureVerificationFailed {
            get {
                return ResourceManager.GetString("SignatureVerificationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The received token is not correctly formed.
        /// </summary>
        internal static string SwtIncorrectlyFormed {
            get {
                return ResourceManager.GetString("SwtIncorrectlyFormed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Simple Web Token must have a signature at the end. The incoming token did not have a signature at the end of the token..
        /// </summary>
        internal static string SwtMustHaveSignature {
            get {
                return ResourceManager.GetString("SwtMustHaveSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Then incoming token does not have an AudienceUri..
        /// </summary>
        internal static string SwtNoAudienceUri {
            get {
                return ResourceManager.GetString("SwtNoAudienceUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Then incoming token does not have an expiry time..
        /// </summary>
        internal static string SwtNoExpiryTime {
            get {
                return ResourceManager.GetString("SwtNoExpiryTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Then incoming token does not have an Issuer.
        /// </summary>
        internal static string SwtNoIssuer {
            get {
                return ResourceManager.GetString("SwtNoIssuer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Then incoming token does not have a signature.
        /// </summary>
        internal static string SwtNoSignature {
            get {
                return ResourceManager.GetString("SwtNoSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The incoming token has an unexpected expiration time format.
        /// </summary>
        internal static string SwtUnexpectedTimeFormat {
            get {
                return ResourceManager.GetString("SwtUnexpectedTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The received token is of incorrect token type.  Expected SimpleWebToken.
        /// </summary>
        internal static string SwtWrongType {
            get {
                return ResourceManager.GetString("SwtWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The incoming token has expired. Get a new access token from the Authorization Server..
        /// </summary>
        internal static string TokenExpired {
            get {
                return ResourceManager.GetString("TokenExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://schemas.microsoft.com/ws/2010/07/identitymodel/tokens/SWT.
        /// </summary>
        internal static string TokenTypeIdentifier {
            get {
                return ResourceManager.GetString("TokenTypeIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The top element of the configuration should be named &apos;trustedIssuers&apos;.
        /// </summary>
        internal static string TopElement {
            get {
                return ResourceManager.GetString("TopElement", resourceCulture);
            }
        }
    }
}

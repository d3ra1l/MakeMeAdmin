﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SinclairCC.MakeMeAdmin.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SinclairCC.MakeMeAdmin.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ready..
        /// </summary>
        public static string ApplicationIsReady {
            get {
                return ResourceManager.GetString("ApplicationIsReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make Me Admin.
        /// </summary>
        public static string ApplicationName {
            get {
                return ResourceManager.GetString("ApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking administrator status....
        /// </summary>
        public static string CheckingAdminStatus {
            get {
                return ResourceManager.GetString("CheckingAdminStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Message.
        /// </summary>
        public static string ErrorMessage {
            get {
                return ResourceManager.GetString("ErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Grant Me Administrator Rights.
        /// </summary>
        public static string GrantRightsButtonText {
            get {
                return ResourceManager.GetString("GrantRightsButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to provide you with administrator rights.
        ///A reason is required in order to obtain administrator rights, but you did not provide one..
        /// </summary>
        public static string MandatoryReasonNotProvided {
            get {
                return ResourceManager.GetString("MandatoryReasonNotProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Other.
        /// </summary>
        public static string OtherReason {
            get {
                return ResourceManager.GetString("OtherReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to provide you with administrator rights.
        ///A reason is required in order to obtain administrator rights, but your administrator has not allowed you to provide a reason..
        /// </summary>
        public static string ReasonDialogBoxPrevented {
            get {
                return ResourceManager.GetString("ReasonDialogBoxPrevented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User could not be prompted for a reason. No methods for doing so are enabled..
        /// </summary>
        public static string ReasonDialogEmpty {
            get {
                return ResourceManager.GetString("ReasonDialogEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user provided the following reason for administrator rights: {0}.
        /// </summary>
        public static string ReasonProvidedByUser {
            get {
                return ResourceManager.GetString("ReasonProvidedByUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon SecurityLock {
            get {
                object obj = ResourceManager.GetObject("SecurityLock", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stack Trace.
        /// </summary>
        public static string StackTrace {
            get {
                return ResourceManager.GetString("StackTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are now a member of the {0} group..
        /// </summary>
        public static string UIMessageAddedToGroup {
            get {
                return ResourceManager.GetString("UIMessageAddedToGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adding you to the {0} group..
        /// </summary>
        public static string UIMessageAddingToGroup {
            get {
                return ResourceManager.GetString("UIMessageAddingToGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You already have administrator rights..
        /// </summary>
        public static string UIMessageAlreadyHaveRights {
            get {
                return ResourceManager.GetString("UIMessageAlreadyHaveRights", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please make sure the Make Me Admin service is running..
        /// </summary>
        public static string UIMessageEnsureServiceRunning {
            get {
                return ResourceManager.GetString("UIMessageEnsureServiceRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while adding you to the Administrators group..
        /// </summary>
        public static string UIMessageErrorWhileAdding {
            get {
                return ResourceManager.GetString("UIMessageErrorWhileAdding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while removing you from the Administrators group..
        /// </summary>
        public static string UIMessageErrorWhileRemoving {
            get {
                return ResourceManager.GetString("UIMessageErrorWhileRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are no longer a member of the {0} group..
        /// </summary>
        public static string UIMessageRemovedFromGroup {
            get {
                return ResourceManager.GetString("UIMessageRemovedFromGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing you from the {0} group..
        /// </summary>
        public static string UIMessageRemovingFromGroup {
            get {
                return ResourceManager.GetString("UIMessageRemovingFromGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not authorized to use this application..
        /// </summary>
        public static string UIMessageUnauthorized {
            get {
                return ResourceManager.GetString("UIMessageUnauthorized", resourceCulture);
            }
        }
    }
}

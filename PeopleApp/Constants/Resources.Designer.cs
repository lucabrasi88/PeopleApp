﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeopleApp.Constants {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PeopleApp.Constants.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Day of birth cannot be empty.
        /// </summary>
        internal static string DayOfBirthValidationText {
            get {
                return ResourceManager.GetString("DayOfBirthValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First name cannot be empty and should consists only of characters.
        /// </summary>
        internal static string FirstNameValidationText {
            get {
                return ResourceManager.GetString("FirstNameValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to House number cannot be empty.
        /// </summary>
        internal static string HouseNumberValidationText {
            get {
                return ResourceManager.GetString("HouseNumberValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last name cannot be empty and should consists only of characters.
        /// </summary>
        internal static string LastNameValidationText {
            get {
                return ResourceManager.GetString("LastNameValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Phone number cannot be empty and should consists of numbers.
        /// </summary>
        internal static string PhoneNumberValidationText {
            get {
                return ResourceManager.GetString("PhoneNumberValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Postal code cannot be empty.
        /// </summary>
        internal static string PostalCodeValidationText {
            get {
                return ResourceManager.GetString("PostalCodeValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Street name cannot be empty.
        /// </summary>
        internal static string StreetNameValidationText {
            get {
                return ResourceManager.GetString("StreetNameValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string UserProfilePath {
            get {
                return ResourceManager.GetString("UserProfilePath", resourceCulture);
            }
        }
    }
}

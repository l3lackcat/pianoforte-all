﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PianoForte.Resourses.DatabaseStructure.MySqlTable {
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
    internal class Payments {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Payments() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PianoForte.Resourses.DatabaseStructure.MySqlTable.Payments", typeof(Payments).Assembly);
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
        ///   Looks up a localized string similar to payment_date.
        /// </summary>
        internal static string ColumnPaymentDate {
            get {
                return ResourceManager.GetString("ColumnPaymentDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to payment_id.
        /// </summary>
        internal static string ColumnPaymentId {
            get {
                return ResourceManager.GetString("ColumnPaymentId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to payment_status.
        /// </summary>
        internal static string ColumnPaymentStatus {
            get {
                return ResourceManager.GetString("ColumnPaymentStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to receiver_id.
        /// </summary>
        internal static string ColumnReceiverId {
            get {
                return ResourceManager.GetString("ColumnReceiverId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to student_id.
        /// </summary>
        internal static string ColumnStudentId {
            get {
                return ResourceManager.GetString("ColumnStudentId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to payments.
        /// </summary>
        internal static string TableName {
            get {
                return ResourceManager.GetString("TableName", resourceCulture);
            }
        }
    }
}
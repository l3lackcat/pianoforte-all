﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
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
    internal class Branches {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Branches() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PianoForte.Resourses.DatabaseStructure.MySqlTable.Branches", typeof(Branches).Assembly);
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
        ///   Looks up a localized string similar to branch_database.
        /// </summary>
        internal static string ColumnBranchDatabase {
            get {
                return ResourceManager.GetString("ColumnBranchDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to branch_id.
        /// </summary>
        internal static string ColumnBranchId {
            get {
                return ResourceManager.GetString("ColumnBranchId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to branch_name.
        /// </summary>
        internal static string ColumnBranchName {
            get {
                return ResourceManager.GetString("ColumnBranchName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to branch_status.
        /// </summary>
        internal static string ColumnBranchStatus {
            get {
                return ResourceManager.GetString("ColumnBranchStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to branches.
        /// </summary>
        internal static string TableName {
            get {
                return ResourceManager.GetString("TableName", resourceCulture);
            }
        }
    }
}
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
    internal class Classrooms {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Classrooms() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PianoForte.Resourses.DatabaseStructure.MySqlTable.Classrooms", typeof(Classrooms).Assembly);
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
        ///   Looks up a localized string similar to classroom_end.
        /// </summary>
        internal static string ColumnClassroomEnd {
            get {
                return ResourceManager.GetString("ColumnClassroomEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to classroom_id.
        /// </summary>
        internal static string ColumnClassroomId {
            get {
                return ResourceManager.GetString("ColumnClassroomId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to classroom_start.
        /// </summary>
        internal static string ColumnClassroomStart {
            get {
                return ResourceManager.GetString("ColumnClassroomStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to classroom_status.
        /// </summary>
        internal static string ColumnClassroomStatus {
            get {
                return ResourceManager.GetString("ColumnClassroomStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to enrollment_id.
        /// </summary>
        internal static string ColumnEnrollmentId {
            get {
                return ResourceManager.GetString("ColumnEnrollmentId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to teacher_id.
        /// </summary>
        internal static string ColumnTeacherId {
            get {
                return ResourceManager.GetString("ColumnTeacherId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to classrooms.
        /// </summary>
        internal static string TableName {
            get {
                return ResourceManager.GetString("TableName", resourceCulture);
            }
        }
    }
}
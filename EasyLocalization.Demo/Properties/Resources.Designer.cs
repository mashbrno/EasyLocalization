﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyLocalization.Demo.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EasyLocalization.Demo.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Key1;Random sentence 1
        ///Key1_1;Random sentence 2
        ///Key22;There is one item in the list;There is no items in the list;There are {0} items in the list
        ///Button1_Content;Change Language!
        ///LblTitle_Text;Welcome to EasyLocalization.
        /// </summary>
        internal static string CharSeperatedFile {
            get {
                return ResourceManager.GetString("CharSeperatedFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] JsonFile {
            get {
                object obj = ResourceManager.GetObject("JsonFile", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;Entries&gt;
        ///	&lt;Entry key=&quot;Key1&quot;&gt;
        ///		&lt;Value&gt;Random sentence 1&lt;/Value&gt;
        ///	&lt;/Entry&gt;
        ///	&lt;Entry key=&quot;Key1_1&quot;&gt;
        ///		&lt;Value&gt;Random sentence 2&lt;/Value&gt;
        ///	&lt;/Entry&gt;
        ///	&lt;Entry key=&quot;Key22&quot;&gt;
        ///		&lt;Value&gt;There is one item in the list&lt;/Value&gt;
        ///		&lt;ZeroValue&gt;There is no items in the list&lt;/ZeroValue&gt;
        ///		&lt;PluralValue&gt;There are {0} items in the list&lt;/PluralValue&gt;
        ///	&lt;/Entry&gt;
        ///	&lt;Entry key=&quot;Button1_Content&quot;&gt;
        ///		&lt;Value&gt;Change Language!&lt;/Value&gt;
        ///	&lt;/Entry&gt;
        ///	&lt;Entry key=&quot;LblTitle_Text&quot;&gt;
        ///		&lt;Value&gt;Welcome [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XmlFile {
            get {
                return ResourceManager.GetString("XmlFile", resourceCulture);
            }
        }
    }
}

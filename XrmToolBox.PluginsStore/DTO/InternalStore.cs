﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace XrmToolBox.PluginsStore.DTO
{
    [DataContract]
    public class InternalStore
    {
        [DataMember(Name = "nuget_feed")]
        public string NuGetFeed { get; set; }

        [DataMember(Name = "nuget_authentication")]
        public string NuGetAuthentication { get; set; }

        [DataMember(Name = "nuget_secretid")]
        public string NuGetSecretId { get; set; }

        [DataMember(Name = "plugins")]
        public List<XtbPlugin> Plugins { get; set; } = new List<XtbPlugin>();
    }

    [DataContract]
    public class InternalStores
    {
        [DataMember(Name = "internal_stores")]
        public List<InternalStore> Stores { get; set; } = new List<InternalStore>();
    }
}

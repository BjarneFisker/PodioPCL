﻿using Newtonsoft.Json;
using PodioAPI.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PodioAPI.Models.Request
{
    public class ApplicationCreateUpdateRequest
    {
        [JsonProperty("space_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpaceId { get; set; }

        [JsonProperty(PropertyName = "config", NullValueHandling = NullValueHandling.Ignore)]
        public ApplicationConfiguration Config { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplicationField> Fields { get; set; }
    }
}
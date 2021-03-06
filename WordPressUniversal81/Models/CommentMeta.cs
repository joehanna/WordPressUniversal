﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressUniversal.Models
{

    /// <summary>
    /// base model for comment meta
    /// </summary>
    public class CommentyMeta
    {
        /// <summary>
        /// gets the meta object links
        /// </summary>
        [JsonProperty("links")]
        public CommentMetaLinks links { get; set; }
    }
}

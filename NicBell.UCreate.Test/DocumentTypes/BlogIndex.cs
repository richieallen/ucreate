﻿using NicBell.UCreate.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace NicBell.UCreate.Test.DocumentTypes
{
    [DocType(Name = "Blog Index",
        Icon = "icon-black icon-bulleted-list",
        AllowedTemplates = new[] { "BlogIndex" },
        AllowedTypes = new[] { "BlogItem" })]
    public class BlogIndex : Base
    {
        public BlogIndex(IPublishedContent content)
            : base(content)
        { }
    }
}
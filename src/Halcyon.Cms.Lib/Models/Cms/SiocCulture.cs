﻿// Licensed to the Halcyon Core Foundation under one or more agreements.
// The Halcyon Core Foundation licenses this file to you under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Halcyon.Cms.Lib.Models.Cms
{
    public partial class SiocCulture
    {
        public SiocCulture()
        {
            SiocArticle = new HashSet<SiocArticle>();
            SiocCategory = new HashSet<SiocCategory>();
            SiocConfiguration = new HashSet<SiocConfiguration>();
            SiocLanguage = new HashSet<SiocLanguage>();
            SiocModule = new HashSet<SiocModule>();
            SiocProduct = new HashSet<SiocProduct>();
        }

        public int Id { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
        public string Icon { get; set; }
        public string Lcid { get; set; }
        public string Specificulture { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }

        public ICollection<SiocArticle> SiocArticle { get; set; }
        public ICollection<SiocCategory> SiocCategory { get; set; }
        public ICollection<SiocConfiguration> SiocConfiguration { get; set; }
        public ICollection<SiocLanguage> SiocLanguage { get; set; }
        public ICollection<SiocModule> SiocModule { get; set; }
        public ICollection<SiocProduct> SiocProduct { get; set; }
    }
}

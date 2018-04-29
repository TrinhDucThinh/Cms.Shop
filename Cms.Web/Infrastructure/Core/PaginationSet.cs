﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cms.Web.Infrastructure.Core
{
    public class PaginationSet<T>
    {
        public int Page { get; set; }

        public int Count
        {
            get { return (Items != null) ? Items.Count() : 0; }
        }

        public int PagesCount { set; get; }

        public int TotalCount { get; set; }

        public IEnumerable<T> Items { set; get; }
    }
}
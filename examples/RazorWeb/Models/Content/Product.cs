/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */

using Piranha.Extend;
using Piranha.Models;

namespace RazorWeb.Models
{
    [ContentGroup(Title = "Products", Icon = "fas fa-hammer")]
    public abstract class Product<T> : Content<T>, ICategorizedContent
        where T : Product<T>
    {
        /// <summary>
        /// Gets/sets the product category.
        /// </summary>
        public Taxonomy Category { get; set; }
    }
}
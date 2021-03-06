#region CodeMaid is Copyright 2007-2015 Steve Cadwallader.

// CodeMaid is free software: you can redistribute it and/or modify it under the terms of the GNU
// Lesser General Public License version 3 as published by the Free Software Foundation.
//
// CodeMaid is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// Lesser General Public License for more details <http://www.gnu.org/licenses/>.

#endregion CodeMaid is Copyright 2007-2015 Steve Cadwallader.

using SteveCadwallader.CodeMaid.Model.CodeItems;
using System;
using System.Collections.Generic;

namespace SteveCadwallader.CodeMaid.Logic.Reorganizing
{
    /// <summary>
    /// An implementation of <see cref="IEqualityComparer{T}"/> for handling region comparison by name.
    /// </summary>
    public class RegionComparerByName : IEqualityComparer<CodeItemRegion>
    {
        /// <summary>
        /// Determines whether the specified objects are equal.
        /// </summary>
        /// <param name="x">The first object of type <see cref="CodeItemRegion" /> to compare.</param>
        /// <param name="y">The second object of type <see cref="CodeItemRegion" /> to compare.</param>
        /// <returns>True if the specified objects are equal; otherwise, false.</returns>
        public bool Equals(CodeItemRegion x, CodeItemRegion y)
        {
            if (x == null && y == null) return true;
            if (x == null || y == null) return false;

            if (x.Name == null && y.Name == null) return true;
            if (x.Name == null || y.Name == null) return false;

            return x.Name.Equals(y.Name);
        }

        /// <summary>
        /// Returns a hash code for the specified object.
        /// </summary>
        /// <param name="region">
        /// The <see cref="T:System.Object" /> for which a hash code is to be returned.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// The type of <paramref name="region" /> is a reference type and <paramref name="region"
        /// /> is null.
        /// </exception>
        /// <returns>A hash code for the specified object.</returns>
        public int GetHashCode(CodeItemRegion region)
        {
            if (region == null)
            {
                throw new ArgumentNullException("region");
            }

            return region.Name == null ? 0 : region.Name.GetHashCode();
        }
    }
}
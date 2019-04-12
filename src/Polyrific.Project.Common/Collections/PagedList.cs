using System.Collections.Generic;

namespace Polyrific.Project.Common.Collections
{
    public class PagedList<T> : List<T>
    {
        /// <summary>
        /// Instantiate <see cref="PagedList"/> object
        /// </summary>
        /// <param name="items">Collection of the items</param>
        /// <param name="pageIndex">Current page index</param>
        /// <param name="pageSize">Maximum number of items in a page</param>
        /// <param name="totalCount">Total number of all items</param>
        public PagedList(List<T> items, int pageIndex, int pageSize, int totalCount)
        {
            AddRange(items);
            PageIndex = pageIndex;
            PageSize = pageSize;
            LastPageIndex = (int)(totalCount / pageSize);
        }

        /// <summary>
        /// Current page index
        /// </summary>
        /// <value></value>
        public int PageIndex { get; } = 0;

        /// <summary>
        /// Maximum number of items in a page
        /// </summary>
        /// <value></value>
        public int PageSize { get; } = 10;

        /// <summary>
        /// Last page index
        /// </summary>
        /// <value></value>
        public int LastPageIndex { get; } = 0;
    }
}

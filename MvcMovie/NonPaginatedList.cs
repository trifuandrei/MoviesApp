using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FullMovieList
{
    public class NonPaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public NonPaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = 1;

            this.AddRange(items);
        }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages + 1;
          public static async Task<NonPaginatedList<T>> CreateStart(IQueryable<T> source, int pageIndex, int pageSize)
          {
              var count = await source.CountAsync();
              var items = await source.ToListAsync();
              return new NonPaginatedList<T>(items, count, pageIndex, pageSize);
          }
    }
}

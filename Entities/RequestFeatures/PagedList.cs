﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PagedList<T> : List<T>
    {
        public MetaData MetaData { get; set; }
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            MetaData = new MetaData
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = count == 0 ? 0 : pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };


            AddRange(items);
        }

        public static async Task<PagedList<T>> ToPagedListAsync(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var totalPages = (int)Math.Ceiling(count / (double)pageSize);
            if (pageNumber > totalPages)
            {
                pageNumber = totalPages;
            }
            if (pageNumber == 0)
            {
                pageNumber = 1;
            }
            var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
}
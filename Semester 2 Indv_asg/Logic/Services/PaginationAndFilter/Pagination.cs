﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logic.Services.PaginationAndFilter
{
    public class Pagination<T>
    {
        private readonly IEnumerable<T> data;
        private readonly int pageSize;

        public Pagination(IEnumerable<T> data, int pageSize)
        {
            this.data = data;
            this.pageSize = pageSize;
        }

        public PaginatedList<T> GetPage(int pageIndex, Func<T, bool> filter = null)
        {
            IEnumerable<T> filteredData;
            if (filter != null)
            {
                filteredData = new Filter<T>(data).ApplyFilter(filter);
            }
            else
            {
                filteredData = data;
            }

            var totalItems = filteredData.Count();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var pagedData = filteredData.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return new PaginatedList<T>(pagedData, pageIndex, totalPages, totalItems);
        }

        public IEnumerable<int> GetVisiblePageNumbers(int currentPage, int totalPages, int maxVisiblePages)
        {
            int startPage;
            int endPage;

            if (totalPages <= maxVisiblePages)
            {
                startPage = 1;
                endPage = totalPages;
            }
            else
            {
                int halfVisiblePages = maxVisiblePages / 2;
                int pagesBeforeCurrent = halfVisiblePages;
                int pagesAfterCurrent = maxVisiblePages - halfVisiblePages - 1;

                if (currentPage <= halfVisiblePages)
                {
                    startPage = 1;
                    endPage = maxVisiblePages;
                }
                else if (currentPage + halfVisiblePages >= totalPages)
                {
                    startPage = totalPages - maxVisiblePages + 1;
                    endPage = totalPages;
                }
                else
                {
                    startPage = currentPage - pagesBeforeCurrent;
                    endPage = currentPage + pagesAfterCurrent;
                }
            }

            return Enumerable.Range(startPage, endPage - startPage + 1);
        }
    }
}

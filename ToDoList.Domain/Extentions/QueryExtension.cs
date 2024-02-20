using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.Extentions
{
    public static class QueryExtension
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, bool condition,
            Expression<Func<T, bool>> predicate)
        {
            if(condition) 
                return source.Where(predicate);
            return source;
        }    
    }
}

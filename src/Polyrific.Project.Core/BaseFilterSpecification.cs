// Copyright (c) Polyrific, Inc 2019. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Polyrific.Project.Core
{
    public abstract class BaseFilterSpecification<TEntity> : IFilterSpecification<TEntity> where TEntity : BaseEntity
    {
        protected BaseFilterSpecification(Expression<Func<TEntity, bool>> criteria) => Criteria = criteria;

        protected BaseFilterSpecification(Expression<Func<TEntity, bool>> criteria,
            Expression<Func<TEntity, object>> orderBy,
            bool orderDesc = false)
        {
            Criteria = criteria;

            if (orderDesc)
            {
                OrderByDescending = orderBy;
            }
            else
            {
                OrderBy = orderBy;
            }
        }

        public Expression<Func<TEntity, bool>> Criteria { get; }

        public Expression<Func<TEntity, object>> OrderBy { get; }

        public Expression<Func<TEntity, object>> OrderByDescending { get; }

        public List<Expression<Func<TEntity, object>>> Includes { get; } = new List<Expression<Func<TEntity, object>>>();

        public List<string> IncludeStrings { get; } = new List<string>();

        /// <summary>
        /// Add related entity to be included in the query
        /// </summary>
        /// <param name="includeExpression">Include expression</param>
        protected virtual void AddInclude(Expression<Func<TEntity, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        /// <summary>
        /// Add related entity to be included in the query
        /// </summary>
        /// <param name="includeString">Related entity name</param>
        protected virtual void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }
    }
}

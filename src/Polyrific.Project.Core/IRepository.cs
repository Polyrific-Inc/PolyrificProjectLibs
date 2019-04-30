﻿// Copyright (c) Polyrific, Inc 2019. All rights reserved.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Polyrific.Project.Common.Collections;

namespace Polyrific.Project.Core
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Get entity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled</param>
        /// <returns>The entity</returns>
        Task<TEntity> GetById(int id, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get entities by specification
        /// </summary>
        /// <param name="spec">Filter specification</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled</param>
        /// <returns>Collection of the entities</returns>
        Task<IEnumerable<TEntity>> GetBySpec(IFilterSpecification<TEntity> spec, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get entities by specification
        /// </summary>
        /// <param name="spec">Filter specification</param>
        /// <param name="pageIndex">Current page index</param>
        /// <param name="pageSize">Maximum number of items in a page</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled</param>
        /// <returns>Collection of the entities</returns>
        Task<PagedList<TEntity>> GetBySpec(IFilterSpecification<TEntity> spec, int pageIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get a single entity by specification
        /// </summary>
        /// <param name="spec">Filter specification</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled</param>
        /// <returns>The entity</returns>
        Task<TEntity> GetSingleBySpec(IFilterSpecification<TEntity> spec, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Count number of entities based on the specification
        /// </summary>
        /// <param name="spec">Filter specification</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled</param>
        /// <returns>Number of the entities</returns>
        Task<int> CountBySpec(IFilterSpecification<TEntity> spec, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a new entity
        /// </summary>
        /// <param name="entity">New entity</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled</param>
        /// <returns>Id of the new entity</returns>
        Task<int> Create(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <param name="entity">Updated entity</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled</param>
        /// <returns></returns>
        Task Update(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled</param>
        /// <returns></returns>
        Task Delete(int id, CancellationToken cancellationToken = default(CancellationToken));
    }
}

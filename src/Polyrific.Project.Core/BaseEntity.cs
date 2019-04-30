// Copyright (c) Polyrific, Inc 2019. All rights reserved.

using System;

namespace Polyrific.Project.Core
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// Id of the entity
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// The date when the entity was created
        /// </summary>
        /// <value></value>
        public DateTime Created { get; set; }

        /// <summary>
        /// The date when the entity was last updated
        /// </summary>
        /// <value></value>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// A random value that must change whenever an entity is persisted
        /// </summary>
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
    }
}

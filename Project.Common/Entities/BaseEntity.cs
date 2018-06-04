using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Common.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString().ToLower().Replace("-", "");
            CreatedAt = DateTimeOffset.Now;
            UpdatedAt = DateTimeOffset.Now;
        }

        [Required]
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// create time utc
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// update time utc
        /// </summary>
        public DateTimeOffset UpdatedAt { get; set; }

    }
}

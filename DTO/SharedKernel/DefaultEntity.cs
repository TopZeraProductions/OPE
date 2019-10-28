using System;

namespace DTO.SharedKernel {
    public class DefaultEntity {
        public int Id { get; set; }
        
        public DateTime CreatedAt { get; set; }

        public DateTime? ExcludedAt { get; set; }

        public bool Active { get; set; }
    }
}
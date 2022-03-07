using System;

namespace ControleFrotas.Models.Domain.Entites
{
    public static class BaseEntity
    {
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}

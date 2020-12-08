using System;
using VirtoCommerce.Platform.Core.Common;

namespace VirtoCommerce.Platform.Core.ChangeLog
{
    public interface ILastChangesService
    {
        void Reset(string entityName);
        void Reset(AuditableEntity entity);
        DateTimeOffset GetLastModified(string entityName);
    }
}

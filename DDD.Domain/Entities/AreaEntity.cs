using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities
{
    public sealed class AreaEntity
    {
        public AreaEntity(int areaId, string areaName) : this(new AreaId(areaId), areaName)
        {
        }

        public AreaEntity(AreaId areaId, string areaName)
        {
            AreaId = areaId;
            AreaName = areaName;
        }

        public AreaId AreaId { get; }
        public string AreaName { get; }
    }
}

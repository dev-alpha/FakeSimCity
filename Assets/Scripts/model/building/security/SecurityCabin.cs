using UnityEngine;

namespace Cariacity.game
{
    public class SecurityCabin : Building
    {
        public static BuildingData Data = new BuildingData
        {
            Bounds = new Rectangle(0, 0, 0, 0),
            InfuenceType = (int)Status.Security,
            InfluenceBound = 5,
            Value = 100
        };

        public static bool IsBuildable(GridCell cell)
        {
            return IsBuildable(cell, Data.Bounds);
        }

        public static void SetOnMap(Vector3 pos)
        {
            if (IsBuildable(Common.GetNearbyCell(pos)))
            {
                SetOnMap(pos, Data);
                DebitFromMoney(Data.Value);
            }
        }

        public static void RemoveFromMap(Vector3 pos)
        {
            RemoveFromMap(pos, Data);
        }
    }
}

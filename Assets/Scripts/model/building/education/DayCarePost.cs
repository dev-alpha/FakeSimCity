using UnityEngine;

namespace Cariacity.game
{
    public class DayCarePost : Building
    {
        public static BuildingData Data = new BuildingData
        {
            InfluenceBound = 5,
            Value = 500
        };

        public static bool IsBuildable(GridCell cell)
        {
            return IsBuildable(cell, new Rectangle(0, 0, 0, 0));
        }

        public static void SetOnMap(Vector3 pos)
        {
            var cell = Common.GetNearbyCell(pos);

            if (IsBuildable(cell))
            {
                cell.obj = GameController.InitObj(Data.Model, pos);
            }
        }

        public static void RemoveFromMap(Vector3 pos)
        {

        }
    }
}

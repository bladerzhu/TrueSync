using System;

namespace TrueSync
{

    /**
    *  @brief Helpers for 3D physics.
    **/
    public class TSPhysics {

        public static bool Raycast(TSVector rayOrigin, TSVector rayDirection, out TSRaycastHit hit, FP maxDistance, int layer)
        {
            TSRay ray = new TSRay(rayOrigin, direction:rayDirection);
            hit = null;
            hit = PhysicsWorldManager.instance.Raycast(ray, maxDistance, layer:layer);
            if (hit != null)
                return true;
            return false;
        }
    }

}
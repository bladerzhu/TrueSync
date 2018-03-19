using UnityEngine;

namespace TrueSync {

    /**
     *  @brief Simulates physical properties of a body.
     **/
    [AddComponentMenu("TrueSync/Physics/TSMaterial", 22)]
    public class TSMaterial : MonoBehaviour {

        /**
         *  @brief Static friction when in contact. 
         **/
        public FP friction = 0.25f;

        /**
         *  @brief Coeficient of restitution. 
         **/
        public FP restitution = 0;

    }

}
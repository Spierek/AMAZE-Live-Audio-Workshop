using UnityEngine;

public class SphereRotation : MonoBehaviour {
    #region Variables
    public float speed = 2;
    #endregion

    #region Monobehaviour Methods
    
    void Update () {
        if (OSCReceiverC.OSCvalues[4] > 0.95f) {
            transform.RotateAround(Vector3.zero, Random.insideUnitSphere, Random.Range(45, 180));
        }
    }
    #endregion

    #region Methods
    #endregion
}

using UnityEngine;

public class Spinner : MonoBehaviour {
    #region Variables
    public float mod;
    public int osc;
    #endregion

    #region Monobehaviour Methods
    void Awake () {
    
    }
    
    void Update () {
        transform.Rotate(transform.forward, Time.deltaTime * (mod + OSCReceiverC.OSCvalues[osc]));
    }
    #endregion

    #region Methods

    #endregion
}

using UnityEngine;

public class Block : MonoBehaviour {
    #region Variables
    public int              OSCid;
    public float            scaleMod = 1;
    private Vector3         originalScale;
    #endregion

    #region Monobehaviour Methods
    void Awake() {
        originalScale = transform.parent.localScale;
    }

    void Update () {
        float osc = OSCReceiverC.OSCvalues[OSCid];
        transform.parent.localScale = originalScale + new Vector3(0, osc * scaleMod, 0);
    }
    #endregion
}

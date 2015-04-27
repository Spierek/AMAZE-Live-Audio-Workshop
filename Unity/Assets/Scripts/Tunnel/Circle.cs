using UnityEngine;

public class Circle : MonoBehaviour {
    #region Variables
    private LineRenderer lineRenderer;
    private float zDistance;
    #endregion

    #region Monobehaviour Methods
    void Awake () {
        lineRenderer = GetComponent<LineRenderer>();
        zDistance = transform.position.z;
    }
    
    void Update () {
        Vector3 v3 = new Vector3();
        // get current block position values
        for (int i = 0; i < OSCReceiverC.OSCcount; i++) {
            v3 = BlockSetup.Instance.blocks[i].GetChild(0).GetChild(0).position;
            v3.z = zDistance;
            lineRenderer.SetPosition(i, v3);
        }

        // close the line renderer gap (connecting last and first)
        v3 = BlockSetup.Instance.blocks[0].GetChild(0).GetChild(0).position;
        v3.z = zDistance;
        lineRenderer.SetPosition(32, v3);
    }
    #endregion
}

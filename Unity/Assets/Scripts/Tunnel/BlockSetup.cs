using UnityEngine;

public class BlockSetup : MonoBehaviour {
    #region Variables
    public static BlockSetup Instance;
    public GameObject blockContainer;

    public Transform[] blocks = new Transform[OSCReceiverC.OSCcount];
    #endregion

    #region Monobehaviour Methods
    void Awake () {
        Instance = this;

        for (int i = 0; i < OSCReceiverC.OSCcount; i++) {
            GameObject go = Instantiate(blockContainer);
            go.transform.parent = transform;
            go.transform.localPosition = Vector3.zero;
            go.transform.Rotate(transform.forward, i/(float)OSCReceiverC.OSCcount * 360f);

            go.transform.GetChild(0).GetChild(0).GetComponent<Block>().OSCid = i;
            blocks[i] = go.transform;
        }
    }
    #endregion
}

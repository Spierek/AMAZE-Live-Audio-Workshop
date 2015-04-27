using System.Linq;
using UnityEngine;

public class CameraMover : MonoBehaviour {
    #region Variables
    public float speed = 1f;
    public bool animateFOV = true;

    private Camera cam;
    private float fovTarget;
    #endregion

    #region Monobehaviour Methods
    void Awake () {
        cam = GetComponent<Camera>();
    }
    
    void Update () {
        transform.Translate(0f, 0f, Time.deltaTime * speed);

        if (animateFOV) {
            float fov = OSCReceiverC.OSCvalues.Sum();
            fov /= OSCReceiverC.OSCvalues.Length;

            fov = 45f + fov * 150;
            Mathf.Clamp(fov, 45f, 140f);
            cam.fieldOfView = fov;
        }
        else {
            cam.fieldOfView = 60f;
        }
    }
    #endregion
}

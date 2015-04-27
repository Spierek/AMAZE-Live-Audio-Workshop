using UnityEditor;
using UnityEngine;

public class RandomizeBGColor : MonoBehaviour {
    #region Variables
    public float colorShiftSpeed = 0.1f;
    private Camera cam;
    private Vector3 hsv;
    #endregion

    #region Monobehaviour Methods
    void Awake () {
        cam = GetComponent<Camera>();
        EditorGUIUtility.RGBToHSV(cam.backgroundColor, out hsv.x, out hsv.y, out hsv.z);
    }
    
    void Update () {
        hsv.x += Time.deltaTime * colorShiftSpeed;
        if (hsv.x > 1)
            hsv.x = 0;

        cam.backgroundColor = EditorGUIUtility.HSVToRGB(hsv.x, hsv.y, hsv.z);
    }
    #endregion
}

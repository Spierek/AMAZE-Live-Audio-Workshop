using UnityEngine;

public class Icosa : MonoBehaviour {
    #region Variables
    private Mesh mesh;
    private Vector3[] originalVerts;
    private Vector3[] currentVerts;
    private Vector3[] normals;
    #endregion

    #region Monobehaviour Methods
    void Awake () {
        mesh = GetComponent<MeshFilter>().mesh;
        originalVerts = mesh.vertices;
        currentVerts = mesh.vertices;
        normals = mesh.normals;
    }
    
    void Update () {
        Deform();
    }
    #endregion

    #region Methods
    private void Deform() {
        for(int i = 0; i < currentVerts.Length; i++) {
            currentVerts[i] = originalVerts[i] + OSCReceiverC.OSCvalues[i % OSCReceiverC.OSCcount] * 0.5f * normals[i];    
        }
        mesh.vertices = currentVerts;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
    }
    #endregion


}

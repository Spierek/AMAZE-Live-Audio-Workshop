using UnityEngine;

public class CircleSpawner : MonoBehaviour {
    #region Variables
    public GameObject prefab;
    public float spawnDelay = 0.5f;
    public float spawnDistance = 30f;
    #endregion

    #region Monobehaviour Methods
    void Start () {
        SpawnCircle();
    }
    #endregion

    #region Methods
    private void SpawnCircle() {
        GameObject go = Instantiate(prefab, Camera.main.transform.position + new Vector3(0, 0, spawnDistance), Quaternion.identity) as GameObject;
        go.transform.parent = transform;
        Destroy(go, 10f);

        Invoke("SpawnCircle", spawnDelay);
    }
    #endregion
}

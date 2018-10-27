using UnityEngine;

public class ShootingGallery : MonoBehaviour {

    [SerializeField]
    protected GameObject ghostPrefab;
    [SerializeField]
    protected float spawnInterval = 2f;

    public void StartGame () {
        InvokeRepeating("CreateGhost", spawnInterval, spawnInterval);
	}

    public void StopGame() {
        CancelInvoke();
    }

    public void CreateGhost() {
        Vector3 direction = Vector3.up;
        direction.x = Random.Range(-0.5f, 0.5f);

        Vector3 position = transform.position;
        position.x += Random.Range(-4, 4);

        Target ghost = Instantiate(ghostPrefab).GetComponent<Target>();
        ghost.transform.position = position;
        ghost.AssignDirection(direction);
    }
}

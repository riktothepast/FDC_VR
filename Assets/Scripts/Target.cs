using UnityEngine;

public class Target : MonoBehaviour {

    [SerializeField]
    protected float moveSpeed;
    [SerializeField]
    protected float TTL;
    Vector3 direction;

    private void Start()
    {
        Invoke("RemoveEntity", TTL);
    }

    void Update () {
        transform.localScale = new Vector3(1 + Mathf.PingPong(Time.time, 0.2f), 1 + Mathf.PingPong(Time.time, 0.2f), 1 + Mathf.PingPong(Time.time, 0.2f));
        transform.Translate(direction * moveSpeed * Time.deltaTime);
	}

    public void AssignDirection(Vector3 dir) {
        direction = dir;
    }

    public void Hit()
    {
        RemoveEntity();
    }

    void RemoveEntity()
    {
        Destroy(gameObject);
    }
}

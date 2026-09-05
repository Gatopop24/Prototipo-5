using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float xDestroy = 10.0f;
    public float speed = 100.0f;
    private Rigidbody objectRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(Vector3.right * speed);

        if(transform.position.x > xDestroy)
        {
            Destroy(gameObject);
        }
    }
}

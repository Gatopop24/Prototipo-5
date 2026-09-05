using UnityEngine;
using System.Collections;

public class PlayerControllerLab : MonoBehaviour
{
    private float speed = 10.0f;
    private float xBound = 8;
    private Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovePlayer();
        ConstraintPlayerPosition();
    }

    private void MovePlayer()
    {
        // the position of the map is rotated so x is for vertical and z for horizontal
        float horizontalInput = Input.GetAxis("Horizontal"); // use this for z
        float verticalInput = Input.GetAxis("Vertical"); //use this for x

        Vector3 direction = new Vector3(-verticalInput, 0, horizontalInput);

        transform.position += direction * speed * Time.deltaTime;
        /*
        Movement by physics that doesn't work well for lab 5
        playerRb.AddForce(Vector3.right * speed * -verticalInput);
        playerRb.AddForce(Vector3.forward * speed * horizontalInput);
        */
    }

    private void ConstraintPlayerPosition()
    {
        if(transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player has collided with enemy.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
        }
    }
}

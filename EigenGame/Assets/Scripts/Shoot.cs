using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed = 40;
    private float xBound = 25;
    private float zBound = 25;
    private float yBound = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        ProjectileBounds();
    }
    void ProjectileBounds()
    {
        if (transform.position.x < -xBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > xBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < yBound)
        {
            transform.position = new Vector3(transform.position.x, yBound, transform.position.z);
        }
        if (transform.position.y > yBound)
        {
            transform.position = new Vector3(transform.position.x, yBound, transform.position.z);
        }
        if (transform.position.z < -zBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > zBound)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 direction;
    public float speed;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.Find("AimObject");
        direction = target.transform.position - transform.position;
        StartCoroutine(Wait());

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        transform.LookAt(target.transform);

        rb.velocity = direction * speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //public GameObject bullet;
    public Transform bulletSpawnPoint;
    private GameObject target;

    public float speed = 3f;
    public GameObject bullet;
    private float distance = 50f;
    public Platform platform;

    void Start()
    {
        target = GameObject.Find("AimObject");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    private void Awake()
    {
        GameManager.I.gun = gameObject;
    }
}

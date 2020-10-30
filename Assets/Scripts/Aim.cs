using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    GameObject target;
    public Vector3 distance;
    private Touch touch;
    private Rigidbody rb;
    public float speed = 10;

    private void Awake()
    {
        GameManager.I.target = gameObject;
    }
    void Start()
    {
        target = GameObject.Find("AimObject");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        distance.z = target.transform.position.z - transform.position.z;

        transform.position = new Vector3(GetWorldPos(Input.mousePosition).x, GetWorldPos(Input.mousePosition).y, GetWorldPos(Input.mousePosition).z);
    }

    public static Vector3 GetWorldPos(Vector2 screenPos)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPos);

        //float t = -ray.origin.z / ray.direction.z;
        
        return ray.GetPoint(10);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject target;
    public int targetCount = 0;
    public Transform gunPoint;
    public float smoothTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        

        int random = Random.Range(1, 4);
        for (int i = 0; i < random; i++)
        {
            targetCount++;
            Instantiate(target, new Vector3(transform.position.x + Random.Range(-4, 4), transform.position.y + 52.5f + Random.Range(0, 2), transform.position.z + Random.Range(0, 5)), transform.rotation * Quaternion.Euler(0, 180, 0));
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (targetCount == 0)
        {
            

            GameManager.I.currentPlatform++;
            Destroy(gameObject);
            if (GameObject.FindGameObjectWithTag("Platform" + GameManager.I.currentPlatform.ToString()) == null)
            {
                Debug.Log("Level Finish!");
                GameManager.I.gameOver = true;
                return;
            }

        }
    }
}

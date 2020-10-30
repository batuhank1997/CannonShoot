using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            gameObject.GetComponent<MeshCollider>().enabled = false;
            Destroy(collision.gameObject);
            if (GameManager.I.currentPlatform == 0)
            {
                GameObject.FindGameObjectWithTag("Platform" + GameManager.I.currentPlatform.ToString()).GetComponent<Platform>().targetCount--;
            }
            if (GameManager.I.currentPlatform == 1)
            {
                GameObject.FindGameObjectWithTag("Platform" + GameManager.I.currentPlatform.ToString()).GetComponent<Platform>().targetCount--;
            }
            if (GameManager.I.currentPlatform == 2)
            {
                GameObject.FindGameObjectWithTag("Platform" + GameManager.I.currentPlatform.ToString()).GetComponent<Platform>().targetCount--;
            }
            if (GameManager.I.currentPlatform == 3)
            {
                GameObject.FindGameObjectWithTag("Platform" + GameManager.I.currentPlatform.ToString()).GetComponent<Platform>().targetCount--;
            }
            if (GameManager.I.currentPlatform == 4)
            {
                GameObject.FindGameObjectWithTag("Platform" + GameManager.I.currentPlatform.ToString()).GetComponent<Platform>().targetCount--;
            }
            if (GameManager.I.currentPlatform == 5)
            {
                GameObject.FindGameObjectWithTag("Platform" + GameManager.I.currentPlatform.ToString()).GetComponent<Platform>().targetCount--;
            }
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }
}

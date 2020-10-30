using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject platform;
    public GameObject gun;
    public GameObject target;
    public GameObject startPlatform;
    public bool gameOver = false;
    public int currentPlatform = 1;
    public int platformTEMP;
    public GameObject gunPoints;
    public int random;
    public GameObject nextLevelObj;

    private float posX;
    private float posZ;

    int j = 0;
    int k = 0;
    int i;
    private void Awake()
    {
        II = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        platformTEMP = currentPlatform;

        Instantiate(startPlatform, new Vector3(0, -50, -10), Quaternion.identity);
        Instantiate(gun, new Vector3(startPlatform.transform.position.x, 0.5f, startPlatform.transform.position.z - 5), Quaternion.identity);

        random = Random.Range(2, 6);
        for (i = 1; i < random; i++)
        {
            GameObject levelPlatform = Instantiate(platform, new Vector3(Random.Range(-5, 5) + k, -50, Random.Range(5, 15) + j), Quaternion.identity);

            switch (i)
            {
                case 1:
                    levelPlatform.tag = "Platform1";
                    break;
                case 2:
                    levelPlatform.tag = "Platform2";
                    break;
                case 3:
                    levelPlatform.tag = "Platform3";
                    break;
                case 4:
                    levelPlatform.tag = "Platform4";
                    break;
                case 5:
                    levelPlatform.tag = "Platform5";
                    break;
                default:
                    break;
            }
          
        j += 30;
        k += 10;

        }
    }

    private void Update()
    {
        if (currentPlatform != platformTEMP)
            SetRandomOffset();

        if(gameOver == true)
        {
            nextLevelObj.SetActive(true);
        }

        MoveNextPlatform();

    }

    public static GameManager II;
    public static GameManager I
    {
        get
        {
            if (II == null)
            {
                II = GameObject.Find("GameManager").GetComponent<GameManager>();
            }
                return II;
        }
    }
    public void GoNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void SetRandomOffset()
    {
        posX = Random.Range(-5, 5);
        posZ = Random.Range(-4, -2);
    }

    void MoveNextPlatform()
    {
        if (GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()) == null)
            return;
        if (currentPlatform == 1)
        {
            gun.transform.position = Vector3.Lerp(gun.transform.position, new Vector3(
                    GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()).transform.position.x + posX,
                    0.5f,
                    GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()).transform.position.z + posZ), 2 * Time.deltaTime);
            platformTEMP = currentPlatform;
        }

        if (currentPlatform == 2)
        {
            gun.transform.position = Vector3.Lerp(gun.transform.position, new Vector3(
                    GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()).transform.position.x + posX,
                    0.5f,
                    GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()).transform.position.z + posZ), 2 * Time.deltaTime);
            platformTEMP = currentPlatform;
        }

        if (currentPlatform == 3)
        {
            gun.transform.position = Vector3.Lerp(gun.transform.position, new Vector3(
                    GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()).transform.position.x + posX,
                    0.5f,
                    GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()).transform.position.z + posZ), 2 * Time.deltaTime);
            platformTEMP = currentPlatform;
        }

        if (currentPlatform == 4)
        {
            gun.transform.position = Vector3.Lerp(gun.transform.position, new Vector3(
                    GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()).transform.position.x + posX,
                    0.5f,
                    GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()).transform.position.z + posZ), 2 * Time.deltaTime);
            platformTEMP = currentPlatform;
        }

        if (currentPlatform == 5)
        {
            gun.transform.position = Vector3.Lerp(gun.transform.position, new Vector3(
                    GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()).transform.position.x + posX,
                    0.5f,
                    GameObject.FindGameObjectWithTag("Platform" + currentPlatform.ToString()).transform.position.z + posZ), 2 * Time.deltaTime);
            platformTEMP = currentPlatform;
        }
    }
}

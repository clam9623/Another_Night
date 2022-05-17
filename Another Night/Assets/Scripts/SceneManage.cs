using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public string sceneToLoad;
    [SerializeField] GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        if (item == null)
        {
            item = GameObject.FindGameObjectWithTag("Item");
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    public void LevelNext()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
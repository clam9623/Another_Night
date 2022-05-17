using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(reloadTimer(5));
    }


    IEnumerator reloadTimer(float reloadTimeInSeconds)
    {
        float counter = 0;

        while (counter < reloadTimeInSeconds)
        {
            counter += Time.deltaTime;
            yield return null;
        }

        //Load new Scene
        SceneManager.LoadScene("RobDied");
    }
}

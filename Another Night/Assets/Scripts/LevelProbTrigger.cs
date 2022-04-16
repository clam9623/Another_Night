using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProbTrigger : MonoBehaviour
{
    // Update is called once per frame
    public void LevelCall()
    {
        float number = Random.value;
        Debug.Log(number);
        if (number > 0 & number < 0.03)
        {
            SceneManager.LoadScene("Mugging");
        }
        else if (number > 0.03 & number < 0.07)
        {
            SceneManager.LoadScene("Gun");
        }
        else if (number > 0.07 & number < 0.27)
        {
            SceneManager.LoadScene("Burglary");
        }
    }
}

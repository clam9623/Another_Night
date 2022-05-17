using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProbTrigger : MonoBehaviour
{
    [SerializeField] private AnimationCurve animCurve;
    // Update is called once per frame
    public void LevelCall()
    {
        float number = animCurve.Evaluate(Random.value);
        Debug.Log(number);
        if (number > 0 & number < 0.03)
        {
            SceneManager.LoadScene("Robbery");
        }
        else if (number > 0.03 & number < 0.233)
        {
            SceneManager.LoadScene("Stalking");
        }
        else 
        {
            SceneManager.LoadScene("Normal");
        }
    }

    public void End()
    {
        Application.Quit();
    }
}

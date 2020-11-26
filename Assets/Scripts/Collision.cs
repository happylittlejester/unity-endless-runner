using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter ()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("GameOver");
    }
}

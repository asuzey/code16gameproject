using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    public string �kinciLevel;

    public void SahneyeGec()
    {
        SceneManager.LoadScene(�kinciLevel);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    public string ÝkinciLevel;

    public void SahneyeGec()
    {
        SceneManager.LoadScene(ÝkinciLevel);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGeciss : MonoBehaviour
{

    public string ÜçüncüLevel;

    public void SahneyeGec()
    {
        SceneManager.LoadScene(ÜçüncüLevel);
    }
}

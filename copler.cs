using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class copler : MonoBehaviour
{
    public GameObject kaybolacak;
    public GameObject gelicek;
    public ParticleSystem efekt;

    public void ackapa()
    {
        StartCoroutine(StartEvent());
        


    }
    IEnumerator StartEvent()
    {
        yield return new WaitForSeconds(2);
        efekt.Play();
        yield return new WaitForSeconds(0.3f);
        kaybolacak.SetActive(false);
        gelicek.SetActive(true);
    }

    public void yenisahne()
    {
        SceneManager.LoadScene(1);
    }
}

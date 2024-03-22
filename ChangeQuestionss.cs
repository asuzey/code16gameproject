using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeQuestionss: MonoBehaviour
{

    [Header("Screens")]
    public GameObject[] Soru;
    int deger;


    public void DogruCevap(GameObject buton)
    {
        GameObject btn = buton.transform.GetChild(2).gameObject;
        btn.GetComponent<Image>().color = Color.green;
        StartCoroutine(soruDegis(buton));

    }

    IEnumerator soruDegis(GameObject buton)
    {
        yield return new WaitForSeconds(1);
        buton.SetActive(false);
        deger++;


        if (deger != 3)
        {
            Soru[deger].SetActive(true);

        }

        else
        {
            SceneManager.LoadScene(3);
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public Text tx;
    private string d_text = "Let's go home!";

    void Start()
    {
        StartCoroutine(_typing());
    }
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(3f);
        for (int i = 0; i <= d_text.Length; i++)
        {
            tx.text = d_text.Substring(0, i);
            //몇번째부터출력, 몇개출력
            yield return new WaitForSeconds(0.20f);
        }
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("StartScene");

    }
}



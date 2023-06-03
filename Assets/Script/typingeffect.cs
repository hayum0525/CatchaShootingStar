using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class typingeffect : MonoBehaviour
{
    public Text tx;
    private string s_text= "Dad, can we go home..?";

    void Start()
    {
        StartCoroutine(_typing());
    }

   IEnumerator _typing()
    {
        yield return new WaitForSeconds(3f);
        for(int i=0; i<=s_text.Length; i++)
        {
            tx.text = s_text.Substring(0, i);
            //몇번째부터출력, 몇개출력
            yield return new WaitForSeconds(0.20f);
        }
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("StartScene");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

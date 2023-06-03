using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScoreView : MonoBehaviour
{
    [SerializeField]
    private PlayerController PlayerController;
    private TextMeshProUGUI textScore;
    void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //ĳġ ���ڿ��� playercontroller�� Score�� ��ģ��.
        textScore.text = "Catch x" + PlayerController.Score;
    }
}

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
        //캐치 문자열과 playercontroller의 Score를 합친다.
        textScore.text = "Catch x" + PlayerController.Score;
    }
}

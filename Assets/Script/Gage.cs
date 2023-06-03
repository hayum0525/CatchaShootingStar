using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gage : MonoBehaviour
{
    public float fillSpeed = 0.1f; // 게이지가 차는 속도
    public float fillAmountPerPress = 0.1f; // 한 번 스페이스바를 눌렀을 때 채워지는 양
    public Slider gaugeSlider; // UI Slider 컴포넌트

    private float timer = 10f; // 타이머
    private bool isFilling; // 게이지 채우기 여부

    private void Start()
    {
        // 타이머 시작
        isFilling = true;
    }

    private void Update()
    {
        if (isFilling)
        {
            // 타이머 감소
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                // 타이머 종료
                timer = 0f;
                isFilling = false;
                
            }

            // 게이지 채우기
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gaugeSlider.value += fillAmountPerPress;
            }

            // 게이지가 최대치(1)에 도달하면 게이지 채우기를 멈춤
            if (gaugeSlider.value >= 1f)
            {
                gaugeSlider.value = 1f;
                isFilling = false;
            }
        }
        else
        {
            // 10초가 지나면 자동으로 게이지를 채움
          //  gaugeSlider.value += fillSpeed * Time.deltaTime;

            // 게이지가 최대치(1)에 도달하면 게이지 채우기를 멈춤
            if (gaugeSlider.value >= 1f)
            {
               
                gaugeSlider.value = 1f;
                {
                    SceneManager.LoadScene("EndingScene");
                }
               
            

            }
            else
            {
                SceneManager.LoadScene("RetryScene");
            }
        }
    }
    //public float gage = 0;
    //public float maxgage = 30f;

    //private Slider slider;
    //void Start()
    //{
    //    // slider = gameObject.GetComponent<Slider>();
    //    slider.maxValue = maxgage;
    //    //slider.minValue = gage;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    slider.value = gage;

    //    if(slider.value<maxgage)
    //    {
    //        if(Input.GetKeyDown(KeyCode.Space))
    //        {
    //            slider.value += 1;
    //        }
    //    }
    //}
}

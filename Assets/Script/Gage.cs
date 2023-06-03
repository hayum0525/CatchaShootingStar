using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gage : MonoBehaviour
{
    public float fillSpeed = 0.1f; // �������� ���� �ӵ�
    public float fillAmountPerPress = 0.1f; // �� �� �����̽��ٸ� ������ �� ä������ ��
    public Slider gaugeSlider; // UI Slider ������Ʈ

    private float timer = 10f; // Ÿ�̸�
    private bool isFilling; // ������ ä��� ����

    private void Start()
    {
        // Ÿ�̸� ����
        isFilling = true;
    }

    private void Update()
    {
        if (isFilling)
        {
            // Ÿ�̸� ����
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                // Ÿ�̸� ����
                timer = 0f;
                isFilling = false;
                
            }

            // ������ ä���
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gaugeSlider.value += fillAmountPerPress;
            }

            // �������� �ִ�ġ(1)�� �����ϸ� ������ ä��⸦ ����
            if (gaugeSlider.value >= 1f)
            {
                gaugeSlider.value = 1f;
                isFilling = false;
            }
        }
        else
        {
            // 10�ʰ� ������ �ڵ����� �������� ä��
          //  gaugeSlider.value += fillSpeed * Time.deltaTime;

            // �������� �ִ�ġ(1)�� �����ϸ� ������ ä��⸦ ����
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

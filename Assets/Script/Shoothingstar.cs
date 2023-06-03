using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Shoothingstar : MonoBehaviour
{
    [SerializeField]
    public int scorepoint = 1; //���� 1�� 
    private  PlayerController playerController; 
    //playercontroller�� ������ score ������ �����ϱ� ���� 
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.05f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }


        

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player") //�浹�� ������Ʈ�� player�϶� 
        {
            OnDie();//������Ʈ ���� �Լ� ȣ��
        }
    }
 
    void OnDie()
    {
        playerController.Score += scorepoint;
       
        //playercontroller�� Score+1�� scorepoint�� ���� �� ��Ʈ���� 
        Destroy(gameObject);

    }
}

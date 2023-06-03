using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Shoothingstar : MonoBehaviour
{
    [SerializeField]
    public int scorepoint = 1; //점수 1점 
    private  PlayerController playerController; 
    //playercontroller에 선언한 score 변수에 접근하기 위해 
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

        if (collision.gameObject.tag == "Player") //충돌된 오브젝트가 player일때 
        {
            OnDie();//오브젝트 삭제 함수 호출
        }
    }
 
    void OnDie()
    {
        playerController.Score += scorepoint;
       
        //playercontroller에 Score+1을 scorepoint에 저장 후 디스트로이 
        Destroy(gameObject);

    }
}

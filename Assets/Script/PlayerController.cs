using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEditor.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    float moveX, moveY;
    [SerializeField][Range(5f, 10f)] float moveSpeed = 5f;

   public int score;
    public int Score
    {
        set => score = Mathf.Max(0, value);
        get => score;
        //값이 음수가 되지않도록 
    }

    void Start()
    {

    }


    private void Update()
    {
        if (Input.GetKey("right"))
        {
            moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        }

        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
        //아래코드 이동거리 3씩 움직여서 부자연스러움
        //if(Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    transform.Translate(-3, 0, 0); //왼쪽 이동
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    transform.Translate(3, 0, 0); //왼쪽 이동
        //}
    }
    private void LateUpdate()
    {
        // 바깥으로 못나가게 함
      
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.3f, 8.3f),
            Mathf.Clamp(transform.position.y, -6f, 6f));
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    public GameObject starPrefab;
    float span = 1.0f;
    float delta = 0;
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(starPrefab);
            int px = Random.Range(-6, 6); //-6 ,6 사이에서 랜덤으로 생성 
            go.transform.position = new Vector3(px, 6, 0);
        }
    }
}

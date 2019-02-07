using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallUp : MonoBehaviour {

    [SerializeField]
    private float speed = 3f;
    bool chek = true;
    private void Start()
    {
        InvokeRepeating("SpeedBuf", 1, 1);
    }
    void SpeedBuf()
    {
        speed += 0.1f;
    }
    void Update () {
        if (transform.position.y > 8.79f && chek)
        {
          Statics.score++;
          chek = false;
        }
        if (transform.position.y > 11.03f)
        {
         Destroy(gameObject);    
        }
        if(Statics.game)
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAcsil : MonoBehaviour {

    [SerializeField]
    float speed = 3f;
    private void FixedUpdate()
    {
        if (Statics.acsilControl)
        {
            Vector3 acsil = Input.acceleration;
            GetComponent<Rigidbody2D>().velocity = new Vector3(acsil.x, 0f, 0f);
        }
    }
}

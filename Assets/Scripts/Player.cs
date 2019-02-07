using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    
    //Vector4 red = new Vector4(1,0,0,1);
   // Vector4 yellow = new Vector4(1, 0.92f, 0.016f, 1);
    public Text score;
    
    public Sprite [] s = new Sprite[10];
    public int check = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Level")
        {
            Statics.game = false;
            Debug.Log("Проиграл");
            GetComponent<SpriteRenderer>().material.color = new Vector4(0, 0, 0, 0);
        }

    }
    private void Start()
    {
        InvokeRepeating("ChangeColor", 10, 10);
    }
    private void Update()
    {
        score.text = Statics.score.ToString();
        if (!Statics.game)
        {
            GetComponent<SpriteRenderer>().material.color = new Vector4(UnityEngine.Random.Range(0f, 0.5f), UnityEngine.Random.Range(0f, 0.5f), UnityEngine.Random.Range(0f, 0.5f), 1);
        }

    }
    //void ChangeColors()
    //{
    //    Debug.Log("Random =    "+ UnityEngine.Random.Range(0f,1f).ToString());
    //    GetComponent<SpriteRenderer>().material.color = new Vector4(UnityEngine.Random.Range(0f,1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), 1);
    //}
    void ChangeColor()
    {
        System.Random rand = new System.Random();
        int x;
        do
        {
            x = rand.Next(0, 9);
        } while (x == check);
        check = x;
        GetComponent<SpriteRenderer>().sprite = s[x];
    }

}

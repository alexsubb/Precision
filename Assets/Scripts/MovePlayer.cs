using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MovePlayer : MonoBehaviour {

    public Transform player;
    [SerializeField]
    private float speed = 10f;
    private float score;
    public int Level;
    private void Start()
    {
        score = 0;
        Level = 0;
    }
    private void Update()
    {
        if (player.position.y <= -5.54f)
        {
            score++;
            player.position = Vector2.MoveTowards(player.position, new Vector2(0f, 6f), speed * Time.deltaTime);
        }
    }
    private void OnMouseDrag()
    {
        if (!Statics.acsilControl)
        {
            if (Statics.game)
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (mousePos.x > 2.95f)
                {
                    mousePos.x = 2.95f;
                }
                if (mousePos.x < -2.95f)
                {
                    mousePos.x = -2.95f;
                }
                player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y), speed * Time.deltaTime);
            }
            }
    }
}

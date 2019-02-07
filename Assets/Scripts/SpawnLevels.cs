using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLevels : MonoBehaviour {
    public List<GameObject> Levels;
   
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (Statics.game && Statics.score < 19)
        {         
            int i = Random.Range(0, Levels.Count);
            Instantiate(Levels[i], new Vector2(Random.Range(-6.6f, -2.15f), -6f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        while (Statics.game && (Statics.score >= 19 && Statics.score<39))
        {
         
        }
        while (Statics.game && (Statics.score >= 39 && Statics.score < 59))
        {

        }
        while (Statics.game && (Statics.score >= 59 && Statics.score < 79))
        {

        }
        while (Statics.game && (Statics.score >= 79 && Statics.score < 99))
        {

        }
        while (Statics.game && Statics.score >= 99)
        {

        }
    }
}

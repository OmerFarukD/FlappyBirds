using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public BirdMove BirdScript;

    public GameObject Borular;

    public float height;


    public float time;

    void Start()
    {
        StartCoroutine(SpawnBorular(time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator SpawnBorular(float time)
    {
        while (BirdScript.isDead == false)
        {
            Instantiate(Borular, new Vector3(1,Random.Range(-height,height),0),Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }


}

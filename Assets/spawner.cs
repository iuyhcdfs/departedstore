using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        frame = 0;
    }

    int frame;
    // Update is called once per frame
    void FixedUpdate()
    {
        frame++;
        if(frame == 47){
            frame = 0;
            GameObject.Instantiate(prefab, new Vector3(Random.Range(-20, 20),1f,Random.Range(-20, 20)),Quaternion.identity);
        }
    }
}

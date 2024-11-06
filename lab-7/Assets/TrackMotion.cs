using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMotion : MonoBehaviour
{
    public Material mat;
    public float speed = 10;
    float curAngle = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        mat.SetFloat("_Speed", speed);
        mat.SetVector("_TransformPos", transform.position);
        mat.SetFloat("_CurAngle", curAngle);
        curAngle += speed * Time.deltaTime;
    }


}

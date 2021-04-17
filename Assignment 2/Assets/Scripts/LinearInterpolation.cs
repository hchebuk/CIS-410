using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    public Transform mygoal;
    public float traveltime;
    float timer;
    Vector3 mystartpos;
    Vector3 goalpos;
    // Start is called before the first frame update
    void Start()
    {
        mystartpos = transform.position;
        goalpos = mygoal.position;
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;
      transform.position = Vector3.Lerp(mystartpos, goalpos, timer/traveltime);
    }
}

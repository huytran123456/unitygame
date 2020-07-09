using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooter : MonoBehaviour
{
    public GameObject dart;
    private float timestamp = 0f;
    public float spawnrate = 1f;
    public int capacity = 10;
    public Text capacityUI;
    // Start is called before the first frame update
    void Start()
    {
        capacityUI.text = "CAPACITY:" + capacity.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time>= timestamp && capacity>0)
        {
            Instantiate(dart, transform.position, Quaternion.identity);
            timestamp = Time.time + spawnrate;
            capacity--;
            capacityUI.text = "CAPACITY:" + capacity.ToString();
        }
    }
}

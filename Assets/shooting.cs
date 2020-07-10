using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooting : MonoBehaviour
{
    [SerializeField]
    public GameObject pro;

    [SerializeField]
    private Transform barr;


    private float reload=0.5f;
    public float timestamp = 0f;
    public int capacity = 100;
    public Text capacityUI;
    public Vector3 mousepos;
   // private float dr;
 //   private Vector2 direct;
    // Start is called before the first frame update
    void Start()
    {
        capacityUI.text = "CAPACITY:" + capacity.ToString();
        //dart=reuse
    }

    // Update is called once per frame
    void Update()
    {
        //  mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Vector3 worldpos = Input.mousePosition;
        // worldpos.z = Camera.main.nearClipPlane;

        //  mousepos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
       // transform.Rotate( 0, 0, dr );
        if (Input.GetMouseButtonDown(0) && Time.time >= timestamp && capacity > 0)
        {
            FireDart();
           // Vector3 worldpos = Input.mousePosition;
           // worldpos.z = Camera.main.nearClipPlane;
            
          //  mousepos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
          //  direct=(mousepos-transform.position).normalized;
            //  transform.up = direct;
            
        }
        void FireDart()
        {
            GameObject dart = Instantiate(pro, barr.position, barr.rotation);
            //    dart.transform.position = transform.position + mousepos;
            dart.GetComponent<Rigidbody2D>().velocity = barr.up * 20f;
            //   dd.rotation = mousepos;
            // dd.velocity =new Vector2( mousepos.x * 40*Time.fixedDeltaTime, mousepos.y * 40 * Time.fixedDeltaTime);
            //  dd.velocity = transform.up*20;
            timestamp = Time.time + reload;
            capacity--;
            capacityUI.text = "CAPACITY:" + capacity.ToString();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookmouse : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector2 direct = -Camera.main.WorldToScreenPoint(transform.position) + Input.mousePosition;
        //   var dr = Mathf.Atan2(direct.x, direct.y) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.AngleAxis(dr, Vector3.forward);
        transform.up = direct.normalized;
    }
}

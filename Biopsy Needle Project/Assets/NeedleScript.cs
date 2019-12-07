using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleScript : MonoBehaviour
{

    public float height;

    Vector3 parentPos;
    // Start is called before the first frame update
    void Start()
    {
        parentPos = this.gameObject.transform.parent.position;
       
        Debug.Log(this.gameObject.transform.position);
        Debug.Log(this.gameObject.transform.parent.position);
    }

    // Update is called once per frame
    void Update()
    {
        


        Vector3 newPos = new Vector3(parentPos.x, parentPos.y + height, parentPos.z);
        this.gameObject.transform.position = newPos;
    }
}

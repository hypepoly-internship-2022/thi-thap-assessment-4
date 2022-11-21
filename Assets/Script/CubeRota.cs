
using UnityEngine;

public class CubeRota : MonoBehaviour
{
     public float speedH = 2f;
    private float yawH = 0.0f;
  
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0)){
            if(Mathf.Abs(yawH) < 40){
                yawH -= speedH * Input.GetAxis("Mouse X");

                Debug.Log("yawH: " + yawH);
            }
            else{
                if(yawH < 0){
                    yawH = -39f;
                } else {
                    yawH = 39f;
                }
            }
        }

        transform.eulerAngles = new Vector3(0.0f, yawH, 0.0f); 
    }
}

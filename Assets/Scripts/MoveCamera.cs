using UnityEngine;

public class MoveCamera : MonoBehaviour
{




    bool moving = false;
    Vector3 lastMouse;
    Vector2 difMouse;
    public Transform cameraRef;

    void Update()
    {
        if (moving == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (!Physics.Raycast(ray,out hit))
                {
                    moving=true;
                    lastMouse=Input.mousePosition;
                    //Debug.Log("down_moving");
                }
            }
        }
        else
        {
            if (!(Input.mousePosition == lastMouse))
            {
                if (Input.mousePosition.x > lastMouse.x)
                {
                    cameraRef.transform.Translate(Vector3.right * Time.deltaTime * 13f);
                    cameraRef.transform.LookAt(transform);
                }
                else
                {
                    cameraRef.transform.Translate(Vector3.left * Time.deltaTime * 13f);
                    cameraRef.transform.LookAt(transform);
                }
                difMouse = lastMouse - Input.mousePosition;
                /*cameraRef.transform.RotateAround(/*transform.eulerAngles, new Vector3 (1f,1f,1f), 3.5f);*/
                lastMouse = Input.mousePosition;
            }
            if (Input.GetMouseButtonUp(0))
            {
                moving=false;
                //Debug.Log("up_stopmoving");
            }
        }
    }







}

using UnityEngine;
using System.Collections;
 
public class Input_ts : MonoBehaviour {

    public float speed;
    public float otationSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        #region//鼠标输入
        //按下鼠标指定键时，返回true。每帧都返回
        //Input.GetMouseButton();

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("GetMouseButton(0)");
        //}
        //if (Input.GetMouseButton(1))
        //{
        //    Debug.Log("GetMouseButton(1)");
        //}
        //if (Input.GetMouseButton(2))
        //{
        //    Debug.Log("GetMouseButton(2)");
        //}


        //按下鼠标指定键时返回true，只在第一帧返回
        //Input.GetMouseButtonDown();

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("GetMouseButtonDown(0)");
        //}


        //松开鼠标指定键时返回true，只在第一帧返回
        //Input.GetMouseButtonUp();

        //if (Input.GetMouseButtonUp(1))
        //{
        //    Debug.Log("GetMouseButtonUp(1)");
        //}
        #endregion

        #region//键盘输入
        //按下键盘指定键时返回true，一直返回
        //Input.GetKey();

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    Debug.Log("GetKey(KeyCode.UpArrow)");
        //}

        //按下键盘指定键时返回true，只在第一帧返回
        //Input.GetKeyDown();

        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    Debug.Log("GetKeyDown(KeyCode.UpArrow)");
        //}


        //按下键盘指定键时返回true，只在第一帧返回
        //Input.GetKeyUp();

        //if (Input.GetKeyUp(KeyCode.UpArrow))
        //{
        //    Debug.Log("GetKeyUp(KeyCode.UpArrow)");
        //}
        #endregion

        #region//获取虚拟轴输入，Horizontal，Vertical，
        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");
        //transform.Translate(x*Time.deltaTime*3,0,0);
        //transform.Translate(0,0,z*Time.deltaTime*3);
        #endregion
        
    }
}

using UnityEngine;
using System.Collections;

public class Component_ts : MonoBehaviour {

    public MeshCollider meshCollider;

	// Use this for initialization
	void Start () {
        meshCollider = gameObject.GetComponent<MeshCollider>();
        if (meshCollider!=null)
        {

        }
        else
        {
            Debug.LogError("组件获取失败");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnMouseDown()
    {
        //属性
        #region
        
        //获取与组件联系的游戏物体
        //meshCollider.gameObject;
        //meshCollider.gameObject.SetActive(false);

        //获取组件所在物体的tag
        //Debug.Log(meshCollider.tag);

        //通过组件获取游戏物体上的transform
        //meshCollider.transform.position = new Vector3(0,2,0);



        //meshCollider.BroadcastMessage();
        
        //meshCollider.CompareTag();
        //meshCollider.GetComponent<>();


        //meshCollider.GetComponentInParent<>();
        //meshCollider.GetComponentInParent<>();
        //meshCollider.GetComponentsInChildren<>();
        //meshCollider.GetComponentsInParent<>();
        //meshCollider.SendMessage();
        //meshCollider.SendMessageUpwards();


        //meshCollider.hideFlags = HideFlags.HideInHierarchy;
        //Debug.Log("meshCollider.hideFlags = HideFlags.HideInHierarchy");
        //meshCollider.hideFlags = HideFlags.HideInInspector ;



        //静态方法
        //Destroy();
        //DestroyImmediate();
        //DontDestroyOnLoad();
        //FindObjectOfType();
        //FindObjectsOfType();
        

        #region//实例化一个游戏物体
        //实例化一个游戏物体
        //GameObject.Instantiate(gameObject,new Vector3(0,2,0),transform.rotation);

        #endregion






        #endregion

    }
}

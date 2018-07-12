using UnityEngine;
using System.Collections;

public class GameObject_ts : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnMouseDown()
    {

        #region//GameObject类里的属性（Properties）

        //gameObject.activeInHierarchy;
        #region//该游戏物体在场景中是否是激活状态
        //该游戏物体在场景中是否是激活状态，
        //改变游戏物体激活状态，go.SetActive(bool a),
        //SetActive()只改变游戏物体自身的状体，不改变组件的激活状态
        //改变组件的激活状态，go.GetComponent<组件>().enable=(bool a)
        //Debug.Log("activeInHierarchy:"+gameObject.activeInHierarchy);
        #endregion

        //gameObject.activeSelf;
        #region//游戏物体自身的激活状态
        //游戏物体自身的激活状态，
        //如果该游戏物体为子物体，当父物体未被激活时，是不显示的，
        //但是自身的激活状态是激活的，只不过不会在场景中显示

        //Debug.Log("activeInHierarchy:"+gameObject.activeInHierarchy);
        //Debug.Log("activeSelf:" + gameObject.activeSelf);

        #endregion

        //gameObject.isStatic;
        #region//游戏物体是否是静态的
        //游戏物体是否是静态的，
        //改变该状态，go.isStatic=(bool a)
        //Debug.Log("isStatic:" + gameObject.isStatic);
        #endregion

        //gameObject.layer;
        #region//游戏物体的层
        //游戏物体的层，
        //改变游戏物体的层，gameObject.layer=(int [1-31])
        //Debug.Log("layer:" + gameObject.layer);
        #endregion

        //gameObject.scene;
        #region//当前游戏物体所在的场景
        //当前游戏物体所在的场景
        //Debug.Log("scene:" + gameObject.scene.name);
        #endregion

        //gameObject.tag;
        #region//游戏物体的标签，方便查找
        //游戏物体的标签，方便查找
        //改变游戏物体的标签，go.tag="标签名字"
        //Debug.Log("tag:" + gameObject.tag);
        #endregion

        //gameObject.transform;
        #region//获取游戏物体的Transform组件
        //获取游戏物体的Transform组件，其他组件不能用点（.）获取
        //获取游戏物体上的其他组件，gameObject.GetComponent<组件>()
        //Debug.Log("transform:"+gameObject.transform);
        #endregion

        //gameObject.hideFlags = HideFlags.HideInHierarchy;
        #region//游戏物体的隐藏

        //游戏物体在层级面板中隐藏，场景下不可选中
        //gameObject.hideFlags = HideFlags.HideInHierarchy;

        //游戏物体的所有组件在检视面板中隐藏
        //gameObject.hideFlags = HideFlags.HideInInspector;

        #endregion

        //gameObject.name;
        #region//游戏物体的名字
        //gameObject.name;

        //Debug.Log("name:"+gameObject.name);

        //gameObject.name = "wwww";

        //Debug.Log("name:"+gameObject.name);
        #endregion

        //GameObject.Instantiate();
        #region//实例化一个游戏物体

        //实例化一个游戏物体
        //GameObject.Instantiate(要实例化的模型,位置,Quaternion.Euler【欧拉角】);

        #endregion


        #endregion
    }
}

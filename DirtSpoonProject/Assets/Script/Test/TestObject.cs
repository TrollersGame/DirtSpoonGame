using UnityEngine;
using System.Collections;

public class TestObject : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Debug.Log("프로그램 시작");
        if (GameManager.Instance.CheckLive())
            Debug.Log("생성 호출 끝");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            GameManager.Instance.SceneChangeMgr.ChangeScene(1);
        }
	}
}

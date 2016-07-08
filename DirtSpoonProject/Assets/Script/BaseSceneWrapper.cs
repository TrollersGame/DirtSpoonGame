using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
/// <summary>
/// Scene 랩퍼 클래스
/// Scene전환과 Scene 내부 오브젝트 버퍼링에 사용
/// </summary>
public class BaseSceneWrapper  {

    private int sceneID = 0;
    public int SceneID
    {
        get
        {
            return sceneID;
        }
    }
    /// <summary>
    /// Object 버퍼 
    /// 현재 ref 참조형이기에 항상 메모리 잡고있어야됨
    /// 작업에따라서 Struct같은 값형식으로 바꿔야될수도 있음
    /// </summary>
    public List<BaseObject> LObjectList;
    
    /// <summary>
    /// 씬 전환은 최종적으로 여기서
    /// Manager에서 호출됨
    /// </summary>
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneID);
    }
    /// <summary>
    /// 생성자
    /// </summary>
    /// <param name="ID">Scene의 인덱스</param>
    public BaseSceneWrapper(int ID)
    {
        sceneID = ID;
    }
}
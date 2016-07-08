using UnityEngine;
using System.Collections;
/// <summary>
/// Game 전체를 관리하는 Manager Singleton Class
/// </summary>
public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;
    public static GameManager Instance
    {
        get
        {
            //찾아본다
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;
            }

            //그래도 없으면 생성
            if (_instance == null)
            {
                GameObject obj = new GameObject("GameManagerObj");
                _instance = obj.AddComponent(typeof(GameManager)) as GameManager;
                DontDestroyOnLoad(obj);
                Debug.Log("매니저 생성");
            }
            return _instance;
        }
    }
    /// <summary>
    /// 씬 관리 매니져
    /// </summary>
    private SceneChangeManager _scenechangeMgr;
    public SceneChangeManager SceneChangeMgr
    {
        get
        {
            return _scenechangeMgr;
        }
    }



    public void Awake()
    {
        if (_instance != null)
        {
            Destroy(this.gameObject);
            Debug.Log("중복 매니저 삭제");
            return;
        }
    }
    /// <summary>
    /// 각종 매니저 생성
    /// 씬 내부 오브젝트는 생성 보장 안될듯
    /// </summary>
    public GameManager()
    {
        _scenechangeMgr = new SceneChangeManager();
        _scenechangeMgr.InitManager();
    }
    /// <summary>
    /// 테스트용 , 매니저가 살아있는지를 반환
    /// </summary>
	public bool CheckLive()
    {
        if (_instance) return true;
        return false;
    }
}

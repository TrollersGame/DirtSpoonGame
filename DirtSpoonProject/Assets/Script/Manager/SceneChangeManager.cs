using UnityEngine;
using System.Collections;

public class SceneChangeManager {

    private int CurrentSceneIndex;

    /// <summary>
    /// Scene wrapper 리스트로 게임 시작시 초기화 되서 계속 사용
    /// 사이즈가 절대 바뀔일 없으므로 배열로 사용
    /// </summary>
    private BaseSceneWrapper[] SceneArray;
    public void InitManager()
    {
        /// 임시 코드 Scene맥스 수치 미리 지정
        int TempSceneMaxCount = 5;
        SceneArray = new BaseSceneWrapper[TempSceneMaxCount];

        /// TestCode
        BaseSceneWrapper FirstScene = new BaseSceneWrapper(0); // 0번 씬
        SceneArray[0] = FirstScene;
        BaseSceneWrapper SecondScene = new BaseSceneWrapper(1); // 1번 씬
        SceneArray[1] = SecondScene;
        Debug.Log("SceneChangeManager 초기화 완료");
    }
    public void ChangeScene(int SceneID)
    {
        CurrentSceneIndex = SceneID;
        SceneArray[SceneID].ChangeScene();
        Debug.Log("Scene전환 성공");
    }

}

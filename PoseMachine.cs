/*
 * ゲームの機動を一時中断するスクリプト
 */

using UnityEngine;


public class PoseMachine : MonoBehaviour
{
    //ポーズの切り替え
    [SerializeField] bool poseActive = false;

    //ポーズを機動させるボタンのキー
    [SerializeField] KeyCode keyCode = KeyCode.None;

    void Update()
    {
        PoseActive();
    }

    //ポーズ機能実装
    void PoseActive()
    {
        //指定したキーを押す
        if (Input.GetKeyDown(keyCode))
        {
            //時間が止まる
            if (poseActive == true)
            {
                poseActive = false;
                Time.timeScale = 1;
            }
            //時間が動き出す
            else
            {
                poseActive = true;
                Time.timeScale = 0;
            }
        }
    }
}

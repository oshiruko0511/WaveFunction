/*
 * スクリーンショットを撮るスクリプト
 */
using UnityEngine;

public class ScreenShotMachine : MonoBehaviour 
{
    public string saveName;

	//スクリーンショットを機動させるボタンのキー
	[SerializeField] KeyCode capture_PNG_Key = KeyCode.None;
	[SerializeField] KeyCode capture_JPG_Key = KeyCode.None;

	void Update () 
	{
		//透過なしのPNG
		if (Input.GetKeyDown(capture_PNG_Key))
		{ 
			ScreenCapture.CaptureScreenshot("Assets/" + saveName + ".png", 1);
			Debug.Log("Normal Capture End・・・PNG");
		}

		//透過なしのJPG
		if (Input.GetKeyDown(capture_JPG_Key))
		{
			ScreenCapture.CaptureScreenshot("Assets/" + saveName + ".jpg", 1);
			Debug.Log("Normal Capture End・・・JPG");
		}
	}
}

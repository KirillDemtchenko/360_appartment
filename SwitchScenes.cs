using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScenes : MonoBehaviour
{
    public string FirstScene = "FirstScene";
		public string SecondScene = "SecondScene";
    Scene m_Scene;

    void Update()
    {
        m_Scene = SceneManager.GetActiveScene();

				if (Input.GetKeyDown (KeyCode.Space) || Input.touchCount == 1) {
					if (m_Scene.name == FirstScene)
					{
							SceneManager.LoadScene(SecondScene);
					}
	
					if (m_Scene.name == SecondScene)
					{
							SceneManager.LoadScene(FirstScene);
					}
				}
					
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class ManagerScene : MonoBehaviour
{
    
    public TextMeshProUGUI txtSceneName;
    public string[] ListScenes;


    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("NAME THE SCENE: " + scene.name);
        txtSceneName.text = scene.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallScene1()
    {
        
        SceneManager.LoadScene(ListScenes[0]);
    }

    public void CallScene2()
    {
        SceneManager.LoadScene(ListScenes[1]);
    }

    public void CallScene3()
    {
        SceneManager.LoadScene(ListScenes[2]);
    }

    public void CallScene4()
    {
        SceneManager.LoadScene(ListScenes[3]);
    }

    

}

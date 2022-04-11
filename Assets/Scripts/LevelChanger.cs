using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    public TextMeshProUGUI txtSceneName;
    public Animator animator;

    private int levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        int y = SceneManager.GetActiveScene().buildIndex;
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("NAME THE SCENE: " + scene.name);
        Debug.Log("INDEX: " + y);
        txtSceneName.text = scene.name;
        animator = GetComponent<Animator>();
    }

    public void FadeToNextLevel_1()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToNextLevel_2()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToNextLevel_3()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToNextLevel_0()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex - 3); 
    }

    public void FadeToLevel(int levelString)
    {
        levelToLoad = levelString;
        animator.SetTrigger("FadeOut");
        
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }



   
}

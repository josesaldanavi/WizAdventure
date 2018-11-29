using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
    public string sceneName;
    public Animator transition_canvas;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(change());
        }
	}

    IEnumerator change()
    {
        transition_canvas.SetTrigger("end");
        yield return new WaitForSeconds(1.3f);
        SceneManager.LoadScene(sceneName);
    }
}

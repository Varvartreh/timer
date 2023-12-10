using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float minute;
    public float seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds-= Time.deltaTime;
        print("Осталось"+ minute+ ":" + seconds);
        if (seconds<=0){
            minute-=1;
            if(minute<=0){
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
            else{
                seconds+=60;
            }
        }
    }
}

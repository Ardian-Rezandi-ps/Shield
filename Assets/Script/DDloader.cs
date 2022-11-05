using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DDloader : MonoBehaviour
{
    public static DDloader instance;
    [SerializeField]bool isSekaliLoad=true;
    
  /// <summary>
  /// Awake is called when the script instance is being loaded.
  /// </summary>
  private void Awake()
  {
    instance=this;
    DontDestroyOnLoad(this.gameObject);
    if(isSekaliLoad){
        SceneManager.LoadSceneAsync(1);
        isSekaliLoad=false;
    }
  }
  

  
}

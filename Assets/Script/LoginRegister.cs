using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoginRegister : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField emailif, passwordif,alamatif,emailifLogin, passwordifLogin;
    public Text errortx;
    public string namaSceneNext;
    public GameObject uiMenu,uiLogin,uiRegister;
    private void Start() {
        uiMenu.SetActive(true);
        uiLogin.SetActive(false);
       uiRegister.SetActive(false);
    }
   public void DaftarPeserta(){
       //untuk mengisi data di dalam game(save game data)
        //untuk mengisi data email dan password

       PlayerPrefs.SetString(emailif.text,passwordif.text);
       //untuk mengisi alamat dari akun email(adress)
        PlayerPrefs.SetString("address"+emailif.text, alamatif.text);
        uiMenu.SetActive(true);
        uiLogin.SetActive(false);
       uiRegister.SetActive(false);
   }
   public void LoginPeserta(){
       //haskey=untuk mengecek apakah email sudah terdaftar?
        if(PlayerPrefs.HasKey(emailifLogin.text)){
            //kondisi email terdaftar melihat passsword dari email input login
            string pass= PlayerPrefs.GetString(emailifLogin.text);
            //apakah password  saved di game sama dengan input password?
            if(pass== passwordifLogin.text){
                SceneManager.LoadSceneAsync(namaSceneNext);
            }else{
                //password salah
                errortx.text="Password salah";
            }
        }else{
            errortx.text="Email tidak terdaftar";
            //kondisi email tidak terdaftar
        }
     
   }
}

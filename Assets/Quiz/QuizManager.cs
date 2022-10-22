using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class QuizManager : MonoBehaviour
{
   
    public int indexJawabanBenar;
    public SoalJawab[] kumpulanSoalSkrip;
    public TextMeshProUGUI textSoal;
    public List<TextMeshProUGUI> textJawaban;
    public GameObject uiPenjelasan,uiKoreksi, uiSkor;
    public TextMeshProUGUI textScore, pointx1,pointx2,timetxskor,acctx,korektx,salahBenartx,deskPenjelasantx;
    public Image imgPenjelasan;
    
    public static int score = 0,correcrt=0;
    public static int nomorSoal = 0;    
    //public static int maxSoal = 3;
     public int indekBenar;
    public Image timerImg;
    public GameObject panelWin;
    public float timerTime=0,timerMax=0,decreasetime=0.1f,timeUsed=0,timecumulative=0;
    

    private void Update() {
        if(Time.time >= timerTime+1){
            timeUsed++;
             timecumulative ++;
            timerImg.fillAmount -= decreasetime;
            timerTime=Time.time;
            if(timerImg.fillAmount <=0){
                WaktuHabis();
            }
        }
       
        
    }
    public void WaktuHabis(){
        timerImg.fillAmount=0;
    }
    void Start()
    {

       decreasetime= 1/timerMax;
   
      LoadSoal();
    }
    public void NextSoal(){
        nomorSoal++;
        textScore.text=""+score+" point.";
        pointx1.text= ""+score+" point.";   
          pointx2.text= ""+score+" point.";
          timeUsed=0;
        if(nomorSoal< kumpulanSoalSkrip.Length){
            LoadSoal();
        }else{
            uiSkor.SetActive(true);
            print("Selesai");
        }
    }
    public void LoadSoal(){
         timerTime=Time.time;
        
            timerImg.fillAmount = 1;

            deskPenjelasantx.text= kumpulanSoalSkrip[nomorSoal].deskPenjelasan;
            imgPenjelasan.sprite= kumpulanSoalSkrip[nomorSoal].gambarPenjelasan;
        textSoal.text= kumpulanSoalSkrip[nomorSoal].soal;
        timetxskor.text = ""+timecumulative+" detik.";
        korektx.text= ""+correcrt+" Correct.";
        float accurate= correcrt/kumpulanSoalSkrip.Length;
        acctx.text= ""+accurate+" %";


        for(int i=0;i<kumpulanSoalSkrip[nomorSoal].jawaban.Length;i++){
            textJawaban[i].text= kumpulanSoalSkrip[nomorSoal].jawaban[i];
          
        }
        indekBenar= kumpulanSoalSkrip[nomorSoal].indekBenar;
    }
    public void ValidasiJawaban(int indexJawabanPlayer)
    {
        if(indexJawabanPlayer == indexJawabanBenar){
            score += 100;
            correcrt++;
          salahBenartx.text="Jawaban Benar.";
        }
        else {
            score -= 0;
             salahBenartx.text="Jawaban Salah.";
        }

       
           uiKoreksi.SetActive(true);
      
    }

}

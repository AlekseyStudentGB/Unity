using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Calc : MonoBehaviour
{
    public Text ecran;
    int a = 0;
    int d  = 0;

    float b;
    
    public void Push1()
    {
        ecran.text += "1"; 
    }
    public void Push2()
    {
        ecran.text += "2"; 
    }
    public void Push3()
    {
        ecran.text += "3"; 
    }
    public void Push4()
    {
        ecran.text += "4"; 
    }
    public void Push5()
    {
        ecran.text += "5"; 
    }
    public void Push6()
    {
        ecran.text += "6"; 
    }
    public void Push7()
    {
        ecran.text += "7"; 
    }
    public void Push8()
    {
        ecran.text += "8"; 
    }
    public void Push9()
    {
        ecran.text += "9"; 
    }
    public void Push0()
    {
        ecran.text += "0"; 
    }
    public void PushRes()
    {
        b = int.Parse(ecran.text);
        if (d == 1){
            ecran.text =$"{a+b}";

        }
        if (d == 2){
            ecran.text =$"{a-b}";

        }
        if (d == 3){
            ecran.text =$"{a*b}";

        }
        if (d == 4){
            ecran.text =$"{a/b}";

        }
        if (ecran.text.Equals("666")){
            ecran.text = "666 число сатаны!";
        }
        a = 0;
        b = 0;
    }
    public void PushC()
    {
        ecran.text = "";
        d = 0;
        a = 0;
        b = 0;
    }
    public void PushPr()
    {
        if(d == 0)
        {
            a = int.Parse(ecran.text);
            ecran.text = ""; 
            d = 3; 
        }else{
            PushRes();
        } 
    }
     public void PushPl()
    {
        if(d == 0)
        {
            a = int.Parse(ecran.text);
            ecran.text = ""; 
            d = 1; 
        }else{
            PushRes();
        }
    
    }
    public void PushMin()
    {
         if(d == 0)
        {
            a = int.Parse(ecran.text);
            ecran.text = ""; 
            d = 2; 
        }else{
            PushRes();
        }
    }
    public void PushDe()
    {
         if(d == 0)
        {
            a = int.Parse(ecran.text);
            ecran.text = ""; 
            d = 4; 
        }else{
            PushRes();
        }
    }

}

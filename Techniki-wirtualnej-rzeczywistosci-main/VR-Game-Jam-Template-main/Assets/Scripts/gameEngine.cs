using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameEngine : MonoBehaviour
{
    int points;
    public TMP_Text tmp;
    public ParticleSystem ps;
    public ParticleSystem gp;

    public void addPoints(int points){
        if (points >= 1){
            this.points += points;
            ps.Play();
        }
        else{
            this.points -= 1;
            gp.Play();
        }
        Debug.Log("All: " + this.points);
        tmp.text = "points: " + this.points;
    }
}

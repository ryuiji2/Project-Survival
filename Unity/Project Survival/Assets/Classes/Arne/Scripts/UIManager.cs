//Made by Arne
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	//health test related stuff
	public float maxHP;
	public float health;
	private float healthPercentage;
	public float dmg;
	public Image healthBar;


	public KeyCode key;


	//sets some things ready
	void Awake () 
	{	
		maxHP = 100;
		health = maxHP;

	}
	//for testing purposes
	void Update () 
	{
		if(Input.GetKeyDown(key))
		{
			health -= dmg;
		}
		CheckHealth();
	}
	//checks health and updates ui
	public void CheckHealth ()
	{
		//get a percentage of health, because fillamount is between 1 and 0
		healthPercentage = health / maxHP;
		Debug.Log(healthPercentage);
		healthBar.fillAmount = healthPercentage;
		
	}
	//checks ammo and updates ui    	NOT MADE YET
	public void CheckAmmo () 
	{

	}
}

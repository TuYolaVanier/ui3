using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestinationLocation : MonoBehaviour
{
	List<string> Floor_1 = new List<string> {"Floor 1","101","102","103","104","106","107","108","109","110","112","113","114","115","116","117","118","119","120","121","122","123","124","125","126","127","128","129","130","131","132","133","134","Library","Cafeterium","Swimming Pool","Gym 1","Gym 2","Gym3","Gym 4"};
	List<string> Floor_2 = new List<string> {"Floor 2","201","202","203/205","204","206","207","208","209","210","211","212","213","214","215","216","217","218","219","220","221","222","223","224","226","Main Office","Guidance Office"};
	List<string> Floor_3 = new List<string> {"Floor 3","301","302","303","304","306","307","308","309","310","311","312","313","314","315","316","317","318","319","320","321","322","323","324","326","327","328","329","330","Science Office","Math Office"};

	public Dropdown dropdown1;
	public Dropdown dropdown2;
	public Dropdown dropdown3;
	public Text Selected_DRoom;
	public Text Confirmed_DRoom;

	void Dropdown_IndexChanged1(int index)
	{
		Selected_DRoom.text = Floor_1 [index];
	}

	public void Dropdown_IndexChanged2(int index)
	{
		Selected_DRoom.text = Floor_2 [index];
	}

	public void Dropdown_IndexChanged3(int index)
	{
		Selected_DRoom.text = Floor_3 [index];
	}

	void Start()
	{
		dropdown1.AddOptions (Floor_1);
		dropdown2.AddOptions (Floor_2);
		dropdown3.AddOptions (Floor_3);
	}

	public void Confirm_OnClick ()
	{
		Confirmed_DRoom.text = Selected_DRoom.text;
		SceneManager.LoadScene(0);
	}

	public void Washroom_Emergency ()
	{
		Confirmed_DRoom.text = "Washroom";
		SceneManager.LoadScene(0);
	}

	public string button_location;

	public void School_Map_Location_Match(string button_location)
	{
		Selected_DRoom.text = button_location;
	}
}

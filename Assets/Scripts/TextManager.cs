using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

	public GameObject popText;
	public GameObject popText2;
	public GameObject popText3;
	public GameObject popText4;

	void Start(){
	}

	public void setTextString(int stringNum){
		popText.SetActive (true);
		switch(stringNum){
		/*
		case 0:
			popText1.SetActive (true);
			break;
		case 1:
			popText2.SetActive (true);
			break;
		case 2:
			popText3.SetActive (true);
			break;
		case 3:
			popText4.SetActive (true);
			break;
			*/
		case 0:
			popText.GetComponent<Text>().text = "Vincent Van Gogh painted a total of five large";
			popText2.GetComponent<Text>().text = "canvases with sunflowers in a vase, with three";
			popText3.GetComponent<Text>().text = "shades of yellow and nothing else.";
			break;
		case 1:
			popText.GetComponent<Text>().text = "The opera singer Emilie Ambre was a neighbor of ";
			popText2.GetComponent<Text>().text = "Manet. She played the title role of George Bizet's";
			popText3.GetComponent<Text>().text = "Carmen which debuted in 1875.";
			break;
		case 2:
			//popText.GetComponent<Text>().text = "Founded in 1825 in Paris, CBG Mignot to this day ";
			//popText2.GetComponent<Text>().text = "continue the great tradition of lead soldiers ";
			//popText3.GetComponent<Text>().text = "for nearly two hundred years.";
			popText.GetComponent<Text>().text = "His work often contains a political message";
			popText2.GetComponent<Text>().text = "(often anti-war or anti-establishment)";
			popText3.GetComponent<Text>().text = "His work can be found all over the world";
			break;
		case 3:
			popText.GetComponent<Text>().text = "The picture was painted from the window of the ";
			popText2.GetComponent<Text>().text = "Folkestone Hotel in Boulogne. The steam ferry ";
			popText3.GetComponent<Text>().text = "carried passengers to Folkestone.";
			break;
		case 4:
			popText.GetComponent<Text>().text = "Over the course of his life, Cézanne painted more ";
			popText2.GetComponent<Text>().text = "than 270 still lifes featuring the Apple set among ";
			popText3.GetComponent<Text>().text = "his other favorite objects.";
			break;
			popText.GetComponent<Text>().text = "Hunting of migrant birds is still a national sport ";
			popText2.GetComponent<Text>().text = "in France and, since the days of the French ";
			popText3.GetComponent<Text>().text = "Revolution, is considered a citizen’s right.";
			break;
		case 6:
			popText.GetComponent<Text>().text = "In the 19th century, Easter was an occasion for ";
			popText2.GetComponent<Text>().text = "ladies to don their most fashionable bonnets and ";
			popText3.GetComponent<Text>().text = "were essential to celebrate as eggs and bunnies.";
			break;
		case 7:
			popText.GetComponent<Text>().text = "An ode to the Statue of Liberty.";
			popText2.GetComponent<Text>().text = "'I lift my lamp beside the golden door.'";
			popText3.GetComponent<Text>().text = "is the last line of Emma Lazarus’s poem.";
			break;
		case 8:
			popText.GetComponent<Text>().text = "The historical town of Gruyères has preserved its";
			popText2.GetComponent<Text>().text = "M Medieval character up until today. It gives ";
			popText3.GetComponent<Text>().text = "its name to Gruyère cheese.";
			break;
		case 9:
			popText.GetComponent<Text>().text = "L'Estaque, a scruffy fishing port northwest of ";
			popText2.GetComponent<Text>().text = "Marseilles, for over half a century was a magnet";
			popText3.GetComponent<Text>().text = " for a series of famous artists.";
			break;
		case 10:
			popText.GetComponent<Text>().text = "In 1899, Monet painted 12 works focusing on the ";
			popText2.GetComponent<Text>().text = "blue-green bridge. Twenty-five years later his ";
			popText3.GetComponent<Text>().text = "later works are more dense and loose.";
			break;
		case 11:
			popText.GetComponent<Text>().text = "There have been three US Navy ships to bear the ";
			popText2.GetComponent<Text>().text = "name Kearsrage. There have been six ships named ";
			popText3.GetComponent<Text>().text = "after the US state of Alabama.";
			break;
		case 12:
			popText.GetComponent<Text>().text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		case 13:
			popText.GetComponent<Text>().text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			break;
		}
	}
}

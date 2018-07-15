using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenController : MonoBehaviour {

	private static ScreenController instance;
	public static ScreenController Instance{get {return instance;}}

	public GameObject ImageTracker;

	public GameObject StartScreen;
	public GameObject Instruction1Screen;
	public GameObject Instruction2Screen;
	public GameObject RatingScreen;
	public GameObject InfoScreen;
	public GameObject NavBar;

	//
	public GameObject TextObj1;
	public GameObject TextObj2;
	public GameObject TextObj3;
	// 
	public GameObject checkObj01;
	public GameObject checkObj02;
	public GameObject checkObj03;
	public GameObject checkObj04;
	public GameObject checkObj05;
	public GameObject checkObj06;
	public GameObject checkObj07;
	public GameObject checkObj08;
	public GameObject checkObj09;
	public GameObject checkObj10;
	public GameObject checkObj11;
	public GameObject checkObj12;
	public GameObject checkObj13;
	public GameObject checkObj14;
	public GameObject checkObj15;
	public GameObject checkObj16;
	public GameObject checkObj17;
	public GameObject checkObj18;
	public GameObject checkObj19;
	public GameObject checkObj20;
	public GameObject checkObj21;
	public GameObject checkObj22;
	public GameObject checkObj23;
	public GameObject checkObj24;
	public GameObject checkObj25;
	public GameObject checkObj26;
	public GameObject checkObj27;
	public GameObject checkObj28;
	public GameObject checkObj29;
	public GameObject checkObj30;
	public GameObject checkObj31;
	public GameObject checkObj32;
	public GameObject checkObj33;
	public GameObject checkObj34;
	public GameObject checkObj35;
	public GameObject checkObj36;
	public GameObject checkObj37;
	public GameObject checkObj38;
	public GameObject checkObj39;
	public GameObject checkObj40;
	public GameObject checkObj41;
	public GameObject checkObj42;
	//
	private string currentTargetName;

	public void Start(){
		instance = this;
		checkObj01.SetActive (false);
		checkObj02.SetActive (false);
		checkObj03.SetActive (false);
		checkObj04.SetActive (false);
		checkObj05.SetActive (false);
		checkObj06.SetActive (false);
		checkObj07.SetActive (true);
		checkObj08.SetActive (false);
		checkObj09.SetActive (false);
		checkObj10.SetActive (false);
		checkObj11.SetActive (false);
		checkObj12.SetActive (false);
		checkObj13.SetActive (false);
		checkObj14.SetActive (false);
		checkObj15.SetActive (false);
		checkObj16.SetActive (false);
		checkObj17.SetActive (false);
		checkObj18.SetActive (false);
		checkObj19.SetActive (false);
		checkObj20.SetActive (false);
		//
		checkObj21.SetActive (false);
		checkObj22.SetActive (false);
		checkObj23.SetActive (false);
		checkObj24.SetActive (false);
		checkObj25.SetActive (false);
		checkObj26.SetActive (false);
		checkObj27.SetActive (false);
		checkObj28.SetActive (false);
		checkObj29.SetActive (false);
		checkObj30.SetActive (false);
		checkObj31.SetActive (false);
		checkObj32.SetActive (false);
		checkObj33.SetActive (false);
		checkObj34.SetActive (false);
		checkObj35.SetActive (false);
		checkObj36.SetActive (false);
		checkObj37.SetActive (false);
		checkObj38.SetActive (false);
		checkObj39.SetActive (false);
		checkObj40.SetActive (false);
		checkObj41.SetActive (false);
		checkObj42.SetActive (false);
	}

	public void StartButtonClick(){
		StartScreen.SetActive (false);
		NavBar.SetActive (true);
		//Instruction1Screen.SetActive (true);
		ImageTracker.SetActive (true);
	}

	public void CardButtonClick(){
		StartScreen.SetActive (true);
		NavBar.SetActive (false);
		//Instruction1Screen.SetActive (true);
		ImageTracker.SetActive (false);
	}

	public void QAButtonClick(){
		StartScreen.SetActive (true);
		NavBar.SetActive (false);
		ImageTracker.SetActive (false);
		//
		// checkObj35.SetActive (true);
		//
		switch (currentTargetName){
		case "DynamicWall":
			checkObj01.SetActive (true);
			break;
		case "CoasterRollers":
			checkObj02.SetActive (true);
			break;
		case "LogoGenerator":
			checkObj03.SetActive (true);
			break;
		case "HoopCurves":
			checkObj04.SetActive (true);
			break;
		case "LightGrooves":
			checkObj05.SetActive (true);
			break;
		case "TwistedThruway":
			checkObj06.SetActive (true);
			break;
		case "ShapesOfSpace":
			checkObj07.SetActive (true);
			break;
		case "HyperHyperboloid":
			checkObj08.SetActive (true);
			break;
		case "SeeingMath":
			checkObj09.SetActive (true);
			break;
		case "ForumlaMorph":
			checkObj10.SetActive (true);
			break;
		case "TracksOFGallileo":
			checkObj11.SetActive (true);
			break;
		case "Mathanaeum":
			checkObj12.SetActive (true);
			break;
		case "StructureStudio":
			checkObj13.SetActive (true);
			break;
		case "PolyPaint":
			checkObj14.SetActive (true);
			break;
		case "MotionScape":
			checkObj15.SetActive (true);
			break;
		case "PatternMesh":
			checkObj16.SetActive (true);
			break;
		case "MathFlash":
			checkObj17.SetActive (true);
			break;
		case "SquareWheeledTrike":
			checkObj18.SetActive (true);
			break;
		case "StringProduct":
			checkObj19.SetActive (true);
			checkObj33.SetActive (true);
			break;
		case "PatternPamts":
			checkObj20.SetActive (true);
			break;
			//
		case "3dDoodle":
			checkObj21.SetActive (true);
			break;
		case "BeaverRun":
			checkObj22.SetActive (true);
			break;
		case "FeedbackFractals":
			checkObj23.SetActive (true);
			break;
		case "EdgeFX":
			checkObj24.SetActive (true);
			break;
		case "HumanTree":
			checkObj25.SetActive (true);
			break;
		case "FindingFifteem":
			checkObj26.SetActive (true);
			break;
		case "EnigmaCafe":
			checkObj27.SetActive (true);
			break;
		case "MarbleMultiplier":
			checkObj28.SetActive (true);
			break;
		case "MindOverMeasure":
			checkObj29.SetActive (true);
			break;
		case "TwistNRoll":
			checkObj30.SetActive (true);
			break;
		case "RobotSwarm":
			checkObj31.SetActive (true);
			break;
		case "ShapeRanger":
			checkObj32.SetActive (true);
			break;
		case "SixthSense":
			checkObj33.SetActive (true);
			break;
			// -- double
		case "TesselationStation":
			checkObj35.SetActive (true);
			break;
		case "TimeTables":
			checkObj36.SetActive (true);
			break;
		case "RhythmsOfLife":
			checkObj37.SetActive (true);
			break;
		case "WallOfFire":
			checkObj38.SetActive (true);
			break;
		case "HarmonyOfTheSpheres":
			checkObj39.SetActive (true);
			break;
		case "WaterFrieze":
			checkObj40.SetActive (true);
			break;
		case "TileFactory":
			checkObj41.SetActive (true);
			break;
		case "MathSquare":
			checkObj42.SetActive (true);
			break;
			//
		}
	}

	public void SetTargetName(string targetName){
		currentTargetName = targetName;
	}

	public void Instuction1ButtonClick(){
		Instruction1Screen.SetActive (false);
		Instruction2Screen.SetActive (true);
	}

	public void Instuction2ButtonClick(){
		Instruction1Screen.SetActive (false);
		Instruction2Screen.SetActive (false);
		NavBar.SetActive (true);
		ImageTracker.SetActive (true);
	}

	public void ShowHelp(){
		ImageTracker.SetActive (false);
		RatingScreen.SetActive (false);
		NavBar.SetActive (false);
		InfoScreen.SetActive (false);
		Instruction1Screen.SetActive (true);
	}

	public void ShowInfo(int textNumber){
		InfoScreen.SetActive (true);
		NavBar.SetActive (false);
		switch (textNumber) {
		case 0:
			TextObj1.GetComponent<Text> ().text = "Vincent Van Gogh painted a total of five large";
			TextObj2.GetComponent<Text> ().text = "canvases with sunflowers in a vase, with three";
			TextObj3.GetComponent<Text> ().text = "shades of yellow and nothing else.";
			break;
		case 1:
			TextObj1.GetComponent<Text> ().text = "The opera singer Emilie Ambre was a neighbor of ";
			TextObj2.GetComponent<Text> ().text = "Manet. She played the title role of George Bizet's";
			TextObj3.GetComponent<Text> ().text = "Carmen which debuted in 1875.";
			break;
		case 2:
			//popText.GetComponent<Text>().text = "Founded in 1825 in Paris, CBG Mignot to this day ";
			//popText2.GetComponent<Text>().text = "continue the great tradition of lead soldiers ";
			//popText3.GetComponent<Text>().text = "for nearly two hundred years.";
			TextObj1.GetComponent<Text>().text = "His work often contains a political message";
			TextObj2.GetComponent<Text>().text = "(often anti-war or anti-establishment)";
			TextObj3.GetComponent<Text>().text = "His work can be found all over the world";
			break;
		case 3:
			//TextObj1.GetComponent<Text> ().text = "The picture was painted from the window of the ";
			//TextObj2.GetComponent<Text> ().text = "Folkestone Hotel in Boulogne. The steam ferry ";
			//TextObj3.GetComponent<Text> ().text = "carried passengers to Folkestone.";
			TextObj1.GetComponent<Text> ().text = "Tribute to the lead singer of The Ramones.";
			TextObj2.GetComponent<Text> ().text = "Joey Ramone  was inspired by Paul McCartney"; 
			TextObj3.GetComponent<Text> ().text = "who used the name 'Paul Ramon' to book hotels.";
			break;
		case 4:
			TextObj1.GetComponent<Text> ().text = "Over the course of his life, Cézanne painted more ";
			TextObj2.GetComponent<Text> ().text = "than 270 still lifes featuring the Apple set among ";
			TextObj3.GetComponent<Text> ().text = "his other favorite objects.";
			break;
		case 5:
			TextObj1.GetComponent<Text> ().text = "Hunting of migrant birds is still a national sport ";
			TextObj2.GetComponent<Text> ().text = "in France and, since the days of the French ";
			TextObj3.GetComponent<Text> ().text = "Revolution, is considered a citizen’s right.";
			break;
		case 6:
			TextObj1.GetComponent<Text> ().text = "In the 19th century, Easter was an occasion for ";
			TextObj2.GetComponent<Text> ().text = "ladies to don their most fashionable bonnets and ";
			TextObj3.GetComponent<Text> ().text = "were essential to celebrate as eggs and bunnies.";
			break;
		case 7:
			//TextObj1.GetComponent<Text> ().text = "In 1899, Cézanne ventured daily to paint Chateau ";
			//TextObj2.GetComponent<Text> ().text = "Noir, a recently constructed neo-Gothic castle ";
			//TextObj3.GetComponent<Text> ().text = "designed to mimic aged ruins, captivated him.";
			TextObj1.GetComponent<Text>().text = "An ode to the Statue of Liberty.";
			TextObj2.GetComponent<Text>().text = "'I lift my lamp beside the golden door.'";
			TextObj3.GetComponent<Text>().text = "is the last line of Emma Lazarus’s poem.";
			break;
		case 8:
			TextObj1.GetComponent<Text> ().text = "The historical town of Gruyères has preserved its";
			TextObj2.GetComponent<Text> ().text = "Medieval character up until today. It gives ";
			TextObj3.GetComponent<Text> ().text = "its name to Gruyère cheese.";
			break;
		case 9:
			TextObj1.GetComponent<Text> ().text = "L'Estaque, a scruffy fishing port northwest of ";
			TextObj2.GetComponent<Text> ().text = "Marseilles, for over half a century was a magnet";
			TextObj3.GetComponent<Text> ().text = "for a series of famous artists.";
			break;
		case 10:
			TextObj1.GetComponent<Text> ().text = "In 1899, Monet painted 12 works focusing on the ";
			TextObj2.GetComponent<Text> ().text = "blue-green bridge. Twenty-five years later his ";
			TextObj3.GetComponent<Text> ().text = "later works are more dense and loose.";
			break;
		case 11:
			TextObj1.GetComponent<Text> ().text = "There have been three US Navy ships to bear the ";
			TextObj2.GetComponent<Text> ().text = "name Kearsrage. There have been six ships named ";
			TextObj3.GetComponent<Text> ().text = "after the US state of Alabama.";
			break;
		}
	}

	public void HideInfo(){
		InfoScreen.SetActive (false);
		NavBar.SetActive (true);
	}

	public void RatingsScreenActive(){
		ImageTracker.SetActive (false);
		RatingScreen.SetActive (true);
		RatingScreen.GetComponent<StarManager> ().ClearStar ();
		NavBar.SetActive (false);
		InfoScreen.SetActive (false);
	}

	public void RatingsScreenInactive(){
		ImageTracker.SetActive (true);
		RatingScreen.SetActive (false);
		NavBar.SetActive (true);
		InfoScreen.SetActive (false);
	}


}

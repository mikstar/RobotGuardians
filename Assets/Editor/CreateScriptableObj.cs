using UnityEngine;
using System.Collections;
using UnityEditor;

public class CreateScriptableObj : MonoBehaviour {
	[MenuItem("Assets/Create/Robopart Arms")]
	public static void createRoboArm()
	{
		RobopartArm asset = ScriptableObject.CreateInstance<RobopartArm>();

		AssetDatabase.CreateAsset(asset,AssetDatabase.GetAssetPath(Selection.activeObject) + "/NewRoboArms.asset");
		AssetDatabase.SaveAssets();
	}

	[MenuItem("Assets/Create/Robopart Legs")]
	public static void createRoboLegs()
	{
		RobopartLegs asset = ScriptableObject.CreateInstance<RobopartLegs>();
		
		AssetDatabase.CreateAsset(asset,AssetDatabase.GetAssetPath(Selection.activeObject) + "/NewRoboLegs.asset");
		AssetDatabase.SaveAssets();
	}

	[MenuItem("Assets/Create/Robopart Head")]
	public static void createRoboHead()
	{
		RobopartHead asset = ScriptableObject.CreateInstance<RobopartHead>();
		
		AssetDatabase.CreateAsset(asset,AssetDatabase.GetAssetPath(Selection.activeObject) + "/NewRoboHead.asset");
		AssetDatabase.SaveAssets();
	}

	[MenuItem("Assets/Create/Robopart Body")]
	public static void createRoboBody()
	{
		RobopartBody asset = ScriptableObject.CreateInstance<RobopartBody>();
		
		AssetDatabase.CreateAsset(asset,AssetDatabase.GetAssetPath(Selection.activeObject) + "/NewRoboBody.asset");
		AssetDatabase.SaveAssets();
	}

	[MenuItem("Assets/Create/Roboblueprint")]
	public static void createRoboBlueprint()
	{
		RoboBlueprint asset = ScriptableObject.CreateInstance<RoboBlueprint>();
		
		AssetDatabase.CreateAsset(asset,AssetDatabase.GetAssetPath(Selection.activeObject) + "/NewRoboblueprint.asset");
		AssetDatabase.SaveAssets();
	}

}

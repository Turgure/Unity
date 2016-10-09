using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviourJ {
	public GameObject plane;
	public GameObject wallPrefab;
	public GameObject blockPrefab;
	public GameObject immotalBlockPrefab;
	public GameObject wall;
	public GameObject block;
	public GameObject immotalBlock;

	private GameObject clone;
	private int xMax = 17;
	private int zMax = 17;

	// Use this for initialization
	void Start() {
		int[,] mapData = new[,]{
			{ 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 },
			{ 9,0,2,2,2,2,0,2,2,0,0,2,0,2,2,0,2,2,9 },
			{ 9,0,1,0,1,2,1,0,1,0,1,0,1,0,1,2,1,0,9 },
			{ 9,0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0,9 },
			{ 9,0,1,0,1,2,1,0,1,2,1,2,1,0,1,0,1,0,9 },
			{ 9,0,0,0,0,2,0,0,0,2,0,2,0,0,0,0,0,0,9 },
			{ 9,0,1,0,1,2,1,0,1,2,1,2,1,0,1,0,1,0,9 },
			{ 9,0,0,0,0,2,2,2,2,2,2,2,0,2,0,0,0,0,9 },
			{ 9,0,1,0,1,0,1,0,1,2,1,0,1,2,1,0,1,0,9 },
			{ 9,0,0,0,0,0,0,0,0,2,0,0,0,2,2,2,2,0,9 },
			{ 9,2,1,0,1,0,1,0,1,2,1,0,1,2,1,0,1,2,9 },
			{ 9,2,0,0,0,0,0,0,0,2,0,0,0,2,0,0,0,2,9 },
			{ 9,2,1,0,1,0,1,0,1,2,1,0,1,2,1,0,1,2,9 },
			{ 9,2,0,2,0,0,0,0,0,2,0,0,0,0,2,2,2,2,9 },
			{ 9,2,1,2,1,0,1,0,1,2,1,0,1,0,1,0,1,0,9 },
			{ 9,2,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9 },
			{ 9,2,1,2,1,0,1,0,1,0,1,0,1,0,1,0,1,0,9 },
			{ 9,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9 },
			{ 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 } };

		plane.transform.position = new Vector3((mapData.GetLength(0) - 1) * 0.5f, -0.5f, (mapData.GetLength(1) - 1) * 0.5f);
		plane.transform.localScale = new Vector3(mapData.GetLength(0) * 0.1f, 1f, mapData.GetLength(1) * 0.1f);

		createMap(mapData);
	}

	// Update is called once per frame
	void Update() {

	}

	void createMap(int[,] mapData) {
		Object prefab = null;
		Transform parent = null;
		string tag = null;

		for(int x = 0; x < mapData.GetLength(0); ++x) {
			for(int z = 0; z < mapData.GetLength(1); ++z) {
				switch(mapData[x, z]) {
					case 0:
						prefab = null;
						parent = null;
						tag = null;
						break;
					case 1:
						prefab = immotalBlockPrefab;
						parent = immotalBlock.transform;
						tag = "ImmotalBlock";
						break;
					case 2:
						prefab = blockPrefab;
						parent = block.transform;
						tag = "Block";
						break;
					case 9:
						prefab = wallPrefab;
						parent = wall.transform;
						tag = "Wall";
						break;
					default:
						prefab = null;
						parent = null;
						tag = null;
						break;
				}
				if(prefab && parent) {
					clone = (GameObject)Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
					clone.transform.parent = parent;
					clone.gameObject.tag = tag;
				}
			}
		}
	}

	void createWall() {
		for(int x = 0; x <= xMax; ++x) {
			clone = (GameObject)Instantiate(wallPrefab, new Vector3(x, 0, 0), Quaternion.identity);
			clone.transform.parent = wall.transform;
			clone = (GameObject)Instantiate(wallPrefab, new Vector3(x, 0, zMax), Quaternion.identity);
			clone.transform.parent = wall.transform;
		}
		// 端はxで作ったので最初と最後は作らない
		for(int z = 1; z < zMax; ++z) {
			clone = (GameObject)Instantiate(wallPrefab, new Vector3(0, 0, z), Quaternion.identity);
			clone.transform.parent = wall.transform;
			clone = (GameObject)Instantiate(wallPrefab, new Vector3(xMax, 0, z), Quaternion.identity);
			clone.transform.parent = wall.transform;
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board {

    private int width;
    private int height;
    public float tileSize {get; private set;}
    private Tile[,] tiles;
    private Vector3 origin;

    public Board(int width, int height, float tileSize, Vector3 origin) {
        this.width = width;
        this.height = height;
        this.tileSize = tileSize;
        this.tiles = new Tile[width, height];
        this.origin = origin;

        for(int y = 0; y < tiles.GetLength(1); y++) {
            for(int x = 0; x < tiles.GetLength(0); x++) {
                tiles[x, y] = new Tile(this, x, y);

                Debug.DrawLine(GetScenePosition(x, y), GetScenePosition(x, y + 1), Color.white, 100f);
                Debug.DrawLine(GetScenePosition(x, y), GetScenePosition(x + 1, y), Color.white, 100f);
            }
        }

        Debug.DrawLine(GetScenePosition(0, height), GetScenePosition(width, height), Color.white, 100f);
        Debug.DrawLine(GetScenePosition(width, 0), GetScenePosition(width, height), Color.white, 100f);
    }

    private Vector3 GetScenePosition(int x, int y) {
        return new Vector3(x, y) * tileSize + origin;
    }

    private void GetBoardPosition(Vector3 scenePosition, out int x, out int y) {
        x = Mathf.FloorToInt((scenePosition - origin).x / tileSize);
        y = Mathf.FloorToInt((scenePosition - origin).y / tileSize);
    }

    private Tile GetTile(int x, int y) {
        if(x >= 0 && x < tiles.GetLength(0) && y >= 0 && y < tiles.GetLength(1)) {
            return tiles[x, y];
        } else {
            return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {

    private Board board;
    private int x;
    private int y;

    public Tile(Board board, int x, int y) {
        this.board = board;
        this.x = x;
        this.y = y;
    }

    private Vector3 GetScenePosition() {
        return new Vector3(x, y) * board.tileSize;
    }
}

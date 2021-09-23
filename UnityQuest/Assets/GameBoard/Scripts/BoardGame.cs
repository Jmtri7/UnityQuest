using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGame : MonoBehaviour {

    private Board board;

    private void Start() {
        board = new Board(4, 2, 10f, new Vector3(0, 0));
    }

    private void Update() {
        if(Input.GetMouseButtonDown(0)) {
            Vector3 scenePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public List<Bird> birds;
    public List<Pig> pigs;
    public static GameManager instance;

    private Vector3 originPos;//初始位置
    void Initialized() {
        for (int i = 0; i < birds.Count; i++) {
            //第一只鸟的Bird脚本激活,SpringJoint2D组件激活
            if (i == 0) {
                //将第一个小鸟的位置置为初始位置 
                birds[i].gameObject.transform.position = originPos;

                birds[i].enabled = true;
                birds[i].sj2d.enabled = true;
            }
            else {
                birds[i].enabled = false;
                birds[i].sj2d.enabled = false;
            }
        }
    }
    void Awake() {
        instance = this;
        //若场景的小鸟个数大于0,将索引0处的小鸟位置记录为初始位置
        if (birds.Count > 0) {
            originPos = birds[0].transform.position;
        }
    }
    // Start is called before the first frame update
    void Start() {
        Initialized();
    }

    // Update is called once per frame
    void Update() {

    }

    public void NextBird() {
        if (pigs.Count > 0) {
            if (birds.Count > 0) {
                //下一只鸟上弹弓架
                Initialized();
            }
            else {
                //defeat
            }
        }
        else {
            //win

        }
    }
}
﻿using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu]
public class CharacterStat : ScriptableObject
{
    public String Name;

    //TODO: Finish adding stats
    [SerializeField]
    private int HealthLeft;
    [SerializeField]
    private int HealthTotal;
    [SerializeField]
    private int Movement;

    public List<Card> Weapons;
    [SerializeField]
    private List<Card> Help;

    public SideType Side;

    public GameObject Model;

    public Color PieceColor;

    //Needs some type of effect script.



}

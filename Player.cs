using System;
using System.Collections.Generic;

public class Player {
    //general reference stuff
    private string inGameName;
    private string realName;
    private uint age;
    private string nationality; //isn't important BUT determintes language which is very important
    private List<PlayerLanguage> languages = new List<PlayerLanguage>; //generally 1 but can be 2 and sometimes 3

    //actually important stuff (well age is important too because it has a factor in a lot of things)...similar to nba2k, has a rating out of 100 + a final OVR
    private uint mechanics;  //bread and butter, basically the most important stat
    private uint experience; //younger players = less experience
    private uint utility;
    private uint gameSense;
    private uint comms;

    //below 2 will change throughout games
    private uint fatigue;  //gets worse and worse over time, affects all other stats. higher experience = less fatigue 
    private uint confidence; //affected by recent performances. higher experience = less confidence detriments
    private double mood; //how happy person is....how likely they are to want to play at the highest level/resign with team
    private string demeanor; //affects other teammates...for example vibey will influence others' confidence, while angry will be detrimental, etc.
    private bool isIGL;  //only 1 igl per team.... better gameSense + comms = better igl
    private string role; //super important, can be changed, also similar to 2K where u can put players on different positions

    private uint overallRating; //will calculate this later
    private uint potentialRating; //honestly don't wanna keep this given how different esports is, most esports players retire at like 30 anyway so i want it to be a lot more slower placed
    private uint scoutedRating; //what im thinking should replace POT




}
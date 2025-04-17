using System;

public class PlayerLanguage {
    private string pLang;
    private double fluency; //determines how fluent from 0.0 - 10.0 the player is...determines communication skills. english tends to be on it

    public PlayerLanguage() {
        pLang = "English";
        fluency = 10.0; //max fluency for english speaker...americans....
    }

    public PlayerLangugae(double fluency) {
        pLang = "English";
        fluency = this.fluency; //default to english, secondary language
    }

    public PlayerLanguage(string pLang) {
        this.pLang = pLang;
        fluency = 10.0; //non-native English speaker native language 
    }

    public PlayerLanguage(string pLang, double fluency) {
        this.pLang = pLang;
        this.fluency = fluency; //bilingual king/queen
    }
}

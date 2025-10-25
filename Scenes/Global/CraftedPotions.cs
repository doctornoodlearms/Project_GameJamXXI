namespace Scenes.Global;

public partial class CraftedPotions : Node{

    Array<string> potionList = new Array<string>();

    public static CraftedPotions Self;

    public override void _EnterTree(){

        Self = this;
    }

    public void AddPotion(string potionName){

        potionList.Add(potionName);
    }

    public void RemovePotion(string potionName){

        if(potionList.Contains(potionName)){

            potionList.Remove(potionName);
        }
    }

    public Array<string> GetPotions(){

        return potionList;
    }
}
using System;
using Definitions.Symptoms;

public partial class CustomerHandler:Node{

    public static CustomerHandler Self;

    Array<string> customerList = new Array<string>(){

        SymptomHeatStroke.Name, SymptomHypothermia.Name, SymptomSick.Name, SymptomStabbed.Name
    };

    public string CurrentCustomer;

    public override void _EnterTree(){

        Self = this;
    }

    public void LoadCustomer(){

        CurrentCustomer = customerList.PickRandom();
    }
}
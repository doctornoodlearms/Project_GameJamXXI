using System;
using Definitions.Customers;

public partial class CustomerHandler:Node{

    public static CustomerHandler Self;

    Array<string> customerList = new Array<string>(){

        Customer.Name
    };

    public string CurrentCustomer;

    public override void _EnterTree(){

        Self = this;
    }

    public void LoadCustomer(){

        CurrentCustomer = customerList.PickRandom();
    }
}
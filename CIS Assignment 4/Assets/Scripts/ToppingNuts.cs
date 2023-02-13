using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Cooper Denault)
 * (Donut)
 * (Assignment)
 * (allows nuts to be added as topping and change text)
 */


public class ToppingNuts : ToppingDecorator
{
    Donut donut;

    public ToppingNuts(Donut donut)
    {
        this.donut = donut;
    }

    public override string getDescription()
    {
        return donut.getDescription() + " with Nuts";
    }

    public override int getSugarAmount()
    {
        return donut.getSugarAmount() + 5;
    }
}

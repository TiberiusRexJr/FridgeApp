using System;
 namespace InterfacePractice
{
    public Interface IFridgeitem
    {
        //wires
        public string Name;
        public int UPC;

        //fucntions
        public string getFridgeItemName();
        public int getFridgeItemUPC();
        public List<NutrionalValues> getFridgeNutrionalVauleSummary(ModelFridgeItem fridgeItem);
    }
}
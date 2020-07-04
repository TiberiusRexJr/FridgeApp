using System;
 namespace FridgeApp.Interfaces
{
    public interface IFridgeitem
    {
       //wires
       //ignitors
       //functions
       /// <summary>IsExpired returns a list of <return> <c>IFridgeItem</c></return> objects, all of which are expired </summary>
       public List<IFridgeitem> IsExpiredDummy()
       {
           /* Makes a call to a  [DATABASE] to aqurie all current (FRIDGE ITEMS) (implies (-NEED DATABASE_CRUD_API-) RETURN TYPE
           WILL BE USED TO DISPLAY INFORMATION TO USER 
           DISPLAY IMPLIES USER DISPAYU, USER INTERFACE TO enable SPEIFIC fucntionality
           (model)-(-viewMODEL-)

           these FRIDGEITEMS are in a LIST<>
           CYCLE THROUGH each FRIDGEITEM OBJ and run  each OBJ's StrogeDdate property through a (--algorthim--)
           that compares the OBJ'S storageDate value "INITIAL" DATE of "FRIDGEPLACEMENT" aginst the FRIDEGITM OBJ's SCANNED ExpirationDate VALUE;
           IF the AMOUNT OF DAYS between INTITALPLACEMENTDATE and EXPIREATION_DATE is =2 or LESS but greateer then ZERO 
           
           (--FLAG SYSTEM--)
           [GREEN] DAYS_IN_BETWEEN=5 OR GREATER THEN 5
           [YELLOW] DAYS_IN_BETWEEEN=2 OR LESS AND NOT EQUAL TO 0
           [RED] DAYS_IN_BETWEEN==0

           <// PHOTO_BASED "AUTO" DISTIGUISHMENT of  new FRIDGEITEM'S "category" based on >
           1.<--API FROM UPC BASED WEBSITE-->
           2. or from a camera based picture of the PHYSCIAL ITEMS unit of weight_measurment (implies text-recognition API)

           <Text-Recognition ALGORTHIM>
           

            */
       }

    }
}
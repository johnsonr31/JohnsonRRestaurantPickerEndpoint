// Richard Johnson
// 10-27-22
// This API will pick a random restaurant from whichever category the user inputs into the URL

// Peer Review: 

using Microsoft.AspNetCore.Mvc;

namespace JohnsonRRestaurantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    string restaurant = "";

    [HttpGet]
    [Route("Restaurant/FastFood")]

    public string FastFoodPicker()
    {
        Random random = new Random();
        int fastFood = random.Next(1,11);

        switch(fastFood)
        {
            case 1: restaurant = "McDonalds"; break;
            
            case 2: restaurant = "Wendy's"; break;
            
            case 3: restaurant = "Burger King"; break;
            
            case 4: restaurant = "Jack in the Box"; break;
            
            case 5: restaurant = "Chick-Fil-A"; break;
            
            case 6: restaurant = "Popeye's"; break;
            
            case 7: restaurant = "In-N-Out Burger"; break;
            
            case 8: restaurant = "Subway"; break;
            
            case 9: restaurant = "Five Guys"; break;
            
            case 10: restaurant = "Arby's"; break;

            case 11: restaurant = "Arby's"; break;
        }
        return restaurant;
    }

    [HttpGet]
    [Route("Restaurant/ChineseTakeout")]

    public string ChineseTakeoutPicker()
    {
        Random random = new Random();
        int fastFood = random.Next(1,11);

        switch(fastFood)
        {
            case 1: restaurant = "Panda Express"; break;

            case 2: restaurant = "East n West Chinese Cuisine"; break;
            
            case 3: restaurant = "Dynasty Restaurant"; break;
            
            case 4: restaurant = "Locke Garden"; break;
            
            case 5: restaurant = "Mandarin Villa"; break;
            
            case 6: restaurant = "Peking Restaurant"; break;
            
            case 7: restaurant = "Golden Bowl"; break;
            
            case 8: restaurant = "Jade Fountain"; break;
            
            case 9: restaurant = "Lucky House"; break;
            
            case 10: restaurant = "Far East Restaurant"; break;

            case 11: restaurant = "Far East Restaurant"; break;
        }
        return restaurant;
    }

    [HttpGet]
    [Route("Restaurant/Italian")]

    public string ItalianPicker()
    {
        Random random = new Random();
        int fastFood = random.Next(1,11);

        switch(fastFood)
        {
            case 1: restaurant = "Olive Garden"; break;

            case 2: restaurant = "Mezzo"; break;
            
            case 3: restaurant = "Pietro's"; break;
            
            case 4: restaurant = "Angelina's"; break;
            
            case 5: restaurant = "De Vega Brothers"; break;
            
            case 6: restaurant = "Calzone Life"; break;
            
            case 7: restaurant = "Padella"; break;
            
            case 8: restaurant = "Pastosa by Lucia"; break;
            
            case 9: restaurant = "Gian's Delicatessen"; break;
            
            case 10: restaurant = "Romano's Macaroni Grill"; break;

            case 11: restaurant = "Romano's Macaroni Grill"; break;
        }
        return restaurant;
    }



}

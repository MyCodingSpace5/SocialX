

using System.Linq;

Console.WriteLine("What are is your favorite sport");
var lmao = Console.ReadLine();
Console.WriteLine("What are your favorite genres?");
var genres = Console.ReadLine();
Console.WriteLine("What is your favorite food?");
var food = Console.ReadLine();

string[] HueyLikes = new string[] { "Football", "Music", "Pepperoni" };
string[] MikeyLikes = new string[] { "Soccer", "Coding", "Subway" };
string[] AnnaLikes = new string[] { "Baseball", "Data Anlyazation", "Grilled Cheese" };



var algorthimrecommendationtowardshuey = 0;
var algorthimrecommendationtowardsmikey = 0;
var algorthimrecommendationtowardsanna = 0;

var sportsharingHuey = HueyLikes.Contains(lmao);
var sportsharingmikey = MikeyLikes.Contains(lmao);
var sportsharinganna = AnnaLikes.Contains(lmao);

var genressharinghuey = HueyLikes.Contains(genres);
var genressharingmikey = MikeyLikes.Contains(genres);
var genressharinganna = AnnaLikes.Contains(genres);

var foodsharinghuey = HueyLikes.Contains(food);
var foodsharingmikey = MikeyLikes.Contains(food);
var foodsharinganna = AnnaLikes.Contains(food);


var hueyrecommendation = 0;
var annarecommendation = 0;
var mikeyrecommendation = 0;

if(sportsharingHuey == true)
{
    algorthimrecommendationtowardshuey++;
}
if(genressharinghuey == true)
{
    algorthimrecommendationtowardshuey++;
}
if(foodsharinghuey == true)
{
    algorthimrecommendationtowardshuey++;
}

if(sportsharingmikey == true)
{
    algorthimrecommendationtowardsmikey++;
}
if(genressharingmikey == true)
{
    algorthimrecommendationtowardsmikey++;
}
if(foodsharingmikey == true)
{
    algorthimrecommendationtowardsmikey++;
}

if (sportsharinganna == true)
{
    algorthimrecommendationtowardsmikey++;
}
if (genressharinganna == true)
{
    algorthimrecommendationtowardsmikey++;
}
if (foodsharinganna == true)
{
    algorthimrecommendationtowardsmikey++;
}

if (algorthimrecommendationtowardshuey > algorthimrecommendationtowardsmikey)
{
    hueyrecommendation++;
}
if(algorthimrecommendationtowardshuey > algorthimrecommendationtowardsanna)
{
    hueyrecommendation++;
}
if (algorthimrecommendationtowardsmikey > algorthimrecommendationtowardshuey)
{
    mikeyrecommendation++;
}
if (algorthimrecommendationtowardsmikey > algorthimrecommendationtowardsanna)
{
    mikeyrecommendation++;
}
if (algorthimrecommendationtowardsanna > algorthimrecommendationtowardshuey)
{
    annarecommendation++;
}
if (algorthimrecommendationtowardsanna > algorthimrecommendationtowardsmikey)
{
    annarecommendation++;
}
if (hueyrecommendation >= 2)
{
    Console.WriteLine("We recommend a friend: Huey! You guys share 2 or more interests");
}
if(mikeyrecommendation >= 2)
{
    Console.WriteLine("We recommend a friend: Mikey! You guys share 2 or more interests");
}
if(annarecommendation >= 2)
{
    Console.WriteLine("We recommend a friend: Anna You guys share 2 or more interests");
}

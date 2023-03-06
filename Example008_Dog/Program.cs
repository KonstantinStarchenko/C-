int count, distance, firstFriendSpeed, secondFriendSpeed, time, dogSpeed, friend;

count = 0;
distance = 10000;
firstFriendSpeed = 2;
secondFriendSpeed = 1;
dogSpeed = 5;
friend = 2;
time = 0;
while (distance > 10)
{
    if (friend == 1)
    {
        time = (int)((double)distance / (firstFriendSpeed + dogSpeed));
        friend = 2;
    }
    else
    {
        time = (int)((double)distance / (secondFriendSpeed + dogSpeed));
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
}
Console.WriteLine(count);
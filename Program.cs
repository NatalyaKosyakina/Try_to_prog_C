int raz = 0;
Console.WriteLine("Далеко бежать?");
double distance = Console.Read();
double friend1 = 2;
double friend2 = 3;
double dogspeed = 4;
int tuda = 2;
double time = 0;
while (distance > 10)
{
    if (tuda == 2)
    {
        time = distance/(friend2 + dogspeed);
        tuda = 1;
    }
    if (tuda == 1)
    {
       time = distance/(friend1 + dogspeed);
        tuda = 2;
    }
    distance = distance - (friend1 + friend2)*time;
raz = raz + 1;
}
Console.WriteLine(raz);
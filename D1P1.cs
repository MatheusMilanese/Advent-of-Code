// Day 1 Part 1
int x = 50;
int ans = 0;
string? line ;
while((line = Console.ReadLine()) != null)
{
    int y = int.Parse(line[1..]);
    if (line.StartsWith('R'))
    {
        x = ((x+y)%100+100)%100;
    }
    else
    {
        x = ((x-y)%100+100)%100;
    }
    if(x == 0) 
        ans++;
}

Console.WriteLine(ans);
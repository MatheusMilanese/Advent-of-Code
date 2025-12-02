// Day 1 Part 1
int x = 50;
int ans = 0;
string? line ;
while((line = Console.ReadLine()) != null)
{
    int y = int.Parse(line[1..]);
    ans += y / 100;
    y %= 100;
    if (line.StartsWith('R'))
    {
        int tmp = ((x+y)%100+100)%100;
        if(x!= 0 && x+y > 100 ) 
            ans++;
        x = tmp;
    }
    else
    {
        int tmp = ((x-y)%100+100)%100;
        if(x!= 0 && x-y < 0) 
            ans++;
        x = tmp;
    }
    if(x == 0) 
        ans++;
}

Console.WriteLine(ans);

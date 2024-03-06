int [] array ={2,3,4,5,6,7,1};
int n=7;
int i=0;
int sum =0;

while(i<n)
{
    if (array[i]>3)
    {
        sum=sum+array[i];
    }
    i=i+1;
}
Console.WriteLine(sum);

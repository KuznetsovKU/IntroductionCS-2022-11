//Ввод-вывод двумерного массива, поиск в двумерном массиве, сортировка 
//двумерного массива(по колонкам, так как в дз есть задание на сортировку 
//по строкам).

int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

bool LinearSearch2DArray(int[,] a,int find, out int i,out int j)
{
    for(i=0;i<a.GetLength(0);i++)
            
        for(j=0;j<a.GetLength(1);j++)
                if (a[i,j]==find)
                return true;
     j=-1;//?
     return false;   

}

void Sort2DArray(int[,] a)
{
    for(int j=0;j<a.GetLength(1);j++)    
        for(int k=0;k<a.GetLength(0);k++)
            for(int i=0;i<a.GetLength(0)-1;i++)
                if (a[i,j]>a[i+1,j])
                {
                    int t=a[i,j];
                    a[i,j]=a[i+1,j];
                    a[i+1,j]=t;                    
                }
}

//int[,] a1=new int[3,4] {{1,2,3,4},{1,2,3,4},{1,2,3,4}};
//int[,] a2= {{1,2,3,4},{1,2,3,4},{1,2,3,4}};
int[,] a=Random2DArray(5,5);
int find=20;
//a[2,2]=find;
Print2DArray(a);
int i,j;
if (LinearSearch2DArray(a,find,out i,out j))
    System.Console.WriteLine($"Element {find} found in position {i},{j}");
else
    System.Console.WriteLine("Element not found");
System.Console.WriteLine();

Sort2DArray(a);
Print2DArray(a);

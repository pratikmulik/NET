using bookshop;

Books FanBooks=new Books();
string BN1=FanBooks[0]; //------------------Getting Book Names using indexer;
string BN2=FanBooks[1];

Console.WriteLine("Book1 from FanBooks is="+BN1);
Console.WriteLine("Book1 from FanBooks is="+BN2);


FanBooks[0]="Harry Potter 1";//------------------Setting Book Names using indexer
FanBooks[1]="LoTR";

BN1=FanBooks[0];
BN2=FanBooks[1];

Console.WriteLine("Book1 from FanBooks is="+BN1);
Console.WriteLine("Book1 from FanBooks is="+BN2);

Console.WriteLine("--------------------------------------------------------------------------------");

//Multidimensional array
int[ , ] mtr1=new int[2,3]
{
    {10,30,40},
    {50,60,80}
};

Console.WriteLine(mtr1);

//Array of Array
int [ ] [ ] mtrxj = new int [3] [];
mtrxj[0]=new int[] {34,56,76,};
mtrxj[1]=new int[] {34,56,76,67,98,1,45,98,67};
mtrxj[2]=new int[] {98,67};

Console.WriteLine(mtrxj);

Console.WriteLine("--------------------------------------------------------------------------------");
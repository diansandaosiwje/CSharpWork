// ConsoleApplication1.cpp: 定义控制台应用程序的入口点。
//

#include "stdafx.h"


int main()
{
	int a, b, c;
	printf("Please in put int a,b,c:\n");
	scanf_s("%d%d%d", &a,&b,&c);
	printf("The three numbers are %d %d %d \n ", a, b, c);

	if (a >= b&&a >= c)
	{
		printf("The max number is:%d", a);
	}
	else if (b >= a && b >= c)
	{
		printf("The max number is:%d", b);
	}
	else
	{
		printf("The max number is:%d", c);
	}

    return 0;
}


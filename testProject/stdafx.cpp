// stdafx.cpp : source file that includes just the standard includes
// testProject.pch will be the pre-compiled header
// stdafx.obj will contain the pre-compiled type information

#include "stdafx.h"

// TODO: reference any additional headers you need in STDAFX.H
// and not in this file


// testProject.cpp : Defines the entry point for the console application.
////
//
//#include "stdafx.h"
//#include <iostream>
//#include <vector>
//using namespace std;
////
////class ARRAY
////{
////private:
////	int b[4][5];
////	int s;
////
////public:
////	ARRAY(int p[][5],int n);
////	void f();
////	void  print();
////	~ARRAY();
////
////private:
////
////};////////////////////////////////hhhhhhhhhhhhhhhhhhhhhhhherrrttrrrrrrrrrrryyyyyyyyyyyyyyyqqqqqpppppppppttttt..;;;;;;;;.........................
//////////////ccjjjjjjjjjjuuuuuu'''
//////zzzzzmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,dddgggggaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaawwwwwwwwwwwwwwwwwwwwwwwwwwwwwssdddddddddddddddsssssssssssnnnnnnnnnnnnnnnnnnnbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbeeeeeeeeeeeeeeeeee,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.kkkkkkkkkk'''''''''''''''']''vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
////ARRAY::ARRAY(int p[][5], int n)
////{
////	for (int i = 0; i < 4; i++)
////	{
////		for (int j = 0; j < 5; j++)
////			b[i][j] = p[4][5];
////	}
////	s = 0;
////}
////
////void ARRAY::f()
////{
////	for (int i = 0; i < 4; i++)
////	{
////		s += b[i][0];
////		s += b[i][4];
////	}
////	for (int i = 0; i < 5; i++)
////	{
////		s += b[0][i];
////		s += b[3][i];
////	}
////}
////
////void ARRAY::print()
////{
////	for (int i = 0; i < 4; i++)
////	{
////		for (int j = 0; j < 5; j++)
////			std::cout << b[i][j] << " ";
////		std::cout << std::endl;
////	}
////	std::cout << "sum=" << s << std::endl;
////}
////
////ARRAY::~ARRAY()
////{
////}
////bool IsValidPrimeNumber(int n)
////{
////	if (n == 1 || n == 2)
////	{
////		return true;
////	}
////	for (int i = 3; i < n;i++)
////	{
////		if (n%i == 0)
////		{
////			return false;
////		}
////	}
////	return true;
////}
////int getPrimeNumberBaseM(int m)
////{
////	int n = m + 1;
////	while (1)
////	{
////		if (IsValidPrimeNumber(n))
////		{
////			return n;
////		}
////		n++;
////	}
////	return n;
////}
////int main()
////{
////	int k = 0;
////	scanf("%d", &k);
////	int res = getPrimeNumberBaseM(k);
////	printf("%d", res);
////	return 0;
////}
////int fun(int n)
////{
////	int sum = 0;
////	for (int i = 1; i <= n;i++)
////	{
////		sum += i;
////	}
////	return sum;
////}
////class Solution {
////	int m;
////	int n;
////public:
////	/**
////	* @param board: A list of lists of character
////	* @param word: A string
////	* @return: A boolean
////	*/
////	bool exist(vector<vector<char>> &board, string word, int row, int col, int pos, vector<vector<int>> flag)
////	{
////		if (pos == word.length())
////			return true;
////		if (board[row][col] != word[pos])
////			return false;
////		flag[row][col] = 1;
////		if ((row - 1 >= 0 && flag[row - 1][col] == 0) && exist(board, word, row - 1, col, pos + 1, flag))
////			return true;
////		if ((row + 1 < m && flag[row + 1][col] == 0) && exist(board, word, row + 1, col, pos + 1, flag))
////			return true;
////		if ((col + 1 < n && flag[row][col + 1] == 0) && exist(board, word, row, col + 1, pos + 1, flag))
////			return true;
////		return false;
////	}
////	bool exist(vector<vector<char> > &board, string word)
////	{
////		// write your code here
////		if (word.length() <= 0) return true;
////		m = board.size();
////		if (m <= 0) return false;
////		n = board[0].size();
////		vector<vector<int>> flag(m, vector<int>(n, 0));
////		for (int i = 0; i < m; i++)
////		{
////			for (int j = 0; j < n; j++)
////			{
////				if (board[i][j] == word[0])
////				{
////					flag[i][j] = 1;
////					if (i - 1 >= 0 && exist(board, word, i - 1, j, 1, flag) == true)
////						return true;
////					if (i + 1 < m && exist(board, word, i + 1, j, 1, flag) == true)
////						return true;
////					if (j + 1 < n && exist(board, word, i, j + 1, 1, flag) == true)
////						return true;
////				}
////			}
////		}
////		return false;
////	}
////};
//int fun(char*str)
//{
//	int i = 0, len = strlen(str)-1;
//	while (i < len)
//	{
//		if (str[i] == str[len])
//		{
//			i++, len--;
//		}
//		else
//			return 0;
//	}
//	return 1;
//}
//void sort(int *p, int n)
//{
//	int i = 0, j = 0;
//	for (i = 0; i < n-1;i++)
//	{
//		int temp = i;
//		for (j = i; j < n;j++)
//		{
//			if (p[j] < p[temp])
//			{
//				temp = j;
//			}
//		}
//		p[temp] = p[temp] + p[i] - (p[i] = p[temp]);
//	}
//}
//
//class Person
//{
//private:
//	string name;
//	string sex;
//public:
//	Person(string name_str, string sexchar)
//	{
//		if (sexchar != "F" && sexchar != "M")
//		{
//			throw exception("性别设置不成功，参数不是性别字符");
//		}
//		name = name_str;
//		sex = sexchar;
//	}
//	void SetName(string strNewName)
//	{
//		name = strNewName;
//	}
//	void SetSex(string sexchar)
//	{
//		if (sexchar != "F" && sexchar != "M")
//		{
//			throw exception("性别设置不成功，参数不是性别字符");
//		}
//		sex = sexchar;
//	}
//	void display()
//	{
//		cout << "姓名： " << name.c_str() << "性别：" << (sex == "F" ? "女" : "男");
//	}
//};
//class Student:public Person
//{
//private:
//	string specialty;
//	int year;
//public:
//	Student(string name_str, string sexchar, string spec_str, int year) :Person(name_str, sexchar), specialty(spec_str), year(year)
//	{}
//	~Student();
//	void show()
//	{
//		display();
//		cout << "专业： " << specialty.c_str() << "   " << "年级 ：" << year;
//	}
//};
//
//bool IsContinue(double num)
//{
//	if (int(num)%10 == 0)
//	{
//		return false;
//	}
//	return true;
//}
//float getRes(bool flag, double res, int deno)
//{
//	if (flag)
//	{
//		return res + 4.0 / deno;
//	}
//	return res - 4.0 / deno;
//}
//
//void func1()
//{
//	bool flag = false;
//	double res = 4.0 * 10000000000;
//	int deno = 3;
//	while (IsContinue(res))
//	{
//		res = getRes(flag, res, deno);
//		deno += 2;
//		flag = !flag;
//	}
//	printf("%.10f", res / 10000000000);
//}
//void printStar(int num, char c)
//{
//	int i = 0;
//	for (i = 0; i < num; i++)
//	{
//		putchar(c);
//	}
//}
//int main()
//{
//	for (int i = 1; i <= 9;i++)
//	{
//		printStar(i, '*');
//		printStar(18 - 2 * i,' ');
//		printStar(i, '*');
//		putchar('\n');
//	}
//	return 0;
//}
//
//int getMaxPrime(int a, int b)
//{
//	while (a%b != 0)
//	{
//		int c = a%b;
//		b = a;
//		a = c;
//	}
//	return b;
//}
//char * strcat(char* s1, char* s2)
//{
//	int len1 = strlen(s1);
//	int len2 = strlen(s2);
//	char* str = (char*)malloc(len2 + len1 + 1);
//	int i = 0;
//	for (; i < len1;i++)
//	{
//		str[i] = s1[i];
//	}
//	for (i = 0; i < len2;i++)
//	{
//		str[len1 + i] = s2[i];
//	}
//	str[len1 + len2] = '\0';
//	return str;
//}

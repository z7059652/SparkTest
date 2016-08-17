#define _CRT_SECURE_NO_WARNINGS 
#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <cmath>
#include <cstring>
#include <stdio.h>
#include <stdlib.h>
#include <map>
#include <vector>
#include <deque>
#include <algorithm>
using namespace std;

const int MAX = 101;
const int dx[4] = { 0, 0, -1, 1 }, dy[4] = { 1, -1, 0, 0 };
class Solution
{
	struct point
	{
		int x, y;
	};

	int Alt[MAX][MAX];
	bool vid[MAX][MAX];
	int heap_size;
	point Heap[MAX*MAX];

	void heap_ins(int x, int y)
	{
		int i;
		for (i = ++heap_size; Alt[x][y] < Alt[Heap[i / 2].x][Heap[i / 2].y]; i = i / 2)
			Heap[i] = Heap[i / 2];
		Heap[i].x = x; Heap[i].y = y;
	}

	point heap_delmin()
	{
		point R = Heap[1], M = Heap[heap_size--];
		int i, c;
		for (i = 1; i * 2 <= heap_size; i = c)
		{
			c = i * 2;
			if (c != heap_size && Alt[Heap[c + 1].x][Heap[c + 1].y]<Alt[Heap[c].x][Heap[c].y])
				c++;
			if (Alt[M.x][M.y] > Alt[Heap[c].x][Heap[c].y])
				Heap[i] = Heap[c];
			else
				break;
		}
		Heap[i] = M;
		return R;
	}
public:
	int N, M, All;
	void init()
	{
		memset(Alt, 0, sizeof(int)*MAX*MAX);
		memset(vid, 0, sizeof(bool)*MAX*MAX);
		memset(Heap, 0, sizeof(point)*MAX*MAX);
		All = 0;
		scanf("%d %d", &N, &M);
		for (int i = 1; i <= N; i++)
		for (int j = 1; j <= M; j++)
			scanf("%d", &Alt[i][j]);
		Alt[0][0] = -0x7FFFFFFF;
		Heap[heap_size = 0].x = Heap[0].y = 0;
	}

	inline bool inrange(point A)
	{
		return A.x >= 1 && A.x <= N && A.y >= 1 && A.y <= M;
	}

	void floodfill(point A, int h)
	{
		point B;
		vid[A.x][A.y] = true;
		if (Alt[A.x][A.y] >= h)
			heap_ins(A.x, A.y);
		else
		{
			All += h - Alt[A.x][A.y];
			for (int i = 0; i < 4; i++)
			{
				B.x = A.x + dx[i]; B.y = A.y + dy[i];
				if (inrange(B) && !vid[B.x][B.y])
					floodfill(B, h);
			}
		}
	}

	void solve()
	{
		int i, j;
		point A, B;
		for (i = 1; i <= N; i++)
		{
			heap_ins(i, 1);
			heap_ins(i, M);
			vid[i][1] = vid[i][M] = true;
		}
		for (i = 2; i <= M - 1; i++)
		{
			heap_ins(1, i);
			heap_ins(N, i);
			vid[1][i] = vid[N][i] = true;
		}
		while (heap_size)
		{
			A = heap_delmin();
			for (i = 0; i < 4; i++)
			{
				B.x = A.x + dx[i]; B.y = A.y + dy[i];
				if (inrange(B) && !vid[B.x][B.y])
					floodfill(B, Alt[A.x][A.y]);
			}
		}
	}
};




//int main()
//{
//	freopen("wod.in", "r", stdin);
//	freopen("wod.out", "w", stdout);
//	int n = 0;
//	scanf("%d", &n);
//	Solution s;
//	for (int i = 0; i < n;i++)
//	{
//		s.init();
//		s.solve();
//		printf("Case #%d: %d\n",i+1, s.All);
//	}
//	return 0;
//}







//void sort(char data[][19],int len)
//{
//	int i = 0, j = 0;
//	int dataLen[5];
//	for (i = 0; i < len;i++)
//	{
//		dataLen[i] = strlen(data[i]);
//	}
//	for (i = 0; i < len;i++)
//	{
//		int maxLen = 0,pos = 0;
//		for (j = 0; j < len;j++)
//		{
//			if (dataLen[j] > maxLen)
//			{
//				maxLen = dataLen[j];
//				pos = j;
//			}
//		}
//		printf("%s\\n",data[pos]);
//		dataLen[pos] = 0;
//	}
//}
//
//int main()
//{
//	char data[5][19];
//	int i = 0;
//	while (i < 5)
//	{
//		scanf("%s",data[i++]);
//	}
//	sort(data,5);
//	return 0;
//}

class Teacher
{};
class Solutionss {
public:
	/**
	* @param matrix: A list of lists of integers
	* @return: Void
	*/
	void rotate(vector<vector<int> > &matrix, int pos)
	{
		if (matrix.size() - pos <= pos)
			return;
		for (int i = pos; i < matrix.size() - pos - 1; i++)
		{
			int num = matrix[pos][pos + i];
			matrix[pos][pos + i] = matrix[matrix.size() - 1 - pos - i][pos];
			matrix[matrix.size() - 1 - pos - i][pos] = matrix[matrix.size() - 1 - pos][matrix.size() - 1 - pos - i];
			matrix[matrix.size() - 1 - pos][matrix.size() - 1 - pos - i] = matrix[pos + i][matrix.size() - 1 - pos];
			matrix[pos + i][matrix.size() - 1 - pos] = num;
		}
		return rotate(matrix, pos+1);
	}
	void rotate(vector<vector<int> > &matrix)
	{
		// write your code here
		int n = matrix.size();
		if (n <= 1)
			return;
		return rotate(matrix, 0);
	}
};

class test
{
public:
	int &a;
	test(int b) :a(b)
	{}
};
int getSecondMaxNum(vector<int> &num)
{
	if (num.size() == 0)
		return -1;
	if (num.size() == 1)
		return num[0];
	int maxNum = max(num[0], num[1]), secondMax = min(num[0], num[1]);
	for (auto x : num)
	{
		if (x > maxNum)
		{
			secondMax = maxNum;
			maxNum = x;
		}
		else if (x < maxNum && x > secondMax)
		{
			secondMax = x;
		}
	}
	return secondMax;
}
void main()
{
	map<int, int> mp;
	vector<int> nums{1,2};
	int a = 3;
	int &b = a;
	cout << getSecondMaxNum(nums) << endl;
	mp.insert(make_pair(1, 1));
	deque<int> de;
	de.front();
	de.pop_front();
	vector<vector<int>> num{ { 1, 2 }, {3,4} };
	Solutionss ss;
	ss.rotate(num);
}


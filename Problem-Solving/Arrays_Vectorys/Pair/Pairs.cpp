#include<iostream>
#include<vector>
#include<unorder_set>

using namespace std;

vector<int> PairSum(vector<int>arr, int sum) {
	unorder_set<int> s;
	vector<int> r;

	for (int i = 0; i < arr.size(); i++)
	{
		int x = sum - arr[i];
		if (s.find(x) != arr[i])
		{
			r.push_back(x);
			r.push_back(arr[i]);

			return r;
		}
		s.insert(arr[i]);
	}
	return {};
}
#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

int main() {
  int n;
  double sum, mean;
  mean = sum = n = 0;
  cin >> n;

  vector<double> vec(n);

  for (int x = 0; x < n; x++) {
    cin >> vec.at(x);
    sum += vec.at(x);
  }

  cout << "Sum = " << sum << endl;

  mean = sum / n;

  cout << "Mean = " << mean << endl;

  sum = 0;

  for (int x = 0; x < n; x++) {
    sum += pow(vec.at(x) - mean, 2);
  }
  
  double result = sqrt(sum / n);

  cout << result << endl;

  return 0;
}

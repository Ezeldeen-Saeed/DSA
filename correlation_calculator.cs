
int n = int.Parse(Console.ReadLine());
double ex1, ex2, ex3, x_mean, y_mean;
double[] x, y;
x = new double[n];
y = new double[n];
ex1 = ex2 = ex3 = x_mean = y_mean = 0d;


double x_sums, y_sums;
x_sums = y_sums = 0d;
for (int i = 0; i < n; i++)
{
  x[i] = double.Parse(Console.ReadLine());
  y[i] = double.Parse(Console.ReadLine());

  x_sums += x[i];
  y_sums += y[i];
}

x_mean = x_sums / n;
y_mean = y_sums / n;

// Console.WriteLine($"x_mean = {x_mean}, y_mean = {y_mean}");

for (int i = 0; i < n; i++)
{
  ex1 += (x[i] - x_mean) * (y[i] - y_mean);
  ex2 += Math.Pow(x[i] - x_mean, 2);
  ex3 += Math.Pow(y[i] - y_mean, 2);
}

Console.WriteLine(ex1 / Math.Sqrt(ex2 * ex3));

// (1,5) (3,2) (5,8) (2,20) (20,3) (1,8)

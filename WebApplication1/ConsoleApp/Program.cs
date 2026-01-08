Console.WriteLine("Hello, World!");

// num
int age = 23;
//Console.WriteLine(age);

long bigNum = 1000000000L;
//Console.WriteLine(bigNum);
//Console.WriteLine(long.MinValue);
//Console.WriteLine(long.MaxValue);

float floatNum = 1.0f;
//Console.WriteLine(floatNum);
//Console.WriteLine(float.MinValue);
//Console.WriteLine(float.MaxValue);

double doubleNum = -55.2;
//Console.WriteLine(doubleNum);
//Console.WriteLine(double.MinValue);
//Console.WriteLine(double.MaxValue);

decimal decimalNum = 5.0m;
//Console.WriteLine(decimalNum);
//Console.WriteLine(decimal.MinValue);
//Console.WriteLine(decimal.MaxValue);

// str
string str = "Ally";
//Console.WriteLine(str);

char word = 'A';
//Console.WriteLine(word);

// string to num
string textNum = "-23";
int convertedNum = Convert.ToInt32(textNum);
//Console.WriteLine(convertedNum);

string textLong = "-1000000000";
long convertedTextBigNum = Convert.ToInt64(textLong);
//Console.WriteLine(convertedTextBigNum);

string textFloatNum = "1.0";
float convertedTextFloatNum = Convert.ToSingle(textFloatNum);
//Console.WriteLine(convertedTextFloatNum);

string textDouble = "-55.2";
double convertedTextDoubleNum = Convert.ToDouble(textDouble);
//Console.WriteLine(convertedTextDoubleNum);

string textDecimal = "5.0";
decimal convertedDecimalTextNum = Convert.ToDecimal(textDecimal);
//Console.WriteLine(convertedDecimalTextNum);

// boolean
bool boolean = false;
//Console.WriteLine(boolean);

// operators
int num = 23;
num++;
//Console.WriteLine(num);
num--;
//Console.WriteLine(num);
int num2 = 25;
num2 /= 10;
//Console.WriteLine(num2);
double num3 = 25;
num3 /= 10;
//Console.WriteLine(num3);

string statement = "hi";
statement += ",I'm Ally.";
//Console.WriteLine(statement);

// remainder
int numerator = 10;
int denominator = 3;
//Console.WriteLine(numerator / denominator);
//Console.WriteLine(numerator % denominator);

// var keyword (automatcally infer the type of value)
var val = 23; // int
var val2 = 10000000L; // long
var val3 = -50.8D; // double
var val4 = 10.0f; // float
var val5 = 15.12M; // decimal
var val6 = "string"; // string
var val7 = 'c'; // char

// const keyword (block changing the value of the variable)
const int solidNum = 20;
//solidNum = 50; // not allowed

// format number
double numWithManyDecimals = 0.2584651661;
string numWithGroomed = string.Format("{0:0.00}", numWithManyDecimals);
//Console.WriteLine(numWithGroomed);

// try parse (pevent inccorect tpye converting leads to exceptions)
string targetVal1 = "fakeNum";
string targetVal2 = "100";
string targetVal3 = "200";
int resultNum1;
int resultNum2;
int.TryParse(targetVal1, out resultNum1);
int.TryParse(targetVal2, out resultNum2);
bool isSuccess = int.TryParse(targetVal2, out resultNum2);
Console.WriteLine(resultNum1);
Console.WriteLine(resultNum2);
Console.WriteLine(isSuccess);


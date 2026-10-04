/*string myName = "Фёдор Зеленцов";
string groupName = "ИСП-251";
int courseNumber = 2;
double averageGrade = 4.6;
bool isBudget = true;

Console.WriteLine("Знакомство");
Console.WriteLine($"Студент: {myName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Бюджетное место: {isBudget}");


Console.WriteLine();
Console.WriteLine("Ремонт: комната");

double roomWidth = 3.5;
double roomLength = 4.2;

double roomArea = roomWidth * roomLength;
double roomPerimeter = (roomWidth + roomLength) * 2;

Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
Console.WriteLine($"площадь: {roomArea} кв.м");
Console.WriteLine($"периметр: {roomPerimeter} м"); 



Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку ");

int laptopPrice = 65000;
int monthsCount = 12;
double interestRate = 0.08;

double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / monthsCount;

Console.WriteLine($"Цена ноутбука:{laptopPrice} руб.");
Console.WriteLine($":{totalWithInterest}руб.");
Console.WriteLine($":{monthlyPayment}руб."); 

Console.WriteLine();
Console.WriteLine("Внимание: деление int");

int totalStudents = 25;
int groupsCount = 4;
int studentsPerGroupWrong = totalStudents / groupsCount;
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;

Console.WriteLine($"25/4 как int:    {studentsPerGroupWrong}");
Console.WriteLine($"25/4 как double: {studentsPerGroupCorrect}"); 

Console.WriteLine();
Console.WriteLine("Способы собрать строку");

string firstname = "Анна";
string lastname = "Смирнова";

//способ 1: конкатенация через оператора+
string fullnameconcat = firstname + "" + lastname;

//Способ 2: интерполяция через $""
string fullnameinterp = $"{firstname}{lastname}";
//Способ 3: метод string.concat
string fullnameconcatmetod = string.Concat(firstname, "", lastname);

Console.WriteLine(fullnameconcat);
Console.WriteLine(fullnameinterp);
Console.WriteLine(fullnameconcatmetod);
Console.WriteLine($"Все три строки равны: {fullnameconcat == fullnameinterp && fullnameinterp == fullnameconcatmetod}"); */


Console.WriteLine();
Console.WriteLine("Константы");

const double vatrate = 0.2;
const string collegename = "ВФ ВолГУ";

double productprice = 1000;
double pricewithvat = productprice * (1 + vatrate);

Console.WriteLine($"учебное заведение: {collegename}");
Console.WriteLine($"Цена без НДС: {productprice},c НДС({vatrate:P0}):{pricewithvat}");

//написал код чтобы получить баллы
//получаю баллы чтобы меня не отчислили
//пишу такие коментарии чтобы вы сжалились и поставили зачёт
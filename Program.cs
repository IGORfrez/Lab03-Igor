// Console.WriteLine("Банковский счёт");
// double balance = 1000;
// Console.WriteLine($"Начальный баланс: {balance}");
// balance += 500; // пополнение
// Console.WriteLine($"После пополнения на 500: {balance}");
// balance -= 200; // покупка
// Console.WriteLine($"После покупки на 200: {balance}");
// balance *= 1.05; // начисление 5% процентов
// Console.WriteLine($"После начисления 5%: {balance}");
// balance /= 2; // разделили счёт пополам с партнёром
// Console.WriteLine($"После деления пополам: {balance}");

// Console.WriteLine();
// Console.WriteLine("Операторы сравнения");
// double myGrade = 4.6;
// double passingGrade = 4.0;
// int myAge = 20;
// int votingAge = 18;
// bool isPassing = myGrade >= passingGrade;
// bool isExactAge = myAge == votingAge;
// bool canVote = myAge >= votingAge;
// bool isNotFailing = myGrade != 2.0;

// Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
// Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
// Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
// Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");

// Console.WriteLine();
// Console.WriteLine("Логические операторы");
// bool hasPassingGrade = true;
// bool hasAttendance = false;
// bool hasDebt = true;

// bool canGetScholarship = hasPassingGrade && hasAttendance;
// bool canRetakeExam = hasPassingGrade || hasAttendance;
// bool isDebtFree = !hasDebt;

// Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
// Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
// Console.WriteLine($"Нет долгов: {isDebtFree}");

// Console.WriteLine();
// Console.WriteLine("Короткое замыкание");
// bool CheckAndPrint(string label, bool value) {
//     Console.WriteLine($"Вычисляется: {label}");
//     return value;
// }

// Console.WriteLine("Проверяем && (первый операнд false):");
// bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
// Console.WriteLine($"Результат: {resultAnd}");

// Console.WriteLine();
// Console.WriteLine("Проверяем || (первый операнд true):");
// bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
// Console.WriteLine($"Результат: {resultOr}");

// Console.WriteLine();
// Console.WriteLine("Приоритет операций");
// int resultNoParens = 2 + 3 * 4;
// int resultWithParens = (2 + 3) * 4;
// Console.WriteLine($"2 + 3 * 4 = {resultNoParens}");
// Console.WriteLine($"(2 + 3) * 4 = {resultWithParens}");

// bool logicResult = 5 > 3 && 2 < 4 || false;
// bool logicResultParens = (5 > 3 && 2 < 4) || false;
// Console.WriteLine($"5>3 && 2<4 || false = {logicResult}");
// Console.WriteLine($"(5>3 && 2<4) || false = {logicResultParens}");

// Console.WriteLine();
// Console.WriteLine("Приёмная комиссия");
// Console.Write("Введите средний балл аттестата: ");
// double averageGrade = double.Parse(Console.ReadLine());

// Console.Write("Введите баллы за экзамен (0-100): ");
// int examScore = int.Parse(Console.ReadLine());

// Console.Write("Есть льгота? (1 - да, 0 - нет): ");
// int benefitInput = int.Parse(Console.ReadLine());
// bool hasBenefit = (benefitInput == 1);

// // TODO 1: hasGoodCertificate = true, если averageGrade >= 4.0
// bool hasGoodCertificate = averageGrade >= 4.0;

// // TODO 2: hasGoodExam = true, если examScore >= 60
// bool hasGoodExam = examScore >= 60;

// // TODO 3: isEligibleByRules = true, если (hasGoodCertificate И hasGoodExam) ИЛИ hasBenefit
// bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;

// // TODO 4: итоговый балл = средний балл * 10, а затем прибавьте баллы экзамена
// double totalScore = averageGrade * 10;
// totalScore += examScore;

// Console.WriteLine();
// Console.WriteLine("Результат");
// Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}"); 
// Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
// Console.WriteLine($"Льгота: {hasBenefit}");
// Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
// Console.WriteLine($"Итоговый балл: {totalScore}");

// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// bool isEven = (number % 2) == 0;

// Console.WriteLine($"Число {number} чётное: {isEven}");

// int x = 5;
// int y = 5;

// // Постфиксный инкремент: сначала используется старое значение, потом увеличивается
// int resultPost = x++; 
// Console.WriteLine($"x++ вернул: {resultPost}, теперь x = {x}"); 
// // Вывод: x++ вернул: 5, теперь x = 6

// // Префиксный инкремент: сначала увеличивается, потом используется новое значение
// int resultPre = ++y;
// Console.WriteLine($"{++y} вернул: {resultPre}, теперь y = {y}"); 
// // Осторожно: тут ++y уже второй раз, чтобы показать поведение. Лучше так:

// // Более чистый пример:
// int a = 10;
// int b = 10;

// int post = a++; // post = 10, a = 11
// int pre = ++b;  // b = 11, pre = 11

// Console.WriteLine($"a++: post={post}, a={a}");
// Console.WriteLine($"++b: pre={pre}, b={b}");

// // Пример в выражении:
// int c = 3;
// int d = 3;

// int exprPost = 10 + c++; // 10 + 3 = 13, c станет 4
// int exprPre = 10 + ++d;  // d станет 4, потом 10 + 4 = 14

// Console.WriteLine($"10 + c++ = {exprPost}, c={c}");
// Console.WriteLine($"10 + ++d = {exprPre}, d={d}");

Console.Write("Введите сумму покупки (руб.): ");
double totalAmount = double.Parse(Console.ReadLine());

Console.Write("Есть карта клиента? (1 - да, 0 - нет): ");
int hasCardInput = int.Parse(Console.ReadLine());
bool hasCard = (hasCardInput == 1);

Console.Write("Количество товаров: ");
int itemCount = int.Parse(Console.ReadLine());

// Промежуточные условия
bool highAmount = totalAmount >= 5000;
bool manyItems = itemCount >= 10;

bool eligibleForDiscount = (highAmount && hasCard) || manyItems;

Console.WriteLine();
Console.WriteLine("Промежуточные условия:");
Console.WriteLine($"Сумма >= 5000: {highAmount}");
Console.WriteLine($"Есть карта: {hasCard}");
Console.WriteLine($"Количество товаров >= 10: {manyItems}");
Console.WriteLine($"Скидка применима: {eligibleForDiscount}");
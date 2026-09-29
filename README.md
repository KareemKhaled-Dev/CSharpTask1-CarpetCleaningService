# Standard Numeric format

1. Why the output of this equation = $30.00?
بسبب وجود C: ودي مهمتها تعرض الرقم العادي بتنسيق العملة زي ماهيا كده عرضاه بالدولار مثلا
2. What is its benefit?
    بستخدمها مثلا لو انا ببني متجر او موقع حساب فواتير وبدال ماعرض الاسعار كارقام عادية اعرضها على هيئة عملة باستخدام c:  
3.Try another example with a different specifier
مثلا f: دي بتضيف للرقم خانات عشرية وبنحتاجها كتير زي اللي مستخدمة في برنامج الاكسيل
example
int X = 10;
int Y = 20;

Console.WriteLine($"Equation: {X} + {Y} = {X + Y:f}");
// output 
Equation: 10 + 20 = 30.00

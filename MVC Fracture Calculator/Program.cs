using MVC_Fracture_Calculator;
while (true)
{
    Console.WriteLine("введите числитель и знаминатель первой дроби");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите числитель и знаминатель dnjhjq дроби");
    int c = Convert.ToInt32(Console.ReadLine());
    int d = Convert.ToInt32(Console.ReadLine());


    Fraction fraction1 = new Fraction(a, b);
    Fraction fraction2 = new Fraction(c, d);

    FractionModel model = new FractionModel();
    model.Fraction1 = fraction1;
    model.Fraction2 = fraction2;

    FractionView view = new FractionView(model);
    FractionController controller = new FractionController(model, view);

    controller.Multiply();
    controller.Divide();

    Console.ReadKey();
}
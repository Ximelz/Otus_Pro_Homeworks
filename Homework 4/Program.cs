namespace Homework_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen(14.2, "Черный");
            GelPen gel = new GelPen(14.6, "Желтый", new Refill("Синий", 0.7));
            BallpointPen ballpoint = new BallpointPen(13.7, "Красный", new Refill("Фиолетовый", 0.9));
            FountainPen fountain = new FountainPen(14.5, "Металлический", new Ink("Черный", Container.Cartridge), FountainPenSize.F);

            Pencil pencil = new Pencil(12.4, "Желтый");
            Pencil blackPencilLead = new BlackPencilLeadPencil(12.1, "Серебрянный");
            Pencil mechanical = new MechanicalPencils(13.2, "Синий", new Lead("Серый", 0.3));


            Console.WriteLine("Исходные классы");
            Console.WriteLine(pen);
            Console.WriteLine(gel);
            Console.WriteLine(ballpoint);
            Console.WriteLine(fountain);

            Console.WriteLine(pencil);
            Console.WriteLine(blackPencilLead);
            Console.WriteLine(mechanical);
            Console.WriteLine("-----------------------------------------------------------------------------------");


            Pen copyPen = new Pen(15.22, "Зеленый");
            GelPen copyGel = new GelPen(15.61, "Темно-зеленый", new Refill("Темно-синий", 0.75));
            BallpointPen copyBallpoint = new BallpointPen(13.74, "Красный", new Refill("Светло-фиолетовый", 0.86));
            FountainPen copyFountain = new FountainPen(14.53, "Платиновый", new Ink("Светло-синий", Container.Bottle), FountainPenSize.M);

            Pencil copyPencil = new Pencil(12.41, "Светло-желтый");
            Pencil copyBlackPencilLead = new BlackPencilLeadPencil(13.71, "Изумрудный");
            Pencil copyMechanical = new MechanicalPencils(12.21, "Стальной", new Lead("Темно-серый", 0.32));

            Console.WriteLine("Классы для кланирования до клонирования");
            Console.WriteLine(copyPen);
            Console.WriteLine(copyGel);
            Console.WriteLine(copyBallpoint);
            Console.WriteLine(copyFountain);

            Console.WriteLine(copyPencil);
            Console.WriteLine(copyBlackPencilLead);
            Console.WriteLine(copyMechanical);
            Console.WriteLine("-----------------------------------------------------------------------------------");


            Console.WriteLine("Результаты сравнения ручек и карандашей до клонирования:");
            Console.WriteLine($"Результат сравнения 2-х объектов pen и copyPen: {pen.Equals(copyPen)}");
            Console.WriteLine($"Результат сравнения 2-х объектов gel и copyGel: {gel.Equals(copyGel)}");
            Console.WriteLine($"Результат сравнения 2-х объектов ballpoint и copyBallpoint: {ballpoint.Equals(copyBallpoint)}");
            Console.WriteLine($"Результат сравнения 2-х объектов fountain и copyFountain: {fountain.Equals(copyFountain)}");

            Console.WriteLine($"Результат сравнения 2-х объектов pencil и copyPencil: {pencil.Equals(copyPencil)}");
            Console.WriteLine($"Результат сравнения 2-х объектов blackPencilLead и copyBlackPencilLead: {blackPencilLead.Equals(copyBlackPencilLead)}");
            Console.WriteLine($"Результат сравнения 2-х объектов mechanical и copyMechanical: {mechanical.Equals(copyMechanical)}");
            Console.WriteLine("-----------------------------------------------------------------------------------");


            copyPen = pen.MyClone();
            copyGel = gel.MyClone();
            copyBallpoint = ballpoint.MyClone();
            copyFountain = fountain.MyClone();

            copyPencil = pencil.MyClone();
            copyBlackPencilLead = blackPencilLead.MyClone();
            copyMechanical = mechanical.MyClone();

            Console.WriteLine("Результаты сравнения ручек и карандашей после клонирования методом MyClone интерфейса IMyCloneable:");
            Console.WriteLine($"Результат сравнения 2-х объектов pen и copyPen: {pen.Equals(copyPen)}");
            Console.WriteLine($"Результат сравнения 2-х объектов gel и copyGel: {gel.Equals(copyGel)}");
            Console.WriteLine($"Результат сравнения 2-х объектов ballpoint и copyBallpoint: {ballpoint.Equals(copyBallpoint)}");
            Console.WriteLine($"Результат сравнения 2-х объектов fountain и copyFountain: {fountain.Equals(copyFountain)}");

            Console.WriteLine($"Результат сравнения 2-х объектов pencil и copyPencil: {pencil.Equals(copyPencil)}");
            Console.WriteLine($"Результат сравнения 2-х объектов blackPencilLead и copyBlackPencilLead: {blackPencilLead.Equals(copyBlackPencilLead)}");
            Console.WriteLine($"Результат сравнения 2-х объектов mechanical и copyMechanical: {mechanical.Equals(copyMechanical)}");
            Console.WriteLine("-----------------------------------------------------------------------------------");


            copyPen = (Pen)pen.Clone();
            copyGel = (GelPen)gel.Clone();
            copyBallpoint = (BallpointPen)ballpoint.Clone();
            copyFountain = (FountainPen)fountain.Clone();

            copyPencil = (Pencil)pencil.Clone();
            copyBlackPencilLead = (BlackPencilLeadPencil)blackPencilLead.Clone();
            copyMechanical = (MechanicalPencils)mechanical.Clone();

            Console.WriteLine("Результаты сравнения ручек и карандашей после клонирования методом Clone стандартного интерфейса ICloneable:");
            Console.WriteLine($"Результат сравнения 2-х объектов pen и copyPen: {pen.Equals(copyPen)}");
            Console.WriteLine($"Результат сравнения 2-х объектов gel и copyGel: {gel.Equals(copyGel)}");
            Console.WriteLine($"Результат сравнения 2-х объектов ballpoint и copyBallpoint: {ballpoint.Equals(copyBallpoint)}");
            Console.WriteLine($"Результат сравнения 2-х объектов fountain и copyFountain: {fountain.Equals(copyFountain)}");

            Console.WriteLine($"Результат сравнения 2-х объектов pencil и copyPencil: {pencil.Equals(copyPencil)}");
            Console.WriteLine($"Результат сравнения 2-х объектов blackPencilLead и copyBlackPencilLead: {blackPencilLead.Equals(copyBlackPencilLead)}");
            Console.WriteLine($"Результат сравнения 2-х объектов mechanical и copyMechanical: {mechanical.Equals(copyMechanical)}");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}

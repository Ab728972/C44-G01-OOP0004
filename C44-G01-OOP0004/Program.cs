namespace C44_G01_OOP0004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        #region Part 1 - Multiple Choice Questions Answers
        /*
        Answers:
        1. b) To define a blueprint for a class
        2. a) private
        3. b) No
        4. b) Yes, interfaces can inherit from multiple interfaces
        5. None (correct syntax is using colon ':')
        6. a) Yes (starting with C# 8.0)
        7. b) No, all members are implicitly public
        8. b) To provide a clear separation between interface and class members
        9. b) No, interfaces cannot have constructors
        10. c) By separating interface names with commas
        */
        #endregion
        #region Part 2 - Question 1 (IShape, ICircle, IRectangle)
        public interface IShape
        {
            double Area { get; }
            void DisplayShapeInfo();
        }

        public interface ICircle : IShape
        {
            double Radius { get; set; }
        }

        public interface IRectangle : IShape
        {
            double Length { get; set; }
            double Width { get; set; }
        }

        public class Circle : ICircle
        {
            public double Radius { get; set; }

            public double Area => Math.PI * Radius * Radius;

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Circle - Radius: {Radius}, Area: {Area:F2}");
            }
        }

        public class Rectangle : IRectangle
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public double Area => Length * Width;

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Rectangle - Length: {Length}, Width: {Width}, Area: {Area:F2}");
            }
        }
        #endregion

    }
}

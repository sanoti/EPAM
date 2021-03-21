using System;
using System.Collections.Generic;

namespace task_2 {
    class MainClass {
        public static void Main(string[] args) {
            //Circle_hollow C1 = new Circle_hollow(0, 0, 4);
            //Circle_solid C2 = new Circle_solid(1, 1, 4);

            //Console.WriteLine(C2.Get_circumference());
            //Console.WriteLine(C1.Get_circumference());
            //Console.WriteLine(C2.Get_area());

            //Triangle T = new Triangle(1, 1, -2, 4, -2, -2);
            //Console.WriteLine(T.Area());

            Paint paint = new Paint();
            Circle_hollow circle_hollow;// = new Circle_hollow();
            Circle_solid circle_solid;
            Ring ring;
            Line line;
            Triangle triangle;
            Rectangle rectangle;

            int x = 1, y, tmp1, tmp2, tmp3, tmp4 ;

            string r = "1";

            Int32.Parse(r) ;



            int test = 0;
            while(true) {
                Console.WriteLine("1. Add the figure");
                Console.WriteLine("2. Show all figures");
                Console.WriteLine("3. Clear all");
                Console.WriteLine("4. Exit");
                Console.Write("input: ");
                switch (Console.ReadLine()) {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Enter the number of figure");
                        Console.WriteLine("1. Hollow Circle");
                        Console.WriteLine("2. Solid Circle");
                        Console.WriteLine("3. Ring");
                        Console.WriteLine("4. Line");
                        Console.WriteLine("5. Triangle");
                        Console.WriteLine("6. Rectangle");
                        Console.Write("input: ");
                        switch (Console.ReadLine()) {
                            case "1": // добавление фигур
                                Console.WriteLine();
                                Console.WriteLine("Hollow Circle:");
                                Console.Write("x = ");
                                x = Int32.Parse(Console.ReadLine());
                                Console.Write("y = ");
                                y = Int32.Parse(Console.ReadLine());
                                Console.Write("rad = ");
                                tmp1 = Int32.Parse(Console.ReadLine());

                                circle_hollow = new Circle_hollow(x, y, tmp1);
                                paint.Add_Circle_hollow(circle_hollow);
                                Console.WriteLine("Hollow Circle is created");
                                Console.WriteLine();
                                break;
                            case "2":
                                Console.WriteLine();
                                Console.WriteLine("Solid Circle:");
                                Console.Write("x = ");
                                x = Int32.Parse(Console.ReadLine());
                                Console.Write("y = ");
                                y = Int32.Parse(Console.ReadLine());
                                Console.Write("rad = ");
                                tmp1 = Int32.Parse(Console.ReadLine());

                                circle_solid = new Circle_solid(x, y, tmp1);
                                paint.Add_Circle_solid(circle_solid);
                                Console.WriteLine("Solid Circle is created");
                                Console.WriteLine();
                                break;
                            case "3":
                                Console.WriteLine();
                                Console.WriteLine("Ring:");
                                Console.Write("x = ");
                                x = Int32.Parse(Console.ReadLine());
                                Console.Write("y = ");
                                y = Int32.Parse(Console.ReadLine());
                                Console.Write("outer rad = ");
                                tmp1 = Int32.Parse(Console.ReadLine());
                                Console.Write("inner rad = ");
                                tmp2 = Int32.Parse(Console.ReadLine());

                                ring = new Ring(x, y, tmp1, tmp2);
                                paint.Add_Ring(ring);
                                Console.WriteLine("Ring is created");
                                Console.WriteLine();
                                break;
                            case "4":
                                Console.WriteLine();
                                Console.WriteLine("Line:");
                                Console.Write("x1 = ");
                                x = Int32.Parse(Console.ReadLine());
                                Console.Write("y1 = ");
                                y = Int32.Parse(Console.ReadLine());
                                Console.Write("x2 = ");
                                tmp1 = Int32.Parse(Console.ReadLine());
                                Console.Write("y2 = ");
                                tmp2 = Int32.Parse(Console.ReadLine());

                                line = new Line(x, y, tmp1, tmp2);
                                paint.Add_Line(line);
                                Console.WriteLine("Line is created");
                                Console.WriteLine();
                                break;
                            case "5":
                                Console.WriteLine();
                                Console.WriteLine("Triangle:");
                                Console.Write("x1 = ");
                                x = Int32.Parse(Console.ReadLine());
                                Console.Write("y1 = ");
                                y = Int32.Parse(Console.ReadLine());
                                Console.Write("x2 = ");
                                tmp1 = Int32.Parse(Console.ReadLine());
                                Console.Write("y2 = ");
                                tmp2 = Int32.Parse(Console.ReadLine());
                                Console.Write("x3 = ");
                                tmp3 = Int32.Parse(Console.ReadLine());
                                Console.Write("y3 = ");
                                tmp4 = Int32.Parse(Console.ReadLine());

                                triangle = new Triangle(x, y, tmp1, tmp2, tmp3, tmp4);
                                paint.Add_Triangle(triangle);
                                Console.WriteLine("Triangle is created");
                                Console.WriteLine();
                                break;
                            case "6":
                                Console.WriteLine();
                                Console.WriteLine("Rectangle:");
                                Console.Write("x1 = ");
                                x = Int32.Parse(Console.ReadLine());
                                Console.Write("y1 = ");
                                y = Int32.Parse(Console.ReadLine());
                                Console.Write("x2 = ");

                                tmp1 = Int32.Parse(Console.ReadLine());
                                Console.Write("y2 = ");
                                tmp2 = Int32.Parse(Console.ReadLine());

                                rectangle = new Rectangle(x, y, tmp1, tmp2);
                                paint.Add_Rectangle(rectangle);
                                Console.WriteLine("Rectangle is created");
                                Console.WriteLine();
                                break;
                        }
                        continue;

                    case "2": // вывод всех фигур
                        Console.WriteLine();
                        if (paint.Get_Circle_hollow_list().Count > 0) {
                            for (int i = 0; i < paint.Get_Circle_hollow_list().Count; i++) {
                                Console.WriteLine($"Hollow Circle {i + 1}");
                                Console.WriteLine($"Coordinates of center: ({paint.Get_Circle_hollow(i).Get_x()}; " +
                                    $"{paint.Get_Circle_hollow(i).Get_y()})");
                                Console.WriteLine($"Radius = {paint.Get_Circle_hollow(i).Get_rad()}");
                                Console.WriteLine($"Circumference = {paint.Get_Circle_hollow(i).Get_circumference()}");
                                Console.WriteLine();
                            }
                        }
                        if (paint.Get_Circle_solid_list().Count > 0) {
                            for (int i = 0; i < paint.Get_Circle_solid_list().Count; i++) {
                                Console.WriteLine($"Solid Circle {i + 1}");
                                Console.WriteLine($"Coordinates of center: ({paint.Get_Circle_solid(i).Get_x()}; " +
                                    $"{paint.Get_Circle_solid(i).Get_y()})");
                                Console.WriteLine($"Radius = {paint.Get_Circle_solid(i).Get_rad()}");
                                Console.WriteLine($"Circumference = {paint.Get_Circle_solid(i).Get_circumference()}");
                                Console.WriteLine($"Area = {paint.Get_Circle_solid(i).Get_area()}");
                                Console.WriteLine();
                            }
                        }
                        if (paint.Get_Ring_list().Count > 0) {
                            for (int i = 0; i < paint.Get_Ring_list().Count; i++) {
                                Console.WriteLine($"Ring {i + 1}");
                                Console.WriteLine($"Coordinates of center: ({paint.Get_Ring(i).Get_x()}; " +
                                    $"{paint.Get_Ring(i).Get_y()})");
                                Console.WriteLine($"Outer radius = {paint.Get_Ring(i).Get_rad()}");
                                Console.WriteLine($"Inner radius = {paint.Get_Ring(i).Get_rad_inside()}");
                                Console.WriteLine($"Sum circumference = {paint.Get_Ring(i).Get_Sum_of_circumferences()}");
                                Console.WriteLine($"Area = {paint.Get_Ring(i).Get_area()}");
                                Console.WriteLine();
                            }
                        }
                        if (paint.Get_Line_list().Count > 0) {
                            for (int i = 0; i < paint.Get_Line_list().Count; i++) {
                                Console.WriteLine($"Line {i + 1}");
                                Console.WriteLine($"Coordinates of 1st point: ({paint.Get_Line(i).Get_x1()}; " +
                                    $"{paint.Get_Line(i).Get_y1()})");
                                Console.WriteLine($"Coordinates of 2nd point: ({paint.Get_Line(i).Get_x2()}; " +
                                    $"{paint.Get_Line(i).Get_y2()})");
                                Console.WriteLine($"Line length = {paint.Get_Line(i).Get_a()}");
                                Console.WriteLine();
                            }
                        }
                        if (paint.Get_Triangle_list().Count > 0) {
                            for (int i = 0; i < paint.Get_Triangle_list().Count; i++) {
                                Console.WriteLine($"Triangle {i + 1}");
                                Console.WriteLine($"Coordinates of 1st point: ({paint.Get_Triangle(i).Get_x1()}; " +
                                    $"{paint.Get_Triangle(i).Get_y1()})");
                                Console.WriteLine($"Coordinates of 2nd point: ({paint.Get_Triangle(i).Get_x2()}; " +
                                    $"{paint.Get_Triangle(i).Get_y2()})");
                                Console.WriteLine($"Coordinates of 3rd point: ({paint.Get_Triangle(i).Get_x3()}; " +
                                    $"{paint.Get_Triangle(i).Get_y3()})");
                                Console.WriteLine($"Perimeter = {paint.Get_Triangle(i).Perimeter()}");
                                Console.WriteLine($"Area = {paint.Get_Triangle(i).Area()}");
                                Console.WriteLine();
                            }
                        }
                        if (paint.Get_Rectangle_list().Count > 0) {
                            for (int i = 0; i < paint.Get_Rectangle_list().Count; i++) {
                                Console.WriteLine($"Rectangle {i + 1}");
                                Console.WriteLine($"Coordinates of 1st point: ({paint.Get_Rectangle(i).Get_x1()}; " +
                                    $"{paint.Get_Rectangle(i).Get_y1()})");
                                Console.WriteLine($"Coordinates of 2nd point: ({paint.Get_Rectangle(i).Get_x2()}; " +
                                    $"{paint.Get_Rectangle(i).Get_y2()})");
                                Console.WriteLine($"Coordinates of 3rd point: ({paint.Get_Rectangle(i).Get_x3()}; " +
                                    $"{paint.Get_Rectangle(i).Get_y3()})");
                                Console.WriteLine($"Coordinates of 4th point: ({paint.Get_Rectangle(i).Get_x4()}; " +
                                    $"{paint.Get_Rectangle(i).Get_y4()})");
                                if (paint.Get_Rectangle(i).Is_square()) {
                                    Console.WriteLine($"a = {paint.Get_Rectangle(i).Get_a()}");
                                }
                                else {
                                    Console.WriteLine($"a = {paint.Get_Rectangle(i).Get_a()}");
                                    Console.WriteLine($"b = {paint.Get_Rectangle(i).Get_b()}");
                                }
                                Console.WriteLine($"Perimeter = {paint.Get_Rectangle(i).Perimeter()}");
                                Console.WriteLine($"Area = {paint.Get_Rectangle(i).Area()}");
                                Console.WriteLine();
                            }
                        }
                        continue;

                    case "3": // очистка холста
                        paint.Clear_all();
                        Console.WriteLine();
                        continue;

                    case "4": // Выход;
                        Console.WriteLine("END");
                        break;

                    default:
                        continue;
                }
                break;
            }
        }
    }





    class Paint {
        private List <Circle_hollow> circle_hollow_list = new List<Circle_hollow>();
        private List<Circle_solid> circle_solid_list = new List<Circle_solid>();
        private List<Ring> ring_list = new List<Ring>();
        private List<Line> line_list = new List<Line>();
        private List<Triangle> triangle_list = new List<Triangle>();
        private List<Rectangle> rectangle_list = new List<Rectangle>();

        public void Add_Circle_hollow(Circle_hollow circle) {
            circle_hollow_list.Add(circle);
        }
        public void Add_Circle_solid(Circle_solid circle) {
            circle_solid_list.Add(circle);
        }
        public void Add_Ring(Ring ring) {
            ring_list.Add(ring);
        }
        public void Add_Line(Line line) {
            line_list.Add(line);
        }
        public void Add_Triangle(Triangle triangle) {
            triangle_list.Add(triangle);
        }
        public void Add_Rectangle(Rectangle rectangle) {
            rectangle_list.Add(rectangle);
        }


        public void Clear_all() {
            circle_hollow_list.Clear();
            circle_solid_list.Clear();
            ring_list.Clear();
            line_list.Clear();
            triangle_list.Clear();
            rectangle_list.Clear();
        }




        public Circle_hollow Get_Circle_hollow(int i) {
            return circle_hollow_list[i];
        }
        public Circle_solid Get_Circle_solid(int i) {
            return circle_solid_list[i];
        }
        public Ring Get_Ring(int i) {
            return ring_list[i];
        }
        public Line Get_Line(int i) {
            return line_list[i];
        }
        public Triangle Get_Triangle(int i) {
            return triangle_list[i];
        }
        public Rectangle Get_Rectangle(int i) {
            return rectangle_list[i];
        }

        public List<Circle_hollow> Get_Circle_hollow_list() {
            return circle_hollow_list;
        }
        public List<Circle_solid> Get_Circle_solid_list() {
            return circle_solid_list;
        }
        public List<Ring> Get_Ring_list() {
            return ring_list;
        }
        public List<Line> Get_Line_list() {
            return line_list;
        }
        public List<Triangle> Get_Triangle_list() {
            return triangle_list;
        }
        public List<Rectangle> Get_Rectangle_list() {
            return rectangle_list;
        }
    }



    class Circle_hollow { // окружность
        private int x;
        private int y;
        private int rad;
        private double circumference;

        public Circle_hollow(int x, int y, int rad) {
            Set_x(x);
            Set_y(y);
            Set_rad(rad);
        }

        public void Set_x(int x) {
            this.x = x;
        }

        public void Set_y(int y) {
            this.y = y;
        }

        public void Set_rad(int rad) {
            if (rad < 0) {
                throw new Exception("radius < 0");
            }
            this.rad = rad;
            circumference = 2 * rad * Math.PI;
        }

        public int Get_x() {
            return x;
        }

        public int Get_y() {
            return y;
        }

        public int Get_rad() {
            return rad;
        }

        public double Get_circumference() {
            return circumference;
        }
    }

    class Circle_solid : Circle_hollow { // круг
        private double area;

        public Circle_solid(int x = 0, int y = 0, int rad = 1) : base(x, y, rad) {
            Set_area();
        }

        public void Set_area() {
            area = Get_circumference() * Get_rad() / 2;
        }

        public double Get_area() {
            return area;
        }

    }

    class Ring : Circle_hollow { // кольцо
        private double area;
        private double rad_inside;


        public Ring(int x, int y, int rad, double rad_inside = 0) : base(x, y, rad) {
            Set_x(x);
            Set_y(y);
            Set_rad(rad);
            Set_rad_inside(rad_inside);
            Set_area();
        }

        public void Set_rad_inside(double rad_inside) {
            this.rad_inside = rad_inside;
        }

        public void Set_area() {
            area = Math.PI * (Get_rad() * Get_rad() - rad_inside * rad_inside); 
        }

        public double Get_area() {
            return area;
        }

        public double Get_rad_inside() {
            return rad_inside;
        }

        public double Get_Sum_of_circumferences() {
            return Get_circumference() + 2 * Get_rad_inside() * Math.PI;
        }
    }

    class Line {
        private int x1;
        private int y1;
        private int x2;
        private int y2;

        public Line(int x1 = 0, int y1 = 0, int x2 = 1, int y2 = 1) {
            Set_x1(x1);
            Set_y1(y1);
            Set_x2(x2);
            Set_y2(y2);
        }

        public void Set_x1(int x1) {
            this.x1 = x1;
        }
        public void Set_y1(int y1) {
            this.y1 = y1;
        }
        public void Set_x2(int x2) {
            this.x2 = x2;
        }
        public void Set_y2(int y2) {
            this.y2 = y2;
        }

        public double Get_a() {
            return Math.Sqrt((Get_x2() - Get_x1()) * (Get_x2() - Get_x1()) + (Get_y2() - Get_y1()) * (Get_y2() - Get_y1()));
        }

        public int Get_x1() {
            return x1;
        }
        public int Get_y1() {
            return y1;
        }
        public int Get_x2() {
            return x2;
        }
        public int Get_y2() {
            return y2;
        }
    }

    class Triangle : Line { //треугольник
        private int x3;
        private int y3;

        public Triangle(int x1 = 0, int y1 = 0, int x2 = 0, int y2 = 1, int x3 = 1, int y3 = 0) {
            Set_x1(x1);
            Set_y1(y1);
            Set_x2(x2);
            Set_y2(y2);
            Set_x3(x3);
            Set_y3(y3);
        }

        public void Set_x3(int x3) {
            this.x3 = x3;
        }
        public void Set_y3(int y3) {
            this.y3 = y3;
        }

        public double Get_a_1_2() { // a
            return Get_a();
        }
        public double Get_a_2_3() { // b
            return Math.Sqrt((Get_x3() - Get_x2()) * (Get_x3() - Get_x2()) + (Get_y3() - Get_y2()) * (Get_y3() - Get_y2()));
        }
        public double Get_a_3_1() { // c
            return Math.Sqrt((Get_x1() - Get_x3()) * (Get_x1() - Get_x3()) + (Get_y1() - Get_y3()) * (Get_y1() - Get_y3()));
        }

        public double Perimeter() { // a + b + c
            return Get_a_1_2() + Get_a_2_3() + Get_a_3_1();
        }

        public double Area() { // формула Герона
            return Math.Sqrt((Get_a_1_2() + Get_a_2_3() - Get_a_3_1()) *
                             (Get_a_1_2() - Get_a_2_3() + Get_a_3_1()) *
                             (-Get_a_1_2() + Get_a_2_3() + Get_a_3_1()) *
                             Perimeter()) / 4;
        }

        public int Get_x3() {
            return x3;
        }
        public int Get_y3() {
            return y3;
        }
    }

    class Rectangle : Line { // прямоугольник
        private int x3;
        private int y3;
        private int x4;
        private int y4;


        public Rectangle(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) {
            Set_x3();
            Set_y3();
            Set_x4();
            Set_y4();
        }

        public void Set_x3() {
            this.x3 = Get_x1();
        }
        public void Set_y3() {
            this.y3 = Get_y2();
        }
        public void Set_x4() {
            this.x4 = Get_x2();
        }
        public void Set_y4() {
            this.y4 = Get_y1();
        }

        public new double Get_a() {
            return Math.Sqrt((Get_x3() - Get_x1()) * (Get_x3() - Get_x1()) + (Get_y3() - Get_y1()) * (Get_y3() - Get_y1()));
        }

        public double Get_b() {
            return Math.Sqrt((Get_x4() - Get_x1()) * (Get_x4() - Get_x1()) + (Get_y4() - Get_y1()) * (Get_y4() - Get_y1()));
        }

        public double Get_diag() {
            return Get_a();
        }

        public double Perimeter() {
            return 4 * Get_a();
        }

        public double Area() {
            return Get_a() * Get_a();
        }

        public bool Is_square() {
            if (Get_a() == Get_b()) {
                return true;
            }
            return false;
        }

        public int Get_x3() {
            return x3;
        }
        public int Get_y3() {
            return y3;
        }
        public int Get_x4() {
            return x4;
        }
        public int Get_y4() {
            return y4;
        }

        // cos и sin можно найти через отношение Line в треугольнике, трретьей вершиной которого
        // является точка (x1;y2). Далее находим смещение по x и по y
    }


    class Square1 {
        private int x; // x центра квадрата
        private int y; // y центра квадрата
        private int a; // длина стороны

        public Square1(int x = 0, int y = 0, int a = 1) {

        }

        public void Set_x(int x) {
            this.x = x;
        }

        public void Set_y(int y) {
            this.y = y;
        }

        public double Get_left_up_x() {
            return x;
        }
    }

}

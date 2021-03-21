using System;
using System.Collections.Generic;


namespace task_2 {


    class MainClass {
        public static void Main(string[] args) {
            MasChar Test = new MasChar("Amphitheater");
            Console.WriteLine(Test.Get_String());


            //for (int i = 0; i < Test.Length(); i++) {
            //    Console.WriteLine(Test.One_char(i));
            //}
            Console.WriteLine($"Length() = {Test.Length()}");
            Console.WriteLine($"One_char(4) = {Test.One_char(4)}");
            Console.WriteLine($"Compair(\"Amphitheater\") = {Test.Compair("Amphitheater")}");
            Console.WriteLine($"Compair(\"theater\") = {Test.Compair("theater")}");
            Console.WriteLine($"Concatenation_end(\" and Coliseum\") = {Test.Concatenation_end_to_string(" and Coliseum")}");
            Console.WriteLine($"Concatenation_begin(\"Coliseum and\") = {Test.Concatenation_begin_to_string("Coliseum and ")}");
            Console.WriteLine($"Find_char(e) = {Test.Find_char('e')}");
            Console.WriteLine($"Cut(4, 6) = {Test.Cut_to_string(4, 6)}");
            Console.WriteLine($"Find_first_of(\"hi\") = {Test.Find_first_of("hi")}");
            Console.WriteLine($"Find_first_of(\"hi\", 4) = {Test.Find_first_of("hi", 4)}");
            Console.WriteLine($"Replace(11, e) = {Test.Replace_to_string(11, 'E')}");

            
        }
    }






    class MasChar {
        private string origin; //по факту он тут не нужен, но почему то хочется оставить)
        private char[] mas;

        public MasChar (string origin) {
            this.Set_String(origin);
            mas = Set_mas(origin);
        }

        private char[] Set_mas (string s) {     //преобразование строки в массив
            char[] TmpMas = new char[s.Length];
            if (TmpMas.Length == 0) {
                return TmpMas;
            }
            else {
                for (int i = 0; i < s.Length; i++) {
                    TmpMas[i] = s[i];
                }

                return TmpMas;
            }
        }

        public char[] Get_mas() {   //возвращение массива
            return mas;
        }

        public void Set_String (string origin) {    //"запись" строки
            this.origin = origin;
        }

        public string Get_String() {    //возвращение строки
            return origin;
        }

        public string To_string(char[] NewMas) {
            string res = "";
            for (int i = 0; i < NewMas.Length; i++) {
                res += NewMas[i];
            }
            return res;
        }

        public int Length() {    //длина массива/строки
            return origin.Length;
        }

        public char One_char (int i) {      //возвращение символа по позиции
            if (i < Length())
                return mas[i];
            else
                return '\0';
        }

        public bool Compair (string s) {     //сравнение
            char[] comp = Set_mas(s);
            if (Length() != comp.Length)
                return false;
            for (int i = 0; i < Length(); i++) {
                if (mas[i] != comp[i])
                    return false;
            }
            return true;
        }

        public char[] Concatenation_end (string s) {    // соединение mas + new mas
            int n = Length() + s.Length;
            char[] res = new char[n];
            for (int i = 0; i < n; i++) {
                if (i < Length()) {
                    res[i] = mas[i];
                }
                else {
                    res[i] = s[i - Length()];
                }
            }

            return res;
        }
        public string Concatenation_end_to_string (string s) {
            return To_string(Concatenation_end(s));
        }

        public char[] Concatenation_begin (string s) {  // соединение new mas + mas
            int n = Length() + s.Length;
            char[] res = new char[n];
            for (int i = 0; i < n; i++) {
                if (i < s.Length) {
                    res[i] = s[i];
                }
                else {
                    res[i] = mas[i - s.Length];
                }
            }

            return res;
        }

        public string Concatenation_begin_to_string(string s) {  // соединение new mas + mas
            return To_string(Concatenation_begin(s));
        }

        public int Find_char (char sym) {   // поиск символа и возвращение его позиции
            for (int i = 0; i < Length(); i++) {
                if (mas[i] == sym) {
                    return i;
                }
            }

            return -1;
        }

        public char[] Cut(int quantity, int start = 0) {   // возвращение части строки, начиная с позиции start
            char[] res = new char[quantity];
            for (int i = start, j = 0; j < quantity; i++, j++) {
                res[j] = mas[i];
            }

            return res;
        }

        public string Cut_to_string(int q, int start = 0) {
            return To_string(Cut(q, start));
        }

        public int Find_first_of(string s, int start = 0) {     // press F
            char[] LookingFor = Set_mas(s);
            for (int i = start; i < Length(); i++) {
                for (int j = 0; j < LookingFor.Length; j++) {
                    if (mas[i] == LookingFor[j])
                        return i;
                }
            }

            return -1;
        }


        public char[] Replace(int i, char ch) {  // замена символа на iой позиции
            char[] res = new char[Length()];
            for (int j = 0; j < Length(); j++) {
                if(j == i) {
                    res[j] = ch;
                }
                else {
                    res[j] = mas[j];
                }

            }
            return res;
        }

        public string Replace_to_string(int i, char ch) {
            return To_string(Replace(i, ch));
        }

    }
}

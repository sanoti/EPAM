using System;
using System.Collections.Generic;

namespace task_2 {
    class MainClass {
        public static void Main(string[] args) {
            Game game = new Game();

        }
    }



    class Game {
        private const int Wight = 5;
        private const int Height = 5;
        private Hero hero;
        //List<Wolf> wolfs;
        private Wolf wolf;
        private Apple apple;
        private Tree tree;
        //List<Tree> trees;
        private bool GameOver = false;
        private int score = 0;
        private Random random;

        public Game() {
            hero = new Hero(Wight / 2, Height / 2);
            tree = new Tree(random.Next(0, Wight), random.Next(0, Height));
            Add_wolf();
            Add_apple();
        }

        public void Hero_Move_Up() { // передвижение игрока вверх
            if ((hero.Get_y() < Height) && (hero.Get_x() != tree.Get_x()) && (hero.Get_y() != tree.Get_y()))
                hero.Move_Up();
        }
        public void Hero_Move_Down() { // передвижение игрока вниз
            if ((hero.Get_y() > 0) && (hero.Get_x() != tree.Get_x()) && (hero.Get_y() != tree.Get_y()))
                hero.Move_Down();
        }
        public void Hero_Move_Left() { // передвижение игрока влево
            if ((hero.Get_x() > 0) && (hero.Get_x() != tree.Get_x()) && (hero.Get_y() != tree.Get_y()))
                hero.Move_Left();
        }
        public void Hero_Move_Right() { // передвижение игрока вправо
            if ((hero.Get_y() < Wight) && (hero.Get_x() != tree.Get_x()) && (hero.Get_y() != tree.Get_y()))
                hero.Move_Right();
        }

        public void Add_apple() {
            while (apple.Get_x() == hero.Get_x() && apple.Get_y() == hero.Get_y() &&
                apple.Get_x() == wolf.Get_x() && apple.Get_y() == wolf.Get_y() &&
                apple.Get_x() == tree.Get_x() && apple.Get_y() == tree.Get_y()) {
                apple = new Apple(random.Next(0, Wight), random.Next(0, Height));
            }
        }
        public void Is_apple() {
            if (hero.Get_x() == apple.Get_x() && hero.Get_y() == apple.Get_y()) {
                score += 1;
                if (hero.Get_hp() < 3)
                    hero.Healing();
                Add_apple();
            }
        }

        public void Add_wolf() {
            while (wolf.Get_x() == hero.Get_x() && wolf.Get_y() == hero.Get_y() &&
                wolf.Get_x() == apple.Get_x() && wolf.Get_y() == apple.Get_y() &&
                wolf.Get_x() == tree.Get_x() && wolf.Get_y() == tree.Get_y()) {
                wolf = new Wolf(random.Next(0, Wight), random.Next(0, Height));
            }
        }
        public void Is_wolf() {
            if (hero.Get_x() == wolf.Get_x() && hero.Get_y() == wolf.Get_y()) {
                if (hero.Get_hp() == 1) {
                    GameOver = true;
                }
                else {
                    hero.Damaging();
                    Add_wolf();
                }
            }
        }







        public void Wolf_alg_Move() {
            if (hero.Get_y() > wolf.Get_y())
                Wolf_Move_Up();
            else
                Wolf_Move_Down();

            if (hero.Get_x() > wolf.Get_x())
                Wolf_Move_Right();
            else
                Wolf_Move_Left();
        }

        public void Wolf_Move_Up() {
            if ((wolf.Get_y() < Height) && (wolf.Get_x() != tree.Get_x()) && (wolf.Get_y() != tree.Get_y()))
                wolf.Move_Up();
        }
        public void Wolf_Move_Down() {
            if ((wolf.Get_y() > 0) && (wolf.Get_x() != tree.Get_x()) && (wolf.Get_y() != tree.Get_y()))
                wolf.Move_Down();
        }
        public void Wolf_Move_Left() {
            if ((wolf.Get_x() > 0) && (wolf.Get_x() != tree.Get_x()) && (wolf.Get_y() != tree.Get_y()))
                wolf.Move_Left();
        }
        public void Wolf_Move_Right() {
            if ((wolf.Get_y() < Wight) && (wolf.Get_x() != tree.Get_x()) && (wolf.Get_y() != tree.Get_y()))
                wolf.Move_Right();
        }

        //public void Draw() {
        //    Console.Clear();
        //    for (int i = 0; i <= Wight; i++) {
        //        Console.Write("#");
        //    }
        //    Console.WriteLine();

        //    for (int i = 0; i < Height; i++) {
        //        for (int j = 0; j < Wight; j++) {
        //            if (j == 0 || j == Wight - 1)
        //                Console.Write("#");
        //            Console.Write(" ");
        //        }
        //        Console.WriteLine();
        //    }

        //    for (int i = 0; i <= Wight; i++) {
        //        Console.Write("#");
        //    }
        //    Console.WriteLine();
        //}




        public Hero Get_Hero() {
            return hero;
        }
        public Wolf Get_wolf() {
            return wolf;
        }
        //public List<Wolf> Get_Wolf_list() {
        //    return wolfs;
        //}
        //public Wolf Get_Wolf(int i) {
        //    return wolfs[i];
        //}
        public Apple Get_Apple() {
            return apple;
        }
        //public List<Tree> Get_Tree_list() {
        //    return trees;
        //}
        //public Tree Get_Tree(int i) {
        //    return trees[i];
        //}
        public bool Get_GameOver() {
            return GameOver;
        }
        public int Get_Score() {
            return score;
        }
    }

    class Hero {
        private int x;
        private int y;
        private int Hp = 3;

        public Hero(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public void Move_Up() {
            y += 1; ;
        }
        public void Move_Down() {
            y -= 1;
        }
        public void Move_Left() {
            x -= 1;
        }
        public void Move_Right() {
            x += 1;
        }

        public void Damaging() {
            Hp -= 1;
        }
        public void Healing() {
            Hp += 1;
        }


        public int Get_x() {
            return x;
        }
        public int Get_y() {
            return y;
        }
        public int Get_hp() {
            return Hp;
        }
    }

    class Wolf {
        private int x;
        private int y;

        public Wolf(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public void Move_Up() {
            y += 1; ;
        }
        public void Move_Down() {
            y -= 1;
        }
        public void Move_Left() {
            x -= 1;
        }
        public void Move_Right() {
            x += 1;
        }



        public int Get_x() {
            return x;
        }
        public int Get_y() {
            return y;
        }
    }

    class Apple {
        private int x;
        private int y;

        public Apple(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public int Get_x() {
            return x;
        }
        public int Get_y() {
            return y;
        }
    }

    class Tree {
        private int x;
        private int y;

        public Tree(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public int Get_x() {
            return x;
        }
        public int Get_y() {
            return y;
        }
    }




}

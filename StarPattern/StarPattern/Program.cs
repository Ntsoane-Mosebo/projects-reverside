using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern
{
    class Program
    {

        public void SquareStar(int row)
        {

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        public void HallowSquare(int row)
        {

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (i == 1 || i == row || j == 1 || j == row)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }


        }



        public void RhombusStar(int row)
        {

            for (int i = 1; i <= row; i++)
            {

                for (int j = i; j < row; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= row; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }

        public void HallowRhombus(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = i; j < row; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= row; j++)
                {
                    if (i == 1 || i == row || j == 1 || j == row)
                    {
                        Console.Write("*");

                    }
                    else
                    {

                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }



        }
        public void MirrorRhombus(int size)
        {

            for (int row = 0; row < size; row++)
            {
                for (int space = size - row; space < size; space++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < size; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        public void MirroredHallow(int size)
        {


            for (int i = 1; i <= size; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                if (i == 1 || i == size)
                    for (int j = 1; j <= size; j++)
                    {
                        Console.Write("*");
                    }
                else
                {
                    for (int j = 1; j <= size; j++)
                    {
                        if (j == 1 || j == size)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }

        public void RightAngleTriangle(int row)
        {


            for (int i = 1; i < row; i++)
            {
                for (int j = i; j < row; j++)
                {
                    Console.Write("");
                }
                for (int k = 1; k < (i * 2); k++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }

        public void InvertedRightAngleTriangle(int row)
        {

            for (int i = row; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }

        public void MirrorInvertedRightAngle(int row)
        {


            for (int i = 1; i <= row; i++)
            {

                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= row; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }


        public void HallowInvertedRightAngle(int row)
        {


            for (int i = 1; i <= row; i++)
            {

                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= row; k++)
                {

                    if (i == 1 || k == i || k == row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");

                    }
                }
                Console.WriteLine();
            }

        }

        public void HallowRightAngle(int height)
        {

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 || i == 2 || i == height || j == 1 | j == i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void MirroredRightAngle(int row)
        {


            for (int i = 1; i <= row; i++)
            {

                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }

        public void HallowMirroredRightAngle(int row)
        {

            for (int i = 1; i <= row; i++)
            {

                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    // Print '*' for boundaries
                    if (i == row || k == 1 || k == i)
                    {

                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }

        public void HallowInvertedRightAngle1(int row)
        {

            for (int i = row; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    {
                        if (i == row || j == 1 || j == i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

        }

        public void PyramidStar(int row)
        {

            for (int i = 1; i < row; i++)
            {
                for (int j = i; j < row; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < (i * 2); k++)
                    Console.Write("*");
                Console.WriteLine();

            }





        }

        public void HalfDiamondStar(int length)
        {

            int columns = 1;
            for (int i = 1; i < length * 2; i++)
            {

                for (int j = 1; j <= columns; j++)
                {

                    Console.Write("*");
                }
                if (i < length)
                {
                    columns++;
                }
                else
                {
                    columns--;
                }
                Console.WriteLine();
            }

        }

        public void MirroredHalfDiamond(int length)
        {

            int spaces = length - 1;
            int stars = 1;
            for (int i = 1; i < length * 2; i++)
            {
                Console.Write(" ");
                for (int j = 1; j <= spaces; j++)
                    Console.Write(" ");
                for (int j = 1; j <= stars; j++)
                    Console.Write("*");


                //Console.WriteLine(" ");

                if (i < length)
                {
                    stars++;
                    spaces--;
                }
                else
                {
                    stars--;
                    spaces++;
                }
                Console.WriteLine();
            }

        }

        public void HollowPyramid(int length)
        {
            int i, j;
            for (i = length; i >= 1; i--)
            {
                for (j = i; j < length; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= (2 * i - 1); j++)
                {
                    if (i == length || j == 1 || j == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }

        }
        public void HallowPyramid(int rows)
        {
            int i, star = 0, space;
            for (i = 1; i < rows; i++)
            {
                for (space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");

                }
                while (star != (2 * i - 1))
                {
                    if (star == 0 || star == 2 * i - 2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                    star++;
                }
                star = 0;
                Console.WriteLine();
            }
            for (i = 0; i < 2 * rows - 1; i++)
            {
                Console.Write("*");

            }


        }

        public void HallowRightAngleTriangle(int rows)
        {
            int i, star = 0, space;
            for (i = 1; i < rows; i++)
            {
                for (space = 1; space <= rows - i; space++)
                {
                    Console.Write("");

                }
                while (star != (2 * i - 1))
                {
                    if (star == 0 || star == 2 * i - 2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                    star++;
                }
                star = 0;
                Console.WriteLine();
            }
            for (i = 0; i < 2 * rows - 2; i++)
            {
                Console.Write("*");

            }
        }
        public void InvertedPyramid(int rows, int cols)
        {
            int i, j, k;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < i; j++)
                {

                    Console.Write(" ");

                }
                for (k = 0; k < cols; k++)
                {
                    Console.Write(" * ");
                }
                cols--;
                Console.WriteLine();
            }

        }

    }

    class ProgramTest
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the number of rows");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SQUARE STAR PATTERN");
            Console.WriteLine("=================================");


            p.SquareStar(row);


            Console.WriteLine("HALLOW SQUARE PATTERN");
            Console.WriteLine("=================================");
            p.HallowSquare(row);

            Console.WriteLine("THE STAR PATTERN OF RHOMBUS");
            Console.WriteLine("=================================");
            p.RhombusStar(row);


            Console.WriteLine("PRINTING HALLOW RHOMBUS");
            Console.WriteLine("=================================");
            p.HallowRhombus(row);



            Console.WriteLine(" MIRRORED RHOMBUS STAR PATTERN");
            Console.WriteLine("=================================");
            p.MirrorRhombus(row);



            Console.WriteLine(" MIRRORED HALLOW RHOMBUS STAR PATTERN");
            Console.WriteLine("=================================");
            p.MirroredHallow(row);


            Console.WriteLine(" RIGHT ANGLE  TRIANGLE PATTERN");
            Console.WriteLine("=================================");
            p.RightAngleTriangle(row);


            Console.WriteLine(" INVERTED RIGHT ANGLE  TRIANGLE PATTERN");
            Console.WriteLine("=================================");
            p.InvertedRightAngleTriangle(row);



            Console.WriteLine(" MIRROR INVERTED RIGHT ANGLE  TRIANGLE PATTERN");
            Console.WriteLine("=================================");
            p.MirrorInvertedRightAngle(row);

            Console.WriteLine(" HALLOW INVERTED RIGHT ANGLE  TRIANGLE PATTERN");
            Console.WriteLine("=================================");
            p.HallowInvertedRightAngle(row);


            Console.WriteLine(" HALLOW  RIGHT ANGLE  TRIANGLE PATTERN");
            Console.WriteLine("=================================");
            p.HallowRightAngle(row);

            Console.WriteLine(" MIRRORED RIGHT ANGLE  TRIANGLE PATTERN");
            Console.WriteLine("=================================");
            p.MirroredRightAngle(row);


            Console.WriteLine(" HALLOW MIRRROW RIGHT ANGLE TRINAGLE");
            Console.WriteLine("=================================");
            p.HallowMirroredRightAngle(row);

            Console.WriteLine(" HALLOW MIRRORED RIGHT ANGLE TRINAGLE");
            Console.WriteLine("=================================");
            p.HallowInvertedRightAngle1(row);

            Console.WriteLine(" PYRAMID STAR PATTERN");
            Console.WriteLine("=================================");
            p.PyramidStar(row);


            Console.WriteLine(" HALF DIAMOND STAR");
            Console.WriteLine("=================================");
            p.HalfDiamondStar(row);


            Console.WriteLine(" MIRRRORED HALF DIAMOND STAR");
            Console.WriteLine("=================================");
            p.MirroredHalfDiamond(row);

            Console.WriteLine(" HALLOW INVERTED PYRAMID STAR ");
            Console.WriteLine("=================================");
            p.HollowPyramid(row);


            Console.WriteLine(" HALLOW  PYRAMID STAR ");
            Console.WriteLine("=================================");
            p.HallowPyramid(row);

            Console.WriteLine(" HALLOW  RIGHT ANGLE TRIANGLE STAR ");
            Console.WriteLine("=================================");
            p.HallowRightAngleTriangle(row);




            Console.WriteLine(" HALLOW  RIGHT ANGLE TRIANGLE STAR ");
            Console.WriteLine("=================================");


            Console.WriteLine("Enter the length or number of rows");
            int rows = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the length or number of columns");
            int cols = Convert.ToInt16(Console.ReadLine());
            p.InvertedPyramid(rows, cols);

        }
    }
}

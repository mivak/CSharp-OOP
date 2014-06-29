namespace DefiningClassesPart2
{
    using System;
    using System.Text;

    public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private const int DefaultSize = 8;
        private readonly T[,] matrix;

        public Matrix()
        {
            this.matrix = new T[DefaultSize, DefaultSize];
        }

        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
            this.Row = matrix.GetLength(0);
            this.Col = matrix.GetLength(1);
        }
        
        public Matrix(int row, int col)
        {
            if (row < 0 || col < 0)
            {
                throw new ArgumentOutOfRangeException("Negative row or col value");
            }
            else
            {
                this.Row = row;
                this.Col = col;
                this.matrix = new T[row, col];
            }
        }

        public int Row { get; private set; }
        
        public int Col { get; private set; }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                if (this.Row < row || this.Col < col || row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }

                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row == second.Row && first.Col == second.Col)
            {
                Matrix<T> tempArr = new Matrix<T>(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Col; j++)
                    {
                        checked
                        {
                            tempArr[i, j] = (dynamic)first[i, j] + second[i, j];
                        }
                    }
                }

                return tempArr;
            }
            else
            {
                throw new Exception("The given matrixes are not with the same col and row size");
            }
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row == second.Row && first.Col == second.Col)
            {
                Matrix<T> tempArr = new Matrix<T>(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Col; j++)
                    {
                        checked
                        {
                            tempArr[i, j] = (dynamic)first[i, j] - second[i, j];
                        }
                    }
                }

                return tempArr;
            }
            else
            {
                throw new Exception("The given matrixes are not with the same col or row size");
            }
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Col == second.Row && first.Row > 0 && first.Col > 0 && second.Col > 0)
            {
                Matrix<T> final = new Matrix<T>(first.Row, second.Col);
                for (int i = 0; i < final.Row; i++)
                {
                    for (int j = 0; j < final.Col; j++)
                    {
                        final[i, j] = (dynamic)0;
                        for (int k = 0; k < first.Col; k++)
                        {
                            checked
                            {
                                final[i, j] += (dynamic)first[i, k] + second[k, j];
                            }
                        }
                    }
                }

                return final;
            }
            else
            {
                throw new Exception("Row in the first matrix and col in the second matrix are not with the same size");
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            int zeroChecker = 0;
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == zeroChecker)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            int zeroChecker = 0;
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == zeroChecker)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    builder.Append(this.matrix[i, j] + " ");
                }

                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}
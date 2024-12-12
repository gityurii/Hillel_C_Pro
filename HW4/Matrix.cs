namespace HW4;

public class Matrix
{
    public int Rows { get; }
    public int Columns { get; }
    public double[,] Data { get; }

    public Matrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        Data = new double[rows, columns];
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Columns != b.Columns)
            throw new InvalidOperationException("Matrices must have the same dimensions to add.");

        var result = new Matrix(a.Rows, a.Columns);
        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Columns; j++)
            {
                result.Data[i, j] = a.Data[i, j] + b.Data[i, j];
            }
        }
        return result;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Columns != b.Columns)
            throw new InvalidOperationException("Matrices must have the same dimensions to subtract.");

        var result = new Matrix(a.Rows, a.Columns);
        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Columns; j++)
            {
                result.Data[i, j] = a.Data[i, j] - b.Data[i, j];
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Columns != b.Rows)
            throw new InvalidOperationException("Matrix multiplication requires the number of columns in the first matrix to equal the number of rows in the second matrix.");

        var result = new Matrix(a.Rows, b.Columns);
        for (int i = 0; i < result.Rows; i++)
        {
            for (int j = 0; j < result.Columns; j++)
            {
                for (int k = 0; k < a.Columns; k++)
                {
                    result.Data[i, j] += a.Data[i, k] * b.Data[k, j];
                }
            }
        }
        return result;
    }

    public static bool operator ==(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Columns != b.Columns)
            return false;

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Columns; j++)
            {
                if (a.Data[i, j] != b.Data[i, j])
                    return false;
            }
        }
        return true;
    }

    public static bool operator !=(Matrix a, Matrix b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        if (obj is Matrix other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        int hash = 17;
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                hash = hash * 23 + Data[i, j].GetHashCode();
            }
        }
        return hash;
    }
}
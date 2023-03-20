
// класс с методами расширения
static class MatrixExt
{
    // extension method to get the number of rows of a matrix
    public static int RowsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(0) + 1;
    }

    // extension method to get the number of matrix columns
    public static int ColumnsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(1) + 1;
    }
}

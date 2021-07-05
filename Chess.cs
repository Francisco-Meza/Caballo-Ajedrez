using System;
//---------------------------- SUPER CLASE ------------------------------------------------
abstract class Chess
{
    private int rows,columns;
    private string color;//--color
    private string piece;//--Pieza que sera
    private int x, y;// Cordenadas
    private int[,] board;//--Tablero
    public Chess()
    {
        this.rows = 8;
        this.columns = 8;
        board = new int[rows,columns];
    }
    public abstract string PossibleToMove();//--Metodo abstracto-- aun no se como se mueve la pieza
    public Boolean AssignOnBoard(int x, int y)//--Asigna la pieza dentro del tablero
    {
        this.x = x;
        this.y = y;
        if(this.x < 1 || this.x > 8 || this.y < 1 || this.y > 8)
        {
            return false;
        }
        return true;
    }
}

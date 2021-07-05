
//-------------------------- CLASE DERIVADA -------------------------------------------
class Pawn:Chess, IPiece
{
    private string[] coordinates;
    private string color, piece;
    private int x, y;
    private int n;//-- indice de numero de posibles soluciones
    public Pawn(string piece, string color, int x, int y)
    {
        this.piece = piece;
        this.color = color;
        this.x = x;
        this.y = y;
    }
    //---------- Metodos de la interface--------------------------------------------------
    public int GetX()
    {
        return this.x;
    }
    public int GetY()
    {
        return this.y;
    }
    //-------------Metodos abstractos-------------------------------------------------------
    public override string PossibleToMove()//-- Se sobrescribe el metodo abstracto de la forma de mover
    {
        string ans = "Las posibles soluciones son:\n";
        n =-1;
        coordinates = new string[8];
        if (this.AssignOnBoard(x+2,y+1))//-- Asigna 1/8 movimientos
        {
            ans += $"({x + 2},{y + 1})\n";
            coordinates[n+1] = $"({x + 2},{y + 1})";
        }
        if (this.AssignOnBoard(x + 1, y + 2))//-- Asigna 2/8 movimientos
        {
            ans += $"({x + 1},{y + 2})\n";
            coordinates[n+1] = $"({x + 1},{y + 2})";
        }
        if (this.AssignOnBoard(x - 2, y - 1))//-- Asigna 3/8 movimientos
        {
            ans += $"({x - 2},{y - 1})\n";
            coordinates[n+1] = $"({x - 2},{y - 1})";
        }
        if (this.AssignOnBoard(x - 1, y - 2))//-- Asigna 4/8 movimientos
        {
            ans += $"({x - 1},{y - 2})\n";
            coordinates[n+1] = $"({x - 1},{y - 2})";
        }
        if (this.AssignOnBoard(x + 1, y - 2))//-- Asigna 5/8 movimientos
        {
            ans += $"({x + 1},{y - 2})\n";
            coordinates[n+1] = $"({x + 1},{y - 2})";
        }
        if (this.AssignOnBoard(x + 2, y - 1))//-- Asigna 6/8 movimientos
        {
            ans += $"({x + 2},{y - 1})\n";
            coordinates[n+1] = $"({x + 2},{y - 1})";
        }
        if (this.AssignOnBoard(x - 1, y + 2))//-- Asigna 7/8 movimientos
        {
            ans += $"({x - 1},{y + 2})\n";
            coordinates[n + 1] = $"({x - 1},{y + 2})";
        }
        if (this.AssignOnBoard(x - 2, y + 1))//-- Asigna 8/8 movimientos
        {
            ans += $"({x - 2},{y + 1})\n";
            coordinates[n + 1] = $"({x - 2},{y + 1})";
        }
        return ans;
    }
}

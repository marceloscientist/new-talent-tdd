namespace NewTalent;

public class Calculadora
{
    private List<String> historicos;
    private String data;

    public Calculadora(string data)
    {
        historicos = new List<string>();
        this.data = data;
    }
    public int somar(int val1, int val2)
    {
        int res = val1 + val2;
        this.historicos.Insert(0,"Res: "+ res + ". Data: " +data);
        return res;
    }
    
    public int subtrair(int val1, int val2)
    {
        int res = val1 - val2;
        this.historicos.Insert(0,"Res: "+ res + ". Data: " +data);
        return res;
    }
    public int multiplicar(int val1, int val2)
    {
        int res = val1 * val2;
        this.historicos.Insert(0,"Res: "+ res + ". Data: " +data);
        return res;
    }
    public int dividir(int val1, int val2)
    {
        if (val2 == 0)
        {
            throw new DivideByZeroException();
        }
        int res = val1 / val2;
        this.historicos.Insert(0,"Res: "+ res + ". Data: " +data);
        return res;
    }
    public List<String> historico()
    {
        historicos.RemoveRange(3, historicos.Count - 3);
        return historicos;
    }
}
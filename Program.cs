namespace Making_a_Die_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1;
            Die die2;
            die1 = new Die();
            die2 = new Die();
            die1.RollDie();
            die1.DrawRoll();

            die2.RollDie();
            die2.DrawRoll();
            Console.ReadLine();
        }
    }
}

namespace LesInterfaces
{
    public interface IAddition
    {
        int Nb1 { get; set; }
        int Nb2 { get; set; }

        void Addition();
    }

    interface ISoustraction
    {
        int Nb1 { get; set; }
        int Nb2 { get; set; }

        void Soustraction();
    }
}
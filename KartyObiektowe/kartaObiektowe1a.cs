using System;
class Rower{
  private Producent producent;
  private string kolor;
  private Material material;
  public void jedz(){
      Console.WriteLine("jedź");
  }
  public string getKolor()
      {
          return kolor;
      }
      public void setKolor(string akolor)
      {
          this.kolor = akolor;
      }
  public void setMaterial(Material amaterial){
      this.material = amaterial;
  }
  public Rower(Producent aproducent){
    this.producent = aproducent;
  }
}
class Producent
{
    public string nazwa;
    private string nip;
    public string getNazwa()
    {
        return nazwa;
    }
    public void setNazwa(string anazwa)
    {
        this.nazwa = anazwa;
    }
    public string getNip()
    {
        return nip;
    }
}
class Material
{
    private string typ;
    private int id;
    private double cena;
    public string getTyp()
      {
          return typ;
      }
      public void setTyp(string atyp)
      {
          this.typ = atyp;
      }
    public double getCena(){
          return cena;
    }
    public void setId(int aid){
        this.id = aid;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Producent p1 = new Producent();
        Material m1 = new Material();
        Rower r1 = new Rower(p1);
        r1.setKolor("czerwony");
        m1.setId(2);
    }
}

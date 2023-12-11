namespace DISample;

public interface IFormFactory
{
    T CreateForm<T>() where T : Form;
}
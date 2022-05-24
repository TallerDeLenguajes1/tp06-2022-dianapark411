public class Calculadora{
    public double resultado;

    public Calculadora(double valorInicial){
        resultado = valorInicial;
    }

    public void Sumar(double valor){
        resultado+=valor;
    }

    public void Restar(double valor){
        resultado-=valor;
    }

    public void Multiplicar(double valor){
        resultado*=valor;
    }

    public void Dividir(double valor){
        resultado/=valor;
    }
    public void Limpiar(){
        resultado=0;
    }
}
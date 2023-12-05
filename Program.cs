// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Solucion 1.1

static int obtenerDiasNecesarios(int diaSam, int diaKelly, int differencia){
    if (diaSam < 1 || diaKelly < 100 || differencia < 0 || differencia < 100)
    {
        return -1;
    }
    int solvedSam = differencia;
    int solvedKelly = 0;
    int DiasNecesarios = 0;
    while (solvedSam >= solvedKelly)
    {
        solvedSam += diaSam;
        solvedKelly += diaKelly;
        DiasNecesarios++;
    }
    return DiasNecesarios;
}
Console.WriteLine(obtenerDiasNecesarios(4,100,1));
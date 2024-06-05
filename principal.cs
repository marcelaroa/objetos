using libreriaClases;

namespace otraLibreria{

    class principal{
        static void Main(){

            string nombre;

            silla pepe = new silla();
            silla Roberta = new silla();

            pepe.Color = "Rojo";
            pepe.material = "Plastico";
            Roberta.Color = "celeste";
            Roberta.material ="hierro";
            
            pepe.mover();

          

            Console.WriteLine(  pepe.crear());
            Console.WriteLine(pepe.Color);
            Console.WriteLine(pepe.material);

            Console.WriteLine(Roberta.crear());
            Console.WriteLine(Roberta.Color);
            Console.WriteLine(Roberta.material);
        }
    }
}
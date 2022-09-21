using System;
using System.IO;


// Implemento la operación prolimórfica (patrón GRASP) PrintTicket para no tener que preguntar por el destino de 
// la impresión del ticket.

namespace Full_GRASP_And_SOLID.Library{
public interface IPrinter
{
    void PrintTicket(Recipe recipe);
}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace let_no_LINQ.models
{
    public record Order(string numero, List<OrderLine> OrderLines);

    public record OrderLine(string produto, int quantidade, decimal preco);
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private LojaContext _context;

        public ProdutoController(LojaContext context) => _context = context;
    }

    [HttpGet]
    public ActionResulst<IList<Produto>> Get()
    {
        return _context.Produtos.toList();
    }

    internal class _context
    {
    }

    [HttpGet("{id}")]
    public ActionResult<Produto> Get(int id)
    {
        var produto = _context.Produtos.Find(id);
        if (produto == null)
            return NotFoundResult();
        return produto;
    }

    [HttpPost]
    public ActionResult<Produto> Create(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
        return CreatedAtAction("Get",
            new { id = produto.ProdutoId }, produto);
    }

    [HttpPut("{id}")]
    public ActionResult<Produto> Put(Produto produto, int id)
    {
        if (_context.Produtos.Find(id) == null)
            return NotFound();
        produto.ProdutoId = id;
        _context.Produto.Update(produto);
        _context.saveChanges();
        return NoContentResult();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var produto = _context.Produtos.Find(id);
        _context.Produtos.Remove(produto);
        _context.SaveChanges();
        return NoContentResult
    }
    
}

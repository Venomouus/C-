{
  @Model.Produto 
}

<body>
  <h1>Tipo de Produto -Cadastrar</h1>
  <!--formulário HTML com Tag Helpers-->
    <form asp-action="Cadastrar" asp-controller="TipoProduto" method="post">
    
   <div class="form-horizontal"><hr />
    <div class="form-group">
      <label>Descrição</label>
    <div class="descricao"><!--Caixa de Texto -->
      <input asp-for="DescricaoTipo" />
    </div>
  </div>
  
  <div class="form-group">
    <label>Comercializado</label>
    <div class="checkbox">
      <!--CheckBox --><input asp-for="Comercializado" />
    </div>
  </div>
  
  <div class="form-group">
    <div class="descricao">
      <input type="reset" value="Limpar" class="btn" />
  
  <input type="submit" value="Cadastrar" class="btn" />
    </div>
  </div>
    <hr />
  </div>
    </form>
    
      <div>
        <a asp-controller="TipoProduto" asp-action="Index">Voltar</a> 
      </div>
   </body>
 </html>
